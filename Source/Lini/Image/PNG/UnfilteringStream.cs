using Lini.Miscellaneous;
using Lini.Stream;

namespace Lini.Image.PNG;

internal class UnfilteringStream : IWriteStream<byte>
{
    /// <summary>
    /// A position of -1 means that the filter method byte has not been read.
    /// </summary>
    private int CurrentPosInLine { get; set; }

    /// <summary>
    /// The filter method in this line.
    /// </summary>
    private byte CurrentFilterMethod { get; set; }

    /// <summary>
    /// Byte count for one scanline
    /// </summary>
    private int ByteCountScanline { get; set; }

    /// <summary>
    /// The current line count. Currently only used to determine if this is the first line.
    /// </summary>
    private int CurrentLineCount { get; set; }

    /// <summary>
    /// A buffer for the last line - this is needed in unfiltering.
    /// </summary>
    private byte[] LastLineArr { get; set; }

    /// <summary>
    /// The buffer for the current line. This is only set to <see cref="CurrentPosInLine"/>.
    /// </summary>
    private byte[] CurrentLineArr { get; set; }

    /// <summary>
    /// How many bytes should be skipped back to read the values of corresponding values in unfiltering.
    /// </summary>
    private int PixelByteOffset { get; set; }

    private IWriteStream<byte> Target { get; init; }



    internal UnfilteringStream(PixelType pixelType, int entriesPerLine, IWriteStream<byte> target)
    {
        Target = target;
        ByteCountScanline = (int)Math.Ceiling(entriesPerLine * pixelType.RequiredBits / 8f);
        LastLineArr = new byte[ByteCountScanline];
        CurrentLineArr = new byte[ByteCountScanline];
        CurrentPosInLine = -1;
        CurrentLineCount = 0;
        CurrentFilterMethod = byte.MaxValue;
        PixelByteOffset = pixelType.RequiredBytes;
    }

    /// <summary>
    /// Implemented after https://www.w3.org/TR/png/#9Filter-type-4-Paeths
    /// </summary>
    private static byte PaethPredictor(byte a, byte b, byte c)
    {
        // let the compiler figure out the best types and inlining
        var p = a + b - c;
        var pa = Math.Abs(p - a);
        var pb = Math.Abs(p - b);
        var pc = Math.Abs(p - c);
        if (pa <= pb && pa <= pc) return a;
        else if (pb <= pc) return b;
        else return c;
    }

    public void Write(ReadOnlySpan<byte> work)
    {
        // keeps track of where we are in the span
        int workPosition = 0;

        Span<byte> CurrentSpan = CurrentLineArr;
        Span<byte> LastSpan = LastLineArr;

        // while there is still work to be done
        while (workPosition < work.Length)
        {

            // check if the current line has a filter method
            if (CurrentPosInLine == -1)
            {
                CurrentFilterMethod = work[workPosition];
                CurrentPosInLine++;
                workPosition++;
            }

            // do as much work as possible in this line
            int toDoInThisLine = Math.Min(work.Length - workPosition, ByteCountScanline - CurrentPosInLine);


            // fill items in current line according to filter method.
            if (CurrentFilterMethod == 0 || (CurrentFilterMethod == 2 && CurrentLineCount == 0))
            {
                // filter method 2 in first line is identical to filter method 0
                // just copy values
                Span<byte> toWrite = CurrentSpan.Slice(CurrentPosInLine, toDoInThisLine);
                work.Slice(workPosition, toDoInThisLine).CopyTo(toWrite);
                workPosition += toDoInThisLine;
                CurrentPosInLine += toDoInThisLine;
            }
            else if (CurrentFilterMethod == 1)
            {
                // this is sub: this decoding is dependent on the pixel to the left, handle the first pixel differently.
                while (CurrentPosInLine < PixelByteOffset)
                {
                    CurrentSpan[CurrentPosInLine] = work[workPosition];
                    CurrentPosInLine++;
                    workPosition++;
                    toDoInThisLine--;
                }
                for (int i = workPosition; i < workPosition + toDoInThisLine; i++)
                {
                    // TODO: this seems to be inconvenient. Is there a way to do simd on bytes?
                    CurrentSpan[CurrentPosInLine] = (byte)(work[i] + CurrentSpan[CurrentPosInLine - PixelByteOffset]);
                    CurrentPosInLine++;
                }
                workPosition += toDoInThisLine;
            }
            else if (CurrentFilterMethod == 2)
            {
                // up filter method
                // don't handle edge case of upper line: done in filter method 0
                for (int i = workPosition; i < workPosition + toDoInThisLine; i++)
                {
                    CurrentSpan[CurrentPosInLine] = (byte)(work[i] + LastSpan[CurrentPosInLine]);
                    CurrentPosInLine++;
                }
                workPosition += toDoInThisLine;
            }
            else if (CurrentFilterMethod == 3)
            {
                // average between pixel byte prior in this scanline and the byte in the last line above.
                // adding those two values is done in at least 9 bytes! Then the value is divided by 2, can be done by shifting
                if (CurrentLineCount == 0)
                {
                    while (CurrentPosInLine < PixelByteOffset)
                    {
                        CurrentSpan[CurrentPosInLine] = work[workPosition];
                        CurrentPosInLine++;
                        workPosition++;
                        toDoInThisLine--;
                    }
                    for (int i = workPosition; i < workPosition + toDoInThisLine; i++)
                    {
                        CurrentSpan[CurrentPosInLine] = (byte)(work[i] + (CurrentSpan[CurrentPosInLine - PixelByteOffset] >> 1));
                        CurrentPosInLine++;
                    }
                    workPosition += toDoInThisLine;
                }
                else
                {
                    while (CurrentPosInLine < PixelByteOffset)
                    {
                        CurrentSpan[CurrentPosInLine] = (byte)(work[workPosition] + (LastSpan[CurrentPosInLine] >> 1));
                        CurrentPosInLine++;
                        workPosition++;
                        toDoInThisLine--;
                    }
                    for (int i = workPosition; i < workPosition + toDoInThisLine; i++)
                    {
                        CurrentSpan[CurrentPosInLine] = (byte)(work[i] + ((CurrentSpan[CurrentPosInLine - PixelByteOffset] + LastSpan[CurrentPosInLine]) >> 1));
                        CurrentPosInLine++;
                    }
                    workPosition += toDoInThisLine;
                }
            }
            else if (CurrentFilterMethod == 4)
            {
                // Paeth predictor - selects a probably optimal value from three possible surrounding bytes
                if (CurrentLineCount == 0)
                {
                    // no upper line, handle different
                    while (CurrentPosInLine < PixelByteOffset)
                    {
                        // Paeth is 0 if no surruonding pixels
                        CurrentSpan[CurrentPosInLine] = work[workPosition];
                        workPosition++;
                        CurrentPosInLine++;
                        toDoInThisLine--;
                    }
                    for (int i = workPosition; i < workPosition + toDoInThisLine; i++)
                    {
                        CurrentSpan[CurrentPosInLine] = (byte)(work[i] + PaethPredictor(CurrentSpan[CurrentPosInLine - PixelByteOffset], 0, 0));
                        CurrentPosInLine++;
                    }
                    workPosition += toDoInThisLine;
                }
                else
                {
                    while (CurrentPosInLine < PixelByteOffset)
                    {
                        CurrentSpan[CurrentPosInLine] = (byte)(work[workPosition] + PaethPredictor(0, LastSpan[CurrentPosInLine], 0));
                        workPosition++;
                        CurrentPosInLine++;
                        toDoInThisLine--;
                    }
                    for (int i = workPosition; i < workPosition + toDoInThisLine; i++)
                    {
                        CurrentSpan[CurrentPosInLine] = (byte)(work[i] + PaethPredictor(
                            CurrentSpan[CurrentPosInLine - PixelByteOffset], LastSpan[CurrentPosInLine],
                            LastSpan[CurrentPosInLine - PixelByteOffset]));
                        CurrentPosInLine++;
                    }
                    workPosition += toDoInThisLine;
                }

            }
            //unknown filter method
            else
            {
                Logger.Warn($"Encountered unkown filter method {CurrentFilterMethod}. Continuing, but unexpected behaviour.", Logger.Source.User);
                return;
            }


            // check for full row and maybe copy to memory, update last line...
            if (CurrentPosInLine >= ByteCountScanline)
            {
                // juggle arrays to avoid reallocating and filling with 0s.
                // thus, no array needs to be cleared. CurrentLineArr contains junk after this
                // but as long as the rest of the algorithm works correctly and doesn't forward access
                // the array, it's fine.
                (CurrentLineArr, LastLineArr) = (LastLineArr, CurrentLineArr);
                Span<byte> tempSpan = LastSpan;
                LastSpan = CurrentSpan;
                CurrentSpan = tempSpan;

                CurrentPosInLine = -1;
                CurrentLineCount++;
                Target.Write(new Span<byte>(LastLineArr));
            }
        }
    }
}
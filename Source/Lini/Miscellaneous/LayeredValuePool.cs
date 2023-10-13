using System.Runtime.InteropServices;

namespace Lini.Miscellaneous;

public class LayeredValuePool<T> where T : struct
{
    public class Layer
    {
        public const int ELEMENTS = 256;

        public int Count { get; private set; }
        // private readonly BackingStruct Array;
        private readonly T[] Array;

        public Layer()
        {
            Array = new T[ELEMENTS];
            Count = 0;
        }

        public bool IsFilledCompletely => Count == ELEMENTS;
        public bool HasFreeSlot => Count < ELEMENTS;

        public ref T this[int index] => ref Array[index];


        public void Free(int index)
        {
            if (index == Count - 1)
            {
                Count--;
                return;
            }

            Array[index] = Array[Count - 1];
            Count--;
        }

        public void Replace(in T item, int index)
        {
            Array[index] = item;
        }

        public bool TryFillAny(in T item, out int index)
        {
            if (IsFilledCompletely)
            {
                index = -1;
                return false;
            }

            index = Count++;
            Array[index] = item;

            return true;
        }


        // TODO: use inline arrays when .NET 8 is released
        // [System.Runtime.CompilerServices.InlineArray(COUNT)]
        [StructLayout(LayoutKind.Sequential)]
        private struct BackingStruct
        {

            public Span<T> AsSpan()
            {
                return MemoryMarshal.CreateSpan(ref Item0, ELEMENTS);
            }
            public ReadOnlySpan<T> AsReadOnlySpan()
            {
                return MemoryMarshal.CreateReadOnlySpan(ref Item0, ELEMENTS);
            }


            public T Item0;
            public T Item1;
            public T Item2;
            public T Item3;
            public T Item4;
            public T Item5;
            public T Item6;
            public T Item7;
            public T Item8;
            public T Item9;
            public T Item10;
            public T Item11;
            public T Item12;
            public T Item13;
            public T Item14;
            public T Item15;
            public T Item16;
            public T Item17;
            public T Item18;
            public T Item19;
            public T Item20;
            public T Item21;
            public T Item22;
            public T Item23;
            public T Item24;
            public T Item25;
            public T Item26;
            public T Item27;
            public T Item28;
            public T Item29;
            public T Item30;
            public T Item31;
            public T Item32;
            public T Item33;
            public T Item34;
            public T Item35;
            public T Item36;
            public T Item37;
            public T Item38;
            public T Item39;
            public T Item40;
            public T Item41;
            public T Item42;
            public T Item43;
            public T Item44;
            public T Item45;
            public T Item46;
            public T Item47;
            public T Item48;
            public T Item49;
            public T Item50;
            public T Item51;
            public T Item52;
            public T Item53;
            public T Item54;
            public T Item55;
            public T Item56;
            public T Item57;
            public T Item58;
            public T Item59;
            public T Item60;
            public T Item61;
            public T Item62;
            public T Item63;
            public T Item64;
            public T Item65;
            public T Item66;
            public T Item67;
            public T Item68;
            public T Item69;
            public T Item70;
            public T Item71;
            public T Item72;
            public T Item73;
            public T Item74;
            public T Item75;
            public T Item76;
            public T Item77;
            public T Item78;
            public T Item79;
            public T Item80;
            public T Item81;
            public T Item82;
            public T Item83;
            public T Item84;
            public T Item85;
            public T Item86;
            public T Item87;
            public T Item88;
            public T Item89;
            public T Item90;
            public T Item91;
            public T Item92;
            public T Item93;
            public T Item94;
            public T Item95;
            public T Item96;
            public T Item97;
            public T Item98;
            public T Item99;
            public T Item100;
            public T Item101;
            public T Item102;
            public T Item103;
            public T Item104;
            public T Item105;
            public T Item106;
            public T Item107;
            public T Item108;
            public T Item109;
            public T Item110;
            public T Item111;
            public T Item112;
            public T Item113;
            public T Item114;
            public T Item115;
            public T Item116;
            public T Item117;
            public T Item118;
            public T Item119;
            public T Item120;
            public T Item121;
            public T Item122;
            public T Item123;
            public T Item124;
            public T Item125;
            public T Item126;
            public T Item127;
            public T Item128;
            public T Item129;
            public T Item130;
            public T Item131;
            public T Item132;
            public T Item133;
            public T Item134;
            public T Item135;
            public T Item136;
            public T Item137;
            public T Item138;
            public T Item139;
            public T Item140;
            public T Item141;
            public T Item142;
            public T Item143;
            public T Item144;
            public T Item145;
            public T Item146;
            public T Item147;
            public T Item148;
            public T Item149;
            public T Item150;
            public T Item151;
            public T Item152;
            public T Item153;
            public T Item154;
            public T Item155;
            public T Item156;
            public T Item157;
            public T Item158;
            public T Item159;
            public T Item160;
            public T Item161;
            public T Item162;
            public T Item163;
            public T Item164;
            public T Item165;
            public T Item166;
            public T Item167;
            public T Item168;
            public T Item169;
            public T Item170;
            public T Item171;
            public T Item172;
            public T Item173;
            public T Item174;
            public T Item175;
            public T Item176;
            public T Item177;
            public T Item178;
            public T Item179;
            public T Item180;
            public T Item181;
            public T Item182;
            public T Item183;
            public T Item184;
            public T Item185;
            public T Item186;
            public T Item187;
            public T Item188;
            public T Item189;
            public T Item190;
            public T Item191;
            public T Item192;
            public T Item193;
            public T Item194;
            public T Item195;
            public T Item196;
            public T Item197;
            public T Item198;
            public T Item199;
            public T Item200;
            public T Item201;
            public T Item202;
            public T Item203;
            public T Item204;
            public T Item205;
            public T Item206;
            public T Item207;
            public T Item208;
            public T Item209;
            public T Item210;
            public T Item211;
            public T Item212;
            public T Item213;
            public T Item214;
            public T Item215;
            public T Item216;
            public T Item217;
            public T Item218;
            public T Item219;
            public T Item220;
            public T Item221;
            public T Item222;
            public T Item223;
            public T Item224;
            public T Item225;
            public T Item226;
            public T Item227;
            public T Item228;
            public T Item229;
            public T Item230;
            public T Item231;
            public T Item232;
            public T Item233;
            public T Item234;
            public T Item235;
            public T Item236;
            public T Item237;
            public T Item238;
            public T Item239;
            public T Item240;
            public T Item241;
            public T Item242;
            public T Item243;
            public T Item244;
            public T Item245;
            public T Item246;
            public T Item247;
            public T Item248;
            public T Item249;
            public T Item250;
            public T Item251;
            public T Item252;
            public T Item253;
            public T Item254;
            public T Item255;
        }


    }


    private List<Layer> Layers { get; init; } = new();
    public int Capacity => Layers.Capacity * Layer.ELEMENTS;
    public int Count => Layers.Count == 0 ? 0 : (Layers.Count - 1) * Layer.ELEMENTS + Layers[^1].Count;

    public LayeredValuePool(int initCapacity)
    {
        Layers = new(Math.Max(initCapacity / Layer.ELEMENTS, 1))
        {
        };
    }

    public int Retrieve(in T item)
    {
        if (Layers.Count > 0 && Layers[^1].TryFillAny(item, out int index))
            return index;

        Layer l = new();
        l.TryFillAny(item, out index);
        Layers.Add(l);
        return index;
    }

    public int Retrieve()
        => Retrieve(default);

    public ref T this[int index]
    {
        get
        {
            if (index < 0 || index > Count)
                throw new ArgumentOutOfRangeException($"{nameof(index)} is out of range.");

            int partIndex = index % Layer.ELEMENTS;
            int layerIndex = index / Layer.ELEMENTS;

            return ref Layers[layerIndex][partIndex];
        }
    }

    public delegate void NonInvasiveAction(ref T item);
    public void DoForAll(NonInvasiveAction action)
    {
        for (int i = 0; i < Layers.Count; i++)
            for (int j = 0; j < Layers[i].Count; j++)
                action(ref Layers[i][j]);
    }

    internal void DoForAllDelegate(Delegate d) {
        DoForAll((NonInvasiveAction)d);
    }

    // public delegate void InvasiveAction(ref T item);
    // public void DoForAll(InvasiveAction action)
    // {
    //     for (int i = 0; i < Layers.Count; i++)
    //         for (int j = 0; j < Layers[i].Count; j++)
    //             action(ref Layers[i][j]);
    // }


    public void Return(int index)
    {
        if (index < 0 || index > Count)
            throw new ArgumentOutOfRangeException($"{nameof(index)} is out of range.");

        int partIndex = index % Layer.ELEMENTS;
        int layerIndex = index / Layer.ELEMENTS;

        if (Count == 1 || index == Count - 1)
            Layers[layerIndex].Free(partIndex);
        else
        {
            ref T last = ref Layers[^1][Layers[^1].Count - 1];
            Layers[layerIndex].Replace(in last, partIndex);
            Layers[^1].Free(Layers[^1].Count - 1);
        }

        while (Layers.Count > 0 && Layers[^1].Count == 0)
            Layers.RemoveAt(Layers.Count - 1);
    }
}
using System.Collections.Concurrent;
using Lini.Miscellaneous;

namespace Lini.Rendering;

/// <summary>
/// The render thread is the thread where all OpenGL calls and some corresponding GLFW calls
/// (<see cref="Windowing.GLFW.SwapBuffers"/> and <see cref="Windowing.GLFW.MakeContextCurrent"/>)
/// have to be executed. Items can be added to the execution list via <see cref="Do"/>.
/// The render thread has to be initialized and terminated. Items can be forced to be executed now via
/// <see cref="Finish"/>.
/// 
/// There still is a debate ongoing whether the <see cref="WorkItems"/> should take Actions or some other
/// kind of maybe discriminated union. Garbage collection is the main concern.
/// </summary>
internal static class RenderThread
{
    private static ConcurrentQueue<Action> WorkItems = null!;
    private static Thread Handle = null!;


    private static AutoResetEvent StartThreadEvent = null!;
    private static ManualResetEventSlim WorkDoneEvent = null!;

    public static bool IsRunning { get; private set; } = false;

    internal static void Initialize()
    {
        StartThreadEvent = new(false);
        WorkDoneEvent = new(false);
        WorkItems = new();

        Handle = new(RenderThreadLoop)
        {
            Name = "RenderThread"
        };
        Handle.Start();
        IsRunning = true;

        Logger.Info("Started.", Logger.Source.RenderThread);
    }

    /// <summary>
    /// This command kills the render thread, but still executes all items in the queue.
    /// This command blocks until the render thread has died, as such, this command may not be called
    /// from the render thread itself.
    /// </summary>
    internal static void FinishAndTerminate()
    {
        if (!IsRunning)
            return;
            
        Logger.Info("Terminate command received.", Logger.Source.RenderThread);
        WorkItems.Enqueue(() => ThreadToTerminate = true);
        StartThreadEvent.Set();
        Handle.Join();
        IsRunning = false;
    }

    /// <summary>
    /// This variable may only be accessed by the render thread.
    /// </summary>
    private static bool ThreadToTerminate;

    /// <summary>
    /// The loop of the render threads.
    /// </summary>
    private static void RenderThreadLoop()
    {
        ThreadToTerminate = false;
        while (!ThreadToTerminate)
        {
            StartThreadEvent.WaitOne();

            while (WorkItems.TryDequeue(out var item))
                item();

            WorkDoneEvent.Set();
        }

        Logger.Info("Terminated.", Logger.Source.RenderThread);
    }

    /// <summary>
    /// This field does not require special synchronization since it's only a 
    /// rough optimization. The render thread may start after any number of items, it should just start
    /// periodically and not let only <see cref="Finish"/> do all the work.
    /// </summary>
    private static int ItemsCount = 0;

    internal static void Do(Action item)
    {
        WorkItems.Enqueue(item);

        ItemsCount++;
        if (ItemsCount > 10)
        {
            StartThreadEvent.Set();
            ItemsCount = 0;
        }
    }

    /// <summary>
    /// This command starts the render thread and waits until all items
    /// from the queue are worked through. The render thread signals the calling thread
    /// and execution resumes - this is by design a blocking function.
    /// </summary>
    internal static void Finish()
    {
        WorkDoneEvent.Reset();
        StartThreadEvent.Set();
        WorkDoneEvent.Wait();
    }
}
using System.Collections.Concurrent;
using Lini.Miscellaneous;

namespace Lini.Rendering;

internal static class RenderThread
{
    private static readonly ConcurrentQueue<Action> WorkItems = new();
    private static Thread ThreadHandle = new(RenderThreadLoop);

    private static volatile bool ThreadToTerminate = false;
    private static readonly object ThreadToTerminateLock = new();

    private static readonly AutoResetEvent StartThreadEvent = new(false);
    private static readonly ManualResetEventSlim WorkDoneEvent = new(false);

    internal static void Initialize()
    {
        ThreadHandle = new(RenderThreadLoop)
        {
            Name = "RenderThread"
        };
        ThreadHandle.Start();

        Logger.Info("Started.", Logger.Source.RenderThread);
    }

    internal static void FinishAndTerminate()
    {
        Logger.Info("Terminate command received.", Logger.Source.RenderThread);
        lock (ThreadToTerminateLock)
            ThreadToTerminate = true;

        Finish();
    }

    private static void RenderThreadLoop()
    {
        bool terminate = false;
        while (!terminate)
        {
            StartThreadEvent.WaitOne();
            while (WorkItems.TryDequeue(out var item))
                item();

            WorkDoneEvent.Set();

            lock (ThreadToTerminateLock)
                terminate = ThreadToTerminate;
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

    internal static void Finish()
    {
        WorkDoneEvent.Reset();
        StartThreadEvent.Set();
        WorkDoneEvent.Wait();
    }
}
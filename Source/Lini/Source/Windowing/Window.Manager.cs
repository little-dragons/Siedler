using System.Diagnostics.CodeAnalysis;
using Lini.Miscellaneous;
using Lini.Rendering;
using Lini.Rendering.GLBindings;

namespace Lini.Windowing;

internal partial class Window
{
    internal class Manager
    {
        private static List<Window> Windows { get; } = [];

        internal static bool Initialize()
        {
            Logger.Info($"Using version {GLFW.GetVersion()}.", Logger.Source.GLFW);

            if (!GLFW.Init())
            {
                Logger.Info("GLFW failed to initialize.", Logger.Source.GLFW);
                return false;
            }


            GLFW.SetErrorCallback((ec, str) =>
            {
                Logger.Error($"{ec} - {str}", Logger.Source.GLFWCallback);
            });

            return true;
        }

        internal static void Terminate()
        {
            foreach (var window in Windows)
                Kill(window);

            // GLFW termination requires that a context is only current on the main thread.
            RenderThread.Do(() => GLFW.MakeContextCurrent(GLFW.WindowRef.Null));
            RenderThread.Finish();
            Windows.Clear();
            GLFW.Terminate();
        }

        public static bool TryMake(WindowInfo info, [NotNullWhen(true)] out Window? window)
        {
            if (Windows.Count == 0)
            {
                if (Window.TryMake(info, GLFW.WindowRef.Null, out window))
                {
                    Windows.Add(window);
                    GLFW.WindowRef handle = window.Handle;
                    RenderThread.Do(() =>
                    {
                        GLFW.MakeContextCurrent(handle);
                        GL.Load(GLFW.GetProcAddress);
                    });
                    RenderThread.Finish();
                    return true;
                }
                else
                    return false;
            }

            if (Window.TryMake(info, Windows[0].Handle, out window))
            {
                Windows.Add(window);
                return true;
            }
            else
                return false;
        }

        public static void Kill(Window window)
        {
            Windows.Remove(window);
            window.Free();
        }
    }
}
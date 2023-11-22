using System.Diagnostics.CodeAnalysis;
using Lini.Miscellaneous;
using Lini.Rendering;
using Lini.Rendering.GLBindings;

namespace Lini.Windowing;

internal partial class Window
{
    /// <summary>
    /// A manager for all windows. This is necessary, because each window is not a standalone piece, but are also connected
    /// through the same OpenGL context and some design choices of GLFW. The window manager requires the <see cref="RenderThread"/>
    /// to live and accept commands throughout <see cref="Initialize"/> and <see cref="Terminate"/>.
    /// </summary>
    internal class Manager
    {
        /// <summary>
        /// A list of all live windows.
        /// </summary>
        private static List<Window> Windows { get; } = [];

        /// <summary>
        /// Initializes GLFW. It does not prepare a rendering context and does not initialize OpenGL functions.
        /// </summary>
        /// <returns>True if GLFW could be successfully initialized, false if something went wrong.</returns>
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

        /// <summary>
        /// Kills all remaining windows and terminates GLFW.
        /// </summary>
        internal static void Terminate()
        {
            foreach (var window in Windows)
                Kill(window);

            // GLFW termination requires that a context is only current on the main thread.
            // the render thread might have died before the window manager in which case there is no context current on the
            // render thread.
            if (RenderThread.IsRunning)
            {
                RenderThread.Do(() => GLFW.MakeContextCurrent(GLFW.WindowRef.Null));

                // make sure that the command is actually executed before glfw is terminated
                RenderThread.Finish();
            }

            Windows.Clear();
            GLFW.Terminate();
        }

        /// <summary>
        /// Polls all pending events and processes them for all active windows.
        /// </summary>
        internal static void PollEvents() {
            GLFW.PollEvents();
        }

        /// <summary>
        /// Creates a new window with the specified information. The first successful call to this method initializes the OpenGL bindings.
        /// They may from now on be used until all windows with the same context are destroyed.
        /// </summary>
        /// <param name="info">The initial info of this window.</param>
        /// <param name="window">The result window. It will share its context with all other previously created windows.</param>
        /// <returns>True if the window could be created without issue. False if the operation could not be executed as expected.</returns>
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

        /// <summary>
        /// Kills a window object. The object may not be accessed in any way after it has been killed.
        /// </summary>
        /// <param name="window"></param>
        public static void Kill(Window window)
        {
            // TODO: This assumes that having a context current with GLFW.MakeContextCurrent is fine if the window is destroyed
            //       but the window's context is shared with other windows. This has to be checked when multiple windows are actually used.

            Windows.Remove(window);
            window.Free();
        }
    }
}
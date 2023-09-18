using System.Numerics;

namespace Lini.Windowing;

public class Window
{
    private Vector2 LastWindowSize;
    private Vector2 LastWindowPos;

    private GLFW.WindowRef Ref { get; init; }

    private bool _IsFullscreen;
    public bool IsFullscreen
    {
        get => _IsFullscreen;
        set
        {
            if (_IsFullscreen == value)
                return;

            if (_IsFullscreen)
            {
                var monitor = GLFW.GetPrimaryMonitor();
                var video = GLFW.GetVideoMode(monitor);
                GLFW.SetWindowMonitor(Ref, monitor, 0, 0, video.Width, video.Height, video.RefreshRate);
            }
            else
            {

            }

            _IsFullscreen = value;
        }
    }

    public Window()
    {

    }

}
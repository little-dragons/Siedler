using Lini.Miscellaneous;

namespace Lini.Windowing;

public record WindowInfo(string Title, (int, int) Resolution, int RefreshRate, Choice<FullscreenInfo, WindowedInfo> FullscreenOptions, bool CursorLocked) {
    public bool IsFullscreen => FullscreenOptions.IsFirstCase;
}

public record FullscreenInfo();
public record WindowedInfo((int, int)? Position);
using Lini.Miscellaneous;

namespace Lini.Windowing;

/// <summary>
/// This record stores all superficial information about a window. This includes all of the appearance information
/// and some questions about how input is supposed to be obtained.
/// </summary>
public record WindowInfo(string Title, (int, int) Resolution, int RefreshRate, Choice<FullscreenInfo, WindowedInfo> FullscreenOptions, bool CursorLocked) {
    public bool IsFullscreen => FullscreenOptions.IsFirstCase;
}

public record FullscreenInfo();
public record WindowedInfo((int, int)? Position);
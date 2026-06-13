using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDCasePrinter;

public record FontSettings(string FontFamily, float FontSize, FontStyle Style);


public record Settings
{
    public FontSettings ArtistFont { get; init; }
    public FontSettings AlbumFont { get; init; }
    public FontSettings SpineFont { get; init; }
    public FontSettings CodeFont { get; init; }
    public string DefaultFontFamily { get; init; }

    public Settings()
    {
        DefaultFontFamily = "Arial";
        ArtistFont = new FontSettings("Arial", 14, FontStyle.Bold);
        AlbumFont = new FontSettings("Arial", 12, FontStyle.Regular);
        SpineFont = new FontSettings("Arial", 12, FontStyle.Regular);
        CodeFont = new FontSettings("Arial", 5, FontStyle.Regular);
    }
}

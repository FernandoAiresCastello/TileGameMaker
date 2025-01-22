using TileGameMaker.Core;
using TileGameMaker.Test;

namespace TileGameMaker;

internal static class EntryPoint
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        TileGameMakerApp app = new();

        AnimatedTileTestWindow testWindow = new(app);
        Application.Run(testWindow);

        //ColorPaletteWindow wnd = new(app);
		//Application.Run(wnd);
	}
}

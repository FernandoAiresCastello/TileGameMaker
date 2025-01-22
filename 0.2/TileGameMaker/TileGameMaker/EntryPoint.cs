using TileGameMaker.Core;
using TileGameMaker.StandaloneTools;

namespace TileGameMaker;

internal static class EntryPoint
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        TileGameMakerApp app = new();
        //TestWindow testWindow = new(app);
        //Application.Run(testWindow);
        ColorPaletteWindow wnd = new(app);
		Application.Run(wnd);
	}
}

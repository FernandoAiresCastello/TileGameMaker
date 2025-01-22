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

        //AnimatedTileTestWindow testWindow = new(app);
        //Application.Run(testWindow);

        //ColorPaletteEditorWindow wnd = new(app);
        //Application.Run(wnd);

        TilePainterWindow wnd = new(app);
		Application.Run(wnd);
	}
}

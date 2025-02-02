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

        //ColorPaletteEditorWindow wnd = new(app);
        //Application.Run(wnd);

        //int tileSize = 16;
        //TilePainterWindow wnd = new(app, new Size(tileSize, tileSize), new Size(8, 8), 3);
        //Application.Run(wnd);

        //Mono8x8TilePainterWindow wnd = new(app);
		//Application.Run(wnd);
	}
}

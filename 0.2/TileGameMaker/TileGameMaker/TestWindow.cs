using TileGameLib.Controls;

namespace TileGameMaker;

public partial class TestWindow : Form
{
    readonly TileDisplay display;

    public TestWindow()
    {
        InitializeComponent();

        int tileSize = 8;

		display = new TileDisplay(320 / tileSize, 200 / tileSize, tileSize, tileSize, Color.Yellow)
		{
			Parent = RootPanel,
			Zoom = 2
		};

		for (int i = 0; i < display.Canvas.Width && i < display.Canvas.Height; i++)
            display.Image.SetPixel(i, i, Color.Black);
	}
}

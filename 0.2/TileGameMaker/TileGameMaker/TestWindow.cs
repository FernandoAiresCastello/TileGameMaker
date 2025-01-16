using TileGameLib.Controls;
using TileGameLib.GraphicsBase;

namespace TileGameMaker;

public partial class TestWindow : Form
{
	private readonly ColorPalettePanel PalettePanel;
	private readonly TileDisplay Display;
	private readonly TileCanvas Canvas;

	public TestWindow()
	{
		InitializeComponent();

		int tileSize = 8;
		int cols = 8;
		int rows = 256 / cols;

		PalettePanel = new ColorPalettePanel(cols, rows, tileSize, tileSize, 3)
		{
			Parent = RootPanel
		};

		PalettePanel.SetColors
		(
			[
				"000000", "808080", "ff0000", "ff8000", "00ff00", 
				"0000ff", "ffff00", "00ffff", "ff00ff", "ffffff", 
			]
		);

		Display = PalettePanel.Display;
		Display.MouseClick += Panel_MouseClick;
		Canvas = Display.Canvas;
	}

	private void Panel_MouseClick(object? sender, MouseEventArgs e)
	{
		int index = Display.GetCellIndex(e.Location);
		Text = Canvas.Data(index).Get<Color>("color").ToString();
	}
}

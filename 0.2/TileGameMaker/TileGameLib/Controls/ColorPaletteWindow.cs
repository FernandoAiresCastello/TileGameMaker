using System.ComponentModel;
using TileGameLib.GraphicsBase;
using TileGameLib.Util;

namespace TileGameLib.Controls;

public partial class ColorPaletteWindow : Form
{
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Action<Form, Color?, MouseButtons> OnColorClicked { get; set; }

	private readonly ColorPalettePanel PalettePanel;
	private readonly TileDisplay Display;
	private readonly TileCanvas Canvas;

	public ColorPaletteWindow()
	{
		InitializeComponent();

		int tileSize = 8;
		int cols = 8;
		int rows = 256 / cols;

		PalettePanel = new ColorPalettePanel(cols, rows, tileSize, tileSize, 3)
		{
			Parent = RootPanel
		};

		Display = PalettePanel.Display;
		Display.MouseClick += Panel_MouseClick;
		Canvas = Display.Canvas;
	}

	public void SetColors(List<string> hexColors)
	{
		PalettePanel.SetColors(hexColors);
	}

	private void Panel_MouseClick(object sender, MouseEventArgs e)
	{
		int index = Display.GetCellIndex(e.Location);
		TileData data = Canvas.Data(index);
		Color? color = data.Get<Color?>("color");
		if (color != null)
			OnColorClicked?.Invoke(this, color, e.Button);
	}
}

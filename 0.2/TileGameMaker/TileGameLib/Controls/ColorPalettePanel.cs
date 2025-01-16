using System.ComponentModel;
using TileGameLib.GraphicsBase;

namespace TileGameLib.Controls;

public partial class ColorPalettePanel : UserControl
{
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public TileDisplay Display { get; private set; }

	private List<Color> Colors { get; set; }

	private readonly TileCanvas Canvas;

	public ColorPalettePanel(int cols, int rows, int cellWidth, int cellHeight, int zoom)
	{
		InitializeComponent();

		Display = new TileDisplay(cols, rows, cellWidth, cellHeight, Color.White)
		{
			Parent = RootPanel,
			Zoom = zoom,
		};

		Canvas = Display.Canvas;
		Dock = DockStyle.Fill;
	}

	public void SetColors(List<Color> colors)
	{
		Colors = colors;
		UpdateDisplay();
	}

	public void SetColors(List<string> hexColors)
	{
		Colors = [];

		foreach (string hexColor in hexColors)
		{
			string hex = hexColor;

			if (hex.StartsWith('#'))
				hex = hex[1..];
			else if (hex.StartsWith("0x"))
				hex = hex[2..];

			Colors.Add(ColorTranslator.FromHtml("#" + hex));
		}

		UpdateDisplay();
	}

	private void UpdateDisplay()
	{
		for (int i = 0; i < Colors.Count && i < Display.CellCount; i++)
		{
			Color color = Colors[i];
			Canvas.DrawColor(color, i);
			Canvas.Data(i).Set("color", color);
		}
	}
}

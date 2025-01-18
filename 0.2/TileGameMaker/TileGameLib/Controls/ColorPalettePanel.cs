using TileGameLib.Util;

namespace TileGameLib.Controls;

/// <summary>
///		A panel that displays a grid of colors from a <see cref="ColorPalette"/>.
/// </summary>
public partial class ColorPalettePanel : TileDisplayPanelBase
{
	private const string ColorDataKey = "color";

	/// <param name="cols">Number of columns</param>
	/// <param name="rows">Number of rows</param>
	/// <param name="cellWidth">Width of grid cells</param>
	/// <param name="cellHeight">Height of grid cells</param>
	/// <param name="zoom">Magnification factor</param>
	/// <param name="emptyColor">Default color for empty cells</param>
	public ColorPalettePanel(int cols, int rows, int cellWidth, int cellHeight, int zoom, Color emptyColor) :
		base(cols, rows, cellWidth, cellHeight, zoom, emptyColor)
	{
	}

	private ColorPalette Colors { get; set; } = new();

	public void SetColors(List<Color> colors)
	{
		Colors.SetColors(colors);
		UpdateDisplay();
	}

	public void SetColors(List<string> hexColors)
	{
		Colors.SetColors(hexColors);
		UpdateDisplay();
	}

	public void LoadColors(string path)
	{
		Colors.Load(path);
		UpdateDisplay();
	}

	public Color? GetColorAtCellIndex(int cellIndex) => 
		Canvas.Data(cellIndex).Get<Color?>(ColorDataKey);

	public Color? GetColorAtCellPos(Point cellPos) => 
		Canvas.Data(cellPos).Get<Color?>(ColorDataKey);

	public Color? GetColorAtMousePos(Point mousePos) =>
		GetColorAtCellIndex(GetCellIndex(mousePos));

	private void UpdateDisplay()
	{
		for (int i = 0; i < Colors.Count && i < Canvas.CellCount; i++)
		{
			Color? color = Colors.Get(i);
			if (color == null)
				continue;

			Canvas.DrawColor(color.Value, i);
			Canvas.Data(i).Set(ColorDataKey, color.Value);
		}
	}
}

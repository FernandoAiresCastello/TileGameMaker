using TileGameLib.Core;
using TileGameLib.Core.TileTypes;

namespace TileGameLib.Controls;

/// <summary>
///		A panel that displays a grid of colors from a <see cref="ColorPalette"/>.
/// </summary>
/// <param name="bufSize">Size of the grid (number of columns and rows)</param>
/// <param name="cellSize">Size of each grid cell (width and height in pixels)</param>
/// <param name="zoomLevel">Magnification factor</param>
/// <param name="emptyColor">Default color for empty cells</param>

public class ColorPaletteDisplay(Size bufSize, Size cellSize, int zoomLevel, Color emptyColor) :
	TileDisplay(bufSize, cellSize, zoomLevel, emptyColor)
{
	private ColorPalette Colors { get; set; } = new();

	public void SetColors(List<Color> colors)
	{
		Colors.SetColors(colors);
		UpdateTiles();
	}

	public void SetColors(List<string> hexColors)
	{
		Colors.SetColors(hexColors);
		UpdateTiles();
	}

	public void LoadColors(string path)
	{
		Colors.Load(path);
		UpdateTiles();
	}

	public Color? GetColorAtCellIndex(int cellIndex) => 
		GetTile<SolidColorTile>(cellIndex).Color;

	public Color? GetColorAtCellPos(Point cellPos) =>
		GetTile<SolidColorTile>(cellPos).Color;

	public Color? GetColorAtMousePos(Point mousePos) =>
		GetColorAtCellIndex(GetCellIndexFromMousePos(mousePos));

	private void UpdateTiles()
	{
		for (int i = 0; i < Colors.Count && i < CellCount; i++)
			SetTile(new SolidColorTile(Colors.Get(i)), i);
	}
}

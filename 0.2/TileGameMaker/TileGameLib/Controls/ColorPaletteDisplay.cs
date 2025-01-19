using TileGameLib.Core;

namespace TileGameLib.Controls;

/// <summary>
///		A panel that displays a grid of colors from a <see cref="ColorPalette"/>.
/// </summary>
/// <param name="gridSize">Size of the grid (number of columns and rows)</param>
/// <param name="cellSize">Size of each grid cell (width and height in pixels)</param>
/// <param name="zoomLevel">Magnification factor</param>
/// <param name="emptyColor">Default color for empty cells</param>

public class ColorPaletteDisplay(Size gridSize, Size cellSize, int zoomLevel, Color emptyColor) :
	TileDisplay(gridSize, cellSize, zoomLevel, emptyColor)
{
	private readonly DataKey ColorDataKey = "color";

	private ColorPalette Colors { get; set; } = new();
	private readonly TileBuffer Tiles = new(gridSize.Width, gridSize.Height);

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
		Tiles.At(cellIndex).Data.Get<Color?>(ColorDataKey);

	public Color? GetColorAtCellPos(Point cellPos) =>
		Tiles.At(cellPos).Data.Get<Color?>(ColorDataKey);

	public Color? GetColorAtMousePos(Point mousePos) =>
		GetColorAtCellIndex(GetCellIndexFromMousePos(mousePos));

	private void UpdateTiles()
	{
		for (int i = 0; i < Colors.Count && i < Tiles.CellCount; i++)
		{
			Color? color = Colors.Get(i);
			if (color == null)
				continue;

			Tiles.At(i).Data.Set(ColorDataKey, color.Value);
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		for (int y = 0; y < Rows; y++)
			for (int x = 0; x < Cols; x++)
				Canvas.DrawColor(Tiles.At(x, y).Data.Get<Color>(ColorDataKey), x, y);

		base.OnPaint(e);
	}
}

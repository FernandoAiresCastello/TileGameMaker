namespace TileGameLib.Core.TileTypes;

public class SolidColorTile(Color color) : Tile
{
	public Color Color { get; set; } = color;

	public override void Draw(TileCanvas canvas, int col, int row)
	{
		canvas.DrawColor(Color, col, row);
	}
}

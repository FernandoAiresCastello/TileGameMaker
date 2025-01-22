namespace TileGameLib.Core.TileTypes;

public class Tile
{
	public Dataset Data { get; set; } = new();

	public virtual void Draw(TileCanvas canvas, int col, int row)
	{
	}
}

namespace TileGameLib.Core;

public class TilePosition
{
	public int X { get; set; } = int.MinValue;
	public int Y { get; set; } = int.MinValue;
	public TileBoard.Layer Layer { get; set; } = TileBoard.Layer.Base;

	public TilePosition()
	{
	}

	public TilePosition(int x, int y, TileBoard.Layer layer)
	{
		X = x;
		Y = y;
		Layer = layer;
	}
}

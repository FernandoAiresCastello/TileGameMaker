namespace TileGameLib.Core.TileTypes;

public class ImageTile : Tile
{
	public TileImage Image { get; set; }

	public ImageTile() {}
	public ImageTile(TileImage image) => Image = image;

	public override void Draw(TileCanvas canvas, int col, int row)
	{
		canvas.DrawTile(Image, col, row);
	}
}

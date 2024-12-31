namespace TileGameLib.GraphicsBase;

public class TileCanvas
{
	public readonly int Cols;
	public readonly int Rows;
	public readonly int CellWidth;
	public readonly int CellHeight;

	public PixelBuffer Buffer { get; private set; }

	public int Width => Buffer.Width;
	public int Height => Buffer.Height;
	public Bitmap Bitmap => Buffer.Bitmap;

	public TileCanvas(int cols, int rows, int cellWidth, int cellHeight, Color color)
	{
		Cols = cols;
		Rows = rows;
		CellWidth = cellWidth;
		CellHeight = cellHeight;

		Buffer = new PixelBuffer(cols * cellWidth, rows * cellHeight, color);
	}

	public void DrawTile(TileImage tile, int col, int row)
	{
		DrawFreeTile(tile, col * CellWidth, row * CellHeight);
	}

	public void DrawFreeTile(TileImage tile, int x, int y)
	{
		int initialX = x;
		int initialY = y;
		int bufX = initialX;
		int bufY = initialY;

		for (int imageY = 0; imageY < tile.Height; imageY++)
		{
			for (int imageX = 0; imageX < tile.Width; imageX++)
			{
				Color color = tile.GetPixel(imageX, imageY);
				Buffer.SetPixel(bufX, bufY, color);
				bufX++;
			}
			bufY++;
			bufX = initialX;
		}
	}
}

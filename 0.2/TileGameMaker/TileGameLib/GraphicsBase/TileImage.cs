namespace TileGameLib.GraphicsBase;

public class TileImage(int width, int height, Color color) : 
	PixelBuffer(width, height, color)
{
	public void Load(string path)
	{
		Bitmap bmp = (Bitmap)Image.FromFile(path);

		FastBitmap = new FastBitmap(bmp.Width, bmp.Height);
		
		for (int y = 0; y < bmp.Height; y++)
			for (int x = 0; x < bmp.Width; x++)
				Bitmap.SetPixel(x, y, bmp.GetPixel(x, y));
	}
}

using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace TileGameLib;

public sealed class PixelCanvas : IDisposable
{
	public int Width { get; }
	public int Height { get; }

	private readonly int[] pixels;
	private readonly Bitmap bitmap;

	public PixelCanvas(int width, int height)
	{
		Width = width;
		Height = height;
		pixels = new int[width * height];
		bitmap = new(width, height, PixelFormat.Format32bppArgb);
	}

	/// <summary>
	///		Sets a pixel using a color in the format 0xRRGGBB.
	/// </summary>
	public void SetPixel(int x, int y, int rgb)
	{
		if ((uint)x >= Width || (uint)y >= Height)
			return;

		// Force alpha to 255 → 0xFFRRGGBB
		pixels[y * Width + x] = unchecked((int)(0xFF000000 | (uint)rgb));
	}

	/// <summary>
	///		Draws the given 8x8 pixel block
	/// </summary>
	public void DrawPixelBlock(string bits, int x, int y, int color1, int color0)
	{
		x *= 8;
		y *= 8;

		int i = 0;

		for (int row = 0; row < 8; row++)
		{
			int py = y + row;
			for (int col = 0; col < 8; col++, i++)
			{
				int px = x + col;
				SetPixel(px, py, bits[i] == '1' ? color1 : color0);
			}
		}
	}

	/// <summary>
	///		Draws the given 8x8 pixel block
	/// </summary>
	public void DrawPixelBlock(string bits, int x, int y, int color1)
	{
		x *= 8;
		y *= 8;

		int i = 0;

		for (int row = 0; row < 8; row++)
		{
			int py = y + row;
			for (int col = 0; col < 8; col++, i++)
			{
				int px = x + col;
				if (bits[i] == '1')
					SetPixel(px, py, color1);
			}
		}
	}

	/// <summary>
	///		Draws an 8x8 pixel block from the given charset using the given palette
	/// </summary>
	public void DrawPixelBlock(Charset charset, Palette palette, int charIndex, int x, int y, int palIndex1, int palIndex0)
	{
		DrawPixelBlock(charset.GetChar(charIndex), x, y, palette.GetColor(palIndex1), palette.GetColor(palIndex0));
	}

	/// <summary>
	///		Draws an 8x8 pixel block from the given charset using the given palette
	/// </summary>
	public void DrawPixelBlock(Charset charset, Palette palette, int charIndex, int x, int y, int palIndex1)
	{
		DrawPixelBlock(charset.GetChar(charIndex), x, y, palette.GetColor(palIndex1));
	}

	/// <summary>
	///		Draws a string using the 8x8 pixel blocks from the given charset using the given palette
	/// </summary>
	public void DrawString(Charset charset, Palette palette, string text, int x, int y, int palIndex1, int palIndex0)
	{
		foreach (char charIndex in text)
			DrawPixelBlock(charset.GetChar(charIndex), x++, y, palette.GetColor(palIndex1), palette.GetColor(palIndex0));
	}

	/// <summary>
	///		Draws a string using the 8x8 pixel blocks from the given charset using the given palette
	/// </summary>
	public void DrawString(Charset charset, Palette palette, string text, int x, int y, int palIndex1)
	{
		foreach (char charIndex in text)
			DrawPixelBlock(charset.GetChar(charIndex), x++, y, palette.GetColor(palIndex1));
	}

	/// <summary>
	///		Copies the off-screen buffer into the internal Bitmap.
	///		Call this once per frame, not per pixel.
	/// </summary>
	public Bitmap GetBitmap()
	{
		var rect = new Rectangle(0, 0, Width, Height);
		var data = bitmap.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

		try
		{
			Marshal.Copy(pixels, 0, data.Scan0, pixels.Length);
		}
		finally
		{
			bitmap.UnlockBits(data);
		}

		return bitmap;
	}

	/// <summary>
	///		Clear the buffer to the given color
	/// </summary>
	public void Clear(int rgb)
	{
		int color = unchecked((int)(0xFF000000 | (uint)rgb));
		Array.Fill(pixels, color);
	}

	public void Dispose()
	{
		bitmap.Dispose();
	}
}

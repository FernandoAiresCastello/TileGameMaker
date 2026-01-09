using TileGameLib.Core;

namespace TileGameMaker;

public partial class Tile8x8Editor : Form
{
	private readonly Charset charset;
	private readonly int charIndex;

	private readonly TilePixels8x8Display display;

	public Tile8x8Editor(Charset charset, int charIndex)
	{
		InitializeComponent();

		display = new TilePixels8x8Display(PnlDisplay);
		display.Zoom = 4;

		this.charset = charset;
		this.charIndex = charIndex;

		display.DrawTilePixels(charset, charIndex);
		display.MouseDown += Display_MouseDown;
		display.MouseMove += Display_MouseMove;

		Size = new Size(276, 344);
		FormBorderStyle = FormBorderStyle.FixedSingle;
	}

	private void Display_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.None)
			Display_MouseDown(e);
	}

	private void Display_MouseDown(object sender, MouseEventArgs e)
	{
		Display_MouseDown(e);
	}

	private void Display_MouseDown(MouseEventArgs e)
	{
		int x = display.GetTileX(e.X);
		int y = display.GetTileY(e.Y);

		int pixelIndex = y * Tile.Width + x;

		char[] pixels = charset.GetChar(1).ToCharArray();

		if (e.Button == MouseButtons.Left)
			pixels[pixelIndex] = '1';
		else if (e.Button == MouseButtons.Right)
			pixels[pixelIndex] = '0';

		charset.SetChar(1, new string(pixels));

		display.DrawTilePixels(charset, charIndex);
		display.Invalidate();
	}
}

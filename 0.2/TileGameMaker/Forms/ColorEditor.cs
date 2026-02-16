using TileGameLib.Core;

namespace TileGameMaker.Forms;

public partial class ColorEditor : Form
{
	private readonly Palette palette;
	private readonly int colorIndex;

	public ColorEditor(Palette palette, int colorIndex)
	{
		InitializeComponent();

		this.palette = palette;
		this.colorIndex = colorIndex;

		UpdateSwatch();
		UpdateHex();

		TxtHex.TextChanged += TxtHex_TextChanged;
	}

	private void TxtHex_TextChanged(object sender, EventArgs e)
	{
		bool ok = int.TryParse(TxtHex.Text, System.Globalization.NumberStyles.HexNumber, null, out int rgb);
		if (!ok)
			return;

		Color color = Color.FromArgb(255, Color.FromArgb(rgb));
		palette.SetColor(colorIndex, color.ToArgb());

		UpdateSwatch();
	}

	private void UpdateHex()
	{
		TxtHex.Text = (palette.GetColor(colorIndex) & 0xFFFFFF).ToString("X6");
	}

	public void UpdateSwatch()
	{
		PnlColor.BackColor = GetColor();
	}

	public Color GetColor()
	{
		return Color.FromArgb(255, Color.FromArgb(palette.GetColor(colorIndex)));
	}
}

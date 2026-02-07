namespace TileGameEngine;

public partial class TextWindow : Form
{
	public TextWindow(string text, Color foreColor, Color backColor)
	{
		InitializeComponent();

		BackColor = backColor;
		ForeColor = foreColor;

		TxtText.Text = text;
		TxtText.BackColor = backColor;
		TxtText.ForeColor = foreColor;

		BtnOk.BackColor = backColor;
		BtnOk.ForeColor = foreColor;
	}
}

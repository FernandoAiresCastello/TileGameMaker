namespace TileGameMaker.Dialogs;

public partial class MapPropertiesDialog : Form
{
	public string Title => TxtTitle.Text;
	public Color AccentForeColor => LbAccentSample.ForeColor;
	public Color AccentBackColor => LbAccentSample.BackColor;

	public MapPropertiesDialog(string boardName, Color accentForeColor, Color accentBackColor)
	{
		InitializeComponent();

		TxtTitle.Text = boardName;
		BtnAccentBack.BackColor = accentBackColor;
		BtnAccentFore.BackColor = accentForeColor;
		LbAccentSample.ForeColor = accentForeColor;
		LbAccentSample.BackColor = accentBackColor;
	}

	private void BtnAccentBack_Click(object sender, EventArgs e)
	{
		ColorDialog dialog = new();
		if (dialog.ShowDialog() != DialogResult.OK)
			return;

		BtnAccentBack.BackColor = dialog.Color;
		LbAccentSample.BackColor = dialog.Color;
	}

	private void BtnAccentFore_Click(object sender, EventArgs e)
	{
		ColorDialog dialog = new();
		if (dialog.ShowDialog() != DialogResult.OK)
			return;

		BtnAccentFore.BackColor = dialog.Color;
		LbAccentSample.ForeColor = dialog.Color;
	}
}

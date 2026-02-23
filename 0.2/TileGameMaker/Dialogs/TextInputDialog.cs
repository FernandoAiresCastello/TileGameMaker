namespace TileGameMaker.Dialogs;

public partial class TextInputDialog : Form
{
	public TextInputDialog(string text)
	{
		InitializeComponent();

		TxtText.Text = text;
	}

	public string GetText()
	{
		return TxtText.Text;
	}
}

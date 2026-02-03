namespace TileGameMaker.Dialogs;

public partial class LineInputDialog : Form
{
	public string Value => TxtInput.Text.Trim();

	public LineInputDialog(string prompt, string initialText)
	{
		InitializeComponent();

		LbPrompt.Text = prompt;
		TxtInput.Text = initialText;
	}
}

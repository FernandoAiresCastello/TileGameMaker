namespace TileGameMaker.Dialogs;

public partial class MapPropertiesDialog : Form
{
	public string Title => TxtTitle.Text;

	public MapPropertiesDialog(string boardName)
	{
		InitializeComponent();

		TxtTitle.Text = boardName;
	}
}

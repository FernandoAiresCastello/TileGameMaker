using TileGameLib.Core;

namespace TileGameMaker.Dialogs;

public partial class DirectionsDialog : Form
{
	public string NorthFilename => TxtNorth.Text.Trim();
	public string SouthFilename => TxtSouth.Text.Trim();
	public string EastFilename => TxtEast.Text.Trim();
	public string WestFilename => TxtWest.Text.Trim();

	public DirectionsDialog(TileBoard board)
	{
		InitializeComponent();

		TxtNorth.Text = board.NorthFilename;
		TxtSouth.Text = board.SouthFilename;
		TxtEast.Text = board.EastFilename;
		TxtWest.Text = board.WestFilename;
	}
}

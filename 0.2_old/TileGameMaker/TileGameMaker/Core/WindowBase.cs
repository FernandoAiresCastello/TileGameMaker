namespace TileGameMaker.Core;

public partial class WindowBase : Form
{
	protected readonly TileGameMakerApp App;

	private WindowBase()
	{
		InitializeComponent();
	}

	public WindowBase(TileGameMakerApp app)
	{
		InitializeComponent();
		
		App = app;
		StartPosition = FormStartPosition.CenterScreen;
		FormBorderStyle = FormBorderStyle.FixedSingle;
		MaximizeBox = false;
	}
}

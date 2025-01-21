namespace TileGameMaker.Core;

public partial class WindowBase : Form
{
	protected readonly TileGameMakerApp App;

	protected WindowBase()
	{
		InitializeComponent();
	}

	public WindowBase(TileGameMakerApp app)
	{
		InitializeComponent();
		App = app;
	}
}

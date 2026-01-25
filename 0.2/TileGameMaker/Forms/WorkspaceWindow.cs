namespace TileGameMaker.Forms;

public partial class WorkspaceWindow : Form
{
	private readonly Workspace workspace = new();

	public WorkspaceWindow()
	{
		InitializeComponent();

		BoardWindow window = new(workspace)
		{
			MdiParent = this
		};

		window.Show();
	}
}

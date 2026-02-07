using System.ComponentModel;

namespace TileGameMaker.Forms;

public partial class WorkspaceWindow : Form
{
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public BoardWindow BoardWindow { get; set; }
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public CharsetWindow CharsetWindow { get; set; }
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public PaletteWindow PaletteWindow { get; set; }
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public CurrentTileWindow CurTileWindow { get; set; }

	private readonly Workspace workspace;

	public WorkspaceWindow()
	{
		InitializeComponent();
		WindowState = FormWindowState.Maximized;

		workspace = new Workspace(this);

		BoardWindow = new(workspace) { MdiParent = this };
		CharsetWindow = new(workspace) { MdiParent = this };
		PaletteWindow = new(workspace) { MdiParent = this };
		CurTileWindow = new(workspace) { MdiParent = this };

		BoardWindow.StartPosition = FormStartPosition.Manual;
		BoardWindow.Location = new Point(500, 0);

		CharsetWindow.StartPosition = FormStartPosition.Manual;
		CharsetWindow.Location = new Point(0, 0);

		PaletteWindow.StartPosition = FormStartPosition.Manual;
		PaletteWindow.Location = new Point(0, 500);

		CurTileWindow.StartPosition = FormStartPosition.Manual;
		CurTileWindow.Location = new Point(1260, 0);

		BoardWindow.Show();
		CharsetWindow.Show();
		PaletteWindow.Show();
		CurTileWindow.Show();
	}

	private void BtnQuit_Click(object sender, EventArgs e)
	{
		Close();
	}
}

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

	private readonly Workspace workspace;

	public WorkspaceWindow()
	{
		InitializeComponent();

		workspace = new Workspace(this);

		BoardWindow = new(workspace)
		{
			MdiParent = this
		};

		CharsetWindow = new(workspace)
		{
			MdiParent = this
		};

		PaletteWindow = new(workspace)
		{
			MdiParent = this
		};

		BoardWindow.Show();
		CharsetWindow.Show();
		PaletteWindow.Show();
	}
}

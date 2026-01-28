using TileGameLib.Core;
using TileGameMaker.Forms;

namespace TileGameMaker;

public class Workspace
{
	public Palette Palette { get; set; } = new();
	public Charset Charset { get; set; } = new();

	public Tile CurrentTile { get; set; } = new Tile('?', 0, 15);

	private readonly WorkspaceWindow workspaceWindow;

	public Workspace(WorkspaceWindow workspaceWindow)
	{
		this.workspaceWindow = workspaceWindow;

		Palette.Load("palette.dat");
		Charset.Load("charset.dat");
	}

	public void SetCurrentTile(Tile tile)
	{
		CurrentTile.SetEqual(tile);
		workspaceWindow.CharsetWindow.DrawChars();
	}
}

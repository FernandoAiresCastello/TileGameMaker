using TileGameLib.Controls;
using TileGameLib.Core;

namespace TileGameEngine;

public partial class GameWindow : Form
{
	public TileBoardDisplay Display { get; private set; }
	public Charset Charset { get; private set; } = new();
	public Palette Palette { get; private set; } = new();
	public GameEngine Engine { get; private set; }

	public GameWindow(GameEngine engine)
	{
		InitializeComponent();

		Engine = engine;
		LbTitle.Text = "";

		Display = new TileBoardDisplay(160 / 8, 144 / 8, Charset, Palette, 400, PnlBoard);
		Display.ShowGrid = false;

		KeyPreview = true;

		BoardFile.Load("test/start.map", Display.Board, Palette, Charset);
		
		LbTitle.Text = Display.Board.Name;

		Engine.OnGameLoaded(Display.Board);
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		if (Engine.OnKeyPress(keyData))
			return true;

		return base.ProcessCmdKey(ref msg, keyData);
	}

	public void RedrawDisplay()
	{
		Display.DrawTiles();
		Display.Invalidate();
	}
}

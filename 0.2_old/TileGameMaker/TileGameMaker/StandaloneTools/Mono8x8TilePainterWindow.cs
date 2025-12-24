using TileGameLib.Controls;
using TileGameMaker.Core;

namespace TileGameMaker.StandaloneTools;

public partial class Mono8x8TilePainterWindow : WindowBase
{
	private ImageEditorDisplay Display;

	public Mono8x8TilePainterWindow(TileGameMakerApp app) : base(app)
	{
		InitializeComponent();

		Display = new ImageEditorDisplay(new Size(8, 8), new Size(8, 8), 3);
		Display.Parent = EditorPanel;
	}
}

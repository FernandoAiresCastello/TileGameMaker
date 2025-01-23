using TileGameLib.Controls;
using TileGameMaker.Core;

namespace TileGameMaker.StandaloneTools;

public partial class TilePainterWindow : WindowBase
{
	private ImageEditorDisplay Display;

	public TilePainterWindow(TileGameMakerApp app, Size imageSize, Size pixelSize, int zoom = 1) : base(app)
	{
		InitializeComponent();

		Display = new ImageEditorDisplay(imageSize, pixelSize, zoom);
		Display.Parent = EditorPanel;
	}
}

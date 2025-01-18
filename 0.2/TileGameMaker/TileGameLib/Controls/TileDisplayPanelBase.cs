using System.ComponentModel;
using TileGameLib.GraphicsBase;

namespace TileGameLib.Controls;

/// <summary>
///		Base class for a panel that holds a <see cref="TileDisplay"/>.
/// </summary>
public partial class TileDisplayPanelBase : UserControl
{
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Action<MouseButtons, Point> OnMouseClicked { get; set; }

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Action<MouseButtons, Point> OnMouseMoved { get; set; }

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Action OnMouseExit { get; set; }

	protected readonly TileDisplay Display;
	protected readonly TileCanvas Canvas;

	/// <summary>
	///		Constructs the panel.
	/// </summary>
	/// <param name="cols">Number of columns</param>
	/// <param name="rows">Number of rows</param>
	/// <param name="cellWidth">Width of grid cells</param>
	/// <param name="cellHeight">Height of grid cells</param>
	/// <param name="zoom">Magnification factor</param>
	/// <param name="backColor">Background color</param>
	public TileDisplayPanelBase(int cols, int rows, int cellWidth, int cellHeight, int zoom, Color backColor)
	{
		InitializeComponent();

		Display = new TileDisplay(cols, rows, cellWidth, cellHeight, backColor)
		{
			Parent = RootPanel,
			Zoom = zoom,
		};

		Canvas = Display.Canvas;

		Display.MouseClick += (sender, e) => 
			OnMouseClicked?.Invoke(e.Button, e.Location);

		Display.MouseMove += (sender, e) =>
			OnMouseMoved?.Invoke(e.Button, e.Location);

		Display.MouseLeave += (sender, e) =>
			OnMouseExit?.Invoke();
	}

	public int GetCellIndexFromMousePos(Point pos) => Display.GetCellIndexFromMousePos(pos);
	public Point GetCellPosFromMousePos(Point pos) => Display.GetCellPosFromMousePos(pos);
}

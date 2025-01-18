using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace TileGameLib.GraphicsBase;

/// <summary>
///		UI control for managing and displaying a <see cref="TileCanvas"/>.
///		Can optionally display a grid, cell selection, and cell text on top of the canvas.
/// </summary>
public partial class TileDisplay : Control
{
	//================================
	//	Public data
	//================================

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public TileCanvas Canvas { get; set; }

	public int Cols => Canvas.Cols;
	public int Rows => Canvas.Rows;
	public int LastCol => Canvas.LastCol;
	public int LastRow => Canvas.LastRow;
	public int CellCount => Canvas.CellCount;
	public int CellWidth => Canvas.CellWidth;
	public int CellHeight => Canvas.CellHeight;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool ShowGrid { get; set; } = true;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Color GridColor
	{
		get => gridColor;
		set
		{
			gridColor = value;
			CreateGrid();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int Zoom
	{
		get => zoom;
		set
		{
			if (value < MinZoom) zoom = MinZoom;
			else if (value > MaxZoom) zoom = MaxZoom;
			else zoom = value;

			UpdateSize();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Color SelectionColor { get; set; } = Color.FromArgb(80, Color.Blue);

	//================================
	//	Protected data
	//================================

	protected int zoom = 1;
	protected const int MinZoom = 1;
	protected const int MaxZoom = 10;
	protected Bitmap grid = new(1, 1);
	protected Color gridColor = Color.FromArgb(80, 128, 128, 128);
	protected readonly HashSet<Point> SelectedCells = [];
	protected readonly List<Tuple<Point, string>> CellText = [];

	//================================
	//	Constructor
	//================================

	public TileDisplay(int cols, int rows, int cellWidth, int cellHeight, Color color)
	{
		InitializeComponent();

		ParentChanged += TileDisplay_ParentChanged;

		Margin = new Padding(0);
		Padding = new Padding(0);
		DoubleBuffered = true;
		Canvas = new TileCanvas(cols, rows, cellWidth, cellHeight, color);

		UpdateSize();
	}

	//================================
	//	Get cell from mouse position
	//================================

	public Point GetCellPosFromMousePos(Point point)
	{
		return new Point
		{
			X = point.X / (Zoom * CellWidth),
			Y = point.Y / (Zoom * CellHeight)
		};
	}

	public int GetCellIndexFromMousePos(Point point)
	{
		Point cellPos = GetCellPosFromMousePos(point);
		return (cellPos.Y * Canvas.Cols) + cellPos.X;
	}

	//================================
	//	Cell selection
	//================================

	public void SelectCell(int x, int y) => SelectCell(new Point(x, y));
	public void SelectCell(Point cellPos) => SelectedCells.Add(cellPos);

	public void SelectAllCells() => SelectCellRegion(0, 0, LastCol, LastRow);

	public void SelectCellRegion(int x1, int y1, int x2, int y2) => 
		SelectCellRegion(new Point(x1, y1), new Point(x2, y2));

	public void SelectCellRegion(Point topLeftCell, Point bottomRightCell)
	{
		for (int row = topLeftCell.Y; row <= bottomRightCell.Y; row++)
			for (int col = topLeftCell.X; col <= bottomRightCell.X; col++)
				SelectCell(col, row);
	}

	//================================
	//	Cell text
	//================================

	public void SetCellText(int x, int y, string text) => CellText.Add(new(new Point(x, y), text));
	public void SetCellText(Point cellPos, string text) => CellText.Add(new(cellPos, text));

	//================================
	//	Grid
	//================================

	protected void CreateGrid()
	{
		grid = new Bitmap(Width, Height);
		using Graphics g = Graphics.FromImage(grid);
		using Pen gridPen = new(GridColor);

		g.Clear(Color.FromArgb(0));

		int incY = Zoom * CellHeight;
		for (int y = -1; y < Height; y += incY)
			g.DrawLine(gridPen, 0, y, Width, y);
		int incX = Zoom * CellWidth;
		for (int x = -1; x < Width; x += incX)
			g.DrawLine(gridPen, x, 0, x, Height);
	}

	//================================
	//	Control painting
	//================================

	protected override void OnPaint(PaintEventArgs e)
	{
		Graphics g = e.Graphics;

		g.InterpolationMode = InterpolationMode.NearestNeighbor;
		g.SmoothingMode = SmoothingMode.None;
		g.PixelOffsetMode = PixelOffsetMode.Half;
		g.CompositingQuality = CompositingQuality.HighSpeed;
		g.CompositingMode = CompositingMode.SourceCopy;

		PaintCanvas(g);

		g.InterpolationMode = InterpolationMode.Default;
		g.SmoothingMode = SmoothingMode.Default;
		g.PixelOffsetMode = PixelOffsetMode.Default;
		g.CompositingQuality = CompositingQuality.Default;
		g.CompositingMode = CompositingMode.SourceOver;

		if (ShowGrid)
			PaintGrid(g);
		if (SelectedCells.Count > 0)
			PaintSelection(g);
		if (CellText.Count > 0)
			PaintCellText(g);
	}

	protected void PaintCanvas(Graphics g)
	{
		g.DrawImage(Canvas.Buffer.Bitmap, 0, 0, Zoom * Canvas.Width, Zoom * Canvas.Height);
	}

	protected void PaintGrid(Graphics g)
	{
		g.DrawImage(grid, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
	}

	protected void PaintSelection(Graphics g)
	{
		foreach (Point pos in SelectedCells)
		{
			int x = pos.X * Zoom * CellWidth;
			int y = pos.Y * Zoom * CellHeight;
			int w = Zoom * CellWidth;
			int h = Zoom * CellHeight;
			using Brush brush = new SolidBrush(SelectionColor);
			g.FillRectangle(brush, x, y, w, h);
		}
	}

	protected void PaintCellText(Graphics g)
	{
		foreach (var tuple in CellText)
		{
			Point cellPos = tuple.Item1;
			string text = tuple.Item2;

			int x = cellPos.X * Zoom * CellWidth;
			int y = cellPos.Y * Zoom * CellHeight;

			using Font font = new("Arial", 8);
			using Brush brush = new SolidBrush(Color.Black);
			g.DrawString(text, font, brush, x, y);
		}
	}


	//================================
	//	Internal utility functions
	//================================

	protected void TileDisplay_ParentChanged(object sender, EventArgs e)
	{
		if (Parent == null)
			return;

		var panel = (Panel)Parent;
		if (panel != null)
			panel.AutoScroll = true;
	}

	protected void UpdateSize()
	{
		Size = new Size(Zoom * Canvas.Width, Zoom * Canvas.Height);

		CreateGrid();
		Refresh();
	}
}

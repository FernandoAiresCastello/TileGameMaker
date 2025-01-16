using System.ComponentModel;
using System.Drawing.Drawing2D;
using TileGameLib.GraphicsBase;

namespace TileGameLib.Controls;

public partial class TileDisplay : Control
{
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public TileCanvas Canvas { get; set; }

	public int Cols => Canvas.Cols;
	public int Rows => Canvas.Rows;
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
			if (value < MinZoom)
				zoom = MinZoom;
			else if (value > MaxZoom)
				zoom = MaxZoom;
			else
				zoom = value;

			UpdateSize();
		}
	}

	protected Bitmap grid = new(1, 1);
	protected Color gridColor = Color.FromArgb(80, 128, 128, 128);
	protected int zoom = 1;
	protected const int MinZoom = 1;
	protected const int MaxZoom = 10;

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

	public Point GetCellPos(Point point)
	{
		return new Point
		{
			X = point.X / (Zoom * CellWidth),
			Y = point.Y / (Zoom * CellHeight)
		};
	}

	public int GetCellIndex(Point point)
	{
		Point cellPos = GetCellPos(point);
		return (cellPos.Y * Canvas.Cols) + cellPos.X;
	}

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

	protected override void OnPaint(PaintEventArgs e)
	{
		PaintCanvas(e.Graphics);

		if (ShowGrid)
			PaintGrid(e.Graphics);
	}

	protected void PaintCanvas(Graphics g)
	{
		g.InterpolationMode = InterpolationMode.NearestNeighbor;
		g.SmoothingMode = SmoothingMode.None;
		g.PixelOffsetMode = PixelOffsetMode.Half;
		g.CompositingQuality = CompositingQuality.HighSpeed;
		g.CompositingMode = CompositingMode.SourceCopy;

		g.DrawImage(Canvas.Buffer.Bitmap, 0, 0, Zoom * Canvas.Width, Zoom * Canvas.Height);
	}

	protected void PaintGrid(Graphics g)
	{
		g.InterpolationMode = InterpolationMode.Default;
		g.SmoothingMode = SmoothingMode.Default;
		g.PixelOffsetMode = PixelOffsetMode.Default;
		g.CompositingQuality = CompositingQuality.Default;
		g.CompositingMode = CompositingMode.SourceOver;

		g.DrawImage(grid, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
	}
}

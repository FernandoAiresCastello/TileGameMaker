using System.ComponentModel;

namespace TileGameLib;

public partial class PixelCanvasDisplay : UserControl
{
	// Canvas
	public PixelCanvas Canvas => canvas;
	protected readonly PixelCanvas canvas;

	// Display mode
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool Stretch { get; set; } = false;
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int Zoom { get; set; } = 1;

	// Grid
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool ShowGrid { get; set; } = true;
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Color GridColor { get; set; } = Color.FromArgb(80, 128, 128, 128);
	private readonly Bitmap gridBitmap;

	public PixelCanvasDisplay(int canvasWidth, int canvasHeight, Control parent)
	{
		InitializeComponent();

		Parent = parent;
		Dock = DockStyle.Fill;
		DoubleBuffered = true;

		canvas = new PixelCanvas(canvasWidth, canvasHeight);
		gridBitmap = new Bitmap(canvasWidth, canvasHeight);
	}

	~PixelCanvasDisplay()
	{
		canvas.Dispose();
	}

	public int GetSnappedX(int x) => x / (Zoom * 8) * 8;
	public int GetSnappedY(int y) => y / (Zoom * 8) * 8;
	public int GetTiledX(int x) => x / (Zoom * 8);
	public int GetTiledY(int y) => y / (Zoom * 8);

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);

		e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
		e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;

		if (Stretch)
			e.Graphics.DrawImage(canvas.GetBitmap(), ClientRectangle);
		else
			e.Graphics.DrawImage(canvas.GetBitmap(), 0, 0, Zoom * canvas.Width, Zoom * canvas.Height);

		if (ShowGrid && !Stretch)
		{
			DrawGrid();

			e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
			e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
			e.Graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
			e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;

			e.Graphics.DrawImage(gridBitmap, 0, 0, Zoom * canvas.Width, Zoom * canvas.Height);
		}
	}

	private void DrawGrid()
	{
		Graphics g = Graphics.FromImage(gridBitmap);
		g.Clear(Color.FromArgb(0, 0, 0, 0));

		using Pen gridPen = new(GridColor);

		for (int x = 0; x < gridBitmap.Width; x += 8)
			g.DrawLine(gridPen, x, 0, x, gridBitmap.Height);
		for (int y = 0; y < gridBitmap.Height; y += 8)
			g.DrawLine(gridPen, 0, y, gridBitmap.Width, y);
	}
}

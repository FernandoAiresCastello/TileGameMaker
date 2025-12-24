using System.ComponentModel;

namespace TileGameLib;

public partial class TileDisplay : UserControl
{
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool Stretch { get; set; } = false;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int Zoom { get; set; } = 1;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool ShowGrid { get; set; } = true;

	// Canvas
	public PixelCanvas Canvas => canvas;
	private readonly PixelCanvas canvas;

	// Grid
	private readonly Bitmap gridBitmap;
	private Pen gridPen = new(Color.FromArgb(40, 255, 255, 255));

	public TileDisplay(int canvasWidth, int canvasHeight, Control parent)
	{
		InitializeComponent();

		Parent = parent;
		Dock = DockStyle.Fill;
		DoubleBuffered = true;

		canvas = new PixelCanvas(canvasWidth, canvasHeight);
		gridBitmap = new Bitmap(canvasWidth, canvasHeight);
	}

	~TileDisplay()
	{
		canvas.Dispose();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);

		e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
		e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;

		if (Stretch)
			e.Graphics.DrawImage(canvas.GetBitmap(), ClientRectangle);
		else
			e.Graphics.DrawImage(canvas.GetBitmap(), 0, 0, Zoom * canvas.Width, Zoom * canvas.Height);

		if (ShowGrid)
		{
			DrawGrid();

			e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
			e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
			e.Graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
			e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;

			if (!Stretch)
				e.Graphics.DrawImage(gridBitmap, 0, 0, Zoom * canvas.Width, Zoom * canvas.Height);
		}
	}

	private void DrawGrid()
	{
		Graphics g = Graphics.FromImage(gridBitmap);

		for (int x = 0; x < gridBitmap.Width; x += 8)
			g.DrawLine(gridPen, x, 0, x, gridBitmap.Height);
		for (int y = 0; y < gridBitmap.Height; y += 8)
			g.DrawLine(gridPen, 0, y, gridBitmap.Width, y);
	}
}

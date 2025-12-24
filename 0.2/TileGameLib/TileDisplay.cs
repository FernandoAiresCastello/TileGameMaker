using System.ComponentModel;

namespace TileGameLib;

public partial class TileDisplay : UserControl
{
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool Stretch { get; set; } = false;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int Zoom { get; set; } = 1;

	public PixelCanvas Canvas => canvas;


	public readonly PixelCanvas canvas;

	public TileDisplay(int canvasWidth, int canvasHeight, Control parent)
	{
		InitializeComponent();

		canvas = new PixelCanvas(canvasWidth, canvasHeight);
		
		Parent = parent;
		Dock = DockStyle.Fill;
		DoubleBuffered = true;
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
	}
}

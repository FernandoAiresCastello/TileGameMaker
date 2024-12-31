using System.ComponentModel;
using System.Drawing.Drawing2D;
using TileGameLib.GraphicsBase;

namespace TileGameLib.Controls;

public partial class TileDisplay : Control
{
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public TileCanvas Canvas { get; set; }
	public PixelBuffer Image => Canvas.Buffer;

	protected int CurrentZoom = 1;
	protected int MinZoom = 1;
	protected int MaxZoom = 10;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int Zoom
	{
		get => CurrentZoom;

		set
		{
			if (value < MinZoom)
				CurrentZoom = MinZoom;
			else if (value > MaxZoom)
				CurrentZoom = MaxZoom;
			else
				CurrentZoom = value;

			UpdateSize();
		}
	}

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

	private void TileDisplay_ParentChanged(object? sender, EventArgs e)
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
		Refresh();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		Graphics g = e.Graphics;
		g.InterpolationMode = InterpolationMode.NearestNeighbor;
		g.SmoothingMode = SmoothingMode.None;
		g.PixelOffsetMode = PixelOffsetMode.Half;
		g.CompositingQuality = CompositingQuality.HighSpeed;
		g.CompositingMode = CompositingMode.SourceCopy;

		g.DrawImage(Canvas.Bitmap, 0, 0, Zoom * Canvas.Width, Zoom * Canvas.Height);
	}
}

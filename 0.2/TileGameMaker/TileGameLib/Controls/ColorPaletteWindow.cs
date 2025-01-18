using System.ComponentModel;
using TileGameLib.ExtensionMethods;

namespace TileGameLib.Controls;

/// <summary>
///		A window that displays a grid of colors from a <see cref="Util.ColorPalette"/> and
///		allows selection of a color with a mouse click.
/// </summary>
public partial class ColorPaletteWindow : Form
{
	/// <summary>
	///		Callback for when a color gets selected.
	///		The selected color and mouse button that was pressed, 
	///		along with a reference to this window, are passed as arguments.
	/// </summary>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Action<Form, Color?, MouseButtons> OnColorClicked { get; set; }

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public string DefaultTitle;

	private readonly ColorPalettePanel PalettePanel;

	public ColorPaletteWindow(int cols, int rows, int cellWidth, int cellHeight, int zoom, Color emptyColor)
	{
		InitializeComponent();

		PalettePanel = new ColorPalettePanel(cols, rows, cellWidth, cellHeight, zoom, emptyColor)
		{
			Parent = RootPanel,
			Dock = DockStyle.Fill,
			OnMouseMoved = Panel_MouseMove,
			OnMouseClicked = Panel_MouseClick,
			OnMouseExit = Panel_MouseExit
		};

		Padding = new Padding(5);
		RootPanel.Dock = DockStyle.Fill;
		RootPanel.BorderStyle = BorderStyle.Fixed3D;
		Size = new Size(286, 309);

		Shown += ColorPaletteWindow_Shown;
	}

	private void ColorPaletteWindow_Shown(object sender, EventArgs e)
	{
		Text = DefaultTitle;
	}

	public void SetColors(List<string> hexColors)
	{
		PalettePanel.SetColors(hexColors);
	}

	public void SetColors(List<Color> colors)
	{
		PalettePanel.SetColors(colors);
	}

	public void LoadColors(string path)
	{
		PalettePanel.LoadColors(path);
	}

	private void Panel_MouseClick(MouseButtons button, Point pos)
	{
		Color? color = PalettePanel.GetColorAtMousePos(pos);
		OnColorClicked?.Invoke(this, color, button);
	}

	private void Panel_MouseMove(MouseButtons button, Point pos)
	{
		int cellIndex = PalettePanel.GetCellIndex(pos);
		Text = $"Index: {cellIndex} (#{cellIndex:X2})";

		Color? color = PalettePanel.GetColorAtMousePos(pos);
		if (color != null)
			Text += $" | RGB: #{color.Value.ToHex()}";
	}

	private void Panel_MouseExit()
	{
		Text = DefaultTitle;
	}
}

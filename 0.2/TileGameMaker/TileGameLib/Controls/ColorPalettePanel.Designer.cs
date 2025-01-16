namespace TileGameLib.Controls
{
	partial class ColorPalettePanel
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			RootPanel = new Panel();
			SuspendLayout();
			// 
			// RootPanel
			// 
			RootPanel.Dock = DockStyle.Fill;
			RootPanel.Location = new Point(0, 0);
			RootPanel.Name = "RootPanel";
			RootPanel.Size = new Size(279, 354);
			RootPanel.TabIndex = 0;
			// 
			// ColorPalettePanel
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(RootPanel);
			Name = "ColorPalettePanel";
			Size = new Size(279, 354);
			ResumeLayout(false);
		}

		#endregion

		private Panel RootPanel;
	}
}

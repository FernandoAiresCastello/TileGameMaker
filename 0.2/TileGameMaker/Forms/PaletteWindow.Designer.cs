namespace TileGameMaker.Forms
{
	partial class PaletteWindow
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			PnlPalette = new Panel();
			SuspendLayout();
			// 
			// PnlPalette
			// 
			PnlPalette.Dock = DockStyle.Fill;
			PnlPalette.Location = new Point(0, 0);
			PnlPalette.Name = "PnlPalette";
			PnlPalette.Size = new Size(435, 450);
			PnlPalette.TabIndex = 0;
			// 
			// PaletteWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(435, 450);
			Controls.Add(PnlPalette);
			Name = "PaletteWindow";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Palette";
			ResumeLayout(false);
		}

		#endregion

		private Panel PnlPalette;
	}
}
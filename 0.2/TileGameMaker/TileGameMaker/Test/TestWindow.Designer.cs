namespace TileGameMaker.Test
{
	partial class TestWindow
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
			BtnColorPalette = new Button();
			DrawingPanel = new Panel();
			BtnToggleGrid = new Button();
			BtnClear = new Button();
			BtnFill = new Button();
			SuspendLayout();
			// 
			// BtnColorPalette
			// 
			BtnColorPalette.Location = new Point(12, 12);
			BtnColorPalette.Name = "BtnColorPalette";
			BtnColorPalette.Size = new Size(104, 23);
			BtnColorPalette.TabIndex = 0;
			BtnColorPalette.Text = "Select color";
			BtnColorPalette.UseVisualStyleBackColor = true;
			BtnColorPalette.Click += BtnColorPalette_Click;
			// 
			// DrawingPanel
			// 
			DrawingPanel.BorderStyle = BorderStyle.Fixed3D;
			DrawingPanel.Location = new Point(133, 12);
			DrawingPanel.Name = "DrawingPanel";
			DrawingPanel.Size = new Size(516, 388);
			DrawingPanel.TabIndex = 1;
			// 
			// BtnToggleGrid
			// 
			BtnToggleGrid.Location = new Point(12, 41);
			BtnToggleGrid.Name = "BtnToggleGrid";
			BtnToggleGrid.Size = new Size(104, 23);
			BtnToggleGrid.TabIndex = 2;
			BtnToggleGrid.Text = "Toggle grid";
			BtnToggleGrid.UseVisualStyleBackColor = true;
			BtnToggleGrid.Click += BtnToggleGrid_Click;
			// 
			// BtnClear
			// 
			BtnClear.Location = new Point(12, 70);
			BtnClear.Name = "BtnClear";
			BtnClear.Size = new Size(104, 23);
			BtnClear.TabIndex = 3;
			BtnClear.Text = "Clear";
			BtnClear.UseVisualStyleBackColor = true;
			BtnClear.Click += BtnClear_Click;
			// 
			// BtnFill
			// 
			BtnFill.Location = new Point(12, 99);
			BtnFill.Name = "BtnFill";
			BtnFill.Size = new Size(104, 23);
			BtnFill.TabIndex = 4;
			BtnFill.Text = "Fill";
			BtnFill.UseVisualStyleBackColor = true;
			BtnFill.Click += BtnFill_Click;
			// 
			// TestWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(659, 411);
			Controls.Add(BtnFill);
			Controls.Add(BtnClear);
			Controls.Add(BtnToggleGrid);
			Controls.Add(DrawingPanel);
			Controls.Add(BtnColorPalette);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "TestWindow";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "TileGameMaker - Test Window";
			ResumeLayout(false);
		}

		#endregion

		private Button BtnColorPalette;
		private Panel DrawingPanel;
		private Button BtnToggleGrid;
		private Button BtnClear;
		private Button BtnFill;
	}
}
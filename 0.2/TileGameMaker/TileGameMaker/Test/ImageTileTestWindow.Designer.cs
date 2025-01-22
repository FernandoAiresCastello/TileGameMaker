namespace TileGameMaker.Test
{
	partial class ImageTileTestWindow
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
			DrawingPanel = new Panel();
			BtnToggleGrid = new Button();
			BtnClear = new Button();
			BtnFill = new Button();
			BtnNorth = new Button();
			BtnSouth = new Button();
			BtnEast = new Button();
			BtnWest = new Button();
			TxtDebug = new TextBox();
			BtnOrigin = new Button();
			BtnCanvasColor = new Button();
			BtnSaveImage = new Button();
			SuspendLayout();
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
			BtnToggleGrid.Location = new Point(12, 12);
			BtnToggleGrid.Name = "BtnToggleGrid";
			BtnToggleGrid.Size = new Size(104, 23);
			BtnToggleGrid.TabIndex = 2;
			BtnToggleGrid.TabStop = false;
			BtnToggleGrid.Text = "Toggle grid";
			BtnToggleGrid.UseVisualStyleBackColor = true;
			BtnToggleGrid.Click += BtnToggleGrid_Click;
			// 
			// BtnClear
			// 
			BtnClear.Location = new Point(11, 141);
			BtnClear.Name = "BtnClear";
			BtnClear.Size = new Size(104, 23);
			BtnClear.TabIndex = 3;
			BtnClear.TabStop = false;
			BtnClear.Text = "Clear";
			BtnClear.UseVisualStyleBackColor = true;
			BtnClear.Click += BtnClear_Click;
			// 
			// BtnFill
			// 
			BtnFill.Location = new Point(12, 112);
			BtnFill.Name = "BtnFill";
			BtnFill.Size = new Size(104, 23);
			BtnFill.TabIndex = 4;
			BtnFill.TabStop = false;
			BtnFill.Text = "Fill";
			BtnFill.UseVisualStyleBackColor = true;
			BtnFill.Click += BtnFill_Click;
			// 
			// BtnNorth
			// 
			BtnNorth.Location = new Point(49, 331);
			BtnNorth.Name = "BtnNorth";
			BtnNorth.Size = new Size(33, 23);
			BtnNorth.TabIndex = 5;
			BtnNorth.TabStop = false;
			BtnNorth.Text = "N";
			BtnNorth.UseVisualStyleBackColor = true;
			BtnNorth.Click += BtnNorth_Click;
			// 
			// BtnSouth
			// 
			BtnSouth.Location = new Point(49, 377);
			BtnSouth.Name = "BtnSouth";
			BtnSouth.Size = new Size(33, 23);
			BtnSouth.TabIndex = 6;
			BtnSouth.TabStop = false;
			BtnSouth.Text = "S";
			BtnSouth.UseVisualStyleBackColor = true;
			BtnSouth.Click += BtnSouth_Click;
			// 
			// BtnEast
			// 
			BtnEast.Location = new Point(82, 354);
			BtnEast.Name = "BtnEast";
			BtnEast.Size = new Size(33, 23);
			BtnEast.TabIndex = 7;
			BtnEast.TabStop = false;
			BtnEast.Text = "E";
			BtnEast.UseVisualStyleBackColor = true;
			BtnEast.Click += BtnEast_Click;
			// 
			// BtnWest
			// 
			BtnWest.Location = new Point(16, 354);
			BtnWest.Name = "BtnWest";
			BtnWest.Size = new Size(33, 23);
			BtnWest.TabIndex = 8;
			BtnWest.TabStop = false;
			BtnWest.Text = "W";
			BtnWest.UseVisualStyleBackColor = true;
			BtnWest.Click += BtnWest_Click;
			// 
			// TxtDebug
			// 
			TxtDebug.Enabled = false;
			TxtDebug.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			TxtDebug.Location = new Point(11, 412);
			TxtDebug.Multiline = true;
			TxtDebug.Name = "TxtDebug";
			TxtDebug.ReadOnly = true;
			TxtDebug.Size = new Size(638, 65);
			TxtDebug.TabIndex = 9;
			TxtDebug.TabStop = false;
			// 
			// BtnOrigin
			// 
			BtnOrigin.Location = new Point(49, 354);
			BtnOrigin.Name = "BtnOrigin";
			BtnOrigin.Size = new Size(33, 23);
			BtnOrigin.TabIndex = 10;
			BtnOrigin.TabStop = false;
			BtnOrigin.Text = "O";
			BtnOrigin.UseVisualStyleBackColor = true;
			BtnOrigin.Click += BtnOrigin_Click;
			// 
			// BtnCanvasColor
			// 
			BtnCanvasColor.Location = new Point(12, 41);
			BtnCanvasColor.Name = "BtnCanvasColor";
			BtnCanvasColor.Size = new Size(104, 23);
			BtnCanvasColor.TabIndex = 11;
			BtnCanvasColor.TabStop = false;
			BtnCanvasColor.Text = "Canvas color";
			BtnCanvasColor.UseVisualStyleBackColor = true;
			BtnCanvasColor.Click += BtnCanvasColor_Click;
			// 
			// BtnSaveImage
			// 
			BtnSaveImage.Location = new Point(11, 170);
			BtnSaveImage.Name = "BtnSaveImage";
			BtnSaveImage.Size = new Size(104, 23);
			BtnSaveImage.TabIndex = 12;
			BtnSaveImage.TabStop = false;
			BtnSaveImage.Text = "Save image";
			BtnSaveImage.UseVisualStyleBackColor = true;
			BtnSaveImage.Click += BtnSaveImage_Click;
			// 
			// ImageTileTestWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(659, 488);
			Controls.Add(BtnSaveImage);
			Controls.Add(BtnCanvasColor);
			Controls.Add(BtnOrigin);
			Controls.Add(TxtDebug);
			Controls.Add(BtnWest);
			Controls.Add(BtnEast);
			Controls.Add(BtnSouth);
			Controls.Add(BtnNorth);
			Controls.Add(BtnFill);
			Controls.Add(BtnClear);
			Controls.Add(BtnToggleGrid);
			Controls.Add(DrawingPanel);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "ImageTileTestWindow";
			Text = "TileGameMaker - Test Window";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Panel DrawingPanel;
		private Button BtnToggleGrid;
		private Button BtnClear;
		private Button BtnFill;
		private Button BtnNorth;
		private Button BtnSouth;
		private Button BtnEast;
		private Button BtnWest;
		private TextBox TxtDebug;
		private Button BtnOrigin;
		private Button BtnCanvasColor;
		private Button BtnSaveImage;
	}
}
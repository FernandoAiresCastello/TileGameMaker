namespace TileGameMaker.Forms
{
    partial class BoardWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			toolStrip1 = new ToolStrip();
			BtnLoad = new ToolStripButton();
			BtnSave = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			BtnPencil = new ToolStripButton();
			BtnEraser = new ToolStripButton();
			BtnDirections = new ToolStripButton();
			toolStripSeparator2 = new ToolStripSeparator();
			BtnGridToggle = new ToolStripButton();
			BtnLayer = new ToolStripButton();
			PnlBoard = new Panel();
			tableLayoutPanel1 = new TableLayoutPanel();
			panel1 = new Panel();
			LbName = new Label();
			LbLayer = new ToolStripLabel();
			toolStripSeparator3 = new ToolStripSeparator();
			toolStrip1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.Items.AddRange(new ToolStripItem[] { BtnLoad, BtnSave, toolStripSeparator1, BtnPencil, BtnEraser, BtnDirections, toolStripSeparator2, BtnLayer, LbLayer, toolStripSeparator3, BtnGridToggle });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(732, 25);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// BtnLoad
			// 
			BtnLoad.DisplayStyle = ToolStripItemDisplayStyle.Image;
			BtnLoad.Image = Properties.Resources.folder;
			BtnLoad.ImageTransparentColor = Color.Magenta;
			BtnLoad.Name = "BtnLoad";
			BtnLoad.Size = new Size(23, 22);
			BtnLoad.Text = "Load";
			BtnLoad.Click += BtnLoad_Click;
			// 
			// BtnSave
			// 
			BtnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
			BtnSave.Image = Properties.Resources.diskette;
			BtnSave.ImageTransparentColor = Color.Magenta;
			BtnSave.Name = "BtnSave";
			BtnSave.Size = new Size(23, 22);
			BtnSave.Text = "Save";
			BtnSave.Click += BtnSave_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 25);
			// 
			// BtnPencil
			// 
			BtnPencil.Checked = true;
			BtnPencil.CheckOnClick = true;
			BtnPencil.CheckState = CheckState.Checked;
			BtnPencil.DisplayStyle = ToolStripItemDisplayStyle.Image;
			BtnPencil.Image = Properties.Resources.pencil;
			BtnPencil.ImageTransparentColor = Color.Magenta;
			BtnPencil.Name = "BtnPencil";
			BtnPencil.Size = new Size(23, 22);
			BtnPencil.Text = "Draw";
			BtnPencil.Click += BtnPencil_Click;
			// 
			// BtnEraser
			// 
			BtnEraser.CheckOnClick = true;
			BtnEraser.DisplayStyle = ToolStripItemDisplayStyle.Image;
			BtnEraser.Image = Properties.Resources.draw_eraser;
			BtnEraser.ImageTransparentColor = Color.Magenta;
			BtnEraser.Name = "BtnEraser";
			BtnEraser.Size = new Size(23, 22);
			BtnEraser.Text = "Eraser";
			BtnEraser.Click += BtnEraser_Click;
			// 
			// BtnDirections
			// 
			BtnDirections.DisplayStyle = ToolStripItemDisplayStyle.Image;
			BtnDirections.Image = Properties.Resources.direction;
			BtnDirections.ImageTransparentColor = Color.Magenta;
			BtnDirections.Name = "BtnDirections";
			BtnDirections.Size = new Size(23, 22);
			BtnDirections.Text = "Directions";
			BtnDirections.Click += BtnDirections_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 25);
			// 
			// BtnGridToggle
			// 
			BtnGridToggle.Checked = true;
			BtnGridToggle.CheckOnClick = true;
			BtnGridToggle.CheckState = CheckState.Checked;
			BtnGridToggle.DisplayStyle = ToolStripItemDisplayStyle.Image;
			BtnGridToggle.Image = Properties.Resources.layouts_four_grid;
			BtnGridToggle.ImageTransparentColor = Color.Magenta;
			BtnGridToggle.Name = "BtnGridToggle";
			BtnGridToggle.Size = new Size(23, 22);
			BtnGridToggle.Text = "Toggle grid";
			BtnGridToggle.Click += BtnGridToggle_Click;
			// 
			// BtnLayer
			// 
			BtnLayer.CheckOnClick = true;
			BtnLayer.DisplayStyle = ToolStripItemDisplayStyle.Image;
			BtnLayer.Image = Properties.Resources.layer_arrange;
			BtnLayer.ImageTransparentColor = Color.Magenta;
			BtnLayer.Name = "BtnLayer";
			BtnLayer.Size = new Size(23, 22);
			BtnLayer.Text = "Switch layer";
			BtnLayer.Click += BtnLayer_Click;
			// 
			// PnlBoard
			// 
			PnlBoard.Dock = DockStyle.Fill;
			PnlBoard.Location = new Point(0, 30);
			PnlBoard.Margin = new Padding(0);
			PnlBoard.Name = "PnlBoard";
			PnlBoard.Size = new Size(732, 576);
			PnlBoard.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(PnlBoard, 0, 1);
			tableLayoutPanel1.Controls.Add(panel1, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 25);
			tableLayoutPanel1.Margin = new Padding(0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(732, 606);
			tableLayoutPanel1.TabIndex = 2;
			// 
			// panel1
			// 
			panel1.Controls.Add(LbName);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(0);
			panel1.Name = "panel1";
			panel1.Size = new Size(732, 30);
			panel1.TabIndex = 2;
			// 
			// LbName
			// 
			LbName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			LbName.Location = new Point(7, 2);
			LbName.Name = "LbName";
			LbName.Size = new Size(713, 23);
			LbName.TabIndex = 0;
			LbName.Text = "Board Name";
			// 
			// LbLayer
			// 
			LbLayer.Name = "LbLayer";
			LbLayer.Size = new Size(35, 22);
			LbLayer.Text = "Layer";
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(6, 25);
			// 
			// BoardWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(732, 631);
			ControlBox = false;
			Controls.Add(tableLayoutPanel1);
			Controls.Add(toolStrip1);
			MaximizeBox = false;
			Name = "BoardWindow";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Board";
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			tableLayoutPanel1.ResumeLayout(false);
			panel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStrip toolStrip1;
		private Panel PnlBoard;
		private ToolStripButton BtnGridToggle;
		private ToolStripButton BtnLoad;
		private ToolStripButton BtnSave;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton BtnEraser;
		private ToolStripButton BtnPencil;
		private ToolStripSeparator toolStripSeparator2;
		private TableLayoutPanel tableLayoutPanel1;
		private Panel panel1;
		private Label LbName;
		private ToolStripButton BtnDirections;
		private ToolStripButton BtnLayer;
		private ToolStripLabel LbLayer;
		private ToolStripSeparator toolStripSeparator3;
	}
}

namespace TileGameMaker
{
    partial class MainWindow
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
			menuStrip1 = new MenuStrip();
			statusStrip1 = new StatusStrip();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			PnlDisplay = new Panel();
			toolStrip1 = new ToolStrip();
			tableLayoutPanel3 = new TableLayoutPanel();
			tableLayoutPanel5 = new TableLayoutPanel();
			PnlPalette = new Panel();
			toolStrip3 = new ToolStrip();
			tableLayoutPanel4 = new TableLayoutPanel();
			PnlCharset = new Panel();
			toolStrip2 = new ToolStrip();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tableLayoutPanel5.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(753, 24);
			menuStrip1.TabIndex = 2;
			menuStrip1.Text = "menuStrip1";
			// 
			// statusStrip1
			// 
			statusStrip1.Location = new Point(0, 495);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(753, 22);
			statusStrip1.TabIndex = 3;
			statusStrip1.Text = "statusStrip1";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 24);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(753, 471);
			tableLayoutPanel1.TabIndex = 4;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Controls.Add(PnlDisplay, 0, 1);
			tableLayoutPanel2.Controls.Add(toolStrip1, 0, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(256, 0);
			tableLayoutPanel2.Margin = new Padding(5, 0, 5, 0);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Size = new Size(492, 471);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// PnlDisplay
			// 
			PnlDisplay.BorderStyle = BorderStyle.Fixed3D;
			PnlDisplay.Dock = DockStyle.Fill;
			PnlDisplay.Location = new Point(0, 25);
			PnlDisplay.Margin = new Padding(0);
			PnlDisplay.Name = "PnlDisplay";
			PnlDisplay.Size = new Size(492, 446);
			PnlDisplay.TabIndex = 3;
			// 
			// toolStrip1
			// 
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(492, 25);
			toolStrip1.TabIndex = 4;
			toolStrip1.Text = "toolStrip1";
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
			tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(5, 0);
			tableLayoutPanel3.Margin = new Padding(5, 0, 0, 0);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 2;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Size = new Size(246, 471);
			tableLayoutPanel3.TabIndex = 1;
			// 
			// tableLayoutPanel5
			// 
			tableLayoutPanel5.ColumnCount = 1;
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel5.Controls.Add(PnlPalette, 0, 1);
			tableLayoutPanel5.Controls.Add(toolStrip3, 0, 0);
			tableLayoutPanel5.Dock = DockStyle.Fill;
			tableLayoutPanel5.Location = new Point(0, 235);
			tableLayoutPanel5.Margin = new Padding(0);
			tableLayoutPanel5.Name = "tableLayoutPanel5";
			tableLayoutPanel5.RowCount = 2;
			tableLayoutPanel5.RowStyles.Add(new RowStyle());
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel5.Size = new Size(246, 236);
			tableLayoutPanel5.TabIndex = 1;
			// 
			// PnlPalette
			// 
			PnlPalette.BorderStyle = BorderStyle.Fixed3D;
			PnlPalette.Dock = DockStyle.Fill;
			PnlPalette.Location = new Point(0, 25);
			PnlPalette.Margin = new Padding(0);
			PnlPalette.Name = "PnlPalette";
			PnlPalette.Size = new Size(246, 211);
			PnlPalette.TabIndex = 6;
			// 
			// toolStrip3
			// 
			toolStrip3.Location = new Point(0, 0);
			toolStrip3.Name = "toolStrip3";
			toolStrip3.Size = new Size(246, 25);
			toolStrip3.TabIndex = 5;
			toolStrip3.Text = "toolStrip3";
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 1;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel4.Controls.Add(PnlCharset, 0, 1);
			tableLayoutPanel4.Controls.Add(toolStrip2, 0, 0);
			tableLayoutPanel4.Dock = DockStyle.Fill;
			tableLayoutPanel4.Location = new Point(0, 0);
			tableLayoutPanel4.Margin = new Padding(0);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 2;
			tableLayoutPanel4.RowStyles.Add(new RowStyle());
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel4.Size = new Size(246, 235);
			tableLayoutPanel4.TabIndex = 0;
			// 
			// PnlCharset
			// 
			PnlCharset.BorderStyle = BorderStyle.Fixed3D;
			PnlCharset.Dock = DockStyle.Fill;
			PnlCharset.Location = new Point(0, 25);
			PnlCharset.Margin = new Padding(0);
			PnlCharset.Name = "PnlCharset";
			PnlCharset.Size = new Size(246, 210);
			PnlCharset.TabIndex = 6;
			// 
			// toolStrip2
			// 
			toolStrip2.Location = new Point(0, 0);
			toolStrip2.Name = "toolStrip2";
			toolStrip2.Size = new Size(246, 25);
			toolStrip2.TabIndex = 5;
			toolStrip2.Text = "toolStrip2";
			// 
			// MainWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(753, 517);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(statusStrip1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "MainWindow";
			StartPosition = FormStartPosition.CenterScreen;
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel5.ResumeLayout(false);
			tableLayoutPanel5.PerformLayout();
			tableLayoutPanel4.ResumeLayout(false);
			tableLayoutPanel4.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private MenuStrip menuStrip1;
		private StatusStrip statusStrip1;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private Panel PnlDisplay;
		private ToolStrip toolStrip1;
		private TableLayoutPanel tableLayoutPanel3;
		private TableLayoutPanel tableLayoutPanel5;
		private ToolStrip toolStrip3;
		private TableLayoutPanel tableLayoutPanel4;
		private ToolStrip toolStrip2;
		private Panel PnlPalette;
		private Panel PnlCharset;
	}
}

namespace TileGameEngine
{
	partial class GameWindow
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
			tableLayoutPanel1 = new TableLayoutPanel();
			PnlBoard = new Panel();
			PnlTitle = new Panel();
			LbTitle = new Label();
			tableLayoutPanel1.SuspendLayout();
			PnlTitle.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(PnlBoard, 0, 0);
			tableLayoutPanel1.Controls.Add(PnlTitle, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(937, 684);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// PnlBoard
			// 
			PnlBoard.Dock = DockStyle.Fill;
			PnlBoard.Location = new Point(0, 32);
			PnlBoard.Margin = new Padding(0);
			PnlBoard.Name = "PnlBoard";
			PnlBoard.Size = new Size(937, 652);
			PnlBoard.TabIndex = 0;
			// 
			// PnlTitle
			// 
			PnlTitle.BackColor = SystemColors.Control;
			PnlTitle.Controls.Add(LbTitle);
			PnlTitle.Dock = DockStyle.Fill;
			PnlTitle.ForeColor = SystemColors.WindowText;
			PnlTitle.Location = new Point(0, 0);
			PnlTitle.Margin = new Padding(0);
			PnlTitle.Name = "PnlTitle";
			PnlTitle.Size = new Size(937, 32);
			PnlTitle.TabIndex = 1;
			// 
			// LbTitle
			// 
			LbTitle.BackColor = Color.Black;
			LbTitle.Dock = DockStyle.Fill;
			LbTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			LbTitle.ForeColor = Color.White;
			LbTitle.Location = new Point(0, 0);
			LbTitle.Name = "LbTitle";
			LbTitle.Size = new Size(937, 32);
			LbTitle.TabIndex = 0;
			LbTitle.Text = "Map Name";
			LbTitle.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// GameWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(937, 684);
			Controls.Add(tableLayoutPanel1);
			Name = "GameWindow";
			StartPosition = FormStartPosition.CenterScreen;
			tableLayoutPanel1.ResumeLayout(false);
			PnlTitle.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Panel PnlBoard;
		private Panel PnlTitle;
		private Label LbTitle;
	}
}

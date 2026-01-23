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
			PnlBoard = new Panel();
			SuspendLayout();
			// 
			// PnlBoard
			// 
			PnlBoard.Dock = DockStyle.Fill;
			PnlBoard.Location = new Point(0, 0);
			PnlBoard.Margin = new Padding(0);
			PnlBoard.Name = "PnlBoard";
			PnlBoard.Size = new Size(581, 517);
			PnlBoard.TabIndex = 0;
			// 
			// MainWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(581, 517);
			Controls.Add(PnlBoard);
			Name = "MainWindow";
			StartPosition = FormStartPosition.CenterScreen;
			ResumeLayout(false);
		}

		#endregion

		private Panel PnlBoard;
	}
}

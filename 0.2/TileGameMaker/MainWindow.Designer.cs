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
			PnlDisplay = new Panel();
			SuspendLayout();
			// 
			// PnlDisplay
			// 
			PnlDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			PnlDisplay.BorderStyle = BorderStyle.Fixed3D;
			PnlDisplay.Location = new Point(52, 27);
			PnlDisplay.Name = "PnlDisplay";
			PnlDisplay.Size = new Size(567, 404);
			PnlDisplay.TabIndex = 0;
			// 
			// MainWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(684, 480);
			Controls.Add(PnlDisplay);
			Name = "MainWindow";
			StartPosition = FormStartPosition.CenterScreen;
			ResumeLayout(false);
		}

		#endregion

		private Panel PnlDisplay;
	}
}

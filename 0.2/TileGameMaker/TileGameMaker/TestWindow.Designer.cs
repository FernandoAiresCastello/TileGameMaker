namespace TileGameMaker
{
    partial class TestWindow
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
			RootPanel = new Panel();
			SuspendLayout();
			// 
			// RootPanel
			// 
			RootPanel.Dock = DockStyle.Fill;
			RootPanel.Location = new Point(0, 0);
			RootPanel.Name = "RootPanel";
			RootPanel.Size = new Size(480, 334);
			RootPanel.TabIndex = 0;
			// 
			// TestWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(480, 334);
			Controls.Add(RootPanel);
			Name = "TestWindow";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "TileGameMaker - Test Window";
			ResumeLayout(false);
		}

		#endregion

		private Panel RootPanel;
	}
}

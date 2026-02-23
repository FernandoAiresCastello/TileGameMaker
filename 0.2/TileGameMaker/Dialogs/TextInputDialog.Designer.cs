namespace TileGameMaker.Dialogs
{
	partial class TextInputDialog
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
			TxtText = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// TxtText
			// 
			TxtText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			TxtText.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			TxtText.Location = new Point(12, 12);
			TxtText.Multiline = true;
			TxtText.Name = "TxtText";
			TxtText.ScrollBars = ScrollBars.Vertical;
			TxtText.Size = new Size(460, 390);
			TxtText.TabIndex = 0;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(195, 411);
			button1.Name = "button1";
			button1.Size = new Size(75, 31);
			button1.TabIndex = 1;
			button1.Text = "OK";
			button1.UseVisualStyleBackColor = true;
			// 
			// TextInputDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(484, 450);
			Controls.Add(button1);
			Controls.Add(TxtText);
			Name = "TextInputDialog";
			StartPosition = FormStartPosition.CenterScreen;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox TxtText;
		private Button button1;
	}
}
namespace TileGameMaker.Dialogs
{
	partial class LineInputDialog
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
			LbPrompt = new Label();
			TxtInput = new TextBox();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// LbPrompt
			// 
			LbPrompt.AutoSize = true;
			LbPrompt.Location = new Point(12, 12);
			LbPrompt.Name = "LbPrompt";
			LbPrompt.Size = new Size(47, 15);
			LbPrompt.TabIndex = 0;
			LbPrompt.Text = "Prompt";
			// 
			// TxtInput
			// 
			TxtInput.Location = new Point(12, 37);
			TxtInput.Name = "TxtInput";
			TxtInput.Size = new Size(486, 23);
			TxtInput.TabIndex = 1;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(423, 71);
			button1.Name = "button1";
			button1.Size = new Size(75, 30);
			button1.TabIndex = 2;
			button1.Text = "OK";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Location = new Point(342, 71);
			button2.Name = "button2";
			button2.Size = new Size(75, 30);
			button2.TabIndex = 3;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			// 
			// LineInputDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(510, 111);
			ControlBox = false;
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(TxtInput);
			Controls.Add(LbPrompt);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "LineInputDialog";
			StartPosition = FormStartPosition.CenterScreen;
			Text = " ";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label LbPrompt;
		private TextBox TxtInput;
		private Button button1;
		private Button button2;
	}
}
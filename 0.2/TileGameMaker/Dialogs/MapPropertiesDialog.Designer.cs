namespace TileGameMaker.Dialogs
{
	partial class MapPropertiesDialog
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
			label1 = new Label();
			TxtTitle = new TextBox();
			BtnOk = new Button();
			BtnCancel = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(18, 18);
			label1.Name = "label1";
			label1.Size = new Size(29, 15);
			label1.TabIndex = 0;
			label1.Text = "Title";
			// 
			// TxtTitle
			// 
			TxtTitle.Location = new Point(60, 15);
			TxtTitle.Name = "TxtTitle";
			TxtTitle.Size = new Size(472, 23);
			TxtTitle.TabIndex = 1;
			// 
			// BtnOk
			// 
			BtnOk.DialogResult = DialogResult.OK;
			BtnOk.Location = new Point(444, 51);
			BtnOk.Name = "BtnOk";
			BtnOk.Size = new Size(88, 29);
			BtnOk.TabIndex = 6;
			BtnOk.Text = "OK";
			BtnOk.UseVisualStyleBackColor = true;
			// 
			// BtnCancel
			// 
			BtnCancel.DialogResult = DialogResult.Cancel;
			BtnCancel.Location = new Point(350, 51);
			BtnCancel.Name = "BtnCancel";
			BtnCancel.Size = new Size(88, 29);
			BtnCancel.TabIndex = 7;
			BtnCancel.Text = "Cancel";
			BtnCancel.UseVisualStyleBackColor = true;
			// 
			// MapPropertiesDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(553, 97);
			Controls.Add(BtnCancel);
			Controls.Add(BtnOk);
			Controls.Add(TxtTitle);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "MapPropertiesDialog";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Map properties";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox TxtTitle;
		private Button BtnOk;
		private Button BtnCancel;
	}
}
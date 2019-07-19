namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.pathNameLabel = new System.Windows.Forms.Label();
			this.pathNameTextBox = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.openButton = new System.Windows.Forms.Button();
			this.textTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// pathNameLabel
			// 
			this.pathNameLabel.AutoSize = true;
			this.pathNameLabel.Location = new System.Drawing.Point(12, 15);
			this.pathNameLabel.Name = "pathNameLabel";
			this.pathNameLabel.Size = new System.Drawing.Size(79, 16);
			this.pathNameLabel.TabIndex = 0;
			this.pathNameLabel.Text = "&Path Name";
			// 
			// pathNameTextBox
			// 
			this.pathNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pathNameTextBox.Location = new System.Drawing.Point(97, 12);
			this.pathNameTextBox.Name = "pathNameTextBox";
			this.pathNameTextBox.Size = new System.Drawing.Size(313, 23);
			this.pathNameTextBox.TabIndex = 1;
			this.pathNameTextBox.Text = "D:\\_TEMP\\Readme.txt";
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.Location = new System.Drawing.Point(416, 12);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 2;
			this.saveButton.Text = "&Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// openButton
			// 
			this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.openButton.Location = new System.Drawing.Point(497, 12);
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(75, 23);
			this.openButton.TabIndex = 3;
			this.openButton.Text = "&Open";
			this.openButton.UseVisualStyleBackColor = true;
			this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
			// 
			// textTextBox
			// 
			this.textTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textTextBox.Location = new System.Drawing.Point(12, 41);
			this.textTextBox.Multiline = true;
			this.textTextBox.Name = "textTextBox";
			this.textTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textTextBox.Size = new System.Drawing.Size(560, 208);
			this.textTextBox.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(584, 261);
			this.Controls.Add(this.textTextBox);
			this.Controls.Add(this.openButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.pathNameTextBox);
			this.Controls.Add(this.pathNameLabel);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(600, 300);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Read From File and Write To File";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label pathNameLabel;
		private System.Windows.Forms.TextBox pathNameTextBox;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button openButton;
		private System.Windows.Forms.TextBox textTextBox;
	}
}

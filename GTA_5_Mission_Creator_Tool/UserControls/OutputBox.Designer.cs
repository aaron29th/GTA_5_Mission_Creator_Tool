namespace GTA_5_Mission_Creator_Tool.UserControls
{
	partial class OutputBox
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.outputTextbox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// outputTextbox
			// 
			this.outputTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputTextbox.Location = new System.Drawing.Point(0, 0);
			this.outputTextbox.Name = "outputTextbox";
			this.outputTextbox.ReadOnly = true;
			this.outputTextbox.Size = new System.Drawing.Size(272, 140);
			this.outputTextbox.TabIndex = 0;
			this.outputTextbox.Text = "";
			this.outputTextbox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.outputTextbox_LinkClicked);
			// 
			// OutputBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.outputTextbox);
			this.Name = "OutputBox";
			this.Size = new System.Drawing.Size(272, 140);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox outputTextbox;
	}
}

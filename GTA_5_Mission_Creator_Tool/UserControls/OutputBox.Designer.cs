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
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 14);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Output";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(15, 40);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(685, 131);
			this.textBox3.TabIndex = 10;
			// 
			// OutputBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox3);
			this.Name = "OutputBox";
			this.Size = new System.Drawing.Size(1140, 444);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
	}
}

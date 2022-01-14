namespace GTA_5_Mission_Creator_Tool.UserControls
{
	partial class GameMemoryEditor
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
			this.descriptionSetBtn = new System.Windows.Forms.Button();
			this.descriptionGetBtn = new System.Windows.Forms.Button();
			this.titleSetBtn = new System.Windows.Forms.Button();
			this.titleGetBtn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.descriptionTextbox = new System.Windows.Forms.TextBox();
			this.titleTextbox = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// descriptionSetBtn
			// 
			this.descriptionSetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionSetBtn.Location = new System.Drawing.Point(588, 50);
			this.descriptionSetBtn.Name = "descriptionSetBtn";
			this.descriptionSetBtn.Size = new System.Drawing.Size(41, 30);
			this.descriptionSetBtn.TabIndex = 23;
			this.descriptionSetBtn.Text = "Set";
			this.descriptionSetBtn.UseVisualStyleBackColor = true;
			this.descriptionSetBtn.Click += new System.EventHandler(this.descriptionSetBtn_Click);
			// 
			// descriptionGetBtn
			// 
			this.descriptionGetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionGetBtn.Location = new System.Drawing.Point(588, 14);
			this.descriptionGetBtn.Name = "descriptionGetBtn";
			this.descriptionGetBtn.Size = new System.Drawing.Size(41, 30);
			this.descriptionGetBtn.TabIndex = 22;
			this.descriptionGetBtn.Text = "Get";
			this.descriptionGetBtn.UseVisualStyleBackColor = true;
			this.descriptionGetBtn.Click += new System.EventHandler(this.descriptionGetBtn_Click);
			// 
			// titleSetBtn
			// 
			this.titleSetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.titleSetBtn.Location = new System.Drawing.Point(588, 14);
			this.titleSetBtn.Name = "titleSetBtn";
			this.titleSetBtn.Size = new System.Drawing.Size(41, 23);
			this.titleSetBtn.TabIndex = 21;
			this.titleSetBtn.Text = "Set";
			this.titleSetBtn.UseVisualStyleBackColor = true;
			this.titleSetBtn.Click += new System.EventHandler(this.titleSetBtn_Click);
			// 
			// titleGetBtn
			// 
			this.titleGetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.titleGetBtn.Location = new System.Drawing.Point(541, 14);
			this.titleGetBtn.Name = "titleGetBtn";
			this.titleGetBtn.Size = new System.Drawing.Size(41, 23);
			this.titleGetBtn.TabIndex = 20;
			this.titleGetBtn.Text = "Get";
			this.titleGetBtn.UseVisualStyleBackColor = true;
			this.titleGetBtn.Click += new System.EventHandler(this.titleGetBtn_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 19;
			this.label4.Text = "Description";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 18;
			this.label2.Text = "Title";
			// 
			// descriptionTextbox
			// 
			this.descriptionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionTextbox.Location = new System.Drawing.Point(6, 16);
			this.descriptionTextbox.Multiline = true;
			this.descriptionTextbox.Name = "descriptionTextbox";
			this.descriptionTextbox.Size = new System.Drawing.Size(576, 64);
			this.descriptionTextbox.TabIndex = 16;
			this.descriptionTextbox.Text = "Example description";
			// 
			// titleTextbox
			// 
			this.titleTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titleTextbox.Location = new System.Drawing.Point(6, 16);
			this.titleTextbox.Name = "titleTextbox";
			this.titleTextbox.Size = new System.Drawing.Size(529, 20);
			this.titleTextbox.TabIndex = 17;
			this.titleTextbox.Text = "Example title";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.titleTextbox);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.titleGetBtn);
			this.panel1.Controls.Add(this.titleSetBtn);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(632, 44);
			this.panel1.TabIndex = 24;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.descriptionTextbox);
			this.panel2.Controls.Add(this.descriptionSetBtn);
			this.panel2.Controls.Add(this.descriptionGetBtn);
			this.panel2.Location = new System.Drawing.Point(3, 53);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(632, 91);
			this.panel2.TabIndex = 25;
			// 
			// GameMemoryEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "GameMemoryEditor";
			this.Size = new System.Drawing.Size(638, 150);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button descriptionSetBtn;
		private System.Windows.Forms.Button descriptionGetBtn;
		private System.Windows.Forms.Button titleSetBtn;
		private System.Windows.Forms.Button titleGetBtn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox descriptionTextbox;
		private System.Windows.Forms.TextBox titleTextbox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}

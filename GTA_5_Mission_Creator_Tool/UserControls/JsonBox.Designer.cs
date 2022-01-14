namespace GTA_5_Mission_Creator_Tool.UserControls
{
	partial class JsonBox
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
			this.selectPathBtn = new System.Windows.Forms.Button();
			this.saveBtn = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.jsonTextbox = new System.Windows.Forms.RichTextBox();
			this.getJsonBtn = new System.Windows.Forms.Button();
			this.copyJsonToClipboardBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// selectPathBtn
			// 
			this.selectPathBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.selectPathBtn.Location = new System.Drawing.Point(432, 376);
			this.selectPathBtn.Name = "selectPathBtn";
			this.selectPathBtn.Size = new System.Drawing.Size(75, 38);
			this.selectPathBtn.TabIndex = 12;
			this.selectPathBtn.Text = "Select path";
			this.selectPathBtn.UseVisualStyleBackColor = true;
			this.selectPathBtn.Click += new System.EventHandler(this.selectPathBtn_Click);
			// 
			// saveBtn
			// 
			this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveBtn.Location = new System.Drawing.Point(513, 376);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(75, 38);
			this.saveBtn.TabIndex = 11;
			this.saveBtn.Text = "Save to file";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.Location = new System.Drawing.Point(168, 394);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(258, 20);
			this.textBox2.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Content JSON";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(165, 378);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "File path";
			// 
			// jsonTextbox
			// 
			this.jsonTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.jsonTextbox.Location = new System.Drawing.Point(6, 16);
			this.jsonTextbox.Name = "jsonTextbox";
			this.jsonTextbox.ReadOnly = true;
			this.jsonTextbox.Size = new System.Drawing.Size(582, 354);
			this.jsonTextbox.TabIndex = 14;
			this.jsonTextbox.Text = "";
			// 
			// getJsonBtn
			// 
			this.getJsonBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.getJsonBtn.Location = new System.Drawing.Point(6, 376);
			this.getJsonBtn.Name = "getJsonBtn";
			this.getJsonBtn.Size = new System.Drawing.Size(75, 38);
			this.getJsonBtn.TabIndex = 15;
			this.getJsonBtn.Text = "Get JSON";
			this.getJsonBtn.UseVisualStyleBackColor = true;
			this.getJsonBtn.Click += new System.EventHandler(this.getJsonBtn_Click);
			// 
			// copyJsonToClipboardBtn
			// 
			this.copyJsonToClipboardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.copyJsonToClipboardBtn.Location = new System.Drawing.Point(87, 376);
			this.copyJsonToClipboardBtn.Name = "copyJsonToClipboardBtn";
			this.copyJsonToClipboardBtn.Size = new System.Drawing.Size(75, 38);
			this.copyJsonToClipboardBtn.TabIndex = 16;
			this.copyJsonToClipboardBtn.Text = "Copy JSON to clipboard";
			this.copyJsonToClipboardBtn.UseVisualStyleBackColor = true;
			this.copyJsonToClipboardBtn.Click += new System.EventHandler(this.copyJsonToClipboardBtn_Click);
			// 
			// JsonBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.copyJsonToClipboardBtn);
			this.Controls.Add(this.getJsonBtn);
			this.Controls.Add(this.jsonTextbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.selectPathBtn);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Name = "JsonBox";
			this.Size = new System.Drawing.Size(591, 417);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button selectPathBtn;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox jsonTextbox;
		private System.Windows.Forms.Button getJsonBtn;
		private System.Windows.Forms.Button copyJsonToClipboardBtn;
	}
}

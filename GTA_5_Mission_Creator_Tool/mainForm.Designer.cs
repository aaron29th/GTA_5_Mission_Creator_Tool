namespace GTA_5_Mission_Creator_Tool
{
	partial class mainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
			this.jsonGroupBox = new System.Windows.Forms.GroupBox();
			this.inGameEditorGroupBox = new System.Windows.Forms.GroupBox();
			this.outputGroupBox = new System.Windows.Forms.GroupBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.contentJsonBox = new GTA_5_Mission_Creator_Tool.UserControls.JsonBox();
			this.gameMemoryEditor = new GTA_5_Mission_Creator_Tool.UserControls.GameMemoryEditor();
			this.outputBox = new GTA_5_Mission_Creator_Tool.UserControls.OutputBox();
			this.connectionControl1 = new GTA_5_Mission_Creator_Tool.UserControls.ConnectionControl();
			this.jsonGroupBox.SuspendLayout();
			this.inGameEditorGroupBox.SuspendLayout();
			this.outputGroupBox.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// jsonGroupBox
			// 
			this.jsonGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.jsonGroupBox.Controls.Add(this.contentJsonBox);
			this.jsonGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.jsonGroupBox.Location = new System.Drawing.Point(0, 207);
			this.jsonGroupBox.Name = "jsonGroupBox";
			this.jsonGroupBox.Size = new System.Drawing.Size(1400, 492);
			this.jsonGroupBox.TabIndex = 0;
			this.jsonGroupBox.TabStop = false;
			this.jsonGroupBox.Text = "JSON";
			// 
			// inGameEditorGroupBox
			// 
			this.inGameEditorGroupBox.Controls.Add(this.gameMemoryEditor);
			this.inGameEditorGroupBox.Controls.Add(this.connectionControl1);
			this.inGameEditorGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inGameEditorGroupBox.Location = new System.Drawing.Point(0, 0);
			this.inGameEditorGroupBox.Name = "inGameEditorGroupBox";
			this.inGameEditorGroupBox.Size = new System.Drawing.Size(1400, 207);
			this.inGameEditorGroupBox.TabIndex = 6;
			this.inGameEditorGroupBox.TabStop = false;
			this.inGameEditorGroupBox.Text = "In game editor";
			// 
			// outputGroupBox
			// 
			this.outputGroupBox.Controls.Add(this.outputBox);
			this.outputGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.outputGroupBox.Location = new System.Drawing.Point(0, 699);
			this.outputGroupBox.Name = "outputGroupBox";
			this.outputGroupBox.Size = new System.Drawing.Size(1400, 213);
			this.outputGroupBox.TabIndex = 9;
			this.outputGroupBox.TabStop = false;
			this.outputGroupBox.Text = "Output";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel2.Controls.Add(this.inGameEditorGroupBox);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1400, 207);
			this.panel2.TabIndex = 11;
			// 
			// contentJsonBox
			// 
			this.contentJsonBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentJsonBox.Location = new System.Drawing.Point(3, 16);
			this.contentJsonBox.Name = "contentJsonBox";
			this.contentJsonBox.Size = new System.Drawing.Size(1394, 473);
			this.contentJsonBox.TabIndex = 9;
			// 
			// gameMemoryEditor
			// 
			this.gameMemoryEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gameMemoryEditor.Location = new System.Drawing.Point(435, 16);
			this.gameMemoryEditor.Name = "gameMemoryEditor";
			this.gameMemoryEditor.Size = new System.Drawing.Size(962, 188);
			this.gameMemoryEditor.TabIndex = 0;
			// 
			// outputBox
			// 
			this.outputBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputBox.Location = new System.Drawing.Point(3, 16);
			this.outputBox.Name = "outputBox";
			this.outputBox.Size = new System.Drawing.Size(1394, 194);
			this.outputBox.TabIndex = 8;
			// 
			// connectionControl1
			// 
			this.connectionControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.connectionControl1.Location = new System.Drawing.Point(3, 16);
			this.connectionControl1.Name = "connectionControl1";
			this.connectionControl1.Size = new System.Drawing.Size(432, 188);
			this.connectionControl1.TabIndex = 0;
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1400, 912);
			this.Controls.Add(this.jsonGroupBox);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.outputGroupBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "mainForm";
			this.Text = "GTA 5 OG Mission Creator Tool";
			this.Load += new System.EventHandler(this.mainForm_Load);
			this.jsonGroupBox.ResumeLayout(false);
			this.inGameEditorGroupBox.ResumeLayout(false);
			this.outputGroupBox.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox jsonGroupBox;
		private System.Windows.Forms.GroupBox inGameEditorGroupBox;
		private UserControls.JsonBox contentJsonBox;
		private UserControls.GameMemoryEditor gameMemoryEditor;
		private UserControls.OutputBox outputBox;
		private System.Windows.Forms.GroupBox outputGroupBox;
		private System.Windows.Forms.Panel panel2;
		private UserControls.ConnectionControl connectionControl1;
	}
}


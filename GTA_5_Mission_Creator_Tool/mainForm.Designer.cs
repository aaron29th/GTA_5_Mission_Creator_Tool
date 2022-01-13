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
			this.jsonGroupBox = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.connectBtn = new System.Windows.Forms.Button();
			this.attachBtn = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.loadDeathmatchCreatorBtn = new System.Windows.Forms.Button();
			this.loadRaceCreatorBtn = new System.Windows.Forms.Button();
			this.loadMissionCreatorBtn = new System.Windows.Forms.Button();
			this.inGameEditorGroupBox = new System.Windows.Forms.GroupBox();
			this.bypassIsCloudAvailableCheck = new System.Windows.Forms.CheckBox();
			this.outputGroupBox = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.metaJsonBox = new GTA_5_Mission_Creator_Tool.UserControls.JsonBox();
			this.contentJsonBox = new GTA_5_Mission_Creator_Tool.UserControls.JsonBox();
			this.gameMemoryEditor = new GTA_5_Mission_Creator_Tool.UserControls.GameMemoryEditor();
			this.outputBox = new GTA_5_Mission_Creator_Tool.UserControls.OutputBox();
			this.jsonGroupBox.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.inGameEditorGroupBox.SuspendLayout();
			this.outputGroupBox.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// jsonGroupBox
			// 
			this.jsonGroupBox.Controls.Add(this.label1);
			this.jsonGroupBox.Controls.Add(this.metaJsonBox);
			this.jsonGroupBox.Controls.Add(this.contentJsonBox);
			this.jsonGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.jsonGroupBox.Location = new System.Drawing.Point(0, 264);
			this.jsonGroupBox.Name = "jsonGroupBox";
			this.jsonGroupBox.Size = new System.Drawing.Size(1400, 435);
			this.jsonGroupBox.TabIndex = 0;
			this.jsonGroupBox.TabStop = false;
			this.jsonGroupBox.Text = "JSON";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label1.Location = new System.Drawing.Point(-10, 169);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1438, 1);
			this.label1.TabIndex = 10;
			// 
			// connectBtn
			// 
			this.connectBtn.Location = new System.Drawing.Point(12, 3);
			this.connectBtn.Name = "connectBtn";
			this.connectBtn.Size = new System.Drawing.Size(121, 24);
			this.connectBtn.TabIndex = 1;
			this.connectBtn.Text = "Connect";
			this.connectBtn.UseVisualStyleBackColor = true;
			this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
			// 
			// attachBtn
			// 
			this.attachBtn.Location = new System.Drawing.Point(139, 3);
			this.attachBtn.Name = "attachBtn";
			this.attachBtn.Size = new System.Drawing.Size(121, 24);
			this.attachBtn.TabIndex = 2;
			this.attachBtn.Text = "Attach / Enable RPC";
			this.attachBtn.UseVisualStyleBackColor = true;
			this.attachBtn.Click += new System.EventHandler(this.attachBtn_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.loadDeathmatchCreatorBtn);
			this.groupBox2.Controls.Add(this.loadRaceCreatorBtn);
			this.groupBox2.Controls.Add(this.loadMissionCreatorBtn);
			this.groupBox2.Location = new System.Drawing.Point(6, 33);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(254, 50);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Load creator";
			// 
			// loadDeathmatchCreatorBtn
			// 
			this.loadDeathmatchCreatorBtn.Location = new System.Drawing.Point(168, 19);
			this.loadDeathmatchCreatorBtn.Name = "loadDeathmatchCreatorBtn";
			this.loadDeathmatchCreatorBtn.Size = new System.Drawing.Size(75, 23);
			this.loadDeathmatchCreatorBtn.TabIndex = 2;
			this.loadDeathmatchCreatorBtn.Text = "Deathmatch";
			this.loadDeathmatchCreatorBtn.UseVisualStyleBackColor = true;
			this.loadDeathmatchCreatorBtn.Click += new System.EventHandler(this.loadDeathmatchCreatorBtn_Click);
			// 
			// loadRaceCreatorBtn
			// 
			this.loadRaceCreatorBtn.Location = new System.Drawing.Point(87, 19);
			this.loadRaceCreatorBtn.Name = "loadRaceCreatorBtn";
			this.loadRaceCreatorBtn.Size = new System.Drawing.Size(75, 23);
			this.loadRaceCreatorBtn.TabIndex = 1;
			this.loadRaceCreatorBtn.Text = "Race";
			this.loadRaceCreatorBtn.UseVisualStyleBackColor = true;
			this.loadRaceCreatorBtn.Click += new System.EventHandler(this.loadRaceCreatorBtn_Click);
			// 
			// loadMissionCreatorBtn
			// 
			this.loadMissionCreatorBtn.Location = new System.Drawing.Point(6, 19);
			this.loadMissionCreatorBtn.Name = "loadMissionCreatorBtn";
			this.loadMissionCreatorBtn.Size = new System.Drawing.Size(75, 23);
			this.loadMissionCreatorBtn.TabIndex = 0;
			this.loadMissionCreatorBtn.Text = "Mission";
			this.loadMissionCreatorBtn.UseVisualStyleBackColor = true;
			this.loadMissionCreatorBtn.Click += new System.EventHandler(this.loadMissionCreatorBtn_Click);
			// 
			// inGameEditorGroupBox
			// 
			this.inGameEditorGroupBox.Controls.Add(this.gameMemoryEditor);
			this.inGameEditorGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.inGameEditorGroupBox.Location = new System.Drawing.Point(0, 100);
			this.inGameEditorGroupBox.Name = "inGameEditorGroupBox";
			this.inGameEditorGroupBox.Size = new System.Drawing.Size(1400, 164);
			this.inGameEditorGroupBox.TabIndex = 6;
			this.inGameEditorGroupBox.TabStop = false;
			this.inGameEditorGroupBox.Text = "In game editor";
			// 
			// bypassIsCloudAvailableCheck
			// 
			this.bypassIsCloudAvailableCheck.AutoSize = true;
			this.bypassIsCloudAvailableCheck.Location = new System.Drawing.Point(276, 56);
			this.bypassIsCloudAvailableCheck.Name = "bypassIsCloudAvailableCheck";
			this.bypassIsCloudAvailableCheck.Size = new System.Drawing.Size(131, 17);
			this.bypassIsCloudAvailableCheck.TabIndex = 7;
			this.bypassIsCloudAvailableCheck.Text = "Bypass no connection";
			this.bypassIsCloudAvailableCheck.UseVisualStyleBackColor = true;
			this.bypassIsCloudAvailableCheck.CheckedChanged += new System.EventHandler(this.bypassIsCloudAvailableCheck_CheckedChanged);
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
			// panel1
			// 
			this.panel1.Controls.Add(this.connectBtn);
			this.panel1.Controls.Add(this.attachBtn);
			this.panel1.Controls.Add(this.bypassIsCloudAvailableCheck);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1400, 100);
			this.panel1.TabIndex = 10;
			// 
			// metaJsonBox
			// 
			this.metaJsonBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metaJsonBox.Location = new System.Drawing.Point(6, 19);
			this.metaJsonBox.Name = "metaJsonBox";
			this.metaJsonBox.Size = new System.Drawing.Size(1388, 147);
			this.metaJsonBox.TabIndex = 0;
			// 
			// contentJsonBox
			// 
			this.contentJsonBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.contentJsonBox.Location = new System.Drawing.Point(6, 174);
			this.contentJsonBox.Name = "contentJsonBox";
			this.contentJsonBox.Size = new System.Drawing.Size(1388, 255);
			this.contentJsonBox.TabIndex = 9;
			// 
			// gameMemoryEditor
			// 
			this.gameMemoryEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gameMemoryEditor.Location = new System.Drawing.Point(3, 16);
			this.gameMemoryEditor.Name = "gameMemoryEditor";
			this.gameMemoryEditor.Size = new System.Drawing.Size(1394, 145);
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
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1400, 912);
			this.Controls.Add(this.jsonGroupBox);
			this.Controls.Add(this.inGameEditorGroupBox);
			this.Controls.Add(this.outputGroupBox);
			this.Controls.Add(this.panel1);
			this.Name = "mainForm";
			this.Text = "OG Mission Creator Tool";
			this.jsonGroupBox.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.inGameEditorGroupBox.ResumeLayout(false);
			this.outputGroupBox.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox jsonGroupBox;
		private System.Windows.Forms.Button connectBtn;
		private System.Windows.Forms.Button attachBtn;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button loadDeathmatchCreatorBtn;
		private System.Windows.Forms.Button loadRaceCreatorBtn;
		private System.Windows.Forms.Button loadMissionCreatorBtn;
		private System.Windows.Forms.GroupBox inGameEditorGroupBox;
		private UserControls.JsonBox metaJsonBox;
		private UserControls.JsonBox contentJsonBox;
		private UserControls.GameMemoryEditor gameMemoryEditor;
		private System.Windows.Forms.CheckBox bypassIsCloudAvailableCheck;
		private UserControls.OutputBox outputBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox outputGroupBox;
		private System.Windows.Forms.Panel panel1;
	}
}


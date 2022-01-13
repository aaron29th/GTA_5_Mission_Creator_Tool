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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.connectBtn = new System.Windows.Forms.Button();
			this.attachBtn = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.loadDeathmatchCreatorBtn = new System.Windows.Forms.Button();
			this.loadRaceCreatorBtn = new System.Windows.Forms.Button();
			this.loadMissionCreatorBtn = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.bypassIsCloudAvailableCheck = new System.Windows.Forms.CheckBox();
			this.outputBox = new GTA_5_Mission_Creator_Tool.UserControls.OutputBox();
			this.gameMemoryEditor = new GTA_5_Mission_Creator_Tool.UserControls.GameMemoryEditor();
			this.metaJsonBox = new GTA_5_Mission_Creator_Tool.UserControls.JsonBox();
			this.contentJsonBox = new GTA_5_Mission_Creator_Tool.UserControls.JsonBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.metaJsonBox);
			this.groupBox1.Controls.Add(this.contentJsonBox);
			this.groupBox1.Location = new System.Drawing.Point(13, 234);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1062, 334);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "JSON";
			// 
			// connectBtn
			// 
			this.connectBtn.Location = new System.Drawing.Point(12, 12);
			this.connectBtn.Name = "connectBtn";
			this.connectBtn.Size = new System.Drawing.Size(121, 24);
			this.connectBtn.TabIndex = 1;
			this.connectBtn.Text = "Connect";
			this.connectBtn.UseVisualStyleBackColor = true;
			this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
			// 
			// attachBtn
			// 
			this.attachBtn.Location = new System.Drawing.Point(139, 12);
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
			this.groupBox2.Location = new System.Drawing.Point(309, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(280, 55);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Load creator";
			// 
			// loadDeathmatchCreatorBtn
			// 
			this.loadDeathmatchCreatorBtn.Location = new System.Drawing.Point(190, 20);
			this.loadDeathmatchCreatorBtn.Name = "loadDeathmatchCreatorBtn";
			this.loadDeathmatchCreatorBtn.Size = new System.Drawing.Size(75, 23);
			this.loadDeathmatchCreatorBtn.TabIndex = 2;
			this.loadDeathmatchCreatorBtn.Text = "Deathmatch";
			this.loadDeathmatchCreatorBtn.UseVisualStyleBackColor = true;
			this.loadDeathmatchCreatorBtn.Click += new System.EventHandler(this.loadDeathmatchCreatorBtn_Click);
			// 
			// loadRaceCreatorBtn
			// 
			this.loadRaceCreatorBtn.Location = new System.Drawing.Point(107, 19);
			this.loadRaceCreatorBtn.Name = "loadRaceCreatorBtn";
			this.loadRaceCreatorBtn.Size = new System.Drawing.Size(75, 23);
			this.loadRaceCreatorBtn.TabIndex = 1;
			this.loadRaceCreatorBtn.Text = "Race";
			this.loadRaceCreatorBtn.UseVisualStyleBackColor = true;
			this.loadRaceCreatorBtn.Click += new System.EventHandler(this.loadRaceCreatorBtn_Click);
			// 
			// loadMissionCreatorBtn
			// 
			this.loadMissionCreatorBtn.Location = new System.Drawing.Point(26, 20);
			this.loadMissionCreatorBtn.Name = "loadMissionCreatorBtn";
			this.loadMissionCreatorBtn.Size = new System.Drawing.Size(75, 23);
			this.loadMissionCreatorBtn.TabIndex = 0;
			this.loadMissionCreatorBtn.Text = "Mission";
			this.loadMissionCreatorBtn.UseVisualStyleBackColor = true;
			this.loadMissionCreatorBtn.Click += new System.EventHandler(this.loadMissionCreatorBtn_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.gameMemoryEditor);
			this.groupBox3.Location = new System.Drawing.Point(13, 64);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(737, 164);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "In game editor";
			// 
			// bypassIsCloudAvailableCheck
			// 
			this.bypassIsCloudAvailableCheck.AutoSize = true;
			this.bypassIsCloudAvailableCheck.Location = new System.Drawing.Point(619, 12);
			this.bypassIsCloudAvailableCheck.Name = "bypassIsCloudAvailableCheck";
			this.bypassIsCloudAvailableCheck.Size = new System.Drawing.Size(131, 17);
			this.bypassIsCloudAvailableCheck.TabIndex = 7;
			this.bypassIsCloudAvailableCheck.Text = "Bypass no connection";
			this.bypassIsCloudAvailableCheck.UseVisualStyleBackColor = true;
			this.bypassIsCloudAvailableCheck.CheckedChanged += new System.EventHandler(this.bypassIsCloudAvailableCheck_CheckedChanged);
			// 
			// outputBox
			// 
			this.outputBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputBox.Location = new System.Drawing.Point(3, 16);
			this.outputBox.Name = "outputBox";
			this.outputBox.Size = new System.Drawing.Size(747, 194);
			this.outputBox.TabIndex = 8;
			// 
			// gameMemoryEditor
			// 
			this.gameMemoryEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gameMemoryEditor.Location = new System.Drawing.Point(3, 16);
			this.gameMemoryEditor.Name = "gameMemoryEditor";
			this.gameMemoryEditor.Size = new System.Drawing.Size(731, 145);
			this.gameMemoryEditor.TabIndex = 0;
			// 
			// metaJsonBox
			// 
			this.metaJsonBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metaJsonBox.Location = new System.Drawing.Point(6, 19);
			this.metaJsonBox.Name = "metaJsonBox";
			this.metaJsonBox.Size = new System.Drawing.Size(1050, 147);
			this.metaJsonBox.TabIndex = 0;
			// 
			// contentJsonBox
			// 
			this.contentJsonBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.contentJsonBox.Location = new System.Drawing.Point(6, 174);
			this.contentJsonBox.Name = "contentJsonBox";
			this.contentJsonBox.Size = new System.Drawing.Size(1050, 151);
			this.contentJsonBox.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label1.Location = new System.Drawing.Point(-10, 169);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1100, 1);
			this.label1.TabIndex = 10;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.outputBox);
			this.groupBox4.Location = new System.Drawing.Point(19, 587);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(753, 213);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Output";
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1400, 912);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.bypassIsCloudAvailableCheck);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.attachBtn);
			this.Controls.Add(this.connectBtn);
			this.Controls.Add(this.groupBox1);
			this.Name = "mainForm";
			this.Text = "OG Mission Creator Tool";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button connectBtn;
		private System.Windows.Forms.Button attachBtn;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button loadDeathmatchCreatorBtn;
		private System.Windows.Forms.Button loadRaceCreatorBtn;
		private System.Windows.Forms.Button loadMissionCreatorBtn;
		private System.Windows.Forms.GroupBox groupBox3;
		private UserControls.JsonBox metaJsonBox;
		private UserControls.JsonBox contentJsonBox;
		private UserControls.GameMemoryEditor gameMemoryEditor;
		private System.Windows.Forms.CheckBox bypassIsCloudAvailableCheck;
		private UserControls.OutputBox outputBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox4;
	}
}


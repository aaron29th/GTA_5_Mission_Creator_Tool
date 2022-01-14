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
			this.connectBtn = new System.Windows.Forms.Button();
			this.attachBtn = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.loadDeathmatchCreatorBtn = new System.Windows.Forms.Button();
			this.loadRaceCreatorBtn = new System.Windows.Forms.Button();
			this.loadMissionCreatorBtn = new System.Windows.Forms.Button();
			this.inGameEditorGroupBox = new System.Windows.Forms.GroupBox();
			this.outputGroupBox = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.terminateCreatorScriptsBtn = new System.Windows.Forms.Button();
			this.terminateScriptBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.scriptNameTextbox = new System.Windows.Forms.TextBox();
			this.connectionGroupBox = new System.Windows.Forms.GroupBox();
			this.interceptionEnableBtn = new System.Windows.Forms.Button();
			this.devModeCheck = new System.Windows.Forms.CheckBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.profanityBypassCheck = new System.Windows.Forms.CheckBox();
			this.contentJsonBox = new GTA_5_Mission_Creator_Tool.UserControls.JsonBox();
			this.gameMemoryEditor = new GTA_5_Mission_Creator_Tool.UserControls.GameMemoryEditor();
			this.outputBox = new GTA_5_Mission_Creator_Tool.UserControls.OutputBox();
			this.tmapiRadio = new System.Windows.Forms.RadioButton();
			this.ccapiRadio = new System.Windows.Forms.RadioButton();
			this.jsonGroupBox.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.inGameEditorGroupBox.SuspendLayout();
			this.outputGroupBox.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.connectionGroupBox.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// jsonGroupBox
			// 
			this.jsonGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.jsonGroupBox.Controls.Add(this.contentJsonBox);
			this.jsonGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.jsonGroupBox.Location = new System.Drawing.Point(0, 160);
			this.jsonGroupBox.Name = "jsonGroupBox";
			this.jsonGroupBox.Size = new System.Drawing.Size(1400, 539);
			this.jsonGroupBox.TabIndex = 0;
			this.jsonGroupBox.TabStop = false;
			this.jsonGroupBox.Text = "JSON";
			// 
			// connectBtn
			// 
			this.connectBtn.Location = new System.Drawing.Point(6, 41);
			this.connectBtn.Name = "connectBtn";
			this.connectBtn.Size = new System.Drawing.Size(75, 40);
			this.connectBtn.TabIndex = 1;
			this.connectBtn.Text = "Connect";
			this.connectBtn.UseVisualStyleBackColor = true;
			this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
			// 
			// attachBtn
			// 
			this.attachBtn.Location = new System.Drawing.Point(87, 41);
			this.attachBtn.Name = "attachBtn";
			this.attachBtn.Size = new System.Drawing.Size(75, 40);
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
			this.groupBox2.Location = new System.Drawing.Point(3, 104);
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
			this.inGameEditorGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inGameEditorGroupBox.Location = new System.Drawing.Point(437, 0);
			this.inGameEditorGroupBox.Name = "inGameEditorGroupBox";
			this.inGameEditorGroupBox.Size = new System.Drawing.Size(963, 160);
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.profanityBypassCheck);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.connectionGroupBox);
			this.panel1.Controls.Add(this.devModeCheck);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(437, 160);
			this.panel1.TabIndex = 10;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.terminateCreatorScriptsBtn);
			this.groupBox1.Controls.Add(this.terminateScriptBtn);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.scriptNameTextbox);
			this.groupBox1.Location = new System.Drawing.Point(257, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(171, 117);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Terminate scripts";
			// 
			// terminateCreatorScriptsBtn
			// 
			this.terminateCreatorScriptsBtn.Location = new System.Drawing.Point(9, 19);
			this.terminateCreatorScriptsBtn.Name = "terminateCreatorScriptsBtn";
			this.terminateCreatorScriptsBtn.Size = new System.Drawing.Size(153, 23);
			this.terminateCreatorScriptsBtn.TabIndex = 3;
			this.terminateCreatorScriptsBtn.Text = "Terminate creator scripts";
			this.terminateCreatorScriptsBtn.UseVisualStyleBackColor = true;
			this.terminateCreatorScriptsBtn.Click += new System.EventHandler(this.terminateCreatorScriptsBtn_Click);
			// 
			// terminateScriptBtn
			// 
			this.terminateScriptBtn.Location = new System.Drawing.Point(9, 87);
			this.terminateScriptBtn.Name = "terminateScriptBtn";
			this.terminateScriptBtn.Size = new System.Drawing.Size(153, 23);
			this.terminateScriptBtn.TabIndex = 2;
			this.terminateScriptBtn.Text = "Terminate";
			this.terminateScriptBtn.UseVisualStyleBackColor = true;
			this.terminateScriptBtn.Click += new System.EventHandler(this.terminateScriptBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Script name";
			// 
			// scriptNameTextbox
			// 
			this.scriptNameTextbox.Location = new System.Drawing.Point(9, 61);
			this.scriptNameTextbox.Name = "scriptNameTextbox";
			this.scriptNameTextbox.Size = new System.Drawing.Size(153, 20);
			this.scriptNameTextbox.TabIndex = 0;
			// 
			// connectionGroupBox
			// 
			this.connectionGroupBox.Controls.Add(this.ccapiRadio);
			this.connectionGroupBox.Controls.Add(this.tmapiRadio);
			this.connectionGroupBox.Controls.Add(this.connectBtn);
			this.connectionGroupBox.Controls.Add(this.interceptionEnableBtn);
			this.connectionGroupBox.Controls.Add(this.attachBtn);
			this.connectionGroupBox.Location = new System.Drawing.Point(3, 3);
			this.connectionGroupBox.Name = "connectionGroupBox";
			this.connectionGroupBox.Size = new System.Drawing.Size(248, 90);
			this.connectionGroupBox.TabIndex = 10;
			this.connectionGroupBox.TabStop = false;
			this.connectionGroupBox.Text = "Connection";
			// 
			// interceptionEnableBtn
			// 
			this.interceptionEnableBtn.Location = new System.Drawing.Point(168, 41);
			this.interceptionEnableBtn.Name = "interceptionEnableBtn";
			this.interceptionEnableBtn.Size = new System.Drawing.Size(75, 40);
			this.interceptionEnableBtn.TabIndex = 9;
			this.interceptionEnableBtn.Text = "Enable interception";
			this.interceptionEnableBtn.UseVisualStyleBackColor = true;
			this.interceptionEnableBtn.Click += new System.EventHandler(this.interceptionEnableBtn_Click);
			// 
			// devModeCheck
			// 
			this.devModeCheck.AutoSize = true;
			this.devModeCheck.Location = new System.Drawing.Point(266, 140);
			this.devModeCheck.Name = "devModeCheck";
			this.devModeCheck.Size = new System.Drawing.Size(75, 17);
			this.devModeCheck.TabIndex = 8;
			this.devModeCheck.Text = "Dev mode";
			this.devModeCheck.UseVisualStyleBackColor = true;
			this.devModeCheck.CheckedChanged += new System.EventHandler(this.devModeCheck_CheckedChanged);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel2.Controls.Add(this.inGameEditorGroupBox);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1400, 160);
			this.panel2.TabIndex = 11;
			// 
			// profanityBypassCheck
			// 
			this.profanityBypassCheck.AutoSize = true;
			this.profanityBypassCheck.Location = new System.Drawing.Point(266, 119);
			this.profanityBypassCheck.Name = "profanityBypassCheck";
			this.profanityBypassCheck.Size = new System.Drawing.Size(136, 17);
			this.profanityBypassCheck.TabIndex = 12;
			this.profanityBypassCheck.Text = "Bypass profanity check";
			this.profanityBypassCheck.UseVisualStyleBackColor = true;
			this.profanityBypassCheck.CheckedChanged += new System.EventHandler(this.profanityBypassCheck_CheckedChanged);
			// 
			// contentJsonBox
			// 
			this.contentJsonBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentJsonBox.Location = new System.Drawing.Point(3, 16);
			this.contentJsonBox.Name = "contentJsonBox";
			this.contentJsonBox.Size = new System.Drawing.Size(1394, 520);
			this.contentJsonBox.TabIndex = 9;
			// 
			// gameMemoryEditor
			// 
			this.gameMemoryEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gameMemoryEditor.Location = new System.Drawing.Point(3, 16);
			this.gameMemoryEditor.Name = "gameMemoryEditor";
			this.gameMemoryEditor.Size = new System.Drawing.Size(957, 141);
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
			// tmapiRadio
			// 
			this.tmapiRadio.AutoSize = true;
			this.tmapiRadio.Checked = true;
			this.tmapiRadio.Location = new System.Drawing.Point(6, 19);
			this.tmapiRadio.Name = "tmapiRadio";
			this.tmapiRadio.Size = new System.Drawing.Size(58, 17);
			this.tmapiRadio.TabIndex = 10;
			this.tmapiRadio.TabStop = true;
			this.tmapiRadio.Text = "TMAPI";
			this.tmapiRadio.UseVisualStyleBackColor = true;
			// 
			// ccapiRadio
			// 
			this.ccapiRadio.AutoSize = true;
			this.ccapiRadio.Location = new System.Drawing.Point(87, 19);
			this.ccapiRadio.Name = "ccapiRadio";
			this.ccapiRadio.Size = new System.Drawing.Size(56, 17);
			this.ccapiRadio.TabIndex = 11;
			this.ccapiRadio.Text = "CCAPI";
			this.ccapiRadio.UseVisualStyleBackColor = true;
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
			this.groupBox2.ResumeLayout(false);
			this.inGameEditorGroupBox.ResumeLayout(false);
			this.outputGroupBox.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.connectionGroupBox.ResumeLayout(false);
			this.connectionGroupBox.PerformLayout();
			this.panel2.ResumeLayout(false);
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
		private UserControls.JsonBox contentJsonBox;
		private UserControls.GameMemoryEditor gameMemoryEditor;
		private UserControls.OutputBox outputBox;
		private System.Windows.Forms.GroupBox outputGroupBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox devModeCheck;
		private System.Windows.Forms.GroupBox connectionGroupBox;
		private System.Windows.Forms.Button interceptionEnableBtn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button terminateCreatorScriptsBtn;
		private System.Windows.Forms.Button terminateScriptBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox scriptNameTextbox;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckBox profanityBypassCheck;
		private System.Windows.Forms.RadioButton ccapiRadio;
		private System.Windows.Forms.RadioButton tmapiRadio;
	}
}


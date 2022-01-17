namespace GTA_5_Mission_Creator_Tool.UserControls
{
	partial class ConnectionControl
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
            this.profanityBypassCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stackSizeSpin = new System.Windows.Forms.NumericUpDown();
            this.startScriptBtn = new System.Windows.Forms.Button();
            this.terminateCreatorScriptsBtn = new System.Windows.Forms.Button();
            this.terminateScriptBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scriptNameTextbox = new System.Windows.Forms.TextBox();
            this.connectionGroupBox = new System.Windows.Forms.GroupBox();
            this.ccapiRadio = new System.Windows.Forms.RadioButton();
            this.tmapiRadio = new System.Windows.Forms.RadioButton();
            this.connectBtn = new System.Windows.Forms.Button();
            this.interceptionEnableBtn = new System.Windows.Forms.Button();
            this.attachBtn = new System.Windows.Forms.Button();
            this.devModeCheck = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loadDeathmatchCreatorBtn = new System.Windows.Forms.Button();
            this.loadRaceCreatorBtn = new System.Windows.Forms.Button();
            this.loadMissionCreatorBtn = new System.Windows.Forms.Button();
            this.scriptGetNumInstancesBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackSizeSpin)).BeginInit();
            this.connectionGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // profanityBypassCheck
            // 
            this.profanityBypassCheck.AutoSize = true;
            this.profanityBypassCheck.Location = new System.Drawing.Point(90, 160);
            this.profanityBypassCheck.Name = "profanityBypassCheck";
            this.profanityBypassCheck.Size = new System.Drawing.Size(136, 17);
            this.profanityBypassCheck.TabIndex = 12;
            this.profanityBypassCheck.Text = "Bypass profanity check";
            this.profanityBypassCheck.UseVisualStyleBackColor = true;
            this.profanityBypassCheck.CheckedChanged += new System.EventHandler(this.profanityBypassCheck_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scriptGetNumInstancesBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.stackSizeSpin);
            this.groupBox1.Controls.Add(this.startScriptBtn);
            this.groupBox1.Controls.Add(this.terminateCreatorScriptsBtn);
            this.groupBox1.Controls.Add(this.terminateScriptBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.scriptNameTextbox);
            this.groupBox1.Location = new System.Drawing.Point(257, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 181);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scripts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stack size";
            // 
            // stackSizeSpin
            // 
            this.stackSizeSpin.Location = new System.Drawing.Point(9, 101);
            this.stackSizeSpin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.stackSizeSpin.Name = "stackSizeSpin";
            this.stackSizeSpin.Size = new System.Drawing.Size(142, 20);
            this.stackSizeSpin.TabIndex = 5;
            this.stackSizeSpin.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            // 
            // startScriptBtn
            // 
            this.startScriptBtn.Location = new System.Drawing.Point(9, 128);
            this.startScriptBtn.Name = "startScriptBtn";
            this.startScriptBtn.Size = new System.Drawing.Size(68, 23);
            this.startScriptBtn.TabIndex = 4;
            this.startScriptBtn.Text = "Start";
            this.startScriptBtn.UseVisualStyleBackColor = true;
            this.startScriptBtn.Click += new System.EventHandler(this.startScriptBtn_Click);
            // 
            // terminateCreatorScriptsBtn
            // 
            this.terminateCreatorScriptsBtn.Location = new System.Drawing.Point(9, 19);
            this.terminateCreatorScriptsBtn.Name = "terminateCreatorScriptsBtn";
            this.terminateCreatorScriptsBtn.Size = new System.Drawing.Size(142, 23);
            this.terminateCreatorScriptsBtn.TabIndex = 3;
            this.terminateCreatorScriptsBtn.Text = "Terminate creator scripts";
            this.terminateCreatorScriptsBtn.UseVisualStyleBackColor = true;
            this.terminateCreatorScriptsBtn.Click += new System.EventHandler(this.terminateCreatorScriptsBtn_Click);
            // 
            // terminateScriptBtn
            // 
            this.terminateScriptBtn.Location = new System.Drawing.Point(83, 128);
            this.terminateScriptBtn.Name = "terminateScriptBtn";
            this.terminateScriptBtn.Size = new System.Drawing.Size(68, 23);
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
            this.scriptNameTextbox.Size = new System.Drawing.Size(142, 20);
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
            // devModeCheck
            // 
            this.devModeCheck.AutoSize = true;
            this.devModeCheck.Location = new System.Drawing.Point(9, 160);
            this.devModeCheck.Name = "devModeCheck";
            this.devModeCheck.Size = new System.Drawing.Size(75, 17);
            this.devModeCheck.TabIndex = 8;
            this.devModeCheck.Text = "Dev mode";
            this.devModeCheck.UseVisualStyleBackColor = true;
            this.devModeCheck.CheckedChanged += new System.EventHandler(this.devModeCheck_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loadDeathmatchCreatorBtn);
            this.groupBox2.Controls.Add(this.loadRaceCreatorBtn);
            this.groupBox2.Controls.Add(this.loadMissionCreatorBtn);
            this.groupBox2.Location = new System.Drawing.Point(3, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 50);
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
            // scriptGetNumInstancesBtn
            // 
            this.scriptGetNumInstancesBtn.Location = new System.Drawing.Point(9, 157);
            this.scriptGetNumInstancesBtn.Name = "scriptGetNumInstancesBtn";
            this.scriptGetNumInstancesBtn.Size = new System.Drawing.Size(142, 23);
            this.scriptGetNumInstancesBtn.TabIndex = 7;
            this.scriptGetNumInstancesBtn.Text = "Get number of instances";
            this.scriptGetNumInstancesBtn.UseVisualStyleBackColor = true;
            this.scriptGetNumInstancesBtn.Click += new System.EventHandler(this.scriptGetNumInstancesBtn_Click);
            // 
            // ConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.profanityBypassCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.connectionGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.devModeCheck);
            this.Name = "ConnectionControl";
            this.Size = new System.Drawing.Size(432, 187);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackSizeSpin)).EndInit();
            this.connectionGroupBox.ResumeLayout(false);
            this.connectionGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox profanityBypassCheck;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button terminateCreatorScriptsBtn;
		private System.Windows.Forms.Button terminateScriptBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox scriptNameTextbox;
		private System.Windows.Forms.GroupBox connectionGroupBox;
		private System.Windows.Forms.RadioButton ccapiRadio;
		private System.Windows.Forms.RadioButton tmapiRadio;
		private System.Windows.Forms.Button connectBtn;
		private System.Windows.Forms.Button interceptionEnableBtn;
		private System.Windows.Forms.Button attachBtn;
		private System.Windows.Forms.CheckBox devModeCheck;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button loadDeathmatchCreatorBtn;
		private System.Windows.Forms.Button loadRaceCreatorBtn;
		private System.Windows.Forms.Button loadMissionCreatorBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown stackSizeSpin;
		private System.Windows.Forms.Button startScriptBtn;
        private System.Windows.Forms.Button scriptGetNumInstancesBtn;
    }
}

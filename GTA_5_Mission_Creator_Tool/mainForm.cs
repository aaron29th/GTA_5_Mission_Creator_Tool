﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTA_5_Mission_Creator_Tool.Models;
using PS3Lib;

namespace GTA_5_Mission_Creator_Tool
{
	public partial class mainForm : Form
	{
		private static PS3API PS3 = new PS3API(SelectAPI.TargetManager);

		public mainForm()
		{
			InitializeComponent();

			Output.outputBox = outputBox;

			Creator.PS3 = PS3;
			RPC.PS3 = PS3;
			ContentIntercepter.PS3 = PS3;
		}

		private void connectBtn_Click(object sender, EventArgs e)
		{
			if (PS3.ConnectTarget()) Output.Write("Connected to " + PS3.GetConsoleName());
			else Output.Write("Failed to connect");
		}

		private void attachBtn_Click(object sender, EventArgs e)
		{
			if (!PS3.ConnectTarget())
			{
				Output.Write("Not connected :(");
				return;
			}

			if (!PS3.AttachProcess())
			{
				Output.Write("Failed to attach");
				return;
			}

			Output.Write("Attached");

			RPC.Enable();
			Output.Write("RPC enabled");
		}

		private void interceptionEnableBtn_Click(object sender, EventArgs e)
		{
			ContentIntercepter.Enable();
			Output.Write("Save interception enabled");

			devModeCheck.Checked = true;
			Creator.RockstarDev = true;

			profanityBypassCheck.Checked = true;
			Creator.BypassProfanityCheck(true);
		}

		private void loadMissionCreatorBtn_Click(object sender, EventArgs e)
		{
			if (Creator.LoadScript("FM_Mission_Creator")) Output.Write("Mission creator successfully loaded");
			else Output.Write("Mission creator failed to load");
		}

		private void loadRaceCreatorBtn_Click(object sender, EventArgs e)
		{
			if (Creator.LoadScript("FM_Race_Creator")) Output.Write("Race creator successfully loaded");
			else Output.Write("Race creator failed to load");
		}

		private void loadDeathmatchCreatorBtn_Click(object sender, EventArgs e)
		{
			if (Creator.LoadScript("FM_Deathmatch_Creator")) Output.Write("Deathmatch  creator successfully loaded");
			else Output.Write("Deathmatch creator failed to load");
		}

		private void devModeCheck_CheckedChanged(object sender, EventArgs e)
		{
			Creator.RockstarDev = devModeCheck.Checked;
			Output.Write("Dev mode: " + (devModeCheck.Checked ? "Enabled" : "Disabled"));
		}

		private void terminateScript(string scriptName)
		{
			if (!Creator.TerminateScript(scriptName)) Output.Write($"Script termination failed: {scriptName}");
			else Output.Write($"Script termination succeeded: {scriptName}");
		}

		private void terminateCreatorScriptsBtn_Click(object sender, EventArgs e)
		{
			terminateScript("FM_Mission_Creator");
			terminateScript("FM_Race_Creator");
			terminateScript("FM_Deathmatch_Creator");
			terminateScript("creator");
		}

		private void terminateScriptBtn_Click(object sender, EventArgs e)
		{
			terminateScript(scriptNameTextbox.Text);
			
		}

		private void profanityBypassCheck_CheckedChanged(object sender, EventArgs e)
		{
			Creator.BypassProfanityCheck(profanityBypassCheck.Checked);
			Output.Write("Profanity check: " + (profanityBypassCheck.Checked ? "Disabled" : "Enabled"));
		}

		private void mainForm_Load(object sender, EventArgs e)
		{
			Output.Write($"Current version: {Updates.VersionStr}");
			checkUpdates();
		}

		private void checkUpdates()
		{
			Updates update = Updates.CheckUpdates();
			if (update == null)
			{
				Output.Write("Failed to check for updates");
				return;
			}

			if (update.LatestVersion > Updates.Version)
				Output.Write($"A new version is available: {update.LatestDownload}");

			if (!string.IsNullOrWhiteSpace(update.StartUpMessage))
				Output.Write(update.StartUpMessage);
		}
	}
}

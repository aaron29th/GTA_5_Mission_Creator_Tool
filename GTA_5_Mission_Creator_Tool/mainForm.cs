using System;
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
		}

		private void connectBtn_Click(object sender, EventArgs e)
		{
			if (PS3.ConnectTarget()) Output.write("Connected to " + PS3.GetConsoleName());
			else Output.write("Failed to connect");
		}

		private void attachBtn_Click(object sender, EventArgs e)
		{
			if (!PS3.ConnectTarget())
			{
				Output.write("Not connected :(");
				return;
			}

			if (!PS3.AttachProcess())
			{
				Output.write("Failed to attach");
				return;
			}

			Output.write("Attached");
			//RPC.Enable();
			Output.write("RPC enabled");
		}

		private void loadMissionCreatorBtn_Click(object sender, EventArgs e)
		{
			if (Creator.loadScript("FM_Mission_Creator")) Output.write("Mission creator successfully loaded");
			else Output.write("Mission creator failed to load");
		}

		private void loadRaceCreatorBtn_Click(object sender, EventArgs e)
		{
			if (Creator.loadScript("FM_Race_Creator")) Output.write("Race creator successfully loaded");
			else Output.write("Race creator failed to load");
		}

		private void loadDeathmatchCreatorBtn_Click(object sender, EventArgs e)
		{
			if (Creator.loadScript("FM_Deathmatch_Creator")) Output.write("Deathmatch  creator successfully loaded");
			else Output.write("Deathmatch creator failed to load");
		}

		private void bypassIsCloudAvailableCheck_CheckedChanged(object sender, EventArgs e)
		{
			Creator.bypassNoConnection = bypassIsCloudAvailableCheck.Checked;
		}
	}
}

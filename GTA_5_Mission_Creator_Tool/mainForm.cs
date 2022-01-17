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
		private static PS3API PS3 = new PS3API();

		public mainForm()
		{
			InitializeComponent();

			Output.outputBox = outputBox;

			RPC.PS3 = PS3;
			ContentIntercepter.PS3 = PS3;

			Scripts.PS3 = PS3;
			Global.PS3 = PS3;
			Creator.PS3 = PS3;
			
			connectionControl.PS3 = PS3;
			gameMemoryEditor.PS3 = PS3;
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

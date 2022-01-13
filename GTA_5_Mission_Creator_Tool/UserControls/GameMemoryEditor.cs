using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTA_5_Mission_Creator_Tool.Models;

namespace GTA_5_Mission_Creator_Tool.UserControls
{
	public partial class GameMemoryEditor : UserControl
	{
		public GameMemoryEditor()
		{
			InitializeComponent();
		}

		private void titleGetBtn_Click(object sender, EventArgs e)
		{
			titleTextbox.Text = Creator.Title;
		}

		private void titleSetBtn_Click(object sender, EventArgs e)
		{
			Creator.Title = titleTextbox.Text;
		}

		private void descriptionGetBtn_Click(object sender, EventArgs e)
		{
			descriptionTextbox.Text = Creator.Description;
		}

		private void descriptionSetBtn_Click(object sender, EventArgs e)
		{
			Creator.Description = descriptionTextbox.Text;
		}
	}
}

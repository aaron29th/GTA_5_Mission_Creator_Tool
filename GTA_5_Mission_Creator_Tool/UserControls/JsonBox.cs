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
	public partial class JsonBox : UserControl
	{
		public JsonBox()
		{
			InitializeComponent();
		}

		private void getJsonBtn_Click(object sender, EventArgs e)
		{
			jsonTextbox.Text = Creator.GetContentJson();
		}

		private void copyJsonToClipboardBtn_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(jsonTextbox.Text);
		}

		private void selectPathBtn_Click(object sender, EventArgs e)
		{

		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			
		}
	}
}

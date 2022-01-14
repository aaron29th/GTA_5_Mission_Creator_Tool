using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_5_Mission_Creator_Tool.UserControls
{
	public partial class OutputBox : UserControl
	{
		public OutputBox()
		{
			InitializeComponent();
		}

		public void prependMessage(string message)
		{
			outputTextbox.Text = message + Environment.NewLine + outputTextbox.Text;
		}

		private void outputTextbox_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);
		}
	}
}

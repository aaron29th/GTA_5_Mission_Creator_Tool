using System;
using System.IO;
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
			Output.Write("Content JSON read from game");
		}

		private void copyJsonToClipboardBtn_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(jsonTextbox.Text);
			Output.Write("Content JSON copied to clipboard");
		}

		private void selectPathBtn_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
			saveFileDialog.RestoreDirectory = true;

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				saveFileTextbox.Text = saveFileDialog.FileName;
			}
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			try
			{
				string directory = Path.GetDirectoryName(saveFileTextbox.Text);
				if (!Directory.Exists(directory))
				{
					Output.Write($"Save failed directory {directory} not found");
					return;
				}

				File.WriteAllText(saveFileTextbox.Text, jsonTextbox.Text);
				Output.Write("Save JSON content succeeded");
			}
			catch (Exception exception)
			{
				Output.Write("Save file failed: " + exception.Message);
			}
			
		}
	}
}

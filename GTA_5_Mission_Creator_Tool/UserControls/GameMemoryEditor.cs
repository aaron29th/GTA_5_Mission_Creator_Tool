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
using System.Text.RegularExpressions;
using PS3Lib;

namespace GTA_5_Mission_Creator_Tool.UserControls
{
	public partial class GameMemoryEditor : UserControl
	{
		public PS3API PS3 { get; set; } = null;

		private uint globalMemoryAddress = 0;

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

		private void typeGetBtn_Click(object sender, EventArgs e)
		{
			typeSpin.Value = Creator.Type;
		}

		private void typeSetBtn_Click(object sender, EventArgs e)
		{
			Creator.Type = (uint)typeSpin.Value;
		}

		private void subtypeGetBtn_Click(object sender, EventArgs e)
		{
			subtypeSpin.Value = Creator.Subtype;
		}

		private void subtypeSetBtn_Click(object sender, EventArgs e)
		{
			Creator.Subtype = (uint)subtypeSpin.Value;
		}

        private void globalAddressTextbox_TextChanged(object sender, EventArgs e)
        {
			string address = globalAddressTextbox.Text;

			// Normal memory address
			if (Regex.IsMatch(address, @"^0x([0-9A-Fa-f]+)$"))
            {
				globalMemoryAddress = Convert.ToUInt32(address, 16);
			} else
            {
				globalMemoryAddress = Global.getPtr(address);
			}

			memoryAddressLabel.Text = $"Memory address: 0x{globalMemoryAddress:X}";
			setGlobalsEditorsEnabled(globalMemoryAddress != 0);
		}

        private void memoryAddressCopyBtn_Click(object sender, EventArgs e)
        {
			Clipboard.SetText($"0x{globalMemoryAddress:X}");
        }

		void setGlobalsEditorsEnabled(bool enabled)
        {
			globalStringGroupBox.Enabled = enabled;
			globalFloatGroupBox.Enabled = enabled;
			globalUintGroupBox.Enabled = enabled;
			globalVec3GroupBox.Enabled = enabled;
        }

        private void globalStringRead_Click(object sender, EventArgs e)
        {
			globalStringTextbox.Text = PS3.Extension.ReadString(globalMemoryAddress);
        }

        private void globalStringWrite_Click(object sender, EventArgs e)
        {
			PS3.Extension.WriteString(globalMemoryAddress, globalStringTextbox.Text);
        }

        private void globalBytesRead_Click(object sender, EventArgs e)
        {

        }

        private void globalBytesWrite_Click(object sender, EventArgs e)
        {

        }

        private void globalFloatRead_Click(object sender, EventArgs e)
        {
            try
            {
				globalFloatSpin.Value = (decimal)PS3.Extension.ReadFloat(globalMemoryAddress);
			}
            catch
            {
				globalFloatSpin.Value = -1;
				Output.Write("Read float failed");
			}
        }

        private void globalFloatWrite_Click(object sender, EventArgs e)
        {
			PS3.Extension.WriteFloat(globalMemoryAddress, (float)globalFloatSpin.Value);
		}

        private void globalUintRead_Click(object sender, EventArgs e)
        {
			globalUintSpin.Value = PS3.Extension.ReadUInt32(globalMemoryAddress);

		}

        private void globalUintWrite_Click(object sender, EventArgs e)
        {
			PS3.Extension.WriteUInt32(globalMemoryAddress, (uint)globalUintSpin.Value);
		}

        private void globalVec3Read_Click(object sender, EventArgs e)
        {
			try
			{
				globalVec3XSpin.Value = (decimal)PS3.Extension.ReadFloat(globalMemoryAddress);
				globalVec3YSpin.Value = (decimal)PS3.Extension.ReadFloat(globalMemoryAddress + 4);
				globalVec3ZSpin.Value = (decimal)PS3.Extension.ReadFloat(globalMemoryAddress + 8);
			}
			catch
			{
				globalVec3XSpin.Value = 0;
				globalVec3YSpin.Value = 0;
				globalVec3ZSpin.Value = 0;
				Output.Write("Read vec3 failed");
			}
		}

        private void globalVec3Write_Click(object sender, EventArgs e)
        {
			PS3.Extension.WriteFloat(globalMemoryAddress, (float)globalVec3XSpin.Value);
			PS3.Extension.WriteFloat(globalMemoryAddress + 4, (float)globalVec3YSpin.Value);
			PS3.Extension.WriteFloat(globalMemoryAddress + 8, (float)globalVec3ZSpin.Value);
		}
    }
}

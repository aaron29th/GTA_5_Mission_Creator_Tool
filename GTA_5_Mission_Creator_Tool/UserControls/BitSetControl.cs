using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_5_Mission_Creator_Tool.UserControls
{
	public partial class BitSetControl : UserControl
	{
		public uint value { get; set; }

		CheckBox[] checkBoxes = null;

		public BitSetControl()
		{
			InitializeComponent();

			checkBoxes = new CheckBox[]
			{
				c0, c1, c2, c3, c4, c5, c6, c7,
				c8, c9, c10, c11, c12, c13, c14, c15,
				c16, c17, c18, c19, c20, c21, c22, c23,
				c24, c25, c26, c27, c28, c29, c30, c31
			};
		}

		private void checkChanged(object sender, EventArgs e)
		{
			uint val = 0;

			for (int i = 0; i < 32; i++)
			{
				val += checkBoxes[i].Checked ? 1u << i : 0;
			}

			valueSpin.Value = val;
		}

		private void valueSpin_ValueChanged(object sender, EventArgs e)
		{
			value = (uint)valueSpin.Value;

			for (int i = 0; i < 32;i++)
			{
				checkBoxes[i].Checked = (value & (1 << i)) != 0;
			}
		}
	}
}

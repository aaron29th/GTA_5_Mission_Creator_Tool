using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTA_5_Mission_Creator_Tool.UserControls;

namespace GTA_5_Mission_Creator_Tool.Models
{
	public static class Output
	{
		public static OutputBox outputBox = null;

		public static void write(string text)
		{
			outputBox?.prependMessage($"[ {DateTime.Now:H:mm:ss} ] {text}");
		}

		public static void write(string formatStr, params object[] args)
		{
			write(string.Format(formatStr, args));
		}
	}
}

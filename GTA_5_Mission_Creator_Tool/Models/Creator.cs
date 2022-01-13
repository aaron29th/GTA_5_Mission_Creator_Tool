using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;

namespace GTA_5_Mission_Creator_Tool.Models
{
	public static class Creator
	{
		public static PS3API PS3 { get; set; }

		public static string title
		{
			get => PS3.Extension.ReadString(0);
			set => PS3.Extension.WriteString(0, value);
		}

		public static string description
		{
			get => PS3.Extension.ReadString(0);
			set => PS3.Extension.WriteString(0, value);
		}

		public static bool bypassNoConnection
		{
			get => PS3.Extension.ReadUInt32(0) == 0;
			set => PS3.Extension.WriteUInt32(0, (value ? 0u : 1));
		}

		public static bool loadScript(string scriptName, uint stackSize = 15000)
		{
			return false;
		}

		public static string getMetaJson()
		{
			return "";
		}

		public static string getContentJson()
		{
			return "";
		}
	}
}

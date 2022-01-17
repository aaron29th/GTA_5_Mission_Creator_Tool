using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;

namespace GTA_5_Mission_Creator_Tool.Models
{
	public static class Creator
	{
		public static PS3API PS3 { get; set; } = null;

		private const uint LiR3_0 = 0x38600000;
		private const uint LiR3_1 = 0x38600001;

		public static uint TypeAddress => PS3.Extension.ReadUInt32(0x01CBA468) + 0x68C8;

		public static uint Type
		{
			get => PS3.Extension.ReadUInt32(TypeAddress);
			set => PS3.Extension.WriteUInt32(TypeAddress, value);
		}

		public static uint Subtype
		{
			get => PS3.Extension.ReadUInt32(TypeAddress + 0x4);
			set => PS3.Extension.WriteUInt32(TypeAddress + 0x4, value);
		}

		public static string Title
		{
			get => PS3.Extension.ReadString(TypeAddress + 15575 * 4);
			set => PS3.Extension.WriteString(TypeAddress + 15575 * 4, value);
		}

		public static string Description
		{
			get => PS3.Extension.ReadString(TypeAddress + 15590 * 4);
			set => PS3.Extension.WriteString(TypeAddress + 15590 * 4, value);
		}

		public static bool BypassNoConnection
		{
			get => PS3.Extension.ReadUInt32(0x011BB388) == LiR3_1;
			set => PS3.Extension.WriteUInt32(0x011BB388, (value ? LiR3_1 : 0x63E30000));
		}

		public static bool RockstarDev
		{
			get => PS3.Extension.ReadUInt32(0x39BC78) == 0x38600001;
			set => PS3.Extension.WriteUInt32(0x39BC78, (value ? LiR3_1 : LiR3_0));
		}

		public static void IsCloudAvailable(bool patched)
		{
			PS3.Extension.WriteUInt32(0x011BB358, patched ? LiR3_1 : LiR3_0);
			PS3.Extension.WriteUInt32(0x011BB388, patched ? LiR3_1 : 0x63E30000);
		}

		public static void BypassProfanityCheck(bool patched)
		{
			// SOCIALCLUB::SC_PROFANITY_GET_CHECK_IS_VALID
			PS3.Extension.WriteUInt32(0x3E3814, patched ? LiR3_1 : LiR3_0);

			// SOCIALCLUB::SC_PROFANITY_GET_CHECK_IS_PENDING
			PS3.Extension.WriteUInt32(0x3E3864, patched ? LiR3_0 : 0x5463DFFE);

			// SOCIALCLUB::SC_PROFANITY_GET_STRING_PASSED
			PS3.Extension.WriteUInt32(0x3E3894, patched ? LiR3_1 : 0x5463DFFE);
		}

		public static string GetContentJson()
		{
			uint jsonLocation = PS3.Extension.ReadUInt32(0x1003FFDC);
			return PS3.Extension.ReadString(jsonLocation);
		}
	}
}

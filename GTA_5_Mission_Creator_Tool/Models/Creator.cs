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
		public static PS3API PS3 { get; set; }

		private const uint LiR3_0 = 0x38600000;
		private const uint LiR3_1 = 0x38600001;

		private static uint TypeAddress => PS3.Extension.ReadUInt32(0x01CBA468) + 0x68C8;

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

		public static bool LoadScript(string scriptName, uint stackSize = 15000)
		{
			uint aPointer = 0x10041F88;
			uint bPointer = 0x10041FB0;
			uint cPointer = 0x10041FD8;

			// A = &B
			PS3.Extension.WriteUInt32(aPointer, bPointer);
			PS3.Extension.WriteUInt32(aPointer + 0x4, 0x2);
			PS3.Extension.WriteUInt32(aPointer + 0x8, bPointer);

			// B = &C
			PS3.Extension.WriteUInt32(bPointer, cPointer);
			PS3.Extension.WriteUInt32(bPointer + 0x4, stackSize);

			// C
			PS3.Extension.WriteString(cPointer, scriptName);

			if (RPC.Call(Natives.SCRIPT_DOES_SCRIPT_EXIST, scriptName) != 1)
			{
				return false;
			}

			RPC.Call(Natives.SCRIPT_REQUEST_SCRIPT, scriptName);
			Thread.Sleep(500);
			if (RPC.Call(Natives.SCRIPT_HAS_SCRIPT_LOADED, scriptName) == 1)
			{
				//Thread.Sleep(1000);
				RPC.Call(Natives.SYSTEM_START_NEW_SCRIPT, aPointer);
				RPC.Call(Natives.SCRIPT_SET_SCRIPT_AS_NO_LONGER_NEEDED, scriptName);
			}

			return true;
		}

		public static bool TerminateScript(string scriptName)
		{
			if (RPC.Call(Natives.SCRIPT_DOES_SCRIPT_EXIST, scriptName) != 1)
			{
				return false;
			}

			RPC.Call(Natives.GAMEPLAY_TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME, scriptName);

			return true;
		}

		public static string GetContentJson()
		{
			uint jsonLocation = PS3.Extension.ReadUInt32(0x1003FFDC);
			return PS3.Extension.ReadString(jsonLocation);
		}
	}
}

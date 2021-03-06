using PS3Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GTA_5_Mission_Creator_Tool.Models
{
    public static class Scripts
    {
		public static PS3API PS3 { get; set; } = null;

		public static bool Load(string scriptName, uint stackSize = 15000)
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

		public static bool Terminate(string scriptName)
		{
			if (RPC.Call(Natives.SCRIPT_DOES_SCRIPT_EXIST, scriptName) != 1)
			{
				return false;
			}

			RPC.Call(Natives.GAMEPLAY_TERMINATE_ALL_SCRIPTS_WITH_THIS_NAME, scriptName);

			return true;
		}

		public static int GetNumberOfRunningInstances(string scriptName)
        {
			return RPC.Call(Natives.SCRIPT_GET_NUMBER_OF_REFERENCES_OF_SCRIPT_WITH_NAME_HASH, Util.Joaat(scriptName));
        }
	}
}

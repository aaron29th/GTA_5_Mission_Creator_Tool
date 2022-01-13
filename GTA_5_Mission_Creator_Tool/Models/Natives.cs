using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_5_Mission_Creator_Tool.Models
{
	enum Natives : uint
	{
		PLAYER_IS_PLAYER_ONLINE = 0x396D00,

		DATAFILE_GET_FILE_DICT = 0x3752F0,
		OBJECT_STRINGIFY = 0x37460C,
		OBJECT_VALUE_ADD_INTEGER = 0x375324,

		SYSTEM_START_NEW_SCRIPT = 0x91FB74,

		SCRIPT_REQUEST_SCRIPT = 0x407184,
		SCRIPT_HAS_SCRIPT_LOADED = 0x4072B4,
		SCRIPT_DOES_SCRIPT_EXIST = 0x40735C,
		SCRIPT_SET_SCRIPT_AS_NO_LONGER_NEEDED = 0x407228
	}
}

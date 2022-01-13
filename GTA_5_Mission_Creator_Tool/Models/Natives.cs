using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_5_Mission_Creator_Tool.Models
{
	enum Natives : uint
	{
		DATAFILE_GET_FILE_DICT = 0x003752F0,
		OBJECT_STRINGIFY = 0x0037460C,
		OBJECT_VALUE_ADD_INTEGER = 0x00375324,

		SYSTEM_START_NEW_SCRIPT = 0x414D10,
		SYSTEM_START_NEW_SCRIPT_WITH_ARGS = 0x0091F850,

		SCRIPT_REQUEST_SCRIPT = 0x00407184,
		SCRIPT_HAS_SCRIPT_LOADED = 0x004072B4,
		SCRIPT_DOES_SCRIPT_EXIST = 0x0040735C
	}
}

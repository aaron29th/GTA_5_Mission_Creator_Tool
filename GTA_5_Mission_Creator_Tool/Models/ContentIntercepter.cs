using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS3Lib;

namespace GTA_5_Mission_Creator_Tool.Models
{
	public static class ContentIntercepter
	{
		public static PS3API PS3 = null;

		private static readonly byte[] hookData =
		{
			// Store stack / link
			0xF8, 0x21, 0xFF, 0x91,		// stdu	%r1, -0x70(%r1)
			0x7C, 0x08, 0x02, 0xA6,		// mflr	%r0
			0xF8, 0x01, 0x00, 0x80,		// std	%r0, 0x80(%r1)

			// r4 = 0x1003FFD8
			0x3C, 0x80, 0x10, 0x03,		// lis	%r4, 0x1003
			0x60, 0x84, 0xFF, 0xD8,		// ori %r4, %r4, 0xFFD8

			// (*0x1003FFD8) = r3
			0x90, 0x64, 0x00, 0x00,		// stw	%r3, 0(%r4)
			
			// if (0x1003FFDC == 0)
			//		goto(+0x14)
			0x80, 0x64, 0x00, 0x04,		// lwz	%r3, 4(%r4)
			0x2C, 0x03, 0x00, 0x00,		// cmpwi	%r3, 0
			0x41, 0x82, 0x00, 0x14,		// beq 0x14

			// free(*(0x1003FFDC))
			0x3C, 0x80, 0x00, 0x01,		// lis	%r4, 0x0001
			0x60, 0x84, 0x02, 0xC0,		// ori %r4, %r4, 0x02C0
			0x7C, 0x89, 0x03, 0xA6,		// mtctr	%r4
			0x4E, 0x80, 0x04, 0x21,		// bctrl

			// datafileToJson()
			0x3C, 0x80, 0x00, 0x37,		// lis	%r4, 0x0037
			0x60, 0x84, 0x46, 0x0C,		// ori %r4, %r4, 0x460C
			0x7C, 0x89, 0x03, 0xA6,		// mtctr	%r4
			0x4E, 0x80, 0x04, 0x21,		// bctrl

			// r4 = 0x1003FFD8
			0x3C, 0x80, 0x10, 0x03,		// lis	%r4, 0x1003
			0x60, 0x84, 0xFF, 0xD8,		// ori %r4, %r4, 0xFFD8

			// *(0x1003FFDC) = r3
			0x90, 0x64, 0x00, 0x04,		// stw	%r3, 4(%r4)

			// r3 = *(0x1003FFD8)
			0x80, 0x64, 0x00, 0x00,		// lwz	%r3, 0(%r4)

			// Restore stack / link
			0xE8, 0x01, 0x00, 0x80,		// ld	%r0, 0x80(%r1)
			0x7C, 0x08, 0x03, 0xA6,		// mtlr	%r0
			0x38, 0x21, 0x00, 0x70		// addi	%r1, %r1, 0x70
		};

		public static void Enable()
		{
			// Unused memory
			const uint hookFunctionEntry = 0x01A50200;
			uint hookFunctionExit = hookFunctionEntry + (uint)hookData.Length + 4;

			// Hook is player online native
			const uint hookJumpFrom = (uint)Natives.DATAFILE_UPDATE_SAVE_TO_CLOUD;
			const uint hookReturnTo = hookJumpFrom + 4;

			// Check if already enabled
			if (PS3.Extension.ReadUInt32(hookJumpFrom) == Branch(hookJumpFrom, hookFunctionEntry))
			{
				return;
			}

			uint overWrittenInstruction = PS3.Extension.ReadUInt32(hookJumpFrom);
			PS3.Extension.WriteUInt32(hookFunctionExit - 4, overWrittenInstruction);

			// Write hook to unused memory
			PS3.SetMemory(hookFunctionEntry, hookData);

			// Write return branch instruction at end of hook
			PS3.Extension.WriteUInt32(hookFunctionExit, Branch(hookFunctionExit, hookReturnTo));

			// Hook game function
			PS3.Extension.WriteUInt32(hookJumpFrom, Branch(hookJumpFrom, hookFunctionEntry));
		}

		private static uint Branch(uint from, uint to)
		{
			if (from > to)
				return 0x4C000000 - (from - to);

			if (from < to)
				return to - from + 0x48000000;

			return 0x48000000;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS3Lib;

namespace GTA_5_Mission_Creator_Tool.Models
{
    class RPC
    {
	    public static PS3API PS3 = null;

	    private static readonly byte[] hookData = {
	        // Grow stack / store link register
		    0xF8, 0x21, 0xFF, 0x91,		// stdu      r1, -0x70(r1)
	        0x7C, 0x08, 0x02, 0xA6,		// mflr      r0
	        0xF8, 0x01, 0x00, 0x80,		// std       r0, 0x80(r1)

			// r3 = 0x10040000
	        0x3C, 0x60, 0x10, 0x04,		// lis       r3, off_1004004C@h

			// Skip if no native address
			// r12 = r3 + 0x4C;
			// if (*r12 == 0)
			//		goto(end)
	        0x81, 0x83, 0x00, 0x4C,		// lwz       r12, off_1004004C@l(r3)
	        0x2C, 0x0C, 0x00, 0x00,		// cmpwi     r12, 0
	        0x41, 0x82, 0x00, 0x64,		// beq       loc_1A5017C

			// Load parameters
	        0x80, 0x83, 0x00, 0x04,		// lwz       r4, off_10040004@l(r3)
	        0x80, 0xA3, 0x00, 0x08,		// lwz       r5, off_10040008@l(r3)
	        0x80, 0xC3, 0x00, 0x0C,		// lwz       r6, off_1004000C@l(r3)
	        0x80, 0xE3, 0x00, 0x10,		// lwz       r7, off_10040010@l(r3)
	        0x81, 0x03, 0x00, 0x14,		// lwz       r8, off_10040014@l(r3)
	        0x81, 0x23, 0x00, 0x18,		// lwz       r9, off_10040018@l(r3)
	        0x81, 0x43, 0x00, 0x1C,		// lwz       r10, off_1004001C@l(r3)
	        0x81, 0x63, 0x00, 0x20,		// lwz       r11, off_10040020@l(r3)
	        0xC0, 0x23, 0x00, 0x24,		// lfs       f1, flt_10040024@l(r3)
	        0xc0, 0x43, 0x00, 0x28,		// lfs       f2, flt_10040028@l(r3)
	        0xC0, 0x63, 0x00, 0x2C,		// lfs       f3, flt_1004002C@l(r3)
	        0xC0, 0x83, 0x00, 0x30,		// lfs       f4, flt_10040030@l(r3)
	        0xC0, 0xA3, 0x00, 0x34,		// lfs       f5, flt_10040034@l(r3)
	        0xc0, 0xC3, 0x00, 0x38,		// lfs       f6, flt_10040038@l(r3)
	        0xC0, 0xE3, 0x00, 0x3C,		// lfs       f7, flt_1004003C@l(r3)
	        0xC1, 0x03, 0x00, 0x40,		// lfs       f8, flt_10040040@l(r3)
	        0xC1, 0x23, 0x00, 0x48,		// lfs       f9, flt_10040048@l(r3)
	        0x80, 0x63, 0x00, 0x00,		// lwz       r3, off_10040000@l(r3)

			// Call native
			// *(0x10040050) = *(0x1004004C)(params)		// Call native and store result
			// *(0x1004004C) = 0						// Zero native address
	        0x7D, 0x89, 0x03, 0xA6,		// mtctr     r12
	        0x4E, 0x80, 0x04, 0x21,		// bctrl
	        0x3C, 0x80, 0x10, 0x04,		// lis       r4, off_1004004C@h
	        0x38, 0xA0, 0x00, 0x00,		// li        r5, 0
	        0x90, 0xA4, 0x00, 0x4C,		// stw       r5, off_1004004C@l(r4)
	        0x90, 0x64, 0x00, 0x50,		// stw       r3, dword_10040050@l(r4)

			// end:
			// Restore stack / link register
			0xE8, 0x01, 0x00, 0x80,		// ld        r0, 0x80(r1)
	        0x7C, 0x08, 0x03, 0xA6,		// mtlr      r0
	        0x38, 0x21, 0x00, 0x70		// addi      r1, r1, 0x70
	    };

        private static uint Branch(uint from, uint to)
        {
	        if (from > to)
                return 0x4C000000 - (from - to);
	        
	        if (from < to)
		        return to - from + 0x48000000;
	        
	        return 0x48000000;
        }

        public static void Enable()
        {
	        // Unused memory
	        const uint hookFunctionEntry = 0x01A50100;
	        uint hookFunctionExit = hookFunctionEntry + (uint)hookData.Length + 4;

	        // Hook is player online native
	        const uint hookJumpFrom = (uint)Natives.PLAYER_IS_PLAYER_ONLINE;
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

        public static int Call(Natives nativeAddress, params object[] parameters)
        {
			// Do not change - must change hook data too
	        const uint intParamsBuffer     = 0x10040000;
	        const uint floatParamsBuffer   = 0x10040024;
	        const uint nativeAddressBuffer = 0x1004004C;
	        const uint responseBuffer      = 0x10040050;
			const uint vectorParamsBuffer  = 0x10041000;
	        const uint stringParamsBuffer  = 0x10042000;

	        const uint maxStringSize = 0x400 - 1;

            int length = parameters.Length;

            uint intParamNum = 0;
            uint floatParamNum = 0;
            uint vecParamNum = 0;
            uint stringParamNum = 0;

			for (int i = 0; i < length; i++)
            {
				if (intParamNum >= 9 && parameters[i].GetType() != typeof(float))
					throw new ArgumentException("Max integer parameters reached - 9");

				if (floatParamNum >= 10)
					throw new ArgumentException("Max float parameters reached - 10");

				switch (parameters[i])
	            {
		            case int val:
			            PS3.Extension.WriteInt32(intParamsBuffer + (intParamNum * 4), val);
			            intParamNum++;
			            break;
		            case uint val:
			            PS3.Extension.WriteUInt32(intParamsBuffer + (intParamNum * 4), val);
			            intParamNum++;
			            break;
		            case float val:
			            WriteSingle(floatParamsBuffer + (floatParamNum * 4), val);
			            floatParamNum++;
			            break;
		            case float[] val:
		            {
			            if (vecParamNum >= 1024)
				            throw new ArgumentException("Max float array parameters reached");

			            uint vecLocation = vectorParamsBuffer + (vecParamNum * 4);

			            WriteSingle(vecLocation, val);
			            vecParamNum += (uint)val.Length;

			            PS3.Extension.WriteUInt32(intParamsBuffer + (intParamNum * 4), vecLocation);
			            intParamNum++;
			            
			            break;
		            }
					case string val:
					{
						if (val.Length > maxStringSize)
							throw new ArgumentException("Max string length 1023 (0x3FF)");

						uint strLocation = stringParamsBuffer + (stringParamNum * (maxStringSize + 1));

			            PS3.Extension.WriteString(strLocation, val);
			            stringParamNum++;

			            PS3.Extension.WriteUInt32(intParamsBuffer + (intParamNum * 4), strLocation);
			            intParamNum++;
			            
			            break;
		            }
					default:
						throw new NotImplementedException();

	            }
            }

            PS3.Extension.WriteUInt32(nativeAddressBuffer, (uint)nativeAddress);
            while (PS3.Extension.ReadUInt32(nativeAddressBuffer) != 0) ;

            return PS3.Extension.ReadInt32(responseBuffer);
        }

        private static void WriteSingle(uint address, float input)
        {
            byte[] bytes = new byte[4];

            BitConverter.GetBytes(input).CopyTo((Array)bytes, 0);

            Array.Reverse((Array)bytes, 0, 4);

            PS3.SetMemory(address, bytes);
        }

        private static void WriteSingle(uint address, float[] input)
        {
	        for (uint i = 0; i < input.Length; i++)
                WriteSingle(address + 4 * i, input[i]);
        }
    }

}

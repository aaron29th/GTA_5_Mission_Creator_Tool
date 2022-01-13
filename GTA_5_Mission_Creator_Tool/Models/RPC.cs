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
	    public static PS3API PS3;

	    private static readonly byte[] hookData = {
	        0xF8, 0x21, 0xFF, 0x91,
	        0x7C, 0x08, 0x02, 0xA6,
	        0xF8, 0x01, 0x00, 0x80,
	        0x3C, 0x60, 0x10, 0x04,
	        0x81, 0x83, 0x00, 0x4C,
	        0x2C, 0x0C, 0x00, 0x00,
	        0x41, 0x82, 0x00, 0x64,
	        0x80, 0x83, 0x00, 0x04,
	        0x80, 0xA3, 0x00, 0x08,
	        0x80, 0xC3, 0x00, 0x0C,
	        0x80, 0xE3, 0x00, 0x10,
	        0x81, 0x03, 0x00, 0x14,
	        0x81, 0x23, 0x00, 0x18,
	        0x81, 0x43, 0x00, 0x1C,
	        0x81, 0x63, 0x00, 0x20,
	        0xC0, 0x23, 0x00, 0x24,
	        0xc0, 0x43, 0x00, 0x28,
	        0xC0, 0x63, 0x00, 0x2C,
	        0xC0, 0x83, 0x00, 0x30,
	        0xC0, 0xA3, 0x00, 0x34,
	        0xc0, 0xC3, 0x00, 0x38,
	        0xC0, 0xE3, 0x00, 0x3C,
	        0xC1, 0x03, 0x00, 0x40,
	        0xC1, 0x23, 0x00, 0x48,
	        0x80, 0x63, 0x00, 0x00,
	        0x7D, 0x89, 0x03, 0xA6,
	        0x4E, 0x80, 0x04, 0x21,
	        0x3C, 0x80, 0x10, 0x04,
	        0x38, 0xA0, 0x00, 0x00,
	        0x90, 0xA4, 0x00, 0x4C,
	        0x90, 0x64, 0x00, 0x50,
	        0xE8, 0x01, 0x00, 0x80,
	        0x7C, 0x08, 0x03, 0xA6,
	        0x38, 0x21, 0x00, 0x70
	    };

        private static uint Branch(uint from, uint to)
        {
	        if (from > to)
                return 0x4C000000 - (from - to);
	        
	        if (@from < to)
		        return to - @from + 0x48000000;
	        
	        return 0x48000000;
        }

        public static void Enable()
        {
	        // Unused memory
	        const uint hookFunctionEntry = 0x1BE4C80;
	        uint hookFunctionExit = hookFunctionEntry + (uint)hookData.Length + 4;

	        // Hook is player online native
	        const uint hookJumpFrom = 0x3E3A20;
	        const uint hookReturnTo = 0x3E3A24;

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

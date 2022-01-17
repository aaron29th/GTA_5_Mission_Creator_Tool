using PS3Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GTA_5_Mission_Creator_Tool.Models
{
    public static class Global
    {
        public static PS3API PS3 { get; set; } = null;

        private const uint ptrsArr = 0x1CBA450;

        public static uint getPtr(uint index, uint fSum = 0)
        {
            uint ptrOffset = ((index >> 18) & 0x3F) * 4;
            uint sectionAddress = PS3.Extension.ReadUInt32(ptrsArr + ptrOffset);
            if (sectionAddress == 0)
                return 0;

            uint sectionOffset = (index & 0x3FFF) * 4;
            return sectionAddress + sectionOffset + fSum * 4;
        }

        public static uint getPtr(string address)
        {
            // Check address in globals format
            string correctFormatPattern = @"^(Global_)([A-Fa-f0-9]+)((\.|->)f_([A-Fa-f0-9]+))*$";
            if (!Regex.IsMatch(address, correctFormatPattern))
                return 0;

            // Get global index
            Match globalIndexMatch = Regex.Match(address, @"^(Global_)([A-Fa-f0-9]+)");
            if (!globalIndexMatch.Success)
                return 0;

            uint globalIndex = Convert.ToUInt32(globalIndexMatch.Groups[2].Value, 16);

            // Get offset from global index
            uint fSum = 0;
            Regex fValuesRgx = new Regex(@"f_([A-Fa-f0-9]+)");
            foreach (Match m in fValuesRgx.Matches(address))
            {
                fSum += Convert.ToUInt32(m.Groups[1].Value, 16);
            }

            return getPtr(globalIndex, fSum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtherCAT_Examples_CSharp
{
    public static class Extensions
    {
        //public static short SetBit(short data, int bit, bool isSet)
        //{
        //    if (isSet)
        //        data |= (short)(1 << bit);
        //    else
        //        data &= (short)(~(1 << bit));

        //    return data;
        //}

        public static bool GetBit(this ushort data, int bit)
        {
            return ((data >> bit) & 0x1) == 1;
        }

        public static bool GetBit(this short data, int bit)
        {
            return ((data >> bit) & 0x1) == 1;
        }
    }
}

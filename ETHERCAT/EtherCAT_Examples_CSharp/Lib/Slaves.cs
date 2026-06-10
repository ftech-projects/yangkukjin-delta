using System.Runtime.InteropServices;


// Date : 2020.08.20
// Ver : 1.0.0
namespace ComiLib.EtherCAT.Slave
{
    public class ETS_MC02P
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct OutPDO
        {
            public short Control_Word;
            public byte Modes_of_Operation;
            public byte temp;
            public float Target_Position;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct InPDO
        {
            public ushort Status_Word;
            public byte Modes_of_Operation_Display;
            public byte temp;
            public float Position_Actual_Value;
            public float Velocity_Actual_Value;
            public uint Digital_Input;
        };
    }


    public class ETS_OHT
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct OutPDO
        {
            public ushort Control_Word;
            public int Target_Position;
            public byte Modes_of_Operation;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct InPDO
        {
            public ushort Status_Word;
            public int Position_Actual_Value;
            public byte Modes_of_Operation_Display;
            public ushort Digital_Input;
        };
    }


    public class CMC
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct OutPDO
        {
            public ushort Control_Word;
            public int Target_Position;
            public int Target_Velocity;
            public byte Modes_of_Operation;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct InPDO
        {
            public ushort Status_Word;
            public int Position_Actual_Value;
            public int Velocity_Actual_Value;
            public byte Modes_of_Operation_Display;
        };
    }

    public class EMS
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct OutPDO
        {
            public ushort Control_Word;
            public int Target_Position;
            public byte Modes_of_Operation;
        };

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct InPDO
        {
            public ushort Status_Word;
            public int Position_Actual_Value;
            public int Velocity_Actual_Value;
            public uint Digital_Input;
            public ushort ErrorCode;
            public byte Modes_of_Operation_Display;
        };
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct EC04H_OutPDO
    {
        public int Counter_DefaultAB;
        public short Counter_DefaultZ;
        public ushort Latch_ReadLatchIndex;

        public ushort CMP_StartAddress;
        public ushort CMP_ListNumber;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public int[] CMP_Couter;
        public ushort CMP_ListUpTrigger;
    };

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct EC04H_InPDO
    {
        public int Counter_DisplayDefaultAB;
        public int Counter_ReadAB;
        public short Counter_DisplayDefaultZ;
        public short Counter_ReadZ;
        public ushort Latch_LatchIndex;
        public int Latch_LatchCounter;
        public ushort CMP_Index;
        public int CMP_Value;
        public ushort CMP_ResponseTrigger;
    };

    public class ETS_EC04H
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct OutPDO
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public EC04H_OutPDO[] OutPDOs;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct InPDO
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public EC04H_InPDO[] InPDOs;
        }
    }
}

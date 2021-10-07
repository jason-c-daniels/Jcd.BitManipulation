using System;

namespace Jcd.BitManipulation
{
    public static class BoolArrayExtensions
    {
        public static bool[] ToBoolArray(this byte bits) => new BitIndexerByte { Bits = bits }.Slice(0, BitIndexerByte.BitSize);
        public static bool[] ToBoolArray(this sbyte bits) => new BitIndexerSByte { Bits = bits }.Slice(0, BitIndexerSByte.BitSize);

        public static bool[] ToBoolArray(this ushort bits) => new BitIndexerUInt16 { Bits = bits }.Slice(0, BitIndexerUInt16.BitSize);
        public static bool[] ToBoolArray(this short bits) => new BitIndexerInt16 { Bits = bits }.Slice(0, BitIndexerInt16.BitSize);
        
        public static bool[] ToBoolArray(this uint bits) => new BitIndexerUInt32 { Bits = bits }.Slice(0, BitIndexerUInt32.BitSize);
        public static bool[] ToBoolArray(this int bits) => new BitIndexerInt32 { Bits = bits }.Slice(0, BitIndexerInt32.BitSize);
        
        public static bool[] ToBoolArray(this ulong bits) => new BitIndexerUInt64 { Bits = bits }.Slice(0, BitIndexerUInt64.BitSize);
        public static bool[] ToBoolArray(this long bits) => new BitIndexerInt64 { Bits = bits }.Slice(0, BitIndexerUInt64.BitSize);

        public static byte ToByte(this bool[] bits)
        {
            byte result = 0;
            for (var i = 0; i < bits.Length;i++)
            {
                result.StoreBit(i,bits[i]);
            }
            return result;
        }

        public static sbyte ToSByte(this bool[] bits)
        {
            sbyte result = 0;
            for (var i = 0; i < bits.Length; i++)
            {
                result.StoreBit(i, bits[i]);
            }

            return result;
        }

        public static UInt16 ToUInt16(this bool[] bits)
        {
            UInt16 result = 0;
            for (var i = 0; i < bits.Length;i++)
            {
                result.StoreBit(i,bits[i]);
            }
            return result;
        } 
        
        public static Int16 ToInt16(this bool[] bits)
        {
            Int16 result = 0;
            for (var i = 0; i < bits.Length;i++)
            {
                result.StoreBit(i,bits[i]);
            }
            return result;
        }

        public static UInt32 ToUInt32(this bool[] bits)
        {
            UInt32 result = 0;
            for (var i = 0; i < bits.Length; i++)
            {
                result.StoreBit(i, bits[i]);
            }

            return result;
        }

        public static Int32 ToInt32(this bool[] bits)
        {
            Int32 result = 0;
            for (var i = 0; i < bits.Length; i++)
            {
                result.StoreBit(i, bits[i]);
            }

            return result;
        }

        public static UInt64 ToUInt64(this bool[] bits)
        {
            UInt64 result = 0;
            for (var i = 0; i < bits.Length;i++)
            {
                result.StoreBit(i,bits[i]);
            }
            return result;
        } 
        
        public static Int64 ToInt64(this bool[] bits)
        {
            Int64 result = 0;
            for (var i = 0; i < bits.Length;i++)
            {
                result.StoreBit(i,bits[i]);
            }
            return result;
        } 
    }
}
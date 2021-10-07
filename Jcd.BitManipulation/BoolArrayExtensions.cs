using System;

namespace Jcd.BitManipulation
{
    /// <summary>
    /// A bunch of extension methods to help with converting numbers to and from arrays of bools
    /// </summary>
    public static class BoolArrayExtensions
    {
        /// <summary>
        /// Convert a byte into an array of bools
        /// </summary>
        /// <param name="bits">the byte to convert</param>
        /// <returns>the array. LSB at index 0</returns>
        public static bool[] ToBoolArray(this byte bits) => new BitIndexerByte { Bits = bits }.Slice(0, BitIndexerByte.BitSize);

        /// <summary>
        /// Convert an sbyte into an array of bools
        /// </summary>
        /// <param name="bits">the sbyte to convert</param>
        /// <returns>the array. LSB at index 0</returns>
        public static bool[] ToBoolArray(this sbyte bits) => new BitIndexerSByte { Bits = bits }.Slice(0, BitIndexerSByte.BitSize);

        /// <summary>
        /// Convert a ushort into an array of bools
        /// </summary>
        /// <param name="bits">the bits of the ushort to convert</param>
        /// <returns>the array. LSB at index 0</returns>
        public static bool[] ToBoolArray(this ushort bits) => new BitIndexerUInt16 { Bits = bits }.Slice(0, BitIndexerUInt16.BitSize);

        /// <summary>
        /// Convert a short into an array of bools
        /// </summary>
        /// <param name="bits">the short to convert</param>
        /// <returns>the array. LSB at index 0</returns>
        public static bool[] ToBoolArray(this short bits) => new BitIndexerInt16 { Bits = bits }.Slice(0, BitIndexerInt16.BitSize);
        
        /// <summary>
        /// Convert a uint into an array of bools
        /// </summary>
        /// <param name="bits">the uint to convert</param>
        /// <returns>the array. LSB at index 0</returns>
        public static bool[] ToBoolArray(this uint bits) => new BitIndexerUInt32 { Bits = bits }.Slice(0, BitIndexerUInt32.BitSize);

        /// <summary>
        /// Convert an int into an array of bools
        /// </summary>
        /// <param name="bits">the int to convert</param>
        /// <returns>the array. LSB at index 0</returns>
        public static bool[] ToBoolArray(this int bits) => new BitIndexerInt32 { Bits = bits }.Slice(0, BitIndexerInt32.BitSize);
        
        /// <summary>
        /// Convert a ulong into an array of bools
        /// </summary>
        /// <param name="bits">the ulong to convert</param>
        /// <returns>the array. LSB at index 0</returns>
        public static bool[] ToBoolArray(this ulong bits) => new BitIndexerUInt64 { Bits = bits }.Slice(0, BitIndexerUInt64.BitSize);

        /// <summary>
        /// Convert a long into an array of bools
        /// </summary>
        /// <param name="bits">the long to convert</param>
        /// <returns>the array. LSB at index 0</returns>
        public static bool[] ToBoolArray(this long bits) => new BitIndexerInt64 { Bits = bits }.Slice(0, BitIndexerUInt64.BitSize);

        /// <summary>
        /// Converts an array of bools into a byte, discarding any excess bits.
        /// </summary>
        /// <param name="bits">the array of bools to convert, LSB at index 0</param>
        /// <returns>The converted byte</returns>
        public static byte ToByte(this bool[] bits)
        {
            byte result = 0;
            for (var i = 0; i < bits.Length;i++)
            {
                result.StoreBit(i,bits[i]);
            }
            return result;
        }

        /// <summary>
        /// Converts an array of bools into an sbyte, discarding any excess bits.
        /// </summary>
        /// <param name="bits">the array of bools to convert, LSB at index 0</param>
        /// <returns>The converted sbyte</returns>
        public static sbyte ToSByte(this bool[] bits)
        {
            sbyte result = 0;
            for (var i = 0; i < bits.Length; i++)
            {
                result.StoreBit(i, bits[i]);
            }

            return result;
        }

        /// <summary>
        /// Converts an array of bools into a ushort, discarding any excess bits.
        /// </summary>
        /// <param name="bits">the array of bools to convert, LSB at index 0</param>
        /// <returns>The converted ushort</returns>
        public static UInt16 ToUInt16(this bool[] bits)
        {
            UInt16 result = 0;
            for (var i = 0; i < bits.Length;i++)
            {
                result.StoreBit(i,bits[i]);
            }
            return result;
        } 
        
        /// <summary>
        /// Converts an array of bools into a short, discarding any excess bits.
        /// </summary>
        /// <param name="bits">the array of bools to convert, LSB at index 0</param>
        /// <returns>The converted short</returns>
        public static Int16 ToInt16(this bool[] bits)
        {
            Int16 result = 0;
            for (var i = 0; i < bits.Length;i++)
            {
                result.StoreBit(i,bits[i]);
            }
            return result;
        }

        /// <summary>
        /// Converts an array of bools into a uint, discarding any excess bits.
        /// </summary>
        /// <param name="bits">the array of bools to convert, LSB at index 0</param>
        /// <returns>The converted uint</returns>
        public static UInt32 ToUInt32(this bool[] bits)
        {
            UInt32 result = 0;
            for (var i = 0; i < bits.Length; i++)
            {
                result.StoreBit(i, bits[i]);
            }

            return result;
        }

        /// <summary>
        /// Converts an array of bools into an int, discarding any excess bits.
        /// </summary>
        /// <param name="bits">the array of bools to convert, LSB at index 0</param>
        /// <returns>The converted int</returns>
        public static Int32 ToInt32(this bool[] bits)
        {
            Int32 result = 0;
            for (var i = 0; i < bits.Length; i++)
            {
                result.StoreBit(i, bits[i]);
            }

            return result;
        }

        /// <summary>
        /// Converts an array of bools into a ulong, discarding any excess bits.
        /// </summary>
        /// <param name="bits">the array of bools to convert, LSB at index 0</param>
        /// <returns>The converted ulong</returns>
        public static UInt64 ToUInt64(this bool[] bits)
        {
            UInt64 result = 0;
            for (var i = 0; i < bits.Length;i++)
            {
                result.StoreBit(i,bits[i]);
            }
            return result;
        } 
        
        /// <summary>
        /// Converts an array of bools into a long, discarding any excess bits.
        /// </summary>
        /// <param name="bits">the array of bools to convert, LSB at index 0</param>
        /// <returns>The converted long</returns>
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
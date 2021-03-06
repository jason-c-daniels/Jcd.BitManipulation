// ReSharper disable ReplaceSliceWithRangeIndexer

namespace Jcd.BitManipulation
{
    /// <summary>
    /// A bunch of extension methods to help with converting numbers to and from arrays of bools
    /// </summary>
    public static class BooleanArrayExtensions
    {
        /// <summary>
        /// Convert a byte into an array of bools
        /// </summary>
        /// <param name="bits">the byte to convert</param>
        /// <returns>the array. LSB at index 0</returns>
        public static bool[] ToBooleanArray(this byte bits) => new BitIndexerByte { Bits = bits }.Slice(0, BitIndexerByte.BitSize);

        /// <summary>
        /// Convert an sbyte into an array of bools
        /// </summary>
        /// <param name="bits">the sbyte to convert</param>
        /// <returns>the array. LSB at index 0</returns>
        public static bool[] ToBooleanArray(this sbyte bits) => new BitIndexerSByte { Bits = bits }.Slice(0, BitIndexerSByte.BitSize);

        /// <summary>
        /// Convert a ushort into an array of bools
        /// </summary>
        /// <param name="bits">the bits of the ushort to convert</param>
        /// <returns>the array. LSB at index 0</returns>
        public static bool[] ToBooleanArray(this ushort bits) => new BitIndexerUInt16 { Bits = bits }.Slice(0, BitIndexerUInt16.BitSize);

        /// <summary>
        /// Convert a short into an array of bools
        /// </summary>
        /// <param name="bits">the short to convert</param>
        /// <returns>the array. LSB at index 0</returns>
        public static bool[] ToBooleanArray(this short bits) => new BitIndexerInt16 { Bits = bits }.Slice(0, BitIndexerInt16.BitSize);
        
        /// <summary>
        /// Convert a uint into an array of bools
        /// </summary>
        /// <param name="bits">the uint to convert</param>
        /// <returns>the array. LSB at index 0</returns>
        public static bool[] ToBooleanArray(this uint bits) => new BitIndexerUInt32 { Bits = bits }.Slice(0, BitIndexerUInt32.BitSize);

        /// <summary>
        /// Convert an int into an array of bools
        /// </summary>
        /// <param name="bits">the int to convert</param>
        /// <returns>the array. LSB at index 0</returns>
        public static bool[] ToBooleanArray(this int bits) => new BitIndexerInt32 { Bits = bits }.Slice(0, BitIndexerInt32.BitSize);
        
        /// <summary>
        /// Convert a ulong into an array of bools
        /// </summary>
        /// <param name="bits">the ulong to convert</param>
        /// <returns>the array. LSB at index 0</returns>
        public static bool[] ToBooleanArray(this ulong bits) => new BitIndexerUInt64 { Bits = bits }.Slice(0, BitIndexerUInt64.BitSize);

        /// <summary>
        /// Convert a long into an array of bools
        /// </summary>
        /// <param name="bits">the long to convert</param>
        /// <returns>the array. LSB at index 0</returns>
        public static bool[] ToBooleanArray(this long bits) => new BitIndexerInt64 { Bits = bits }.Slice(0, BitIndexerUInt64.BitSize);

        /// <summary>
        /// Converts an array of bools into a byte, discarding any excess bits.
        /// </summary>
        /// <param name="bits">the array of bools to convert, LSB at index 0</param>
        /// <returns>The converted byte</returns>
        public static byte ToByte(this bool[] bits)
        {
            byte result = 0;
            for (var i = 0; i < bits.Length && i < 8; i++)
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
            for (var i = 0; i < bits.Length && i < 8; i++)
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
        public static ushort ToUInt16(this bool[] bits)
        {
            ushort result = 0;
            for (var i = 0; i < bits.Length && i < 16; i++)
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
        public static short ToInt16(this bool[] bits)
        {
            short result = 0;
            for (var i = 0; i < bits.Length && i < 16; i++)
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
        public static uint ToUInt32(this bool[] bits)
        {
            uint result = 0;
            for (var i = 0; i < bits.Length && i < 32; i++)
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
        public static int ToInt32(this bool[] bits)
        {
            var result = 0;
            for (var i = 0; i < bits.Length && i < 32; i++)
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
        public static ulong ToUInt64(this bool[] bits)
        {
            ulong result = 0;
            for (var i = 0; i < bits.Length && i < 64; i++)
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
        public static long ToInt64(this bool[] bits)
        {
            long result = 0;
            for (var i = 0; i < bits.Length && i < 64; i++)
            {
                result.StoreBit(i,bits[i]);
            }
            return result;
        } 
    }
}
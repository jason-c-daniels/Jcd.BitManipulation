// ReSharper disable ReplaceSliceWithRangeIndexer

#region

using System.Runtime.CompilerServices;

using Jcd.BitManipulation.BitIndexers;

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Extension methods to aid in converting numbers to and from arrays of bools
/// </summary>
public static class BooleanArrayExtensions
{
   /// <summary>
   /// Convert a <see cref="byte"/> into an array of bools
   /// </summary>
   /// <param name="bits">the byte to convert</param>
   /// <returns>the array. Least Significant Bit at index 0</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool[] ToBooleanArray(this byte bits)
   {
      return new BitIndexerByte { Bits = bits }.Slice(0, BitIndexerByte.BitSize);
   }

   /// <summary>
   /// Convert an <see cref="sbyte"/> into an array of bools
   /// </summary>
   /// <param name="bits">the <see cref="sbyte"/> to convert</param>
   /// <returns>the array. Least Significant Bit at index 0</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool[] ToBooleanArray(this sbyte bits)
   {
      return new BitIndexerSByte { Bits = bits }.Slice(0, BitIndexerSByte.BitSize);
   }

   /// <summary>
   /// Convert a <see cref="ushort"/> into an array of bools
   /// </summary>
   /// <param name="bits">the bits of the <see cref="ushort"/> to convert</param>
   /// <returns>the array. Least Significant Bit at index 0</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool[] ToBooleanArray(this ushort bits)
   {
      return new BitIndexerUInt16 { Bits = bits }.Slice(0, BitIndexerUInt16.BitSize);
   }

   /// <summary>
   /// Convert a <see cref="short"/> into an array of bools
   /// </summary>
   /// <param name="bits">the <see cref="short"/> to convert</param>
   /// <returns>the array. Least Significant Bit at index 0</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool[] ToBooleanArray(this short bits)
   {
      return new BitIndexerInt16 { Bits = bits }.Slice(0, BitIndexerInt16.BitSize);
   }

   /// <summary>
   /// Convert a uint into an array of bools
   /// </summary>
   /// <param name="bits">the <see cref="uint"/> to convert</param>
   /// <returns>the array. Least Significant Bit at index 0</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool[] ToBooleanArray(this uint bits)
   {
      return new BitIndexerUInt32 { Bits = bits }.Slice(0, BitIndexerUInt32.BitSize);
   }

   /// <summary>
   /// Convert an int into an array of bools
   /// </summary>
   /// <param name="bits">the <see cref="uint"/> to convert</param>
   /// <returns>the array. Least Significant Bit at index 0</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool[] ToBooleanArray(this int bits)
   {
      return new BitIndexerInt32 { Bits = bits }.Slice(0, BitIndexerInt32.BitSize);
   }

   /// <summary>
   /// Convert a <see cref="ulong"/> into an array of bools
   /// </summary>
   /// <param name="bits">the ulong to convert</param>
   /// <returns>the array. Least Significant Bit at index 0</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool[] ToBooleanArray(this ulong bits)
   {
      return new BitIndexerUInt64 { Bits = bits }.Slice(0, BitIndexerUInt64.BitSize);
   }

   /// <summary>
   /// Convert a <see cref="long"/> into an array of bools
   /// </summary>
   /// <param name="bits">the <see cref="long"/> to convert</param>
   /// <returns>the array. Least Significant Bit at index 0</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool[] ToBooleanArray(this long bits)
   {
      return new BitIndexerInt64 { Bits = bits }.Slice(0, BitIndexerUInt64.BitSize);
   }

   /// <summary>
   /// Convert a float into an array of bools
   /// </summary>
   /// <param name="bits">the long to convert</param>
   /// <returns>the array. LSB at index 0</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool[] ToBooleanArray(this float bits)
   {
      return new BitIndexerUInt32 { Bits = bits.BitwiseToUInt32() }.Slice(0, BitIndexerUInt64.BitSize);
   }

   /// <summary>
   /// Convert a long into an array of bools
   /// </summary>
   /// <param name="bits">the long to convert</param>
   /// <returns>the array. LSB at index 0</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool[] ToBooleanArray(this double bits)
   {
      return new BitIndexerUInt64 { Bits = bits.BitwiseToUInt64() }.Slice(0, BitIndexerUInt64.BitSize);
   }

   /// <summary>
   /// Converts an array of bools into a <see cref="byte"/>, discarding any excess bits.
   /// </summary>
   /// <param name="bits">the array of bools to convert, Least Significant Bit at index 0</param>
   /// <returns>The converted <see cref="byte"/></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ToByte(this bool[] bits)
   {
      byte result = 0;
      for (var i = 0; i < bits.Length && i < 8; i++)
         result = result.StoreBit(bits[i], i);

      return result;
   }

   /// <summary>
   /// Converts an array of bools into an <see cref="sbyte"/>, discarding any excess bits.
   /// </summary>
   /// <param name="bits">the array of bools to convert, Least Significant Bit at index 0</param>
   /// <returns>The converted <see cref="sbyte"/></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ToSByte(this bool[] bits)
   {
      sbyte result = 0;
      for (var i = 0; i < bits.Length && i < 8; i++)
         result = result.StoreBit(bits[i], i);

      return result;
   }

   /// <summary>
   /// Converts an array of bools into a <see cref="ushort"/>, discarding any excess bits.
   /// </summary>
   /// <param name="bits">the array of bools to convert, Least Significant Bit at index 0</param>
   /// <returns>The converted <see cref="ushort"/></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort ToUInt16(this bool[] bits)
   {
      ushort result = 0;
      for (var i = 0; i < bits.Length && i < 16; i++)
         result = result.StoreBit(bits[i], i);

      return result;
   }

   /// <summary>
   /// Converts an array of bools into a <see cref="short"/>, discarding any excess bits.
   /// </summary>
   /// <param name="bits">the array of bools to convert, Least Significant Bit at index 0</param>
   /// <returns>The converted <see cref="short"/></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short ToInt16(this bool[] bits)
   {
      short result = 0;
      for (var i = 0; i < bits.Length && i < 16; i++)
         result = result.StoreBit(bits[i], i);

      return result;
   }

   /// <summary>
   /// Converts an array of bools into a <see cref="uint"/>, discarding any excess bits.
   /// </summary>
   /// <param name="bits">the array of bools to convert, Least Significant Bit at index 0</param>
   /// <returns>The converted <see cref="uint"/></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ToUInt32(this bool[] bits)
   {
      uint result = 0;
      for (var i = 0; i < bits.Length && i < 32; i++)
         result = result.StoreBit(bits[i], i);

      return result;
   }

   /// <summary>
   /// Converts an array of bools into an <see cref="int"/>, discarding any excess bits.
   /// </summary>
   /// <param name="bits">the array of bools to convert, Least Significant Bit at index 0</param>
   /// <returns>The converted <see cref="int"/></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int ToInt32(this bool[] bits)
   {
      var result = 0;
      for (var i = 0; i < bits.Length && i < 32; i++)
         result = result.StoreBit(bits[i], i);

      return result;
   }

   /// <summary>
   /// Converts an array of bools into a <see cref="ulong"/>, discarding any excess bits.
   /// </summary>
   /// <param name="bits">the array of bools to convert, Least Significant Bit at index 0</param>
   /// <returns>The converted <see cref="ulong"/></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong ToUInt64(this bool[] bits)
   {
      ulong result = 0;
      for (var i = 0; i < bits.Length && i < 64; i++)
         result = result.StoreBit(bits[i], i);

      return result;
   }

   /// <summary>
   /// Converts an array of bools into a <see cref="long"/>, discarding any excess bits.
   /// </summary>
   /// <param name="bits">the array of bools to convert, Least Significant Bit at index 0</param>
   /// <returns>The converted <see cref="long"/></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ToInt64(this bool[] bits)
   {
      long result = 0;
      for (var i = 0; i < bits.Length && i < 64; i++)
         result = result.StoreBit(bits[i], i);

      return result;
   }

   /// <summary>
   /// Converts an array of bools into a double, discarding any excess bits.
   /// </summary>
   /// <param name="bits">the array of bools to convert, LSB at index 0</param>
   /// <returns>The converted double</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static double ToDouble(this bool[] bits)
   {
      ulong result = 0;
      for (var i = 0; i < bits.Length && i < 64; i++)
         result = result.StoreBit(bits[i], i);

      return result.BitwiseToDouble();
   }

   /// <summary>
   /// Converts an array of bools into a float, discarding any excess bits.
   /// </summary>
   /// <param name="bits">the array of bools to convert, LSB at index 0</param>
   /// <returns>The converted float</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float ToSingle(this bool[] bits)
   {
      uint result = 0;
      for (var i = 0; i < bits.Length && i < 32; i++)
         result = result.StoreBit(bits[i], i);

      return result.BitwiseToSingle();
   }
}
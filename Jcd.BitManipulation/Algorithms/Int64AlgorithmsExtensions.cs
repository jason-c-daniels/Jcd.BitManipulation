#region

using System.Runtime.CompilerServices;

#endregion

namespace Jcd.BitManipulation.Algorithms;

/// <summary>
/// Provides bit counting and other niche bit manipulation facilities
/// for <see cref="long" /> instances.
/// </summary>
public static class Int64AlgorithmsExtensions
{
   private const int BitSize = BitSizeConstants.BitsPerUInt64;

   private static readonly BitMask LowestBit = 0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000001;
   private static readonly BitMask HighestBit = 0b10000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000;

   /// <summary>
   /// Determines if the number is a power of two.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   /// <returns>true if number == 2^n; where n is an integer.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsPowerOfTwo(this long number)
   {
      return number > 0 && ((ulong) number).IsPowerOfTwo();
   }

   /// <summary>
   /// Counts the bits that are set to 1 in a number.
   /// </summary>
   /// <param name="number">The number</param>
   /// <returns>The count of the bits set to 1</returns>
   /// <remarks>This is a reader-friendly alias for <see cref="PopCount" /></remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int CountBitsSet(this long number)
   {
      return number.PopCount();
   }

   /// <summary>
   /// Determines if the only lowest bit and one other higher bit are set.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   /// <returns>true if the bitwise representation follows this pattern: 0b10..01. with any number of intervening zeros.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreOnlyFirstAndLastBitsSet(this long number)
   {
      return ((ulong) number).AreOnlyFirstAndLastBitsSet();
   }

   /// <summary>
   /// For any given number return the number if it's a power of two,
   /// or return the next higher power of two capable of fitting in the
   /// data type.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long GetValueOrNextHigherPowerOfTwo(this long number)
   {
      if (number < 0)
      {
         return 0;
      }

      return (long) ((ulong) number).GetValueOrNextHigherPowerOfTwo();
   }

   /// <summary>
   /// Calculate the index of the highest bit that's been set.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   /// <returns>The index of the highest bit that's been set; or -1 if none were set.</returns>
   /// [MethodImpl(MethodImplOptions.AggressiveInlining)]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int GetHighestBitSet(this long number)
   {
      if (number < 0)
      {
         return BitSize - 1;
      }

      return ((ulong) number).GetHighestBitSet();
   }

   /// <summary>
   /// Calculate the index of the lowest bit that's been set.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   /// <returns>The index of the lowest bit that's been set; or -1 if none were set.</returns>
   /// [MethodImpl(MethodImplOptions.AggressiveInlining)]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int GetLowestBitSet(this long number)
   {
      return ((ulong) number).GetLowestBitSet();
   }

   /// <summary>
   /// Computes the number of sequentially zeroed bits occupying the
   /// most significant bit positions.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   /// <returns>The count of sequentially zeroed bits occupying the most significant bit positions.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int CountLeadingZeros(this long number)
   {
      var uln = (ulong) number;

      return number < 0
                ? 0
                : uln.CountLeadingZeros();
   }

   /// <summary>
   /// Computes the number of sequentially zeroed bits occupying the
   /// least significant bit positions.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   /// <returns>The count of sequentially zeroed bits occupying the least significant bit positions.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int CountTrailingZeros(this long number)
   {
      return ((ulong) number).CountTrailingZeros();
   }

   /// <summary>
   /// Performs a bitwise left rotation on a number.
   /// </summary>
   /// <param name="number">The number to rotate</param>
   /// <param name="count">the number of bits to rotate</param>
   /// <returns>The rotated value.</returns>
   /// <example>
   /// Examples
   /// <code>
   /// long b = 0b00001111;
   /// var b2 = b.RotateLeft(3); // b2 = 0b01111000
   /// var b3 = b.RotateLeft(4); // b3 = 0b11110000
   /// var b4 = b.RotateLeft(5); // b4 = 0b11100001
   /// var b5 = b.RotateLeft(6); // b5 = 0b11000011
   /// var b6 = b.RotateLeft(7); // b6 = 0b10000111
   /// var b7 = b.RotateLeft(8); // b7 = 0b00001111
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long RotateLeft(this long number, int count)
   {
      return (long) ((ulong) number).RotateLeft(count);
   }

   /// <summary>
   /// Performs a bitwise right rotation on a number.
   /// </summary>
   /// <param name="number">The number to rotate</param>
   /// <param name="count">the number of bits to rotate</param>
   /// <returns>The rotated value.</returns>
   /// <example>
   /// Examples
   /// <code>
   /// long b = 0b11110000;
   /// var b2 = b.RotateRight(3); // b2 = 0b00011110
   /// var b3 = b.RotateRight(4); // b3 = 0b00001111
   /// var b4 = b.RotateRight(5); // b4 = 0b10000111
   /// var b5 = b.RotateRight(6); // b5 = 0b11000011
   /// var b6 = b.RotateRight(7); // b6 = 0b11100001
   /// var b7 = b.RotateRight(8); // b7 = 0b11110000
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long RotateRight(this long number, int count)
   {
      return (long) ((ulong) number).RotateRight(count);
   }

   /// <summary>
   /// Counts the bits that are set to 1 in a number
   /// </summary>
   /// <param name="number">The number</param>
   /// <returns>The count of the bits set to 1</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int PopCount(this long number)
   {
      return ((ulong) number).PopCount();
   }

   /// <summary>
   /// Determines if the number is odd.
   /// </summary>
   /// <param name="number"></param>
   /// <returns><c>true</c> if the number is odd (e.g. 1,3...etc.)</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsOdd(this long number)
   {
      return (number & LowestBit) != 0;
   }

   /// <summary>
   /// Determines if the number is odd.
   /// </summary>
   /// <param name="number"></param>
   /// <returns><c>true</c> if the number is even (e.g. 2,4...etc.)</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsEven(this long number)
   {
      return (number & LowestBit) == 0;
   }

   /// <summary>
   /// Indicates if the number is negative. (Always false for unsigned numbers)
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>true if &lt; 0.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsNegative(this long number)
   {
      return (number & HighestBit) != 0;
   }

   /// <summary>
   /// Indicates if the number is zero or positive. (Always true for unsigned numbers)
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>true if &gt;= 0.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsPositive(this long number)
   {
      return (number & HighestBit) == 0;
   }
}
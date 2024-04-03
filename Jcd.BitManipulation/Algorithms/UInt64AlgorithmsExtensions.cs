#region

using System.Runtime.CompilerServices;

#endregion

namespace Jcd.BitManipulation.Algorithms;

/// <summary>
/// Provides bit counting and other niche bit manipulation facilities
/// for <see cref="ulong" /> instances.
/// </summary>
public static class UInt64AlgorithmsExtensions
{
   private const int BitSize = BitSizeConstants.BitsPerUInt64;

   private static readonly BitMask LowestBit = 0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000001;
   private static readonly BitMask Lower2Bits = 0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000011;
   private static readonly BitMask Lower4Bits = 0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00001111;
   private static readonly BitMask Lower8Bits = 0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_11111111;
   private static readonly BitMask Lower16Bits = 0b00000000_00000000_00000000_00000000_00000000_00000000_11111111_11111111;
   private static readonly BitMask Lower32Bits = 0b00000000_00000000_00000000_00000000_11111111_11111111_11111111_11111111;
   private static readonly BitMask Upper32Bits = 0b11111111_11111111_11111111_11111111_00000000_00000000_00000000_00000000;
   private static readonly BitMask Upper16Bits = 0b11111111_11111111_00000000_00000000_00000000_00000000_00000000_00000000;
   private static readonly BitMask Upper8Bits = 0b11111111_00000000_00000000_00000000_00000000_00000000_00000000_00000000;
   private static readonly BitMask Upper4Bits = 0b11110000_00000000_00000000_00000000_00000000_00000000_00000000_00000000;
   private static readonly BitMask Upper2Bits = 0b11000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000;
   private static readonly BitMask HighestBit = 0b10000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000;

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private static ulong BitwiseAndWithSelfMinusOne(this ulong number)
   {
      return number & (number - 1);
   }

   /// <summary>
   /// Determines if the number is a power of two.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   /// <returns>true if number == 2^n; where n is an integer.</returns>
   /// [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsPowerOfTwo(this ulong number)
   {
      return number != 0 && number.BitwiseAndWithSelfMinusOne() == 0;
   }

   /// <summary>
   /// Counts the "set" bits on the number.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>The count of the "set" bits.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int CountBitsSet(this ulong number)
   {
      if (number == 0)
      {
         return 0;
      }

      var count = 0;

      while (number != 0)
      {
         number = number.BitwiseAndWithSelfMinusOne();
         count++;
      }

      return count;
   }

   /// <summary>
   /// Determines if the only lowest bit and one other higher bit are set.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   /// <returns>true if the bitwise representation follows this pattern: 0b10..01. with any number of intervening zeros.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreOnlyFirstAndLastBitsSet(this ulong number)
   {
      if (number == 1)
      {
         return true;
      }

      return (number & 1) == 1 && (number - 1).IsPowerOfTwo();
   }

   /// <summary>
   /// For any given number return the number if it's a power of two,
   /// or return the next higher power of two capable of fitting in the
   /// data type.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong GetValueOrNextHigherPowerOfTwo(this ulong number)
   {
      if (number == 0)
      {
         return 1;
      }

      if (number.IsPowerOfTwo())
      {
         return number;
      }

      var highestBitSet = number.GetHighestBitSet();

      return (1ul << (highestBitSet + 1));
   }

   /// <summary>
   /// Calculate the index of the highest bit that's been set.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   /// <returns>The index of the highest bit that's been set.</returns>
   /// [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int GetHighestBitSet(this ulong number)
   {
      if (number == 0)
      {
         return -1;
      }

      return BitSize - number.CountLeadingZeros() - 1;
   }

   /// <summary>
   /// Calculate the index of the lowest bit that's been set.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   /// <returns>The index of the lowest bit that's been set.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int GetLowestBitSet(this ulong number)
   {
      if (number == 0)
      {
         return -1;
      }

      return number.CountTrailingZeros();
   }

   /// <summary>
   /// Computes the number of sequentially zeroed bits occupying the
   /// most significant bit positions.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   /// <returns>The count of sequentially zeroed bits occupying the most significant bit positions.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int CountLeadingZeros(this ulong number)
   {
      if (number == 0)
      {
         return BitSize;
      }

      var count = 0;

      if (number.AreNoBitsSet(Upper32Bits))
      {
         count += 32;
         number <<= 32;
      }

      if (number.AreNoBitsSet(Upper16Bits))
      {
         count += 16;
         number <<= 16;
      }

      if (number.AreNoBitsSet(Upper8Bits))
      {
         count += 8;
         number <<= 8;
      }

      if (number.AreNoBitsSet(Upper4Bits))
      {
         count += 4;
         number <<= 4;
      }

      if (number.AreNoBitsSet(Upper2Bits))
      {
         count += 2;
         number <<= 2;
      }

      if (number.AreNoBitsSet(HighestBit))
      {
         count += 1;
      }

      return count;
   }

   /// <summary>
   /// Computes the number of sequentially zeroed bits occupying the
   /// least significant bit positions.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   /// <returns>The count of sequentially zeroed bits occupying the least significant bit positions.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int CountTrailingZeros(this ulong number)
   {
      if (number == 0)
      {
         return BitSize;
      }

      var count = 0;

      if ((number & Lower32Bits) == 0)
      {
         count += 32;
         number >>= 32;
      }

      if (number.AreNoBitsSet(Lower16Bits))
      {
         count += 16;
         number >>= 16;
      }

      if (number.AreNoBitsSet(Lower8Bits))
      {
         count += 8;
         number >>= 8;
      }

      if (number.AreNoBitsSet(Lower4Bits))
      {
         count += 4;
         number >>= 4;
      }

      if (number.AreNoBitsSet(Lower2Bits))
      {
         count += 2;
         number >>= 2;
      }

      if (number.AreNoBitsSet(LowestBit))
      {
         count += 1;
      }

      return count;
   }
}
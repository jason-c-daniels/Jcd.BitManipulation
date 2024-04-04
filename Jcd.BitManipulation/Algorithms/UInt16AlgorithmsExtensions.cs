﻿#region

using System.Runtime.CompilerServices;

#endregion

namespace Jcd.BitManipulation.Algorithms;

/// <summary>
/// Provides bit counting and other niche bit manipulation facilities
/// for <see cref="ushort" /> instances.
/// </summary>
public static class UInt16AlgorithmsExtensions
{
   private const int BitSize = BitSizeConstants.BitsPerUInt16;
   private const int BitSizeMinusOne = BitSize - 1;

   private static readonly BitMask LowestBit = 0b00000000_00000001;
   private static readonly BitMask Lower2Bits = 0b00000000_00000011;
   private static readonly BitMask Lower4Bits = 0b00000000_00001111;
   private static readonly BitMask Lower8Bits = 0b00000000_11111111;
   private static readonly BitMask Upper8Bits = 0b11111111_00000000;
   private static readonly BitMask Upper4Bits = 0b11110000_00000000;
   private static readonly BitMask Upper2Bits = 0b11000000_00000000;
   private static readonly BitMask HighestBit = 0b10000000_00000000;

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private static ushort BitwiseAndWithSelfMinusOne(this ushort number)
   {
      return (ushort) (number & (number - 1));
   }

   /// <summary>
   /// Determines if the number is a power of two.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   /// <returns>true if number == 2^n; where n is an integer.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsPowerOfTwo(this ushort number)
   {
      return number != 0 && number.BitwiseAndWithSelfMinusOne() == 0;
   }

   /// <summary>
   /// Counts the bits that are set to 1 in a number.
   /// </summary>
   /// <param name="number">The number</param>
   /// <returns>The count of the bits set to 1</returns>
   /// <remarks>This is a reader-friendly alias for <see cref="PopCount" /></remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int CountBitsSet(this ushort number)
   {
      return number.PopCount();
   }

   /// <summary>
   /// Determines if the only lowest bit and one other higher bit are set.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   /// <returns>true if the bitwise representation follows this pattern: 0b10..01. with any number of intervening zeros.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreOnlyFirstAndLastBitsSet(this ushort number)
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
   public static ushort GetValueOrNextHigherPowerOfTwo(this ushort number)
   {
      if (number == 0)
      {
         return 1;
      }

      if (number.IsPowerOfTwo())
      {
         return number;
      }

      return (ushort) (1 << (number.GetHighestBitSet() + 1));
   }

   /// <summary>
   /// Calculate the index of the highest bit that's been set.
   /// </summary>
   /// <param name="number">the number to evaluate</param>
   /// <returns>The index of the highest bit that's been set; or -1 if none were set.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int GetHighestBitSet(this ushort number)
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
   /// <returns>The index of the lowest bit that's been set; or -1 if none were set.</returns>
   /// [MethodImpl(MethodImplOptions.AggressiveInlining)]
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int GetLowestBitSet(this ushort number)
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
   public static int CountLeadingZeros(this ushort number)
   {
      if (number == 0)
      {
         return BitSize;
      }

      var count = 0;

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
   public static int CountTrailingZeros(this ushort number)
   {
      if (number == 0)
      {
         return BitSize;
      }

      var count = 0;

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

   /// <summary>
   /// Performs a bitwise left rotation on a number.
   /// </summary>
   /// <param name="number">The number to rotate</param>
   /// <param name="count">the number of bits to rotate</param>
   /// <returns>The rotated value.</returns>
   /// <example>
   /// Examples
   /// <code>
   /// ushort b = 0b00001111;
   /// var b2 = b.RotateLeft(3); // b2 = 0b01111000
   /// var b3 = b.RotateLeft(4); // b3 = 0b11110000
   /// var b4 = b.RotateLeft(5); // b4 = 0b11100001
   /// var b5 = b.RotateLeft(6); // b5 = 0b11000011
   /// var b6 = b.RotateLeft(7); // b6 = 0b10000111
   /// var b7 = b.RotateLeft(8); // b7 = 0b00001111
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort RotateLeft(this ushort number, int count)
   {
      return (ushort) ((ushort) (number << (count & BitSizeMinusOne)) | (ushort) (number >> (BitSize - (count & BitSizeMinusOne))));
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
   /// ushort b = 0b11110000;
   /// var b2 = b.RotateRight(3); // b2 = 0b00011110
   /// var b3 = b.RotateRight(4); // b3 = 0b00001111
   /// var b4 = b.RotateRight(5); // b4 = 0b10000111
   /// var b5 = b.RotateRight(6); // b5 = 0b11000011
   /// var b6 = b.RotateRight(7); // b6 = 0b11100001
   /// var b7 = b.RotateRight(8); // b7 = 0b11110000
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort RotateRight(this ushort number, int count)
   {
      return (ushort) ((ushort) (number >> (count & BitSizeMinusOne)) | (ushort) (number << (BitSize - (count & BitSizeMinusOne))));
   }

   /// <summary>
   /// Counts the bits that are set to 1 in a number
   /// </summary>
   /// <param name="number">The number</param>
   /// <returns>The count of the bits set to 1</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int PopCount(this ushort number)
   {
      // algorithm adapted from: https://graphics.stanford.edu/%7Eseander/bithacks.html#CountBitsSetParallel
      // constants renamed based on descriptions provided in: https://stackoverflow.com/questions/109023/count-the-number-of-set-bits-in-a-32-bit-integer
      const int bitsPerByte = BitSizeConstants.BitsPerByte;
      const ushort maxValue = ushort.MaxValue;
      const ushort pairs = maxValue                 / 3;
      const ushort quads = maxValue  / 15           * 3;
      const ushort eights = maxValue / 255          * 15;
      const ushort horizontalSum = maxValue         / 255;
      const int topByteShift = (sizeof(ushort) - 1) * bitsPerByte;

      number -= (ushort) ((ushort) (number >> 1) & pairs);
      number = (ushort) ((ushort) (number & quads) + (ushort) ((ushort) (number >> 2) & quads));
      number = (ushort) ((ushort) (number + (ushort) (number                    >> 4)) & eights);

      return (ushort) (number * horizontalSum) >> topByteShift;
   }

   /// <summary>
   /// Determines if the number is odd.
   /// </summary>
   /// <param name="number"></param>
   /// <returns><c>true</c> if the number is odd (e.g. 1,3...etc.)</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsOdd(this ushort number)
   {
      return (number & 1) == 1;
   }

   /// <summary>
   /// Determines if the number is odd.
   /// </summary>
   /// <param name="number"></param>
   /// <returns><c>true</c> if the number is even (e.g. 2,4...etc.)</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsEven(this ushort number)
   {
      return (number & 1) == 0;
   }

   /// <summary>
   /// Indicates if the number is negative. (Always false for unsigned numbers)
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>true if &lt; 0.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsNegative(this ushort number)
   {
      return false;
   }

   /// <summary>
   /// Indicates if the number is zero or positive. (Always true for unsigned numbers)
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>true if &gt;= 0.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsPositive(this ushort number)
   {
      return true;
   }
}
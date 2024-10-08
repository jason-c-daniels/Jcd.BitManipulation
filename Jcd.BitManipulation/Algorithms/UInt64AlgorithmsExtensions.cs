﻿#region

using System.Runtime.CompilerServices;

#endregion

namespace Jcd.BitManipulation.Algorithms;

/// <summary>
/// Provides bit counting and other niche bit manipulation facilities
/// for <see cref="ulong" /> values.
/// </summary>
public static class UInt64AlgorithmsExtensions
{
   private const int BitSize = BitSizeConstants.BitsPerUInt64;
   private const int BitSizeMinusOne = BitSize - 1;

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
   /// <param name="number">The number to evaluate.</param>
   /// <returns>true if number == 2^n; where n is an integer.</returns>
   /// <example>
   /// <code>
   /// ulong v = 1;
   /// if (v.IsPowerOfTwo()) Console.WriteLine($"{v} is a power of two!"); // outputs: 1 is a power of two!
   ///
   /// v = 2;
   /// if (v.IsPowerOfTwo()) Console.WriteLine($"{v} is a power of two!"); // outputs: 2 is a power of two!
   ///
   /// v = 3;
   /// if (v.IsPowerOfTwo()) Console.WriteLine($"{v} is a power of two!"); // does not output anything.
   ///
   /// v = 4;
   /// if (v.IsPowerOfTwo()) Console.WriteLine($"{v} is a power of two!"); // outputs: 4 is a power of two!
   ///
   /// </code>
   /// </example>
   /// [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsPowerOfTwo(this ulong number)
   {
      return number != 0 && number.BitwiseAndWithSelfMinusOne() == 0;
   }

   /// <summary>
   /// Counts the bits that are set to 1 in a number.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>The count of the bits set to 1.</returns>
   /// <remarks>This is a reader-friendly alias for <see cref="PopCount" />.</remarks>
   /// <example>
   /// <code>
   /// var v = ulong.MaxValue;
   /// Console.WriteLine($"{v.CountBitsSet()} bits are set."); // outputs: 64 bits are set.
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int CountBitsSet(this ulong number)
   {
      return number.PopCount();
   }

   /// <summary>
   /// Determines if only the lowest bit and one other higher bit are set.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>true if the bitwise representation follows this pattern: 0b10..01. with any number of intervening zeros.</returns>
   /// <example>
   /// <code>
   /// ulong v = 0b0001;
   /// Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True
   ///
   /// v = 0b0011;
   /// Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True
   ///
   /// v = 0b0101;
   /// Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True
   ///
   /// v = 0b0111;
   /// Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: False
   /// </code>
   /// </example>
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
   /// <param name="number">The number to evaluate.</param>
   /// <example>
   /// <code>
   /// ulong v = 2;
   /// Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 2
   ///
   /// v = 3;
   /// Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 4
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong RoundUpToPowerOfTwo(this ulong number)
   {
      // adapted from https://graphics.stanford.edu/~seander/bithacks.html#RoundUpPowerOf2
      number--;
      number |= number >> 1;
      number |= number >> 2;
      number |= number >> 4;
      number |= number >> 8;
      number |= number >> 16;
      number |= number >> 32;
      number++;
      number += number == 0
                   ? 1ul
                   : 0;

      return number;
   }

   /// <summary>
   /// Calculate the index of the highest bit that's been set.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>The index of the highest bit that's been set; or -1 if none were set.</returns>
   /// <example>
   /// <code>
   /// ulong v = 1;
   /// Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 0
   ///
   /// v = 2;
   /// Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 1
   ///
   /// v = 3;
   /// Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 1
   ///
   /// v = 4;
   /// Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 2
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
   /// <param name="number">The number to evaluate.</param>
   /// <returns>The index of the lowest bit that's been set; or -1 if none were set.</returns>
   /// <example>
   /// <code>
   /// ulong v = 1;
   /// Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 0
   ///
   /// v = 2;
   /// Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 1
   ///
   /// v = 3;
   /// Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 1
   ///
   /// v = 4;
   /// Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 2
   /// </code>
   /// </example>
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
   /// <param name="number">The number to evaluate.</param>
   /// <returns>The count of sequentially zeroed bits occupying the most significant bit positions.</returns>
   /// <example>
   /// <code>
   /// ulong v = 0x7FFFFFFF_FFFFFFFF;
   /// Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 1
   ///
   /// v = 0x3FFFFFFF_FFFFFFFF;
   /// Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 2
   ///
   /// v = 1;
   /// Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 63
   /// </code>
   /// </example>
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
   /// <param name="number">The number to evaluate.</param>
   /// <returns>The count of sequentially zeroed bits occupying the least significant bit positions.</returns>
   /// <example>
   /// <code>
   /// ulong v = 1;
   /// Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 0
   ///
   /// v = 2;
   /// Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 1
   ///
   /// v = 3;
   /// Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 1
   ///
   /// v = 4;
   /// Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 2
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int CountTrailingZeros(this ulong number)
   {
      if (number.IsOdd())
      {
         return 0;
      }

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

   /// <summary>
   /// Performs a bitwise left rotation on a number.
   /// </summary>
   /// <param name="number">The number to rotate</param>
   /// <param name="count">the number of bits to rotate</param>
   /// <returns>The rotated value.</returns>
   /// <example>
   /// <code>
   /// var rotationBase = sizeof(int)-5;
   ///
   /// ulong b = 0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00001111;
   ///
   /// var b2 = b.RotateLeft(rotationBase+0); // b2 = 0b01111000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
   /// var b3 = b.RotateLeft(rotationBase+1); // b3 = 0b11110000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
   /// var b4 = b.RotateLeft(rotationBase+2); // b4 = 0b11100000_00000000_00000000_00000000_00000000_00000000_00000000_00000001
   /// var b5 = b.RotateLeft(rotationBase+3); // b5 = 0b11000000_00000000_00000000_00000000_00000000_00000000_00000000_00000011
   /// var b6 = b.RotateLeft(rotationBase+4); // b6 = 0b10000000_00000000_00000000_00000000_00000000_00000000_00000000_00000111
   /// var b7 = b.RotateLeft(rotationBase+5); // b7 = 0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00001111
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong RotateLeft(this ulong number, int count)
   {
      return (number << (count & BitSizeMinusOne)) | (number >> (BitSize - (count & BitSizeMinusOne)));
   }

   /// <summary>
   /// Performs a bitwise right rotation on a number.
   /// </summary>
   /// <param name="number">The number to rotate</param>
   /// <param name="count">the number of bits to rotate</param>
   /// <returns>The rotated value.</returns>
   /// <example>
   /// <code>
   /// var rotationBase = sizeof(int)-5;
   ///
   /// ulong b = 0b11110000_00000000_00000000_00000000_00000000_00000000_00000000_00000000;
   ///
   /// var b2 = b.RotateRight(rotationBase+0); // b2 = 0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00011110
   /// var b3 = b.RotateRight(rotationBase+1); // b3 = 0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00001111
   /// var b4 = b.RotateRight(rotationBase+2); // b4 = 0b10000000_00000000_00000000_00000000_00000000_00000000_00000000_00000111
   /// var b5 = b.RotateRight(rotationBase+3); // b5 = 0b11000000_00000000_00000000_00000000_00000000_00000000_00000000_00000011
   /// var b6 = b.RotateRight(rotationBase+4); // b6 = 0b11100000_00000000_00000000_00000000_00000000_00000000_00000000_00000001
   /// var b7 = b.RotateRight(rotationBase+5); // b7 = 0b11110000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong RotateRight(this ulong number, int count)
   {
      return (number >> (count & BitSizeMinusOne)) | (number << (BitSize - (count & BitSizeMinusOne)));
   }

   /// <summary>
   /// Counts the bits that are set to 1 in a number.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>The count of the bits set to 1.</returns>
   /// <remarks>This is an alias for <see cref="CountBitsSet" />.</remarks>
   /// <example>
   /// <code>
   /// var v = ulong.MaxValue;
   /// Console.WriteLine($"{v.PopCount()} bits are set."); // outputs: 64 bits are set.
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int PopCount(this ulong number)
   {
      // algorithm adapted from: https://graphics.stanford.edu/%7Eseander/bithacks.html#CountBitsSetParallel
      // constants renamed based on descriptions provided in: https://stackoverflow.com/questions/109023/count-the-number-of-set-bits-in-a-32-bit-integer
      const int bitsPerByte = BitSizeConstants.BitsPerByte;
      const ulong maxValue = ulong.MaxValue;
      const ulong pairs = maxValue                 / 3;
      const ulong quads = maxValue  / 15           * 3;
      const ulong eights = maxValue / 255          * 15;
      const ulong horizontalSum = maxValue         / 255;
      const int topByteShift = (sizeof(ulong) - 1) * bitsPerByte;

      number -= (number >> 1) & pairs;
      number = (number & quads) + ((number >> 2) & quads);
      number = (number + (number           >> 4)) & eights;

      return (int) ((number * horizontalSum) >> topByteShift);
   }

   /// <summary>
   /// Determines if the number is odd.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns><c>true</c> if the number is odd (e.g. 1,3...etc.)</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsOdd(this ulong number)
   {
      return (number & 1) == 1;
   }

   /// <summary>
   /// Determines if the number is odd.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns><c>true</c> if the number is even (e.g. 2,4...etc.)</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsEven(this ulong number)
   {
      return (number & 1) == 0;
   }

   /// <summary>
   /// Indicates if the number is negative. (Always false for unsigned numbers)
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>true if &lt; 0.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsNegative(this ulong number)
   {
      return false;
   }

   /// <summary>
   /// Indicates if the number is zero or positive. (Always true for unsigned numbers)
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>true if &gt;= 0.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsPositive(this ulong number)
   {
      return true;
   }

   /// <summary>
   /// Returns a value indicating the sign of the number.
   /// </summary>
   /// <param name="number">The number to evaluate</param>
   /// <returns>1 if &gt; 0; 0 otherwise.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int GetSign(this ulong number)
   {
      return number == 0
                ? 0
                : 1;
   }

   /// <summary>
   /// Returns a value where the bits of the output are in the reverse order from their inputs.
   /// For example: 1010000010101111 becomes 1111010100000101
   /// </summary>
   /// <param name="number">The number to evaluate</param>
   /// <returns>The bits in reverse order.</returns>
   /// <remarks>
   /// Algorithm taken from: https://graphics.stanford.edu/~seander/bithacks.html#ReverseParallel
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong ReverseBits(this ulong number)
   {
      return
         ((ulong) ((byte) (number & 0xFF)).ReverseBits()) << 56
       | ((ulong) ((byte) ((number >> 8)  & 0xFF)).ReverseBits()) << 48
       | ((ulong) ((byte) ((number >> 16) & 0xFF)).ReverseBits()) << 40
       | ((ulong) ((byte) ((number >> 24) & 0xFF)).ReverseBits()) << 32
       | ((ulong) ((byte) ((number >> 32) & 0xFF)).ReverseBits()) << 24
       | ((ulong) ((byte) ((number >> 40) & 0xFF)).ReverseBits()) << 16
       | ((ulong) ((byte) ((number >> 48) & 0xFF)).ReverseBits()) << 8
       | ((ulong) ((byte) ((number >> 56) & 0xFF)).ReverseBits());
   }
}
#region

using System.Runtime.CompilerServices;

#pragma warning disable S3358

#endregion

namespace Jcd.BitManipulation.Algorithms;

/// <summary>
/// Provides bit counting and other niche bit manipulation facilities
/// for <see cref="int" /> values.
/// </summary>
public static class Int32AlgorithmsExtensions
{
   private const int BitSize = BitSizeConstants.BitsPerUInt32;

   private static readonly BitMask LowestBit = 0b00000000_00000000_00000000_00000001;
   private static readonly BitMask HighestBit = 0b10000000_00000000_00000000_00000000;

   /// <summary>
   /// Determines if the number is a power of two.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>true if number == 2^n; where n is an integer.</returns>
   /// <example>
   /// <code>
   /// int v = 1;
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
   public static bool IsPowerOfTwo(this int number)
   {
      return number > 0 && ((uint) number).IsPowerOfTwo();
   }

   /// <summary>
   /// Counts the bits that are set to 1 in a number.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>The count of the bits set to 1.</returns>
   /// <remarks>This is a reader-friendly alias for <see cref="PopCount" />.</remarks>
   /// <example>
   /// <code>
   /// var v = int.MaxValue;
   /// Console.WriteLine($"{v.CountBitsSet()} bits are set."); // outputs: 31 bits are set.
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int CountBitsSet(this int number)
   {
      return number.PopCount();
   }

   /// <summary>
   /// Determines if the only lowest bit and one other higher bit are set.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>true if the bitwise representation follows this pattern: 0b10..01. with any number of intervening zeros.</returns>
   /// <example>
   /// <code>
   /// int v = 0b0001;
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
   public static bool AreOnlyFirstAndLastBitsSet(this int number)
   {
      return ((uint) number).AreOnlyFirstAndLastBitsSet();
   }

   /// <summary>
   /// For any given number return the number if it's a power of two,
   /// or return the next higher power of two capable of fitting in the
   /// data type. For negative values or values that would result in a
   /// negative next higher power of two, zero is returned. (e.g. number > 2^(k-2)
   /// where k is the bit size.)
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <example>
   /// <code>
   /// int v = 2;
   /// Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 2
   /// 
   /// v = 3;
   /// Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 4
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int RoundUpToPowerOfTwo(this int number)
   {
      if (number < 0)
      {
         return 0;
      }

      var r = (int) ((uint) number).RoundUpToPowerOfTwo();

      return r < 0
                ? 0
                : r;
   }

   /// <summary>
   /// Calculate the index of the highest bit that's been set.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>The index of the highest bit that's been set; or -1 if none were set.</returns>
   /// <example>
   /// <code>
   /// int v = 1;
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
   public static int GetHighestBitSet(this int number)
   {
      if (number < 0)
      {
         return BitSize - 1;
      }

      return ((uint) number).GetHighestBitSet();
   }

   /// <summary>
   /// Calculate the index of the lowest bit that's been set.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>The index of the lowest bit that's been set; or -1 if none were set.</returns>
   /// <example>
   /// <code>
   /// int v = 1;
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
   public static int GetLowestBitSet(this int number)
   {
      return ((uint) number).GetLowestBitSet();
   }

   /// <summary>
   /// Computes the number of sequentially zeroed bits occupying the
   /// most significant bit positions.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>The count of sequentially zeroed bits occupying the most significant bit positions.</returns>
   /// <example>
   /// <code>
   /// int v = 0x7FFFFFFF;
   /// Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 1
   ///       
   /// v = 0x3FFFFFFF;
   /// Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 2
   /// 
   /// v = 1;
   /// Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 31
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int CountLeadingZeros(this int number)
   {
      return number < 0
                ? 0
                : ((uint) number).CountLeadingZeros();
   }

   /// <summary>
   /// Computes the number of sequentially zeroed bits occupying the
   /// least significant bit positions.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>The count of sequentially zeroed bits occupying the least significant bit positions.</returns>
   /// <example>
   /// <code>
   /// int v = 1;
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
   public static int CountTrailingZeros(this int number)
   {
      return ((uint) number).CountTrailingZeros();
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
   /// int b = 0b00000000_00000000_00000000_00001111;
   /// 
   /// var b2 = b.RotateLeft(rotationBase+0); // b2 = 0b01111000_00000000_00000000_00000000
   /// var b3 = b.RotateLeft(rotationBase+1); // b3 = 0b11110000_00000000_00000000_00000000
   /// var b4 = b.RotateLeft(rotationBase+2); // b4 = 0b11100000_00000000_00000000_00000001
   /// var b5 = b.RotateLeft(rotationBase+3); // b5 = 0b11000000_00000000_00000000_00000011
   /// var b6 = b.RotateLeft(rotationBase+4); // b6 = 0b10000000_00000000_00000000_00000111
   /// var b7 = b.RotateLeft(rotationBase+5); // b7 = 0b00000000_00000000_00000000_00001111
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int RotateLeft(this int number, int count)
   {
      return (int) ((uint) number).RotateLeft(count);
   }

   /// <summary>
   /// Performs a bitwise right rotation on a number.
   /// </summary>
   /// <param name="number">The number to rotate</param>
   /// <param name="count">the number of bits to rotate</param>
   /// <returns>The rotated value.</returns>
   /// <example>
   /// <code>
   /// var rotationBase = sizeof(short)-5;
   /// 
   /// uint ub = 0b11110000_00000000_00000000_00000000;
   /// 
   /// int b = (int)ub;
   /// 
   /// var b2 = b.RotateRight(rotationBase+0); // b2 = 0b00000000_00000000_00000000_00011110
   /// var b3 = b.RotateRight(rotationBase+1); // b3 = 0b00000000_00000000_00000000_00001111
   /// var b4 = b.RotateRight(rotationBase+2); // b4 = 0b10000000_00000000_00000000_00000111
   /// var b5 = b.RotateRight(rotationBase+3); // b5 = 0b11000000_00000000_00000000_00000011
   /// var b6 = b.RotateRight(rotationBase+4); // b6 = 0b11100000_00000000_00000000_00000001
   /// var b7 = b.RotateRight(rotationBase+5); // b7 = 0b11110000_00000000_00000000_00000000
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int RotateRight(this int number, int count)
   {
      return (int) ((uint) number).RotateRight(count);
   }

   /// <summary>
   /// Counts the bits that are set to 1 in a number.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>The count of the bits set to 1.</returns>
   /// <remarks>This is an alias for <see cref="CountBitsSet" />.</remarks>
   /// <example>
   /// <code>
   /// var v = int.MaxValue;
   /// Console.WriteLine($"{v.PopCount()} bits are set."); // outputs: 31 bits are set.
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int PopCount(this int number)
   {
      return ((uint) number).PopCount();
   }

   /// <summary>
   /// Determines if the number is odd.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns><c>true</c> if the number is odd (e.g. 1,3...etc.)</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsOdd(this int number)
   {
      return (number & LowestBit) != 0;
   }

   /// <summary>
   /// Determines if the number is odd.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns><c>true</c> if the number is even (e.g. 2,4...etc.)</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsEven(this int number)
   {
      return (number & LowestBit) == 0;
   }

   /// <summary>
   /// Indicates if the number is negative.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>true if &lt; 0.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsNegative(this int number)
   {
      return (number & HighestBit) != 0;
   }

   /// <summary>
   /// Indicates if the number is zero or positive.
   /// </summary>
   /// <param name="number">The number to evaluate.</param>
   /// <returns>true if &gt;= 0.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool IsPositive(this int number)
   {
      return (number & HighestBit) == 0;
   }

   /// <summary>
   /// Returns a value indicating the sign of the number.
   /// </summary>
   /// <param name="number">The number to evaluate</param>
   /// <returns>-1 if &lt; 0; 1 if &gt; 0; 0 otherwise.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int GetSign(this int number)
   {
      return number == 0
                ? 0
                : number > 0
                   ? 1
                   : -1;
   }
}
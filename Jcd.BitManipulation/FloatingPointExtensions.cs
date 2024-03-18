using System;

namespace Jcd.BitManipulation;

/// <summary>
/// Methods to convert to and from like sized integers and floating point numbers.
/// </summary>
public static class FloatingPointExtensions
{
   /// <summary>
   /// Converts a <see cref="float"/> to the bit-wise identical <see cref="uint"/>
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>the <see cref="uint"/> representation of the underlying bits</returns>
   public static uint BitwiseToUInt32(this float value) { return (uint) value.BitwiseToInt32(); }

   /// <summary>
   /// Converts a <see cref="float"/> to the bit-wise identical <see cref="int"/>
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>the <see cref="int"/> representation of the underlying bits</returns>
   public static int BitwiseToInt32(this float value) { return BitConverter.ToInt32(BitConverter.GetBytes(value), 0); }

   /// <summary>
   /// Converts a <see cref="uint"/> to the bit-wise identical <see cref="float"/>
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>the <see cref="float"/> representation of the bits</returns>
   public static float BitwiseToSingle(this uint value) { return ((int) value).BitwiseToSingle(); }

   /// <summary>
   /// Converts a <see cref="int"/> to the bit-wise identical <see cref="float"/>
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>the <see cref="float"/> representation of the bits</returns>
   public static float BitwiseToSingle(this int value)
   {
      return BitConverter.ToSingle(BitConverter.GetBytes(value), 0);
   }

   /// <summary>
   /// Converts a <see cref="double"/> to the bit-wise identical <see cref="ulong"/>
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>the <see cref="ulong"/> representation of the underlying bits</returns>
   public static ulong BitwiseToUInt64(this double value) { return (ulong) value.BitwiseToInt64(); }

   /// <summary>
   /// Converts a <see cref="double"/> to the bit-wise identical <see cref="long"/>
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>the <see cref="long"/> representation of the underlying bits</returns>
   public static long BitwiseToInt64(this double value) { return BitConverter.DoubleToInt64Bits(value); }

   /// <summary>
   /// Converts a <see cref="ulong"/> to the bit-wise identical <see cref="double"/>
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>the <see cref="double"/> representation of the bits</returns>
   public static double BitwiseToDouble(this ulong value) { return ((long) value).BitwiseToDouble(); }

   /// <summary>
   /// Converts a <see cref="long"/> to the bit-wise identical <see cref="double"/>
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>the <see cref="double"/> representation of the bits</returns>
   public static double BitwiseToDouble(this long value) { return BitConverter.Int64BitsToDouble(value); }
}
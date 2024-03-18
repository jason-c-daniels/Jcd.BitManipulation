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
   public static uint ToUInt32Bits(this float value) { return (uint) value.ToInt32Bits(); }

   /// <summary>
   /// Converts a <see cref="float"/> to the bit-wise identical <see cref="int"/>
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>the <see cref="int"/> representation of the underlying bits</returns>
   public static int ToInt32Bits(this float value) { return BitConverter.ToInt32(BitConverter.GetBytes(value), 0); }

   /// <summary>
   /// Converts a <see cref="uint"/> to the bit-wise identical <see cref="float"/>
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>the <see cref="float"/> representation of the bits</returns>
   public static float FromUInt32Bits(this uint value) { return ((int) value).FromInt32Bits(); }

   /// <summary>
   /// Converts a <see cref="int"/> to the bit-wise identical <see cref="float"/>
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>the <see cref="float"/> representation of the bits</returns>
   public static float FromInt32Bits(this int value) { return BitConverter.ToSingle(BitConverter.GetBytes(value), 0); }

   /// <summary>
   /// Converts a <see cref="double"/> to the bit-wise identical <see cref="ulong"/>
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>the <see cref="ulong"/> representation of the underlying bits</returns>
   public static ulong ToUInt64Bits(this double value) { return (ulong) value.ToInt64Bits(); }

   /// <summary>
   /// Converts a <see cref="double"/> to the bit-wise identical <see cref="long"/>
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>the <see cref="long"/> representation of the underlying bits</returns>
   public static long ToInt64Bits(this double value) { return BitConverter.DoubleToInt64Bits(value); }

   /// <summary>
   /// Converts a <see cref="ulong"/> to the bit-wise identical <see cref="double"/>
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>the <see cref="double"/> representation of the bits</returns>
   public static double FromUInt64Bits(this ulong value) { return ((long) value).FromInt64Bits(); }

   /// <summary>
   /// Converts a <see cref="long"/> to the bit-wise identical <see cref="double"/>
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>the <see cref="double"/> representation of the bits</returns>
   public static double FromInt64Bits(this long value) { return BitConverter.Int64BitsToDouble(value); }
}
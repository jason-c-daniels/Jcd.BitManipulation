#region

using System;
using System.Runtime.CompilerServices;

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Provides facilities to convert <see cref="ReadOnlySpan{T}" /> of bytes to other data types.
/// </summary>
public static class ReadOnlySpanOfByteExtensions
{
   /// <summary>
   /// Converts bytes into a <see cref="byte" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="byte" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ToByte(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Big
                ? data[^1]
                : data[0];
   }

   /// <summary>
   /// Converts bytes into an <see cref="sbyte" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="sbyte" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ToSByte(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Big
                ? (sbyte) data[^1]
                : (sbyte) data[0];
   }

   /// <summary>
   /// Converts bytes into a <see cref="ushort" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="ushort" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort ToUInt16(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Little
                ? (ushort) GetLittleEndianUInt64(data)
                : (ushort) GetBigEndianUInt64(data, sizeof(ushort));
   }

   /// <summary>
   /// Converts bytes into a <see cref="short" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="short" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short ToInt16(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Little
                ? (short) GetLittleEndianUInt64(data)
                : (short) GetBigEndianUInt64(data, sizeof(short));
   }

   /// <summary>
   /// Converts bytes into a <see cref="uint" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="uint" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ToUInt32(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Little
                ? (uint) GetLittleEndianUInt64(data)
                : (uint) GetBigEndianUInt64(data, sizeof(uint));
   }

   /// <summary>
   /// Converts bytes into an <see cref="int" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="int" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int ToInt32(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Little
                ? (int) GetLittleEndianUInt64(data)
                : (int) GetBigEndianUInt64(data, sizeof(int));
   }

   /// <summary>
   /// Converts bytes into a <see cref="ulong" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="ulong" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong ToUInt64(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Little
                ? GetLittleEndianUInt64(data)
                : GetBigEndianUInt64(data, sizeof(ulong));
   }

   /// <summary>
   /// Converts bytes into a <see cref="long" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="long" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ToInt64(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Little
                ? (long) GetLittleEndianUInt64(data)
                : (long) GetBigEndianUInt64(data, sizeof(long));
   }

   /// <summary>
   /// Converts bytes into a double, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted ulong</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static double ToDouble(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      return data.ToUInt64(endian).BitwiseToDouble();
   }

   /// <summary>
   /// Converts bytes into a double, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted ulong</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float ToSingle(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      return data.ToUInt32(endian).BitwiseToSingle();
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private static ulong GetBigEndianUInt64(ReadOnlySpan<byte> data, int size)
   {
      ulong result = 0;
      var len = data.Length;

      if (StoreAndShift(ref result, data, 0, 1, len, size))
         return result;

      if (StoreAndShift(ref result, data, 1, 2, len, size))
         return result;

      if (StoreAndShift(ref result, data, 2, 3, len, size))
         return result;

      if (StoreAndShift(ref result, data, 3, 4, len, size))
         return result;

      if (StoreAndShift(ref result, data, 4, 5, len, size))
         return result;

      if (StoreAndShift(ref result, data, 5, 6, len, size))
         return result;

      if (StoreAndShift(ref result, data, 6, 7, len, size))
         return result;

      StoreAndShift(ref result, data, 7, 8, len, size);

      return result;
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private static bool StoreAndShift(ref ulong result, ReadOnlySpan<byte> data, int idx, int sizeComp, int len, int size)
   {
      if (idx < len)
         result = result.StoreBits(data[idx], 0, 8);

      if (size == sizeComp)
         return true;

      result <<= 8;

      return false;
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   internal static ulong GetLittleEndianUInt64(ReadOnlySpan<byte> data)
   {
      ulong result = 0;
      var i = 0;
      var len = data.Length;
      result = result.StoreBits(data[i], i << 3, 8);
      i++;

      if (i >= len)
         return result;

      result = result.StoreBits(data[i], i << 3, 8);
      i++;

      if (i >= len)
         return result;

      result = result.StoreBits(data[i], i << 3, 8);
      i++;

      if (i >= len)
         return result;

      result = result.StoreBits(data[i], i << 3, 8);
      i++;

      if (i >= len)
         return result;

      result = result.StoreBits(data[i], i << 3, 8);
      i++;

      if (i >= len)
         return result;

      result = result.StoreBits(data[i], i << 3, 8);
      i++;

      if (i >= len)
         return result;

      result = result.StoreBits(data[i], i << 3, 8);
      i++;

      if (i >= len)
         return result;

      result = result.StoreBits(data[i], i << 3, 8);

      return result;
   }
}
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
   /// <param name="data">the bytes to convert</param>
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
   /// <param name="data">the bytes to convert</param>
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
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="ushort" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort ToUInt16(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      if (endian == Endian.Big)
      {
         BigEndianByteIndexer result = (ushort) 0;
         var o = data.Length >= result.Length
                    ? 0
                    : result.Length - data.Length;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[o + i] = data[i];

         return result;
      }
      else
      {
         LittleEndianByteIndexer result = (ushort) 0;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[i] = data[i];

         return result;
      }
   }

   /// <summary>
   /// Converts bytes into a <see cref="short" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="short" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short ToInt16(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      if (endian == Endian.Big)
      {
         BigEndianByteIndexer result = (short) 0;
         var o = data.Length >= result.Length
                    ? 0
                    : result.Length - data.Length;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[o + i] = data[i];

         return result;
      }
      else
      {
         LittleEndianByteIndexer result = (short) 0;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[i] = data[i];

         return result;
      }
   }

   /// <summary>
   /// Converts bytes into a <see cref="uint" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="uint" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ToUInt32(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      if (endian == Endian.Big)
      {
         BigEndianByteIndexer result = (uint) 0;
         var o = data.Length >= result.Length
                    ? 0
                    : result.Length - data.Length;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[o + i] = data[i];

         return result;
      }
      else
      {
         LittleEndianByteIndexer result = (uint) 0;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[i] = data[i];

         return result;
      }
   }

   /// <summary>
   /// Converts bytes into an <see cref="int" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="int" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int ToInt32(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      if (endian == Endian.Big)
      {
         BigEndianByteIndexer result = 0;
         var o = data.Length >= result.Length
                    ? 0
                    : result.Length - data.Length;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[o + i] = data[i];

         return result;
      }
      else
      {
         LittleEndianByteIndexer result = 0;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[i] = data[i];

         return result;
      }
   }

   /// <summary>
   /// Converts bytes into a <see cref="ulong" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="ulong" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong ToUInt64(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      if (endian == Endian.Big)
      {
         BigEndianByteIndexer result = (ulong) 0;
         var o = data.Length >= result.Length
                    ? 0
                    : result.Length - data.Length;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[o + i] = data[i];

         return result;
      }
      else
      {
         LittleEndianByteIndexer result = (ulong) 0;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[i] = data[i];

         return result;
      }
   }

   /// <summary>
   /// Converts bytes into a <see cref="long" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="long" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ToInt64(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      if (endian == Endian.Big)
      {
         BigEndianByteIndexer result = (long) 0;
         var o = data.Length >= result.Length
                    ? 0
                    : result.Length - data.Length;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[o + i] = data[i];

         return result;
      }
      else
      {
         LittleEndianByteIndexer result = (long) 0;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[i] = data[i];

         return result;
      }
   }

   /// <summary>
   /// Converts bytes into a double, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
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
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted ulong</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float ToSingle(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      return data.ToUInt32(endian).BitwiseToSingle();
   }
}
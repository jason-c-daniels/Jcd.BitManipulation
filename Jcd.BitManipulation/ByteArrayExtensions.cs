#region

using System;
using System.Runtime.CompilerServices;

using Jcd.BitManipulation.ByteIndexers;

// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable CognitiveComplexity
// ReSharper disable ReplaceSliceWithRangeIndexer
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable RedundantRangeBound

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// A bunch of extension methods to help with converting numbers to and from arrays of bools
/// </summary>
public static class ByteArrayExtensions
{
   /// <summary>
   /// Convert a byte into an array of bytes
   /// </summary>
   /// <param name="data">the byte to convert</param>
   /// <returns>an array containing the byte.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this byte data) { return [data]; }

   /// <summary>
   /// Convert an sbyte into an array of bytes
   /// </summary>
   /// <param name="data">the sbyte to convert</param>
   /// <returns>an array containing the byte.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this sbyte data) { return [(byte) data]; }

   /// <summary>
   /// Convert a ushort into an array of bytes
   /// </summary>
   /// <param name="data">the data of the ushort to convert</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this ushort data, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? new BigEndianByteIndexerUInt16 { Data    = data }[0..^0]
                : new LittleEndianByteIndexerUInt16 { Data = data }[0..^0];
   }

   /// <summary>
   /// Convert a short into an array of bytes
   /// </summary>
   /// <param name="data">the short to convert</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this short data, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? new BigEndianByteIndexerInt16 { Data    = data }[0..^0]
                : new LittleEndianByteIndexerInt16 { Data = data }[0..^0];
   }

   /// <summary>
   /// Convert a uint into an array of bytes
   /// </summary>
   /// <param name="data">the uint to convert</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this uint data, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? new BigEndianByteIndexerUInt32 { Data    = data }[0..^0]
                : new LittleEndianByteIndexerUInt32 { Data = data }[0..^0];
   }

   /// <summary>
   /// Convert an int into an array of bytes
   /// </summary>
   /// <param name="data">the int to convert</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this int data, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? new BigEndianByteIndexerInt32 { Data    = data }[0..^0]
                : new LittleEndianByteIndexerInt32 { Data = data }[0..^0];
   }

   /// <summary>
   /// Convert a ulong into an array of bytes
   /// </summary>
   /// <param name="data">the ulong to convert</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this ulong data, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? new BigEndianByteIndexerUInt64 { Data    = data }[0..^0]
                : new LittleEndianByteIndexerUInt64 { Data = data }[0..^0];
   }

   /// <summary>
   /// Convert a long into an array of bytes
   /// </summary>
   /// <param name="data">the long to convert</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this long data, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? new BigEndianByteIndexerInt64 { Data    = data }[0..^0]
                : new LittleEndianByteIndexerInt64 { Data = data }[0..^0];
   }

   /// <summary>
   /// Convert a float into an array of bytes
   /// </summary>
   /// <param name="data">the long to convert</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this float data, Endian endian = Endian.Little)
   {
      var bits = data.BitwiseToUInt32();

      return endian == Endian.Big
                ? new BigEndianByteIndexerUInt32 { Data    = bits }[0..^0]
                : new LittleEndianByteIndexerUInt32 { Data = bits }[0..^0];
   }

   /// <summary>
   /// Convert a double into an array of bytes
   /// </summary>
   /// <param name="data">the long to convert</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this double data, Endian endian = Endian.Little)
   {
      var bits = data.BitwiseToUInt64();

      return endian == Endian.Big
                ? new BigEndianByteIndexerUInt64 { Data    = bits }[0..^0]
                : new LittleEndianByteIndexerUInt64 { Data = bits }[0..^0];
   }

   /// <summary>
   /// Converts bytes into a byte, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted byte</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ToByte(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0) return 0;

      return endian == Endian.Big ? data[^1] : data[0];
   }

   /// <summary>
   /// Converts bytes into an sbyte, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted sbyte</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ToSByte(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0) return 0;

      return endian == Endian.Big ? (sbyte) data[^1] : (sbyte) data[0];
   }

   /// <summary>
   /// Converts bytes into a ushort, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted ushort</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort ToUInt16(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0) return 0;

      if (endian == Endian.Big)
      {
         BigEndianByteIndexerUInt16 result = 0;
         var                        o      = data.Length >= result.Length ? 0 : result.Length - data.Length;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[o + i] = data[i];

         return result;
      }
      else
      {
         LittleEndianByteIndexerUInt16 result = 0;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[i] = data[i];

         return result;
      }
   }

   /// <summary>
   /// Converts bytes into a short, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted short</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short ToInt16(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0) return 0;

      if (endian == Endian.Big)
      {
         BigEndianByteIndexerInt16 result = 0;
         var o = data.Length >= result.Length
                    ? 0
                    : result.Length - data.Length;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[o + i] = data[i];

         return result;
      }
      else
      {
         LittleEndianByteIndexerInt16 result = 0;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[i] = data[i];

         return result;
      }
   }

   /// <summary>
   /// Converts bytes into a uint, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted uint</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ToUInt32(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0) return 0;

      if (endian == Endian.Big)
      {
         BigEndianByteIndexerUInt32 result = 0;
         var o = data.Length >= result.Length
                    ? 0
                    : result.Length - data.Length;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[o + i] = data[i];

         return result;
      }
      else
      {
         LittleEndianByteIndexerUInt32 result = 0;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[i] = data[i];

         return result;
      }
   }

   /// <summary>
   /// Converts bytes into an int, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted int</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int ToInt32(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0) return 0;

      if (endian == Endian.Big)
      {
         BigEndianByteIndexerInt32 result = 0;
         var o = data.Length >= result.Length
                    ? 0
                    : result.Length - data.Length;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[o + i] = data[i];

         return result;
      }
      else
      {
         LittleEndianByteIndexerInt32 result = 0;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[i] = data[i];

         return result;
      }
   }

   /// <summary>
   /// Converts bytes into a ulong, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted ulong</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong ToUInt64(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0) return 0;

      if (endian == Endian.Big)
      {
         BigEndianByteIndexerUInt64 result = 0;
         var o = data.Length >= result.Length
                    ? 0
                    : result.Length - data.Length;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[o + i] = data[i];

         return result;
      }
      else
      {
         LittleEndianByteIndexerUInt64 result = 0;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[i] = data[i];

         return result;
      }
   }

   /// <summary>
   /// Converts bytes into a long, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted long</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ToInt64(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0) return 0;

      if (endian == Endian.Big)
      {
         BigEndianByteIndexerInt64 result = 0;
         var o = data.Length >= result.Length
                    ? 0
                    : result.Length - data.Length;
         for (var i = 0; i < data.Length && i < result.Length; i++)
            result[o + i] = data[i];

         return result;
      }
      else
      {
         LittleEndianByteIndexerInt64 result = 0;
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

   /// <summary>
   /// Converts bytes into a byte, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted byte</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ToByte(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0) return 0;

      return endian == Endian.Little ? data[0] : data[^1];
   }

   /// <summary>
   /// Converts bytes into an sbyte, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted sbyte</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ToSByte(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0) return 0;

      return endian == Endian.Little ? (sbyte) data[0] : (sbyte) data[^1];
   }

   /// <summary>
   /// Converts bytes into a ushort, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted ushort</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort ToUInt16(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0) return 0;
      ushort result = 0;
      var    len    = data.Length;

      if (endian == Endian.Little)
      {
         var i = 0;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
      }
      else
      {
         var i = 0;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result = (ushort) (result << 8);
         result = result.StoreBits(data[i], 0, 8);
      }

      return result;
   }

   /// <summary>
   /// Converts bytes into a short, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted short</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short ToInt16(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0) return 0;
      short result = 0;
      var   len    = data.Length;

      if (endian == Endian.Little)
      {
         var i = 0;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
      }
      else
      {
         var i = 0;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result = (short) (result << 8);
         result = result.StoreBits(data[i], 0, 8);
      }

      return result;
   }

   /// <summary>
   /// Converts bytes into a uint, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted uint</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ToUInt32(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0) return 0;
      uint result = 0;
      var  len    = data.Length;

      if (endian == Endian.Little)
      {
         var i = 0;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
      }
      else
      {
         var i = 0;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
      }

      return result;
   }

   /// <summary>
   /// Converts bytes into an int, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted int</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int ToInt32(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0) return 0;
      var result = 0;
      var len    = data.Length;

      if (endian == Endian.Little)
      {
         var i = 0;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
      }
      else
      {
         var i = 0;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
      }

      return result;
   }

   /// <summary>
   /// Converts bytes into a ulong, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted ulong</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong ToUInt64(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0) return 0;
      ulong result = 0;
      var   len    = data.Length;

      if (endian == Endian.Little)
      {
         var i = 0;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
      }
      else
      {
         var i = 0;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
      }

      return result;
   }

   /// <summary>
   /// Converts bytes into a long, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <returns>The converted long</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ToInt64(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0) return 0;
      long result = 0;
      var  len    = data.Length;

      if (endian == Endian.Little)
      {
         var i = 0;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len) return result;
         result = result.StoreBits(data[i], i << 3, 8);
      }
      else
      {
         var i = 0;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len) return result;
         result <<= 8;
         result =   result.StoreBits(data[i], 0, 8);
      }

      return result;
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
   public static double ToDouble(this byte[] data, Endian endian = Endian.Little)
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
   public static float ToSingle(this byte[] data, Endian endian = Endian.Little)
   {
      return data.ToUInt32(endian).BitwiseToSingle();
   }
}
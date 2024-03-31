#region

using System;
using System.Runtime.CompilerServices;

// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable CognitiveComplexity
// ReSharper disable ReplaceSliceWithRangeIndexer
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable RedundantRangeBound

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Extension methods to aid in converting numbers to and from arrays of bools
/// </summary>

[Obsolete("The extension methods in this type are being moved to type-specific classes in v3.0. Change all invocations over to standard extension method invocations! And the implementation for Big Endian usages are changing to be consistent with BigEndianByteIndexer.StoreBytes in v3.0. This will break some usages.")]
public static class ByteArrayExtensions
{
   /// <summary>
   /// Convert a <see cref="byte" /> into an array of bytes
   /// </summary>
   /// <param name="data">the <see cref="byte" /> to convert</param>
   /// <returns>an array containing the <see cref="byte" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this byte data)
   {
      return [data];
   }

   /// <summary>
   /// Convert an <see cref="sbyte" /> into an array of bytes
   /// </summary>
   /// <param name="data">the <see cref="sbyte" /> to convert</param>
   /// <returns>an array containing the <see cref="sbyte" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this sbyte data)
   {
      return [(byte) data];
   }

   /// <summary>
   /// Convert a <see cref="ushort" /> into an array of bytes
   /// </summary>
   /// <param name="data">the data of the <see cref="ushort" /> to convert</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this ushort data, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? new BigEndianByteIndexerUInt16 { Data = data }[0..^0]
                : new LittleEndianByteIndexerUInt16 { Data = data }[0..^0];
   }

   /// <summary>
   /// Convert a <see cref="short" /> into an array of bytes
   /// </summary>
   /// <param name="data">the <see cref="short" /> to convert</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this short data, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? new BigEndianByteIndexerInt16 { Data = data }[0..^0]
                : new LittleEndianByteIndexerInt16 { Data = data }[0..^0];
   }

   /// <summary>
   /// Convert a uint into an array of bytes
   /// </summary>
   /// <param name="data">the <see cref="uint" /> to convert</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this uint data, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? new BigEndianByteIndexerUInt32 { Data = data }[0..^0]
                : new LittleEndianByteIndexerUInt32 { Data = data }[0..^0];
   }

   /// <summary>
   /// Convert an int into an array of bytes
   /// </summary>
   /// <param name="data">the <see cref="int" /> to convert</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this int data, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? new BigEndianByteIndexerInt32 { Data = data }[0..^0]
                : new LittleEndianByteIndexerInt32 { Data = data }[0..^0];
   }

   /// <summary>
   /// Convert a <see cref="ulong" /> into an array of bytes
   /// </summary>
   /// <param name="data">the <see cref="ulong" /> to convert</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this ulong data, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? new BigEndianByteIndexerUInt64 { Data = data }[0..^0]
                : new LittleEndianByteIndexerUInt64 { Data = data }[0..^0];
   }

   /// <summary>
   /// Convert a <see cref="long" /> into an array of bytes
   /// </summary>
   /// <param name="data">the <see cref="long" /> to convert</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this long data, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? new BigEndianByteIndexerInt64 { Data = data }[0..^0]
                : new LittleEndianByteIndexerInt64 { Data = data }[0..^0];
   }

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
   [Obsolete("The behavior of this this method will have a breaking change in 3.0")]
   public static ushort ToUInt16(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      if (endian == Endian.Big)
      {
         BigEndianByteIndexerUInt16 result = 0;
         var o = data.Length >= result.Length
                    ? 0
                    : result.Length - data.Length;
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
   /// Converts bytes into a <see cref="short" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="short" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   [Obsolete("The behavior of this this method will have a breaking change in 3.0")]
   public static short ToInt16(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

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
   /// Converts bytes into a <see cref="uint" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="uint" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   [Obsolete("The behavior of this this method will have a breaking change in 3.0")]
   public static uint ToUInt32(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

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
   /// Converts bytes into an <see cref="int" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="int" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   [Obsolete("The behavior of this this method will have a breaking change in 3.0")]
   public static int ToInt32(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

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
   /// Converts bytes into a <see cref="ulong" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="ulong" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   [Obsolete("The behavior of this this method will have a breaking change in 3.0")]
   public static ulong ToUInt64(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

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
   /// Converts bytes into a <see cref="long" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="long" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   [Obsolete("The behavior of this this method will have a breaking change in 3.0")]
   public static long ToInt64(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

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
   /// Converts bytes into a <see cref="byte" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="byte" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   [Obsolete("The behavior of this this method will have a breaking change in 3.0")]
   public static byte ToByte(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Little
                ? data[0]
                : data[^1];
   }

   /// <summary>
   /// Converts bytes into an <see cref="sbyte" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted sbyte</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   [Obsolete("The behavior of this this method will have a breaking change in 3.0")]
   public static sbyte ToSByte(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Little
                ? (sbyte) data[0]
                : (sbyte) data[^1];
   }

   /// <summary>
   /// Converts bytes into a <see cref="ushort" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="ushort" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   [Obsolete("The behavior of this this method will have a breaking change in 3.0")]
   public static ushort ToUInt16(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      ushort result = 0;
      var len = data.Length;

      if (endian == Endian.Little)
      {
         var i = 0;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len)
            return result;

         result = result.StoreBits(data[i], i << 3, 8);
      }
      else
      {
         var i = 0;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result = (ushort) (result << 8);
         result = result.StoreBits(data[i], 0, 8);
      }

      return result;
   }

   /// <summary>
   /// Converts bytes into a <see cref="short" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="short" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   [Obsolete("The behavior of this this method will have a breaking change in 3.0")]
   public static short ToInt16(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      short result = 0;
      var len = data.Length;

      if (endian == Endian.Little)
      {
         var i = 0;
         result = result.StoreBits(data[i], i << 3, 8);
         i++;

         if (i >= len)
            return result;

         result = result.StoreBits(data[i], i << 3, 8);
      }
      else
      {
         var i = 0;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result = (short) (result << 8);
         result = result.StoreBits(data[i], 0, 8);
      }

      return result;
   }

   /// <summary>
   /// Converts bytes into a <see cref="uint" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="uint" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   [Obsolete("The behavior of this this method will have a breaking change in 3.0")]
   public static uint ToUInt32(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      uint result = 0;
      var len = data.Length;

      if (endian == Endian.Little)
      {
         var i = 0;
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
      }
      else
      {
         var i = 0;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
      }

      return result;
   }

   /// <summary>
   /// Converts bytes into an <see cref="uint" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="uint" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   [Obsolete("The behavior of this this method will have a breaking change in 3.0")]
   public static int ToInt32(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      var result = 0;
      var len = data.Length;

      if (endian == Endian.Little)
      {
         var i = 0;
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
      }
      else
      {
         var i = 0;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
      }

      return result;
   }

   /// <summary>
   /// Converts bytes into a <see cref="ulong" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="ulong" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   [Obsolete("The behavior of this this method will have a breaking change in 3.0")]
   public static ulong ToUInt64(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      ulong result = 0;
      var len = data.Length;

      if (endian == Endian.Little)
      {
         var i = 0;
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
      }
      else
      {
         var i = 0;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
      }

      return result;
   }

   /// <summary>
   /// Converts bytes into a <see cref="long" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="long" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   [Obsolete("The behavior of this this method will have a breaking change in 3.0")]
   public static long ToInt64(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      long result = 0;
      var len = data.Length;

      if (endian == Endian.Little)
      {
         var i = 0;
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
      }
      else
      {
         var i = 0;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
         i++;

         if (i >= len)
            return result;

         result <<= 8;
         result = result.StoreBits(data[i], 0, 8);
      }

      return result;
   }
}
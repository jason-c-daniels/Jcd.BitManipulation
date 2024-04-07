#region

using System;
using System.Runtime.CompilerServices;

// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMethodReturnValue.Global
// ReSharper disable UnusedMemberInSuper.Global

#pragma warning disable S4136

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
   /// <param name="span">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="byte" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ToByte(this ReadOnlySpan<byte> span, Endian endian = Endian.Little)
   {
      if (span == null || span.Length == 0)
      {
         return 0;
      }

      return endian == Endian.Little
                ? (byte) GetLittleEndianUInt64(span)
                : (byte) GetBigEndianUInt64(span, sizeof(byte));
   }

   /// <summary>
   /// Converts bytes into a <see cref="sbyte" />, discarding any excess data.
   /// </summary>
   /// <param name="span">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="sbyte" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ToSByte(this ReadOnlySpan<byte> span, Endian endian = Endian.Little)
   {
      if (span == null || span.Length == 0)
      {
         return 0;
      }

      return endian == Endian.Little
                ? (sbyte) GetLittleEndianUInt64(span)
                : (sbyte) GetBigEndianUInt64(span, sizeof(sbyte));
   }

   /// <summary>
   /// Converts bytes into a <see cref="ushort" />, discarding any excess data.
   /// </summary>
   /// <param name="span">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <param name="align">Indicates how to align partial data</param>
   /// <returns>The converted <see cref="ushort" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort ToUInt16(this ReadOnlySpan<byte> span, Endian endian = Endian.Little, ByteAlignment align = ByteAlignment.InferredFromEndian)
   {
      if (span == null || span.Length == 0)
      {
         return 0;
      }

      return (ushort) GetAlignedValue(span, endian, align, sizeof(ushort));
   }

   /// <summary>
   /// Converts bytes into a <see cref="short" />, discarding any excess data.
   /// </summary>
   /// <param name="span">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <param name="align">Indicates how to align partial data</param>
   /// <returns>The converted <see cref="short" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short ToInt16(this ReadOnlySpan<byte> span, Endian endian = Endian.Little, ByteAlignment align = ByteAlignment.InferredFromEndian)
   {
      if (span == null || span.Length == 0)
      {
         return 0;
      }

      return (short) GetAlignedValue(span, endian, align, sizeof(short));
   }

   /// <summary>
   /// Converts bytes into a <see cref="uint" />, discarding any excess data.
   /// </summary>
   /// <param name="span">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <param name="align">Indicates how to align partial data</param>
   /// <returns>The converted <see cref="uint" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ToUInt32(this ReadOnlySpan<byte> span, Endian endian = Endian.Little, ByteAlignment align = ByteAlignment.InferredFromEndian)
   {
      if (span == null || span.Length == 0)
      {
         return 0;
      }

      return (uint) GetAlignedValue(span, endian, align, sizeof(uint));
   }

   /// <summary>
   /// Converts bytes into a <see cref="int" />, discarding any excess data.
   /// </summary>
   /// <param name="span">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <param name="align">Indicates how to align partial data</param>
   /// <returns>The converted <see cref="int" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int ToInt32(this ReadOnlySpan<byte> span, Endian endian = Endian.Little, ByteAlignment align = ByteAlignment.InferredFromEndian)
   {
      if (span == null || span.Length == 0)
      {
         return 0;
      }

      return (int) GetAlignedValue(span, endian, align, sizeof(int));
   }

   /// <summary>
   /// Converts bytes into a <see cref="ulong" />, discarding any excess data.
   /// </summary>
   /// <param name="span">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <param name="align">Indicates how to align partial data</param>
   /// <returns>The converted <see cref="ulong" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong ToUInt64(this ReadOnlySpan<byte> span, Endian endian = Endian.Little, ByteAlignment align = ByteAlignment.InferredFromEndian)
   {
      if (span == null || span.Length == 0)
      {
         return 0;
      }

      return GetAlignedValue(span, endian, align, sizeof(ulong));
   }

   /// <summary>
   /// Converts bytes into a <see cref="long" />, discarding any excess data.
   /// </summary>
   /// <param name="span">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <param name="align">Indicates how to align partial data</param>
   /// <returns>The converted <see cref="long" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ToInt64(this ReadOnlySpan<byte> span, Endian endian = Endian.Little, ByteAlignment align = ByteAlignment.InferredFromEndian)
   {
      if (span == null || span.Length == 0)
      {
         return 0;
      }

      return (long) GetAlignedValue(span, endian, align, sizeof(long));
   }

   /// <summary>
   /// Converts bytes into a double, discarding any excess data.
   /// </summary>
   /// <param name="span">the bytes to convert.</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <param name="align">Indicates how to align partial data</param>
   /// <returns>The converted ulong</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static double ToDouble(this ReadOnlySpan<byte> span, Endian endian = Endian.Little, ByteAlignment align = ByteAlignment.InferredFromEndian)
   {
      return span.ToUInt64(endian, align).BitwiseToDouble();
   }

   /// <summary>
   /// Converts bytes into a double, discarding any excess data.
   /// </summary>
   /// <param name="span">the bytes to convert.</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <param name="align">Indicates how to align partial data</param>
   /// <returns>The converted ulong</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float ToSingle(this ReadOnlySpan<byte> span, Endian endian = Endian.Little, ByteAlignment align = ByteAlignment.InferredFromEndian)
   {
      return span.ToUInt32(endian, align).BitwiseToSingle();
   }

   #region Helpers

   private static ulong GetAlignedValue(ReadOnlySpan<byte> data, Endian endian, ByteAlignment align, int typeSize)
   {
      var size = data.Length;
      var result = endian == Endian.Little
                      ? GetLittleEndianUInt64(data)
                      : GetBigEndianUInt64(data, typeSize);

      if (data.Length >= typeSize)
      {
         return result;
      }

      if (align == ByteAlignment.InferredFromEndian)
      {
         align = endian == Endian.Big
                    ? ByteAlignment.MostSignificantByte
                    : ByteAlignment.LeastSignificantByte;
      }

      var diff = typeSize - size;

      if (endian == Endian.Big && align == ByteAlignment.LeastSignificantByte)
      {
         result >>= diff << BitSizeConstants.ThreeBits;
      }
      else if (endian == Endian.Little && align == ByteAlignment.MostSignificantByte)
      {
         result <<= diff << BitSizeConstants.ThreeBits;
      }

      return result;
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private static ulong GetBigEndianUInt64(ReadOnlySpan<byte> data, int size)
   {
      #pragma warning disable S109
      ulong result = 0;
      var len = data.Length;

      // byte & sbyte
      if (StoreAndShift(ref result, data, 0, 1, len, size))
      {
         return result;
      }

      // short & ushort
      if (StoreAndShift(ref result, data, 1, 2, len, size))
      {
         return result;
      }

      // int & uint
      StoreAndShift(ref result, data, 2, 3, len, size);

      if (StoreAndShift(ref result, data, 3, 4, len, size))
      {
         return result;
      }

      // long & ulong
      StoreAndShift(ref result, data, 4, 5, len, size);
      StoreAndShift(ref result, data, 5, 6, len, size);
      StoreAndShift(ref result, data, 6, 7, len, size);
      StoreAndShift(ref result, data, 7, 8, len, size);

      return result;
      #pragma warning restore S109
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private static bool StoreAndShift(ref ulong result, ReadOnlySpan<byte> data, int idx, int sizeComp, int len, int size)
   {
      if (idx < len)
      {
         result = result.StoreBits(data[idx], 0, BitSizeConstants.BitsPerByte);
      }

      if (size == sizeComp)
      {
         return true;
      }

      result <<= BitSizeConstants.BitsPerByte;

      return false;
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   internal static ulong GetLittleEndianUInt64(ReadOnlySpan<byte> data)
   {
      #pragma warning disable S109
      ulong result = 0;
      var len = data.Length;

      result = result.StoreBits(data[0], 0, BitSizeConstants.BitsPerByte);

      if (len == 1)
      {
         return result;
      }

      result = result.StoreBits(data[1], 1 << BitSizeConstants.ThreeBits, BitSizeConstants.BitsPerByte);

      if (len == 2)
      {
         return result;
      }

      result = result.StoreBits(data[2], 2 << BitSizeConstants.ThreeBits, BitSizeConstants.BitsPerByte);

      if (len == 3)
      {
         return result;
      }

      result = result.StoreBits(data[3], 3 << BitSizeConstants.ThreeBits, BitSizeConstants.BitsPerByte);

      if (len == 4)
      {
         return result;
      }

      result = result.StoreBits(data[4], 4 << BitSizeConstants.ThreeBits, BitSizeConstants.BitsPerByte);

      if (len == 5)
      {
         return result;
      }

      result = result.StoreBits(data[5], 5 << BitSizeConstants.ThreeBits, BitSizeConstants.BitsPerByte);

      if (len == 6)
      {
         return result;
      }

      result = result.StoreBits(data[6], 6 << BitSizeConstants.ThreeBits, BitSizeConstants.BitsPerByte);

      if (len == 7)
      {
         return result;
      }

      result = result.StoreBits(data[7], 7 << BitSizeConstants.ThreeBits, BitSizeConstants.BitsPerByte);

      return result;
      #pragma warning restore S109
   }

   #endregion
}
#region

using System.Runtime.CompilerServices;

// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable CognitiveComplexity
// ReSharper disable ReplaceSliceWithRangeIndexer
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable RedundantRangeBound
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedVariable
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMethodReturnValue.Global
// ReSharper disable UnusedMemberInSuper.Global
// ReSharper disable SuggestBaseTypeForParameter

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Provides facilities to convert an array of bytes to other data types.
/// </summary>
public static class ByteArrayExtensions
{
   /// <summary>
   /// Converts an array of bytes into a <see cref="byte" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="byte" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ToByte(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
      {
         return 0;
      }

      return endian == Endian.Little
                ? (byte) GetLittleEndianUInt64(data)
                : (byte) GetBigEndianUInt64(data, sizeof(byte));
   }

   /// <summary>
   /// Converts an array of bytes into a <see cref="sbyte" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted sbyte</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ToSByte(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
      {
         return 0;
      }

      return endian == Endian.Little
                ? (sbyte) GetLittleEndianUInt64(data)
                : (sbyte) GetBigEndianUInt64(data, sizeof(sbyte));
   }

   /// <summary>
   /// Converts an array of bytes into a <see cref="ushort" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <param name="align">Indicates how to align partial data</param>
   /// <returns>The converted <see cref="ushort" /></returns>
   /// <remarks>
   /// <para>
   /// <b>WARNING:</b>
   /// </para>
   /// <para>
   /// Index 0 in the array is index 0 in the destination value. For Big Endian this is the
   /// most significant byte. If you're passing in a smaller array and need the result
   /// right shifted, you'll need to shift it after calling this.
   /// </para>
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort ToUInt16(this byte[] data, Endian endian = Endian.Little, ByteAlignment align = ByteAlignment.InferredFromEndian)
   {
      if (data == null || data.Length == 0)
      {
         return 0;
      }

      return (ushort) GetAlignedValue(data, endian, align, sizeof(ushort));
   }

   /// <summary>
   /// Converts an array of bytes into a <see cref="short" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <param name="align">Indicates how to align partial data</param>
   /// <returns>The converted <see cref="short" /></returns>
   /// <remarks>
   /// <para>
   /// <b>WARNING:</b>
   /// </para>
   /// <para>
   /// Index 0 in the array is index 0 in the destination value. For Big Endian this is the
   /// most significant byte. If you're passing in a smaller array and need the result
   /// right shifted, you'll need to shift it after calling this.
   /// </para>
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short ToInt16(this byte[] data, Endian endian = Endian.Little, ByteAlignment align = ByteAlignment.InferredFromEndian)
   {
      if (data == null || data.Length == 0)
      {
         return 0;
      }

      return (short) GetAlignedValue(data, endian, align, sizeof(short));
   }

   /// <summary>
   /// Converts an array of bytes into a <see cref="uint" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <param name="align">Indicates how to align partial data</param>
   /// <returns>The converted <see cref="uint" /></returns>
   /// <remarks>
   /// <para>
   /// <b>WARNING:</b>
   /// </para>
   /// <para>
   /// Index 0 in the array is index 0 in the destination value. For Big Endian this is the
   /// most significant byte. If you're passing in a smaller array and need the result
   /// right shifted, you'll need to shift it after calling this.
   /// </para>
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ToUInt32(this byte[] data, Endian endian = Endian.Little, ByteAlignment align = ByteAlignment.InferredFromEndian)
   {
      if (data == null || data.Length == 0)
      {
         return 0;
      }

      return (uint) GetAlignedValue(data, endian, align, sizeof(uint));
   }

   /// <summary>
   /// Converts an array of bytes into a <see cref="uint" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <param name="align">Indicates how to align partial data</param>
   /// <returns>The converted <see cref="uint" /></returns>
   /// <remarks>
   /// <para>
   /// <b>WARNING:</b>
   /// </para>
   /// <para>
   /// Index 0 in the array is index 0 in the destination value. For Big Endian this is the
   /// most significant byte. If you're passing in a smaller array and need the result
   /// right shifted, you'll need to shift it after calling this.
   /// </para>
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int ToInt32(this byte[] data, Endian endian = Endian.Little, ByteAlignment align = ByteAlignment.InferredFromEndian)
   {
      if (data == null || data.Length == 0)
      {
         return 0;
      }

      return (int) GetAlignedValue(data, endian, align, sizeof(int));
   }

   /// <summary>
   /// Converts an array of bytes into a <see cref="ulong" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <param name="align">Indicates how to align partial data</param>
   /// <returns>The converted <see cref="ulong" /></returns>
   /// <remarks>
   /// <para>
   /// <b>WARNING:</b>
   /// </para>
   /// <para>
   /// Index 0 in the array is index 0 in the destination value. For Big Endian this is the
   /// most significant byte. If you're passing in a smaller array and need the result
   /// right shifted, you'll need to shift it after calling this.
   /// </para>
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong ToUInt64(this byte[] data, Endian endian = Endian.Little, ByteAlignment align = ByteAlignment.InferredFromEndian)
   {
      if (data == null || data.Length == 0)
      {
         return 0;
      }

      return GetAlignedValue(data, endian, align, sizeof(ulong));
   }

   /// <summary>
   /// Converts an array of bytes into a <see cref="long" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <param name="align">Indicates how to align partial data</param>
   /// <returns>The converted <see cref="long" /></returns>
   /// <remarks>
   /// <para>
   /// <b>WARNING:</b>
   /// </para>
   /// <para>
   /// Index 0 in the array is index 0 in the destination value. For Big Endian this is the
   /// most significant byte. If you're passing in a smaller array and need the result
   /// right shifted, you'll need to shift it after calling this.
   /// </para>
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ToInt64(this byte[] data, Endian endian = Endian.Little, ByteAlignment align = ByteAlignment.InferredFromEndian)
   {
      if (data == null || data.Length == 0)
      {
         return 0;
      }

      return (long) GetAlignedValue(data, endian, align, sizeof(long));
   }

   /// <summary>
   /// Converts an array of bytes into a <see cref="double" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <param name="align">Indicates how to align partial data</param>
   /// <returns>The converted <see cref="double" /></returns>
   /// <remarks>
   /// <para>
   /// <b>WARNING:</b>
   /// </para>
   /// <para>
   /// Index 0 in the array is index 0 in the destination value. For Big Endian this is the
   /// most significant byte. If you're passing in a smaller array and need the result
   /// right shifted, after calling this, you'll need to convert to a <see cref="ulong" />
   /// shift it, then convert back to a <see cref="double" />.
   /// </para>
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static double ToDouble(this byte[] data, Endian endian = Endian.Little, ByteAlignment align = ByteAlignment.InferredFromEndian)
   {
      return data.ToUInt64(endian).BitwiseToDouble();
   }

   /// <summary>
   /// Converts an array of bytes into a <see cref="float" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert.</param>
   /// <param name="endian">
   /// A setting indicating the endianness of the source data. The default is Endian.Little.
   /// </param>
   /// <param name="align">Indicates how to align partial data</param>
   /// <returns>The converted ulong</returns>
   /// <remarks>
   /// <para>
   /// <b>WARNING:</b>
   /// </para>
   /// <para>
   /// Index 0 in the array is index 0 in the destination value. For Big Endian this is the
   /// most significant byte. If you're passing in a smaller array and need the result
   /// right shifted, after calling this, you'll need to convert to a <see cref="uint" />
   /// shift it, then convert back to a <see cref="float" />.
   /// </para>
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float ToSingle(this byte[] data, Endian endian = Endian.Little, ByteAlignment align = ByteAlignment.InferredFromEndian)
   {
      return data.ToUInt32(endian).BitwiseToSingle();
   }

   #region internal helpers

   private static ulong GetAlignedValue(byte[] data, Endian endian, ByteAlignment align, int typeSize)
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
   private static ulong GetBigEndianUInt64(byte[] data, int size)
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
   private static bool StoreAndShift(ref ulong result, byte[] data, int idx, int sizeComp, int len, int size)
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
   private static ulong GetLittleEndianUInt64(byte[] data)
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
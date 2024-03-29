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

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Extension methods to aid in converting numbers to and from arrays of bools
/// </summary>
public static class ByteArrayExtensions
{
   /// <summary>
   /// Converts an array of bytes into a <see cref="byte" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="byte" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ToByte(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Little
                ? data[0]
                : data[^1];
   }

   /// <summary>
   /// Converts an array of bytes into an <see cref="sbyte" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted sbyte</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ToSByte(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Little
                ? (sbyte) data[0]
                : (sbyte) data[^1];
   }

   /// <summary>
   /// Converts an array of bytes into a <see cref="ushort" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="ushort" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort ToUInt16(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Little
                ? (ushort) GetLittleEndianUInt64(data)
                : (ushort) GetBigEndianUInt64(data);
   }
   
   /// <summary>
   /// Converts an array of bytes into a <see cref="short" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="short" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short ToInt16(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Little
                ? (short) GetLittleEndianUInt64(data)
                : (short) GetBigEndianUInt64(data);
   }

   /// <summary>
   /// Converts an array of bytes into a <see cref="uint" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="uint" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ToUInt32(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Little
                ? (uint) GetLittleEndianUInt64(data)
                : (uint) GetBigEndianUInt64(data);
   }

   /// <summary>
   /// Converts an array of bytes into an <see cref="uint" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="uint" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int ToInt32(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Little
                ? (int) GetLittleEndianUInt64(data)
                : (int) GetBigEndianUInt64(data);
   }

   /// <summary>
   /// Converts an array of bytes into a <see cref="ulong" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="ulong" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong ToUInt64(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Little
                ? GetLittleEndianUInt64(data)
                : GetBigEndianUInt64(data);
   }

   /// <summary>
   /// Converts an array of bytes into a <see cref="long" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="long" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ToInt64(this byte[] data, Endian endian = Endian.Little)
   {
      if (data == null || data.Length == 0)
         return 0;

      return endian == Endian.Little
                ? (long) GetLittleEndianUInt64(data)
                : (long) GetBigEndianUInt64(data);
   }

   /// <summary>
   /// Converts an array of bytes into a <see cref="double" />, discarding any excess data.
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
   /// Converts an array of bytes into a <see cref="float" />, discarding any excess data.
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

   #region internal helpers
   
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private static ulong GetBigEndianUInt64(byte[] data, int offset = 0, int size = -1)
   {
      ulong result = 0;
      var i = 0;
      var len = data.Length;
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

      return result;
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   internal static ulong GetLittleEndianUInt64(byte[] data, int offset = 0, int size = -1)
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

   #endregion
   
}
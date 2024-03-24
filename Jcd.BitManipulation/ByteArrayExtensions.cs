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
   /// Converts bytes into a <see cref="byte" />, discarding any excess data.
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
   /// Converts bytes into an <see cref="sbyte" />, discarding any excess data.
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
   /// Converts bytes into a <see cref="ushort" />, discarding any excess data.
   /// </summary>
   /// <param name="data">the bytes to convert</param>
   /// <param name="endian">The endian for the bytes.</param>
   /// <returns>The converted <see cref="ushort" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
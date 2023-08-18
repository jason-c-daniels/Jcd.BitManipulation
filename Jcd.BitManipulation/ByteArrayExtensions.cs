#region

// ReSharper disable ReplaceSliceWithRangeIndexer
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.CompilerServices;
using Jcd.BitManipulation.ByteIndexers;

namespace Jcd.BitManipulation;

#endregion

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
    public static byte[] ToByteArray(this byte data)
    {
        return new[] { data };
    }

    /// <summary>
    /// Convert an sbyte into an array of bytes
    /// </summary>
    /// <param name="data">the sbyte to convert</param>
    /// <returns>an array containing the byte.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] ToByteArray(this sbyte data)
    {
        return new[] { (byte)data };
    }

    /// <summary>
    /// Convert a ushort into an array of bytes
    /// </summary>
    /// <param name="data">the data of the ushort to convert</param>
    /// <param name="endian">The order in which to store the bytes</param>
    /// <returns>The value as an array in the requested byte order</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] ToByteArray(this ushort data, Endian endian = Endian.Little)
    {
        var result = new ByteIndexerUInt16 { Data = data }.Slice(0, ByteIndexerUInt16.ByteSize);
        if (endian == Endian.Big) Array.Reverse(result);
        return result;
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
        var result = new ByteIndexerInt16 { Data = data }.Slice(0, ByteIndexerInt16.ByteSize);
        if (endian == Endian.Big) Array.Reverse(result);
        return result;
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
        var result = new ByteIndexerUInt32 { Data = data }.Slice(0, ByteIndexerUInt32.ByteSize);
        if (endian == Endian.Big) Array.Reverse(result);
        return result;
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
        var result = new ByteIndexerInt32 { Data = data }.Slice(0, ByteIndexerInt32.ByteSize);
        if (endian == Endian.Big) Array.Reverse(result);
        return result;
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
        var result = new ByteIndexerUInt64 { Data = data }.Slice(0, ByteIndexerUInt64.ByteSize);
        if (endian == Endian.Big) Array.Reverse(result);
        return result;
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
        var result = new ByteIndexerInt64 { Data = data }.Slice(0, ByteIndexerUInt64.ByteSize);
        if (endian == Endian.Big) Array.Reverse(result);
        return result;
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
        return endian == Endian.Big ? data[data.Length - 1] : data[0];
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
        return endian == Endian.Big ? (sbyte)data[data.Length - 1] : (sbyte)data[0];
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
        ByteIndexerUInt16 result = 0;
        for (var i = 0; i < data.Length && i < result.Length; i++)
        {
            if (endian == Endian.Big)
            {
                result <<= 8;
                result[0] = data[i];
            }
            else
                result[i] = data[i];
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
    public static short ToInt16(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
    {
        if (data == null || data.Length == 0) return 0;
        ByteIndexerInt16 result = 0;
        for (var i = 0; i < data.Length && i < result.Length; i++)
        {
            if (endian == Endian.Big)
            {
                result <<= 8;
                result[0] = data[i];
            }
            else
                result[i] = data[i];
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
    public static uint ToUInt32(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
    {
        if (data == null || data.Length == 0) return 0;
        ByteIndexerUInt32 result = 0;
        for (var i = 0; i < data.Length && i < result.Length; i++)
        {
            if (endian == Endian.Big)
            {
                result <<= 8;
                result[0] = data[i];
            }
            else
                result[i] = data[i];
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
    public static int ToInt32(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
    {
        if (data == null || data.Length == 0) return 0;
        ByteIndexerInt32 result = 0;
        for (var i = 0; i < data.Length && i < result.Length; i++)
        {
            if (endian == Endian.Big)
            {
                result <<= 8;
                result[0] = data[i];
            }
            else
                result[i] = data[i];
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
    public static ulong ToUInt64(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
    {
        if (data == null || data.Length == 0) return 0;
        ByteIndexerUInt64 result = 0;
        for (var i = 0; i < data.Length && i < result.Length; i++)
        {
            if (endian == Endian.Big)
            {
                result <<= 8;
                result[0] = data[i];
            }
            else
                result[i] = data[i];
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
    public static long ToInt64(this ReadOnlySpan<byte> data, Endian endian = Endian.Little)
    {
        if (data == null || data.Length == 0) return 0;
        ByteIndexerInt64 result = 0;
        for (var i = 0; i < data.Length && i < result.Length; i++)
        {
            if (endian == Endian.Big)
            {
                result <<= 8;
                result[0] = data[i];
            }
            else
                result[i] = data[i];
        }

        return result;
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
        return endian == Endian.Little ? data[0] : data[data.Length - 1];
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
        return endian == Endian.Little ? (sbyte)data[0] : (sbyte)data[data.Length - 1];
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
        var len = data.Length;
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
            result = (ushort)(result << 8);
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
        var len = data.Length;
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
            result = (short)(result << 8);
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
        var len = data.Length;
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
            result = result.StoreBits(data[i], 0, 8);
            i++;
            if (i >= len) return result;
            result <<= 8;
            result = result.StoreBits(data[i], 0, 8);
            i++;
            if (i >= len) return result;
            result <<= 8;
            result = result.StoreBits(data[i], 0, 8);
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
        var len = data.Length;
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
            result = result.StoreBits(data[i], 0, 8);
            i++;
            if (i >= len) return result;
            result <<= 8;
            result = result.StoreBits(data[i], 0, 8);
            i++;
            if (i >= len) return result;
            result <<= 8;
            result = result.StoreBits(data[i], 0, 8);
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
        var len = data.Length;
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
            result = result.StoreBits(data[i], 0, 8);
            i++;
            if (i >= len) return result;
            result <<= 8;
            result = result.StoreBits(data[i], 0, 8);
            i++;
            if (i >= len) return result;
            result <<= 8;
            result = result.StoreBits(data[i], 0, 8);
            i++;
            if (i >= len) return result;
            result <<= 8;
            result = result.StoreBits(data[i], 0, 8);
            i++;
            if (i >= len) return result;
            result <<= 8;
            result = result.StoreBits(data[i], 0, 8);
            i++;
            if (i >= len) return result;
            result <<= 8;
            result = result.StoreBits(data[i], 0, 8);
            i++;
            if (i >= len) return result;
            result <<= 8;
            result = result.StoreBits(data[i], 0, 8);
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
        var len = data.Length;
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
            result = result.StoreBits(data[i], 0, 8);
            i++;
            if (i >= len) return result;
            result <<= 8;
            result = result.StoreBits(data[i], 0, 8);
            i++;
            if (i >= len) return result;
            result <<= 8;
            result = result.StoreBits(data[i], 0, 8);
            i++;
            if (i >= len) return result;
            result <<= 8;
            result = result.StoreBits(data[i], 0, 8);
            i++;
            if (i >= len) return result;
            result <<= 8;
            result = result.StoreBits(data[i], 0, 8);
            i++;
            if (i >= len) return result;
            result <<= 8;
            result = result.StoreBits(data[i], 0, 8);
            i++;
            if (i >= len) return result;
            result <<= 8;
            result = result.StoreBits(data[i], 0, 8);
        }

        return result;
    }
}
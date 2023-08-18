#region

using System.Runtime.CompilerServices;
using Jcd.BitManipulation.ByteIndexers;

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Extension methods that aid in storing values into byte offsets within another integer data type.
/// The offsets are Least Significant Byte. Index 0 is the 8 least significant bits....etc.
/// </summary>
public static class ReadBytesExtensions
{
    #region operations on ranges of bytes.

    /// <summary>
    /// Reads a set of bytes starting at the specified byte location within the value.
    /// The offsets are in LSB, this means the array will be little endian.
    /// </summary>
    /// <param name="value">The value to be read.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store.</param>
    /// <returns>A little endian byte array of the value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] ReadBytes(this sbyte value, int offset, int size)
    {
        return ((ByteIndexerSByte)value).ReadBytes(offset, size);
    }

    /// <summary>
    /// Reads a set of bytes starting at the specified byte location within the value.
    /// The offsets are in LSB, this means the array will be little endian.
    /// </summary>
    /// <param name="value">The value to be read.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The byte size of the value.</param>
    /// <returns>A little endian byte array of the value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] ReadBytes(this short value, int offset, int size)
    {
        return ((ByteIndexerInt16)value).ReadBytes(offset, size);
    }

    /// <summary>
    /// Reads a set of bytes starting at the specified byte location within the value.
    /// The offsets are in LSB, this means the array will be little endian.
    /// </summary>
    /// <param name="value">The value to be read.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The byte size of the value.</param>
    /// <returns>A little endian byte array of the value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] ReadBytes(this int value, int offset, int size)
    {
        return ((ByteIndexerInt32)value).ReadBytes(offset, size);
    }

    /// <summary>
    /// Reads a set of bytes starting at the specified byte location within the value.
    /// The offsets are in LSB, this means the array will be little endian.
    /// </summary>
    /// <param name="value">The value to be read.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The byte size of the value.</param>
    /// <returns>A little endian byte array of the value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] ReadBytes(this long value, int offset, int size)
    {
        return ((ByteIndexerInt64)value).ReadBytes(offset, size);
    }

    /// <summary>
    /// Reads a set of bytes starting at the specified byte location within the value.
    /// The offsets are in LSB, this means the array will be little endian.
    /// </summary>
    /// <param name="value">The value to be read.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The byte size of the value.</param>
    /// <returns>A little endian byte array of the value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] ReadBytes(this byte value, int offset, int size)
    {
        return ((ByteIndexerByte)value).ReadBytes(offset, size);
    }

    /// <summary>
    /// Reads a set of bytes starting at the specified byte location within the value.
    /// The offsets are in LSB, this means the array will be little endian.
    /// </summary>
    /// <param name="value">The value to be read.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The byte size of the value.</param>
    /// <returns>A little endian byte array of the value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] ReadBytes(this ushort value, int offset, int size)
    {
        return ((ByteIndexerUInt16)value).ReadBytes(offset, size);
    }

    /// <summary>
    /// Reads a set of bytes starting at the specified byte location within the value.
    /// The offsets are in LSB, this means the array will be little endian.
    /// </summary>
    /// <param name="value">The value to be read.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The byte size of the value.</param>
    /// <returns>A little endian byte array of the value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] ReadBytes(this uint value, int offset, int size)
    {
        return ((ByteIndexerUInt32)value).ReadBytes(offset, size);
    }

    /// <summary>
    /// Reads a set of bytes starting at the specified byte location within the value.
    /// The offsets are in LSB, this means the array will be little endian.
    /// </summary>
    /// <param name="value">The value to be read.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The byte size of the value.</param>
    /// <returns>A little endian byte array of the value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] ReadBytes(this ulong value, int offset, int size)
    {
        return ((ByteIndexerUInt64)value).ReadBytes(offset, size);
    }

    #endregion

    #region operations on ByteIndexers

    /// <summary>
    /// Reads a set of bytes starting at the specified byte location within the indexer.
    /// </summary>
    /// <param name="indexer">The indexer whose value is to be modified.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store.</param>
    /// <returns>A little endian byte array of the value.</returns>
    public static byte[] ReadBytes(this ByteIndexerSByte indexer, int offset, int size)
    {
        return indexer.Slice(offset, size);
    }

    /// <summary>
    /// Reads a set of bytes starting at the specified byte location within the indexer.
    /// </summary>
    /// <param name="indexer">The indexer whose value is to be modified.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store.</param>
    /// <returns>A little endian byte array of the value.</returns>
    public static byte[] ReadBytes(this ByteIndexerByte indexer, int offset, int size)
    {
        return indexer.Slice(offset, size);
    }

    /// <summary>
    /// Reads a set of bytes starting at the specified byte location within the indexer.
    /// </summary>
    /// <param name="indexer">The indexer whose value is to be modified.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store.</param>
    /// <returns>A little endian byte array of the value.</returns>
    public static byte[] ReadBytes(this ByteIndexerInt16 indexer, int offset, int size)
    {
        return indexer.Slice(offset, size);
    }

    /// <summary>
    /// Reads a set of bytes starting at the specified byte location within the indexer.
    /// </summary>
    /// <param name="indexer">The indexer whose value is to be modified.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store.</param>
    /// <returns>A little endian byte array of the value.</returns>
    public static byte[] ReadBytes(this ByteIndexerUInt16 indexer, int offset, int size)
    {
        return indexer.Slice(offset, size);
    }

    /// <summary>
    /// Reads a set of bytes starting at the specified byte location within the indexer.
    /// </summary>
    /// <param name="indexer">The indexer whose value is to be modified.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store.</param>
    /// <returns>A little endian byte array of the value.</returns>
    public static byte[] ReadBytes(this ByteIndexerInt32 indexer, int offset, int size)
    {
        return indexer.Slice(offset, size);
    }

    /// <summary>
    /// Reads a set of bytes starting at the specified byte location within the indexer.
    /// </summary>
    /// <param name="indexer">The indexer whose value is to be modified.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store.</param>
    /// <returns>A little endian byte array of the value.</returns>
    public static byte[] ReadBytes(this ByteIndexerUInt32 indexer, int offset, int size)
    {
        return indexer.Slice(offset, size);
    }

    /// <summary>
    /// Reads a set of bytes starting at the specified byte location within the indexer.
    /// </summary>
    /// <param name="indexer">The indexer whose value is to be modified.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store.</param>
    /// <returns>A little endian byte array of the value.</returns>
    public static byte[] ReadBytes(this ByteIndexerInt64 indexer, int offset, int size)
    {
        return indexer.Slice(offset, size);
    }

    /// <summary>
    /// Reads a set of bytes starting at the specified byte location within the indexer.
    /// </summary>
    /// <param name="indexer">The indexer whose value is to be modified.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store.</param>
    /// <returns>A little endian byte array of the value.</returns>
    public static byte[] ReadBytes(this ByteIndexerUInt64 indexer, int offset, int size)
    {
        return indexer.Slice(offset, size);
    }

    #endregion

    #region single byte operations

    /// <summary>
    /// Read a single byte from the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be read.</param>
    /// <param name="offset">the offset of the byte to write</param>
    /// <returns>The specified byte.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte ReadByte(this ulong value, int offset)
    {
        return (byte)value.ReadBits(offset * 8, 8);
    }

    /// <summary>
    /// Read a single byte from the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be read.</param>
    /// <param name="offset">the offset of the byte to write</param>
    /// <returns>The specified byte.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte ReadByte(this long value, int offset)
    {
        return (byte)value.ReadBits(offset * 8, 8);
    }

    /// <summary>
    /// Read a single byte from the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be read.</param>
    /// <param name="offset">the offset of the byte to write</param>
    /// <returns>The specified byte.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte ReadByte(this uint value, int offset)
    {
        return (byte)value.ReadBits(offset * 8, 8);
    }

    /// <summary>
    /// Read a single byte from the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be read.</param>
    /// <param name="offset">the offset of the byte to write</param>
    /// <returns>The specified byte.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte ReadByte(this int value, int offset)
    {
        return (byte)value.ReadBits(offset * 8, 8);
    }

    /// <summary>
    /// Read a single byte from the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be read.</param>
    /// <param name="offset">the offset of the byte to write</param>
    /// <returns>The specified byte.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte ReadByte(this ushort value, int offset)
    {
        return (byte)value.ReadBits(offset * 8, 8);
    }

    /// <summary>
    /// Read a single byte from the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be read.</param>
    /// <param name="offset">the offset of the byte to write</param>
    /// <returns>The specified byte.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte ReadByte(this short value, int offset)
    {
        return (byte)value.ReadBits(offset * 8, 8);
    }

    /// <summary>
    /// Read a single byte from the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be read.</param>
    /// <returns>The specified byte.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte ReadByte(this byte value)
    {
        return value;
    }

    /// <summary>
    /// Read a single byte from the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be read.</param>
    /// <returns>The specified byte.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte ReadByte(this sbyte value)
    {
        return (byte)value;
    }

    #endregion
}
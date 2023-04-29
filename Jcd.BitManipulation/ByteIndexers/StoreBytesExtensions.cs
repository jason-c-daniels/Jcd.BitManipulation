#region

using System;

// ReSharper disable UnusedMethodReturnValue.Global
// ReSharper disable UnusedMemberInSuper.Global
// ReSharper disable MemberCanBePrivate.Global

#endregion

namespace Jcd.BitManipulation.ByteIndexers;

/// <summary>
/// Extension methods that aid in storing values into byte offsets within another integer data type.
/// </summary>
public static class StoreBytesExtensions
{
    #region operations on ranges of bytes.

    /// <summary>
    /// Stores a set of bytes starting at the specified byte location within the value.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="bytes">The value to be stored at the byte location.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
    public static sbyte StoreBytes(this sbyte value, ReadOnlySpan<byte> bytes, int offset, int size = -1)
    {
        return ((ByteIndexerSByte)value).StoreBytes(bytes, offset, size);
    }

    /// <summary>
    /// Stores a set of bytes starting at the specified byte location within the value.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="bytes">The value to be stored at the byte location.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
    public static short StoreBytes(this short value, ReadOnlySpan<byte> bytes, int offset, int size = -1)
    {
        return ((ByteIndexerInt16)value).StoreBytes(bytes, offset, size);
    }

    /// <summary>
    /// Stores a set of bytes starting at the specified byte location within the value.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="bytes">The value to be stored at the byte location.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
    public static int StoreBytes(this int value, ReadOnlySpan<byte> bytes, int offset, int size = -1)
    {
        return ((ByteIndexerInt32)value).StoreBytes(bytes, offset, size);
    }

    /// <summary>
    /// Stores a set of bytes starting at the specified byte location within the value.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="bytes">The value to be stored at the byte location.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
    public static long StoreBytes(this long value, ReadOnlySpan<byte> bytes, int offset, int size = -1)
    {
        return ((ByteIndexerInt64)value).StoreBytes(bytes, offset, size);
    }

    /// <summary>
    /// Stores a set of bytes starting at the specified byte location within the value.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="bytes">The value to be stored at the byte location.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
    public static byte StoreBytes(this byte value, ReadOnlySpan<byte> bytes, int offset, int size = -1)
    {
        return ((ByteIndexerByte)value).StoreBytes(bytes, offset, size);
    }

    /// <summary>
    /// Stores a set of bytes starting at the specified byte location within the value.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="bytes">The value to be stored at the byte location.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
    public static ushort StoreBytes(this ushort value, ReadOnlySpan<byte> bytes, int offset, int size = -1)
    {
        return ((ByteIndexerUInt16)value).StoreBytes(bytes, offset, size);
    }

    /// <summary>
    /// Stores a set of bytes starting at the specified byte location within the value.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="bytes">The value to be stored at the byte location.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
    public static uint StoreBytes(this uint value, ReadOnlySpan<byte> bytes, int offset, int size = -1)
    {
        return ((ByteIndexerUInt32)value).StoreBytes(bytes, offset, size);
    }

    /// <summary>
    /// Stores a set of bytes starting at the specified byte location within the value.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="bytes">The value to be stored at the byte location.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
    public static ulong StoreBytes(this ulong value, ReadOnlySpan<byte> bytes, int offset, int size = -1)
    {
        return ((ByteIndexerUInt64)value).StoreBytes(bytes, offset, size);
    }

    #endregion

    #region operations on ranges of bytes.

    /// <summary>
    /// Stores a set of bytes starting at the specified byte location within the indexer.
    /// </summary>
    /// <param name="indexer">The indexer whose value is to be modified.</param>
    /// <param name="bytes">The value to be stored at the byte location.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
    public static ByteIndexerSByte StoreBytes(this ByteIndexerSByte indexer, ReadOnlySpan<byte> bytes, int offset,
                                              int size)
    {
        if (size == -1 || size > bytes.Length) size = bytes.Length;
        const int i = 0;
        if (offset >= indexer.Length || i >= size) return indexer;
        indexer.StoreByte(bytes[i], offset);

        return indexer;
    }

    /// <summary>
    /// Stores a set of bytes starting at the specified byte location within the indexer.
    /// </summary>
    /// <param name="indexer">The indexer whose value is to be modified.</param>
    /// <param name="bytes">The value to be stored at the byte location.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
    public static ByteIndexerByte StoreBytes(this ByteIndexerByte indexer, ReadOnlySpan<byte> bytes, int offset,
                                             int size)
    {
        if (size == -1 || size > bytes.Length) size = bytes.Length;
        const int i = 0;
        if (offset >= indexer.Length || i >= size) return indexer;
        indexer.StoreByte(bytes[i], offset);

        return indexer;
    }

    /// <summary>
    /// Stores a set of bytes starting at the specified byte location within the indexer.
    /// </summary>
    /// <param name="indexer">The indexer whose value is to be modified.</param>
    /// <param name="bytes">The value to be stored at the byte location.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
    public static ByteIndexerInt16 StoreBytes(this ByteIndexerInt16 indexer, ReadOnlySpan<byte> bytes, int offset,
                                              int size = -1)
    {
        if (size == -1 || size > bytes.Length) size = bytes.Length;
        var idx = 0;
        foreach (var @byte in bytes)
        {
            if (idx >= size) return indexer;
            if (offset + idx >= ByteIndexerInt16.ByteSize) return indexer;

            indexer[idx] = @byte;
            idx++;
        }

        return indexer;
    }

    /// <summary>
    /// Stores a set of bytes starting at the specified byte location within the indexer.
    /// </summary>
    /// <param name="indexer">The indexer whose value is to be modified.</param>
    /// <param name="bytes">The value to be stored at the byte location.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
    public static ByteIndexerUInt16 StoreBytes(this ByteIndexerUInt16 indexer, ReadOnlySpan<byte> bytes, int offset,
                                               int size = -1)
    {
        if (size == -1 || size > bytes.Length) size = bytes.Length;
        var idx = 0;
        foreach (var @byte in bytes)
        {
            if (idx >= size) return indexer;
            if (offset + idx >= ByteIndexerUInt16.ByteSize) return indexer;

            indexer[idx] = @byte;
            idx++;
        }

        return indexer;
    }

    /// <summary>
    /// Stores a set of bytes starting at the specified byte location within the indexer.
    /// </summary>
    /// <param name="indexer">The indexer whose value is to be modified.</param>
    /// <param name="bytes">The value to be stored at the byte location.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
    public static ByteIndexerInt32 StoreBytes(this ByteIndexerInt32 indexer, ReadOnlySpan<byte> bytes, int offset,
                                              int size = -1)
    {
        if (size == -1 || size > bytes.Length) size = bytes.Length;
        var idx = 0;
        foreach (var @byte in bytes)
        {
            if (idx >= size) return indexer;
            if (offset + idx >= ByteIndexerInt32.ByteSize) return indexer;

            indexer[idx] = @byte;
            idx++;
        }

        return indexer;
    }

    /// <summary>
    /// Stores a set of bytes starting at the specified byte location within the indexer.
    /// </summary>
    /// <param name="indexer">The indexer whose value is to be modified.</param>
    /// <param name="bytes">The value to be stored at the byte location.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
    public static ByteIndexerUInt32 StoreBytes(this ByteIndexerUInt32 indexer, ReadOnlySpan<byte> bytes, int offset,
                                               int size = -1)
    {
        if (size == -1 || size > bytes.Length) size = bytes.Length;
        var idx = 0;
        foreach (var @byte in bytes)
        {
            if (idx >= size) return indexer;
            if (offset + idx >= ByteIndexerUInt32.ByteSize) return indexer;

            indexer[idx] = @byte;
            idx++;
        }

        return indexer;
    }

    /// <summary>
    /// Stores a set of bytes starting at the specified byte location within the indexer.
    /// </summary>
    /// <param name="indexer">The indexer whose value is to be modified.</param>
    /// <param name="bytes">The value to be stored at the byte location.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
    public static ByteIndexerInt64 StoreBytes(this ByteIndexerInt64 indexer, ReadOnlySpan<byte> bytes, int offset,
                                              int size = -1)
    {
        if (size == -1 || size > bytes.Length) size = bytes.Length;
        var idx = 0;
        foreach (var @byte in bytes)
        {
            if (idx >= size) return indexer;
            if (offset + idx >= ByteIndexerInt64.ByteSize) return indexer;

            indexer[idx] = @byte;
            idx++;
        }

        return indexer;
    }

    /// <summary>
    /// Stores a set of bytes starting at the specified byte location within the indexer.
    /// </summary>
    /// <param name="indexer">The indexer whose value is to be modified.</param>
    /// <param name="bytes">The value to be stored at the byte location.</param>
    /// <param name="offset">The byte location to store the value.</param>
    /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
    public static ByteIndexerUInt64 StoreBytes(this ByteIndexerUInt64 indexer, ReadOnlySpan<byte> bytes, int offset,
                                               int size = -1)
    {
        if (size == -1 || size > bytes.Length) size = bytes.Length;
        var idx = 0;
        foreach (var @byte in bytes)
        {
            if (idx >= size) return indexer;
            if (offset + idx >= ByteIndexerUInt64.ByteSize) return indexer;

            indexer[idx] = @byte;
            idx++;
        }

        return indexer;
    }

    #endregion

    #region single byte operations

    /// <summary>
    /// Store a single byte to the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="byte">The byte value to set</param>
    /// <param name="offset">the offset of the byte to write</param>
    public static ulong StoreByte(this ulong value, byte @byte, int offset)
    {
        return value.StoreBits(@byte, offset * 8, 8);
    }

    /// <summary>
    /// Store a single byte to the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="byte">The byte value to set</param>
    /// <param name="offset">the offset of the byte to write</param>
    public static long StoreByte(this long value, byte @byte, int offset)
    {
        return value.StoreBits(@byte, offset * 8, 8);
    }

    /// <summary>
    /// Store a single byte to the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="byte">The byte value to set</param>
    /// <param name="offset">the offset of the byte to write</param>
    public static uint StoreByte(this uint value, byte @byte, int offset)
    {
        return value.StoreBits(@byte, offset * 8, 8);
    }

    /// <summary>
    /// Store a single byte to the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="byte">The byte value to set</param>
    /// <param name="offset">the offset of the byte to write</param>
    public static int StoreByte(this int value, byte @byte, int offset)
    {
        return value.StoreBits(@byte, offset * 8, 8);
    }

    /// <summary>
    /// Store a single byte to the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="byte">The byte value to set</param>
    /// <param name="offset">the offset of the byte to write</param>
    public static ushort StoreByte(this ushort value, byte @byte, int offset)
    {
        return value.StoreBits(@byte, offset * 8, 8);
    }

    /// <summary>
    /// Store a single byte to the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="byte">The byte value to set</param>
    /// <param name="offset">the offset of the byte to write</param>
    public static short StoreByte(this short value, byte @byte, int offset)
    {
        return value.StoreBits(@byte, offset * 8, 8);
    }

    /// <summary>
    /// Store a single byte to the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="byte">The byte value to set</param>
    /// <param name="offset">the offset of the byte to write</param>
    public static byte StoreByte(this byte value, byte @byte, int offset)
    {
        return value.StoreBits(@byte, offset * 8, 8);
    }

    /// <summary>
    /// Store a single byte to the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="byte">The byte value to set</param>
    /// <param name="offset">the offset of the byte to write</param>
    public static sbyte StoreByte(this sbyte value, byte @byte, int offset)
    {
        return value.StoreBits((sbyte)@byte, offset * 8, 8);
    }

    /// <summary>
    /// Store a single byte to the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="byte">The byte value to set</param>
    /// <param name="offset">the offset of the byte to write</param>
    public static ByteIndexerUInt64 StoreByte(this ByteIndexerUInt64 value, byte @byte, int offset)
    {
        value[offset] = @byte;
        return value;
    }

    /// <summary>
    /// Store a single byte to the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="byte">The byte value to set</param>
    /// <param name="offset">the offset of the byte to write</param>
    public static ByteIndexerInt64 StoreByte(this ByteIndexerInt64 value, byte @byte, int offset)
    {
        value[offset] = @byte;
        return value;
    }

    /// <summary>
    /// Store a single byte to the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="byte">The byte value to set</param>
    /// <param name="offset">the offset of the byte to write</param>
    public static ByteIndexerUInt32 StoreByte(this ByteIndexerUInt32 value, byte @byte, int offset)
    {
        value[offset] = @byte;
        return value;
    }

    /// <summary>
    /// Store a single byte to the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="byte">The byte value to set</param>
    /// <param name="offset">the offset of the byte to write</param>
    public static ByteIndexerInt32 StoreByte(this ByteIndexerInt32 value, byte @byte, int offset)
    {
        value[offset] = @byte;
        return value;
    }

    /// <summary>
    /// Store a single byte to the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="byte">The byte value to set</param>
    /// <param name="offset">the offset of the byte to write</param>
    public static ByteIndexerUInt16 StoreByte(this ByteIndexerUInt16 value, byte @byte, int offset)
    {
        value[offset] = @byte;
        return value;
    }

    /// <summary>
    /// Store a single byte to the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="byte">The byte value to set</param>
    /// <param name="offset">the offset of the byte to write</param>
    public static ByteIndexerInt16 StoreByte(this ByteIndexerInt16 value, byte @byte, int offset)
    {
        value[offset] = @byte;
        return value;
    }

    /// <summary>
    /// Store a single byte to the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="byte">The byte value to set</param>
    /// <param name="offset">the offset of the byte to write</param>
    public static ByteIndexerByte StoreByte(this ByteIndexerByte value, byte @byte, int offset)
    {
        value[offset] = @byte;
        return value;
    }

    /// <summary>
    /// Store a single byte to the value at the specified byte offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="byte">The byte value to set</param>
    /// <param name="offset">the offset of the byte to write</param>
    public static ByteIndexerSByte StoreByte(this ByteIndexerSByte value, byte @byte, int offset)
    {
        value[offset] = @byte;
        return value;
    }

    #endregion
}
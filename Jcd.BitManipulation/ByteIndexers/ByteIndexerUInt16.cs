#region

using System;
using System.Collections;
using System.Collections.Generic;
// ReSharper disable MemberCanBePrivate.Global

#endregion

namespace Jcd.BitManipulation.ByteIndexers;

/// <summary>
/// Provides byte level indexing operations (set, get) on a UInt16. Zero is the least significant byte.
/// </summary>
public struct ByteIndexerUInt16 : IByteIndexer
{
    /// <summary>
    /// The number of bytes this type will index
    /// </summary>
    public const int ByteSize = sizeof(ushort);

    /// <summary>
    /// Constructs a byte indexer from the underlying data type.
    /// </summary>
    /// <param name="data">The initial value of the data.</param>
    public ByteIndexerUInt16(ushort data = 0)
    {
        Data = data;
    }

    /// <summary>
    /// The length of the buffer.
    /// </summary>
    public int Length => sizeof(ushort);

    /// <summary>
    /// The backing store.
    /// </summary>
    public ushort Data { get; set; }

    /// <summary>
    /// Access bytes from the underlying data.
    /// </summary>
    /// <param name="index">The index of the byte to get or set. 0 is the least significant byte from the underlying storage.</param>
    /// <exception cref="ArgumentOutOfRangeException">When index &lt; 0 or gt;= Length</exception>
    public byte this[int index]
    {
        get
        {
            if (index is < 0 or >= ByteSize) throw new ArgumentOutOfRangeException(nameof(index));
            return (byte)Data.ReadBits(index << 3, 8);
        }
        set
        {
            if (index is < 0 or >= ByteSize) throw new ArgumentOutOfRangeException(nameof(index));
            Data = Data.StoreBits(value, index << 3, 8);
        }
    }

    /// <summary>
    /// Get a subset of bytes given a starting offset and length.
    /// </summary>
    /// <param name="start">The starting bit offset</param>
    /// <param name="length">The number of bits to extract</param>
    /// <returns>an array of bytes for the specified subset</returns>
    public byte[] Slice(int start, int length)
    {
        var slice = new byte[length];
        for (var i = 0; i < length; i++) slice[i] = this[i + start];

        return slice;
    }

    /// <summary>
    /// Converts the byte indexer to its underlying data type.
    /// </summary>
    /// <param name="buffer">The buffer to convert.</param>
    /// <returns>The raw data.</returns>
    public static implicit operator ushort(ByteIndexerUInt16 buffer)
    {
        return buffer.Data;
    }

    /// <summary>
    /// Converts the underlying data type to the buffer type.
    /// </summary>
    /// <param name="data">The underlying data type.</param>
    /// <returns>A buffer type.</returns>
    public static implicit operator ByteIndexerUInt16(ushort data)
    {
        return new ByteIndexerUInt16(data);
    }

    #region Implementation of IEnumerable

    /// <inheritdoc />
    public IEnumerator<byte> GetEnumerator()
    {
        for (var i = 0; i < ByteSize; i++) yield return this[i];
    }

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    #endregion
}
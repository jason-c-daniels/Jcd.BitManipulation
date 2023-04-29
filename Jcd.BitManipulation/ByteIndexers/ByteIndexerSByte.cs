#region

using System;
using System.Collections;
using System.Collections.Generic;

// ReSharper disable UnusedMemberInSuper.Global
// ReSharper disable MemberCanBePrivate.Global

#endregion

namespace Jcd.BitManipulation.ByteIndexers;

/// <summary>
/// Provides byte level indexing operations (set, get) on a SByte. Zero is the least significant byte.
/// This type was provided for completeness sake. It's really not that useful.
/// </summary>
public struct ByteIndexerSByte : IByteIndexer
{
    /// <summary>
    /// The number of bytes this type will index
    /// </summary>
    public const int ByteSize = sizeof(sbyte);

    /// <summary>
    /// Constructs a byte indexer from the underlying data type.
    /// </summary>
    /// <param name="data">The initial value of the data.</param>
    public ByteIndexerSByte(sbyte data = 0)
    {
        Data = data;
    }

    /// <summary>
    /// The length of the data in bytes.
    /// </summary>
    public int Length => ByteSize;

    /// <summary>
    /// The backing store.
    /// </summary>
    public sbyte Data { get; set; }

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
            return (byte)Data;
        }
        set
        {
            if (index is < 0 or >= ByteSize) throw new ArgumentOutOfRangeException(nameof(index));
            Data = (sbyte)value;
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
    public static implicit operator sbyte(ByteIndexerSByte buffer)
    {
        return buffer.Data;
    }

    /// <summary>
    /// Converts the underlying data type to the buffer type.
    /// </summary>
    /// <param name="data">The underlying data type.</param>
    /// <returns>A buffer type.</returns>
    public static implicit operator ByteIndexerSByte(sbyte data)
    {
        return new ByteIndexerSByte(data);
    }

    #region Implementation of IEnumerable

    /// <inheritdoc />
    public IEnumerator<byte> GetEnumerator()
    {
        yield return (byte)Data;
    }

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    #endregion
}
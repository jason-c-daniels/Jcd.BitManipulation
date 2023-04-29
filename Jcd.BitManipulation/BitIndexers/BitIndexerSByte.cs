#region

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation.Possible

#endregion

namespace Jcd.BitManipulation.BitIndexers;

/// <summary>
/// Provides enumeration and indexed access to the bits on a stored sbyte. 
/// </summary>
public struct BitIndexerSByte : IBitIndexer
{
    /// <summary>
    /// The number of bits this type will index
    /// </summary>
    public const int BitSize = 8;

    /// <summary>
    /// The backing store
    /// </summary>
    public sbyte Bits { get; set; }

    /// <summary>
    /// The length of enumerated bits
    /// </summary>
    public int Length => BitSize;

    /// <summary>
    /// Gets or sets individual bits within the backing store. 
    /// </summary>
    /// <param name="index">the offset of the bit to access.</param>
    public bool this[int index]
    {
        get => Bits.ReadBit(index);
        set => Bits = Bits.StoreBit(value, index);
    }

    /// <summary>
    /// Automatically Convert from an sbyte to a BitIndexerSByte
    /// </summary>
    /// <param name="bits">the initial value for the indexer's backing store</param>
    /// <returns>A new BitIndexerSByte</returns>
    public static implicit operator BitIndexerSByte(sbyte bits)
    {
        return new BitIndexerSByte { Bits = bits };
    }

    /// <summary>
    /// Automatically convert from a BitIndexerSByte to an sbyte
    /// </summary>
    /// <param name="indexer">the indexer to convert from</param>
    /// <returns>the sbyte</returns>
    public static implicit operator sbyte(BitIndexerSByte indexer)
    {
        return indexer.Bits;
    }

    /// <summary>
    /// Get an enumerator to enumerate the bits with.
    /// </summary>
    /// <returns>The enumerator</returns>
    public IEnumerator<bool> GetEnumerator()
    {
        for (var index = 0; index < BitSize; index++)
            yield return Bits.ReadBit(index);
    }

    /// <summary>
    /// Get an enumerator to enumerate the bits with.
    /// </summary>
    /// <returns>The enumerator</returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <summary>
    /// Get a subset of bits given a starting offset and length.
    /// </summary>
    /// <param name="start">The starting bit offset</param>
    /// <param name="length">The number of bits to extract</param>
    /// <returns>an array of bools for the subset of bits</returns>
    public bool[] Slice(int start, int length)
    {
        var slice = new bool[length];
        for (var i = 0; i < length; i++) slice[i] = this[i + start];

        return slice;
    }

    /// <summary>
    /// Format as a bit representation
    /// </summary>
    /// <returns>the bits of the value formatted as 0b0101...1111</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("0b");
        foreach (var value in this.Reverse()) sb.Append(value ? '1' : '0');

        return sb.ToString();
    }
}
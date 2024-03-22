#region

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Possible

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Provides enumeration and indexed access to the bits on a stored <see cref="byte" />.
/// </summary>
public struct BitIndexerByte : IBitIndexer
{
   /// <summary>
   /// The number of bits this type will index
   /// </summary>
   public const int BitSize = 8;

   /// <summary>
   /// The backing store
   /// </summary>
   public byte Bits { get; set; }

   /// <summary>
   /// The number of bits indexable by this indexer.
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
   /// Automatically Convert from a <see cref="byte" /> to a BitIndexerByte
   /// </summary>
   /// <param name="bits">the initial value for the indexer's backing store</param>
   /// <returns>A new BitIndexerByte</returns>
   public static implicit operator BitIndexerByte(byte bits)
   {
      return new BitIndexerByte { Bits = bits };
   }

   /// <summary>
   /// Automatically convert from a BitIndexerByte to a <see cref="byte" />
   /// </summary>
   /// <param name="indexer">the indexer to convert from</param>
   /// <returns>the <see cref="byte" /></returns>
   public static implicit operator byte(BitIndexerByte indexer)
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
   /// Gets a subset of bits given a starting offset and length.
   /// </summary>
   /// <param name="start">The starting bit offset</param>
   /// <param name="length">The number of bits to extract</param>
   /// <returns>an array of bools for the subset of bits</returns>
   public bool[] Slice(int start, int length)
   {
      var slice = new bool[length];
      for (var i = 0; i < length; i++)
         slice[i] = this[i + start];

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
      foreach (var value in this.Reverse())
         sb.Append(value ? '1' : '0');

      return sb.ToString();
   }
}
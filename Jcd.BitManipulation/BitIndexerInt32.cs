#region

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Possible

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Provides enumeration and indexed access to the bits on a stored <see cref="int" />.
/// </summary>
[Obsolete("This type is being replaced with BitIndexer in v3.0")]
public struct BitIndexerInt32 : IBitIndexer
{
   /// <summary>
   /// The number of bits this type will index
   /// </summary>
   public const int BitSize = 32;

   /// <summary>
   /// The backing store
   /// </summary>
   public int Bits { get; set; }

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
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get => Bits.ReadBit(index);

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      set => Bits = Bits.StoreBit(value, index);
   }

   /// <summary>
   /// Automatically Convert from an <see cref="int" /> to a BitIndexerInt32
   /// </summary>
   /// <param name="bits">the initial value for the indexer's backing store</param>
   /// <returns>A new BitIndexerInt32</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitIndexerInt32(int bits)
   {
      return new BitIndexerInt32 { Bits = bits };
   }

   /// <summary>
   /// Automatically convert from a BitIndexerInt32 to an <see cref="int" />
   /// </summary>
   /// <param name="indexer">the indexer to convert from</param>
   /// <returns>the <see cref="int" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator int(BitIndexerInt32 indexer)
   {
      return indexer.Bits;
   }

   /// <summary>
   /// Get an enumerator to enumerate the bits with.
   /// </summary>
   /// <returns>The enumerator</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public IEnumerator<bool> GetEnumerator()
   {
      for (var index = 0; index < BitSize; index++)
         yield return Bits.ReadBit(index);
   }

   /// <summary>
   /// Get an enumerator to enumerate the bits with.
   /// </summary>
   /// <returns>The enumerator</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public bool[] Slice(int start, int length)
   {
      var len = length + start > BitSize
                   ? BitSize - start
                   : length;
      var slice = new bool[len];
      var j = start;
      for (var i = 0; i < len; i++, j++)
         slice[i] = Bits.ReadBit(j);

      return slice;
   }

   /// <summary>
   /// Format as a bit representation
   /// </summary>
   /// <returns>the bits of the value formatted as 0b0101...1111</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public override string ToString()
   {
      var sb = new StringBuilder();
      sb.Append("0b");
      foreach (var value in this.Reverse())
         sb.Append(value
                      ? '1'
                      : '0'
                  );

      return sb.ToString();
   }
}
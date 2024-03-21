#region

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

namespace Jcd.BitManipulation.BitIndexers;

/// <summary>
/// Provides enumeration and indexed access to the bits on a stored <see cref="double"/>. 
/// </summary>
public struct BitIndexerDouble : IBitIndexer
{
   /// <summary>
   /// The number of bits this type will index
   /// </summary>
   public const int BitSize = 64;

   private ulong bits;

   /// <summary>
   /// The backing store
   /// </summary>
   public double Bits
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      readonly get => bits.BitwiseToDouble();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      set => bits = value.BitwiseToUInt64();
   }

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
      readonly get => bits.ReadBit(index);

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      set => bits = bits.StoreBit(value, index);
   }

   /// <summary>
   /// Automatically Convert from a <see cref="double"/> to a <see cref="BitIndexerDouble"/>
   /// </summary>
   /// <param name="bits">the initial value for the indexer's backing store</param>
   /// <returns>A new <see cref="BitIndexerDouble"/></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitIndexerDouble(double bits) { return new BitIndexerDouble { Bits = bits }; }

   /// <summary>
   /// Automatically convert from a <see cref="BitIndexerDouble"/> to a <see cref="double"/>
   /// </summary>
   /// <param name="indexer">the indexer to convert from</param>
   /// <returns>the underlying value</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator double(BitIndexerDouble indexer) { return indexer.Bits; }

   /// <summary>
   /// Get an enumerator to enumerate the bits with.
   /// </summary>
   /// <returns>The enumerator</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public readonly IEnumerator<bool> GetEnumerator()
   {
      for (var index = 0; index < BitSize; index++)
         yield return bits.ReadBit(index);
   }

   /// <summary>
   /// Get an enumerator to enumerate the bits with.
   /// </summary>
   /// <returns>The enumerator</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   readonly IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

   /// <summary>
   /// Get a subset of bits given a starting offset and length.
   /// </summary>
   /// <param name="start">The starting bit offset</param>
   /// <param name="length">The number of bits to extract</param>
   /// <returns>an array of bools for the subset of bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public readonly bool[] Slice(int start, int length)
   {
      var slice                                 = new bool[length];
      for (var i = 0; i < length; i++) slice[i] = this[i + start];

      return slice;
   }

   /// <summary>
   /// Format as a bit representation
   /// </summary>
   /// <returns>the bits of the value formatted as 0b0101...1111</returns>
   public readonly override string ToString()
   {
      var sb = new StringBuilder();
      sb.Append("0b");
      foreach (var value in this.Reverse()) sb.Append(value ? '1' : '0');

      return sb.ToString();
   }
}
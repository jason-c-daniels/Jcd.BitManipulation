#region

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global

#endregion

namespace Jcd.BitManipulation.ByteIndexers;

/// <summary>
/// Provides byte level indexing operations (set, get) on a <see cref="float"/>. Zero is the most significant byte.
/// </summary>
public struct BigEndianByteIndexerSingle : IByteIndexer
{
   /// <summary>
   /// The number of bytes this type will index
   /// </summary>
   public const int ByteSize = sizeof(float);

   /// <summary>
   /// The largest <see cref="byte"/> index available.
   /// </summary>
   public const int MaxByteIndex = ByteSize - 1;

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexerSingle"/> from a <see cref="float"/>.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   public BigEndianByteIndexerSingle(float data = 0) { Data = data; }

   /// <summary>
   /// The number of bytes indexable by this indexer.
   /// </summary>
   public int Length => sizeof(float);

   private uint data;

   /// <summary>
   /// The backing store.
   /// </summary>
   public float Data
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get => data.BitwiseToSingle();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      set => data = value.BitwiseToUInt32();
   }

   /// <summary>
   /// Access bytes from the underlying data.
   /// </summary>
   /// <param name="index">The index of the byte to get or set.</param>
   /// <exception cref="ArgumentOutOfRangeException">When index &lt; 0 or gt;= Length</exception>
   public byte this[int index]
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get
      {
         if (index is < 0 or >= ByteSize) throw new ArgumentOutOfRangeException(nameof(index));

         return data.ReadByte(index, Endian.Big);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      set
      {
         if (index is < 0 or >= ByteSize) throw new ArgumentOutOfRangeException(nameof(index));
         data = data.StoreByte(value, index, Endian.Big);
      }
   }

   /// <summary>
   /// Get a subset of bytes given a starting offset and length.
   /// </summary>
   /// <param name="start">The starting bit offset</param>
   /// <param name="length">The number of bits to extract</param>
   /// <returns>an array of bytes for the specified subset</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public readonly byte[] Slice(int start, int length)
   {
      var len   = length + start > ByteSize ? ByteSize - start : length;
      var slice = new byte[len];
      for (var i = 0; i < length; i++)
         slice[i] = data.ReadByte(start + i, Endian.Big);

      return slice;
   }

   /// <summary>
   /// Converts the byte indexer to its underlying data type.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator float(BigEndianByteIndexerSingle indexer) { return indexer.Data; }

   /// <summary>
   /// Converts the underlying data type to the indexer type.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexerSingle(float data) { return new BigEndianByteIndexerSingle(data); }

   #region Implementation of IEnumerable

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public readonly IEnumerator<byte> GetEnumerator()
   {
      for (var i = 0; i < ByteSize; i++) yield return this[i];
   }

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   readonly IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

   #endregion
}
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
/// Provides byte level indexing operations (set, get) on a <see cref="short" />. Zero is the least significant byte.
/// </summary>
public struct LittleEndianByteIndexerInt16 : IByteIndexer
{
   /// <summary>
   /// The number of bytes this type will index
   /// </summary>
   public const int ByteSize = sizeof(short);

   /// <summary>
   /// The largest <see cref="byte" /> index available.
   /// </summary>
   public const int MaxByteIndex = ByteSize - 1;

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexerInt16" /> from an <see cref="short" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public LittleEndianByteIndexerInt16(short data = 0)
   {
      Data = data;
   }

   /// <summary>
   /// The length of the buffer.
   /// </summary>
   public int Length => sizeof(short);

   /// <summary>
   /// The backing store.
   /// </summary>
   public short Data { get; set; }

   /// <summary>
   /// Access bytes from the underlying data.
   /// </summary>
   /// <param name="index">The index of the <see cref="byte" /> to get or set.</param>
   /// <exception cref="ArgumentOutOfRangeException">When index &lt; 0 or gt;= Length</exception>
   public byte this[int index]
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get
      {
         if (index is < 0 or >= ByteSize)
            throw new ArgumentOutOfRangeException(nameof(index));

         return Data.ReadByte(index);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      set
      {
         if (index is < 0 or >= ByteSize)
            throw new ArgumentOutOfRangeException(nameof(index));

         Data = Data.StoreBits(value, index << 3, 8);
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
      var len = length + start > ByteSize
                   ? ByteSize - start
                   : length;
      var slice = new byte[len];
      var j = start;
      for (var i = 0; i < len; i++, j++)
         slice[i] = Data.ReadByte(j);

      return slice;
   }

   /// <summary>
   /// Converts the <see cref="byte" /> indexer to its underlying data type.
   /// </summary>
   /// <param name="buffer">The buffer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator short(LittleEndianByteIndexerInt16 buffer)
   {
      return buffer.Data;
   }

   /// <summary>
   /// Converts the underlying data type to the buffer type.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A buffer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexerInt16(short data)
   {
      return new LittleEndianByteIndexerInt16(data);
   }

   #region Implementation of IEnumerable

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public readonly IEnumerator<byte> GetEnumerator()
   {
      for (var i = 0; i < ByteSize; i++)
         yield return this[i];
   }

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   readonly IEnumerator IEnumerable.GetEnumerator()
   {
      return GetEnumerator();
   }

   #endregion
}
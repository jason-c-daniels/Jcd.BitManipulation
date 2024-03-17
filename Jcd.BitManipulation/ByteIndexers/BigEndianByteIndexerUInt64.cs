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
/// Provides byte level indexing operations (set, get) on a <see cref="UInt64"/>. Zero is the most significant byte.
/// </summary>
public struct BigEndianByteIndexerUInt64 : IByteIndexer
{
   /// <summary>
   /// The number of bytes this type will index
   /// </summary>
   public const int ByteSize = sizeof(ulong);

   /// <summary>
   /// The largest byte index available.
   /// </summary>
   public const int MaxByteIndex = ByteSize - 1;

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexerUInt64"/> from a <see cref="UInt64"/>.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   public BigEndianByteIndexerUInt64(ulong data = 0) { Data = data; }

   static BigEndianByteIndexerUInt64() { IsSystemBigEndian = !BitConverter.IsLittleEndian; }

   public static bool IsSystemBigEndian { get; }

   
   /// <summary>
   /// The length of the indexer.
   /// </summary>
   public int Length => sizeof(ulong);

   /// <summary>
   /// The backing store.
   /// </summary>
   public ulong Data
   {
      get => _data;
      set => _data = value;
   }

   private ulong _data;

   /// <summary>
   /// Access bytes from the underlying data.
   /// </summary>
   /// <param name="index">The index of the byte to get or set. 0 is the least significant byte from the underlying storage.</param>
   /// <exception cref="ArgumentOutOfRangeException">When index &lt; 0 or gt;= Length</exception>
   public byte this[int index]
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get
      {
         if (index is < 0 or >= ByteSize) throw new ArgumentOutOfRangeException(nameof(index));

         return (byte) Data.ReadBits((MaxByteIndex - index) << 3, 8);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      set
      {
         if (index is < 0 or >= ByteSize) throw new ArgumentOutOfRangeException(nameof(index));
         Data = Data.StoreBits(value, (MaxByteIndex - index) << 3, 8);
      }
   }

   /// <summary>
   /// Get a subset of bytes given a starting offset and length.
   /// </summary>
   /// <param name="start">The starting bit offset</param>
   /// <param name="length">The number of bits to extract</param>
   /// <returns>an array of bytes for the specified subset</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public unsafe byte[] Slice(int start, int length)
   {
      var slice = new byte[Math.Min(length, ByteSize)];

      fixed (byte* ps = slice)
      fixed (ulong* pdata = &_data)
      {
         var bytes = (byte*) pdata;
         if (start == 0 && length >= ByteSize)
            CopyAll(bytes, ps);
         else
            CopySubset(start, length, bytes, ps);
      }

      return slice;
   }

   private unsafe void CopyAll(byte* bytes, byte* pslice)
   {
      if (IsSystemBigEndian)
      {
         var pb = bytes;
         for (var i = 0; i < ByteSize; i++, pb++)
            pslice[i] = *pb;
      }
      else
      {
         var rpb = bytes + MaxByteIndex;
         for (var i = 0; i < ByteSize; i++, rpb--)
            pslice[i] = *rpb;
      }
   }

   private unsafe void CopySubset(int start, int length, byte* bytes, byte* pslice)
   {
      if (IsSystemBigEndian)
      {
         var pb = bytes + start;
         for (var i = 0; i < length && i + start < ByteSize; i++, pb++)
            pslice[i] = *pb;
      }
      else
      {
         var rpb = bytes + (MaxByteIndex - start);
         for (var i = 0; i < length && i + start < ByteSize; i++, rpb--)
            pslice[i] = *rpb;
      }
   }

   /// <summary>
   /// Converts the byte indexer to its underlying data type.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator ulong(BigEndianByteIndexerUInt64 indexer) { return indexer.Data; }

   /// <summary>
   /// Converts the underlying data type to the indexer type.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexerUInt64(ulong data)
   {
      return new BigEndianByteIndexerUInt64(data);
   }

   #region Implementation of IEnumerable

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public IEnumerator<byte> GetEnumerator()
   {
      for (var i = 0; i < ByteSize; i++) yield return this[i];
   }

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

   #endregion
}
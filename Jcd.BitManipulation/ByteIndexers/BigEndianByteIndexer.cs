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
public struct BigEndianByteIndexer //: IByteIndexer
   : IEnumerable<byte>
{
   /// <summary>
   /// The number of bytes this type will index
   /// </summary>
   public int ByteSize
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;
   }

   /// <summary>
   /// The largest <see cref="byte"/> index available.
   /// </summary>
   public int MaxByteIndex
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer"/> from a <see cref="UInt64"/>.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BigEndianByteIndexer(ulong data = 0) : this(data, sizeof(ulong)) { }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BigEndianByteIndexer(long data) : this((ulong) data, sizeof(long)) { }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BigEndianByteIndexer(uint data) : this(data, sizeof(uint)) { }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BigEndianByteIndexer(int data) : this((uint) data, sizeof(int)) { }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(ushort data) : this(data, sizeof(ushort)) { }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(short data) : this((ushort) data, sizeof(short)) { }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(byte data) : this(data, sizeof(byte)) { }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(sbyte data) : this((byte) data, sizeof(sbyte)) { }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(float data) : this(BitConverter.ToUInt32(BitConverter.GetBytes(data), 0), sizeof(float)) { }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(double data) : this((ulong) BitConverter.DoubleToInt64Bits(data), sizeof(double)) { }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer"/> from a <see cref="UInt64"/>.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   /// <param name="byteSize">The number of bytes to index</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(ulong data, int byteSize)
   {
      ByteSize     = byteSize;
      MaxByteIndex = ByteSize      - 1;
      Offset       = sizeof(ulong) - ByteSize;
      Data         = data;
   }

   public int Offset { get; }

   /// <summary>
   /// The number of bytes indexable by this indexer.
   /// </summary>
   public int Length => ByteSize;

   /// <summary>
   /// The backing store.
   /// </summary>
   private ulong Data { get; set; }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BigEndianByteIndexer()
   {
      Data         = 0;
      ByteSize     = sizeof(ulong);
      MaxByteIndex = ByteSize - 1;
   }

   /// <summary>
   /// Access bytes from the underlying data.
   /// </summary>
   /// <param name="index">The index of the byte to get or set.</param>
   /// <exception cref="ArgumentOutOfRangeException">When index &lt; 0 or gt;= Length</exception>
   public byte this[int index]
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      readonly get
      {
         if (index is < 0 || index >= ByteSize) throw new ArgumentOutOfRangeException(nameof(index));

         return Data.ReadByte(index + Offset, Endian.Big);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      set
      {
         if (index is < 0 || index >= ByteSize) throw new ArgumentOutOfRangeException(nameof(index));
         Data = Data.StoreByte(value, index + Offset, Endian.Big);
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
      for (var i = 0; i < len; i++)
         slice[i] = Data.ReadByte(i + Offset, Endian.Big);

      return slice;
   }

   /// <summary>
   /// Converts the byte indexer to its underlying data type.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator ulong(BigEndianByteIndexer indexer) { return indexer.Data; }

   /// <summary>
   /// Converts the byte indexer to its underlying data type.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator float(BigEndianByteIndexer indexer) { return BitConverter.ToSingle(BitConverter.GetBytes((uint) indexer.Data), 0); }

   /// <summary>
   /// Converts the byte indexer to its underlying data type.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator double(BigEndianByteIndexer indexer) { return BitConverter.DoubleToInt64Bits((long) indexer.Data); }

   /// <summary>
   /// Converts the byte indexer to its underlying data type.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator byte[](BigEndianByteIndexer indexer) { return indexer.Slice(indexer.Offset, indexer.Length); }

   /// <summary>
   /// Converts the underlying data type to the indexer type.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(ulong data) { return new BigEndianByteIndexer(data); }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(long data) { return new BigEndianByteIndexer(data); }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(uint data) { return new BigEndianByteIndexer(data); }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(int data) { return new BigEndianByteIndexer(data); }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(ushort data) { return new BigEndianByteIndexer(data); }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(short data) { return new BigEndianByteIndexer(data); }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(byte data) { return new BigEndianByteIndexer(data); }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(sbyte data) { return new BigEndianByteIndexer(data); }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(float data) { return new BigEndianByteIndexer(data); }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(double data) { return new BigEndianByteIndexer(data); }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator BigEndianByteIndexer(byte[] data) { return new BigEndianByteIndexer(data.ToUInt64(Endian.Big)); }

   #region Implementation of IEnumerable

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public readonly IEnumerator<byte> GetEnumerator()
   {
      for (var i = 0; i < ByteSize; i++)
         yield return Data.ReadByte(i + Offset, Endian.Big);
   }

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   readonly IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

   #endregion
}
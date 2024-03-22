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
public struct LittleEndianByteIndexer : IEnumerable<byte>
{
   #region Constructors

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer"/> from a <see cref="UInt64"/>.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public LittleEndianByteIndexer(ulong data = 0) : this(data, sizeof(ulong)) { }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer"/> from an <see cref="Int64"/>.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public LittleEndianByteIndexer(long data) : this((ulong) data, sizeof(long)) { }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer"/> from a <see cref="UInt32"/>.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public LittleEndianByteIndexer(uint data) : this(data, sizeof(uint)) { }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer"/> from an <see cref="Int32"/>.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public LittleEndianByteIndexer(int data) : this((uint) data, sizeof(int)) { }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer"/> from a <see cref="UInt16"/>.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(ushort data) : this(data, sizeof(ushort)) { }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer"/> from an <see cref="Int16"/>.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(short data) : this((ushort) data, sizeof(short)) { }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer"/> from a <see cref="Byte"/>.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(byte data) : this(data, sizeof(byte)) { }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer"/> from an <see cref="SByte"/>.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(sbyte data) : this((byte) data, sizeof(sbyte)) { }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer"/> from an <see cref="Single"/>.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(float data) : this(BitConverter.ToUInt32(BitConverter.GetBytes(data), 0), sizeof(float)) { }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer"/> from an <see cref="Double"/>.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(double data) : this((ulong) BitConverter.DoubleToInt64Bits(data), sizeof(double)) { }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer"/> from a <see cref="UInt64"/>.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   /// <param name="byteSize">The number of bytes to index</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(ulong data, int byteSize)
   {
      ByteSize     = byteSize;
      MaxByteIndex = ByteSize - 1;
      Data         = data;
   }

   /// <summary>
   /// Constructs a 64 bit <see cref="LittleEndianByteIndexer"/> defaulted to 0.
   /// </summary>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public LittleEndianByteIndexer()
   {
      Data         = 0;
      ByteSize     = sizeof(ulong);
      MaxByteIndex = ByteSize - 1;
   }

   #endregion

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
   /// The number of bytes indexable by this indexer.
   /// </summary>
   public int Length => ByteSize;

   /// <summary>
   /// The backing store.
   /// </summary>
   private ulong Data { get; set; }

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

         return Data.ReadByte(index, Endian.Little);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      set
      {
         if (index is < 0 || index >= ByteSize) throw new ArgumentOutOfRangeException(nameof(index));
         Data = Data.StoreByte(value, index, Endian.Little);
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
      var j     = start;
      for (var i = 0; i < len; i++, j++)
         slice[i] = Data.ReadByte(j, Endian.Little);

      return slice;
   }

   #region Conversion To Operators

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer"/> to a <see cref="UInt64"/>.
   /// </summary> 
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data as a <see cref="UInt64"/>.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator ulong(LittleEndianByteIndexer indexer) { return indexer.Data; }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer"/> to a <see cref="UInt64"/>.
   /// </summary> 
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator long(LittleEndianByteIndexer indexer) { return (long) indexer.Data; }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer"/> to a <see cref="UInt64"/>.
   /// </summary> 
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator uint(LittleEndianByteIndexer indexer) { return (uint) indexer.Data; }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer"/> to a <see cref="UInt64"/>.
   /// </summary> 
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator int(LittleEndianByteIndexer indexer) { return (int) (uint) indexer.Data; }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer"/> to a <see cref="UInt64"/>.
   /// </summary> 
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator ushort(LittleEndianByteIndexer indexer) { return (ushort) indexer.Data; }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer"/> to a <see cref="UInt64"/>.
   /// </summary> 
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator short(LittleEndianByteIndexer indexer) { return (short) (ushort) indexer.Data; }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer"/> to a <see cref="UInt64"/>.
   /// </summary> 
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator byte(LittleEndianByteIndexer indexer) { return (byte) indexer.Data; }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer"/> to a <see cref="UInt64"/>.
   /// </summary> 
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator sbyte(LittleEndianByteIndexer indexer) { return (sbyte) (byte) indexer.Data; }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer"/> to a <see cref="Single"/>.
   /// </summary> 
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator float(LittleEndianByteIndexer indexer) { return BitConverter.ToSingle(BitConverter.GetBytes((uint) indexer.Data), 0); }

   /// <summary>
   /// Implicitly converts the byte indexer to its underlying data type.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator double(LittleEndianByteIndexer indexer) { return BitConverter.Int64BitsToDouble((long) indexer.Data); }

   /// <summary>
   /// Explicitly converts the <see cref="LittleEndianByteIndexer"/> to an array of bytes. 
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data converted to an array, serialized as big endian.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator byte[](LittleEndianByteIndexer indexer) { return indexer.Slice(0, indexer.Length); }

   #endregion

   #region Conversion From Operators

   /// <summary>
   /// Implicitly converts a <see cref="UInt64"/> to a <see cref="LittleEndianByteIndexer"/>. 
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(ulong data) { return new LittleEndianByteIndexer(data); }

   /// <summary>
   /// Implicitly converts an <see cref="Int64"/> to a <see cref="LittleEndianByteIndexer"/>. 
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(long data) { return new LittleEndianByteIndexer(data); }

   /// <summary>
   /// Implicitly converts a <see cref="UInt32"/> to a <see cref="LittleEndianByteIndexer"/>. 
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(uint data) { return new LittleEndianByteIndexer(data); }

   /// <summary>
   /// Implicitly converts a <see cref="Int32"/> to a <see cref="LittleEndianByteIndexer"/>. 
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(int data) { return new LittleEndianByteIndexer(data); }

   /// <summary>
   /// Implicitly converts a <see cref="UInt16"/> to a <see cref="LittleEndianByteIndexer"/>. 
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(ushort data) { return new LittleEndianByteIndexer(data); }

   /// <summary>
   /// Implicitly converts a <see cref="Int16"/> to a <see cref="LittleEndianByteIndexer"/>. 
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(short data) { return new LittleEndianByteIndexer(data); }

   /// <summary>
   /// Implicitly converts a <see cref="Byte"/> to a <see cref="LittleEndianByteIndexer"/>. 
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(byte data) { return new LittleEndianByteIndexer(data); }

   /// <summary>
   /// Implicitly converts an <see cref="SByte"/> to a <see cref="LittleEndianByteIndexer"/>. 
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(sbyte data) { return new LittleEndianByteIndexer(data); }

   /// <summary>
   /// Implicitly converts a <see cref="Single"/> to a <see cref="LittleEndianByteIndexer"/>. 
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(float data) { return new LittleEndianByteIndexer(data); }

   /// <summary>
   /// Implicitly converts a <see cref="Double"/> to a <see cref="LittleEndianByteIndexer"/>. 
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(double data) { return new LittleEndianByteIndexer(data); }

   /// <summary>
   /// Explicitly converts an array of  bytes to a <see cref="LittleEndianByteIndexer"/>. 
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator LittleEndianByteIndexer(byte[] data) { return new LittleEndianByteIndexer(data.ToUInt64(Endian.Little)); }

   #endregion

   #region Implementation of IEnumerable

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public readonly IEnumerator<byte> GetEnumerator()
   {
      for (var i = 0; i < ByteSize; i++)
         yield return Data.ReadByte(i, Endian.Little);
   }

   /// <inheritdoc />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   readonly IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

   #endregion
}
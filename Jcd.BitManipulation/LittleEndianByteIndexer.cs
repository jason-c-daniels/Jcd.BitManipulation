﻿#region

using System;
using System.Runtime.CompilerServices;
using System.Text;

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Provides byte level indexing operations (set, get) on a <see cref="ulong" />. Zero is the most significant byte.
/// </summary>
public ref struct LittleEndianByteIndexer
{
   #region Constructors

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from a <see cref="ulong" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(ulong data = 0)
      : this(data, sizeof(ulong))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from an <see cref="long" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(long data)
      : this((ulong) data, sizeof(long))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from a <see cref="uint" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(uint data)
      : this(data, sizeof(uint))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from an <see cref="int" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(int data)
      : this((uint) data, sizeof(int))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from a <see cref="ushort" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(ushort data)
      : this(data, sizeof(ushort))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from an <see cref="short" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(short data)
      : this((ushort) data, sizeof(short))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from a <see cref="byte" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(byte data)
      : this(data, sizeof(byte))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from an <see cref="sbyte" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(sbyte data)
      : this((byte) data, sizeof(sbyte))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from an <see cref="float" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(float data)
      : this(data.BitwiseToUInt32(), sizeof(float))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from an <see cref="double" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(double data)
      : this(data.BitwiseToUInt64(), sizeof(double))
   {
   }

   private LittleEndianByteIndexer(byte[] data)
      : this(data, data.Length)
   {
   }

   private LittleEndianByteIndexer(byte[] data, int byteSize)
   {
      ByteSize = GetIntegerByteSize(byteSize);
      StoreBytes(data, 0, byteSize);
   }

   private LittleEndianByteIndexer(ReadOnlySpan<byte> data)
      : this(data, data.Length)
   {
   }

   private LittleEndianByteIndexer(ReadOnlySpan<byte> data, int byteSize)
   {
      ByteSize = GetIntegerByteSize(byteSize);
      StoreBytes(data, 0, byteSize);
   }

   private static int GetIntegerByteSize(int count)
   {
      return count switch
             {
                <= sizeof(byte)   => sizeof(byte)
              , <= sizeof(ushort) => sizeof(ushort)
              , <= sizeof(uint)   => sizeof(uint)
              , _                 => sizeof(ulong)
             };
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from a <see cref="ulong" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   /// <param name="byteSize">The number of bytes to index</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(ulong data, int byteSize)
   {
      ByteSize = byteSize;
      Data = data;
   }

   #endregion

   /// <summary>
   /// The number of bytes this type will index
   /// </summary>
   public int ByteSize
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;
   } = sizeof(ulong);

   /// <summary>
   /// The number of bytes indexable by this indexer.
   /// </summary>
   public int Length => ByteSize;

   /// <summary>
   /// The backing store.
   /// </summary>
   internal ulong Data
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      readonly get;

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      private set;
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
         if (index < 0 || index >= ByteSize)
            throw new ArgumentOutOfRangeException(nameof(index));

         return Data.ReadByte(index);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      set
      {
         if (index < 0 || index >= ByteSize)
            throw new ArgumentOutOfRangeException(nameof(index));

         Data = Data.InternalLittleEndianStoreByte(value, index);
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
      if (start == 0 && length >= ByteSize)
         return GetAllBytes();

      return GetSubset(start, length);
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private readonly byte[] GetAllBytes()
   {
      return ByteSize switch
             {
                8 => [this[0], this[1], this[2], this[3], this[4], this[5], this[6], this[7]]
              , 7 => [this[0], this[1], this[2], this[3], this[4], this[5], this[6]]
              , 6 => [this[0], this[1], this[2], this[3], this[4], this[5]]
              , 5 => [this[0], this[1], this[2], this[3], this[4]]
              , 4 => [this[0], this[1], this[2], this[3]]
              , 3 => [this[0], this[1], this[2]]
              , 2 => [this[0], this[1]]
              , 1 => [(byte) Data]
              , _ => []
             };
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private readonly byte[] GetSubset(int start, int length)
   {
      var len = length + start > ByteSize
                   ? ByteSize - start
                   : length;

      // ReSharper disable once HeapView.ObjectAllocation.Evident
      var slice = new byte[len];
      for (int i = 0, j = start; i < len; i++, j++)
         slice[i] = Data.InternalLittleEndianReadByte(j);

      return slice;
   }

   #region Conversion To Operators

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data as a <see cref="UInt64" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator ulong(LittleEndianByteIndexer indexer)
   {
      return indexer.Data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator long(LittleEndianByteIndexer indexer)
   {
      return (long) indexer.Data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator uint(LittleEndianByteIndexer indexer)
   {
      return (uint) indexer.Data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator int(LittleEndianByteIndexer indexer)
   {
      return (int) (uint) indexer.Data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator ushort(LittleEndianByteIndexer indexer)
   {
      return (ushort) indexer.Data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator short(LittleEndianByteIndexer indexer)
   {
      return (short) (ushort) indexer.Data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator byte(LittleEndianByteIndexer indexer)
   {
      return (byte) indexer.Data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator sbyte(LittleEndianByteIndexer indexer)
   {
      return (sbyte) (byte) indexer.Data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="Single" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator float(LittleEndianByteIndexer indexer)
   {
      return ((uint) indexer.Data).BitwiseToSingle();
   }

   /// <summary>
   /// Implicitly converts the byte indexer to its underlying data type.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator double(LittleEndianByteIndexer indexer)
   {
      return indexer.Data.BitwiseToDouble();
   }

   /// <summary>
   /// Explicitly converts the <see cref="LittleEndianByteIndexer" /> to an array of bytes.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data converted to an array, serialized as big endian.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator byte[](LittleEndianByteIndexer indexer)
   {
      // ReSharper disable RedundantRangeBound
      return indexer[0..^0];

      // ReSharper enable RedundantRangeBound
   }

   /// <summary>
   /// Explicitly converts the <see cref="LittleEndianByteIndexer" /> to an array of bytes.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data converted to an array, serialized as big endian.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator ReadOnlySpan<byte>(LittleEndianByteIndexer indexer)
   {
      return (byte[]) indexer;
   }

   #endregion

   #region Conversion From Operators

   /// <summary>
   /// Implicitly converts a <see cref="UInt64" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(ulong data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts an <see cref="Int64" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(long data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="UInt32" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(uint data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Int32" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(int data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="UInt16" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(ushort data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Int16" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(short data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Byte" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(byte data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts an <see cref="SByte" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(sbyte data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Single" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(float data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Double" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(double data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Explicitly converts an array of  bytes to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator LittleEndianByteIndexer(byte[] data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Explicitly converts an array of  bytes to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator LittleEndianByteIndexer(ReadOnlySpan<byte> data)
   {
      return new LittleEndianByteIndexer(data);
   }

   #endregion

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source to store. -1 means all bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public LittleEndianByteIndexer StoreBytes(byte[] bytes, int offset, int size = -1)
   {
      if (size == -1)
         size = ByteSize - offset;

      var len = size + offset > ByteSize
                   ? ByteSize - offset
                   : size;
      var cnt = Math.Min(len, bytes.Length);

      if (cnt == 0)
         return this;

      Data = Data.InternalLittleEndianStoreByte(bytes[0], offset + 0);

      if (cnt == 1)
         return this;

      Data = Data.InternalLittleEndianStoreByte(bytes[1], offset + 1);

      if (cnt == 2)
         return this;

      Data = Data.InternalLittleEndianStoreByte(bytes[2], offset + 2);

      if (cnt == 3)
         return this;

      Data = Data.InternalLittleEndianStoreByte(bytes[3], offset + 3);

      if (cnt == 4)
         return this;

      Data = Data.InternalLittleEndianStoreByte(bytes[4], offset + 4);

      if (cnt == 5)
         return this;

      Data = Data.InternalLittleEndianStoreByte(bytes[5], offset + 5);

      if (cnt == 6)
         return this;

      Data = Data.InternalLittleEndianStoreByte(bytes[6], offset + 6);

      if (cnt == 7)
         return this;

      Data = Data.InternalLittleEndianStoreByte(bytes[7], offset + 7);

      return this;
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source to store. -1 means all bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public LittleEndianByteIndexer StoreBytes(ReadOnlySpan<byte> bytes, int offset, int size = -1)
   {
      if (size == -1)
         size = ByteSize - offset;

      var len = size + offset > ByteSize
                   ? ByteSize - offset
                   : size;

      var cnt = Math.Min(len, bytes.Length);

      if (cnt == 0)
         return this;

      Data = Data.InternalLittleEndianStoreByte(bytes[0], offset + 0);

      if (cnt == 1)
         return this;

      Data = Data.InternalLittleEndianStoreByte(bytes[1], offset + 1);

      if (cnt == 2)
         return this;

      Data = Data.InternalLittleEndianStoreByte(bytes[2], offset + 2);

      if (cnt == 3)
         return this;

      Data = Data.InternalLittleEndianStoreByte(bytes[3], offset + 3);

      if (cnt == 4)
         return this;

      Data = Data.InternalLittleEndianStoreByte(bytes[4], offset + 4);

      if (cnt == 5)
         return this;

      Data = Data.InternalLittleEndianStoreByte(bytes[5], offset + 5);

      if (cnt == 6)
         return this;

      Data = Data.InternalLittleEndianStoreByte(bytes[6], offset + 6);

      if (cnt == 7)
         return this;

      Data = Data.InternalLittleEndianStoreByte(bytes[7], offset + 7);

      return this;
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public LittleEndianByteIndexer StoreByte(byte @byte, int offset)
   {
      this[offset] = @byte;

      return this;
   }

   /// <summary>
   /// Creates a string of the data formatted as hex for the bytes in big endian notation
   /// </summary>
   /// <returns>a string of the data formatted as hex bytes</returns>
   public readonly override string ToString()
   {
      // ReSharper disable once HeapView.ObjectAllocation.Evident
      var sb = new StringBuilder(ByteSize * 3);

      for (var i = 0; i < ByteSize; i++)
      {
         if (i != 0)
            sb.Append(" ");
         sb.AppendFormat(this[i].ToString("X2"));
      }

      return sb.ToString();
   }
}
#region

using System;
using System.Runtime.CompilerServices;
using System.Text;

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Provides byte level indexing operations (set, get) on the bytes of
/// a copied value. It provides indexer-style access to the bytes of
/// the value. Index zero is the least significant byte.
/// </summary>
/// <include file='XmlDocs/examples.xml' path='/doc/examples/item[@name="ByteIndexerExample"]/example' />
public ref struct LittleEndianByteIndexer
{
   #region Constructors

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from a <see cref="ulong" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(ulong data = 0)
      : this(data, sizeof(ulong))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from a <see cref="long" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(long data)
      : this((ulong) data, sizeof(long))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from a <see cref="uint" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(uint data)
      : this(data, sizeof(uint))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from a <see cref="int" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(int data)
      : this((uint) data, sizeof(int))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from a <see cref="ushort" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(ushort data)
      : this(data, sizeof(ushort))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from a <see cref="short" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(short data)
      : this((ushort) data, sizeof(short))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from a <see cref="byte" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(byte data)
      : this(data, sizeof(byte))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from a <see cref="sbyte" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(sbyte data)
      : this((byte) data, sizeof(sbyte))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from a <see cref="float" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(float data)
      : this(data.BitwiseToUInt32(), sizeof(float))
   {
   }

   /// <summary>
   /// Constructs a <see cref="LittleEndianByteIndexer" /> from a <see cref="double" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
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
      Length = GetIntegerByteSize(byteSize);
      StoreBytes(data, 0, byteSize);
   }

   private LittleEndianByteIndexer(ReadOnlySpan<byte> data)
      : this(data, data.Length)
   {
   }

   private LittleEndianByteIndexer(ReadOnlySpan<byte> data, int byteSize)
   {
      Length = GetIntegerByteSize(byteSize);
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
   /// <param name="data">The initial value for the underlying data.</param>
   /// <param name="byteSize">The number of bytes to index</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private LittleEndianByteIndexer(ulong data, int byteSize)
   {
      Length = byteSize;
      this.data = data;
   }

   #endregion

   /// <summary>
   /// The number of bytes this type will index
   /// </summary>
   public int Length
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get;
   } = sizeof(ulong);

   /// <summary>
   /// The backing store.
   /// </summary>
   /// <exclude />
   private ulong data;

   /// <summary>
   /// Access bytes from the underlying data.
   /// </summary>
   /// <param name="index">The index of the byte to get or set.</param>
   /// <exception cref="ArgumentOutOfRangeException">When index &lt; 0 or &gt;= Length</exception>
   public byte this[int index]
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      readonly get
      {
         if (index < 0 || index >= Length)
            throw new ArgumentOutOfRangeException(nameof(index));

         return data.ReadByte(index);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      set
      {
         if (index < 0 || index >= Length)
            throw new ArgumentOutOfRangeException(nameof(index));

         data = data.InternalLittleEndianStoreByte(value, index);
      }
   }

   /// <summary>
   /// Get a subset of bytes given a starting offset and length.
   /// </summary>
   /// <param name="start">The starting bit offset</param>
   /// <param name="length">The number of bytes to extract</param>
   /// <returns>An array of bytes for the specified subset.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public readonly byte[] Slice(int start, int length)
   {
      if (start == 0 && length >= Length)
         return GetAllBytes();

      return GetSubset(start, length);
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private readonly byte[] GetAllBytes()
   {
      return Length switch
             {
                8 => [this[0], this[1], this[2], this[3], this[4], this[5], this[6], this[7]]
              , 7 => [this[0], this[1], this[2], this[3], this[4], this[5], this[6]]
              , 6 => [this[0], this[1], this[2], this[3], this[4], this[5]]
              , 5 => [this[0], this[1], this[2], this[3], this[4]]
              , 4 => [this[0], this[1], this[2], this[3]]
              , 3 => [this[0], this[1], this[2]]
              , 2 => [this[0], this[1]]
              , 1 => [(byte) data]
              , _ => []
             };
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private readonly byte[] GetSubset(int start, int length)
   {
      var len = length + start > Length
                   ? Length - start
                   : length;

      // ReSharper disable once HeapView.ObjectAllocation.Evident
      var slice = new byte[len];
      for (int i = 0, j = start; i < len; i++, j++)
         slice[i] = data.InternalLittleEndianReadByte(j);

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
      return indexer.data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator long(LittleEndianByteIndexer indexer)
   {
      return (long) indexer.data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator uint(LittleEndianByteIndexer indexer)
   {
      return (uint) indexer.data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator int(LittleEndianByteIndexer indexer)
   {
      return (int) (uint) indexer.data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator ushort(LittleEndianByteIndexer indexer)
   {
      return (ushort) indexer.data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator short(LittleEndianByteIndexer indexer)
   {
      return (short) (ushort) indexer.data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator byte(LittleEndianByteIndexer indexer)
   {
      return (byte) indexer.data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator sbyte(LittleEndianByteIndexer indexer)
   {
      return (sbyte) (byte) indexer.data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="LittleEndianByteIndexer" /> to a <see cref="Single" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator float(LittleEndianByteIndexer indexer)
   {
      return ((uint) indexer.data).BitwiseToSingle();
   }

   /// <summary>
   /// Implicitly converts the byte indexer to its underlying data type.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator double(LittleEndianByteIndexer indexer)
   {
      return indexer.data.BitwiseToDouble();
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
   /// <param name="data">The initial value for the bytes of data.</param>
   /// />
   /// <returns>A new <see cref="LittleEndianByteIndexer" /> instance.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(ulong data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="long" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// />
   /// <returns>A new <see cref="LittleEndianByteIndexer" /> instance.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(long data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="UInt32" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// />
   /// <returns>A new <see cref="LittleEndianByteIndexer" /> instance.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(uint data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Int32" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// />
   /// <returns>A new <see cref="LittleEndianByteIndexer" /> instance.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(int data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="UInt16" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// />
   /// <returns>A new <see cref="LittleEndianByteIndexer" /> instance.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(ushort data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Int16" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// />
   /// <returns>A new <see cref="LittleEndianByteIndexer" /> instance.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(short data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Byte" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// />
   /// <returns>A new <see cref="LittleEndianByteIndexer" /> instance.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(byte data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="sbyte" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// />
   /// <returns>A new <see cref="LittleEndianByteIndexer" /> instance.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(sbyte data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Single" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// />
   /// <returns>A new <see cref="LittleEndianByteIndexer" /> instance.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(float data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Double" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// />
   /// <returns>A new <see cref="LittleEndianByteIndexer" /> instance.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator LittleEndianByteIndexer(double data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Explicitly converts an array of  bytes to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// />
   /// <returns>A new <see cref="LittleEndianByteIndexer" /> instance.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator LittleEndianByteIndexer(byte[] data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Explicitly converts an array of  bytes to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// />
   /// <returns>A new <see cref="LittleEndianByteIndexer" /> instance.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator LittleEndianByteIndexer(ReadOnlySpan<byte> data)
   {
      return new LittleEndianByteIndexer(data);
   }

   /// <summary>
   /// Explicitly converts a <see cref="BigEndianByteIndexer" /> to a <see cref="LittleEndianByteIndexer" />.
   /// </summary>
   /// <param name="indexer">The <see cref="BigEndianByteIndexer" /> to copy the data from.</param>
   /// <returns>A new <see cref="LittleEndianByteIndexer" /> instance.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator LittleEndianByteIndexer(BigEndianByteIndexer indexer)
   {
      return new LittleEndianByteIndexer(indexer, indexer.Length);
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
         size = Length - offset;

      var len = size + offset > Length
                   ? Length - offset
                   : size;
      var cnt = Math.Min(len, bytes.Length);

      if (cnt == 0)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[0], offset + 0);

      if (cnt == 1)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[1], offset + 1);

      if (cnt == 2)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[2], offset + 2);

      if (cnt == 3)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[3], offset + 3);

      if (cnt == 4)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[4], offset + 4);

      if (cnt == 5)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[5], offset + 5);

      if (cnt == 6)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[6], offset + 6);

      if (cnt == 7)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[7], offset + 7);

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
         size = Length - offset;

      var len = size + offset > Length
                   ? Length - offset
                   : size;

      var cnt = Math.Min(len, bytes.Length);

      if (cnt == 0)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[0], offset + 0);

      if (cnt == 1)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[1], offset + 1);

      if (cnt == 2)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[2], offset + 2);

      if (cnt == 3)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[3], offset + 3);

      if (cnt == 4)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[4], offset + 4);

      if (cnt == 5)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[5], offset + 5);

      if (cnt == 6)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[6], offset + 6);

      if (cnt == 7)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[7], offset + 7);

      return this;
   }

   /// <summary>
   /// Stores a single byte to the value at the specified byte offset and returns the modified value.
   /// </summary>
   /// <param name="byte">The <see cref="byte" /> value to store.</param>
   /// <param name="offset">The offset of where to store the byte.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public LittleEndianByteIndexer StoreByte(byte @byte, int offset)
   {
      this[offset] = @byte;

      return this;
   }

   /// <summary>
   /// Formats the <see cref="LittleEndianByteIndexer" /> as a hexadecimal string in big endian notation.
   /// For example: `DE C0 0D 60`
   /// </summary>
   /// <returns>a string of the data formatted as hex bytes</returns>
   public readonly override string ToString()
   {
      // ReSharper disable once HeapView.ObjectAllocation.Evident
      var sb = new StringBuilder(Length * 3);

      for (var i = 0; i < Length; i++)
      {
         if (i != 0)
            sb.Append(" ");
         sb.AppendFormat(this[i].ToString("X2"));
      }

      return sb.ToString();
   }
}
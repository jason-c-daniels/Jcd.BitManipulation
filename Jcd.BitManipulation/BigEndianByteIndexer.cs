#region

using System;
using System.Runtime.CompilerServices;
using System.Text;

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Provides byte level indexing operations (set, get) on a <see cref="ulong" />. Zero is the most significant byte.
/// </summary>
public ref struct BigEndianByteIndexer
{
   #region Constructors

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="ulong" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(ulong data = 0)
      : this(data, sizeof(ulong))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from an <see cref="long" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(long data)
      : this((ulong) data, sizeof(long))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="uint" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(uint data)
      : this(data, sizeof(uint))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from an <see cref="int" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(int data)
      : this((uint) data, sizeof(int))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="ushort" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(ushort data)
      : this(data, sizeof(ushort))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from an <see cref="short" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(short data)
      : this((ushort) data, sizeof(short))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="byte" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(byte data)
      : this(data, sizeof(byte))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from an <see cref="sbyte" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(sbyte data)
      : this((byte) data, sizeof(sbyte))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from an <see cref="float" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(float data)
      : this(BitConverter.ToUInt32(BitConverter.GetBytes(data), 0), sizeof(float))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from an <see cref="Double" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(double data)
      : this((ulong) BitConverter.DoubleToInt64Bits(data), sizeof(double))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="UInt64" />.
   /// </summary>
   /// <param name="data"> The initial value of the underlying data.</param>
   /// <param name="byteSize">The number of bytes to index</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(ulong data, int byteSize)
   {
      ByteSize = byteSize;
      dataOffset = sizeof(ulong) - ByteSize;
      Data = data;
   }

   #endregion

   private readonly int dataOffset;

   private BigEndianByteIndexer(ReadOnlySpan<byte> data)
      : this(data, GetIntegerByteSize(data.Length))
   {
   }

   private BigEndianByteIndexer(ReadOnlySpan<byte> data, int byteSize)
   {
      ByteSize = byteSize;

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
   internal ulong Data { get; private set; }

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

         return Data.ReadByte(index + dataOffset, Endian.Big);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      set
      {
         if (index < 0 || index >= ByteSize)
            throw new ArgumentOutOfRangeException(nameof(index));

         Data = Data.StoreByte(value, index + dataOffset, Endian.Big);
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

      // ReSharper disable once HeapView.ObjectAllocation.Evident
      var slice = new byte[len];
      var j = dataOffset + start;
      for (var i = 0; i < len; i++, j++)
         slice[i] = Data.ReadByte(j, Endian.Big);

      return slice;
   }

   #region Conversion To Operators

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data as a <see cref="UInt64" />.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator ulong(BigEndianByteIndexer indexer)
   {
      return indexer.Data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator long(BigEndianByteIndexer indexer)
   {
      return (long) indexer.Data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator uint(BigEndianByteIndexer indexer)
   {
      return (uint) indexer.Data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator int(BigEndianByteIndexer indexer)
   {
      return (int) (uint) indexer.Data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator ushort(BigEndianByteIndexer indexer)
   {
      return (ushort) indexer.Data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator short(BigEndianByteIndexer indexer)
   {
      return (short) (ushort) indexer.Data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator byte(BigEndianByteIndexer indexer)
   {
      return (byte) indexer.Data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="UInt64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator sbyte(BigEndianByteIndexer indexer)
   {
      return (sbyte) (byte) indexer.Data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="Single" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator float(BigEndianByteIndexer indexer)
   {
      return BitConverter.ToSingle(BitConverter.GetBytes((uint) indexer.Data), 0);
   }

   /// <summary>
   /// Implicitly converts the byte indexer to its underlying data type.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator double(BigEndianByteIndexer indexer)
   {
      return BitConverter.Int64BitsToDouble((long) indexer.Data);
   }

   /// <summary>
   /// Explicitly converts the <see cref="BigEndianByteIndexer" /> to an array of bytes.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data converted to an array, serialized as big endian.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator byte[](BigEndianByteIndexer indexer)
   {
      // ReSharper disable RedundantRangeBound -- false positive
      return indexer[0..^0];
      // ReSharper enable RedundantRangeBound -- false positive
   }

   /// <summary>
   /// Explicitly converts the <see cref="BigEndianByteIndexer" /> to an array of bytes.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data converted to an array, serialized as big endian.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator ReadOnlySpan<byte>(BigEndianByteIndexer indexer)
   {
      return (byte[]) indexer;
   }

   #endregion

   #region Conversion From Operators

   /// <summary>
   /// Implicitly converts a <see cref="UInt64" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(ulong data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts an <see cref="Int64" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(long data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="UInt32" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(uint data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Int32" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(int data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="UInt16" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(ushort data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Int16" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(short data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Byte" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(byte data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts an <see cref="SByte" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(sbyte data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Single" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(float data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Double" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(double data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Explicitly converts an array of  bytes to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator BigEndianByteIndexer(byte[] data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Explicitly converts an array of  bytes to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The underlying data type.</param>
   /// <returns>A indexer type.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator BigEndianByteIndexer(ReadOnlySpan<byte> data)
   {
      return new BigEndianByteIndexer(data);
   }
   #endregion

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BigEndianByteIndexer StoreBytes(byte[] bytes, int offset, int size = -1)
   {
      if (size == -1)
         size = ByteSize - offset;

      var len = size + offset > ByteSize
                   ? ByteSize - offset
                   : size;

      var j = offset;
      for (var i = 0; i < len; i++, j++)
         this[j] = bytes[i];

      return this;
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BigEndianByteIndexer StoreBytes(ReadOnlySpan<byte> bytes, int offset, int size = -1)
   {
      if (size == -1)
         size = ByteSize - offset;

      var len = size + offset > ByteSize
                   ? ByteSize - offset
                   : size;

      var j = offset;
      for (var i = 0; i < len; i++, j++)
         this[j] = bytes[i];

      return this;
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BigEndianByteIndexer StoreByte(byte @byte, int offset)
   {
      this[offset] = @byte;

      return this;
   }

   /// <summary>
   /// Creates a string of the data formatted as hex for the bytes in big endian notation
   /// </summary>
   /// <returns>a string of the data formatted as hex bytes</returns>
   public override string ToString()
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
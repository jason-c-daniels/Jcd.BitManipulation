#region

using System;
using System.Runtime.CompilerServices;
using System.Text;

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Provides byte level indexing operations (set, get) on the bytes of
/// a copied value. It provides indexer-style access to the bytes of
/// the value. Index zero is the most significant byte.
/// </summary>
public ref struct BigEndianByteIndexer
{
   #region Constructors

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="ulong" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(ulong data = 0)
      : this(data, sizeof(ulong))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="long" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(long data)
      : this((ulong) data, sizeof(long))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="uint" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(uint data)
      : this(data, sizeof(uint))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="int" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(int data)
      : this((uint) data, sizeof(int))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="ushort" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(ushort data)
      : this(data, sizeof(ushort))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="short" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(short data)
      : this((ushort) data, sizeof(short))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="byte" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(byte data)
      : this(data, sizeof(byte))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="sbyte" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(sbyte data)
      : this((byte) data, sizeof(sbyte))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="float" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(float data)
      : this(data.BitwiseToUInt32(), sizeof(float))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="double" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(double data)
      : this(data.BitwiseToUInt64(), sizeof(double))
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="ulong" />.
   /// </summary>
   /// <param name="data">The initial value for the underlying data.</param>
   /// <param name="byteSize">The number of bytes to index</param>
   /// <exclude />
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   private BigEndianByteIndexer(ulong data, int byteSize)
   {
      Length = byteSize;
      dataOffset = sizeof(ulong) - Length;
      this.data = data;
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="ReadOnlySpan{T}" /> of bytes.
   /// </summary>
   /// <param name="data">The span to populate the underlying data from.</param>
   /// <exclude />
   private BigEndianByteIndexer(ReadOnlySpan<byte> data)
      : this(data, data.Length)
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="ReadOnlySpan{T}" /> of bytes.
   /// </summary>
   /// <param name="data">The span to populate the underlying data from.</param>
   /// <param name="byteSize">The number of bytes to store from the <see cref="ReadOnlySpan{T}" /></param>
   /// <exclude />
   private BigEndianByteIndexer(ReadOnlySpan<byte> data, int byteSize)
   {
      Length = GetIntegerByteSize(byteSize);
      this.data = data.ToUInt64(Endian.Big);
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="Array" /> of bytes.
   /// </summary>
   /// <param name="data">The span to populate the underlying data from.</param>
   /// <exclude />
   private BigEndianByteIndexer(byte[] data)
      : this(data, data.Length)
   {
   }

   /// <summary>
   /// Constructs a <see cref="BigEndianByteIndexer" /> from a <see cref="Array" /> of bytes.
   /// </summary>
   /// <param name="data">The span to populate the underlying data from.</param>
   /// <param name="byteSize">The number of bytes to store from the <see cref="Array" /></param>
   /// <exclude />
   private BigEndianByteIndexer(byte[] data, int byteSize)
   {
      Length = GetIntegerByteSize(byteSize);
      this.data = data.ToUInt64(Endian.Big);
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

   #endregion

   private readonly int dataOffset;

   /// <summary>
   /// The number of indexable bytes.
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
   /// <exception cref="ArgumentOutOfRangeException">When index &lt; 0 or gt;= Length</exception>
   public byte this[int index]
   {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      readonly get
      {
         if (index < 0 || index >= Length)
            throw new ArgumentOutOfRangeException(nameof(index));

         return data.ReadByte(index + dataOffset, Endian.Big);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      set
      {
         if (index < 0 || index >= Length)
            throw new ArgumentOutOfRangeException(nameof(index));

         data = data.InternalBigEndianStoreByte(value, index + dataOffset);
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
      for (int i = 0, j = dataOffset + start; i < len; i++, j++)
         slice[i] = data.InternalBigEndianReadByte(j);

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
      return indexer.data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="Int64" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator long(BigEndianByteIndexer indexer)
   {
      return (long) indexer.data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="UInt32" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator uint(BigEndianByteIndexer indexer)
   {
      return (uint) indexer.data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="Int32" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator int(BigEndianByteIndexer indexer)
   {
      return (int) (uint) indexer.data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="UInt16" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator ushort(BigEndianByteIndexer indexer)
   {
      return (ushort) indexer.data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="Int16" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator short(BigEndianByteIndexer indexer)
   {
      return (short) (ushort) indexer.data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="Byte" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator byte(BigEndianByteIndexer indexer)
   {
      return (byte) indexer.data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="SByte" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator sbyte(BigEndianByteIndexer indexer)
   {
      return (sbyte) (byte) indexer.data;
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="Single" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator float(BigEndianByteIndexer indexer)
   {
      return ((uint) indexer.data).BitwiseToSingle();
   }

   /// <summary>
   /// Implicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="Double" />.
   /// </summary>
   /// <param name="indexer">The indexer to convert.</param>
   /// <returns>The raw data.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator double(BigEndianByteIndexer indexer)
   {
      return indexer.data.BitwiseToDouble();
   }

   /// <summary>
   /// Explicitly converts the <see cref="BigEndianByteIndexer" /> to a array of bytes.
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
   /// Explicitly converts the <see cref="BigEndianByteIndexer" /> to a <see cref="ReadOnlySpan{T}" /> of bytes.
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
   /// <param name="data">The initial data for the indexer.</param>
   /// <returns>The newly created <see cref="BigEndianByteIndexer" />.</returns>
   /// <example>
   /// <para>
   /// Example:
   /// </para>
   /// <code>
   /// ulong number = 0xDEADBEEFFA17C0DE;
   /// BigEndianByteIndexer indexer = number; // implicit cast.
   /// 
   /// var b0 = indexer[0]; // b0 is 0xDE
   /// indexer[1] = 0xFF;
   /// var result = indexer.ToString(); // result is "DE FF BE EF FA 17 C0 DE"
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(ulong data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Int64" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// <returns>The newly created <see cref="BigEndianByteIndexer" />.</returns>
   /// <example>
   /// <para>
   /// Example:
   /// </para>
   /// <code>
   /// long number = 0x7EADBEEFFA17C0DE;
   /// BigEndianByteIndexer indexer = number; // implicit cast.
   /// 
   /// var b0 = indexer[0]; // b0 is 0x7E
   /// indexer[1] = 0xFF;
   /// var result = indexer.ToString(); // result is "7E FF BE EF FA 17 C0 DE"
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(long data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="UInt32" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// <returns>The newly created <see cref="BigEndianByteIndexer" />.</returns>
   /// <example>
   /// <para>
   /// Example:
   /// </para>
   /// <code>
   /// uint number = 0xDEADBEEF;
   /// BigEndianByteIndexer indexer = number; // implicit cast.
   /// 
   /// var b0 = indexer[0]; // b0 is 0xDE
   /// indexer[1] = 0xFF;
   /// var result = indexer.ToString(); // result is "DE FF BE EF"
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(uint data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Int32" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// <returns>The <see cref="BigEndianByteIndexer" /> instance.</returns>
   /// <example>
   /// <para>
   /// Example:
   /// </para>
   /// <code>
   /// int number = 0x7EADBEEF;
   /// BigEndianByteIndexer indexer = number; // implicit cast.
   /// 
   /// var b0 = indexer[0]; // b0 is 0xDE
   /// indexer[1] = 0xFF;
   /// var result = indexer.ToString(); // result is "7E FF BE EF"
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(int data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="UInt16" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// <returns>The <see cref="BigEndianByteIndexer" /> instance.</returns>
   /// <example>
   /// <para>
   /// Example:
   /// </para>
   /// <code>
   /// ushort number = 0xDEAD;
   /// BigEndianByteIndexer indexer = number; // implicit cast.
   /// 
   /// var b0 = indexer[0]; // b0 is 0xDE
   /// indexer[1] = 0xFF;
   /// var result = indexer.ToString(); // result is "DE FF"
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(ushort data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Int16" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// <returns>The <see cref="BigEndianByteIndexer" /> instance.</returns>
   /// <example>
   /// <para>
   /// Example:
   /// </para>
   /// <code>
   /// short number = 0x7EAD;
   /// BigEndianByteIndexer indexer = number; // implicit cast.
   /// 
   /// var b0 = indexer[0]; // b0 is 0xDE
   /// indexer[1] = 0xFF;
   /// var result = indexer.ToString(); // result is "7E FF"
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(short data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Byte" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// <returns>The <see cref="BigEndianByteIndexer" /> instance.</returns>
   /// <example>
   /// <para>
   /// Example:
   /// </para>
   /// <code>
   /// byte number = 0xDE;
   /// BigEndianByteIndexer indexer = number; // implicit cast.
   /// 
   /// var b0 = indexer[0]; // b0 is 0xDE
   /// indexer[0] = 0xFF;
   /// var result = indexer.ToString(); // result is "FF"
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(byte data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="SByte" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// <returns>The <see cref="BigEndianByteIndexer" /> instance.</returns>
   /// <example>
   /// <para>
   /// Example:
   /// </para>
   /// <code>
   /// sbyte number = 0xDE;
   /// BigEndianByteIndexer indexer = number; // implicit cast.
   /// 
   /// var b0 = indexer[0]; // b0 is 0xDE
   /// indexer[0] = 0xFF;
   /// var result = indexer.ToString(); // result is "FF"
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(sbyte data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Single" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// <returns>The <see cref="BigEndianByteIndexer" /> instance.</returns>
   /// <example>
   /// <para>
   /// Example:
   /// </para>
   /// <code>
   /// float number = -6.259853398707798016E18f; // 0xDEADBEEF
   /// BigEndianByteIndexer indexer = number; // implicit cast.
   /// 
   /// var b0 = indexer[0]; // b0 is 0xDE
   /// indexer[1] = 0xFF;
   /// var result = indexer.ToString(); // result is "DE FF BE EF"
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(float data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Implicitly converts a <see cref="Double" /> to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// <returns>The <see cref="BigEndianByteIndexer" /> instance.</returns>
   /// <example>
   /// <para>
   /// Example:
   /// </para>
   /// <code>
   /// var number = -1.1885959909993540014504278736E148; // 0xDEADBEEFFA17C0DE
   /// BigEndianByteIndexer indexer = number;    // implicit cast.
   /// 
   /// var b0_1 = indexer[0]; // b0 is 0xDE
   /// indexer[1] = 0xFF;
   /// var result = indexer.ToString(); // result is "DE FF BE EF FA 17 C0 DE"
   /// </code>
   /// </example>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BigEndianByteIndexer(double data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Explicitly converts an array of  bytes to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// <returns>The <see cref="BigEndianByteIndexer" /> instance.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static explicit operator BigEndianByteIndexer(byte[] data)
   {
      return new BigEndianByteIndexer(data);
   }

   /// <summary>
   /// Explicitly converts an array of  bytes to a <see cref="BigEndianByteIndexer" />.
   /// </summary>
   /// <param name="data">The initial value for the bytes of data.</param>
   /// <returns>The <see cref="BigEndianByteIndexer" /> instance.</returns>
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
         size = Length - offset;

      var len = size + offset > Length
                   ? Length - offset
                   : size;

      var cnt = Math.Min(len, bytes.Length);

      if (cnt == 0)
         return this;

      var o = sizeof(ulong) - 1 - offset - dataOffset;
      data = data.InternalLittleEndianStoreByte(bytes[0], o);

      if (cnt == 1)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[1], o - 1);

      if (cnt == 2)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[2], o - 2);

      if (cnt == 3)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[3], o - 3);

      if (cnt == 4)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[4], o - 4);

      if (cnt == 5)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[5], o - 5);

      if (cnt == 6)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[6], o - 6);

      if (cnt == 7)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[7], o - 7);

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
         size = Length - offset;

      var len = size + offset > Length
                   ? Length - offset
                   : size;

      var cnt = Math.Min(len, bytes.Length);

      if (cnt == 0)
         return this;

      var o = sizeof(ulong) - 1 - offset - dataOffset;
      data = data.InternalLittleEndianStoreByte(bytes[0], o);

      if (cnt == 1)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[1], o - 1);

      if (cnt == 2)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[2], o - 2);

      if (cnt == 3)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[3], o - 3);

      if (cnt == 4)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[4], o - 4);

      if (cnt == 5)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[5], o - 5);

      if (cnt == 6)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[6], o - 6);

      if (cnt == 7)
         return this;

      data = data.InternalLittleEndianStoreByte(bytes[7], o - 7);

      return this;
   }

   /// <summary>
   /// Stores a single byte to the value at the specified byte offset and returns the modified value.
   /// </summary>
   /// <param name="byte">The <see cref="byte" /> value to store.</param>
   /// <param name="offset">The offset of where to store the byte.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BigEndianByteIndexer StoreByte(byte @byte, int offset)
   {
      this[offset] = @byte;

      return this;
   }

   /// <summary>
   /// Formats the <see cref="BigEndianByteIndexer" />> as a hexadecimal string in big endian notation.
   /// For example: `60 0D C0 DE`
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
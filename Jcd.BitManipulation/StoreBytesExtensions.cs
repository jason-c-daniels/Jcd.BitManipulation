#region

using System;
using System.Runtime.CompilerServices;

using Jcd.BitManipulation.ByteIndexers;

// ReSharper disable UnusedMethodReturnValue.Global
// ReSharper disable UnusedMemberInSuper.Global
// ReSharper disable MemberCanBePrivate.Global

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Extension methods that aid in storing values into byte offsets within another integer data type.
/// </summary>
public static class StoreBytesExtensions
{
   #region StoreBytes to integral data type from ReadOnlySpan of bytes.

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the value.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short StoreBytes(
      this short         value
    , ReadOnlySpan<byte> bytes
    , int                offset
    , int                size   = -1
    , Endian             endian = Endian.Little
   )
   {
      return endian == Endian.Big
                ? ((BigEndianByteIndexerInt16) value).StoreBytes(bytes, offset, size)
                : ((LittleEndianByteIndexerInt16) value).StoreBytes(bytes, offset, size);
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the value.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int StoreBytes(
      this int           value
    , ReadOnlySpan<byte> bytes
    , int                offset
    , int                size   = -1
    , Endian             endian = Endian.Little
   )
   {
      return endian == Endian.Big
                ? ((BigEndianByteIndexerInt32) value).StoreBytes(bytes, offset, size)
                : ((LittleEndianByteIndexerInt32) value).StoreBytes(bytes, offset, size);
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the value.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long StoreBytes(
      this long          value
    , ReadOnlySpan<byte> bytes
    , int                offset
    , int                size   = -1
    , Endian             endian = Endian.Little
   )
   {
      return endian == Endian.Big
                ? ((BigEndianByteIndexerInt64) value).StoreBytes(bytes, offset, size)
                : ((LittleEndianByteIndexerInt64) value).StoreBytes(bytes, offset, size);
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the value.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort StoreBytes(
      this ushort        value
    , ReadOnlySpan<byte> bytes
    , int                offset
    , int                size   = -1
    , Endian             endian = Endian.Little
   )
   {
      return endian == Endian.Big
                ? ((BigEndianByteIndexerUInt16) value).StoreBytes(bytes, offset, size)
                : ((LittleEndianByteIndexerUInt16) value).StoreBytes(bytes, offset, size);
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the value.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint StoreBytes(
      this uint          value
    , ReadOnlySpan<byte> bytes
    , int                offset
    , int                size   = -1
    , Endian             endian = Endian.Little
   )
   {
      return endian == Endian.Big
                ? ((BigEndianByteIndexerUInt32) value).StoreBytes(bytes, offset, size)
                : ((LittleEndianByteIndexerUInt32) value).StoreBytes(bytes, offset, size);
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the value.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong StoreBytes(
      this ulong         value
    , ReadOnlySpan<byte> bytes
    , int                offset
    , int                size   = -1
    , Endian             endian = Endian.Little
   )
   {
      return endian == Endian.Big
                ? ((BigEndianByteIndexerUInt64) value).StoreBytes(bytes, offset, size)
                : ((LittleEndianByteIndexerUInt64) value).StoreBytes(bytes, offset, size);
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the value.
   /// Byte indexing is LSB, least significant byte, at index/offset zero.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float StoreBytes(
      this float         value
    , ReadOnlySpan<byte> bytes
    , int                offset
    , int                size   = -1
    , Endian             endian = Endian.Little
   )
   {
      return value
            .BitwiseToUInt32()
            .StoreBytes(bytes, offset, size, endian)
            .BitwiseToSingle();
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the value.
   /// Byte indexing is LSB, least significant byte, at index/offset zero.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static double StoreBytes(
      this double        value
    , ReadOnlySpan<byte> bytes
    , int                offset
    , int                size   = -1
    , Endian             endian = Endian.Little
   )
   {
      return value
            .BitwiseToUInt64()
            .StoreBytes(bytes, offset, size, endian)
            .BitwiseToDouble();
   }

   #endregion

   #region StoreBytes to IByteIndexer types from ReadOnlySpan of byte

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source to store. -1 means all bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static LittleEndianByteIndexerInt16 StoreBytes(
      this LittleEndianByteIndexerInt16 indexer
    , ReadOnlySpan<byte>                bytes
    , int                               offset
    , int                               size = -1
   )
   {
      if (size == -1 || size > bytes.Length) size = bytes.Length;
      var idx                                     = 0;

      foreach (var @byte in bytes)
      {
         if (idx          >= size) return indexer;
         if (offset + idx >= LittleEndianByteIndexerInt16.ByteSize) return indexer;
         indexer[idx + offset] = @byte;
         idx++;
      }

      return indexer;
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BigEndianByteIndexerInt16 StoreBytes(
      this BigEndianByteIndexerInt16 indexer
    , ReadOnlySpan<byte>             bytes
    , int                            offset
    , int                            size = -1
   )
   {
      if (size == -1 || size > bytes.Length) size = bytes.Length;
      var idx                                     = 0;

      foreach (var @byte in bytes)
      {
         if (idx          >= size) return indexer;
         if (offset + idx >= LittleEndianByteIndexerInt16.ByteSize) return indexer;
         indexer[idx + offset] = @byte;
         idx++;
      }

      return indexer;
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static LittleEndianByteIndexerUInt16 StoreBytes(
      this LittleEndianByteIndexerUInt16 indexer
    , ReadOnlySpan<byte>                 bytes
    , int                                offset
    , int                                size = -1
   )
   {
      if (size == -1 || size > bytes.Length) size = bytes.Length;
      var idx                                     = 0;

      foreach (var @byte in bytes)
      {
         if (idx          >= size) return indexer;
         if (offset + idx >= LittleEndianByteIndexerUInt16.ByteSize) return indexer;

         indexer[idx + offset] = @byte;
         idx++;
      }

      return indexer;
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BigEndianByteIndexerUInt16 StoreBytes(
      this BigEndianByteIndexerUInt16 indexer
    , ReadOnlySpan<byte>              bytes
    , int                             offset
    , int                             size = -1
   )
   {
      if (size == -1 || size > bytes.Length) size = bytes.Length;
      var idx                                     = 0;

      foreach (var @byte in bytes)
      {
         if (idx          >= size) return indexer;
         if (offset + idx >= LittleEndianByteIndexerUInt16.ByteSize) return indexer;

         indexer[idx + offset] = @byte;
         idx++;
      }

      return indexer;
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static LittleEndianByteIndexerInt32 StoreBytes(
      this LittleEndianByteIndexerInt32 indexer
    , ReadOnlySpan<byte>                bytes
    , int                               offset
    , int                               size = -1
   )
   {
      if (size == -1 || size > bytes.Length) size = bytes.Length;
      var idx                                     = 0;

      foreach (var @byte in bytes)
      {
         if (idx          >= size) return indexer;
         if (offset + idx >= LittleEndianByteIndexerInt32.ByteSize) return indexer;

         indexer[idx + offset] = @byte;
         idx++;
      }

      return indexer;
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BigEndianByteIndexerInt32 StoreBytes(
      this BigEndianByteIndexerInt32 indexer
    , ReadOnlySpan<byte>             bytes
    , int                            offset
    , int                            size = -1
   )
   {
      if (size == -1 || size > bytes.Length) size = bytes.Length;
      var idx                                     = 0;

      foreach (var @byte in bytes)
      {
         if (idx          >= size) return indexer;
         if (offset + idx >= LittleEndianByteIndexerInt32.ByteSize) return indexer;

         indexer[idx + offset] = @byte;
         idx++;
      }

      return indexer;
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static LittleEndianByteIndexerUInt32 StoreBytes(
      this LittleEndianByteIndexerUInt32 indexer
    , ReadOnlySpan<byte>                 bytes
    , int                                offset
    , int                                size = -1
   )
   {
      if (size == -1 || size > bytes.Length) size = bytes.Length;
      var idx                                     = 0;

      foreach (var @byte in bytes)
      {
         if (idx          >= size) return indexer;
         if (offset + idx >= LittleEndianByteIndexerUInt32.ByteSize) return indexer;

         indexer[idx + offset] = @byte;
         idx++;
      }

      return indexer;
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BigEndianByteIndexerUInt32 StoreBytes(
      this BigEndianByteIndexerUInt32 indexer
    , ReadOnlySpan<byte>              bytes
    , int                             offset
    , int                             size = -1
   )
   {
      if (size == -1 || size > bytes.Length) size = bytes.Length;
      var idx                                     = 0;

      foreach (var @byte in bytes)
      {
         if (idx          >= size) return indexer;
         if (offset + idx >= LittleEndianByteIndexerUInt32.ByteSize) return indexer;

         indexer[idx + offset] = @byte;
         idx++;
      }

      return indexer;
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static LittleEndianByteIndexerInt64 StoreBytes(
      this LittleEndianByteIndexerInt64 indexer
    , ReadOnlySpan<byte>                bytes
    , int                               offset
    , int                               size = -1
   )
   {
      if (size == -1 || size > bytes.Length) size = bytes.Length;
      var idx                                     = 0;

      foreach (var @byte in bytes)
      {
         if (idx          >= size) return indexer;
         if (offset + idx >= LittleEndianByteIndexerInt64.ByteSize) return indexer;

         indexer[idx + offset] = @byte;
         idx++;
      }

      return indexer;
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BigEndianByteIndexerInt64 StoreBytes(
      this BigEndianByteIndexerInt64 indexer
    , ReadOnlySpan<byte>             bytes
    , int                            offset
    , int                            size = -1
   )
   {
      if (size == -1 || size > bytes.Length) size = bytes.Length;
      var idx                                     = 0;

      foreach (var @byte in bytes)
      {
         if (idx          >= size) return indexer;
         if (offset + idx >= LittleEndianByteIndexerInt64.ByteSize) return indexer;

         indexer[idx + offset] = @byte;
         idx++;
      }

      return indexer;
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static LittleEndianByteIndexerUInt64 StoreBytes(
      this LittleEndianByteIndexerUInt64 indexer
    , ReadOnlySpan<byte>                 bytes
    , int                                offset
    , int                                size = -1
   )
   {
      if (size == -1 || size > bytes.Length) size = bytes.Length;
      var idx                                     = 0;

      foreach (var @byte in bytes)
      {
         if (idx          >= size) return indexer;
         if (offset + idx >= LittleEndianByteIndexerUInt64.ByteSize) return indexer;

         indexer[idx + offset] = @byte;
         idx++;
      }

      return indexer;
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BigEndianByteIndexerUInt64 StoreBytes(
      this BigEndianByteIndexerUInt64 indexer
    , ReadOnlySpan<byte>              bytes
    , int                             offset
    , int                             size = -1
   )
   {
      if (size == -1 || size > bytes.Length) size = bytes.Length;
      var idx                                     = 0;

      foreach (var @byte in bytes)
      {
         if (idx          >= size) return indexer;
         if (offset + idx >= LittleEndianByteIndexerUInt64.ByteSize) return indexer;

         indexer[idx + offset] = @byte;
         idx++;
      }

      return indexer;
   }

   #endregion

   #region StoreByte to integral data type

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <param name="endian">The endianness for indexing into the bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong StoreByte(this ulong value, byte @byte, int offset, Endian endian = Endian.Little)
   {
      if (endian == Endian.Little)
         return value.StoreBits(@byte, offset << 3, 8);

      var beOffset = sizeof(ulong) - offset - 1;

      return value.StoreBits(@byte, beOffset << 3, 8);
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <param name="endian">The endianness for indexing into the bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long StoreByte(this long value, byte @byte, int offset, Endian endian = Endian.Little)
   {
      if (endian == Endian.Little)
         return value.StoreBits(@byte, offset << 3, 8);

      var beOffset = sizeof(long) - offset - 1;

      return value.StoreBits(@byte, beOffset << 3, 8);
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <param name="endian">The endianness for indexing into the bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint StoreByte(this uint value, byte @byte, int offset, Endian endian = Endian.Little)
   {
      if (endian == Endian.Little)
         return value.StoreBits(@byte, offset << 3, 8);

      var beOffset = sizeof(uint) - offset - 1;

      return value.StoreBits(@byte, beOffset << 3, 8);
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <param name="endian">The endianness for indexing into the bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int StoreByte(this int value, byte @byte, int offset, Endian endian = Endian.Little)
   {
      if (endian == Endian.Little)
         return value.StoreBits(@byte, offset << 3, 8);

      var beOffset = sizeof(int) - offset - 1;

      return value.StoreBits(@byte, beOffset << 3, 8);
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <param name="endian">The endianness for indexing into the bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort StoreByte(this ushort value, byte @byte, int offset, Endian endian = Endian.Little)
   {
      if (endian == Endian.Little)
         return value.StoreBits(@byte, offset << 3, 8);

      var beOffset = sizeof(ushort) - offset - 1;

      return value.StoreBits(@byte, beOffset << 3, 8);
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <param name="endian">The endianness for indexing into the bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short StoreByte(this short value, byte @byte, int offset, Endian endian = Endian.Little)
   {
      if (endian == Endian.Little)
         return value.StoreBits(@byte, offset << 3, 8);

      var beOffset = sizeof(short) - offset - 1;

      return value.StoreBits(@byte, beOffset << 3, 8);
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// Byte indexing is LSB, least significant byte, at index/offset zero.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float StoreByte(this float value, byte @byte, int offset)
   {
      return value.StoreBits(@byte, offset * 8, 8);
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// Byte indexing is LSB, least significant byte, at index/offset zero.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static double StoreByte(this double value, byte @byte, int offset)
   {
      return value.StoreBits(@byte, offset * 8, 8);
   }

   #endregion

   #region StoreByte to IByteIndexer

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static LittleEndianByteIndexerUInt64 StoreByte(
      this LittleEndianByteIndexerUInt64 value
    , byte                               @byte
    , int                                offset
   )
   {
      value[offset] = @byte;

      return value;
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BigEndianByteIndexerUInt64 StoreByte(this BigEndianByteIndexerUInt64 value, byte @byte, int offset)
   {
      value[offset] = @byte;

      return value;
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static LittleEndianByteIndexerInt64 StoreByte(
      this LittleEndianByteIndexerInt64 value
    , byte                              @byte
    , int                               offset
   )
   {
      value[offset] = @byte;

      return value;
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BigEndianByteIndexerInt64 StoreByte(this BigEndianByteIndexerInt64 value, byte @byte, int offset)
   {
      value[offset] = @byte;

      return value;
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static LittleEndianByteIndexerUInt32 StoreByte(
      this LittleEndianByteIndexerUInt32 value
    , byte                               @byte
    , int                                offset
   )
   {
      value[offset] = @byte;

      return value;
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BigEndianByteIndexerUInt32 StoreByte(this BigEndianByteIndexerUInt32 value, byte @byte, int offset)
   {
      value[offset] = @byte;

      return value;
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static LittleEndianByteIndexerInt32 StoreByte(
      this LittleEndianByteIndexerInt32 value
    , byte                              @byte
    , int                               offset
   )
   {
      value[offset] = @byte;

      return value;
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BigEndianByteIndexerInt32 StoreByte(this BigEndianByteIndexerInt32 value, byte @byte, int offset)
   {
      value[offset] = @byte;

      return value;
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static LittleEndianByteIndexerUInt16 StoreByte(
      this LittleEndianByteIndexerUInt16 value
    , byte                               @byte
    , int                                offset
   )
   {
      value[offset] = @byte;

      return value;
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BigEndianByteIndexerUInt16 StoreByte(this BigEndianByteIndexerUInt16 value, byte @byte, int offset)
   {
      value[offset] = @byte;

      return value;
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static LittleEndianByteIndexerInt16 StoreByte(
      this LittleEndianByteIndexerInt16 value
    , byte                              @byte
    , int                               offset
   )
   {
      value[offset] = @byte;

      return value;
   }

   /// <summary>
   /// Store a single byte to the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="byte">The byte value to set</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BigEndianByteIndexerInt16 StoreByte(this BigEndianByteIndexerInt16 value, byte @byte, int offset)
   {
      value[offset] = @byte;

      return value;
   }

   #endregion
}
#region

using System.Runtime.CompilerServices;

using Jcd.BitManipulation.ByteIndexers;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedVariable
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMethodReturnValue.Global
// ReSharper disable UnusedMemberInSuper.Global

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Extension methods that aid in reading bytes from integer data types.
/// </summary>
public static class ReadBytesExtensions
{
   #region operations on ranges of bytes.

   /// <summary>
   /// Reads a set of bytes starting at the specified offset within the value.
   /// </summary>
   /// <param name="value">The value to be read.</param>
   /// <param name="offset">The offset to read the bytes from.</param>
   /// <param name="size">The size of the value in bytes.</param>
   /// <param name="endian">The endianness of the indexing within the value.</param>
   /// <returns>A little endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this short value, int offset, int size, Endian endian = Endian.Little)
   {
      return endian == Endian.Big ? ((BigEndianByteIndexerInt16) value).ReadBytes(offset, size) : ((LittleEndianByteIndexerInt16) value).ReadBytes(offset, size);
   }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the value.
   /// </summary>
   /// <param name="value">The value to be read.</param>
   /// <param name="offset">The offset to read the bytes from.</param>
   /// <param name="size">The byte size of the value.</param>
   /// <param name="endian">The endianness of the indexing.</param>
   /// <returns>A byte array of the value in the specified endian.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this int value, int offset, int size, Endian endian = Endian.Little)
   {
      return endian == Endian.Big ? ((BigEndianByteIndexerInt32) value).ReadBytes(offset, size) : ((LittleEndianByteIndexerInt32) value).ReadBytes(offset, size);
   }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the value.
   /// </summary>
   /// <param name="value">The value to be read.</param>
   /// <param name="offset">The offset to read the bytes from.</param>
   /// <param name="size">The byte size of the value.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>A little endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this long value, int offset, int size, Endian endian = Endian.Little)
   {
      return endian == Endian.Big ? ((BigEndianByteIndexerInt64) value).ReadBytes(offset, size) : ((LittleEndianByteIndexerInt64) value).ReadBytes(offset, size);
   }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the value.
   /// </summary>
   /// <param name="value">The value to be read.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The byte size of the value.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>A little endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this ushort value, int offset, int size, Endian endian = Endian.Little)
   {
      return endian == Endian.Big ? ((BigEndianByteIndexerUInt16) value).ReadBytes(offset, size) : ((LittleEndianByteIndexerUInt16) value).ReadBytes(offset, size);
   }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the value.
   /// </summary>
   /// <param name="value">The value to be read.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The byte size of the value.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>A little endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this uint value, int offset, int size, Endian endian = Endian.Little)
   {
      return endian == Endian.Big ? ((BigEndianByteIndexerUInt32) value).ReadBytes(offset, size) : ((LittleEndianByteIndexerUInt32) value).ReadBytes(offset, size);
   }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the value.
   /// </summary>
   /// <param name="value">The value to be read.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The byte size of the value.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>A little endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this ulong value, int offset, int size, Endian endian = Endian.Little)
   {
      return endian == Endian.Big ? ((BigEndianByteIndexerUInt64) value).ReadBytes(offset, size) : ((LittleEndianByteIndexerUInt64) value).ReadBytes(offset, size);
   }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the value.
   /// </summary>
   /// <param name="value">The value to be read.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The byte size of the value.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>A little endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this float value, int offset, int size, Endian endian = Endian.Little)
   {
      return value.BitwiseToUInt32().ReadBytes(offset, size, endian);
   }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the value.
   /// </summary>
   /// <param name="value">The value to be read.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The byte size of the value.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>A little endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this double value, int offset, int size, Endian endian = Endian.Little)
   {
      return value.BitwiseToUInt64().ReadBytes(offset, size, endian);
   }

   #endregion

   #region operations on ByteIndexers

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store.</param>
   /// <returns>A little endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this LittleEndianByteIndexerInt16 indexer, int offset, int size) { return indexer.Slice(offset, size); }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store.</param>
   /// <returns>A big endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this BigEndianByteIndexerInt16 indexer, int offset, int size) { return indexer.Slice(offset, size); }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store.</param>
   /// <returns>A little endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this LittleEndianByteIndexerUInt16 indexer, int offset, int size) { return indexer.Slice(offset, size); }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store.</param>
   /// <returns>A big endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this BigEndianByteIndexerUInt16 indexer, int offset, int size) { return indexer.Slice(offset, size); }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store.</param>
   /// <returns>A little endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this LittleEndianByteIndexerInt32 indexer, int offset, int size) { return indexer.Slice(offset, size); }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store.</param>
   /// <returns>A big endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this BigEndianByteIndexerInt32 indexer, int offset, int size) { return indexer.Slice(offset, size); }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store.</param>
   /// <returns>A little endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this LittleEndianByteIndexerUInt32 indexer, int offset, int size) { return indexer.Slice(offset, size); }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store.</param>
   /// <returns>A big endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this BigEndianByteIndexerUInt32 indexer, int offset, int size) { return indexer.Slice(offset, size); }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store.</param>
   /// <returns>A little endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this LittleEndianByteIndexerInt64 indexer, int offset, int size) { return indexer.Slice(offset, size); }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store.</param>
   /// <returns>A big endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this BigEndianByteIndexerInt64 indexer, int offset, int size) { return indexer.Slice(offset, size); }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store.</param>
   /// <returns>A little endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this LittleEndianByteIndexerUInt64 indexer, int offset, int size) { return indexer.Slice(offset, size); }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the indexer.
   /// </summary>
   /// <param name="indexer">The indexer whose value is to be modified.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store.</param>
   /// <returns>A big endian byte array of the value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this BigEndianByteIndexerUInt64 indexer, int offset, int size) { return indexer.Slice(offset, size); }

   #endregion

   #region single byte operations

   /// <summary>
   /// Read a single byte from the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be read.</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The specified byte.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ReadByte(this ulong value, int offset, Endian endian = Endian.Little)
   {
      if (endian == Endian.Little)
         return (byte) value.ReadBits(offset << 3, 8);

      var beOffset = sizeof(ulong) - offset - 1;
      return (byte) value.ReadBits(beOffset << 3, 8);
   }

   /// <summary>
   /// Read a single byte from the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be read.</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The specified byte.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ReadByte(this long value, int offset, Endian endian = Endian.Little)
   {
      if (endian == Endian.Little)
         return (byte) value.ReadBits(offset << 3, 8);

      var beOffset = sizeof(long) - offset - 1;

      return (byte) value.ReadBits(beOffset << 3, 8);
   }

   /// <summary>
   /// Read a single byte from the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be read.</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The specified byte.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ReadByte(this uint value, int offset, Endian endian = Endian.Little)
   {
      if (endian == Endian.Little)
         return (byte) value.ReadBits(offset << 3, 8);

      var beOffset = sizeof(uint) - offset - 1;

      return (byte) value.ReadBits(beOffset << 3, 8);
   }

   /// <summary>
   /// Read a single byte from the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be read.</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The specified byte.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ReadByte(this int value, int offset, Endian endian = Endian.Little)
   {
      if (endian == Endian.Little)
         return (byte) value.ReadBits(offset << 3, 8);

      var beOffset = sizeof(int) - offset - 1;

      return (byte) value.ReadBits(beOffset << 3, 8);
   }

   /// <summary>
   /// Read a single byte from the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be read.</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The specified byte.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ReadByte(this ushort value, int offset, Endian endian = Endian.Little)
   {
      if (endian == Endian.Little)
         return (byte) value.ReadBits(offset << 3, 8);

      var beOffset = sizeof(ushort) - offset - 1;

      return (byte) value.ReadBits(beOffset << 3, 8);
   }

   /// <summary>
   /// Read a single byte from the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be read.</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The specified byte.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ReadByte(this short value, int offset, Endian endian = Endian.Little)
   {
      if (endian == Endian.Little)
         return (byte) value.ReadBits(offset << 3, 8);

      var beOffset = sizeof(short) - offset - 1;

      return (byte) value.ReadBits(beOffset << 3, 8);
   }

   /// <summary>
   /// Read a single byte from the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be read.</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The specified byte.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ReadByte(this float value, int offset, Endian endian = Endian.Little) { return value.BitwiseToUInt32().ReadByte(offset, endian); }

   /// <summary>
   /// Read a single byte from the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to be read.</param>
   /// <param name="offset">the offset of the byte to write</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The specified byte.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ReadByte(this double value, int offset, Endian endian = Endian.Little) { return value.BitwiseToUInt64().ReadByte(offset, endian); }

   #endregion
}
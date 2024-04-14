#region

using System;
using System.Runtime.CompilerServices;

// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMethodReturnValue.Global
// ReSharper disable UnusedMemberInSuper.Global

#pragma warning disable S4136

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Provides easy to read methods for bit manipulation operations on a <see cref="long" />
/// </summary>
/// <include file='XmlDocs/examples.xml' path='/doc/examples/item[@name="Int64Extensions"]/example' />
public static class Int64Extensions
{
   /// <summary>
   /// Tests if all of the bits from the bitmask are set on a <see cref="long" />.
   /// </summary>
   /// <param name="number">The data to inspect.</param>
   /// <param name="bitmask">The bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAllBitsSet(this long number, BitMask bitmask)
   {
      return (number & bitmask) == bitmask;
   }

   /// <summary>
   /// Tests if any bits from the bitmask are set on a <see cref="long" />.
   /// </summary>
   /// <param name="number">The data to inspect.</param>
   /// <param name="bitmask">The bits to test.</param>
   /// <returns>True if any of the bits from the bitmask were set.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAnyBitsSet(this long number, BitMask bitmask)
   {
      return (number & bitmask) != 0;
   }

   /// <summary>
   /// Tests if none of the bits from the bitmask are set on a <see cref="long" />.
   /// </summary>
   /// <param name="number">The data to inspect.</param>
   /// <param name="bitmask">The bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreNoBitsSet(this long number, BitMask bitmask)
   {
      return (number & bitmask) == 0;
   }

   /// <summary>
   /// Converts a <see cref="long" /> to the bit-wise identical <see cref="double" />
   /// </summary>
   /// <param name="number">The value to convert.</param>
   /// <returns>the <see cref="double" /> representation of the bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static double BitwiseToDouble(this long number)
   {
      return BitConverter.Int64BitsToDouble(number);
   }

   /// <summary>
   /// Converts a <see cref="long" /> into an array of <see cre="bool" /> values with the lease significant bit at index 0.
   /// </summary>
   /// <param name="number">The <see cref="long" /> to convert.</param>
   /// <returns>An array with the Least Significant Bit at index 0</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool[] ToBooleanArray(this long number)
   {
      return (BitIndexer) number;
   }

   /// <summary>
   /// Converts a <see cref="long" /> into an array of bytes in the specified <see cref="Endian" />.
   /// </summary>
   /// <param name="number">The value to convert to a <see cref="byte" /> array.</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this long number, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? ((BigEndianByteIndexer) number).Slice(0, sizeof(long))
                : ((LittleEndianByteIndexer) number).Slice(0, sizeof(long));
   }

   /// <summary>
   /// Sets all specified bits to "off" and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="offset">The offset of where to begin clearing bits.</param>
   /// <param name="size">The number of bits to clear.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ClearBits(this long number, int offset = 0, int size = sizeof(long) * BitSizeConstants.BitsPerByte)
   {
      return number.ClearBits(BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Sets the specified bit to "off" and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="offset">The bit position to set to false/0.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ClearBit(this long number, int offset)
   {
      return number.ClearBits(BitMask.FromSingleBit(offset));
   }

   /// <summary>
   /// Sets all bits from the provided mask to "off" and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="mask">The bit mask of the bits to clear.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ClearBits(this long number, BitMask mask)
   {
      return (long) ((ulong) number).ClearBits(mask);
   }

   /// <summary>
   /// Reads the bits specified and returns the result shifted to the right by the offset.
   /// </summary>
   /// <param name="number">The source of the bits to read.</param>
   /// <param name="offset">The bit offset to start reading from.</param>
   /// <param name="size">The total number of bits to extract.</param>
   /// <returns>The value stored in the range of bits specified, right shifted by the offset.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ReadBits(this long number, int offset, int size)
   {
      return number.ReadBits(offset, BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Extract a subset of bits specified by a bitmask.
   /// </summary>
   /// <param name="number">The source of the bits to read.</param>
   /// <param name="mask">The bitmask specifying which bits to read.</param>
   /// <returns>The unshifted extracted bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ReadBits(this long number, BitMask mask)
   {
      return number.ReadBits(0, mask);
   }

   /// <summary>
   /// Extract a subset of bits specified by a bitmask and right align the bits by the offset.
   /// </summary>
   /// <param name="number">The source of the bits to read.</param>
   /// <param name="shift">The bit offset to start reading from.</param>
   /// <param name="mask">The bitmask specifying which bits to read.</param>
   /// <returns>The extracted bits right shifted by the specified amount.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ReadBits(this long number, int shift, BitMask mask)
   {
      return (long) ((ulong) number).ReadBits(shift, mask);
   }

   /// <summary>
   /// Reads a single bit from the specified position.
   /// </summary>
   /// <param name="number">The source of the bits to read.</param>
   /// <param name="offset">The offset of the bit to read.</param>
   /// <returns>The bit at the specified position returned as a <see cref="bool" />. </returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool ReadBit(this long number, int offset)
   {
      return ((ulong) number).ReadBit(offset);
   }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the value.
   /// </summary>
   /// <param name="number">The value to read the bytes from.</param>
   /// <param name="offset">The byte offset to starting reading from.</param>
   /// <param name="size">The requested number of bytes to read.</param>
   /// <param name="endian">The endianness of the indexing for the byte read.</param>
   /// <returns>A byte array of the value in the specified endian.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this long number, int offset, int size, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? ((BigEndianByteIndexer) number).Slice(offset, size)
                : ((LittleEndianByteIndexer) number).Slice(offset, size);
   }

   /// <summary>
   /// Reads a single byte from the value at the specified byte offset.
   /// </summary>
   /// <param name="number">The value to read the byte from.</param>
   /// <param name="offset">The offset of where to store the byte.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The specified byte.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ReadByte(this long number, int offset, Endian endian = Endian.Little)
   {
      if (endian == Endian.Little)
      {
         return (byte) number.ReadBits(offset << BitSizeConstants.ThreeBits, BitSizeConstants.BitsPerByte);
      }

      var beOffset = sizeof(long) - offset - 1;

      return (byte) number.ReadBits(beOffset << BitSizeConstants.ThreeBits, BitSizeConstants.BitsPerByte);
   }

   /// <summary>
   /// Sets all specified bits to 1 and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="offset">The bit location to store the value.</param>
   /// <param name="size">The number of bits to set on.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long SetBits(this long number, int offset = 0, int size = sizeof(long) * BitSizeConstants.BitsPerByte)
   {
      return number.SetBits(BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Sets the bit at the specified to 1 and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="offset">The offset of the bit to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long SetBit(this long number, int offset)
   {
      return number.SetBits(BitMask.FromSingleBit(offset));
   }

   /// <summary>
   /// Sets all specified bits to 1 and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="mask">The bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long SetBits(this long number, BitMask mask)
   {
      return (long) ((ulong) number).SetBits(mask);
   }

   /// <summary>
   /// Stores a range of bits to the value, from a source value, and returns the modified value. The source value is left shifted by the offset before storing.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="source">The value to be stored at the bit location.</param>
   /// <param name="offset">The bit location to store the value.</param>
   /// <param name="size">The bit size of the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long StoreBits(this long number, long source, int offset, int size)
   {
      return number.StoreBits(source, offset, BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Stores a set of bits specified by a <see cref="BitMask" /> from a source value to a bit offset and returns the modified
   /// value.
   /// </summary>
   /// <param name="number">the destination for the stored bits</param>
   /// <param name="source">The source of the bits to store.</param>
   /// <param name="offset">The destination offset of where to store the bits.</param>
   /// <param name="mask">The mask specifying the bits to store</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long StoreBits(this long number, long source, int offset, BitMask mask)
   {
      return (long) ((ulong) number).StoreBits((ulong) source, offset, mask);
   }

   /// <summary>
   /// Store a single bit at the specified offset and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="bit">The value to store at the specified bit offset.</param>
   /// <param name="offset">The offset of the bit to store.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long StoreBit(this long number, bool bit, int offset)
   {
      return number.StoreBits(bit
                                 ? 1
                                 : 0
                            , offset
                            , 1
                             );
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte offset and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long StoreBytes(this long number, byte[] bytes, int offset, int size = -1, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? ((BigEndianByteIndexer) number).StoreBytes(bytes, offset, size)
                : ((LittleEndianByteIndexer) number).StoreBytes(bytes, offset, size);
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte offset and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long StoreBytes(this long number, ReadOnlySpan<byte> bytes, int offset, int size = -1, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? ((BigEndianByteIndexer) number).StoreBytes(bytes, offset, size)
                : ((LittleEndianByteIndexer) number).StoreBytes(bytes, offset, size);
   }

   /// <summary>
   /// Stores a single byte to the value at the specified byte offset and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="byte">The <see cref="byte" /> value to store.</param>
   /// <param name="offset">The offset of where to store the byte.</param>
   /// <param name="endian">The endianness for indexing into the bytes.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long StoreByte(this long number, byte @byte, int offset, Endian endian = Endian.Little)
   {
      if (endian == Endian.Little)
      {
         return number.StoreBits(@byte, offset << BitSizeConstants.ThreeBits, BitSizeConstants.BitsPerByte);
      }

      var beOffset = sizeof(long) - offset - 1;

      return number.StoreBits(@byte, beOffset << BitSizeConstants.ThreeBits, BitSizeConstants.BitsPerByte);
   }

   /// <summary>
   /// Toggles the specified range of bits and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="offset">The offset of the bits to toggle.</param>
   /// <param name="size">The number of bits to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ToggleBits(this long number, int offset = 0, int size = sizeof(long) * BitSizeConstants.BitsPerByte)
   {
      return number.ToggleBits(BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Toggles a bit at the specified offset and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="offset">The bit location to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ToggleBit(this long number, int offset)
   {
      return number.ToggleBits(BitMask.FromSingleBit(offset));
   }

   /// <summary>
   /// Toggle all the bits specified in the provided bit mask and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="mask">The bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ToggleBits(this long number, BitMask mask)
   {
      return (long) ((ulong) number).ToggleBits(mask);
   }
}
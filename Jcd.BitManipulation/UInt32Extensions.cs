﻿#region

using System;
using System.Runtime.CompilerServices;

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Provides methods to perform easy to read bit and byte manipulations on a <see cref="uint" />
/// </summary>
public static class UInt32Extensions
{
   /// <summary>
   /// Tests if all of the bits from the bitmask are set on a <see cref="uint" />.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 32 bits of the bitmask will be used.
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAllBitsSet(this uint data, BitMask bitmask)
   {
      return data.ReadBits(0, bitmask) == bitmask;
   }

   /// <summary>
   /// Tests if any bits from the bitmask are set on a <see cref="uint" />.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if any of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 32 bits of the bitmask will be used.
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAnyBitsSet(this uint data, BitMask bitmask)
   {
      return data.ReadBits(0, bitmask) != 0;
   }

   /// <summary>
   /// Tests if none of the bits from the bitmask are set on a <see cref="uint" />.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 32 bits of the bitmask will be used.
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreNoBitsSet(this uint data, BitMask bitmask)
   {
      return data.ReadBits(0, bitmask) == 0;
   }

   /// <summary>
   /// Converts a <see cref="uint" /> to the bit-wise identical <see cref="float" />
   /// </summary>
   /// <param name="value">The value to convert</param>
   /// <returns>the <see cref="float" /> representation of the bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float BitwiseToSingle(this uint value)
   {
      return ((int) value).BitwiseToSingle();
   }

   /// <summary>
   /// Convert a uint into an array of bools
   /// </summary>
   /// <param name="bits">the <see cref="uint" /> to convert</param>
   /// <returns>the array. Least Significant Bit at index 0</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool[] ToBooleanArray(this uint bits)
   {
      return (BitIndexer) bits;
   }

   /// <summary>
   /// Convert a uint into an array of bytes
   /// </summary>
   /// <param name="data">the <see cref="uint" /> to convert</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this uint data, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? ((BigEndianByteIndexer) data)[..]
                : ((LittleEndianByteIndexer) data)[..];
   }

   /// <summary>
   /// Sets all specified bits to "off" and returns the modified value.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The offset of where to begin clearing bits.</param>
   /// <param name="size">The number of bits to clear.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ClearBits(this uint value, int offset = 0, int size = 32)
   {
      return value.ClearBits(BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Sets bit to "off" and returns the modified value.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The offset of the bit to clear.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ClearBit(this uint value, int offset)
   {
      return value.ClearBits(BitMask.FromSingleBit(offset));
   }

   /// <summary>
   /// Sets all bits from a provided mask to "off" and returns the modified value.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">the bit mask of the bits to clear.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ClearBits(this uint value, BitMask mask)
   {
      return value & (uint) ~mask.Bits;
   }

   /// <summary>
   /// For a given value return the specified bits from within it, right shifted pos bits.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="size">The total number of bits to extract</param>
   /// <returns>The numeric value stored at that bit location</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ReadBits(this uint value, int offset, int size)
   {
      return value.ReadBits(offset, BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Extract a subset of bits specified by a bitmask and right align the bits by the offset.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="mask">
   /// the bitmask of which bits to read.
   /// Zeroed bits in the mask will always extract 0 from the source.
   /// </param>
   /// <returns>The right shifted value extracted from the value</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ReadBits(this uint value, int offset, BitMask mask)
   {
      return (value & mask) >> offset;
   }

   /// <summary>
   /// Read a single bit from the specified offset.
   /// </summary>
   /// <param name="value">the bits to read from</param>
   /// <param name="offset">the offset of the bit to read</param>
   /// <returns>the bit (a bool) at the specified offset </returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool ReadBit(this uint value, int offset)
   {
      return value.ReadBits(offset, 1) > 0;
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
      return endian == Endian.Big
                ? ((BigEndianByteIndexer) value).Slice(offset, size)
                : ((LittleEndianByteIndexer) value).Slice(offset, size);
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
   /// Sets all specified bits to "on"
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to store the value.</param>
   /// <param name="size">The number of bits to set on.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint SetBits(this uint value, int offset = 0, int size = 32)
   {
      return value.SetBits(BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Sets specified bit to "on"
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The offset of the bit to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint SetBit(this uint value, int offset)
   {
      return value.SetBits(BitMask.FromSingleBit(offset));
   }

   /// <summary>
   /// Sets all specified bits to "on"
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint SetBits(this uint value, BitMask mask)
   {
      return value | (uint) mask.Bits;
   }

   /// <summary>
   /// Stores a value at the specified bit location within the variable.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="source">The value to be stored at the bit location.</param>
   /// <param name="offset">The bit location to store the value.</param>
   /// <param name="size">The bit size of the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint StoreBits(this uint value, uint source, int offset, int size)
   {
      return value.StoreBits(source, offset, BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Store a masked set of bits from a value to an offset in the destination
   /// The mask must apply to the destination bits.
   /// </summary>
   /// <param name="value">the destination for the stored bits</param>
   /// <param name="source">the source of the bits to store</param>
   /// <param name="offset">the destination offset of where to store the bits</param>
   /// <param name="mask">the mask of which bits to store</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint StoreBits(this uint value, uint source, int offset, BitMask mask)
   {
      value = value.ClearBits(mask);
      value |= (source << offset) & (uint) mask.Bits;

      return value;
   }

   /// <summary>
   /// Store a single bit at the specified offset.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="bit">The bit value to set</param>
   /// <param name="offset">the offset of the bit to write</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint StoreBit(this uint value, bool bit, int offset)
   {
      return value.StoreBits((uint) (bit
                                        ? 1
                                        : 0)
                           , offset
                           , 1
                            );
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
   public static ushort StoreBytes(this ushort value, ReadOnlySpan<byte> bytes, int offset, int size = -1, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? ((BigEndianByteIndexer) value).StoreBytes(bytes, offset, size)
                : ((LittleEndianByteIndexer) value).StoreBytes(bytes, offset, size);
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
   /// Stores a set of bytes starting at the specified byte location within the value.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint StoreBytes(this uint value, ReadOnlySpan<byte> bytes, int offset, int size = -1, Endian endian = Endian.Little)
   {
      return endian == Endian.Big
                ? ((BigEndianByteIndexer) value).StoreBytes(bytes, offset, size)
                : ((LittleEndianByteIndexer) value).StoreBytes(bytes, offset, size);
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
   /// Toggles bits and size.
   /// The default values result in toggling all bits.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The offset of the bits to toggle.</param>
   /// <param name="size">The number of bits to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ToggleBits(this uint value, int offset = 0, int size = 32)
   {
      return value.ToggleBits(BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Toggles a bit.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ToggleBit(this uint value, int offset)
   {
      return value.ToggleBits(BitMask.FromSingleBit(offset));
   }

   /// <summary>
   /// Toggle all the bits according to the provided mask
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ToggleBits(this uint value, BitMask mask)
   {
      return value ^ (uint) mask.Bits;
   }
}
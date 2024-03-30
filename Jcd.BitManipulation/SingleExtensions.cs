#region

using System;
using System.Runtime.CompilerServices;

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Provides methods to perform easy to read bit and byte manipulations on a <see cref="float" />
/// </summary>
public static class SingleExtensions
{
   /// <summary>
   /// Tests if all of the bits from the bitmask are set on a <see cref="float" />.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">The bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 8 bits of the bitmask will be used.
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAllBitsSet(this float data, BitMask bitmask)
   {
      return data.ReadBits(0, bitmask) == bitmask;
   }

   /// <summary>
   /// Tests if any bits from the bitmask are set on an <see cref="float" />.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">The bits to test.</param>
   /// <returns>True if any of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 8 bits of the bitmask will be used.
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAnyBitsSet(this float data, BitMask bitmask)
   {
      return data.ReadBits(0, bitmask) != 0;
   }

   /// <summary>
   /// Tests if none of the bits from the bitmask are set on an <see cref="float" />.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">The bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 8 bits of the bitmask will be used.
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreNoBitsSet(this float data, BitMask bitmask)
   {
      return data.ReadBits(0, bitmask) == 0;
   }

   /// <summary>
   /// Converts a <see cref="float" /> to the bit-wise identical <see cref="uint" />
   /// </summary>
   /// <param name="value">The value to convert.</param>
   /// <returns>the <see cref="uint" /> representation of the underlying bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint BitwiseToUInt32(this float value)
   {
      return (uint) value.BitwiseToInt32();
   }

   /// <summary>
   /// Converts a <see cref="float" /> to the bit-wise identical <see cref="int" />
   /// </summary>
   /// <param name="value">The value to convert.</param>
   /// <returns>the <see cref="int" /> representation of the underlying bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int BitwiseToInt32(this float value)
   {
      #if NETSTANDARD2_1_OR_GREATER
      return BitConverter.SingleToInt32Bits(value);
      #else
      return BitConverter.ToInt32(BitConverter.GetBytes(value), 0);
      #endif
   }

   /// <summary>
   /// Converts a <see cref="float" /> into an array of <see cre="bool" /> values with the lease significant bit at index 0.
   /// </summary>
   /// <param name="bits">The value to convert to an array of <see cref="bool" /> values.</param>
   /// <returns>the array. LSB at index 0</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool[] ToBooleanArray(this float bits)
   {
      return (BitIndexer) bits;
   }

   /// <summary>
   /// Converts a <see cref="float" /> into an array of bytes in the specified <see cref="Endian" />.
   /// </summary>
   /// <param name="data">The value to convert to a <see cref="byte" /> array.</param>
   /// <param name="endian">The order in which to store the bytes</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this float data, Endian endian = Endian.Little)
   {
      return data.BitwiseToUInt32().ToByteArray(endian);
   }

   /// <summary>
   /// Sets all specified bits to "off" and returns the modified value.
   /// </summary>
   /// <param name="value">The value to modify.</param>
   /// <param name="offset">The offset of where to begin clearing bits.</param>
   /// <param name="size">The number of bits to clear.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float ClearBits(this float value, int offset = 0, int size = 32)
   {
      return value.ClearBits(BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Sets the specified bit to "off" and returns the modified value.
   /// </summary>
   /// <param name="value">The value to modify.</param>
   /// <param name="offset">The bit position to set to false/0.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float ClearBit(this float value, int offset)
   {
      return value.ClearBits(BitMask.FromSingleBit(offset));
   }

   /// <summary>
   /// Sets all bits from the provided mask to "off" and returns the modified value.
   /// </summary>
   /// <param name="value">The value to modify.</param>
   /// <param name="mask">The bit mask of the bits to clear.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float ClearBits(this float value, BitMask mask)
   {
      return value.BitwiseToUInt32().ClearBits(mask).BitwiseToSingle();
   }

   /// <summary>
   /// Reads the bits specified and returns the result shifted to the right by the offset.
   /// </summary>
   /// <param name="value">The source of the bits to read.</param>
   /// <param name="offset">The bit offset to start reading from.</param>
   /// <param name="size">The total number of bits to extract.</param>
   /// <returns>The value stored in the range of bits specified, right shifted by the offset..</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ReadBits(this float value, int offset, int size)
   {
      return value.ReadBits(offset, BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Extract a subset of bits specified by a bitmask.
   /// </summary>
   /// <param name="value">The source of the bits to read.</param>
   /// <param name="mask">The bitmask specifying which bits to read.</param>
   /// <returns>The ushifted extracted bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ReadBits(this float value, BitMask mask)
   {
      return value.BitwiseToUInt32().ReadBits(mask);
   }

   /// <summary>
   /// Extract a subset of bits specified by a bitmask and right align the bits by the offset.
   /// </summary>
   /// <param name="value">The source of the bits to read.</param>
   /// <param name="shift">The bit offset to start reading from.</param>
   /// <param name="mask">The bitmask specifying which bits to read.</param>
   /// <returns>The extracted bits right shifted by the specified amount.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ReadBits(this float value, int shift, BitMask mask)
   {
      return value.ReadBits(mask) >> shift;
   }

   /// <summary>
   /// Reads a single bit from the specified position.
   /// </summary>
   /// <param name="value">The source of the bits to read.</param>
   /// <param name="offset">The offset of the bit to read.</param>
   /// <returns>The bit at the specified position returned as a <see cref="bool" />. </returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool ReadBit(this float value, int offset)
   {
      return value.ReadBits(offset, 1) > 0;
   }

   /// <summary>
   /// Reads a set of bytes starting at the specified byte location within the value.
   /// </summary>
   /// <param name="value">The value to read the bytes from.</param>
   /// <param name="offset">The byte offset to starting reading from.</param>
   /// <param name="size">The requested number of bytes to read.</param>
   /// <param name="endian">The endianness of the indexing for the byte read.</param>
   /// <returns>A byte array of the value in the specified endian.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ReadBytes(this float value, int offset, int size, Endian endian = Endian.Little)
   {
      return value.BitwiseToUInt32().ReadBytes(offset, size, endian);
   }

   /// <summary>
   /// Reads a single byte from the value at the specified byte offset.
   /// </summary>
   /// <param name="value">The value to read the byte from.</param>
   /// <param name="offset">The offset of where to store the byte.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The specified byte.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ReadByte(this float value, int offset, Endian endian = Endian.Little)
   {
      return value.BitwiseToUInt32().ReadByte(offset, endian);
   }

   /// <summary>
   /// Sets all specified bits to "on" and returns the modified value.
   /// </summary>
   /// <param name="value">The value to modify.</param>
   /// <param name="offset">The bit location to store the value.</param>
   /// <param name="size">The number of bits to set on.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float SetBits(this float value, int offset = 0, int size = 32)
   {
      return value.SetBits(BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Sets the bit at the specified to "on" and returns the modified value.
   /// </summary>
   /// <param name="value">The value to modify.</param>
   /// <param name="offset">The offset of the bit to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float SetBit(this float value, int offset)
   {
      return value.SetBits(BitMask.FromSingleBit(offset));
   }

   /// <summary>
   /// Sets all specified bits to "on" and returns the modified value.
   /// </summary>
   /// <param name="value">The value to modify.</param>
   /// <param name="mask">The bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float SetBits(this float value, BitMask mask)
   {
      return value.BitwiseToUInt32().SetBits(mask).BitwiseToSingle();
   }

   /// <summary>
   /// Stores a range of bits to the value, from a source value, and returns the modified value.
   /// </summary>
   /// <param name="value">The value to modify.</param>
   /// <param name="source">The value to be stored at the bit location.</param>
   /// <param name="offset">The bit location to store the value.</param>
   /// <param name="size">The bit size of the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float StoreBits(this float value, uint source, int offset, int size)
   {
      return value.StoreBits(source, offset, BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Stores a set of bits specified by a <see cref="BitMask" /> from a source value to a bit offset and returns the modified
   /// value.
   /// </summary>
   /// <param name="value">the destination for the stored bits</param>
   /// <param name="source">The source of the bits to store.</param>
   /// <param name="offset">The destination offset of where to store the bits.</param>
   /// <param name="mask">The mask specifying the bits to store</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float StoreBits(this float value, uint source, int offset, BitMask mask)
   {
      return value.BitwiseToUInt32().StoreBits(source, offset, mask).BitwiseToSingle();
   }

   /// <summary>
   /// Store a single bit at the specified offset and returns the modified value.
   /// </summary>
   /// <param name="value">The value to modify.</param>
   /// <param name="bit">The value to store at the specified bit offset.</param>
   /// <param name="offset">The offset of the bit to store.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float StoreBit(this float value, bool bit, int offset)
   {
      return value.BitwiseToUInt32().StoreBit(bit, offset).BitwiseToSingle();
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte offset and returns the modified value.
   /// </summary>
   /// <param name="value">The value to modify.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float StoreBytes(this float value, byte[] bytes, int offset, int size = -1, Endian endian = Endian.Little)
   {
      return value.BitwiseToUInt32().StoreBytes(bytes, offset, size, endian).BitwiseToSingle();
   }

   /// <summary>
   /// Stores a set of bytes starting at the specified byte offset and returns the modified value.
   /// </summary>
   /// <param name="value">The value to modify.</param>
   /// <param name="bytes">The value to be stored at the byte location.</param>
   /// <param name="offset">The byte location to store the value.</param>
   /// <param name="size">The number of bytes from the source, to store. -1 means all bytes.</param>
   /// <param name="endian">The endianness of the byte indexing within the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float StoreBytes(this float value, ReadOnlySpan<byte> bytes, int offset, int size = -1, Endian endian = Endian.Little)
   {
      return value.BitwiseToUInt32().StoreBytes(bytes, offset, size, endian).BitwiseToSingle();
   }

   /// <summary>
   /// Stores a single byte to the value at the specified byte offset and returns the modified value.
   /// </summary>
   /// <param name="value">The value to modify.</param>
   /// <param name="byte">The <see cref="byte" /> value to store.</param>
   /// <param name="offset">The offset of where to store the byte.</param>
   /// <param name="endian">The endianness of the indexing within the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float StoreByte(this float value, byte @byte, int offset, Endian endian = Endian.Little)
   {
      if (endian == Endian.Little)
         return value.StoreBits(@byte, offset << 3, 8);

      var beOffset = sizeof(float) - offset - 1;

      return value.StoreBits(@byte, beOffset << 3, 8);
   }

   /// <summary>
   /// Toggles the specified range of bits and returns the modified value.
   /// </summary>
   /// <param name="value">The value to modify.</param>
   /// <param name="offset">The offset of the bits to toggle.</param>
   /// <param name="size">The number of bits to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float ToggleBits(this float value, int offset = 0, int size = 32)
   {
      return value.ToggleBits(BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Toggles a bit at the specified offset and returns the modified value.
   /// </summary>
   /// <param name="value">The value to modify.</param>
   /// <param name="offset">The bit location to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float ToggleBit(this float value, int offset)
   {
      return value.ToggleBits(BitMask.FromSingleBit(offset));
   }

   /// <summary>
   /// Toggle all the bits specified in the provided bit mask and returns the modified value.
   /// </summary>
   /// <param name="value">The value to modify.</param>
   /// <param name="mask">The bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float ToggleBits(this float value, BitMask mask)
   {
      return value.BitwiseToUInt32().ToggleBits(mask).BitwiseToSingle();
   }
}
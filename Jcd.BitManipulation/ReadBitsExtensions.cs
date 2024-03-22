// ReSharper disable MemberCanBePrivate.Global

#region

using System.Runtime.CompilerServices;

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Extension methods that enable reading one or more bits from a specified offset in an integer data type.
/// </summary>
public static class ReadBitsExtensions
{
   #region operations on ranges of bits.

   /// <summary>
   /// For a given value return the specified bits from within it, right shifted pos bits.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="size">The total number of bits to extract</param>
   /// <returns>The numeric value stored at that bit location</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ReadBits(this sbyte value, int offset, int size)
   {
      return value.ReadBits(offset, BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// For a given value return the specified bits from within it, right shifted pos bits.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="size">The total number of bits to extract</param>
   /// <returns>The numeric value stored at that bit location</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short ReadBits(this short value, int offset, int size)
   {
      return value.ReadBits(offset, BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// For a given value return the specified bits from within it, right shifted pos bits.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="size">The total number of bits to extract</param>
   /// <returns>The numeric value stored at that bit location</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int ReadBits(this int value, int offset, int size)
   {
      return value.ReadBits(offset, BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// For a given value return the specified bits from within it, right shifted pos bits.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="size">The total number of bits to extract</param>
   /// <returns>The numeric value stored at that bit location</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ReadBits(this long value, int offset, int size)
   {
      return value.ReadBits(offset, BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// For a given value return the specified bits from within it, right shifted pos bits.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="size">The total number of bits to extract</param>
   /// <returns>The numeric value stored at that bit location</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ReadBits(this byte value, int offset, int size)
   {
      return value.ReadBits(offset, BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// For a given value return the specified bits from within it, right shifted pos bits.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="size">The total number of bits to extract</param>
   /// <returns>The numeric value stored at that bit location</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort ReadBits(this ushort value, int offset, int size)
   {
      return value.ReadBits(offset, BitMask.FromRange(offset, size));
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
   /// For a given value return the specified bits from within it, right shifted pos bits.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="size">The total number of bits to extract</param>
   /// <returns>The numeric value stored at that bit location</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong ReadBits(this ulong value, int offset, int size)
   {
      return value.ReadBits(offset, BitMask.FromRange(offset, size));
   }

   #endregion

   #region BitMask operations

   /// <summary>
   /// Extract a subset of bits specified by a bitmask and right align the bits by the offset.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="mask">the bitmask of which bits to read.
   /// Zeroed bits in the mask will always extract 0 from the source.
   /// </param>
   /// <returns>The right shifted value extracted from the value</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong ReadBits(this ulong value, int offset, BitMask mask) { return (value & mask) >> offset; }

   /// <summary>
   /// Extract a subset of bits specified by a bitmask and right align the bits by the offset.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="mask">the bitmask of which bits to read.
   /// Zeroed bits in the mask will always extract 0 from the source.
   /// </param>
   /// <returns>The right shifted value extracted from the value</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ReadBits(this long value, int offset, BitMask mask)
   {
      return (long) (((ulong) value & mask) >> offset);
   }

   /// <summary>
   /// Extract a subset of bits specified by a bitmask and right align the bits by the offset.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="mask">the bitmask of which bits to read.
   /// Zeroed bits in the mask will always extract 0 from the source.
   /// </param>
   /// <returns>The right shifted value extracted from the value</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ReadBits(this uint value, int offset, BitMask mask) { return (value & mask) >> offset; }

   /// <summary>
   /// Extract a subset of bits specified by a bitmask and right align the bits by the offset.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="mask">the bitmask of which bits to read.
   /// Zeroed bits in the mask will always extract 0 from the source.
   /// </param>
   /// <returns>The right shifted value extracted from the value</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int ReadBits(this int value, int offset, BitMask mask)
   {
      return (int) (((uint) value & mask) >> offset); // coerce to unsigned first to prevent issues with sign bit.
   }

   /// <summary>
   /// Extract a subset of bits specified by a bitmask and right align the bits by the offset.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="mask">the bitmask of which bits to read.
   /// Zeroed bits in the mask will always extract 0 from the source.
   /// </param>
   /// <returns>The right shifted value extracted from the value</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort ReadBits(this ushort value, int offset, BitMask mask)
   {
      return (ushort) ((value & mask) >> offset);
   }

   /// <summary>
   /// Extract a subset of bits specified by a bitmask and right align the bits by the offset.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="mask">the bitmask of which bits to read.
   /// Zeroed bits in the mask will always extract 0 from the source.
   /// </param>
   /// <returns>The right shifted value extracted from the value</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short ReadBits(this short value, int offset, BitMask mask)
   {
      return (short) (((ushort) value & mask) >> offset);
   }

   /// <summary>
   /// Extract a subset of bits specified by a bitmask and right align the bits by the offset.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="mask">the bitmask of which bits to read.
   /// Zeroed bits in the mask will always extract 0 from the source.
   /// </param>
   /// <returns>The right shifted value extracted from the value</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ReadBits(this byte value, int offset, BitMask mask) { return (byte) ((value & mask) >> offset); }

   /// <summary>
   /// Extract a subset of bits specified by a bitmask and right align the bits by the offset.
   /// </summary>
   /// <param name="value">the source of bits to read</param>
   /// <param name="offset">the bit offset to read from</param>
   /// <param name="mask">the bitmask of which bits to read.
   /// Zeroed bits in the mask will always extract 0 from the source.
   /// </param>
   /// <returns>The right shifted value extracted from the value</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ReadBits(this sbyte value, int offset, BitMask mask)
   {
      return (sbyte) (((byte) value & mask) >> offset);
   }

   #endregion

   #region single bit operations

   /// <summary>
   /// Read a single bit from the specified offset.
   /// </summary>
   /// <param name="value">the bits to read from</param>
   /// <param name="offset">the offset of the bit to read</param>
   /// <returns>the bit (a bool) at the specified offset </returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool ReadBit(this ulong value, int offset) { return value.ReadBits(offset, 1) > 0; }

   /// <summary>
   /// Read a single bit from the specified offset.
   /// </summary>
   /// <param name="value">the bits to read from</param>
   /// <param name="offset">the offset of the bit to read</param>
   /// <returns>the bit (a bool) at the specified offset </returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool ReadBit(this long value, int offset) { return value.ReadBits(offset, 1) > 0; }

   /// <summary>
   /// Read a single bit from the specified offset.
   /// </summary>
   /// <param name="value">the bits to read from</param>
   /// <param name="offset">the offset of the bit to read</param>
   /// <returns>the bit (a bool) at the specified offset </returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool ReadBit(this uint value, int offset) { return value.ReadBits(offset, 1) > 0; }

   /// <summary>
   /// Read a single bit from the specified offset.
   /// </summary>
   /// <param name="value">the bits to read from</param>
   /// <param name="offset">the offset of the bit to read</param>
   /// <returns>the bit (a bool) at the specified offset </returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool ReadBit(this int value, int offset) { return value.ReadBits(offset, 1) > 0; }

   /// <summary>
   /// Read a single bit from the specified offset.
   /// </summary>
   /// <param name="value">the bits to read from</param>
   /// <param name="offset">the offset of the bit to read</param>
   /// <returns>the bit (a bool) at the specified offset </returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool ReadBit(this ushort value, int offset) { return value.ReadBits(offset, 1) > 0; }

   /// <summary>
   /// Read a single bit from the specified offset.
   /// </summary>
   /// <param name="value">the bits to read from</param>
   /// <param name="offset">the offset of the bit to read</param>
   /// <returns>the bit (a bool) at the specified offset </returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool ReadBit(this short value, int offset) { return value.ReadBits(offset, 1) > 0; }

   /// <summary>
   /// Read a single bit from the specified offset.
   /// </summary>
   /// <param name="value">the bits to read from</param>
   /// <param name="offset">the offset of the bit to read</param>
   /// <returns>the bit (a bool) at the specified offset </returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool ReadBit(this byte value, int offset) { return value.ReadBits(offset, 1) > 0; }

   /// <summary>
   /// Read a single bit from the specified offset.
   /// </summary>
   /// <param name="value">the bits to read from</param>
   /// <param name="offset">the offset of the bit to read</param>
   /// <returns>the bit (a bool) at the specified offset </returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool ReadBit(this sbyte value, int offset) { return value.ReadBits(offset, 1) > 0; }

   #endregion
}
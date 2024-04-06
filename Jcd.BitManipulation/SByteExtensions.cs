#region

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
/// Provides easy to read methods for bit manipulation operations on a <see cref="sbyte" />
/// </summary>
/// <include file='XmlDocs/examples.xml' path='/doc/examples/item[@name="SByteExtensions"]/example' />
public static class SByteExtensions
{
   /// <summary>
   /// Tests if all of the bits from the bitmask are set on a <see cref="sbyte" />.
   /// </summary>
   /// <param name="number">The data to inspect.</param>
   /// <param name="bitmask">The bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 8 bits of the bitmask will be used.
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAllBitsSet(this sbyte number, BitMask bitmask)
   {
      return (number & bitmask) == bitmask;
   }

   /// <summary>
   /// Tests if any bits from the bitmask are set on a <see cref="sbyte" />.
   /// </summary>
   /// <param name="number">The data to inspect.</param>
   /// <param name="bitmask">The bits to test.</param>
   /// <returns>True if any of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 8 bits of the bitmask will be used.
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAnyBitsSet(this sbyte number, BitMask bitmask)
   {
      return (number & bitmask) != 0;
   }

   /// <summary>
   /// Tests if none of the bits from the bitmask are set on a <see cref="sbyte" />.
   /// </summary>
   /// <param name="number">The data to inspect.</param>
   /// <param name="bitmask">The bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 8 bits of the bitmask will be used.
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreNoBitsSet(this sbyte number, BitMask bitmask)
   {
      return (number & bitmask) == 0;
   }

   /// <summary>
   /// Converts a <see cref="sbyte" /> into an array of <see cre="bool" /> values with the lease significant bit at index 0.
   /// </summary>
   /// <param name="number">The <see cref="sbyte" /> to convert.</param>
   /// <returns>An array with the Least Significant Bit at index 0</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool[] ToBooleanArray(this sbyte number)
   {
      return (BitIndexer) number;
   }

   /// <summary>
   /// Converts a <see cref="sbyte" /> into an array of bytes in the specified <see cref="Endian" />.
   /// </summary>
   /// <param name="number">The value to convert to a <see cref="byte" /> array.</param>
   /// <returns>The value as an array in the requested byte order</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte[] ToByteArray(this sbyte number)
   {
      return [(byte) number];
   }

   /// <summary>
   /// Sets all specified bits to "off" and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="offset">The offset of where to begin clearing bits.</param>
   /// <param name="size">The number of bits to clear.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ClearBits(this sbyte number, int offset = 0, int size = BitSizeConstants.BitsPerByte)
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
   public static sbyte ClearBit(this sbyte number, int offset)
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
   public static sbyte ClearBits(this sbyte number, BitMask mask)
   {
      return (sbyte) ((byte) number).ClearBits(mask);
   }

   /// <summary>
   /// Reads the bits specified and returns the result shifted to the right by the offset.
   /// </summary>
   /// <param name="number">The source of the bits to read.</param>
   /// <param name="offset">The bit offset to start reading from.</param>
   /// <param name="size">The total number of bits to extract.</param>
   /// <returns>The value stored in the range of bits specified, right shifted by the offset..</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ReadBits(this sbyte number, int offset, int size)
   {
      return number.ReadBits(offset, BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Extract a subset of bits specified by a bitmask and right align the bits by the offset.
   /// </summary>
   /// <param name="number">The source of the bits to read.</param>
   /// <param name="mask">The bitmask specifying which bits to read.</param>
   /// <returns>The unshifted extracted bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ReadBits(this sbyte number, BitMask mask)
   {
      return (sbyte) ((byte) number).ReadBits(mask);
   }

   /// <summary>
   /// Extract a subset of bits specified by a bitmask and right align the bits by the offset.
   /// </summary>
   /// <param name="number">The source of the bits to read.</param>
   /// <param name="shift">The number of bits to right shift the result of applying the <see cref="BitMask" />.</param>
   /// <param name="mask">The bitmask specifying which bits to read.</param>
   /// <returns>The extracted bits right shifted by the specified amount.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ReadBits(this sbyte number, int shift, BitMask mask)
   {
      return (sbyte) ((byte) number).ReadBits(shift, mask);
   }

   /// <summary>
   /// Reads a single bit from the specified position.
   /// </summary>
   /// <param name="number">The source of the bits to read.</param>
   /// <param name="offset">The offset of the bit to read.</param>
   /// <returns>The bit at the specified position returned as a <see cref="bool" />. </returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool ReadBit(this sbyte number, int offset)
   {
      return ((byte) number).ReadBit(offset);
   }

   /// <summary>
   /// Sets all specified bits to 1 and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="offset">The bit location to store the value.</param>
   /// <param name="size">The number of bits to set on.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte SetBits(this sbyte number, int offset = 0, int size = BitSizeConstants.BitsPerByte)
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
   public static sbyte SetBit(this sbyte number, int offset)
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
   public static sbyte SetBits(this sbyte number, BitMask mask)
   {
      return (sbyte) ((byte) number).SetBits(mask);
   }

   /// <summary>
   /// Stores a range of bits to the value, from a source value, and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="source">The value to be stored at the bit location.</param>
   /// <param name="offset">The bit location to store the value.</param>
   /// <param name="size">The bit size of the value.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte StoreBits(this sbyte number, sbyte source, int offset, int size)
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
   public static sbyte StoreBits(this sbyte number, sbyte source, int offset, BitMask mask)
   {
      return (sbyte) ((byte) number).StoreBits((byte) source, offset, mask);
   }

   /// <summary>
   /// Store a single bit at the specified offset and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="bit">The value to store at the specified bit offset.</param>
   /// <param name="offset">The offset of the bit to store.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte StoreBit(this sbyte number, bool bit, int offset)
   {
      return number.StoreBits((sbyte) (bit
                                         ? 1
                                         : 0)
                           , offset
                           , 1
                            );
   }

   /// <summary>
   /// Toggles the specified range of bits and returns the modified value.
   /// </summary>
   /// <param name="number">The value to modify.</param>
   /// <param name="offset">The offset of the bits to toggle.</param>
   /// <param name="size">The number of bits to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ToggleBits(this sbyte number, int offset = 0, int size = BitSizeConstants.BitsPerByte)
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
   public static sbyte ToggleBit(this sbyte number, int offset)
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
   public static sbyte ToggleBits(this sbyte number, BitMask mask)
   {
      return (sbyte) (number ^ (sbyte) mask);
   }
}
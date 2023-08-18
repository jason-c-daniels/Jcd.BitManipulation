// ReSharper disable MemberCanBePrivate.Global

using System.Runtime.CompilerServices;
using Jcd.BitManipulation.BitIndexers;

namespace Jcd.BitManipulation;

/// <summary>
/// Extension methods that aid in storing values into bit offsets within an integer data type.
/// </summary>
public static class StoreBitsExtensions
{
    #region operations on ranges of bits.

    /// <summary>
    /// Stores a value at the specified bit location within the variable.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="source">The value to be stored at the bit location.</param>
    /// <param name="offset">The bit location to store the value.</param>
    /// <param name="size">The bit size of the value.</param>
    /// <returns>The modified value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte StoreBits(this sbyte value, sbyte source, int offset, int size)
    {
        return value.StoreBits(source, offset, BitMask.FromRange(offset, size));
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
    public static short StoreBits(this short value, short source, int offset, int size)
    {
        return value.StoreBits(source, offset, BitMask.FromRange(offset, size));
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
    public static int StoreBits(this int value, int source, int offset, int size)
    {
        return value.StoreBits(source, offset, BitMask.FromRange(offset, size));
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
    public static long StoreBits(this long value, long source, int offset, int size)
    {
        return value.StoreBits(source, offset, BitMask.FromRange(offset, size));
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
    public static byte StoreBits(this byte value, byte source, int offset, int size)
    {
        return value.StoreBits(source, offset, BitMask.FromRange(offset, size));
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
    public static ushort StoreBits(this ushort value, ushort source, int offset, int size)
    {
        return value.StoreBits(source, offset, BitMask.FromRange(offset, size));
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
    /// Stores a value at the specified bit location within the variable.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="source">The value to be stored at the bit location.</param>
    /// <param name="offset">The bit location to store the value.</param>
    /// <param name="size">The bit size of the value.</param>
    /// <returns>The modified value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong StoreBits(this ulong value, ulong source, int offset, int size)
    {
        return value.StoreBits(source, offset, BitMask.FromRange(offset, size));
    }

    #endregion

    #region BitMask operations

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
    public static ulong StoreBits(this ulong value, ulong source, int offset, BitMask mask)
    {
        value = value.ClearBits(mask);
        value |= (source << offset) & mask;
        return value;
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
    public static long StoreBits(this long value, long source, int offset, BitMask mask)
    {
        value = value.ClearBits(mask);
        value |= (source << offset) & (long)mask.Bits;
        return value;
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
        value |= (source << offset) & (uint)mask.Bits;
        return value;
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
    public static int StoreBits(this int value, int source, int offset, BitMask mask)
    {
        value = value.ClearBits(mask);
        value |= (source << offset) & (int)mask.Bits;
        return value;
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
    public static ushort StoreBits(this ushort value, ushort source, int offset, BitMask mask)
    {
        value = value.ClearBits(mask);
        value |= (ushort)((source << offset) & (ushort)mask.Bits);
        return value;
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
    public static short StoreBits(this short value, short source, int offset, BitMask mask)
    {
        value = value.ClearBits(mask);
        value |= (short)((source << offset) & (short)mask.Bits);
        return value;
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
    public static byte StoreBits(this byte value, byte source, int offset, BitMask mask)
    {
        value = value.ClearBits(mask);
        value |= (byte)((source << offset) & (byte)mask.Bits);
        return value;
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
    public static sbyte StoreBits(this sbyte value, sbyte source, int offset, BitMask mask)
    {
        value = value.ClearBits(mask);
        value |= (sbyte)((source << offset) & (sbyte)mask.Bits);
        return value;
    }

    #endregion

    #region single bit operations

    /// <summary>
    /// Store a single bit from the specified offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="bit">The bit value to set</param>
    /// <param name="offset">the offset of the bit to write</param>
    /// <returns>The modified value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong StoreBit(this ulong value, bool bit, int offset)
    {
        return value.StoreBits((ulong)(bit ? 1 : 0), offset, 1);
    }

    /// <summary>
    /// Store a single bit from the specified offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="bit">The bit value to set</param>
    /// <param name="offset">the offset of the bit to write</param>
    /// <returns>The modified value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long StoreBit(this long value, bool bit, int offset)
    {
        return value.StoreBits(bit ? 1 : 0, offset, 1);
    }

    /// <summary>
    /// Store a single bit from the specified offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="bit">The bit value to set</param>
    /// <param name="offset">the offset of the bit to write</param>
    /// <returns>The modified value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint StoreBit(this uint value, bool bit, int offset)
    {
        return value.StoreBits((uint)(bit ? 1 : 0), offset, 1);
    }

    /// <summary>
    /// Store a single bit from the specified offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="bit">The bit value to set</param>
    /// <param name="offset">the offset of the bit to write</param>
    /// <returns>The modified value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int StoreBit(this int value, bool bit, int offset)
    {
        return value.StoreBits(bit ? 1 : 0, offset, 1);
    }

    /// <summary>
    /// Store a single bit from the specified offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="bit">The bit value to set</param>
    /// <param name="offset">the offset of the bit to write</param>
    /// <returns>The modified value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort StoreBit(this ushort value, bool bit, int offset)
    {
        return value.StoreBits((ushort)(bit ? 1 : 0), offset, 1);
    }

    /// <summary>
    /// Store a single bit from the specified offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="bit">The bit value to set</param>
    /// <param name="offset">the offset of the bit to write</param>
    /// <returns>The modified value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short StoreBit(this short value, bool bit, int offset)
    {
        return value.StoreBits((short)(bit ? 1 : 0), offset, 1);
    }

    /// <summary>
    /// Store a single bit from the specified offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="bit">The bit value to set</param>
    /// <param name="offset">the offset of the bit to write</param>
    /// <returns>The modified value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte StoreBit(this byte value, bool bit, int offset)
    {
        return value.StoreBits((byte)(bit ? 1 : 0), offset, 1);
    }

    /// <summary>
    /// Store a single bit from the specified offset.
    /// </summary>
    /// <param name="value">The value to be modified.</param>
    /// <param name="bit">The bit value to set</param>
    /// <param name="offset">the offset of the bit to write</param>
    /// <returns>The modified value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte StoreBit(this sbyte value, bool bit, int offset)
    {
        return value.StoreBits((sbyte)(bit ? 1 : 0), offset, 1);
    }

    #endregion
}
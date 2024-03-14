#region

using System.Runtime.CompilerServices;

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Extension methods that aid in turning bits on in an integer data type.
/// </summary>
public static class SetBitsExtensions
{
   #region Range of bits operations

   /// <summary>
   /// Sets all specified bits to "on" 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to store the value.</param>
   /// <param name="size">The number of bits to set on.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte SetBits(this sbyte value, int offset = 0, int size = 8)
   {
      return value.SetBits(BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Sets all specified bits to "on" 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to store the value.</param>
   /// <param name="size">The number of bits to set on.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short SetBits(this short value, int offset = 0, int size = 16)
   {
      return value.SetBits(BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Sets all specified bits to "on" 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to store the value.</param>
   /// <param name="size">The number of bits to set on.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int SetBits(this int value, int offset = 0, int size = 32)
   {
      return value.SetBits(BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Sets all specified bits to "on" 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to store the value.</param>
   /// <param name="size">The number of bits to set on.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long SetBits(this long value, int offset = 0, int size = 64)
   {
      return value.SetBits(BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Sets all specified bits to "on" 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to store the value.</param>
   /// <param name="size">The number of bits to set on.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte SetBits(this byte value, int offset = 0, int size = 8)
   {
      return value.SetBits(BitMask.FromRange(offset, size));
   }

   /// <summary>
   /// Sets all specified bits to "on" 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to store the value.</param>
   /// <param name="size">The number of bits to set on.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort SetBits(this ushort value, int offset = 0, int size = 16)
   {
      return value.SetBits(BitMask.FromRange(offset, size));
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
   /// Sets all specified bits to "on" 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to store the value.</param>
   /// <param name="size">The number of bits to set on.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong SetBits(this ulong value, int offset = 0, int size = 64)
   {
      return value.SetBits(BitMask.FromRange(offset, size));
   }

   #endregion

   #region Single bit operations

   /// <summary>
   /// Sets specified bit to "on"
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The offset of the bit to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte SetBit(this sbyte value, int offset) { return value.SetBits(BitMask.FromSingleBit(offset)); }

   /// <summary>
   /// Sets specified bit to "on"
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The offset of the bit to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short SetBit(this short value, int offset) { return value.SetBits(BitMask.FromSingleBit(offset)); }

   /// <summary>
   /// Sets specified bit to "on"
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The offset of the bit to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int SetBit(this int value, int offset) { return value.SetBits(BitMask.FromSingleBit(offset)); }

   /// <summary>
   /// Sets specified bit to "on"
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The offset of the bit to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long SetBit(this long value, int offset) { return value.SetBits(BitMask.FromSingleBit(offset)); }

   /// <summary>
   /// Sets specified bit to "on"
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The offset of the bit to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte SetBit(this byte value, int offset) { return value.SetBits(BitMask.FromSingleBit(offset)); }

   /// <summary>
   /// Sets specified bit to "on"
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The offset of the bit to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort SetBit(this ushort value, int offset) { return value.SetBits(BitMask.FromSingleBit(offset)); }

   /// <summary>
   /// Sets specified bit to "on"
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The offset of the bit to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint SetBit(this uint value, int offset) { return value.SetBits(BitMask.FromSingleBit(offset)); }

   /// <summary>
   /// Sets specified bit to "on"
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The offset of the bit to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong SetBit(this ulong value, int offset) { return value.SetBits(BitMask.FromSingleBit(offset)); }

   #endregion

   #region BitMask operations

   /// <summary>
   /// Sets all specified bits to "on" 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte SetBits(this sbyte value, BitMask mask) { return (sbyte) (value | (sbyte) mask.Bits); }

   /// <summary>
   /// Sets all specified bits to "on" 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short SetBits(this short value, BitMask mask) { return (short) (value | (short) mask.Bits); }

   /// <summary>
   /// Sets all specified bits to "on" 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int SetBits(this int value, BitMask mask) { return value | (int) mask.Bits; }

   /// <summary>
   /// Sets all specified bits to "on" 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long SetBits(this long value, BitMask mask) { return value | (long) mask.Bits; }

   /// <summary>
   /// Sets all specified bits to "on" 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte SetBits(this byte value, BitMask mask) { return (byte) (value | (byte) mask.Bits); }

   /// <summary>
   /// Sets all specified bits to "on" 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort SetBits(this ushort value, BitMask mask) { return (ushort) (value | (ushort) mask.Bits); }

   /// <summary>
   /// Sets all specified bits to "on" 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint SetBits(this uint value, BitMask mask) { return value | (uint) mask.Bits; }

   /// <summary>
   /// Sets all specified bits to "on" 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong SetBits(this ulong value, BitMask mask) { return value | mask.Bits; }

   #endregion
}
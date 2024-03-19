#region

using System.Runtime.CompilerServices;

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
/// Extension methods to aid in toggling bits. 
/// </summary>
public static class ToggleBitsExtensions
{
   #region Range of bits operations

   /// <summary>
   /// Toggles bits and size.
   /// The default values result in toggling all bits. 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The offset of the bits to toggle.</param>
   /// <param name="size">The number of bits to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ToggleBits(this sbyte value, int offset = 0, int size = 8)
   {
      return value.ToggleBits(BitMask.FromRange(offset, size));
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
   public static short ToggleBits(this short value, int offset = 0, int size = 16)
   {
      return value.ToggleBits(BitMask.FromRange(offset, size));
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
   public static int ToggleBits(this int value, int offset = 0, int size = 32)
   {
      return value.ToggleBits(BitMask.FromRange(offset, size));
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
   public static long ToggleBits(this long value, int offset = 0, int size = 64)
   {
      return value.ToggleBits(BitMask.FromRange(offset, size));
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
   public static byte ToggleBits(this byte value, int offset = 0, int size = 8)
   {
      return value.ToggleBits(BitMask.FromRange(offset, size));
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
   public static ushort ToggleBits(this ushort value, int offset = 0, int size = 16)
   {
      return value.ToggleBits(BitMask.FromRange(offset, size));
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
   /// Toggles bits and size. 
   /// The default values result in toggling all bits. 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The offset of the bits to toggle.</param>
   /// <param name="size">The number of bits to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong ToggleBits(this ulong value, int offset = 0, int size = 64)
   {
      return value.ToggleBits(BitMask.FromRange(offset, size));
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
   public static float ToggleBits(this float value, int offset = 0, int size = 32)
   {
      return value.ToggleBits(BitMask.FromRange(offset, size));
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
   public static double ToggleBits(this double value, int offset = 0, int size = 64)
   {
      return value.ToggleBits(BitMask.FromRange(offset, size));
   }

   #endregion

   #region Single bit operations

   /// <summary>
   /// Toggles a bit.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ToggleBit(this sbyte value, int offset)
   {
      return value.ToggleBits(BitMask.FromSingleBit(offset));
   }

   /// <summary>
   /// Toggles a bit.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short ToggleBit(this short value, int offset)
   {
      return value.ToggleBits(BitMask.FromSingleBit(offset));
   }

   /// <summary>
   /// Toggles a bit.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int ToggleBit(this int value, int offset) { return value.ToggleBits(BitMask.FromSingleBit(offset)); }

   /// <summary>
   /// Toggles a bit.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ToggleBit(this long value, int offset) { return value.ToggleBits(BitMask.FromSingleBit(offset)); }

   /// <summary>
   /// Toggles a bit.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ToggleBit(this byte value, int offset) { return value.ToggleBits(BitMask.FromSingleBit(offset)); }

   /// <summary>
   /// Toggles a bit.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort ToggleBit(this ushort value, int offset)
   {
      return value.ToggleBits(BitMask.FromSingleBit(offset));
   }

   /// <summary>
   /// Toggles a bit.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ToggleBit(this uint value, int offset) { return value.ToggleBits(BitMask.FromSingleBit(offset)); }

   /// <summary>
   /// Toggles a bit.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong ToggleBit(this ulong value, int offset)
   {
      return value.ToggleBits(BitMask.FromSingleBit(offset));
   }

   /// <summary>
   /// Toggles a bit.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float ToggleBit(this float value, int offset)
   {
      return value.ToggleBits(BitMask.FromSingleBit(offset));
   }

   /// <summary>
   /// Toggles a bit.
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="offset">The bit location to toggle.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static double ToggleBit(this double value, int offset)
   {
      return value.ToggleBits(BitMask.FromSingleBit(offset));
   }

   #endregion

   #region BitMask operations

   /// <summary>
   /// Toggle all the bits according to the provided mask 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static sbyte ToggleBits(this sbyte value, BitMask mask) { return (sbyte) (value ^ (sbyte) mask.Bits); }

   /// <summary>
   /// Toggle all the bits according to the provided mask 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static short ToggleBits(this short value, BitMask mask) { return (short) (value ^ (short) mask.Bits); }

   /// <summary>
   /// Toggle all the bits according to the provided mask 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static int ToggleBits(this int value, BitMask mask) { return value ^ (int) mask.Bits; }

   /// <summary>
   /// Toggle all the bits according to the provided mask 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static long ToggleBits(this long value, BitMask mask) { return value ^ (long) mask.Bits; }

   /// <summary>
   /// Toggle all the bits according to the provided mask 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static byte ToggleBits(this byte value, BitMask mask) { return (byte) (value ^ (byte) mask.Bits); }

   /// <summary>
   /// Toggle all the bits according to the provided mask 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ushort ToggleBits(this ushort value, BitMask mask) { return (ushort) (value ^ (ushort) mask.Bits); }

   /// <summary>
   /// Toggle all the bits according to the provided mask 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static uint ToggleBits(this uint value, BitMask mask) { return value ^ (uint) mask.Bits; }

   /// <summary>
   /// Toggle all the bits according to the provided mask 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static ulong ToggleBits(this ulong value, BitMask mask) { return value ^ mask.Bits; }

   /// <summary>
   /// Toggle all the bits according to the provided mask 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static float ToggleBits(this float value, BitMask mask)
   {
      return value.BitwiseToUInt32()
                  .ToggleBits(mask)
                  .BitwiseToSingle();
   }

   /// <summary>
   /// Toggle all the bits according to the provided mask 
   /// </summary>
   /// <param name="value">The value to be modified.</param>
   /// <param name="mask">bits to set.</param>
   /// <returns>The modified value.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static double ToggleBits(this double value, BitMask mask)
   {
      return value.BitwiseToUInt64()
                  .ToggleBits(mask)
                  .BitwiseToDouble();
   }

   #endregion
}
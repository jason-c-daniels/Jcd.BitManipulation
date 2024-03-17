using System.Runtime.CompilerServices;

namespace Jcd.BitManipulation;

/// <summary>
/// Provides the ability to check if any bits from a <see cref="BitMask"/> are set on integral integer types.
/// </summary>
public static class AreAnyBitsSetExtensions
{
   /// <summary>
   /// Tests if any bits from the bitmask are set on a <see cref="ulong"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if any of the bits from the bitmask were set.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAnyBitsSet(this ulong data, BitMask bitmask) { return data.ReadBits(0, bitmask) != 0; }

   /// <summary>
   /// Tests if any bits from the bitmask are set on a <see cref="long"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if any of the bits from the bitmask were set.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAnyBitsSet(this long data, BitMask bitmask) { return data.ReadBits(0, bitmask) != 0; }

   /// <summary>
   /// Tests if any bits from the bitmask are set on a <see cref="uint"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if any of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 32 bits of the bitmask will be used. 
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAnyBitsSet(this uint data, BitMask bitmask) { return data.ReadBits(0, bitmask) != 0; }

   /// <summary>
   /// Tests if any bits from the bitmask are set on an <see cref="int"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if any of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 32 bits of the bitmask will be used. 
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAnyBitsSet(this int data, BitMask bitmask) { return data.ReadBits(0, bitmask) != 0; }

   /// <summary>
   /// Tests if any bits from the bitmask are set on a <see cref="ushort"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if any of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 16 bits of the bitmask will be used. 
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAnyBitsSet(this ushort data, BitMask bitmask) { return data.ReadBits(0, bitmask) != 0; }

   /// <summary>
   /// Tests if any bits from the bitmask are set on a <see cref="short"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if any of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 16 bits of the bitmask will be used. 
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAnyBitsSet(this short data, BitMask bitmask) { return data.ReadBits(0, bitmask) != 0; }

   /// <summary>
   /// Tests if any bits from the bitmask are set on a <see cref="byte"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if any of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 8 bits of the bitmask will be used. 
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAnyBitsSet(this byte data, BitMask bitmask) { return data.ReadBits(0, bitmask) != 0; }

   /// <summary>
   /// Tests if any bits from the bitmask are set on an <see cref="sbyte"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if any of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 8 bits of the bitmask will be used. 
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAnyBitsSet(this sbyte data, BitMask bitmask) { return data.ReadBits(0, bitmask) != 0; }
}
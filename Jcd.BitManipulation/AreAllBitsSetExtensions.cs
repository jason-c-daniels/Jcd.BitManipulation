#region

using System;
using System.Runtime.CompilerServices;

#endregion

namespace Jcd.BitManipulation;
 
/// <summary>
/// Provides the ability to check if all bits from a <see cref="BitMask" /> are set on integral integer types.
/// </summary>
[Obsolete("The extension methods in this type are being moved to type-specific classes in v3.0. Change all invocations over to standard extension method invocations!")]
public static class AreAllBitsSetExtensions
{
   /// <summary>
   /// Tests if all of the bits from the bitmask are set on a <see cref="ulong" />.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAllBitsSet(this ulong data, BitMask bitmask)
   {
      return data.ReadBits(0, bitmask) == bitmask;
   }

   /// <summary>
   /// Tests if all of the bits from the bitmask are set on a <see cref="long" />.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAllBitsSet(this long data, BitMask bitmask)
   {
      return data.ReadBits(0, bitmask) == bitmask;
   }

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
   /// Tests if all of the bits from the bitmask are set on an <see cref="int" />.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 32 bits of the bitmask will be used.
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAllBitsSet(this int data, BitMask bitmask)
   {
      return data.ReadBits(0, bitmask) == bitmask;
   }

   /// <summary>
   /// Tests if all of the bits from the bitmask are set on a <see cref="ushort" />.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 16 bits of the bitmask will be used.
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAllBitsSet(this ushort data, BitMask bitmask)
   {
      return data.ReadBits(0, bitmask) == bitmask;
   }

   /// <summary>
   /// Tests if all of the bits from the bitmask are set on a <see cref="short" />.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 16 bits of the bitmask will be used.
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAllBitsSet(this short data, BitMask bitmask)
   {
      return data.ReadBits(0, bitmask) == bitmask;
   }

   /// <summary>
   /// Tests if all of the bits from the bitmask are set on a <see cref="byte" />.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 8 bits of the bitmask will be used.
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAllBitsSet(this byte data, BitMask bitmask)
   {
      return data.ReadBits(0, bitmask) == bitmask;
   }

   /// <summary>
   /// Tests if all of the bits from the bitmask are set on an <see cref="sbyte" />.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 8 bits of the bitmask will be used.
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAllBitsSet(this sbyte data, BitMask bitmask)
   {
      return data.ReadBits(0, bitmask) == bitmask;
   }
}
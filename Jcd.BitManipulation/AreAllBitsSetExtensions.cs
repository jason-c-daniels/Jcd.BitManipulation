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
/// Provides the ability to check if all bits from a <see cref="BitMask" /> are set on integral integer types.
/// </summary>
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

   /// <summary>
   /// Tests if all of the bits from the bitmask are set on a <see cref="float" />.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
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
   /// Tests if all of the bits from the bitmask are set on a <see cref="double" />.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 8 bits of the bitmask will be used.
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreAllBitsSet(this double data, BitMask bitmask)
   {
      return data.ReadBits(0, bitmask) == bitmask;
   }
}
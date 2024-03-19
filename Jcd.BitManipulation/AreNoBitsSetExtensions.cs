using System.Runtime.CompilerServices;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedVariable
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMethodReturnValue.Global
// ReSharper disable UnusedMemberInSuper.Global

namespace Jcd.BitManipulation;

/// <summary>
/// Provides the ability to check if no bits from a <see cref="BitMask"/> are set on integral integer types.
/// </summary>
public static class AreNoBitsSetExtensions
{
   /// <summary>
   /// Tests if none of the bits from the bitmask are set on a <see cref="ulong"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreNoBitsSet(this ulong data, BitMask bitmask) { return data.ReadBits(0, bitmask) == 0; }

   /// <summary>
   /// Tests if none of the bits from the bitmask are set on a <see cref="long"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreNoBitsSet(this long data, BitMask bitmask) { return data.ReadBits(0, bitmask) == 0; }

   /// <summary>
   /// Tests if none of the bits from the bitmask are set on a <see cref="uint"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 32 bits of the bitmask will be used. 
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreNoBitsSet(this uint data, BitMask bitmask) { return data.ReadBits(0, bitmask) == 0; }

   /// <summary>
   /// Tests if none of the bits from the bitmask are set on an <see cref="int"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 32 bits of the bitmask will be used. 
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreNoBitsSet(this int data, BitMask bitmask) { return data.ReadBits(0, bitmask) == 0; }

   /// <summary>
   /// Tests if none of the bits from the bitmask are set on a <see cref="ushort"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 16 bits of the bitmask will be used. 
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreNoBitsSet(this ushort data, BitMask bitmask) { return data.ReadBits(0, bitmask) == 0; }

   /// <summary>
   /// Tests if none of the bits from the bitmask are set on a <see cref="short"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 16 bits of the bitmask will be used. 
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreNoBitsSet(this short data, BitMask bitmask) { return data.ReadBits(0, bitmask) == 0; }

   /// <summary>
   /// Tests if none of the bits from the bitmask are set on a <see cref="byte"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 8 bits of the bitmask will be used. 
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreNoBitsSet(this byte data, BitMask bitmask) { return data.ReadBits(0, bitmask) == 0; }

   /// <summary>
   /// Tests if none of the bits from the bitmask are set on an <see cref="sbyte"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 8 bits of the bitmask will be used. 
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreNoBitsSet(this sbyte data, BitMask bitmask) { return data.ReadBits(0, bitmask) == 0; }

   /// <summary>
   /// Tests if none of the bits from the bitmask are set on an <see cref="float"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 8 bits of the bitmask will be used. 
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreNoBitsSet(this float data, BitMask bitmask) { return data.ReadBits(0, bitmask) == 0; }

   /// <summary>
   /// Tests if none of the bits from the bitmask are set on an <see cref="double"/>.
   /// </summary>
   /// <param name="data">The data to inspect.</param>
   /// <param name="bitmask">the bits to test.</param>
   /// <returns>True if all of the bits from the bitmask were set.</returns>
   /// <remarks>
   /// NB: Only the lowest 8 bits of the bitmask will be used. 
   /// </remarks>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool AreNoBitsSet(this double data, BitMask bitmask) { return data.ReadBits(0, bitmask) == 0; }
}
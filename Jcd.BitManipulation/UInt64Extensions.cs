#region

using System;
using System.Runtime.CompilerServices;

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// Provides easy to read methods for bit manipulation operations on a <see cref="ulong" />
/// </summary>
/// <exclude />
public static class UInt64Extensions
{
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   internal static ulong InternalBigEndianStoreByte(this ulong value, byte @byte, int offset)
   {
      var beOffset = sizeof(ulong) - offset - 1;

      return value.StoreBits(@byte, beOffset << 3, 8);
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   internal static ulong InternalLittleEndianStoreByte(this ulong value, byte @byte, int offset)
   {
      return value.StoreBits(@byte, offset << 3, 8);
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   internal static byte InternalBigEndianReadByte(this ulong value, int offset)
   {
      var beOffset = sizeof(ulong) - offset - 1;

      return (byte) value.ReadBits(beOffset << 3, BitMask.BigEndianByteMasks[offset]);
   }

   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   internal static byte InternalLittleEndianReadByte(this ulong value, int offset)
   {
      return (byte) value.ReadBits(offset << 3, BitMask.LittleEndianByteMasks[offset]);
   }
}
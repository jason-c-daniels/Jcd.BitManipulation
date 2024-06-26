#region

using System;
using System.Runtime.CompilerServices;
using System.Text;

// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable UnusedMember.Global
// ReSharper disable HeapView.ObjectAllocation
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
/// Provides an integer size independent representation of a bit mask
/// and helper methods to simplify creating bit masks.
/// </summary>
public readonly struct BitMask : IEquatable<BitMask>
{
   #region Equality and HashCode

   /// <summary>
   /// Compares this instance to another for equality.
   /// </summary>
   /// <param name="other"></param>
   /// <returns>true if equivalent.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public bool Equals(BitMask other)
   {
      return bits == other.bits;
   }

   /// <summary>
   /// compares this instance agains an object for equality.
   /// </summary>
   /// <param name="obj">The target of the comparison.</param>
   /// <returns>true if equivalent</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public override bool Equals(object obj)
   {
      return obj is BitMask other && Equals(other);
   }

   /// <summary>
   /// Gets the hashcode for this instance.
   /// </summary>
   /// <returns></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public override int GetHashCode()
   {
      return bits.GetHashCode();
   }

   /// <summary>
   /// Compares two <see cref="BitMask" /> instances for equality.
   /// </summary>
   /// <param name="left">The left side of the comparison.</param>
   /// <param name="right">The right side of the comparison.</param>
   /// <returns>True if equivalent.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator ==(BitMask left, BitMask right)
   {
      return left.Equals(right);
   }

   /// <summary>
   /// Compares two <see cref="BitMask" /> instances for inequality.
   /// </summary>
   /// <param name="left">The left side of the comparison.</param>
   /// <param name="right">The right side of the comparison.</param>
   /// <returns>True if not equivalent.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static bool operator !=(BitMask left, BitMask right)
   {
      return !left.Equals(right);
   }

   #endregion

   #region Bit Manipulation Operators

   /// <summary>
   /// Bitwise or
   /// </summary>
   /// <param name="left">left side</param>
   /// <param name="right">right side</param>
   /// <returns>A bitmask representing the bitwise or result.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BitMask operator |(BitMask left, BitMask right)
   {
      return left.bits | right.bits;
   }

   /// <summary>
   /// Bitwise AND
   /// </summary>
   /// <param name="left">Left side</param>
   /// <param name="right">Right side</param>
   /// <returns>A bitmask representing the bitwise or result.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BitMask operator &(BitMask left, BitMask right)
   {
      return left.bits & right.bits;
   }

   /// <summary>
   /// Bitwise XOR
   /// </summary>
   /// <param name="left">Left side</param>
   /// <param name="right">Right side</param>
   /// <returns>A bitmask representing the bitwise or result.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BitMask operator ^(BitMask left, BitMask right)
   {
      return left.bits ^ right.bits;
   }

   /// <summary>
   /// Bitwise left shift
   /// </summary>
   /// <param name="value">Left side</param>
   /// <param name="shift">Right side</param>
   /// <returns>A bitmask representing the bitwise or result.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BitMask operator <<(BitMask value, int shift)
   {
      return value.bits << shift;
   }

   /// <summary>
   /// Bitwise right shift
   /// </summary>
   /// <param name="value">Left side</param>
   /// <param name="shift">Right side</param>
   /// <returns>A bitmask representing the bitwise or result.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BitMask operator >> (BitMask value, int shift)
   {
      return value.bits >> shift;
   }

   /// <summary>
   /// Bitwise complement
   /// </summary>
   /// <param name="value">Left side</param>
   /// <returns>A bitmask representing the bitwise or result.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BitMask operator ~(BitMask value)
   {
      return ~value.bits;
   }

   #endregion

   /// <summary>
   /// A bitmask with all bits set in the mask.
   /// </summary>
   public static readonly BitMask AllBits = ulong.MaxValue;

   /// <summary>
   /// A bitmask for the first byte in a number.
   /// </summary>
   /// <exclude />
   private static readonly BitMask Byte = 0xFF;

   /// <summary>
   /// A bitmask for the second byte in a number.
   /// </summary>
   /// <exclude />
   private static readonly BitMask Byte1 = (ulong) Byte << 8;

   /// <summary>
   /// A bitmask for the third byte in a number.
   /// </summary>
   /// <exclude />
   private static readonly BitMask Byte2 = (ulong) Byte1 << 8;

   /// <summary>
   /// A bitmask for the fourth byte in a number.
   /// </summary>
   /// <exclude />
   private static readonly BitMask Byte3 = (ulong) Byte2 << 8;

   /// <summary>
   /// A bitmask for the fifth byte in a number.
   /// </summary>
   /// <exclude />
   private static readonly BitMask Byte4 = (ulong) Byte3 << 8;

   /// <summary>
   /// A bitmask for the sixth byte in a number.
   /// </summary>
   /// <exclude />
   private static readonly BitMask Byte5 = (ulong) Byte4 << 8;

   /// <summary>
   /// A bitmask for the seventh byte in a number.
   /// </summary>
   /// <exclude />
   private static readonly BitMask Byte6 = (ulong) Byte5 << 8;

   /// <summary>
   /// A bitmask for the seventh byte in a number.
   /// </summary>
   /// <exclude />
   private static readonly BitMask Byte7 = (ulong) Byte6 << 8;

   internal static readonly BitMask[] BigEndianByteMasks = [Byte7, Byte6, Byte5, Byte4, Byte3, Byte2, Byte1, Byte];

   internal static readonly BitMask[] LittleEndianByteMasks = [Byte, Byte1, Byte2, Byte3, Byte4, Byte5, Byte6, Byte7];

   /// <summary>
   /// The backing store for the actual bits of the <see cref="BitMask" />.
   /// </summary>
   /// <exclude />
   private readonly ulong bits;

   #region Helpers

   /// <summary>
   /// Create a <see cref="BitMask" /> with a range of bits set.
   /// </summary>
   /// <param name="offset">the lowest bit to start turning on</param>
   /// <param name="size">the number of bits to set to 1</param>
   /// <returns>the shifted mask</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BitMask FromRange(int offset = 0, int size = sizeof(ulong) * BitSizeConstants.BitsPerByte)
   {
      return size == sizeof(ulong) * BitSizeConstants.BitsPerByte
                ? new BitMask(ulong.MaxValue            << offset)
                : new BitMask((((ulong) 1 << size) - 1) << offset);
   }

   /// <summary>
   /// Create a <see cref="BitMask" /> with a single bit set.
   /// </summary>
   /// <param name="offset">the bit to set</param>
   /// <returns>a <see cref="BitMask" /> with the specified bit set.</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static BitMask FromSingleBit(int offset)
   {
      return new BitMask((ulong) 1 << offset);
   }

   #endregion

   #region constructors

   /// <summary>
   /// Copies a existing <see cref="BitMask" />
   /// </summary>
   /// <param name="mask">The <see cref="BitMask" /> to copy</param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BitMask(BitMask mask)
   {
      bits = mask.bits;
   }

   /// <summary>
   /// Constructs a <see cref="BitMask" /> from a <see cref="ulong" />
   /// </summary>
   /// <param name="bits">The bits to use for the <see cref="BitMask" /></param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BitMask(ulong bits)
   {
      this.bits = bits;
   }

   /// <summary>
   /// Constructs a <see cref="BitMask" /> from a <see cref="long" />
   /// </summary>
   /// <param name="bits">The bits to use for the <see cref="BitMask" /></param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BitMask(long bits)
      : this((ulong) bits)
   {
   }

   /// <summary>
   /// Constructs a <see cref="BitMask" /> from a <see cref="uint" />
   /// </summary>
   /// <param name="bits">The bits to use for the <see cref="BitMask" /></param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BitMask(uint bits)
      : this((ulong) bits)
   {
   }

   /// <summary>
   /// Constructs a <see cref="BitMask" /> from a <see cref="int" />
   /// </summary>
   /// <param name="bits">The bits to use for the <see cref="BitMask" /></param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BitMask(int bits)
      : this((uint) bits)
   {
   }

   /// <summary>
   /// Constructs a <see cref="BitMask" /> from a <see cref="ushort" />
   /// </summary>
   /// <param name="bits">The bits to use for the <see cref="BitMask" /></param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BitMask(ushort bits)
      : this((ulong) bits)
   {
   }

   /// <summary>
   /// Constructs a <see cref="BitMask" /> from a <see cref="short" />
   /// </summary>
   /// <param name="bits">The bits to use for the <see cref="BitMask" /></param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BitMask(short bits)
      : this((ushort) bits)
   {
   }

   /// <summary>
   /// Constructs a <see cref="BitMask" /> from a <see cref="byte" />
   /// </summary>
   /// <param name="bits">The bits to use for the <see cref="BitMask" /></param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BitMask(byte bits)
      : this((ulong) bits)
   {
   }

   /// <summary>
   /// Constructs a <see cref="BitMask" /> from a <see cref="sbyte" />
   /// </summary>
   /// <param name="bits">The bits to use for the <see cref="BitMask" /></param>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public BitMask(sbyte bits)
      : this((byte) bits)
   {
   }

   #endregion

   /// <summary>
   /// Formats the <see cref="BitMask" /> as a "0b" prefixed string of zeroes and ones.
   /// </summary>
   /// <returns>the bits of the mask formatted as 0b0101...1111</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public override string ToString()
   {
      const ulong highBit = (ulong) 1 << 63;
      var sb = new StringBuilder();
      var tmp = bits;
      sb.Append("0b");

      for (var i = 0; i < sizeof(ulong) * BitSizeConstants.BitsPerByte; i++)
      {
         sb.Append((tmp & highBit) > 0
                      ? '1'
                      : '0'
                  );
         tmp <<= 1;
      }

      return sb.ToString();
   }

   #region implicit conversion operators.

   /// <summary>
   /// Automatically convert to a <see cref="sbyte" /> from a <see cref="BitMask" />
   /// </summary>
   /// <param name="mask">the <see cref="BitMask" /> to convert from.</param>
   /// <returns>the lowest 8 bits of the mask as a <see cref="sbyte" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator sbyte(BitMask mask)
   {
      return (sbyte) (mask.bits & byte.MaxValue);
   }

   /// <summary>
   /// Automatically convert to a <see cref="byte" /> from a <see cref="BitMask" />
   /// </summary>
   /// <param name="mask">the <see cref="BitMask" /> to convert from.</param>
   /// <returns>the lowest 8 bits of the mask as a <see cref="byte" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator byte(BitMask mask)
   {
      return (byte) (mask.bits & byte.MaxValue);
   }

   /// <summary>
   /// Automatically convert to a <see cref="short" /> from a <see cref="BitMask" />
   /// </summary>
   /// <param name="mask">the <see cref="BitMask" /> to convert from.</param>
   /// <returns>the lowest 16 bits of the mask as a <see cref="short" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator short(BitMask mask)
   {
      return (short) (mask.bits & ushort.MaxValue);
   }

   /// <summary>
   /// Automatically convert to <see cref="ushort" /> from a <see cref="BitMask" />
   /// </summary>
   /// <param name="mask">the <see cref="BitMask" /> to convert from.</param>
   /// <returns>the lowest 16 bits of the mask as a <see cref="ushort" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator ushort(BitMask mask)
   {
      return (ushort) (mask.bits & ushort.MaxValue);
   }

   /// <summary>
   /// Automatically convert to <see cref="int" /> from a <see cref="BitMask" />
   /// </summary>
   /// <param name="mask">the <see cref="BitMask" /> to convert from.</param>
   /// <returns>the lowest 32 bits of the mask as a int</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator int(BitMask mask)
   {
      return (int) (mask.bits & uint.MaxValue);
   }

   /// <summary>
   /// Automatically convert to <see cref="uint" /> from a <see cref="BitMask" />
   /// </summary>
   /// <param name="mask"></param>
   /// <returns>the lowest 32 bits of the mask as a uint</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator uint(BitMask mask)
   {
      return (uint) (mask.bits & uint.MaxValue);
   }

   /// <summary>
   /// Automatically convert to <see cref="long" /> from a <see cref="BitMask" />
   /// </summary>
   /// <param name="mask">the <see cref="BitMask" /> to convert from.</param>
   /// <returns>the bits of the mask as a <see cref="long" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator long(BitMask mask)
   {
      return (long) mask.bits;
   }

   /// <summary>
   /// Automatically convert to <see cref="ulong" /> from a <see cref="BitMask" />
   /// </summary>
   /// <param name="mask">the <see cref="BitMask" /> to convert from.</param>
   /// <returns>the bits of the mask as a <see cref="ulong" /></returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator ulong(BitMask mask)
   {
      return mask.bits;
   }

   /// <summary>
   /// Automatically convert to <see cref="BitMask" /> from a <see cref="sbyte" />
   /// </summary>
   /// <param name="bits">The value to convert to a <see cref="BitMask" />.</param>
   /// <returns>The <see cref="BitMask" /> constructed from the provided bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitMask(sbyte bits)
   {
      return new BitMask(bits);
   }

   /// <summary>
   /// Automatically convert to <see cref="BitMask" /> from a <see cref="byte" />
   /// </summary>
   /// <param name="bits">the value to convert to a BitMask</param>
   /// <returns>The <see cref="BitMask" /> constructed from the provided bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitMask(short bits)
   {
      return new BitMask(bits);
   }

   /// <summary>
   /// Automatically convert to <see cref="BitMask" /> from a <see cref="int" />
   /// </summary>
   /// <param name="bits">The value to convert to a <see cref="BitMask" />.</param>
   /// <returns>The <see cref="BitMask" /> constructed from the provided bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitMask(int bits)
   {
      return new BitMask(bits);
   }

   /// <summary>
   /// Automatically convert to <see cref="BitMask" /> from a <see cref="long" />
   /// </summary>
   /// <param name="bits">The value to convert to a <see cref="BitMask" />.</param>
   /// <returns>The <see cref="BitMask" /> constructed from the provided bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitMask(long bits)
   {
      return new BitMask(bits);
   }

   /// <summary>
   /// Automatically convert to <see cref="BitMask" /> from a <see cref="byte" />
   /// </summary>
   /// <param name="bits">The value to convert to a <see cref="BitMask" />.</param>
   /// <returns>The <see cref="BitMask" /> constructed from the provided bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitMask(byte bits)
   {
      return new BitMask(bits);
   }

   /// <summary>
   /// Automatically convert to <see cref="BitMask" /> from a <see cref="ushort" />
   /// </summary>
   /// <param name="bits">The value to convert to a <see cref="BitMask" />.</param>
   /// <returns>The <see cref="BitMask" /> constructed from the provided bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitMask(ushort bits)
   {
      return new BitMask(bits);
   }

   /// <summary>
   /// Automatically convert to <see cref="BitMask" /> from a <see cref="uint" />
   /// </summary>
   /// <param name="bits">The value to convert to a <see cref="BitMask" />.</param>
   /// <returns>The <see cref="BitMask" /> constructed from the provided bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitMask(uint bits)
   {
      return new BitMask(bits);
   }

   /// <summary>
   /// Automatically convert to <see cref="BitMask" /> from a <see cref="ulong" />
   /// </summary>
   /// <param name="bits">The value to convert to a <see cref="BitMask" />.</param>
   /// <returns>The <see cref="BitMask" /> constructed from the provided bits</returns>
   [MethodImpl(MethodImplOptions.AggressiveInlining)]
   public static implicit operator BitMask(ulong bits)
   {
      return new BitMask(bits);
   }

   #endregion
}
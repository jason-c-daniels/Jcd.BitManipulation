#region

using System.Text;

// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable UnusedMember.Global

#endregion

namespace Jcd.BitManipulation;

/// <summary>
/// An conceptual abstraction for a bit mask.
/// </summary>
public readonly struct BitMask
{
   /// <summary>
   /// A default bitmask signifying all bits have been set.
   /// </summary>
   public static readonly BitMask AllBits = ulong.MaxValue;

   /// <summary>
   /// The backing store for the actual bits of the <see cref="BitMask"/>.
   /// </summary>
   public readonly ulong Bits;

   #region Helpers

   /// <summary>
   /// Create a 64 bit <see cref="BitMask"/> with a range of bits set.  
   /// </summary>
   /// <param name="offset">the lowest bit to start turning on</param>
   /// <param name="size">the number of bits to set to 1</param>
   /// <returns>the shifted mask</returns>
   public static BitMask FromRange(int offset = 0, int size = 64)
   {
      return size == 64
                ? new BitMask(ulong.MaxValue            << offset)
                : new BitMask((((ulong) 1 << size) - 1) << offset);
   }

   /// <summary>
   /// Create a 64 bit bit <see cref="BitMask"/> with a single bit set.
   /// </summary>
   /// <param name="offset">the bit to set</param>
   /// <returns>a <see cref="BitMask"/> with the specified bit set.</returns>
   public static BitMask FromSingleBit(int offset) { return new BitMask((ulong) 1 << offset); }

   #endregion

   #region constructors

   /// <summary>
   /// Copies an existing <see cref="BitMask"/>
   /// </summary>
   /// <param name="mask">The <see cref="BitMask"/> to copy</param>
   public BitMask(BitMask mask) { Bits = mask.Bits; }

   /// <summary>
   /// Constructs a <see cref="BitMask"/> from a <see cref="ulong"/>  
   /// </summary>
   /// <param name="bits">The <see cref="BitMask"/> to use</param>
   public BitMask(ulong bits) { Bits = bits; }

   /// <summary>
   /// Constructs a <see cref="BitMask"/> from a <see cref="long"/>  
   /// </summary>
   /// <param name="bits">The <see cref="BitMask"/> to use</param>
   public BitMask(long bits) : this((ulong) bits) { }

   /// <summary>
   /// Constructs a <see cref="BitMask"/> from a <see cref="uint"/>  
   /// </summary>
   /// <param name="bits">The <see cref="BitMask"/> to use</param>
   public BitMask(uint bits) : this((ulong) bits) { }

   /// <summary>
   /// Constructs a <see cref="BitMask"/> from an <see cref="int"/>  
   /// </summary>
   /// <param name="bits">The <see cref="BitMask"/> to use</param>
   public BitMask(int bits) : this((uint) bits) { }

   /// <summary>
   /// Create a bitmask  
   /// </summary>
   /// <param name="bits">The <see cref="BitMask"/> to use</param>
   public BitMask(ushort bits) : this((ulong) bits) { }

   /// <summary>
   /// Constructs a <see cref="BitMask"/> from a <see cref="short"/>  
   /// </summary>
   /// <param name="bits">The <see cref="BitMask"/> to use</param>
   public BitMask(short bits) : this((ushort) bits) { }

   /// <summary>
   /// Constructs a <see cref="BitMask"/> from a <see cref="byte"/>  
   /// </summary>
   /// <param name="bits">The <see cref="BitMask"/> to use</param>
   public BitMask(byte bits) : this((ulong) bits) { }

   /// <summary>
   /// Constructs a <see cref="BitMask"/> from an <see cref="sbyte"/>  
   /// </summary>
   /// <param name="bits">The <see cref="BitMask"/> to use</param>
   public BitMask(sbyte bits) : this((byte) bits) { }

   #endregion

   /// <summary>
   /// Formats the <see cref="BitMask"/> as a "0b" prefixed string of zeroes and ones.
   /// </summary>
   /// <returns>the bits of the mask formatted as 0b0101...1111</returns>
   public override string ToString()
   {
      const ulong highBit = (ulong) 1 << 63;
      var         sb      = new StringBuilder();
      var         tmp     = Bits;
      sb.Append("0b");

      for (var i = 0; i < 64; i++)
      {
         sb.Append((tmp & highBit) > 0 ? '1' : '0');
         tmp <<= 1;
      }

      return sb.ToString();
   }

   #region implicit conversion operators.

   /// <summary>
   /// Automatically convert to <see cref="sbyte"/> from a <see cref="BitMask"/>
   /// </summary>
   /// <param name="mask">the <see cref="BitMask"/> to convert from.</param>
   /// <returns>the lowest 8 bits of the mask as a signed <see cref="sbyte"/></returns>
   public static implicit operator sbyte(BitMask mask)
   {
      return (sbyte) (mask.Bits & byte.MaxValue);

      // limit to the lower 8 bits.
   }

   /// <summary>
   /// Automatically convert to <see cref="byte"/> from a <see cref="BitMask"/>
   /// </summary>
   /// <param name="mask">the <see cref="BitMask"/> to convert from.</param>
   /// <returns>the lowest 8 bits of the mask as a <see cref="byte"/></returns>
   public static implicit operator byte(BitMask mask)
   {
      return (byte) (mask.Bits & byte.MaxValue);

      // ensure we only return the lower 8 bits
   }

   /// <summary>
   /// Automatically convert to <see cref="short"/> from a <see cref="BitMask"/>
   /// </summary>
   /// <param name="mask">the <see cref="BitMask"/> to convert from.</param>
   /// <returns>the lowest 16 bits of the mask as a <see cref="short"/></returns>
   public static implicit operator short(BitMask mask)
   {
      return (short) (mask.Bits & ushort.MaxValue);

      // limit to the lower 16 bits
   }

   /// <summary>
   /// Automatically convert to <see cref="ushort"/> from a <see cref="BitMask"/>
   /// </summary>
   /// <param name="mask">the <see cref="BitMask"/> to convert from.</param>
   /// <returns>the lowest 16 bits of the mask as a <see cref="ushort"/></returns>
   public static implicit operator ushort(BitMask mask)
   {
      return (ushort) (mask.Bits & ushort.MaxValue);

      // ensure we only return the lower 16 bits
   }

   /// <summary>
   /// Automatically convert to <see cref="int"/> from a <see cref="BitMask"/>
   /// </summary>
   /// <param name="mask">the <see cref="BitMask"/> to convert from.</param>
   /// <returns>the lowest 32 bits of the mask as an int</returns>
   public static implicit operator int(BitMask mask)
   {
      return (int) (mask.Bits & uint.MaxValue);

      // limit to the lower 32 bits
   }

   /// <summary>
   /// Automatically convert to <see cref="uint"/> from a <see cref="BitMask"/>
   /// </summary>
   /// <param name="mask"></param>
   /// <returns>the lowest 32 bits of the mask as a uint</returns>
   public static implicit operator uint(BitMask mask)
   {
      return (uint) (mask.Bits & uint.MaxValue);

      // ensure we only return the lower 32 bits
   }

   /// <summary>
   /// Automatically convert to <see cref="long"/> from a <see cref="BitMask"/>
   /// </summary>
   /// <param name="mask">the <see cref="BitMask"/> to convert from.</param>
   /// <returns>the bits of the mask as a <see cref="long"/></returns>
   public static implicit operator long(BitMask mask) { return (long) mask.Bits; }

   /// <summary>
   /// Automatically convert to <see cref="ulong"/> from a <see cref="BitMask"/>
   /// </summary>
   /// <param name="mask">the <see cref="BitMask"/> to convert from.</param>
   /// <returns>the bits of the mask as a <see cref="ulong"/></returns>
   public static implicit operator ulong(BitMask mask) { return mask.Bits; }

   /// <summary>
   /// Automatically convert to <see cref="BitMask"/> from an <see cref="sbyte"/>
   /// </summary>
   /// <param name="bits">the value to convert to a <see cref="BitMask"/></param>
   /// <returns>the <see cref="BitMask"/> object constructed from the bits</returns>
   public static implicit operator BitMask(sbyte bits) { return new BitMask(bits); }

   /// <summary>
   /// Automatically convert to <see cref="BitMask"/> from a <see cref="byte"/>
   /// </summary>
   /// <param name="bits">the value to convert to a BitMask</param>
   /// <returns>the <see cref="BitMask"/> object constructed from the bits</returns>
   public static implicit operator BitMask(short bits) { return new BitMask(bits); }

   /// <summary>
   /// Automatically convert to <see cref="BitMask"/> from an <see cref="int"/>
   /// </summary>
   /// <param name="bits">the value to convert to a <see cref="BitMask"/></param>
   /// <returns>the <see cref="BitMask"/> object constructed from the bits</returns>
   public static implicit operator BitMask(int bits) { return new BitMask(bits); }

   /// <summary>
   /// Automatically convert to <see cref="BitMask"/> from a <see cref="long"/>
   /// </summary>
   /// <param name="bits">the value to convert to a <see cref="BitMask"/></param>
   /// <returns>the <see cref="BitMask"/> object constructed from the bits</returns>
   public static implicit operator BitMask(long bits) { return new BitMask(bits); }

   /// <summary>
   /// Automatically convert to <see cref="BitMask"/> from a <see cref="byte"/>
   /// </summary>
   /// <param name="bits">the value to convert to a <see cref="BitMask"/></param>
   /// <returns>the <see cref="BitMask"/> object constructed from the bits</returns>
   public static implicit operator BitMask(byte bits) { return new BitMask(bits); }

   /// <summary>
   /// Automatically convert to <see cref="BitMask"/> from a <see cref="ushort"/>
   /// </summary>
   /// <param name="bits">the value to convert to a <see cref="BitMask"/></param>
   /// <returns>the <see cref="BitMask"/> object constructed from the bits</returns>
   public static implicit operator BitMask(ushort bits) { return new BitMask(bits); }

   /// <summary>
   /// Automatically convert to <see cref="BitMask"/> from a <see cref="uint"/>
   /// </summary>
   /// <param name="bits">the value to convert to a <see cref="BitMask"/></param>
   /// <returns>the <see cref="BitMask"/> object constructed from the bits</returns>
   public static implicit operator BitMask(uint bits) { return new BitMask(bits); }

   /// <summary>
   /// Automatically convert to <see cref="BitMask"/> from a <see cref="ulong"/>
   /// </summary>
   /// <param name="bits">the value to convert to a <see cref="BitMask"/></param>
   /// <returns>the <see cref="BitMask"/> object constructed from the bits</returns>
   public static implicit operator BitMask(ulong bits) { return new BitMask(bits); }

   #endregion
}
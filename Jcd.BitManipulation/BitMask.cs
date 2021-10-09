using System.Text;

namespace Jcd.BitManipulation
{
    /// <summary>
    /// An abstraction and factory methods to aid in bit manipulation.
    /// </summary>
    public struct BitMask
    {
        /// <summary>
        /// The backing store for the actual bits of the bitmask.
        /// </summary>
        public ulong Bits;

        #region Helpers
        /// <summary>
        /// Create a 64 bit, bitmask of a specified bit size and bit location within the number.  
        /// </summary>
        /// <param name="offset">the lowest bit to start turning on</param>
        /// <param name="size">the number of bits to set to 1</param>
        /// <returns>the shifted mask</returns>
        public static BitMask CreateRange(int offset=0, int size=64) =>
            size == 64  ?
                  new BitMask(ulong.MaxValue << offset)
                : new BitMask(((((ulong)1 << size) - 1) << offset));

        /// <summary>
        /// Create a 64 bit, single bit bitmask, given bit position.
        /// </summary>
        /// <param name="offset">the lowest bit to start turning on</param>
        /// <returns>the shifted mask</returns>
        public static BitMask CreateSingleBit(int offset) => new BitMask((ulong) 1 << offset);
        #endregion

        #region constructors
        /// <summary>
        /// Copy constructor  
        /// </summary>
        /// <param name="mask">The BitMask to copy</param>
        public BitMask(BitMask mask) { Bits = mask.Bits; }

        /// <summary>
        /// Create a bitmask  
        /// </summary>
        /// <param name="bits">The BitMask to use</param>
        public BitMask(ulong bits) { this.Bits = bits; }

        /// <summary>
        /// Create a bitmask  
        /// </summary>
        /// <param name="bits">The BitMask to use</param>
        public BitMask(long bits) : this((ulong)bits) { }

        /// <summary>
        /// Create a bitmask  
        /// </summary>
        /// <param name="bits">The BitMask to use</param>
        public BitMask(uint bits)  : this((ulong)bits) { }
        
        /// <summary>
        /// Create a bitmask  
        /// </summary>
        /// <param name="bits">The BitMask to use</param>
        public BitMask(int bits)  : this((uint)bits) { }

        /// <summary>
        /// Create a bitmask  
        /// </summary>
        /// <param name="bits">The BitMask to use</param>
        public BitMask(ushort bits)  : this((ulong)bits) { }
        
        /// <summary>
        /// Create a bitmask  
        /// </summary>
        /// <param name="bits">The BitMask to use</param>
        public BitMask(short bits)  : this((ushort)bits) { }
        
        /// <summary>
        /// Create a bitmask  
        /// </summary>
        /// <param name="bits">The BitMask to use</param>
        public BitMask(byte bits)  : this((ulong)bits) { }
        
        /// <summary>
        /// Create a bitmask  
        /// </summary>
        /// <param name="bits">The BitMask to use</param>
        public BitMask(sbyte bits)  : this((byte)bits) { }
        #endregion

        /// <summary>
        /// Format as a bit representation
        /// </summary>
        /// <returns>the bits of the mask formatted as 0b0101...1111</returns>
        public override string ToString()
        {
            const ulong highBit = ((ulong)1) << 63;
            var sb = new StringBuilder();
            var tmp = Bits;
            sb.Append("0b");
            for (int i = 0; i < 64; i++)
            {
                sb.Append((tmp & highBit) > 0 ? '1' : '0');
                tmp <<= 1;
            }
            return sb.ToString();
        }

        #region implicit cast operations.        

        /// <summary>
        /// Automatically convert to sbyte from a BitMask
        /// </summary>
        /// <param name="mask"></param>
        /// <returns>the lowest 8 bits of the mask as a signed byte</returns>
        public static implicit operator sbyte(BitMask mask) => (sbyte)(mask.Bits & byte.MaxValue); // limit to the lower 8 bits.

        /// <summary>
        /// Automatically convert to byte from a BitMask
        /// </summary>
        /// <param name="mask"></param>
        /// <returns>the lowest 8 bits of the mask as a byte</returns>
        public static implicit operator byte(BitMask mask) => (byte)(mask.Bits & byte.MaxValue); // ensure we only return the lower 8 bits
        
        /// <summary>
        /// Automatically convert to short from a BitMask
        /// </summary>
        /// <param name="mask"></param>
        /// <returns>the lowest 16 bits of the mask as a short</returns>
        public static implicit operator short(BitMask mask) => (short)(mask.Bits & ushort.MaxValue); // limit to the lower 16 bits

        /// <summary>
        /// Automatically convert to ushort from a BitMask
        /// </summary>
        /// <param name="mask"></param>
        /// <returns>the lowest 16 bits of the mask as a ushort</returns>
        public static implicit operator ushort(BitMask mask) => (ushort)(mask.Bits & ushort.MaxValue); // ensure we only return the lower 16 bits
        
        /// <summary>
        /// Automatically convert to int from a BitMask
        /// </summary>
        /// <param name="mask"></param>
        /// <returns>the lowest 32 bits of the mask as an int</returns>
        public static implicit operator int(BitMask mask) => (int)(mask.Bits & uint.MaxValue); // limit to the lower 32 bits

        /// <summary>
        /// Automatically convert to uint from a BitMask
        /// </summary>
        /// <param name="mask"></param>
        /// <returns>the lowest 32 bits of the mask as a uint</returns>
        public static implicit operator uint(BitMask mask) => (uint)(mask.Bits & uint.MaxValue); // ensure we only return the lower 32 bits

        /// <summary>
        /// Automatically convert to long from a BitMask
        /// </summary>
        /// <param name="mask"></param>
        /// <returns>the bits of the mask as a long</returns>
        public static implicit operator long(BitMask mask) => (long)mask.Bits;

        /// <summary>
        /// Automatically convert to ulong from a BitMask
        /// </summary>
        /// <param name="mask"></param>
        /// <returns>the bits of the mask as a ulong</returns>
        public static implicit operator ulong(BitMask mask) => mask.Bits;
        
        /// <summary>
        /// Automatically convert to BitMask from an sbyte
        /// </summary>
        /// <param name="bits">the value to convert to a BitMask</param>
        /// <returns>the BitMask object constructed from the bits</returns>
        public static implicit operator BitMask(sbyte bits) => new BitMask(bits);

        /// <summary>
        /// Automatically convert to BitMask from a byte
        /// </summary>
        /// <param name="bits">the value to convert to a BitMask</param>
        /// <returns>the BitMask object constructed from the bits</returns>
        public static implicit operator BitMask(short bits) => new BitMask(bits);
        
        /// <summary>
        /// Automatically convert to BitMask from an int
        /// </summary>
        /// <param name="bits">the value to convert to a BitMask</param>
        /// <returns>the BitMask object constructed from the bits</returns>
        public static implicit operator BitMask(int bits) => new BitMask(bits);
        
        /// <summary>
        /// Automatically convert to BitMask from a long
        /// </summary>
        /// <param name="bits">the value to convert to a BitMask</param>
        /// <returns>the BitMask object constructed from the bits</returns>
        public static implicit operator BitMask(long bits) => new BitMask(bits);
        
        /// <summary>
        /// Automatically convert to BitMask from a byte
        /// </summary>
        /// <param name="bits">the value to convert to a BitMask</param>
        /// <returns>the BitMask object constructed from the bits</returns>
        public static implicit operator BitMask(byte bits) => new BitMask(bits);

        /// <summary>
        /// Automatically convert to BitMask from a ushort
        /// </summary>
        /// <param name="bits">the value to convert to a BitMask</param>
        /// <returns>the BitMask object constructed from the bits</returns>
        public static implicit operator BitMask(ushort bits) => new BitMask(bits);

        /// <summary>
        /// Automatically convert to BitMask from a uint
        /// </summary>
        /// <param name="bits">the value to convert to a BitMask</param>
        /// <returns>the BitMask object constructed from the bits</returns>
        public static implicit operator BitMask(uint bits) => new BitMask(bits);

        /// <summary>
        /// Automatically convert to BitMask from a ulong
        /// </summary>
        /// <param name="bits">the value to convert to a BitMask</param>
        /// <returns>the BitMask object constructed from the bits</returns>
        public static implicit operator BitMask(ulong bits) => new BitMask(bits);
#endregion        
    }
}
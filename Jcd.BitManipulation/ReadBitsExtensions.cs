namespace Jcd.BitManipulation
{
    public static class ReadBitsExtensions
    {
        #region operations on ranges of bits.
        
        /// <summary>
        /// For a given value return the specified bits from within it, right shifted pos bits.
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="size">The total number of bits to extract</param>
        /// <returns>The numeric value stored at that bit location</returns>
        public static sbyte ReadBits(this sbyte self, byte offset, byte size)
            => self.ReadBits(offset, BitMask.CreateRange(offset, size));

        /// <summary>
        /// For a given value return the specified bits from within it, right shifted pos bits.
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="size">The total number of bits to extract</param>
        /// <returns>The numeric value stored at that bit location</returns>
        public static short ReadBits(this short self, byte offset, byte size)
            => self.ReadBits(offset, BitMask.CreateRange(offset, size));

        /// <summary>
        /// For a given value return the specified bits from within it, right shifted pos bits.
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="size">The total number of bits to extract</param>
        /// <returns>The numeric value stored at that bit location</returns>
        public static int ReadBits(this int self, byte offset, byte size)
            => self.ReadBits(offset, BitMask.CreateRange(offset, size));

        /// <summary>
        /// For a given value return the specified bits from within it, right shifted pos bits.
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="size">The total number of bits to extract</param>
        /// <returns>The numeric value stored at that bit location</returns>
        public static long ReadBits(this long self, byte offset, byte size)
            => self.ReadBits(offset, BitMask.CreateRange(offset, size));

        /// <summary>
        /// For a given value return the specified bits from within it, right shifted pos bits.
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="size">The total number of bits to extract</param>
        /// <returns>The numeric value stored at that bit location</returns>
        public static byte ReadBits(this byte self, byte offset, byte size)
            => self.ReadBits(offset, BitMask.CreateRange(offset, size));
       
        /// <summary>
        /// For a given value return the specified bits from within it, right shifted pos bits.
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="size">The total number of bits to extract</param>
        /// <returns>The numeric value stored at that bit location</returns>
        public static ushort ReadBits(this ushort self, byte offset, byte size)
            => self.ReadBits(offset, BitMask.CreateRange(offset, size));
        
        /// <summary>
        /// For a given value return the specified bits from within it, right shifted pos bits.
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="size">The total number of bits to extract</param>
        /// <returns>The numeric value stored at that bit location</returns>
        public static uint ReadBits(this uint self, byte offset, byte size)
            => self.ReadBits(offset, BitMask.CreateRange(offset, size));
        
        /// <summary>
        /// For a given value return the specified bits from within it, right shifted pos bits.
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="size">The total number of bits to extract</param>
        /// <returns>The numeric value stored at that bit location</returns>
        public static ulong ReadBits(this ulong self, byte offset, byte size)
            => self.ReadBits(offset, BitMask.CreateRange(offset, size));

        #endregion
        
        #region BitMask operations
        
        /// <summary>
        /// Extract a subset of bits specified by a bitmask and right align the bits by the offset. 
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="mask">the bitmask of which bits to read.
        /// Zeroed bits in the mask will always extract 0 from the source.
        /// </param>
        /// <returns>The right shifted value extracted from the value</returns>
        public static ulong ReadBits(this ulong self, byte offset, BitMask mask)
        {
            return ((self & mask) >> offset);
        }

        /// <summary>
        /// Extract a subset of bits specified by a bitmask and right align the bits by the offset. 
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="mask">the bitmask of which bits to read.
        /// Zeroed bits in the mask will always extract 0 from the source.
        /// </param>
        /// <returns>The right shifted value extracted from the value</returns>
        public static long ReadBits(this long self, byte offset, BitMask mask)
        {
            return (long)(((ulong)self & mask) >> offset);
        }
        
        
        /// <summary>
        /// Extract a subset of bits specified by a bitmask and right align the bits by the offset. 
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="mask">the bitmask of which bits to read.
        /// Zeroed bits in the mask will always extract 0 from the source.
        /// </param>
        /// <returns>The right shifted value extracted from the value</returns>
        public static uint ReadBits(this uint self, byte offset, BitMask mask)
        {
            return ((self & mask) >> offset);
        }

        /// <summary>
        /// Extract a subset of bits specified by a bitmask and right align the bits by the offset. 
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="mask">the bitmask of which bits to read.
        /// Zeroed bits in the mask will always extract 0 from the source.
        /// </param>
        /// <returns>The right shifted value extracted from the value</returns>
        public static int ReadBits(this int self, byte offset, BitMask mask)
        {
            return (int)(((uint)self & mask) >> offset); // coerce to unsigned first to prevent issues with sign bit.
        }

        /// <summary>
        /// Extract a subset of bits specified by a bitmask and right align the bits by the offset. 
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="mask">the bitmask of which bits to read.
        /// Zeroed bits in the mask will always extract 0 from the source.
        /// </param>
        /// <returns>The right shifted value extracted from the value</returns>
        public static ushort ReadBits(this ushort self, byte offset, BitMask mask)
        {
            return (ushort)((self & mask) >> offset);
        }

        /// <summary>
        /// Extract a subset of bits specified by a bitmask and right align the bits by the offset. 
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="mask">the bitmask of which bits to read.
        /// Zeroed bits in the mask will always extract 0 from the source.
        /// </param>
        /// <returns>The right shifted value extracted from the value</returns>
        public static short ReadBits(this short self, byte offset, BitMask mask)
        {
            return (short)(((ushort)self & mask) >> offset);
        }
 
        /// <summary>
        /// Extract a subset of bits specified by a bitmask and right align the bits by the offset. 
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="mask">the bitmask of which bits to read.
        /// Zeroed bits in the mask will always extract 0 from the source.
        /// </param>
        /// <returns>The right shifted value extracted from the value</returns>
        public static byte ReadBits(this byte self, byte offset, BitMask mask)
        {
            return (byte)((self & mask) >> offset);
        }

        /// <summary>
        /// Extract a subset of bits specified by a bitmask and right align the bits by the offset. 
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="mask">the bitmask of which bits to read.
        /// Zeroed bits in the mask will always extract 0 from the source.
        /// </param>
        /// <returns>The right shifted value extracted from the value</returns>
        public static sbyte ReadBits(this sbyte self, byte offset, BitMask mask)
        {
            return (sbyte)(((byte)self & mask) >> offset);
        }
        
        #endregion

        #region single bit operations

        /// <summary>
        /// Read a single bit from the specified offset.
        /// </summary>
        /// <param name="self">the bits to read from</param>
        /// <param name="offset">the offset to read</param>
        /// <returns>the bit (a bool) at the specified offset </returns>
        public static bool ReadBit(this ulong self, byte offset)
            => (self & BitMask.CreateRange(offset, 1)) > 0;

        /// <summary>
        /// Read a single bit from the specified offset.
        /// </summary>
        /// <param name="self">the bits to read from</param>
        /// <param name="offset">the offset to read</param>
        /// <returns>the bit (a bool) at the specified offset </returns>
        public static bool ReadBit(this long self, byte offset)
            => (self & BitMask.CreateRange(offset, 1)) > 0;
        
        /// <summary>
        /// Read a single bit from the specified offset.
        /// </summary>
        /// <param name="self">the bits to read from</param>
        /// <param name="offset">the offset to read</param>
        /// <returns>the bit (a bool) at the specified offset </returns>
        public static bool ReadBit(this uint self, byte offset)
            => (self & BitMask.CreateRange(offset, 1)) > 0;
        
        /// <summary>
        /// Read a single bit from the specified offset.
        /// </summary>
        /// <param name="self">the bits to read from</param>
        /// <param name="offset">the offset to read</param>
        /// <returns>the bit (a bool) at the specified offset </returns>
        public static bool ReadBit(this int self, byte offset)
            => (self & BitMask.CreateRange(offset, 1)) > 0;
        
        /// <summary>
        /// Read a single bit from the specified offset.
        /// </summary>
        /// <param name="self">the bits to read from</param>
        /// <param name="offset">the offset to read</param>
        /// <returns>the bit (a bool) at the specified offset </returns>
        public static bool ReadBit(this ushort self, byte offset)
            => (self & BitMask.CreateRange(offset, 1)) > 0;

        /// <summary>
        /// Read a single bit from the specified offset.
        /// </summary>
        /// <param name="self">the bits to read from</param>
        /// <param name="offset">the offset to read</param>
        /// <returns>the bit (a bool) at the specified offset </returns>
        public static bool ReadBit(this short self, byte offset)
            => (self & BitMask.CreateRange(offset, 1)) > 0;
        
        /// <summary>
        /// Read a single bit from the specified offset.
        /// </summary>
        /// <param name="self">the bits to read from</param>
        /// <param name="offset">the offset to read</param>
        /// <returns>the bit (a bool) at the specified offset </returns>
        public static bool ReadBit(this byte self, byte offset)
            => (self & BitMask.CreateRange(offset, 1)) > 0;

        /// <summary>
        /// Read a single bit from the specified offset.
        /// </summary>
        /// <param name="self">the bits to read from</param>
        /// <param name="offset">the offset to read</param>
        /// <returns>the bit (a bool) at the specified offset </returns>
        public static bool ReadBit(this sbyte self, byte offset)
            => (self & BitMask.CreateRange(offset, 1)) > 0;
        
        #endregion
        
    }
}
// ReSharper disable MemberCanBePrivate.Global
namespace Jcd.BitManipulation
{
    /// <summary>
    /// Extension methods that enable reading one or more bits from a specified offset in an integer data type. 
    /// </summary>
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
        public static sbyte ReadBits(this sbyte self, int offset, int size)
            => self.ReadBits(offset, BitMask.CreateRange(offset, size));

        /// <summary>
        /// For a given value return the specified bits from within it, right shifted pos bits.
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="size">The total number of bits to extract</param>
        /// <returns>The numeric value stored at that bit location</returns>
        public static short ReadBits(this short self, int offset, int size)
            => self.ReadBits(offset, BitMask.CreateRange(offset, size));

        /// <summary>
        /// For a given value return the specified bits from within it, right shifted pos bits.
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="size">The total number of bits to extract</param>
        /// <returns>The numeric value stored at that bit location</returns>
        public static int ReadBits(this int self, int offset, int size)
            => self.ReadBits(offset, BitMask.CreateRange(offset, size));

        /// <summary>
        /// For a given value return the specified bits from within it, right shifted pos bits.
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="size">The total number of bits to extract</param>
        /// <returns>The numeric value stored at that bit location</returns>
        public static long ReadBits(this long self, int offset, int size)
            => self.ReadBits(offset, BitMask.CreateRange(offset, size));

        /// <summary>
        /// For a given value return the specified bits from within it, right shifted pos bits.
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="size">The total number of bits to extract</param>
        /// <returns>The numeric value stored at that bit location</returns>
        public static byte ReadBits(this byte self, int offset, int size)
            => self.ReadBits(offset, BitMask.CreateRange(offset, size));
       
        /// <summary>
        /// For a given value return the specified bits from within it, right shifted pos bits.
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="size">The total number of bits to extract</param>
        /// <returns>The numeric value stored at that bit location</returns>
        public static ushort ReadBits(this ushort self, int offset, int size)
            => self.ReadBits(offset, BitMask.CreateRange(offset, size));
        
        /// <summary>
        /// For a given value return the specified bits from within it, right shifted pos bits.
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="size">The total number of bits to extract</param>
        /// <returns>The numeric value stored at that bit location</returns>
        public static uint ReadBits(this uint self, int offset, int size)
            => self.ReadBits(offset, BitMask.CreateRange(offset, size));
        
        /// <summary>
        /// For a given value return the specified bits from within it, right shifted pos bits.
        /// </summary>
        /// <param name="self">the source of bits to read</param>
        /// <param name="offset">the bit offset to read from</param>
        /// <param name="size">The total number of bits to extract</param>
        /// <returns>The numeric value stored at that bit location</returns>
        public static ulong ReadBits(this ulong self, int offset, int size)
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
        public static ulong ReadBits(this ulong self, int offset, BitMask mask)
        {
            return (self & mask) >> offset;
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
        public static long ReadBits(this long self, int offset, BitMask mask)
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
        public static uint ReadBits(this uint self, int offset, BitMask mask)
        {
            return (self & mask) >> offset;
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
        public static int ReadBits(this int self, int offset, BitMask mask)
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
        public static ushort ReadBits(this ushort self, int offset, BitMask mask)
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
        public static short ReadBits(this short self, int offset, BitMask mask)
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
        public static byte ReadBits(this byte self, int offset, BitMask mask)
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
        public static sbyte ReadBits(this sbyte self, int offset, BitMask mask)
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
        public static bool ReadBit(this ulong self, int offset)
            => self.ReadBits(offset,1) > 0;

        /// <summary>
        /// Read a single bit from the specified offset.
        /// </summary>
        /// <param name="self">the bits to read from</param>
        /// <param name="offset">the offset to read</param>
        /// <returns>the bit (a bool) at the specified offset </returns>
        public static bool ReadBit(this long self, int offset)
            => self.ReadBits(offset,1) > 0;
        
        /// <summary>
        /// Read a single bit from the specified offset.
        /// </summary>
        /// <param name="self">the bits to read from</param>
        /// <param name="offset">the offset to read</param>
        /// <returns>the bit (a bool) at the specified offset </returns>
        public static bool ReadBit(this uint self, int offset)
            => self.ReadBits(offset,1) > 0;
        
        /// <summary>
        /// Read a single bit from the specified offset.
        /// </summary>
        /// <param name="self">the bits to read from</param>
        /// <param name="offset">the offset to read</param>
        /// <returns>the bit (a bool) at the specified offset </returns>
        public static bool ReadBit(this int self, int offset)
            => self.ReadBits(offset,1) > 0;
        
        /// <summary>
        /// Read a single bit from the specified offset.
        /// </summary>
        /// <param name="self">the bits to read from</param>
        /// <param name="offset">the offset to read</param>
        /// <returns>the bit (a bool) at the specified offset </returns>
        public static bool ReadBit(this ushort self, int offset)
            => self.ReadBits(offset,1) > 0;

        /// <summary>
        /// Read a single bit from the specified offset.
        /// </summary>
        /// <param name="self">the bits to read from</param>
        /// <param name="offset">the offset to read</param>
        /// <returns>the bit (a bool) at the specified offset </returns>
        public static bool ReadBit(this short self, int offset)
            => self.ReadBits(offset,1) > 0;
        
        /// <summary>
        /// Read a single bit from the specified offset.
        /// </summary>
        /// <param name="self">the bits to read from</param>
        /// <param name="offset">the offset to read</param>
        /// <returns>the bit (a bool) at the specified offset </returns>
        public static bool ReadBit(this byte self, int offset)
            => self.ReadBits(offset,1) > 0;

        /// <summary>
        /// Read a single bit from the specified offset.
        /// </summary>
        /// <param name="self">the bits to read from</param>
        /// <param name="offset">the offset to read</param>
        /// <returns>the bit (a bool) at the specified offset </returns>
        public static bool ReadBit(this sbyte self, int offset)
            => self.ReadBits(offset,1) > 0;
        
        #endregion
    }
}
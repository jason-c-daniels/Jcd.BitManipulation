namespace Jcd.BitManipulation
{
    /// <summary>
    /// Extension methods to aid in clearing bits in various integer data types.
    /// </summary>
    public static class ClearBitsExtensions
    {
        #region Range of bits operations
        /// <summary>
        /// Sets all specified bits to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to begin clearing bits.</param>
        /// <param name="size">The number of bits to clear on.</param>
        public static void ClearBits(this ref sbyte self, int offset=0, int size=8)
            => self.ClearBits(BitMask.CreateRange(offset, size));

        /// <summary>
        /// Sets all specified bits to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to begin clearing bits.</param>
        /// <param name="size">The number of bits to clear on.</param>
        public static void ClearBits(this ref short self, int offset=0, int size=16)
            => self.ClearBits(BitMask.CreateRange(offset, size));
        
        /// <summary>
        /// Sets all specified bits to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to begin clearing bits.</param>
        /// <param name="size">The number of bits to clear on.</param>
        public static void ClearBits(this ref int self, int offset=0, int size=32)
            => self.ClearBits(BitMask.CreateRange(offset, size));
        
        /// <summary>
        /// Sets all specified bits to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to begin clearing bits.</param>
        /// <param name="size">The number of bits to clear on.</param>
        public static void ClearBits(this ref long self, int offset=0, int size=64)
            => self.ClearBits(BitMask.CreateRange(offset, size));
        
        /// <summary>
        /// Sets all specified bits to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to begin clearing bits.</param>
        /// <param name="size">The number of bits to clear on.</param>
        public static void ClearBits(this ref byte self, int offset=0, int size=8)
            => self.ClearBits(BitMask.CreateRange(offset, size));
        
        /// <summary>
        /// Sets all specified bits to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to begin clearing bits.</param>
        /// <param name="size">The number of bits to clear on.</param>
        public static void ClearBits(this ref ushort self, int offset=0, int size=16)
            => self.ClearBits(BitMask.CreateRange(offset, size));
        
        /// <summary>
        /// Sets all specified bits to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to begin clearing bits.</param>
        /// <param name="size">The number of bits to clear on.</param>
        public static void ClearBits(this ref uint self, int offset=0, int size=32)
            => self.ClearBits(BitMask.CreateRange(offset, size));
        
        /// <summary>
        /// Sets all specified bits to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to begin clearing bits.</param>
        /// <param name="size">The number of bits to clear on.</param>
        public static void ClearBits(this ref ulong self, int offset=0, int size=64)
            => self.ClearBits(BitMask.CreateRange(offset, size));
        
        #endregion
     
        #region Single bit operations
        /// <summary>
        /// Sets bit to "off" in a variable, given a bit position.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit to clear.</param>
        public static void ClearBit(this ref sbyte self, int offset)
            => self.ClearBits(BitMask.CreateSingleBit(offset));
        
        /// <summary>
        /// Sets bit to "off" in a variable, given a bit position.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit to clear.</param>
        public static void ClearBit(this ref short self, int offset)
            => self.ClearBits(BitMask.CreateSingleBit(offset));
        
        /// <summary>
        /// Sets bit to "off" in a variable, given a bit position.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit to clear.</param>
        public static void ClearBit(this ref int self, int offset)
            => self.ClearBits(BitMask.CreateSingleBit(offset));

        /// <summary>
        /// Sets bit to "off" in a variable, given a bit position.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit to clear.</param>
        public static void ClearBit(this ref long self, int offset)
            => self.ClearBits(BitMask.CreateSingleBit(offset));

        /// <summary>
        /// Sets bit to "off" in a variable, given a bit position.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit to clear.</param>
        public static void ClearBit(this ref byte self, int offset)
            => self.ClearBits(BitMask.CreateSingleBit(offset));

        /// <summary>
        /// Sets bit to "off" in a variable, given a bit position.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit to clear.</param>
        public static void ClearBit(this ref ushort self, int offset)
            => self.ClearBits(BitMask.CreateSingleBit(offset));

        /// <summary>
        /// Sets bit to "off" in a variable, given a bit position.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit to clear.</param>
        public static void ClearBit(this ref uint self, int offset)
            => self.ClearBits(BitMask.CreateSingleBit(offset));

        /// <summary>
        /// Sets bit to "off" in a variable, given a bit position.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit to clear.</param>
        public static void ClearBit(this ref ulong self, int offset)
            => self.ClearBits(BitMask.CreateSingleBit(offset));
                
        #endregion

        #region BitMask operations
        
        /// <summary>
        /// Sets all bits from a provided mask to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to clear.</param>
        public static void ClearBits(this ref sbyte self, BitMask mask)
            => self &= (sbyte)~mask.Bits;

        /// <summary>
        /// Sets all bits from a provided mask to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to clear.</param>
        public static void ClearBits(this ref short self, BitMask mask)
            => self &= (short)~mask.Bits;

        /// <summary>
        /// Sets all bits from a provided mask to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to clear.</param>
        public static void ClearBits(this ref int self, BitMask mask)
            => self &= (int)~mask.Bits;

        /// <summary>
        /// Sets all bits from a provided mask to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to clear.</param>
        public static void ClearBits(this ref long self, BitMask mask)
            => self &= (long)~mask.Bits;

        /// <summary>
        /// Sets all bits from a provided mask to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to clear.</param>
        public static void ClearBits(this ref byte self, BitMask mask)
            => self &= (byte)~mask.Bits;

        /// <summary>
        /// Sets all bits from a provided mask to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to clear.</param>
        public static void ClearBits(this ref ushort self, BitMask mask)
            => self &= (ushort)~mask.Bits;

        /// <summary>
        /// Sets all bits from a provided mask to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to clear.</param>
        public static void ClearBits(this ref uint self, BitMask mask)
            => self &= (uint)~mask.Bits;

        /// <summary>
        /// Sets all bits from a provided mask to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to clear.</param>
        public static void ClearBits(this ref ulong self, BitMask mask)
            => self &= ~mask.Bits;
        
        #endregion
    }
}
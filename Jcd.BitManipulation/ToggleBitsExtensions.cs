namespace Jcd.BitManipulation
{
    public static class ToggleBitsExtensions
    {
        #region Range of bits operations
        /// <summary>
        /// Toggles bits in a variable, given a bit position and size.
        /// The default values result in toggling all bits. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The offset of the bits to toggle.</param>
        /// <param name="size">The number of bits to toggle.</param>
        public static void ToggleBits(this ref sbyte self, byte offset=0, byte size=8)
            => self.ToggleBits(BitMask.CreateRange(offset, size));
        
        /// <summary>
        /// Toggles bits in a variable, given a bit position and size. 
        /// The default values result in toggling all bits. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The offset of the bits to toggle.</param>
        /// <param name="size">The number of bits to toggle.</param>
        public static void ToggleBits(this ref short self, byte offset=0, byte size=16)
            => self.ToggleBits(BitMask.CreateRange(offset, size));
        
        /// <summary>
        /// Toggles bits in a variable, given a bit position and size. 
        /// The default values result in toggling all bits. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The offset of the bits to toggle.</param>
        /// <param name="size">The number of bits to toggle.</param>
        public static void ToggleBits(this ref int self, byte offset=0, byte size=32)
            => self.ToggleBits(BitMask.CreateRange(offset, size));

        /// <summary>
        /// Toggles bits in a variable, given a bit position and size. 
        /// The default values result in toggling all bits. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The offset of the bits to toggle.</param>
        /// <param name="size">The number of bits to toggle.</param>
        public static void ToggleBits(this ref long self, byte offset=0, byte size=64)
            => self.ToggleBits(BitMask.CreateRange(offset, size));

        /// <summary>
        /// Toggles bits in a variable, given a bit position and size. 
        /// The default values result in toggling all bits. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The offset of the bits to toggle.</param>
        /// <param name="size">The number of bits to toggle.</param>
        public static void ToggleBits(this ref byte self, byte offset=0, byte size=8)
            => self.ToggleBits(BitMask.CreateRange(offset, size));

        /// <summary>
        /// Toggles bits in a variable, given a bit position and size. 
        /// The default values result in toggling all bits. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The offset of the bits to toggle.</param>
        /// <param name="size">The number of bits to toggle.</param>
        public static void ToggleBits(this ref ushort self, byte offset=0, byte size=16)
            => self.ToggleBits(BitMask.CreateRange(offset, size));

        /// <summary>
        /// Toggles bits in a variable, given a bit position and size. 
        /// The default values result in toggling all bits. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The offset of the bits to toggle.</param>
        /// <param name="size">The number of bits to toggle.</param>
        public static void ToggleBits(this ref uint self, byte offset=0, byte size=32)
            => self.ToggleBits(BitMask.CreateRange(offset, size));

        /// <summary>
        /// Toggles bits in a variable, given a bit position and size. 
        /// The default values result in toggling all bits. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The offset of the bits to toggle.</param>
        /// <param name="size">The number of bits to toggle.</param>
        public static void ToggleBits(this ref ulong self, byte offset=0, byte size=64)
            => self.ToggleBits(BitMask.CreateRange(offset, size));
        #endregion
        
        #region Single bit operations
        
        /// <summary>
        /// Toggles a bit, given a bit position.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to toggle.</param>
        public static void ToggleBit(this ref sbyte self, byte offset)
            => self.ToggleBits(BitMask.CreateSingleBit(offset));
        
        /// <summary>
        /// Toggles a bit, given a bit position.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to toggle.</param>
        public static void ToggleBit(this ref short self, byte offset)
            => self.ToggleBits(BitMask.CreateSingleBit(offset));
        
        /// <summary>
        /// Toggles a bit, given a bit position.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to toggle.</param>
        public static void ToggleBit(this ref int self, byte offset)
            => self.ToggleBits(BitMask.CreateSingleBit(offset));

        /// <summary>
        /// Toggles a bit, given a bit position.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to toggle.</param>
        public static void ToggleBit(this ref long self, byte offset)
            => self.ToggleBits(BitMask.CreateSingleBit(offset));

        /// <summary>
        /// Toggles a bit, given a bit position.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to toggle.</param>
        public static void ToggleBit(this ref byte self, byte offset)
            => self.ToggleBits(BitMask.CreateSingleBit(offset));

        /// <summary>
        /// Toggles a bit, given a bit position.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to toggle.</param>
        public static void ToggleBit(this ref ushort self, byte offset)
            => self.ToggleBits(BitMask.CreateSingleBit(offset));

        /// <summary>
        /// Toggles a bit, given a bit position.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to toggle.</param>
        public static void ToggleBit(this ref uint self, byte offset)
            => self.ToggleBits(BitMask.CreateSingleBit(offset));

        /// <summary>
        /// Toggles a bit, given a bit position.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to toggle.</param>
        public static void ToggleBit(this ref ulong self, byte offset)
            => self.ToggleBits(BitMask.CreateSingleBit(offset));
        
        #endregion
        
        #region BitMask operations
        /// <summary>
        /// Sets all from a provided mask to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to set.</param>
        public static void ToggleBits(this ref sbyte self, BitMask mask)
            => self ^= (sbyte)mask.Bits;
        
        /// <summary>
        /// Sets all from a provided mask to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to set.</param>
        public static void ToggleBits(this ref short self, BitMask mask)
            => self ^= (short)mask.Bits;
        
        /// <summary>
        /// Sets all from a provided mask to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to set.</param>
        public static void ToggleBits(this ref int self, BitMask mask)
            => self ^= (int)mask.Bits;

        /// <summary>
        /// Sets all from a provided mask to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to set.</param>
        public static void ToggleBits(this ref long self, BitMask mask)
            => self ^= (long)mask.Bits;

        /// <summary>
        /// Sets all from a provided mask to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to set.</param>
        public static void ToggleBits(this ref byte self, BitMask mask)
            => self ^= (byte)mask.Bits;

        /// <summary>
        /// Sets all from a provided mask to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to set.</param>
        public static void ToggleBits(this ref ushort self, BitMask mask)
            => self ^= (ushort)mask.Bits;

        /// <summary>
        /// Sets all from a provided mask to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to set.</param>
        public static void ToggleBits(this ref uint self, BitMask mask)
            => self ^= (uint)mask.Bits;

        /// <summary>
        /// Sets all from a provided mask to "off" in a variable. 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to set.</param>
        public static void ToggleBits(this ref ulong self, BitMask mask)
            => self ^= mask.Bits;
        
        #endregion
    }
}
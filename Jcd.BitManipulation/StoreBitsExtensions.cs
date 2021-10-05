namespace Jcd.BitManipulation
{
    public static class StoreBitsExtensions
    {
        #region operations on ranges of bits.
        /// <summary>
        /// Stores a value at the specified bit location within the variable.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="value">The value to be stored at the bit location.</param>
        /// <param name="offset">The bit location to store the value.</param>
        /// <param name="size">The bit size of the value.</param>
        public static void StoreBits(this ref sbyte self, sbyte value, byte offset, byte size)
            => self.StoreBits(value, offset, BitMask.CreateRange(offset, size));
        
        /// <summary>
        /// Stores a value at the specified bit location within the variable.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="value">The value to be stored at the bit location.</param>
        /// <param name="offset">The bit location to store the value.</param>
        /// <param name="size">The bit size of the value.</param>
        public static void StoreBits(this ref short self, short value, byte offset, byte size)
            => self.StoreBits(value, offset, BitMask.CreateRange(offset, size));
        
        /// <summary>
        /// Stores a value at the specified bit location within the variable.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="value">The value to be stored at the bit location.</param>
        /// <param name="offset">The bit location to store the value.</param>
        /// <param name="size">The bit size of the value.</param>
        public static void StoreBits(this ref int self, int value, byte offset, byte size)
            => self.StoreBits(value, offset, BitMask.CreateRange(offset, size));

        /// <summary>
        /// Stores a value at the specified bit location within the variable.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="value">The value to be stored at the bit location.</param>
        /// <param name="offset">The bit location to store the value.</param>
        /// <param name="size">The bit size of the value.</param>
        public static void StoreBits(this ref long self, long value, byte offset, byte size)
            => self.StoreBits(value, offset, BitMask.CreateRange(offset, size));

        /// <summary>
        /// Stores a value at the specified bit location within the variable.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="value">The value to be stored at the bit location.</param>
        /// <param name="offset">The bit location to store the value.</param>
        /// <param name="size">The bit size of the value.</param>
        public static void StoreBits(this ref byte self, byte value, byte offset, byte size)
            => self.StoreBits(value, offset, BitMask.CreateRange(offset, size));

        /// <summary>
        /// Stores a value at the specified bit location within the variable.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="value">The value to be stored at the bit location.</param>
        /// <param name="offset">The bit location to store the value.</param>
        /// <param name="size">The bit size of the value.</param>
        public static void StoreBits(this ref ushort self, ushort value, byte offset, byte size)
            => self.StoreBits(value, offset, BitMask.CreateRange(offset, size));

        /// <summary>
        /// Stores a value at the specified bit location within the variable.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="value">The value to be stored at the bit location.</param>
        /// <param name="offset">The bit location to store the value.</param>
        /// <param name="size">The bit size of the value.</param>
        public static void StoreBits(this ref uint self, uint value, byte offset, byte size)
            => self.StoreBits(value, offset, BitMask.CreateRange(offset, size));

        /// <summary>
        /// Stores a value at the specified bit location within the variable.
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="value">The value to be stored at the bit location.</param>
        /// <param name="offset">The bit location to store the value.</param>
        /// <param name="size">The bit size of the value.</param>
        public static void StoreBits(this ref ulong self, ulong value, byte offset, byte size)
            => self.StoreBits(value, offset, BitMask.CreateRange(offset, size));
        
        #endregion
        
        #region BitMask operations
        
        /// <summary>
        /// Store a masked set of bits from a value to an offset in the destination
        /// The mask must apply to the destination bits.
        /// </summary>
        /// <param name="self">the destination for the stored bits</param>
        /// <param name="value">the source of the bits to store</param>
        /// <param name="offset">the destination offset of where to store the bits</param>
        /// <param name="mask">the mask of which bits to store</param>
        public static void StoreBits(this ref ulong self, ulong value, byte offset, BitMask mask)
        {
            self.ClearBits(mask);
            self |= ((value << offset) & mask);
        }

        /// <summary>
        /// Store a masked set of bits from a value to an offset in the destination
        /// The mask must apply to the destination bits.
        /// </summary>
        /// <param name="self">the destination for the stored bits</param>
        /// <param name="value">the source of the bits to store</param>
        /// <param name="offset">the destination offset of where to store the bits</param>
        /// <param name="mask">the mask of which bits to store</param>
        public static void StoreBits(this ref long self, long value, byte offset, BitMask mask)
        {
            self.ClearBits(mask);
            self |= ((value << offset) & (long)mask.Bits);
        }
        
        /// <summary>
        /// Store a masked set of bits from a value to an offset in the destination
        /// The mask must apply to the destination bits.
        /// </summary>
        /// <param name="self">the destination for the stored bits</param>
        /// <param name="value">the source of the bits to store</param>
        /// <param name="offset">the destination offset of where to store the bits</param>
        /// <param name="mask">the mask of which bits to store</param>
        public static void StoreBits(this ref uint self, uint value, byte offset, BitMask mask)
        {
            self.ClearBits(mask);
            self |= ((value << offset) & (uint)mask.Bits);
        }

        /// <summary>
        /// Store a masked set of bits from a value to an offset in the destination
        /// The mask must apply to the destination bits.
        /// </summary>
        /// <param name="self">the destination for the stored bits</param>
        /// <param name="value">the source of the bits to store</param>
        /// <param name="offset">the destination offset of where to store the bits</param>
        /// <param name="mask">the mask of which bits to store</param>
        public static void StoreBits(this ref int self, int value, byte offset, BitMask mask)
        {
            self.ClearBits(mask);
            self |= ((value << offset) & (int)mask.Bits);
        }

        /// <summary>
        /// Store a masked set of bits from a value to an offset in the destination
        /// The mask must apply to the destination bits.
        /// </summary>
        /// <param name="self">the destination for the stored bits</param>
        /// <param name="value">the source of the bits to store</param>
        /// <param name="offset">the destination offset of where to store the bits</param>
        /// <param name="mask">the mask of which bits to store</param>
        public static void StoreBits(this ref ushort self, ushort value, byte offset, BitMask mask)
        {
            self.ClearBits(mask);
            self |= (ushort)((value << offset) & (ushort)mask.Bits);
        }

        /// <summary>
        /// Store a masked set of bits from a value to an offset in the destination
        /// The mask must apply to the destination bits.
        /// </summary>
        /// <param name="self">the destination for the stored bits</param>
        /// <param name="value">the source of the bits to store</param>
        /// <param name="offset">the destination offset of where to store the bits</param>
        /// <param name="mask">the mask of which bits to store</param>
        public static void StoreBits(this ref short self, short value, byte offset, BitMask mask)
        {
            self.ClearBits(mask);
            self |= (short)((value << offset) & (short)mask.Bits);
        }
        
        
        /// <summary>
        /// Store a masked set of bits from a value to an offset in the destination
        /// The mask must apply to the destination bits.
        /// </summary>
        /// <param name="self">the destination for the stored bits</param>
        /// <param name="value">the source of the bits to store</param>
        /// <param name="offset">the destination offset of where to store the bits</param>
        /// <param name="mask">the mask of which bits to store</param>
        public static void StoreBits(this ref byte self, byte value, byte offset, BitMask mask)
        {
            self.ClearBits(mask);
            self |= (byte)((value << offset) & (byte)mask.Bits);
        }

        /// <summary>
        /// Store a masked set of bits from a value to an offset in the destination
        /// The mask must apply to the destination bits.
        /// </summary>
        /// <param name="self">the destination for the stored bits</param>
        /// <param name="value">the source of the bits to store</param>
        /// <param name="offset">the destination offset of where to store the bits</param>
        /// <param name="mask">the mask of which bits to store</param>
        public static void StoreBits(this ref sbyte self, sbyte value, byte offset, BitMask mask)
        {
            self.ClearBits(mask);
            self |= (sbyte)((value << offset) & (sbyte)mask.Bits);
        }
        #endregion
    }
}
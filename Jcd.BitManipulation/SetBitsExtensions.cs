namespace Jcd.BitManipulation
{
    public static class SetBitsExtensions
    {
        #region Range of bits operations
        /// <summary>
        /// Sets all specified bits to "on" in a variable 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to store the value.</param>
        /// <param name="size">The number of bits to set on.</param>
        public static void SetBits(this ref sbyte self, byte offset=0, byte size=8)
        {
            self.SetBits(BitMask.CreateRange(offset, size));
        }
        
        /// <summary>
        /// Sets all specified bits to "on" in a variable 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to store the value.</param>
        /// <param name="size">The number of bits to set on.</param>
        public static void SetBits(this ref short self, byte offset=0, byte size=16)
        {
            self.SetBits(BitMask.CreateRange(offset, size));
        }
        
        /// <summary>
        /// Sets all specified bits to "on" in a variable 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to store the value.</param>
        /// <param name="size">The number of bits to set on.</param>
        public static void SetBits(this ref int self, byte offset=0, byte size=32)
        {
            self.SetBits(BitMask.CreateRange(offset, size));
        }

        /// <summary>
        /// Sets all specified bits to "on" in a variable 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to store the value.</param>
        /// <param name="size">The number of bits to set on.</param>
        public static void SetBits(this ref long self, byte offset=0, byte size=64)
        {
            self.SetBits(BitMask.CreateRange(offset, size));
        }

        /// <summary>
        /// Sets all specified bits to "on" in a variable 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to store the value.</param>
        /// <param name="size">The number of bits to set on.</param>
        public static void SetBits(this ref byte self, byte offset=0, byte size=8)
        {
            self.SetBits(BitMask.CreateRange(offset, size));
        }

        /// <summary>
        /// Sets all specified bits to "on" in a variable 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to store the value.</param>
        /// <param name="size">The number of bits to set on.</param>
        public static void SetBits(this ref ushort self, byte offset=0, byte size=16)
        {
            self.SetBits(BitMask.CreateRange(offset, size));
        }

        /// <summary>
        /// Sets all specified bits to "on" in a variable 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to store the value.</param>
        /// <param name="size">The number of bits to set on.</param>
        public static void SetBits(this ref uint self, byte offset=0, byte size=32)
        {
            self.SetBits(BitMask.CreateRange(offset, size));
        }

        /// <summary>
        /// Sets all specified bits to "on" in a variable 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to store the value.</param>
        /// <param name="size">The number of bits to set on.</param>
        public static void SetBits(this ref ulong self, byte offset=0, byte size=64)
        {
            self.SetBits(BitMask.CreateRange(offset, size));
        }
        #endregion
        
        #region Single bit operations
        /// <summary>
        /// Sets specified bit to "on" in a variable
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to set to on.</param>
        public static void SetBit(this ref sbyte self, byte offset)
        {
            self.SetBits(BitMask.CreateSingleBit(offset));
        }
        
        /// <summary>
        /// Sets specified bit to "on" in a variable
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to set to on.</param>
        public static void SetBit(this ref short self, byte offset)
        {
            self.SetBits(BitMask.CreateSingleBit(offset));
        }
        
        /// <summary>
        /// Sets specified bit to "on" in a variable
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to set to on.</param>
        public static void SetBit(this ref int self, byte offset)
        {
            self.SetBits(BitMask.CreateSingleBit(offset));
        }

        /// <summary>
        /// Sets specified bit to "on" in a variable
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to set to on.</param>
        public static void SetBit(this ref long self, byte offset)
        {
            self.SetBits(BitMask.CreateSingleBit(offset));
        }

        /// <summary>
        /// Sets specified bit to "on" in a variable
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to set to on.</param>
        public static void SetBit(this ref byte self, byte offset)
        {
            self.SetBits(BitMask.CreateSingleBit(offset));
        }

        /// <summary>
        /// Sets specified bit to "on" in a variable
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to set to on.</param>
        public static void SetBit(this ref ushort self, byte offset)
        {
            self.SetBits(BitMask.CreateSingleBit(offset));
        }

        /// <summary>
        /// Sets specified bit to "on" in a variable
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to set to on.</param>
        public static void SetBit(this ref uint self, byte offset)
        {
            self.SetBits(BitMask.CreateSingleBit(offset));
        }

        /// <summary>
        /// Sets specified bit to "on" in a variable
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="offset">The bit location to set to on.</param>
        public static void SetBit(this ref ulong self, byte offset)
        {
            self.SetBits(BitMask.CreateSingleBit(offset));
        }
        #endregion
        
        #region BitMask operations
        /// <summary>
        /// Sets all specified bits to "on" in a variable 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to set.</param>
        public static void SetBits(this ref sbyte self, BitMask mask)
            => self |= (sbyte)mask.Bits;
        
        /// <summary>
        /// Sets all specified bits to "on" in a variable 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to set.</param>
        public static void SetBits(this ref short self, BitMask mask)
            => self |= (short)mask.Bits;
        
        /// <summary>
        /// Sets all specified bits to "on" in a variable 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to set.</param>
        public static void SetBits(this ref int self, BitMask mask)
            => self |= (int)mask.Bits;

        /// <summary>
        /// Sets all specified bits to "on" in a variable 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to set.</param>
        public static void SetBits(this ref long self, BitMask mask)
            => self |= (long)mask.Bits;

        /// <summary>
        /// Sets all specified bits to "on" in a variable 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to set.</param>
        public static void SetBits(this ref byte self, BitMask mask)
            => self |= (byte)mask.Bits;

        /// <summary>
        /// Sets all specified bits to "on" in a variable 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to set.</param>
        public static void SetBits(this ref ushort self, BitMask mask)
            => self |= (ushort)mask.Bits;

        /// <summary>
        /// Sets all specified bits to "on" in a variable 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to set.</param>
        public static void SetBits(this ref uint self, BitMask mask)
            => self |= (uint)mask.Bits;

        /// <summary>
        /// Sets all specified bits to "on" in a variable 
        /// </summary>
        /// <param name="self">The value to be modified.</param>
        /// <param name="mask">bits to set.</param>
        public static void SetBits(this ref ulong self, BitMask mask)
            => self |= mask.Bits;
        
        #endregion
    }
}
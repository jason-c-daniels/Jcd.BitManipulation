using Xunit;

namespace Jcd.BitManipulation.Tests
{
    public class ClearBitsExtensionsTests
    {
        #region range of bits tests
        [Theory]
        [InlineData(0b11111111,0,2,0b11111100)] // clear lower 2 bits
        [InlineData(0b11111111,4,2,0b11001111)] // clear middle 2 bits
        [InlineData(0b11111111,6,2,0b00111111)] // clear upper 2 bits
        public void ClearBits_On_SByte_Clears_The_Correct_Bits(uint initial,int offset,int size, uint expected)
        {
            var value=(sbyte)initial; // coerce to proper type
            value.ClearBits((byte)offset,(byte)size);
            Assert.Equal((sbyte)expected, value);
        }
       
        [Theory]
        [InlineData(0b11111111,0,2,0b11111100)] // clear lower 2 bits
        [InlineData(0b11111111,4,2,0b11001111)] // clear middle 2 bits
        [InlineData(0b11111111,6,2,0b00111111)] // clear upper 2 bits
        public void ClearBits_On_Byte_Clears_The_Correct_Bits(uint initial,int offset,int size, uint expected)
        {
            var value=(byte)initial; // coerce to proper type
            value.ClearBits((byte)offset,(byte)size);
            Assert.Equal((byte)expected, value);
        }
        
        [Theory]
        [InlineData(0b11111111,0,2,0b11111100)] // clear lower 2 bits
        [InlineData(0b11111111,4,2,0b11001111)] // clear middle 2 bits of lower byte
        [InlineData(0b11111111,6,2,0b00111111)] // clear upper 2 bits of lower byte
        [InlineData(0b111111111111,8,2,0b110011111111)] 
        public void ClearBits_On_Int16_Clears_The_Correct_Bits(uint initial,int offset,int size, uint expected)
        {
            var value=(short)initial; // coerce to proper type
            value.ClearBits((byte)offset,(byte)size);
            Assert.Equal((short)expected, value);
        }
       
        [Theory]
        [InlineData(0b11111111,0,2,0b11111100)] // clear lower 2 bits
        [InlineData(0b11111111,4,2,0b11001111)] // clear middle 2 bits of lower byte
        [InlineData(0b11111111,6,2,0b00111111)] // clear upper 2 bits of lower byte
        [InlineData(0b111111111111,8,2,0b110011111111)] 
        public void ClearBits_On_UInt16_Clears_The_Correct_Bits(uint initial, int offset, int size, uint expected)
        {
            var value=(ushort)initial; // coerce to proper type, test data binder fails to do this correctly.
            value.ClearBits((byte)offset,(byte)size);
            Assert.Equal((ushort)expected, value);
        }

        [Theory]
        [InlineData(0b11111111,0,2,0b11111100)] // clear lower 2 bits
        [InlineData(0b11111111,4,2,0b11001111)] // clear middle 2 bits of lower byte
        [InlineData(0b11111111,6,2,0b00111111)] // clear upper 2 bits of lower byte
        [InlineData(0b111111111111,8,2,0b110011111111)] 
        [InlineData(0b11111111111111111111111111111111,26,2,0b11110011111111111111111111111111)] 
        public void ClearBits_On_Int32_Clears_The_Correct_Bits(uint initial,int offset,int size, uint expected)
        {
            var value=(int)initial; // coerce to proper type
            value.ClearBits((byte)offset,(byte)size);
            Assert.Equal((int)expected, value);
        }
       
        [Theory]
        [InlineData(0b11111111,0,2,0b11111100)] // clear lower 2 bits
        [InlineData(0b11111111,4,2,0b11001111)] // clear middle 2 bits of lower byte
        [InlineData(0b11111111,6,2,0b00111111)] // clear upper 2 bits of lower byte
        [InlineData(0b111111111111,8,2,0b110011111111)] 
        [InlineData(0b11111111111111111111111111111111,26,2,0b11110011111111111111111111111111)] 
        public void ClearBits_On_UInt32_Clears_The_Correct_Bits(uint value, int offset, int size, uint expected)
        {
            value.ClearBits((byte)offset,(byte)size);
            Assert.Equal(expected, value);
        }
        
        [Theory]
        [InlineData(0b11111111,0,2,0b11111100)] // clear lower 2 bits
        [InlineData(0b11111111,4,2,0b11001111)] // clear middle 2 bits of lower byte
        [InlineData(0b11111111,6,2,0b00111111)] // clear upper 2 bits of lower byte
        [InlineData(0b111111111111,8,2,0b110011111111)] 
        [InlineData(0b00111111111111111111111111111111,26,2,0b00110011111111111111111111111111)] 
        [InlineData(0b111111111111111111111111111111111111,32,2,0b110011111111111111111111111111111111)] 
        public void ClearBits_On_Int64_Clears_The_Correct_Bits(ulong initial,int offset,int size, ulong expected)
        {
            var value=(long)initial; // coerce to proper type
            value.ClearBits((byte)offset,(byte)size);
            Assert.Equal((long)expected, value);
        }
       
        [Theory]
        [InlineData(0b11111111,0,2,0b11111100)] // clear lower 2 bits
        [InlineData(0b11111111,4,2,0b11001111)] // clear middle 2 bits of lower byte
        [InlineData(0b11111111,6,2,0b00111111)] // clear upper 2 bits of lower byte
        [InlineData(0b111111111111,8,2,0b110011111111)] 
        [InlineData(0b00111111111111111111111111111111,26,2,0b00110011111111111111111111111111)] 
        [InlineData(0b111111111111111111111111111111111111,32,2,0b110011111111111111111111111111111111)] 
        public void ClearBits_On_UInt64_Clears_The_Correct_Bits(ulong value, int offset, int size, ulong expected)
        {
            value.ClearBits((byte)offset,(byte)size);
            Assert.Equal(expected, value);
        }
        
        
        #endregion
        
        #region single bit tests

        [Theory]
        [InlineData(0xFF,0,0xFE)]
        [InlineData(0xFF,4,0xEF)]
        [InlineData(0xFF,7,0x7F)]
        public void ClearBit_On_SByte_Clears_Correct_Bit(ulong initial, int bitToClear, ulong expected)
        {
            var value = (sbyte)initial;
            value.ClearBit((byte)bitToClear);
            Assert.Equal((sbyte)expected,value);
        }
        

        [Theory]
        [InlineData(0xFF,0,0xFE)]
        [InlineData(0xFF,4,0xEF)]
        [InlineData(0xFF,7,0x7F)]
        public void ClearBit_On_Byte_Clears_Correct_Bit(ulong initial, int bitToClear, ulong expected)
        {
            var value = (byte)initial;
            value.ClearBit((byte)bitToClear);
            Assert.Equal((byte)expected,value);
        }
        

        [Theory]
        [InlineData(0xFFFF,0,0xFFFE)]
        [InlineData(0xFFFF,4,0xFFEF)]
        [InlineData(0xFFFF,15,0x7FFF)]
        public void ClearBit_On_Int16_Clears_Correct_Bit(ulong initial, int bitToClear, ulong expected)
        {
            var value = (short)initial;
            value.ClearBit((byte)bitToClear);
            Assert.Equal((short)expected,value);
        }
        

        [Theory]
        [InlineData(0xFFFF,0,0xFFFE)]
        [InlineData(0xFFFF,4,0xFFEF)]
        [InlineData(0xFFFF,15,0x7FFF)]
        public void ClearBit_On_UInt16_Clears_Correct_Bit(ulong initial, int bitToClear, ulong expected)
        {
            var value = (ushort)initial;
            value.ClearBit((byte)bitToClear);
            Assert.Equal((ushort)expected,value);
        }
        
        
        [Theory]
        [InlineData(0xFFFFFFFF,0,0xFFFFFFFE)]
        [InlineData(0xFFFFFFFF,4,0xFFFFFFEF)]
        [InlineData(0xFFFFFFFF,15,0xFFFF7FFF)]
        [InlineData(0xFFFFFFFF,31,0x7FFFFFFF)]
        public void ClearBit_On_Int32_Clears_Correct_Bit(ulong initial, int bitToClear, ulong expected)
        {
            var value = (int)initial;
            value.ClearBit((byte)bitToClear);
            Assert.Equal((int)expected,value);
        }
        

        [Theory]
        [InlineData(0xFFFFFFFF,0,0xFFFFFFFE)]
        [InlineData(0xFFFFFFFF,4,0xFFFFFFEF)]
        [InlineData(0xFFFFFFFF,15,0xFFFF7FFF)]
        [InlineData(0xFFFFFFFF,31,0x7FFFFFFF)]
        public void ClearBit_On_UInt32_Clears_Correct_Bit(ulong initial, int bitToClear, ulong expected)
        {
            var value = (uint)initial;
            value.ClearBit((byte)bitToClear);
            Assert.Equal((uint)expected,value);
        }
        
        [Theory]
        [InlineData(0xFFFFFFFFFFFFFFFF,0,0xFFFFFFFFFFFFFFFE)]
        [InlineData(0xFFFFFFFFFFFFFFFF,4,0xFFFFFFFFFFFFFFEF)]
        [InlineData(0xFFFFFFFFFFFFFFFF,15,0xFFFFFFFFFFFF7FFF)]
        [InlineData(0xFFFFFFFFFFFFFFFF,31,0xFFFFFFFF7FFFFFFF)]
        [InlineData(0xFFFFFFFFFFFFFFFF,63,0x7FFFFFFFFFFFFFFF)]
        public void ClearBit_On_Int64_Clears_Correct_Bit(ulong initial, int bitToClear, ulong expected)
        {
            var value = (long)initial;
            value.ClearBit((byte)bitToClear);
            Assert.Equal((long)expected,value);
        }
        

        [Theory]
        [InlineData(0xFFFFFFFFFFFFFFFF,0,0xFFFFFFFFFFFFFFFE)]
        [InlineData(0xFFFFFFFFFFFFFFFF,4,0xFFFFFFFFFFFFFFEF)]
        [InlineData(0xFFFFFFFFFFFFFFFF,15,0xFFFFFFFFFFFF7FFF)]
        [InlineData(0xFFFFFFFFFFFFFFFF,31,0xFFFFFFFF7FFFFFFF)]
        [InlineData(0xFFFFFFFFFFFFFFFF,63,0x7FFFFFFFFFFFFFFF)]
        public void ClearBit_On_UInt64_Clears_Correct_Bit(ulong value, int bitToClear, ulong expected)
        {
            value.ClearBit((byte)bitToClear);
            Assert.Equal(expected,value);
        }
        #endregion
        
        #region BitMask tests
        
        #endregion
    }
}
using Xunit;

namespace Jcd.BitManipulation.Tests
{
    public class StoreBitsExtensionsTests
    {
        #region range of bits tests
        [Theory]
        [InlineData(0x00,0xFF,0,2,0x03)]
        [InlineData(0x00,0xFF,6,2,0b11000000)]
        [InlineData(0x00,0xFF,0,8,0xFF)]
        [InlineData(0xF0,0x03,0,4,0xF3)]
        public void StoreBits_On_SByte_Stores_The_Correct_Bits(uint initial, uint val, int offset,int size, uint expected)
        {
            var destination=(sbyte)initial; // coerce to proper type
            var value = (sbyte)val;
            destination.StoreBits(value,(byte)offset,(byte)size);
            Assert.Equal((sbyte)expected, destination);
        }
        
        [Theory]
        [InlineData(0x00,0xFF,0,2,0x03)]
        [InlineData(0x00,0xFF,6,2,0b11000000)]
        [InlineData(0x00,0xFF,0,8,0xFF)]
        [InlineData(0xF0,0x03,0,4,0xF3)]
        public void StoreBits_On_Byte_Stores_The_Correct_Bits(uint initial, uint val, int offset,int size, uint expected)
        {
            var destination=(byte)initial; // coerce to proper type
            var value = (byte)val;
            destination.StoreBits(value,(byte)offset,(byte)size);
            Assert.Equal((byte)expected, destination);
        }
       
        
        [Theory]
        [InlineData(0x00,0xFF,0,2,0x03)]
        [InlineData(0x00,0xFF,6,2,0b11000000)]
        [InlineData(0x00,0xFF,0,8,0xFF)]
        [InlineData(0xF0,0x03,0,4,0xF3)]
        [InlineData(0x0000,0xFFFF,0,16,0xFFFF)]
        [InlineData(0xF000,0x03,0,8,0xF003)]
        public void StoreBits_On_Int16_Stores_The_Correct_Bits(uint initial, uint val, int offset,int size, uint expected)
        {
            var destination=(short)initial; // coerce to proper type
            var value = (short)val;
            destination.StoreBits(value,(byte)offset,(byte)size);
            Assert.Equal((short)expected, destination);
        }
        
        [Theory]
        [InlineData(0x00,0xFF,0,2,0x03)]
        [InlineData(0x00,0xFF,6,2,0b11000000)]
        [InlineData(0x00,0xFF,0,8,0xFF)]
        [InlineData(0xF0,0x03,0,4,0xF3)]
        [InlineData(0x0000,0xFFFF,0,16,0xFFFF)]
        [InlineData(0xF000,0x03,0,8,0xF003)]
        public void StoreBits_On_UInt16_Stores_The_Correct_Bits(uint initial, uint val, int offset,int size, uint expected)
        {
            var destination=(ushort)initial; // coerce to proper type
            var value = (ushort)val;
            destination.StoreBits(value,(byte)offset,(byte)size);
            Assert.Equal((ushort)expected, destination);
        }
        
        [Theory]
        [InlineData(0x00,0xFF,0,2,0x03)]
        [InlineData(0x00,0xFF,6,2,0b11000000)]
        [InlineData(0x00,0xFF,0,8,0xFF)]
        [InlineData(0xF0,0x03,0,4,0xF3)]
        [InlineData(0x0000,0xFFFF,0,16,0xFFFF)]
        [InlineData(0xF000,0x03,0,8,0xF003)]
        public void StoreBits_On_Int32_Stores_The_Correct_Bits(uint initial, uint val, int offset,int size, uint expected)
        {
            var destination=(int)initial; // coerce to proper type
            var value = (int)val;
            destination.StoreBits(value,(byte)offset,(byte)size);
            Assert.Equal((int)expected, destination);
        }
        
        [Theory]
        [InlineData(0x00,0xFF,0,2,0x03)]
        [InlineData(0x00,0xFF,6,2,0b11000000)]
        [InlineData(0x00,0xFF,0,8,0xFF)]
        [InlineData(0xF0,0x03,0,4,0xF3)]
        [InlineData(0x0000,0xFFFF,0,16,0xFFFF)]
        [InlineData(0xF000,0x03,0,8,0xF003)]
        public void StoreBits_On_UInt32_Stores_The_Correct_Bits(uint initial, uint val, int offset,int size, uint expected)
        {
            var destination=initial; // coerce to proper type
            var value = val;
            destination.StoreBits( value,(byte)offset,(byte)size);
            Assert.Equal(expected, destination);
        }
        
        
        [Theory]
        [InlineData(0x00,0xFF,0,2,0x03)]
        [InlineData(0x00,0xFF,6,2,0b11000000)]
        [InlineData(0x00,0xFF,0,8,0xFF)]
        [InlineData(0xF0,0x03,0,4,0xF3)]
        [InlineData(0x0000,0xFFFF,0,16,0xFFFF)]
        [InlineData(0xF000,0x03,0,8,0xF003)]
        public void StoreBits_On_Int64_Stores_The_Correct_Bits(ulong initial, ulong val, int offset, int size, ulong expected)
        {
            var destination=(long)initial; // coerce to proper type
            var value = (long)val;
            destination.StoreBits(value,(byte)offset,(byte)size);
            Assert.Equal((long)expected, destination);
        }
        
        [Theory]
        [InlineData(0x00,0xFF,0,2,0x03)]
        [InlineData(0x00,0xFF,6,2,0b11000000)]
        [InlineData(0x00,0xFF,0,8,0xFF)]
        [InlineData(0xF0,0x03,0,4,0xF3)]
        [InlineData(0x0000,0xFFFF,0,16,0xFFFF)]
        [InlineData(0xF000,0x03,0,8,0xF003)]
        public void StoreBits_On_UInt64_Stores_The_Correct_Bits(ulong initial, ulong val, int offset,int size, ulong expected)
        {
            var destination=initial; // copy for debugging reasons.
            var value = val;
            destination.StoreBits(value,(byte)offset,(byte)size);
            Assert.Equal(expected, destination);
        }
        
        #endregion
    }
}
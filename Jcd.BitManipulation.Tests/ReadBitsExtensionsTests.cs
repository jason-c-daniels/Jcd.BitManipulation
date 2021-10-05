using Xunit;

namespace Jcd.BitManipulation.Tests
{
    public class ReadBitsExtensionsTests
    {
        #region range of bits tests
        
        [Theory]
        [InlineData(0xFF,0,2,0x03)]
        [InlineData(0b11100000,6,2,0b11)]
        [InlineData(0b11100000,4,2,0b10)]
        [InlineData(0xFF,0,8,0xFF)]
        [InlineData(0x3F,4,4,0x03)]
        public void ReadBits_On_SByte_Reads_The_Correct_Bits(uint initial, int offset,int size, uint expected)
        {
            var bits=(sbyte)initial; // coerce to proper type
            var value=bits.ReadBits((byte)offset,(byte)size);
            Assert.Equal((sbyte)expected, value);
        }

        [Theory]
        [InlineData(0xFF,0,2,0x03)]
        [InlineData(0b11100000,6,2,0b11)]
        [InlineData(0b11100000,4,2,0b10)]
        [InlineData(0xFF,0,8,0xFF)]
        [InlineData(0x3F,4,4,0x03)]
        public void ReadBits_On_Byte_Reads_The_Correct_Bits(uint initial, int offset,int size, uint expected)
        {
            var bits=(byte)initial; // coerce to proper type
            var value=bits.ReadBits((byte)offset,(byte)size);
            Assert.Equal((byte)expected, value);
        }
        

        [Theory]
        [InlineData(0xFF,0,2,0x03)]
        [InlineData(0b11100000,6,2,0b11)]
        [InlineData(0b11100000,4,2,0b10)]
        [InlineData(0xFF,0,8,0xFF)]
        [InlineData(0x3F,4,4,0x03)]
        [InlineData(0x300F,12,4,0x03)]
        [InlineData(0xF00F,14,2,0x03)]
        public void ReadBits_On_Int16_Reads_The_Correct_Bits(uint initial, int offset,int size, uint expected)
        {
            var bits=(short)initial; // coerce to proper type
            var value=bits.ReadBits((byte)offset,(byte)size);
            Assert.Equal((short)expected, value);
        }

        [Theory]
        [InlineData(0xFF,0,2,0x03)]
        [InlineData(0b11100000,6,2,0b11)]
        [InlineData(0b11100000,4,2,0b10)]
        [InlineData(0xFF,0,8,0xFF)]
        [InlineData(0x3F,4,4,0x03)]
        [InlineData(0x300F,12,4,0x03)]
        [InlineData(0xF00F,14,2,0x03)]
        public void ReadBits_On_UInt16_Reads_The_Correct_Bits(uint initial, int offset,int size, uint expected)
        {
            var bits=(ushort)initial; // coerce to proper type
            var value=bits.ReadBits((byte)offset,(byte)size);
            Assert.Equal((ushort)expected, value);
        }

        [Theory]
        [InlineData(0xFF,0,2,0x03)]
        [InlineData(0b11100000,6,2,0b11)]
        [InlineData(0b11100000,4,2,0b10)]
        [InlineData(0xFF,0,8,0xFF)]
        [InlineData(0x3F,4,4,0x03)]
        [InlineData(0x300F,12,4,0x03)]
        [InlineData(0xF00F,14,2,0x03)]
        [InlineData(0x3000000F,28,4,0x03)]
        [InlineData(0xF000000F,30,2,0x03)]
        public void ReadBits_On_Int32_Reads_The_Correct_Bits(uint initial, int offset,int size, uint expected)
        {
            var bits=(int)initial; // coerce to proper type
            var value=bits.ReadBits((byte)offset,(byte)size);
            Assert.Equal((int)expected, value);
        }

        [Theory]
        [InlineData(0xFF,0,2,0x03)]
        [InlineData(0b11100000,6,2,0b11)]
        [InlineData(0b11100000,4,2,0b10)]
        [InlineData(0xFF,0,8,0xFF)]
        [InlineData(0x3F,4,4,0x03)]
        [InlineData(0x300F,12,4,0x03)]
        [InlineData(0xF00F,14,2,0x03)]
        [InlineData(0x3000000F,28,4,0x03)]
        [InlineData(0xF000000F,30,2,0x03)]
        public void ReadBits_On_UInt32_Reads_The_Correct_Bits(uint initial, int offset,int size, uint expected)
        {
            var bits=initial; // coerce to proper type
            var value=bits.ReadBits((byte)offset,(byte)size);
            Assert.Equal(expected, value);
        }
        
        
        [Theory]
        [InlineData(0xFF,0,2,0x03)]
        [InlineData(0b11100000,6,2,0b11)]
        [InlineData(0b11100000,4,2,0b10)]
        [InlineData(0xFF,0,8,0xFF)]
        [InlineData(0x3F,4,4,0x03)]
        [InlineData(0x300F,12,4,0x03)]
        [InlineData(0xF00F,14,2,0x03)]
        [InlineData(0x3000000F,28,4,0x03)]
        [InlineData(0xF000000F,30,2,0x03)]
        [InlineData(0x300000000000000F,60,4,0x03)]
        [InlineData(0xF00000000000000F,62,2,0x03)]
        public void ReadBits_On_Int64_Reads_The_Correct_Bits(ulong initial, int offset,int size, ulong expected)
        {
            var bits=(long)initial; // coerce to proper type
            var value=bits.ReadBits((byte)offset,(byte)size);
            Assert.Equal((long)expected, value);
        }

        [Theory]
        [InlineData(0xFF,0,2,0x03)]
        [InlineData(0b11100000,6,2,0b11)]
        [InlineData(0b11100000,4,2,0b10)]
        [InlineData(0xFF,0,8,0xFF)]
        [InlineData(0x3F,4,4,0x03)]
        [InlineData(0x300F,12,4,0x03)]
        [InlineData(0xF00F,14,2,0x03)]
        [InlineData(0x3000000F,28,4,0x03)]
        [InlineData(0xF000000F,30,2,0x03)]
        [InlineData(0x300000000000000F,60,4,0x03)]
        [InlineData(0xF00000000000000F,62,2,0x03)]
        public void ReadBits_On_UInt64_Reads_The_Correct_Bits(ulong initial, int offset,int size, ulong expected)
        {
            var bits=initial; // coerce to proper type
            var value=bits.ReadBits((byte)offset,(byte)size);
            Assert.Equal(expected, value);
        }
        #endregion
    }
}
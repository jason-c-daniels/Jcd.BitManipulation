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
            destination.StoreBits(value,offset,size);
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
            destination.StoreBits(value,offset,size);
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
            destination.StoreBits(value,offset,size);
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
            destination.StoreBits(value,offset,size);
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
            destination.StoreBits(value,offset,size);
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
            var destination=initial; 
            destination.StoreBits( val,offset,size);
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
            destination.StoreBits(value,offset,size);
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
            destination.StoreBits(val,offset,size);
            Assert.Equal(expected, destination);
        }

        #endregion
        
        #region single bit operation tests

        [Theory]
        [InlineData(0x00,0,true,0x01)]
        [InlineData(0x00,7,true,0x80)]
        [InlineData(0xFF,0,false,0xFE)]
        [InlineData(0xFF,7,false,0x7F)]
        public void StoreBit_For_SByte_Sets_The_Specified_Bit_To_The_Target_Value
            (uint destination, int offset, bool bit, uint expected)
        {
            var value = (sbyte)destination;
            value.StoreBit((byte)offset,bit);
            Assert.Equal((sbyte)expected,value);
        }
        
        [Theory]
        [InlineData(0x00,0,true,0x01)]
        [InlineData(0x00,7,true,0x80)]
        [InlineData(0xFF,0,false,0xFE)]
        [InlineData(0xFF,7,false,0x7F)]
        public void StoreBit_For_Byte_Sets_The_Specified_Bit_To_The_Target_Value
            (uint destination, int offset, bool bit, uint expected)
        {
            var value = (byte)destination;
            value.StoreBit((byte)offset,bit);
            Assert.Equal((byte)expected,value);
        }

        [Theory]
        [InlineData(0x00,0,true,0x01)]
        [InlineData(0x00,7,true,0x80)]
        [InlineData(0xFF,0,false,0xFE)]
        [InlineData(0xFF,7,false,0x7F)]
        [InlineData(0x0000,15,true, 0x8000)]
        [InlineData(0xFFFF,15,false,0x7FFF)]
        public void StoreBit_For_Int16_Sets_The_Specified_Bit_To_The_Target_Value
            (uint destination, int offset, bool bit, uint expected)
        {
            var value = (short)destination;
            value.StoreBit((byte)offset,bit);
            Assert.Equal((short)expected,value);
        }
        
        [Theory]
        [InlineData(0x00,0,true,0x01)]
        [InlineData(0x00,7,true,0x80)]
        [InlineData(0xFF,0,false,0xFE)]
        [InlineData(0xFF,7,false,0x7F)]
        [InlineData(0x0000,15,true, 0x8000)]
        [InlineData(0xFFFF,15,false,0x7FFF)]
        public void StoreBit_For_UInt16_Sets_The_Specified_Bit_To_The_Target_Value
            (uint destination, int offset, bool bit, uint expected)
        {
            var value = (ushort)destination;
            value.StoreBit((byte)offset,bit);
            Assert.Equal((ushort)expected,value);
        }

        [Theory]
        [InlineData(0x00,0,true,0x01)]
        [InlineData(0x00,7,true,0x80)]
        [InlineData(0xFF,0,false,0xFE)]
        [InlineData(0xFF,7,false,0x7F)]
        [InlineData(0x0000,15,true, 0x8000)]
        [InlineData(0xFFFF,15,false,0x7FFF)]
        [InlineData(0x00000000,31,true, 0x80000000)]
        [InlineData(0xFFFFFFFF,31,false,0x7FFFFFFF)]
        public void StoreBit_For_Int32_Sets_The_Specified_Bit_To_The_Target_Value
            (uint destination, int offset, bool bit, uint expected)
        {
            var value = (int)destination;
            value.StoreBit((byte)offset,bit);
            Assert.Equal((int)expected,value);
        }
        
        [Theory]
        [InlineData(0x00,0,true,0x01)]
        [InlineData(0x00,7,true,0x80)]
        [InlineData(0xFF,0,false,0xFE)]
        [InlineData(0xFF,7,false,0x7F)]
        [InlineData(0x0000,15,true, 0x8000)]
        [InlineData(0xFFFF,15,false,0x7FFF)]
        [InlineData(0x00000000,31,true, 0x80000000)]
        [InlineData(0xFFFFFFFF,31,false,0x7FFFFFFF)]
        public void StoreBit_For_UInt32_Sets_The_Specified_Bit_To_The_Target_Value
            (uint value, int offset, bool bit, uint expected)
        {
            value.StoreBit((byte)offset,bit);
            Assert.Equal(expected,value);
        }

        

        [Theory]
        [InlineData(0x00,0,true,0x01)]
        [InlineData(0x00,7,true,0x80)]
        [InlineData(0xFF,0,false,0xFE)]
        [InlineData(0xFF,7,false,0x7F)]
        [InlineData(0x0000,15,true, 0x8000)]
        [InlineData(0xFFFF,15,false,0x7FFF)]
        [InlineData(0x00000000,31,true, 0x80000000)]
        [InlineData(0xFFFFFFFF,31,false,0x7FFFFFFF)]
        [InlineData(0x0000000000000000,63,true, 0x8000000000000000)]
        [InlineData(0xFFFFFFFFFFFFFFFF,63,false,0x7FFFFFFFFFFFFFFF)]
        public void StoreBit_For_Int64_Sets_The_Specified_Bit_To_The_Target_Value
            (ulong destination, int offset, bool bit, ulong expected)
        {
            var value = (long)destination;
            value.StoreBit((byte)offset,bit);
            Assert.Equal((long)expected,value);
        }
        
        [Theory]
        [InlineData(0x00,0,true,0x01)]
        [InlineData(0x00,7,true,0x80)]
        [InlineData(0xFF,0,false,0xFE)]
        [InlineData(0xFF,7,false,0x7F)]
        [InlineData(0x0000,15,true, 0x8000)]
        [InlineData(0xFFFF,15,false,0x7FFF)]
        [InlineData(0x00000000,31,true, 0x80000000)]
        [InlineData(0xFFFFFFFF,31,false,0x7FFFFFFF)]
        [InlineData(0x0000000000000000,63,true, 0x8000000000000000)]
        [InlineData(0xFFFFFFFFFFFFFFFF,63,false,0x7FFFFFFFFFFFFFFF)]
        public void StoreBit_For_UInt64_Sets_The_Specified_Bit_To_The_Target_Value
            (ulong value, int offset, bool bit, ulong expected)
        {
            value.StoreBit((byte)offset,bit);
            Assert.Equal(expected,value);
        }
        #endregion
        
        // TODO: Add tests for direct calls to BitMask overloads.
        
    }
}
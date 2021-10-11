using Xunit;

namespace Jcd.BitManipulation.Tests
{
    public class BooleanArrayExtensionsTests
    {
        [Theory]
        [InlineData(0xFF)]
        [InlineData(0xF3)]
        [InlineData(0x71)]
        public void Byte_Round_Trip_Remains_Unaltered(uint data)
        {
            var expected = (byte)data;
            var actual = expected.ToBooleanArray().ToByte();
            Assert.Equal(expected,actual);
        }
        
        [Theory]
        [InlineData(0xFF)]
        [InlineData(0xF3)]
        [InlineData(0x71)]
        public void SByte_Round_Trip_Remains_Unaltered(uint data)
        {
            var expected = (sbyte)data;
            var actual = expected.ToBooleanArray().ToSByte();
            Assert.Equal(expected,actual);
        }
        
        [Theory]
        [InlineData(0xFFFF)]
        [InlineData(0xF3FF)]
        [InlineData(0x71FF)]
        public void UInt16_Round_Trip_Remains_Unaltered(uint data)
        {
            var expected = (ushort)data;
            var actual = expected.ToBooleanArray().ToUInt16();
            Assert.Equal(expected,actual);
        }
        
        [Theory]
        [InlineData(0xEEFF)]
        [InlineData(0xEEF3)]
        [InlineData(0xEE71)]
        public void Int16_Round_Trip_Remains_Unaltered(uint data)
        {
            var expected = (short)data;
            var actual = expected.ToBooleanArray().ToInt16();
            Assert.Equal(expected,actual);
        }
        
        [Theory]
        [InlineData(0xFFEEAACC)]
        [InlineData(0xF3EEAACC)]
        [InlineData(0x71EEAACC)]
        public void UInt32_Round_Trip_Remains_Unaltered(uint expected)
        {
            var actual = expected.ToBooleanArray().ToUInt32();
            Assert.Equal(expected,actual);
        }
        
        [Theory]
        [InlineData(0xEEAACCFF)]
        [InlineData(0xEEAACCF3)]
        [InlineData(0xEEAACC71)]
        public void Int32_Round_Trip_Remains_Unaltered(uint data)
        {
            var expected = (int)data;
            var actual = expected.ToBooleanArray().ToInt32();
            Assert.Equal(expected,actual);
        }
        
        [Theory]
        [InlineData(0xFFEEAACC11223344)]
        [InlineData(0xF3EEAACC11223344)]
        [InlineData(0x71EEAACC11223344)]
        public void UInt64_Round_Trip_Remains_Unaltered(ulong expected)
        {
            var actual = expected.ToBooleanArray().ToUInt64();
            Assert.Equal(expected,actual);
        }
        
        [Theory]
        [InlineData(0xEEAACC11223344FF)]
        [InlineData(0xEEAACC11223344F3)]
        [InlineData(0xEEAACC1122334471)]
        public void Int64_Round_Trip_Remains_Unaltered(ulong data)
        {
            var expected = (long)data;
            var actual = expected.ToBooleanArray().ToInt64();
            Assert.Equal(expected,actual);
        }
    }
}
using Xunit;

namespace Jcd.BitManipulation.Tests
{
    public class BitIndexerExtensionsTests
    {
        [Fact]
        public void ToBitIndexer_From_Byte_Returns_BitIndexerByte()
        {
            const byte value = 0;
            Assert.IsType<BitIndexerByte>(value.ToBitIndexer());
        }
        
        [Fact]
        public void ToBitIndexer_From_SByte_Returns_BitIndexerSByte()
        {
            const sbyte value = 0;
            Assert.IsType<BitIndexerSByte>(value.ToBitIndexer());
        }
        
        [Fact]
        public void ToBitIndexer_From_Int16_Returns_BitIndexerInt16()
        {
            const short value = 0;
            Assert.IsType<BitIndexerInt16>(value.ToBitIndexer());
        }
        
        [Fact]
        public void ToBitIndexer_From_UInt16_Returns_BitIndexerUInt16()
        {
            const ushort value = 0;
            Assert.IsType<BitIndexerUInt16>(value.ToBitIndexer());
        }
        
        [Fact]
        public void ToBitIndexer_From_Int32_Returns_BitIndexerInt32()
        {
            const int value = 0;
            Assert.IsType<BitIndexerInt32>(value.ToBitIndexer());
        }
        
        [Fact]
        public void ToBitIndexer_From_UInt32_Returns_BitIndexerUInt32()
        {
            const uint value = 0;
            Assert.IsType<BitIndexerUInt32>(value.ToBitIndexer());
        }
        
        [Fact]
        public void ToBitIndexer_From_Int64_Returns_BitIndexerInt64()
        {
            const long value = 0;
            Assert.IsType<BitIndexerInt64>(value.ToBitIndexer());
        }
        
        [Fact]
        public void ToBitIndexer_From_UInt64_Returns_BitIndexerUInt64()
        {
            const ulong value = 0;
            Assert.IsType<BitIndexerUInt64>(value.ToBitIndexer());
        }

        [Fact]
        public void ToByte_Truncates_Extra_Bits()
        {
            var indexer = new BitIndexerUInt64 { Bits = 0xDEADBEEF0D06F00D };
            Assert.Equal((byte)0x0D,indexer.ToByte());
        }
        
        [Fact]
        public void ToSByte_Truncates_Extra_Bits()
        {
            var indexer = new BitIndexerUInt64 { Bits = 0xDEADBEEF0D06F00D };
            Assert.Equal((sbyte)0x0D,indexer.ToSByte());
        }
        
        [Fact]
        public void ToInt16_Truncates_Extra_Bits()
        {
            var indexer = new BitIndexerUInt64 { Bits = 0xDEADBEEF0D06700D };
            Assert.Equal((short)0x700D,indexer.ToInt16());
        }
        
        [Fact]
        public void ToUInt16_Truncates_Extra_Bits()
        {
            var indexer = new BitIndexerUInt64 { Bits = 0xDEADBEEF0D06F00D };
            Assert.Equal((ushort)0xF00D,indexer.ToUInt16());
        }
        
        [Fact]
        public void ToInt32_Truncates_Extra_Bits()
        {
            var indexer = new BitIndexerUInt64 { Bits = 0xDEADBEEF0D06F00D };
            Assert.Equal(0x0D06F00D,indexer.ToInt32());
        }
        
        [Fact]
        public void ToUInt32_Truncates_Extra_Bits()
        {
            var indexer = new BitIndexerUInt64 { Bits = 0xDEADBEEF0D06F00D };
            Assert.Equal((uint)0x0D06F00D,indexer.ToUInt32());
        }
    }
}
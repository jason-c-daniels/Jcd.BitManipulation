using System.Collections;
using System.Linq;
using Xunit;

namespace Jcd.BitManipulation.Tests
{
    public class BitIndexerInt16Tests
    {
        [Fact]
        public void Constant_Bit_Size_Is_16_Bits()
        {
            Assert.Equal(16,BitIndexerInt16.BitSize);
        }

        [Fact]
        public void Length_Is_Bit_Size()
        {
            Assert.Equal(BitIndexerInt16.BitSize,new BitIndexerInt16().Length);
        }

        [Theory]
        [InlineData(0x0FFF)]
        [InlineData(0x7DFE)]
        [InlineData(0x7FD1)]
        [InlineData(0b00011000)]
        public void Implicit_Operator_To_BitIndexerInt16_From_Int16_Sets_All_Bits_Correctly(uint data)
        {
            // HACK: Type binder for xUnit hates bytes as params. Coerce the value here.
            var bits = (short)data;
            BitIndexerInt16 indexer = bits;
            Assert.Equal(bits,indexer.Bits);
        }

        [Theory]
        [InlineData(0xFF)]
        [InlineData(0xFE)]
        [InlineData(0x7F)]
        [InlineData(0b00011000)]
        public void Implicit_Operator_From_BitIndexerInt16_To_Int16_Sets_All_Bits_Correctly(uint data)
        {
            // HACK: Type binder for xUnit hates bytes as params. Coerce the value here.
            var indexer = new BitIndexerInt16{ Bits= (short)data };
            short bits = indexer;
            
            Assert.Equal(indexer.Bits,bits);
        }

        [Theory]
        [InlineData(0b0101010101000001)]
        [InlineData(0b1010101001000001)]
        [InlineData(0b1011111001000001)]
        [InlineData(0b0100000101000001)]
        public void Indexer_Returns_Correct_Bit_Value(uint data)
        {
            var value = (short)data;
            BitIndexerInt16 indexer = value;
            short mask = 0;
            for (var i = 0; i < indexer.Length; i++)
            {
                mask.SetBit(i);
                var bit = (value & mask) != 0;
                Assert.Equal(bit,indexer[i]);
                mask.ClearBit(i);
            }
        }
        
        [Theory]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(6)]
        [InlineData(14)]
        public void Indexer_Sets_Correct_Bit_Value(int index )
        {
            BitIndexerInt16 indexer = 0;
            short expected = 0;
            expected.SetBit(index);
            indexer[index] = true;
            Assert.Equal(expected,indexer.Bits);
            Assert.True(indexer[index]);
            indexer[index] = false;
            Assert.False(indexer[index]);
        }

        [Fact]
        public void Enumerator_Enumerates_Correct_Number_Of_Bits()
        {
            var indexer = new BitIndexerInt16 { Bits = 0x7e };
            Assert.Equal(BitIndexerInt16.BitSize,indexer.ToArray().Length);
        }
        
        [Theory]
        [InlineData(0b10101000000000)]
        [InlineData(0b11101100000000)]
        public void Enumerator_Enumerates_Bits_In_Correct_Order_LSB_to_MSB(int data)
        {
            var indexer = new BitIndexerInt16 { Bits = (short)data };
            var bitValues = indexer.ToArray();

            for (var i = 0; i < indexer.Length; i++)
            {
                Assert.Equal(indexer.Bits.ReadBit(i),bitValues[i]);
            }
        }

        [Theory]
        [InlineData(0b0000000000000000,"0b0000000000000000")]
        [InlineData(0b0000000000011100,"0b0000000000011100")]
        [InlineData(0b1110000000000000,"0b1110000000000000")]
        public void ToString_Formats_As_Binary_Int_Representation(uint data, string expected)
        {
            var indexer = new BitIndexerInt16 { Bits = (short)data };
            Assert.Equal(expected,indexer.ToString());
        }

        [Theory]
        [InlineData(0b00011100,0,4)]
        [InlineData(0b00011100,2,6)]
        [InlineData(0b00011100,0,8)]
        public void Slice_Returns_Correct_Subset_Of_Bools(uint data, int start, int end)
        {
            var indexer = new BitIndexerInt16 { Bits = (short)data };
            var bits = indexer.ToArray();
            var expected = bits[start..end];
            var actual = indexer[start..end];
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void IEnumerable_GetEnumerator_Enumerates_The_Correct_Number_Of_Items()
        {
            var itemCount = 0;
            var enumerable = (IEnumerable)new BitIndexerInt16 { Bits = 0x7FFF };
            foreach (var item in enumerable)
            {
                Assert.IsType<bool>(item);
                itemCount++;
            }
            Assert.Equal(BitIndexerInt16.BitSize,itemCount);
        }
    }
}
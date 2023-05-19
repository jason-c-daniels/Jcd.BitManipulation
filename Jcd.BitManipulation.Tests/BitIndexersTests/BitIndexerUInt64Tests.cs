#region

using System.Collections;
using System.Linq;
using Jcd.BitManipulation.BitIndexers;
using Xunit;

// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation.Possible

#endregion

namespace Jcd.BitManipulation.Tests.BitIndexersTests;

public class BitIndexerUInt64Tests
{
    [Fact]
    public void Constant_Bit_Size_Is_64_Bits()
    {
        Assert.Equal(64, BitIndexerUInt64.BitSize);
    }

    [Fact]
    public void Length_Is_Bit_Size()
    {
        Assert.Equal(BitIndexerUInt64.BitSize, new BitIndexerUInt64().Length);
    }

    [Theory]
    [InlineData(0x0FFF)]
    [InlineData(0x7DFE)]
    [InlineData(0x7FD1)]
    [InlineData(0b00011000)]
    public void Implicit_Operator_To_BitIndexerUInt64_From_UInt64_Sets_All_Bits_Correctly(ulong data)
    {
        BitIndexerUInt64 indexer = data;
        Assert.Equal(data, indexer.Bits);
    }

    [Theory]
    [InlineData(0xFF)]
    [InlineData(0xFE)]
    [InlineData(0x7F)]
    [InlineData(0b00011000)]
    public void Implicit_Operator_From_BitIndexerUInt64_To_UInt64_Sets_All_Bits_Correctly(ulong data)
    {
        // HACK: Type binder for xUnit hates bytes as params. Coerce the value here.
        var indexer = new BitIndexerUInt64 { Bits = data };
        ulong bits = indexer;

        Assert.Equal((ulong)indexer, bits);
    }

    [Theory]
    [InlineData(0b0101010101000001)]
    [InlineData(0b1010101001000001)]
    [InlineData(0b1011111001000001)]
    [InlineData(0b0100000101000001)]
    public void Indexer_Returns_Correct_Bit_Value(ulong data)
    {
        BitIndexerUInt64 indexer = data;
        ulong mask = 0;
        for (var i = 0; i < indexer.Length; i++)
        {
            mask = mask.SetBit(i);
            var bit = (data & mask) != 0;
            Assert.Equal(bit, indexer[i]);
            mask = mask.ClearBit(i);
        }
    }

    [Theory]
    [InlineData(0)]
    [InlineData(2)]
    [InlineData(6)]
    [InlineData(14)]
    public void Indexer_Sets_Correct_Bit_Value(int index)
    {
        BitIndexerUInt64 indexer = 0;
        ulong expected = 0;
        expected = expected.SetBit(index);
        indexer[index] = true;
        Assert.Equal(expected, indexer.Bits);
        Assert.True(indexer[index]);
        indexer[index] = false;
        Assert.False(indexer[index]);
    }

    [Fact]
    public void Enumerator_Enumerates_Correct_Number_Of_Bits()
    {
        var indexer = new BitIndexerUInt64 { Bits = 0x7e };
        Assert.Equal(BitIndexerUInt64.BitSize, indexer.ToArray().Length);
    }

    [Theory]
    [InlineData(0b10101000000000)]
    [InlineData(0b11101100000000)]
    public void Enumerator_Enumerates_Bits_In_Correct_Order_LSB_to_MSB(ulong data)
    {
        var indexer = new BitIndexerUInt64 { Bits = data };
        var bitValues = indexer.ToArray();

        for (var i = 0; i < indexer.Length; i++) Assert.Equal(indexer.Bits.ReadBit(i), bitValues[i]);
    }

    [Theory]
    [InlineData(0b0000000000000000000000000000000000000000000000000000000000000100,
        "0b0000000000000000000000000000000000000000000000000000000000000100")]
    [InlineData(0b0010000000011100000000000000000000000000000000000000000000000000,
        "0b0010000000011100000000000000000000000000000000000000000000000000")]
    [InlineData(0b0000000000000000111000000000000000000000000000000000000000000000,
        "0b0000000000000000111000000000000000000000000000000000000000000000")]
    public void ToString_Formats_As_Binary_Int_Representation(ulong data, string expected)
    {
        var indexer = new BitIndexerUInt64 { Bits = data };
        Assert.Equal(expected, indexer.ToString());
    }

    [Theory]
    [InlineData(0b00011100, 0, 4)]
    [InlineData(0b00011100, 2, 6)]
    [InlineData(0b00011100, 0, 8)]
    public void Slice_Returns_Correct_Subset_Of_Bools(ulong data, int start, int end)
    {
        var indexer = new BitIndexerUInt64 { Bits = data };
        var bits = indexer.ToArray();
        var expected = bits[start..end];
        var actual = indexer[start..end];
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void IEnumerable_GetEnumerator_Enumerates_The_Correct_Number_Of_Items()
    {
        var itemCount = 0;
        var enumerable = (IEnumerable)new BitIndexerUInt64 { Bits = 0x7FFF };
        foreach (var item in enumerable)
        {
            Assert.IsType<bool>(item);
            itemCount++;
        }

        Assert.Equal(BitIndexerUInt64.BitSize, itemCount);
    }
}
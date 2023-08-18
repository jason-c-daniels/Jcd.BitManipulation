#region

using System;
using Jcd.BitManipulation.ByteIndexers;
using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests.ByteIndexerTests;

public class ByteIndexerSByteTests
{
    [Fact]
    public void Constant_ByteSize_Is_One()
    {
        Assert.Equal(sizeof(sbyte), ByteIndexerSByte.ByteSize);
    }

    [Fact]
    public void Length_Is_BitSize()
    {
        ByteIndexerSByte sut = 0;
        Assert.Equal(ByteIndexerSByte.ByteSize, sut.Length);
    }

    [Theory]
    [InlineData(0xFF)]
    [InlineData(0xFE)]
    [InlineData(0x7F)]
    [InlineData(0b00011000)]
    public void Implicit_Conversion_Operators_Round_Trip_Returns_Original_Value(uint data)
    {
        var expected = (sbyte)data;
        ByteIndexerSByte sut = expected;
        sbyte convertedBack = sut;
        Assert.Equal(expected, convertedBack);
    }

    [Theory]
    [InlineData(0xFF, 0, 0xFF)]
    [InlineData(0xFE, 0, 0xFE)]
    [InlineData(0x7F, 0, 0x7F)]
    [InlineData(0b00011000, 0, 0b00011000)]
    public void Indexer_Get_Returns_Expected_Value(uint data, int index, uint extractedData)
    {
        var expected = (byte)extractedData;
        ByteIndexerSByte sut = (sbyte)data;
        Assert.Equal(expected, sut[index]);
    }

    [Theory]
    [InlineData(0x01, 0, 0xFF)]
    [InlineData(0x02, 0, 0xFE)]
    [InlineData(0x03, 0, 0x7F)]
    [InlineData(0b00011000, 0, 0b00011000)]
    public void Indexer_Set_Sets_The_Expected_Value(uint data, int index, uint dataToSet)
    {
        var expected = (sbyte)dataToSet;
        ByteIndexerSByte sut = (sbyte)data;
        sut[index] = (byte)expected;
        Assert.Equal(expected, (sbyte)sut);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(ByteIndexerSByte.ByteSize)]
    public void Indexer_Get_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
    {
        ByteIndexerSByte sut = 0x7F;
        Assert.Throws<ArgumentOutOfRangeException>(() => sut[index]);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(ByteIndexerSByte.ByteSize)]
    public void Indexer_Set_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
    {
        ByteIndexerSByte sut = 0x7F;
        Assert.Throws<ArgumentOutOfRangeException>(() => sut[index] = 0);
    }

    [Theory]
    [InlineData(0xFF, 0, 0xFF)]
    [InlineData(0xFE, 0, 0xFE)]
    [InlineData(0x7F, 0, 0x7F)]
    [InlineData(0b00011000, 0, 0b00011000)]
    public void Slice_Returns_Expected_Subset(short data, int index, byte extractedData)
    {
        var expected = new[] { extractedData };
        ByteIndexerInt16 sut = data;
        Assert.Equal(expected, sut.Slice(index, 1));
    }
}
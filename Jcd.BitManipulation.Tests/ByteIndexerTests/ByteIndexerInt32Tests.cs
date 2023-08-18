#region

using System;
using System.Collections.Generic;
using Jcd.BitManipulation.ByteIndexers;
using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests.ByteIndexerTests;

public class ByteIndexerInt32Tests
{
    [Fact]
    public void Constant_ByteSize_Is_Two()
    {
        Assert.Equal(sizeof(int), ByteIndexerInt32.ByteSize);
    }

    [Fact]
    public void Length_Is_BitSize()
    {
        ByteIndexerInt32 sut = 0;
        Assert.Equal(ByteIndexerInt32.ByteSize, sut.Length);
    }

    [Theory]
    [InlineData(0x01FF)]
    [InlineData(0x20FE)]
    [InlineData(0x337F)]
    public void Implicit_Conversion_Operators_Round_Trip_Returns_Original_Value(uint data)
    {
        var expected = (int)data;
        ByteIndexerInt32 sut = expected;
        int convertedBack = sut;
        Assert.Equal(expected, convertedBack);
    }

    [Theory]
    [InlineData(0x01FF, 0, 0xFF)]
    [InlineData(0x02FE, 0, 0xFE)]
    [InlineData(0x037F, 0, 0x7F)]
    [InlineData(0x01FF, 1, 0x01)]
    [InlineData(0x02FE, 1, 0x02)]
    [InlineData(0x037F, 1, 0x03)]
    public void Indexer_Get_Returns_Expected_Value(uint data, int index, byte extractedData)
    {
        var expected = extractedData;
        ByteIndexerInt32 sut = (int)data;
        Assert.Equal(expected, sut[index]);
    }

    [Theory]
    [InlineData(0x0101, 1, 0x7F, 0x7F01)]
    [InlineData(0x0202, 1, 0x7E, 0x7E02)]
    [InlineData(0x0303, 1, 0x7D, 0x7D03)]
    [InlineData(0x0101, 0, 0xFF, 0x01FF)]
    [InlineData(0x0202, 0, 0xFE, 0x02FE)]
    [InlineData(0x0303, 0, 0x7F, 0x037F)]
    public void Indexer_Set_Sets_The_Expected_Value(int data, int index, byte dataToSet, int expected)
    {
        ByteIndexerInt32 sut = data;
        sut[index] = dataToSet;
        Assert.Equal(expected, (int)sut);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(ByteIndexerInt32.ByteSize)]
    public void Indexer_Get_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
    {
        ByteIndexerInt32 sut = 0xFF;
        Assert.Throws<ArgumentOutOfRangeException>(() => sut[index]);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(ByteIndexerInt32.ByteSize)]
    public void Indexer_Set_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
    {
        ByteIndexerInt32 sut = 0xFF;
        Assert.Throws<ArgumentOutOfRangeException>(() => sut[index] = 0);
    }

    [Theory]
    [InlineData(0x010101FF, 0, 1, 1, 0xFF)]
    [InlineData(0x010202FE, 0, 2, 2, 0xFE, 0x02)]
    [InlineData(0x0102037F, 0, 3, 3, 0x7F, 0x03, 0x02)]
    [InlineData(0x030201FF, 0, 4, 4, 0xFF, 0x01, 0x02, 0x03)]
    [InlineData(0x040302FE, 1, 3, 3, 0x02, 0x03, 0x04)]
    [InlineData(0x05060708, 2, 2, 2, 0x06, 0x05)]
    [InlineData(0x0F060708, 3, 1, 1, 0x0F)]
    public void Slice_Returns_Expected_Subset(int data, int index, int size, int expectedSize, byte e0, byte e1 = 0,
                                              byte e2 = 0, byte e3 = 0)
    {
        var expected = new List<byte>(new[] { e0 });
        if (expectedSize >= 2) expected.Add(e1);
        if (expectedSize >= 3) expected.Add(e2);
        if (expectedSize >= 4) expected.Add(e3);

        ByteIndexerInt32 sut = data;
        Assert.Equal(expected.ToArray(), sut.Slice(index, size));
    }
}
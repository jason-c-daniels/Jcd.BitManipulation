#region

using System;
using System.Collections.Generic;
using Jcd.BitManipulation.ByteIndexers;
using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests.ByteIndexerTests;

public class LittleEndianByteIndexerUInt64Tests
{
    [Fact]
    public void Constant_ByteSize_Is_Two()
    {
       Assert.Equal(sizeof(ulong), LittleEndianByteIndexerUInt64.ByteSize);
    }

    [Fact]
    public void Length_Is_BitSize()
    {
       LittleEndianByteIndexerUInt64 sut = 0;
       Assert.Equal(LittleEndianByteIndexerUInt64.ByteSize, sut.Length);
    }

    [Theory]
    [InlineData(0x01FF)]
    [InlineData(0x20FE)]
    [InlineData(0x337F)]
    [InlineData(0b111001100011000)]
    public void Implicit_Conversion_Operators_Round_Trip_Returns_Original_Value(uint data)
    {
        var                           expected      = (ushort)data;
        LittleEndianByteIndexerUInt64 sut           = expected;
        ulong                         convertedBack = sut;
        Assert.Equal(expected, convertedBack);
    }

    [Theory]
    [InlineData(0x01FF, 0, 0xFF)]
    [InlineData(0x02FE, 0, 0xFE)]
    [InlineData(0x037F, 0, 0x7F)]
    [InlineData(0x01FF, 1, 0x01)]
    [InlineData(0x02FE, 1, 0x02)]
    [InlineData(0x037F, 1, 0x03)]
    public void Indexer_Get_Returns_Expected_Value(uint data, int index, uint extractedData)
    {
        var                           expected = (ushort)extractedData;
        LittleEndianByteIndexerUInt64 sut      = (ushort) data;
        Assert.Equal(expected, sut[index]);
    }

    [Theory]
    [InlineData(0x0101, 1, 0xFF, 0xFF01)]
    [InlineData(0x0202, 1, 0xFE, 0xFE02)]
    [InlineData(0x0303, 1, 0x7F, 0x7F03)]
    [InlineData(0x0101, 0, 0xFF, 0x01FF)]
    [InlineData(0x0202, 0, 0xFE, 0x02FE)]
    [InlineData(0x0303, 0, 0x7F, 0x037F)]
    public void Indexer_Set_Sets_The_Expected_Value(ushort data, int index, byte dataToSet, ushort expected)
    {
       LittleEndianByteIndexerUInt64 sut = data;
        sut[index] = dataToSet;
        Assert.Equal(expected, (ushort)sut);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(LittleEndianByteIndexerUInt64.ByteSize)]
    public void Indexer_Get_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
    {
       LittleEndianByteIndexerUInt64 sut = 0xFF;
        Assert.Throws<ArgumentOutOfRangeException>(() => sut[index]);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(LittleEndianByteIndexerUInt64.ByteSize)]
    public void Indexer_Set_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
    {
       LittleEndianByteIndexerUInt64 sut = 0xFF;
        Assert.Throws<ArgumentOutOfRangeException>(() => sut[index] = 0);
    }

    [Theory]
    [InlineData(0x00000000010101FF, 0, 1, 1, 0xFF)]
    [InlineData(0x00000000010202FE, 0, 2, 2, 0xFE, 0x02)]
    [InlineData(0x000000000102037F, 0, 3, 3, 0x7F, 0x03, 0x02)]
    [InlineData(0x00000000030201FF, 0, 4, 4, 0xFF, 0x01, 0x02, 0x03)]
    [InlineData(0x07060504030201FF, 0, 5, 5, 0xFF, 0x01, 0x02, 0x03, 0x04)]
    [InlineData(0x07060504030201FF, 0, 6, 6, 0xFF, 0x01, 0x02, 0x03, 0x04, 0x05)]
    [InlineData(0x07060504030201FF, 0, 7, 7, 0xFF, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06)]
    [InlineData(0x07060504030201FF, 0, 8, 8, 0xFF, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07)]
    [InlineData(0x00000000040302FE, 1, 3, 3, 0x02, 0x03, 0x04)]
    [InlineData(0x0000000005060708, 2, 2, 2, 0x06, 0x05)]
    [InlineData(0x000000000F060708, 3, 1, 1, 0x0F)]
    public void Slice_Returns_Expected_Subset(ulong data, int index, int size, int expectedSize, byte e0, byte e1 = 0,
                                              byte e2 = 0, byte e3 = 0, byte e4 = 0, byte e5 = 0, byte e6 = 0,
                                              byte e7 = 0)
    {
        var expected = new List<byte>(new[] { e0 });
        if (expectedSize >= 2) expected.Add(e1);
        if (expectedSize >= 3) expected.Add(e2);
        if (expectedSize >= 4) expected.Add(e3);
        if (expectedSize >= 5) expected.Add(e4);
        if (expectedSize >= 6) expected.Add(e5);
        if (expectedSize >= 7) expected.Add(e6);
        if (expectedSize == 8) expected.Add(e7);

        LittleEndianByteIndexerUInt64 sut = data;
        Assert.Equal(expected.ToArray(), sut.Slice(index, size));
    }
}
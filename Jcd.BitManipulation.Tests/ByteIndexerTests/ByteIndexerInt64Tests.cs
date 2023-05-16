using System;
using System.Collections.Generic;
using Jcd.BitManipulation.ByteIndexers;
using Xunit;

namespace Jcd.BitManipulation.Tests.ByteIndexerTests;

public class ByteIndexerInt64Tests
{
    [Fact]
    public void Constant_ByteSize_Is_Two()
    {
        Assert.Equal(sizeof(long),ByteIndexerInt64.ByteSize);
    }

    [Fact]
    public void Length_Is_BitSize()
    {
        ByteIndexerInt64 sut = 0;
        Assert.Equal(ByteIndexerInt64.ByteSize,sut.Length);
    }

    [Theory]
    [InlineData(0x01FF)]
    [InlineData(0x20FE)]
    [InlineData(0x337F)]
    public void Implicit_Conversion_Operators_Round_Trip_Returns_Original_Value(long data)
    {
        var expected = (int)data;
        ByteIndexerInt64 sut = expected;
        long convertedBack = sut;
        Assert.Equal(expected,convertedBack);
    }
    
    [Theory]
    [InlineData(0x01FF,0,0xFF)]
    [InlineData(0x02FE,0,0xFE)]
    [InlineData(0x037F,0,0x7F)]
    [InlineData(0x01FF,1,0x01)]
    [InlineData(0x02FE,1,0x02)]
    [InlineData(0x037F,1,0x03)]
    public void Indexer_Get_Returns_Expected_Value(long data,int index,long extractedData)
    {
        var expected = (int)extractedData;
        ByteIndexerInt64 sut = (int)data;
        Assert.Equal(expected,sut[index]);
    }
    
    [Theory]
    [InlineData(0x0101,1,0x7F,0x7F01)]
    [InlineData(0x0202,1,0x7E,0x7E02)]
    [InlineData(0x0303,1,0x7D,0x7D03)]
    [InlineData(0x0101,0,0xFF,0x01FF)]
    [InlineData(0x0202,0,0xFE,0x02FE)]
    [InlineData(0x0303,0,0x7F,0x037F)]
    public void Indexer_Set_Sets_The_Expected_Value(long data,int index,byte dataToSet,int expected)
    {
        ByteIndexerInt64 sut = data;
        sut[index] = dataToSet;
        Assert.Equal(expected,(int)sut);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(ByteIndexerInt64.ByteSize)]
    public void Indexer_Get_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
    {
        ByteIndexerInt64 sut = 0xFF;
        Assert.Throws<ArgumentOutOfRangeException>(()=>sut[index]);
    }
    
    [Theory]
    [InlineData(-1)]
    [InlineData(ByteIndexerInt64.ByteSize)]

    public void Indexer_Set_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
    {
        ByteIndexerInt64 sut = 0xFF;
        Assert.Throws<ArgumentOutOfRangeException>(()=>sut[index]=0);
    }

    [Theory]
    [InlineData(0x00000000010101FF, 0, 1, 1, 0xFF)]
    [InlineData(0x00000000010202FE, 0, 2, 2, 0xFE, 0x02)]
    [InlineData(0x000000000102037F, 0, 3, 3, 0x7F, 0x03, 0x02)]
    [InlineData(0x00000000030201FF, 0, 4, 4, 0xFF, 0x01, 0x02, 0x03)]
    [InlineData(0x07060504030201FF, 0, 5, 5, 0xFF, 0x01, 0x02, 0x03,0x04)]
    [InlineData(0x07060504030201FF, 0, 6, 6, 0xFF, 0x01, 0x02, 0x03,0x04,0x05)]
    [InlineData(0x07060504030201FF, 0, 7, 7, 0xFF, 0x01, 0x02, 0x03,0x04,0x05,0x06)]
    [InlineData(0x07060504030201FF, 0, 8, 8, 0xFF, 0x01, 0x02, 0x03,0x04,0x05,0x06, 0x07)]
    [InlineData(0x00000000040302FE, 1, 3, 3, 0x02, 0x03, 0x04)]
    [InlineData(0x0000000005060708, 2, 2, 2, 0x06, 0x05)]
    [InlineData(0x000000000F060708, 3, 1, 1, 0x0F)]
    public void Slice_Returns_Expected_Subset(long data, int index, int size, int expectedSize, byte e0, byte e1 = 0,
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
        
        ByteIndexerInt64 sut = data;
        Assert.Equal(expected.ToArray(), sut.Slice(index, size));
    }
}
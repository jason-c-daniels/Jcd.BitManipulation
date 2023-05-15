using System;
using Jcd.BitManipulation.ByteIndexers;
using Xunit;

namespace Jcd.BitManipulation.Tests.ByteIndexerTests;

public class ByteIndexerInt16Tests
{
    [Fact]
    public void Constant_ByteSize_Is_Two()
    {
        Assert.Equal(2,ByteIndexerInt16.ByteSize);
    }

    [Fact]
    public void Length_Is_BitSize()
    {
        ByteIndexerInt16 sut = 0;
        Assert.Equal(ByteIndexerInt16.ByteSize,sut.Length);
    }

    [Theory]
    [InlineData(0x01FF)]
    [InlineData(0x20FE)]
    [InlineData(0x337F)]
    [InlineData(0b111001100011000)]
    public void Implicit_Conversion_Operators_Round_Trip_Returns_Original_Value(uint data)
    {
        var expected = (short)data;
        ByteIndexerInt16 sut = expected;
        short convertedBack = sut;
        Assert.Equal(expected,convertedBack);
    }
    
    [Theory]
    [InlineData(0x01FF,0,0xFF)]
    [InlineData(0x02FE,0,0xFE)]
    [InlineData(0x037F,0,0x7F)]
    [InlineData(0x01FF,1,0x01)]
    [InlineData(0x02FE,1,0x02)]
    [InlineData(0x037F,1,0x03)]
    public void Indexer_Get_Returns_Expected_Value(uint data,int index,uint extractedData)
    {
        var expected = (short)extractedData;
        ByteIndexerInt16 sut = (short)data;
        Assert.Equal(expected,sut[index]);
    }
    
    [Theory]
    [InlineData(0x0101,1,0x7F,0x7F01)]
    [InlineData(0x0202,1,0x7E,0x7E02)]
    [InlineData(0x0303,1,0x7D,0x7D03)]
    [InlineData(0x0101,0,0xFF,0x01FF)]
    [InlineData(0x0202,0,0xFE,0x02FE)]
    [InlineData(0x0303,0,0x7F,0x037F)]
    public void Indexer_Set_Sets_The_Expected_Value(short data,int index,byte dataToSet,short expected)
    {
        ByteIndexerInt16 sut = data;
        sut[index] = dataToSet;
        Assert.Equal(expected,(short)sut);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(2)]
    public void Indexer_Get_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
    {
        ByteIndexerInt16 sut = 0xFF;
        Assert.Throws<ArgumentOutOfRangeException>(()=>sut[index]);
    }
    
    [Theory]
    [InlineData(-1)]
    [InlineData(2)]
    public void Indexer_Set_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
    {
        ByteIndexerInt16 sut = 0xFF;
        Assert.Throws<ArgumentOutOfRangeException>(()=>sut[index]=0);
    }

    [Theory]
    [InlineData(0x01FF,0,0xFF)]
    [InlineData(0x02FE,0,0xFE)]
    [InlineData(0x037F,0,0x7F)]
    [InlineData(0x01FF,1,0x01)]
    [InlineData(0x02FE,1,0x02)]
    [InlineData(0x037F,1,0x03)]
    public void Slice_Returns_Expected_Subset(short data,int index, uint extractedData)
    {
        var expected = new[]{(byte)extractedData};
        ByteIndexerInt16 sut = data;
        Assert.Equal(expected,sut.Slice(index,1));
    }
}
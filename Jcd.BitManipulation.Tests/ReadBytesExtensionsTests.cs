using System.Collections.Generic;
using Jcd.BitManipulation.ByteIndexers;
using Xunit;

namespace Jcd.BitManipulation.Tests;

public class ReadBytesExtensionsTests
{
    #region ReadByte Tests
    
    [Theory]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,0,0xF8)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,1,0xF9)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,2,0xFA)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,3,0xFB)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,4,0xFC)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,5,0xFD)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,6,0xFE)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,7,0xFF)]
    public void ReadByte_On_UInt64_Returns_Expected_Value(ulong data, int offset, byte expected)
    {
        Assert.Equal(expected,data.ReadByte(offset));
    }
    
    [Theory]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,0,0xF8)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,1,0xF9)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,2,0xFA)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,3,0xFB)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,4,0xFC)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,5,0xFD)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,6,0xFE)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,7,0xFF)]
    public void ReadByte_On_Int64_Returns_Expected_Value(ulong data, int offset, byte expected)
    {
        var ldata = (long)data;
        Assert.Equal(expected,ldata.ReadByte(offset));
    }
    
    [Theory]
    [InlineData(0xFB_FA_F9_F8,0,0xF8)]
    [InlineData(0xFB_FA_F9_F8,1,0xF9)]
    [InlineData(0xFB_FA_F9_F8,2,0xFA)]
    [InlineData(0xFB_FA_F9_F8,3,0xFB)]
    public void ReadByte_On_UInt32_Returns_Expected_Value(uint data, int offset, byte expected)
    {
        Assert.Equal(expected,data.ReadByte(offset));
    }
    
    [Theory]
    [InlineData(0xFB_FA_F9_F8,0,0xF8)]
    [InlineData(0xFB_FA_F9_F8,1,0xF9)]
    [InlineData(0xFB_FA_F9_F8,2,0xFA)]
    [InlineData(0xFB_FA_F9_F8,3,0xFB)]
    public void ReadByte_On_Int32_Returns_Expected_Value(uint data, int offset, byte expected)
    {
        var ldata = (int)data;
        Assert.Equal(expected,ldata.ReadByte(offset));
    }

    [Theory]
    [InlineData(0xF9_F8,0,0xF8)]
    [InlineData(0xF9_F8,1,0xF9)]
    public void ReadByte_On_UInt16_Returns_Expected_Value(ushort data, int offset, byte expected)
    {
        Assert.Equal(expected,data.ReadByte(offset));
    }
    
    [Theory]
    [InlineData(0xF9_F8,0,0xF8)]
    [InlineData(0xF9_F8,1,0xF9)]
    public void ReadByte_On_Int16_Returns_Expected_Value(ushort data, int offset, byte expected)
    {
        var ldata = (short)data;
        Assert.Equal(expected,ldata.ReadByte(offset));
    }
 
    [Theory]
    [InlineData(0xF8,0xF8)]
    [InlineData(0xF9,0xF9)]
    public void ReadByte_On_Byte_Returns_Expected_Value(byte data, byte expected)
    {
        Assert.Equal(expected,data.ReadByte());
    }
    
    [Theory]
    [InlineData(0xF8,0xF8)]
    [InlineData(0xF9,0xF9)]
    public void ReadByte_On_SByte_Returns_Expected_Value(byte data, byte expected)
    {
        var ldata = (sbyte)data;
        Assert.Equal(expected,ldata.ReadByte());
    }

    #endregion
    
    #region ReadBytes - Integral Data Type Tests
    
    [Theory]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,0,2)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,0,3)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,0,4)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,3,4)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,4,3)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,5,2)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,6,2)]
    public void ReadBytes_On_UInt64_Returns_Expected_Array(ulong data, int offset, int size)
    {
        var expected = new List<byte>();
        for (var i = 0; i < size; i++)
        {
            expected.Add(data.ReadByte(i+offset));
        }
        Assert.Equal(expected.ToArray(),data.ReadBytes(offset,size));
    }
    
    [Theory]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,0,2)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,0,3)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,0,4)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,3,4)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,4,3)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,5,2)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,6,2)]
    public void ReadBytes_On_Int64_Returns_Expected_Array(ulong data, int offset, int size)
    {
        var ldata = (long)data;
        var expected = new List<byte>();
        for (var i = 0; i < size; i++)
        {
            expected.Add(ldata.ReadByte(i+offset));
        }
        Assert.Equal(expected.ToArray(),ldata.ReadBytes(offset,size));
    }
    
    [Theory]
    [InlineData(0xFB_FA_F9_F8,0,4)]
    [InlineData(0xFB_FA_F9_F8,1,3)]
    [InlineData(0xFB_FA_F9_F8,2,2)]
    [InlineData(0xFB_FA_F9_F8,0,3)]
    public void ReadBytes_On_UInt32_Returns_Expected_Array(uint data, int offset, int size)
    {
        var expected = new List<byte>();
        for (var i = 0; i < size; i++)
        {
            expected.Add(data.ReadByte(i+offset));
        }
        Assert.Equal(expected.ToArray(),data.ReadBytes(offset,size));
    }
    
    [Theory]
    [InlineData(0xFB_FA_F9_F8,0,4)]
    [InlineData(0xFB_FA_F9_F8,1,3)]
    [InlineData(0xFB_FA_F9_F8,2,2)]
    [InlineData(0xFB_FA_F9_F8,0,3)]
    public void ReadBytes_On_Int32_Returns_Expected_Array(uint data, int offset, int size)
    {
        var ldata = (int)data;
        var expected = new List<byte>();
        for (var i = 0; i < size; i++)
        {
            expected.Add(ldata.ReadByte(i+offset));
        }
        Assert.Equal(expected.ToArray(),ldata.ReadBytes(offset,size));
    }

    [Theory]
    [InlineData(0xF9_F8,0,2)]
    [InlineData(0xFB_FA,1,1)]
    public void ReadBytes_On_UInt16_Returns_Expected_Array(ushort data, int offset, int size)
    {
        var expected = new List<byte>();
        for (var i = 0; i < size; i++)
        {
            expected.Add(data.ReadByte(i+offset));
        }
        Assert.Equal(expected.ToArray(),data.ReadBytes(offset,size));
    }
    
    [Theory]
    [InlineData(0xF9_F8,0,2)]
    [InlineData(0xFB_FA,1,1)]
    public void ReadBytes_On_Int16_Returns_Expected_Array(ushort data, int offset, int size)
    {
        var ldata = (short)data;
        var expected = new List<byte>();
        for (var i = 0; i < size; i++)
        {
            expected.Add(ldata.ReadByte(i+offset));
        }
        Assert.Equal(expected.ToArray(),ldata.ReadBytes(offset,size));
    }

    [Theory]
    [InlineData(0xF8,0,1)]
    [InlineData(0xFB,0,1)]
    public void ReadBytes_On_Byte_Returns_Expected_Array(byte data, int offset, int size)
    {
        var expected = new List<byte>();
        for (var i = 0; i < size; i++)
        {
            expected.Add(data.ReadByte());
        }
        Assert.Equal(expected.ToArray(),data.ReadBytes(offset,size));
    }
    
    [Theory]
    [InlineData(0xF8,0,1)]
    [InlineData(0xFB,0,1)]
    public void ReadBytes_On_SByte_Returns_Expected_Array(byte data, int offset, int size)
    {
        var ldata = (sbyte)data;
        var expected = new List<byte>();
        for (var i = 0; i < size; i++)
        {
            expected.Add(data);
        }
        Assert.Equal(expected.ToArray(),ldata.ReadBytes(offset,size));
    }

    
    #endregion

    #region ReadBytes - ByteIndexer Tests
    
    [Theory]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,0,2)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,0,3)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,0,4)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,3,4)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,4,3)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,5,2)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,6,2)]
    public void ReadBytes_On_ByteIndexerUInt64_Returns_Expected_Array(ulong baseData, int offset, int size)
    {
        ByteIndexerUInt64 data = baseData;
        var expected = new List<byte>();
        for (var i = 0; i < size; i++)
        {
            expected.Add(data[i+offset]);
        }
        Assert.Equal(expected.ToArray(),data.ReadBytes(offset,size));
    }
    
    [Theory]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,0,2)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,0,3)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,0,4)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,3,4)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,4,3)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,5,2)]
    [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8,6,2)]
    public void ReadBytes_On_ByteIndexerInt64_Returns_Expected_Array(ulong baseData, int offset, int size)
    {
        ByteIndexerInt64 data = (long)baseData;
        var expected = new List<byte>();
        for (var i = 0; i < size; i++)
        {
            expected.Add(data[i+offset]);
        }
        Assert.Equal(expected.ToArray(),data.ReadBytes(offset,size));
    }
    
    [Theory]
    [InlineData(0xFB_FA_F9_F8,0,4)]
    [InlineData(0xFB_FA_F9_F8,1,3)]
    [InlineData(0xFB_FA_F9_F8,2,2)]
    [InlineData(0xFB_FA_F9_F8,0,3)]
    public void ReadBytes_On_ByteIndexerUInt32_Returns_Expected_Array(uint baseData, int offset, int size)
    {
        ByteIndexerUInt32 data = baseData;
        var expected = new List<byte>();
        for (var i = 0; i < size; i++)
        {
            expected.Add(data[i+offset]);
        }
        Assert.Equal(expected.ToArray(),data.ReadBytes(offset,size));
    }
    
    [Theory]
    [InlineData(0xFB_FA_F9_F8,0,4)]
    [InlineData(0xFB_FA_F9_F8,1,3)]
    [InlineData(0xFB_FA_F9_F8,2,2)]
    [InlineData(0xFB_FA_F9_F8,0,3)]
    public void ReadBytes_On_ByteIndexerInt32_Returns_Expected_Array(uint baseData, int offset, int size)
    {
        ByteIndexerInt32 data = (int)baseData;
        var expected = new List<byte>();
        for (var i = 0; i < size; i++)
        {
            expected.Add(data[i+offset]);
        }
        Assert.Equal(expected.ToArray(),data.ReadBytes(offset,size));
    }

    [Theory]
    [InlineData(0xF9_F8,0,2)]
    [InlineData(0xFB_FA,1,1)]
    public void ReadBytes_On_ByteIndexerUInt16_Returns_Expected_Array(ushort baseData, int offset, int size)
    {
        ByteIndexerUInt16 data = baseData;
        var expected = new List<byte>();
        for (var i = 0; i < size; i++)
        {
            expected.Add(data[i+offset]);
        }
        Assert.Equal(expected.ToArray(),data.ReadBytes(offset,size));
    }
    
    [Theory]
    [InlineData(0xF9_F8,0,2)]
    [InlineData(0xFB_FA,1,1)]
    public void ReadBytes_On_ByteIndexerInt16_Returns_Expected_Array(ushort baseData, int offset, int size)
    {
        ByteIndexerInt16 data = (short)baseData;
        var expected = new List<byte>();
        for (var i = 0; i < size; i++)
        {
            expected.Add(data[i+offset]);
        }
        Assert.Equal(expected.ToArray(),data.ReadBytes(offset,size));
    }

    [Theory]
    [InlineData(0xF8,0,1)]
    [InlineData(0xFB,0,1)]
    public void ReadBytes_On_ByteIndexerByte_Returns_Expected_Array(byte baseData, int offset, int size)
    {
        ByteIndexerByte data = baseData;
        var expected = new List<byte>();
        for (var i = 0; i < size; i++)
        {
            expected.Add(data[i+offset]);
        }
        Assert.Equal(expected.ToArray(),data.ReadBytes(offset,size));
    }
    
    [Theory]
    [InlineData(0xF8,0,1)]
    [InlineData(0xFB,0,1)]
    public void ReadBytes_On_ByteIndexerSByte_Returns_Expected_Array(byte baseData, int offset, int size)
    {
        ByteIndexerSByte data = (sbyte)baseData;
        var expected = new List<byte>();
        for (var i = 0; i < size; i++)
        {
            expected.Add(data[i+offset]);
        }
        Assert.Equal(expected.ToArray(),data.ReadBytes(offset,size));
    }
    
    #endregion
}
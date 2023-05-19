using System;
using System.Linq;
using Xunit;

namespace Jcd.BitManipulation.Tests;

public class ByteArrayExtensionTests
{
    #region ToByteArray Tests

    [Theory]
    [InlineData(0x00, 0x00)]
    [InlineData(0x01, 0x01)]
    [InlineData(0x7F, 0x7F)]
    public void ToByteArray_On_Byte_Returns_Expected_Value(byte data, byte e0)
    {
        var expected = new[] { e0 };
        Assert.Equal(expected, data.ToByteArray());
    }

    [Theory]
    [InlineData(0x00, 0x00)]
    [InlineData(0x01, 0x01)]
    [InlineData(0x7F, 0x7F)]
    public void ToByteArray_On_SByte_Returns_Expected_Value(sbyte data, byte e0)
    {
        var expected = new[] { e0 };
        Assert.Equal(expected, data.ToByteArray());
    }

    [Theory]
    [InlineData(0x0201, Endian.Little, 0x01, 0x02)]
    [InlineData(0x0201, Endian.Big, 0x02, 0x01)]
    public void ToByteArray_On_UInt16_Returns_Expected_Value(ushort data, Endian endian, byte e0, byte e1)
    {
        var expected = new[] { e0, e1 };
        Assert.Equal(expected, data.ToByteArray(endian));
    }

    [Theory]
    [InlineData(0x0201, Endian.Little, 0x01, 0x02)]
    [InlineData(0x0201, Endian.Big, 0x02, 0x01)]
    public void ToByteArray_On_Int16_Returns_Expected_Value(short data, Endian endian, byte e0, byte e1)
    {
        var expected = new[] { e0, e1 };
        Assert.Equal(expected, data.ToByteArray(endian));
    }

    [Theory]
    [InlineData(0x04030201, Endian.Little, 0x01, 0x02, 0x03, 0x04)]
    [InlineData(0x04030201, Endian.Big, 0x04, 0x03, 0x02, 0x01)]
    public void ToByteArray_On_UInt32_Returns_Expected_Value(uint data, Endian endian, byte e0, byte e1, byte e2,
                                                             byte e3)
    {
        var expected = new[] { e0, e1, e2, e3 };
        Assert.Equal(expected, data.ToByteArray(endian));
    }

    [Theory]
    [InlineData(0x04030201, Endian.Little, 0x01, 0x02, 0x03, 0x04)]
    [InlineData(0x04030201, Endian.Big, 0x04, 0x03, 0x02, 0x01)]
    public void ToByteArray_On_Int32_Returns_Expected_Value(int data, Endian endian, byte e0, byte e1, byte e2, byte e3)
    {
        var expected = new[] { e0, e1, e2, e3 };
        Assert.Equal(expected, data.ToByteArray(endian));
    }

    [Theory]
    [InlineData(0x0807060504030201, Endian.Little, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08)]
    [InlineData(0x0807060504030201, Endian.Big, 0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01)]
    public void ToByteArray_On_UInt64_Returns_Expected_Value(ulong data, Endian endian, byte e0, byte e1, byte e2,
                                                             byte e3, byte e4, byte e5, byte e6, byte e7)
    {
        var expected = new[] { e0, e1, e2, e3, e4, e5, e6, e7 };
        Assert.Equal(expected, data.ToByteArray(endian));
    }

    [Theory]
    [InlineData(0x0807060504030201, Endian.Little, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08)]
    [InlineData(0x0807060504030201, Endian.Big, 0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01)]
    public void ToByteArray_On_Int64_Returns_Expected_Value(long data, Endian endian, byte e0, byte e1, byte e2,
                                                            byte e3, byte e4, byte e5, byte e6, byte e7)
    {
        var expected = new[] { e0, e1, e2, e3, e4, e5, e6, e7 };
        Assert.Equal(expected, data.ToByteArray(endian));
    }

    #endregion

    #region To[Integer Data Type] Tests on Array of bytes

    [Theory]
    [InlineData(0x01, 0x01)]
    [InlineData(0x02, 0x02)]
    [InlineData(0x03, 0x03)]
    public void ToByte_On_Array(byte d0, byte expected)
    {
        Assert.Equal(expected, new[] { d0 }.ToByte());
    }

    [Theory]
    [InlineData(0x01, 0x01)]
    [InlineData(0x02, 0x02)]
    [InlineData(0x03, 0x03)]
    public void ToSByte_On_Array(byte d0, sbyte expected)
    {
        Assert.Equal(expected, new[] { d0 }.ToSByte());
    }

    [Theory]
    [InlineData(0x01, 0x02, 2, Endian.Little, 0x0201)]
    [InlineData(0x02, 0x01, 2, Endian.Big, 0x0201)]
    [InlineData(0x01, 0x02, 1, Endian.Little, 0x01)]
    [InlineData(0x02, 0x01, 1, Endian.Big, 0x02)]
    public void ToUInt16_On_Array(byte d0, byte d1, int size, Endian endian, ushort expected)
    {
        Assert.Equal(expected, new[] { d0, d1 }.Take(size).ToArray().ToUInt16(endian));
    }

    [Theory]
    [InlineData(0x01, 0x02, 2, Endian.Little, 0x0201)]
    [InlineData(0x02, 0x01, 2, Endian.Big, 0x0201)]
    [InlineData(0x01, 0x02, 1, Endian.Little, 0x01)]
    [InlineData(0x02, 0x01, 1, Endian.Big, 0x02)]
    public void ToInt16_On_Array(byte d0, byte d1, int size, Endian endian, short expected)
    {
        Assert.Equal(expected, new[] { d0, d1 }.Take(size).ToArray().ToInt16(endian));
    }

    [Theory]
    [InlineData(0x01, 0x02, 0x03, 0x04, 4, Endian.Little, 0x04030201)]
    [InlineData(0x04, 0x03, 0x02, 0x01, 4, Endian.Big, 0x04030201)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 3, Endian.Little, 0x030201)]
    [InlineData(0x04, 0x03, 0x02, 0x01, 3, Endian.Big, 0x040302)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 2, Endian.Little, 0x0201)]
    [InlineData(0x04, 0x03, 0x02, 0x01, 2, Endian.Big, 0x0403)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 1, Endian.Little, 0x01)]
    [InlineData(0x04, 0x03, 0x02, 0x01, 1, Endian.Big, 0x04)]
    public void ToUInt32_On_Array(byte d0, byte d1, byte d2, byte d3, int size, Endian endian, uint expected)
    {
        Assert.Equal(expected, new[] { d0, d1, d2, d3 }.Take(size).ToArray().ToUInt32(endian));
    }

    [Theory]
    [InlineData(0x01, 0x02, 0x03, 0x04, 4, Endian.Little, 0x04030201)]
    [InlineData(0x04, 0x03, 0x02, 0x01, 4, Endian.Big, 0x04030201)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 3, Endian.Little, 0x030201)]
    [InlineData(0x04, 0x03, 0x02, 0x01, 3, Endian.Big, 0x040302)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 2, Endian.Little, 0x0201)]
    [InlineData(0x04, 0x03, 0x02, 0x01, 2, Endian.Big, 0x0403)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 1, Endian.Little, 0x01)]
    [InlineData(0x04, 0x03, 0x02, 0x01, 1, Endian.Big, 0x04)]
    public void ToInt32_On_Array(byte d0, byte d1, byte d2, byte d3, int size, Endian endian, int expected)
    {
        Assert.Equal(expected, new[] { d0, d1, d2, d3 }.Take(size).ToArray().ToInt32(endian));
    }

    [Theory]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 8, Endian.Little, 0x0807060504030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 8, Endian.Big, 0x0807060504030201)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 7, Endian.Little, 0x07060504030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 7, Endian.Big, 0x08070605040302)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 6, Endian.Little, 0x060504030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 6, Endian.Big, 0x080706050403)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 5, Endian.Little, 0x0504030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 5, Endian.Big, 0x0807060504)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 4, Endian.Little, 0x04030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 4, Endian.Big, 0x08070605)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 3, Endian.Little, 0x030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 3, Endian.Big, 0x080706)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 2, Endian.Little, 0x0201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 2, Endian.Big, 0x0807)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 1, Endian.Little, 0x01)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 1, Endian.Big, 0x08)]
    public void ToUInt64_On_Array(byte d0, byte d1, byte d2, byte d3, byte d4, byte d5, byte d6, byte d7, int size,
                                  Endian endian, ulong expected)
    {
        Assert.Equal(expected, new[] { d0, d1, d2, d3, d4, d5, d6, d7 }.Take(size).ToArray().ToUInt64(endian));
    }

    [Theory]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 8, Endian.Little, 0x0807060504030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 8, Endian.Big, 0x0807060504030201)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 7, Endian.Little, 0x07060504030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 7, Endian.Big, 0x08070605040302)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 6, Endian.Little, 0x060504030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 6, Endian.Big, 0x080706050403)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 5, Endian.Little, 0x0504030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 5, Endian.Big, 0x0807060504)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 4, Endian.Little, 0x04030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 4, Endian.Big, 0x08070605)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 3, Endian.Little, 0x030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 3, Endian.Big, 0x080706)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 2, Endian.Little, 0x0201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 2, Endian.Big, 0x0807)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 1, Endian.Little, 0x01)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 1, Endian.Big, 0x08)]
    public void ToInt64_On_Array(byte d0, byte d1, byte d2, byte d3, byte d4, byte d5, byte d6, byte d7, int size,
                                 Endian endian, long expected)
    {
        Assert.Equal(expected, new[] { d0, d1, d2, d3, d4, d5, d6, d7 }.Take(size).ToArray().ToInt64(endian));
    }

    #endregion

    #region To[Integer Data Type] Tests on Array of bytes

    [Theory]
    [InlineData(0x01, 0x01)]
    [InlineData(0x02, 0x02)]
    [InlineData(0x03, 0x03)]
    public void ToByte_On_ReadOnlySpan(byte d0, byte expected)
    {
        Assert.Equal(expected, new ReadOnlySpan<byte>(new[] { d0 }).ToByte());
    }

    [Theory]
    [InlineData(0x01, 0x01)]
    [InlineData(0x02, 0x02)]
    [InlineData(0x03, 0x03)]
    public void ToSByte_On_ReadOnlySpan(byte d0, sbyte expected)
    {
        Assert.Equal(expected, new ReadOnlySpan<byte>(new[] { d0 }).ToSByte());
    }

    [Theory]
    [InlineData(0x01, 0x02, 2, Endian.Little, 0x0201)]
    [InlineData(0x02, 0x01, 2, Endian.Big, 0x0201)]
    [InlineData(0x01, 0x02, 1, Endian.Little, 0x01)]
    [InlineData(0x02, 0x01, 1, Endian.Big, 0x02)]
    public void ToUInt16_On_ReadOnlySpan(byte d0, byte d1, int size, Endian endian, ushort expected)
    {
        Assert.Equal(expected, new ReadOnlySpan<byte>(new[] { d0, d1 }.Take(size).ToArray()).ToUInt16(endian));
    }

    [Theory]
    [InlineData(0x01, 0x02, 2, Endian.Little, 0x0201)]
    [InlineData(0x02, 0x01, 2, Endian.Big, 0x0201)]
    [InlineData(0x01, 0x02, 1, Endian.Little, 0x01)]
    [InlineData(0x02, 0x01, 1, Endian.Big, 0x02)]
    public void ToInt16_On_ReadOnlySpan(byte d0, byte d1, int size, Endian endian, short expected)
    {
        Assert.Equal(expected, new ReadOnlySpan<byte>(new[] { d0, d1 }.Take(size).ToArray()).ToInt16(endian));
    }

    [Theory]
    [InlineData(0x01, 0x02, 0x03, 0x04, 4, Endian.Little, 0x04030201)]
    [InlineData(0x04, 0x03, 0x02, 0x01, 4, Endian.Big, 0x04030201)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 3, Endian.Little, 0x030201)]
    [InlineData(0x04, 0x03, 0x02, 0x01, 3, Endian.Big, 0x040302)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 2, Endian.Little, 0x0201)]
    [InlineData(0x04, 0x03, 0x02, 0x01, 2, Endian.Big, 0x0403)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 1, Endian.Little, 0x01)]
    [InlineData(0x04, 0x03, 0x02, 0x01, 1, Endian.Big, 0x04)]
    public void ToUInt32_On_ReadOnlySpan(byte d0, byte d1, byte d2, byte d3, int size, Endian endian, uint expected)
    {
        Assert.Equal(expected, new ReadOnlySpan<byte>(new[] { d0, d1, d2, d3 }.Take(size).ToArray()).ToUInt32(endian));
    }

    [Theory]
    [InlineData(0x01, 0x02, 0x03, 0x04, 4, Endian.Little, 0x04030201)]
    [InlineData(0x04, 0x03, 0x02, 0x01, 4, Endian.Big, 0x04030201)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 3, Endian.Little, 0x030201)]
    [InlineData(0x04, 0x03, 0x02, 0x01, 3, Endian.Big, 0x040302)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 2, Endian.Little, 0x0201)]
    [InlineData(0x04, 0x03, 0x02, 0x01, 2, Endian.Big, 0x0403)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 1, Endian.Little, 0x01)]
    [InlineData(0x04, 0x03, 0x02, 0x01, 1, Endian.Big, 0x04)]
    public void ToInt32_On_ReadOnlySpan(byte d0, byte d1, byte d2, byte d3, int size, Endian endian, int expected)
    {
        Assert.Equal(expected, new ReadOnlySpan<byte>(new[] { d0, d1, d2, d3 }.Take(size).ToArray()).ToInt32(endian));
    }

    [Theory]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 8, Endian.Little, 0x0807060504030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 8, Endian.Big, 0x0807060504030201)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 7, Endian.Little, 0x07060504030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 7, Endian.Big, 0x08070605040302)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 6, Endian.Little, 0x060504030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 6, Endian.Big, 0x080706050403)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 5, Endian.Little, 0x0504030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 5, Endian.Big, 0x0807060504)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 4, Endian.Little, 0x04030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 4, Endian.Big, 0x08070605)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 3, Endian.Little, 0x030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 3, Endian.Big, 0x080706)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 2, Endian.Little, 0x0201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 2, Endian.Big, 0x0807)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 1, Endian.Little, 0x01)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 1, Endian.Big, 0x08)]
    public void ToUInt64_On_ReadOnlySpan(byte d0, byte d1, byte d2, byte d3, byte d4, byte d5, byte d6, byte d7, int size,
                                  Endian endian, ulong expected)
    {
        Assert.Equal(expected, new ReadOnlySpan<byte>(new[] { d0, d1, d2, d3, d4, d5, d6, d7 }.Take(size).ToArray()).ToUInt64(endian));
    }

    [Theory]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 8, Endian.Little, 0x0807060504030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 8, Endian.Big, 0x0807060504030201)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 7, Endian.Little, 0x07060504030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 7, Endian.Big, 0x08070605040302)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 6, Endian.Little, 0x060504030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 6, Endian.Big, 0x080706050403)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 5, Endian.Little, 0x0504030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 5, Endian.Big, 0x0807060504)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 4, Endian.Little, 0x04030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 4, Endian.Big, 0x08070605)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 3, Endian.Little, 0x030201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 3, Endian.Big, 0x080706)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 2, Endian.Little, 0x0201)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 2, Endian.Big, 0x0807)]
    [InlineData(0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 1, Endian.Little, 0x01)]
    [InlineData(0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 1, Endian.Big, 0x08)]
    public void ToInt64_On_ReadOnlySpan(byte d0, byte d1, byte d2, byte d3, byte d4, byte d5, byte d6, byte d7, int size,
                                 Endian endian, long expected)
    {
        Assert.Equal(expected, new ReadOnlySpan<byte>(new[] { d0, d1, d2, d3, d4, d5, d6, d7 }.Take(size).ToArray()).ToInt64(endian));
    }

    #endregion
    
    [Fact]
    public void ToAnyInt_On_Empty_Array_Returns_Zero()
    {
        var empty = Array.Empty<byte>();
        Assert.Equal(0, empty.ToByte());
        Assert.Equal(0, empty.ToSByte());
        Assert.Equal(0, empty.ToInt16());
        Assert.Equal(0, empty.ToUInt16());
        Assert.Equal(0, empty.ToInt32());
        Assert.Equal((uint)0, empty.ToUInt32());
        Assert.Equal(0, empty.ToInt64());
        Assert.Equal((ulong)0, empty.ToUInt64());
    }

    [Fact]
    public void ToAnyInt_On_Empty_ReadOnlySpan_Returns_Zero()
    {
        var empty = new ReadOnlySpan<byte>(Array.Empty<byte>());
        Assert.Equal(0, empty.ToByte());
        Assert.Equal(0, empty.ToSByte());
        Assert.Equal(0, empty.ToInt16());
        Assert.Equal(0, empty.ToUInt16());
        Assert.Equal(0, empty.ToInt32());
        Assert.Equal((uint)0, empty.ToUInt32());
        Assert.Equal(0, empty.ToInt64());
        Assert.Equal((ulong)0, empty.ToUInt64());
    }
}
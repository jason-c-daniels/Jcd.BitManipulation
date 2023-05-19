using System.Collections.Generic;
using Jcd.BitManipulation.ByteIndexers;
using Xunit;
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable ArrangeTrailingCommaInMultilineLists

namespace Jcd.BitManipulation.Tests;

public class StoreBytesExtensionsTests
{
    #region StoreByte Tests

    [Theory]
    [InlineData(0, (byte)0x01, 0, 0x00_00_00_00_00_00_00_01)]
    [InlineData(0, (byte)0x02, 1, 0x00_00_00_00_00_00_02_00)]
    [InlineData(0, (byte)0xFF, 2, 0x00_00_00_00_00_FF_00_00)]
    [InlineData(0, (byte)0xFE, 3, 0x00_00_00_00_FE_00_00_00)]
    [InlineData(0, (byte)0xFD, 4, 0x00_00_00_FD_00_00_00_00)]
    [InlineData(0, (byte)0xFC, 5, 0x00_00_FC_00_00_00_00_00)]
    [InlineData(0, (byte)0xFB, 6, 0x00_FB_00_00_00_00_00_00)]
    [InlineData(0, (byte)0xFA, 7, 0xFA_00_00_00_00_00_00_00)]
    public void StoreByte_On_UInt64_Returns_Expected_Value(ulong value, byte data, int offset, ulong expected)
    {
        Assert.Equal(expected, value.StoreByte(data, offset));
    }

    [Theory]
    [InlineData((long)0, (byte)0x01, 0, (long)0x00_00_00_00_00_00_00_01)]
    [InlineData((long)0, (byte)0x02, 1, (long)0x00_00_00_00_00_00_02_00)]
    [InlineData((long)0, (byte)0xFF, 2, (long)0x00_00_00_00_00_FF_00_00)]
    [InlineData((long)0, (byte)0xFE, 3, (long)0x00_00_00_00_FE_00_00_00)]
    [InlineData((long)0, (byte)0xFD, 4, 0x00_00_00_FD_00_00_00_00)]
    [InlineData((long)0, (byte)0xFC, 5, 0x00_00_FC_00_00_00_00_00)]
    [InlineData((long)0, (byte)0xFB, 6, 0x00_FB_00_00_00_00_00_00)]
    [InlineData((long)0, (byte)0x0A, 7, 0x0A_00_00_00_00_00_00_00)]
    public void StoreByte_On_Int64_Returns_Expected_Value(long value, byte data, int offset, long expected)
    {
        Assert.Equal(expected, value.StoreByte(data, offset));
    }

    [Theory]
    [InlineData(0, (byte)0x01, 0, 0x00_00_00_01)]
    [InlineData(0, (byte)0x02, 1, 0x00_00_02_00)]
    [InlineData(0, (byte)0xFF, 2, 0x00_FF_00_00)]
    [InlineData(0, (byte)0xFE, 3, 0xFE_00_00_00)]
    public void StoreByte_On_UInt32_Returns_Expected_Value(uint value, byte data, int offset, uint expected)
    {
        Assert.Equal(expected, value.StoreByte(data, offset));
    }

    [Theory]
    [InlineData(0, (byte)0x01, 0, 0x00_00_00_01)]
    [InlineData(0, (byte)0x02, 1, 0x00_00_02_00)]
    [InlineData(0, (byte)0xFF, 2, 0x00_FF_00_00)]
    [InlineData(0, (byte)0x0E, 3, 0x0E_00_00_00)]
    public void StoreByte_On_Int32_Returns_Expected_Value(int value, byte data, int offset, int expected)
    {
        Assert.Equal(expected, value.StoreByte(data, offset));
    }

    [Theory]
    [InlineData(0, (byte)0x01, 0, 0x00_01)]
    [InlineData(0, (byte)0x02, 1, 0x02_00)]
    public void StoreByte_On_UInt16_Returns_Expected_Value(ushort value, byte data, int offset, ushort expected)
    {
        Assert.Equal(expected, value.StoreByte(data, offset));
    }

    [Theory]
    [InlineData((short)0, (byte)0x01, 0, (short)0x00_01)]
    [InlineData((short)0, (byte)0x02, 1, (short)0x02_00)]
    public void StoreByte_On_Int16_Returns_Expected_Value(short value, byte data, int offset, short expected)
    {
        Assert.Equal(expected, value.StoreByte(data, offset));
    }

    [Theory]
    [InlineData(0, (byte)0x01, 0, (byte)0x01)]
    public void StoreByte_On_Byte_Returns_Expected_Value(byte value, byte data, int offset, byte expected)
    {
        Assert.Equal(expected, value.StoreByte(data, offset));
    }

    [Theory]
    [InlineData((sbyte)0, (byte)0x02, 0, (sbyte)0x02)]
    public void StoreByte_On_SByte_Returns_Expected_Value(sbyte value, byte data, int offset, sbyte expected)
    {
        Assert.Equal(expected, value.StoreByte(data, offset));
    }

    [Theory]
    [InlineData(0, (byte)0x01, 0, 0x00_00_00_00_00_00_00_01)]
    [InlineData(0, (byte)0x02, 1, 0x00_00_00_00_00_00_02_00)]
    [InlineData(0, (byte)0xFF, 2, 0x00_00_00_00_00_FF_00_00)]
    [InlineData(0, (byte)0xFE, 3, 0x00_00_00_00_FE_00_00_00)]
    [InlineData(0, (byte)0xFD, 4, 0x00_00_00_FD_00_00_00_00)]
    [InlineData(0, (byte)0xFC, 5, 0x00_00_FC_00_00_00_00_00)]
    [InlineData(0, (byte)0xFB, 6, 0x00_FB_00_00_00_00_00_00)]
    [InlineData(0, (byte)0xFA, 7, 0xFA_00_00_00_00_00_00_00)]
    public void StoreByte_On_ByteIndexerUInt64_Returns_Expected_Value(ulong rawValue, byte data, int offset,
                                                                      ulong rawExpected)
    {
        ByteIndexerUInt64 expected = rawExpected;
        ByteIndexerUInt64 value = rawValue;
        Assert.Equal(expected, value.StoreByte(data, offset));
    }

    [Theory]
    [InlineData((long)0, (byte)0x01, 0, (long)0x00_00_00_00_00_00_00_01)]
    [InlineData((long)0, (byte)0x02, 1, (long)0x00_00_00_00_00_00_02_00)]
    [InlineData((long)0, (byte)0xFF, 2, (long)0x00_00_00_00_00_FF_00_00)]
    [InlineData((long)0, (byte)0xFE, 3, (long)0x00_00_00_00_FE_00_00_00)]
    [InlineData((long)0, (byte)0xFD, 4, 0x00_00_00_FD_00_00_00_00)]
    [InlineData((long)0, (byte)0xFC, 5, 0x00_00_FC_00_00_00_00_00)]
    [InlineData((long)0, (byte)0xFB, 6, 0x00_FB_00_00_00_00_00_00)]
    [InlineData((long)0, (byte)0x0A, 7, 0x0A_00_00_00_00_00_00_00)]
    public void StoreByte_On_ByteIndexerInt64_Returns_Expected_Value(long rawValue, byte data, int offset,
                                                                     long rawExpected)
    {
        ByteIndexerInt64 expected = rawExpected;
        ByteIndexerInt64 value = rawValue;
        Assert.Equal(expected, value.StoreByte(data, offset));
    }

    [Theory]
    [InlineData(0, (byte)0x01, 0, 0x00_00_00_01)]
    [InlineData(0, (byte)0x02, 1, 0x00_00_02_00)]
    [InlineData(0, (byte)0xFF, 2, 0x00_FF_00_00)]
    [InlineData(0, (byte)0xFE, 3, 0xFE_00_00_00)]
    public void StoreByte_On_ByteIndexerUInt32_Returns_Expected_Value(uint rawValue, byte data, int offset,
                                                                      uint rawExpected)
    {
        ByteIndexerUInt32 expected = rawExpected;
        ByteIndexerUInt32 value = rawValue;
        Assert.Equal(expected, value.StoreByte(data, offset));
    }

    [Theory]
    [InlineData(0, (byte)0x01, 0, 0x00_00_00_01)]
    [InlineData(0, (byte)0x02, 1, 0x00_00_02_00)]
    [InlineData(0, (byte)0xFF, 2, 0x00_FF_00_00)]
    [InlineData(0, (byte)0x0E, 3, 0x0E_00_00_00)]
    public void StoreByte_On_ByteIndexerInt32_Returns_Expected_Value(int rawValue, byte data, int offset,
                                                                     int rawExpected)
    {
        ByteIndexerInt32 expected = rawExpected;
        ByteIndexerInt32 value = rawValue;
        Assert.Equal(expected, value.StoreByte(data, offset));
    }

    [Theory]
    [InlineData(0, (byte)0x01, 0, 0x00_01)]
    [InlineData(0, (byte)0x02, 1, 0x02_00)]
    public void StoreByte_On_ByteIndexerUInt16_Returns_Expected_Value(ushort rawValue, byte data, int offset,
                                                                      ushort rawExpected)
    {
        ByteIndexerUInt16 expected = rawExpected;
        ByteIndexerUInt16 value = rawValue;
        Assert.Equal(expected, value.StoreByte(data, offset));
    }

    [Theory]
    [InlineData((short)0, (byte)0x01, 0, (short)0x00_01)]
    [InlineData((short)0, (byte)0x02, 1, (short)0x02_00)]
    public void StoreByte_On_ByteIndexerInt16_Returns_Expected_Value(short rawValue, byte data, int offset,
                                                                     short rawExpected)
    {
        ByteIndexerInt16 expected = rawExpected;
        ByteIndexerInt16 value = rawValue;
        Assert.Equal(expected, value.StoreByte(data, offset));
    }

    [Theory]
    [InlineData(0, (byte)0x01, 0, (byte)0x01)]
    public void StoreByte_On_ByteIndexerByte_Returns_Expected_Value(byte rawValue, byte data, int offset,
                                                                    byte rawExpected)
    {
        ByteIndexerByte expected = rawExpected;
        ByteIndexerByte value = rawValue;
        Assert.Equal(expected, value.StoreByte(data, offset));
    }

    [Theory]
    [InlineData((sbyte)0, (byte)0x02, 0, (sbyte)0x02)]
    public void StoreByte_On_ByteIndexerSByte_Returns_Expected_Value(sbyte rawValue, byte data, int offset,
                                                                     sbyte rawExpected)
    {
        ByteIndexerSByte expected = rawExpected;
        ByteIndexerSByte value = rawValue;
        Assert.Equal(expected, value.StoreByte(data, offset));
    }

    #endregion

    #region StoreBytes - Integral Data Type Tests

    [Theory]
    [MemberData(nameof(UInt64StoreBytes))]
    public void StoreBytes_On_UInt64_Returns_Expected_Value(ulong data, int offset, int size, byte[] bytes)
    {
        var expected = data;
        for (var i = 0; i < size && i + offset < sizeof(ulong); i++)
            expected = expected.StoreByte(bytes[i], offset + i);
        var actual = data.StoreBytes(bytes, offset, size);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Int64StoreBytes))]
    public void StoreBytes_On_Int64_Returns_Expected_Value(long data, int offset, int size, byte[] bytes)
    {
        var expected = data;
        for (var i = 0; i < size && i + offset < sizeof(long); i++)
            expected = expected.StoreByte(bytes[i], offset + i);
        var actual = data.StoreBytes(bytes, offset, size);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(UInt32StoreBytes))]
    public void StoreBytes_On_UInt32_Returns_Expected_Value(uint data, int offset, int size, byte[] bytes)
    {
        var expected = data;
        for (var i = 0; i < size && i + offset < sizeof(uint); i++)
            expected = expected.StoreByte(bytes[i], offset + i);
        var actual = data.StoreBytes(bytes, offset, size);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Int32StoreBytes))]
    public void StoreBytes_On_Int32_Returns_Expected_Value(int data, int offset, int size, byte[] bytes)
    {
        var expected = data;
        for (var i = 0; i < size && i + offset < sizeof(int); i++)
            expected = expected.StoreByte(bytes[i], offset + i);
        var actual = data.StoreBytes(bytes, offset, size);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(UInt16StoreBytes))]
    public void StoreBytes_On_UInt16_Returns_Expected_Value(ushort data, int offset, int size, byte[] bytes)
    {
        var expected = data;
        for (var i = 0; i < size && i + offset < sizeof(ushort); i++)
            expected = expected.StoreByte(bytes[i], offset + i);
        var actual = data.StoreBytes(bytes, offset, size);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Int16StoreBytes))]
    public void StoreBytes_On_Int16_Returns_Expected_Value(short data, int offset, int size, byte[] bytes)
    {
        var expected = data;
        for (var i = 0; i < size && i + offset < sizeof(short); i++)
            expected = expected.StoreByte(bytes[i], offset + i);
        var actual = data.StoreBytes(bytes, offset, size);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(ByteStoreBytes))]
    public void StoreBytes_On_Byte_Returns_Expected_Value(byte data, int offset, int size, byte[] bytes)
    {
        var expected = data;
        for (var i = 0; i < size && i + offset < sizeof(byte); i++)
            expected = expected.StoreByte(bytes[i], offset + i);
        var actual = data.StoreBytes(bytes, offset, size);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(SByteStoreBytes))]
    public void StoreBytes_On_SByte_Returns_Expected_Value(sbyte data, int offset, int size, byte[] bytes)
    {
        var expected = data;
        for (var i = 0; i < size && i + offset < sizeof(sbyte); i++)
            expected = expected.StoreByte(bytes[i], offset + i);
        var actual = data.StoreBytes(bytes, offset, size);
        Assert.Equal(expected, actual);
    }

    #endregion

    #region StoreBytes - ByteIndexer Tests

    [Theory]
    [MemberData(nameof(UInt64StoreBytes))]
    public void StoreBytes_On_ByteIndexerUInt64_Returns_Expected_Value(ulong rawData, int offset, int size,
                                                                       byte[] bytes)
    {
        var rawExpected = rawData;
        ByteIndexerUInt64 data = rawData;
        for (var i = 0; i < size && i + offset < sizeof(ulong); i++)
            rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
        ByteIndexerUInt64 expected = rawExpected;
        var actual = data.StoreBytes(bytes, offset, size);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Int64StoreBytes))]
    public void StoreBytes_On_ByteIndexerInt64_Returns_Expected_Value(long rawData, int offset, int size, byte[] bytes)
    {
        var rawExpected = rawData;
        ByteIndexerInt64 data = rawData;
        for (var i = 0; i < size && i + offset < sizeof(long); i++)
            rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
        ByteIndexerInt64 expected = rawExpected;
        var actual = data.StoreBytes(bytes, offset, size);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(UInt32StoreBytes))]
    public void StoreBytes_On_ByteIndexerUInt32_Returns_Expected_Value(uint rawData, int offset, int size, byte[] bytes)
    {
        var rawExpected = rawData;
        ByteIndexerUInt32 data = rawData;
        for (var i = 0; i < size && i + offset < sizeof(uint); i++)
            rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
        ByteIndexerUInt32 expected = rawExpected;
        var actual = data.StoreBytes(bytes, offset, size);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Int32StoreBytes))]
    public void StoreBytes_On_ByteIndexerInt32_Returns_Expected_Value(int rawData, int offset, int size, byte[] bytes)
    {
        var rawExpected = rawData;
        ByteIndexerInt32 data = rawData;
        for (var i = 0; i < size && i + offset < sizeof(int); i++)
            rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
        ByteIndexerInt32 expected = rawExpected;
        var actual = data.StoreBytes(bytes, offset, size);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(UInt16StoreBytes))]
    public void StoreBytes_On_ByteIndexerUInt16_Returns_Expected_Value(ushort rawData, int offset, int size,
                                                                       byte[] bytes)
    {
        var rawExpected = rawData;
        ByteIndexerUInt16 data = rawData;
        for (var i = 0; i < size && i + offset < sizeof(ushort); i++)
            rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
        ByteIndexerUInt16 expected = rawExpected;
        var actual = data.StoreBytes(bytes, offset, size);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Int16StoreBytes))]
    public void StoreBytes_On_ByteIndexerInt16_Returns_Expected_Value(short rawData, int offset, int size, byte[] bytes)
    {
        var rawExpected = rawData;
        ByteIndexerInt16 data = rawData;
        for (var i = 0; i < size && i + offset < sizeof(short); i++)
            rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
        ByteIndexerInt16 expected = rawExpected;
        var actual = data.StoreBytes(bytes, offset, size);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(ByteStoreBytes))]
    public void StoreBytes_On_ByteIndexerByte_Returns_Expected_Value(byte rawData, int offset, int size, byte[] bytes)
    {
        var rawExpected = rawData;
        ByteIndexerByte data = rawData;
        for (var i = 0; i < size && i + offset < sizeof(byte); i++)
            rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
        ByteIndexerByte expected = rawExpected;
        var actual = data.StoreBytes(bytes, offset, size);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(SByteStoreBytes))]
    public void StoreBytes_On_ByteIndexerSByte_Returns_Expected_Value(sbyte rawData, int offset, int size, byte[] bytes)
    {
        var rawExpected = rawData;
        ByteIndexerSByte data = rawData;
        for (var i = 0; i < size && i + offset < sizeof(sbyte); i++)
            rawExpected = rawExpected.StoreByte(bytes[i], offset + i);
        ByteIndexerSByte expected = rawExpected;
        var actual = data.StoreBytes(bytes, offset);
        Assert.Equal(expected, actual);
    }

    #endregion

    #region DataMember Data Providers

    public static IEnumerable<object[]> UInt64StoreBytes =>
        new List<object[]>
        {
            new object[] { 0xFF_00_00_00_00_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE } },
            new object[] { 0xFE_00_00_00_00_00_00_00, 1, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
            new object[] { 0xFE_00_00_00_00_00_20_00, 3, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
            new object[] { 0xFE_00_00_00_00_00_00_01, 4, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } },
            new object[] { 0xFE_00_00_00_00_00_00_01, 5, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } },
            new object[] { 0xFE_00_00_00_00_00_00_01, 8, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } },
            new object[] { 0xFE_00_00_00_00_00_00_01, 8, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } },
        };

    public static IEnumerable<object[]> Int64StoreBytes =>
        new List<object[]>
        {
            new object[] { 0x0F_00_00_00_00_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE } },
            new object[] { 0x0E_00_00_00_00_00_00_00, 1, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
            new object[] { 0x0E_00_00_00_00_00_20_00, 3, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
            new object[] { 0x0E_00_00_00_00_00_00_01, 4, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } },
            new object[] { 0x0E_00_00_00_00_00_00_01, 5, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } },
            new object[] { 0x0E_00_00_00_00_00_00_01, 8, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } },
            new object[] { 0x0E_00_00_00_00_00_00_01, 8, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } },
        };

    public static IEnumerable<object[]> UInt32StoreBytes =>
        new List<object[]>
        {
            new object[] { 0xFF_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE } },
            new object[] { 0xFE_00_00_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
            new object[] { 0xFE_00_00_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
            new object[] { 0xFE_00_00_00, 3, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } },
            new object[] { 0xFE_00_00_00, 4, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } },
            new object[] { 0xFE_00_00_00, 4, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } },
        };

    public static IEnumerable<object[]> Int32StoreBytes =>
        new List<object[]>
        {
            new object[] { 0x0F_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE } },
            new object[] { 0x0E_00_00_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
            new object[] { 0x0E_00_00_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
            new object[] { 0x0E_00_00_00, 3, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } },
            new object[] { 0x0E_00_00_00, 4, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } },
            new object[] { 0x0E_00_00_00, 4, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } },
        };

    public static IEnumerable<object[]> UInt16StoreBytes =>
        new List<object[]>
        {
            new object[] { (ushort)0xFF_00, 0, 2, new byte[] { 0xFF, 0xFE } },
            new object[] { (ushort)0xFE_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
            new object[] { (ushort)0xFE_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
            new object[] { (ushort)0xFE_00, 2, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
        };

    public static IEnumerable<object[]> Int16StoreBytes =>
        new List<object[]>
        {
            new object[] { (short)0x0F_00, 0, 2, new byte[] { 0xFF, 0xFE } },
            new object[] { (short)0x0E_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
            new object[] { (short)0x0E_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
            new object[] { (short)0x0E_00, 2, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
        };

    public static IEnumerable<object[]> ByteStoreBytes =>
        new List<object[]>
        {
            new object[] { (byte)0x0F, 0, 2, new byte[] { 0xFF, 0xFE } },
            new object[] { (byte)0x0E, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
            new object[] { (byte)0x0E, 1, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
        };

    public static IEnumerable<object[]> SByteStoreBytes =>
        new List<object[]>
        {
            new object[] { (sbyte)0x0F, 0, 2, new byte[] { 0xFF, 0xFE } },
            new object[] { (sbyte)0x0E, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
            new object[] { (sbyte)0x0E, 1, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } },
        };

    #endregion
}
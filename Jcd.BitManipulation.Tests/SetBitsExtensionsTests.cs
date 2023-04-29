#region

using Jcd.BitManipulation.BitIndexers;
using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests;

public class SetBitsExtensionsTests
{
    #region range of bits tests

    [Theory]
    [InlineData(0x00, 0, 2, 0x03)]
    [InlineData(0x00, 6, 2, 0b11000000)]
    [InlineData(0x00, 0, 8, 0xFF)]
    public void SetBits_On_SByte_Sets_The_Correct_Bits(uint initial, int offset, int size, uint expected)
    {
        var value = (sbyte)initial; // coerce to proper type
        var result = value.SetBits((byte)offset, (byte)size);
        Assert.Equal((sbyte)expected, result);
    }

    [Theory]
    [InlineData(0x00, 0, 2, 0x03)]
    [InlineData(0x00, 6, 2, 0b11000000)]
    [InlineData(0x00, 0, 8, 0xFF)]
    public void SetBits_On_Byte_Sets_The_Correct_Bits(uint initial, int offset, int size, uint expected)
    {
        var value = (byte)initial; // coerce to proper type
        var result = value.SetBits((byte)offset, (byte)size);
        Assert.Equal((byte)expected, result);
    }

    [Theory]
    [InlineData(0x00, 0, 2, 0x03)]
    [InlineData(0x00, 6, 2, 0b11000000)]
    [InlineData(0x00, 0, 8, 0xFF)]
    [InlineData(0x00, 12, 2, 0b0011000000000000)]
    [InlineData(0x00, 0, 16, 0xFFFF)]
    public void SetBits_On_Int16_Sets_The_Correct_Bits(uint initial, int offset, int size, uint expected)
    {
        var value = (short)initial; // coerce to proper type
        var result = value.SetBits((byte)offset, (byte)size);
        Assert.Equal((short)expected, result);
    }

    [Theory]
    [InlineData(0x00, 0, 2, 0x03)]
    [InlineData(0x00, 6, 2, 0b11000000)]
    [InlineData(0x00, 0, 8, 0xFF)]
    [InlineData(0x00, 12, 2, 0b0011000000000000)]
    [InlineData(0x00, 0, 16, 0xFFFF)]
    public void SetBits_On_UInt16_Sets_The_Correct_Bits(uint initial, int offset, int size, uint expected)
    {
        var value = (ushort)initial; // coerce to proper type, test data binder fails to do this correctly.
        var result = value.SetBits((byte)offset, (byte)size);
        Assert.Equal((ushort)expected, result);
    }

    [Theory]
    [InlineData(0x00, 0, 2, 0x03)]
    [InlineData(0x00, 6, 2, 0b11000000)]
    [InlineData(0x00, 0, 8, 0xFF)]
    [InlineData(0x00, 12, 2, 0b0011000000000000)]
    [InlineData(0x00, 0, 16, 0xFFFF)]
    [InlineData(0x00, 28, 2, 0b00110000000000000000000000000000)]
    [InlineData(0x00, 0, 32, 0xFFFFFFFF)]
    public void SetBits_On_Int32_Sets_The_Correct_Bits(uint initial, int offset, int size, uint expected)
    {
        var value = (int)initial; // coerce to proper type
        var result = value.SetBits((byte)offset, (byte)size);
        Assert.Equal((int)expected, result);
    }

    [Theory]
    [InlineData(0x00, 0, 2, 0x03)]
    [InlineData(0x00, 6, 2, 0b11000000)]
    [InlineData(0x00, 0, 8, 0xFF)]
    [InlineData(0x00, 12, 2, 0b0011000000000000)]
    [InlineData(0x00, 0, 16, 0xFFFF)]
    [InlineData(0x00, 28, 2, 0b00110000000000000000000000000000)]
    [InlineData(0x00, 0, 32, 0xFFFFFFFF)]
    public void SetBits_On_UInt32_Sets_The_Correct_Bits(uint value, int offset, int size, uint expected)
    {
        var result = value.SetBits((byte)offset, (byte)size);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0x00, 0, 2, 0x03)]
    [InlineData(0x00, 6, 2, 0b11000000)]
    [InlineData(0x00, 0, 8, 0xFF)]
    [InlineData(0x00, 12, 2, 0b0011000000000000)]
    [InlineData(0x00, 0, 16, 0xFFFF)]
    [InlineData(0x00, 28, 2, 0b00110000000000000000000000000000)]
    [InlineData(0x00, 0, 32, 0xFFFFFFFF)]
    [InlineData(0x00, 60, 2, 0b0011000000000000000000000000000000000000000000000000000000000000)]
    [InlineData(0x00, 0, 64, 0xFFFFFFFFFFFFFFFF)]
    public void SetBits_On_Int64_Sets_The_Correct_Bits(ulong initial, int offset, int size, ulong expected)
    {
        var value = (long)initial; // coerce to proper type
        var result = value.SetBits((byte)offset, (byte)size);
        Assert.Equal((long)expected, result);
    }

    [Theory]
    [InlineData(0x00, 0, 2, 0x03)]
    [InlineData(0x00, 6, 2, 0b11000000)]
    [InlineData(0x00, 0, 8, 0xFF)]
    [InlineData(0x00, 12, 2, 0b0011000000000000)]
    [InlineData(0x00, 0, 16, 0xFFFF)]
    [InlineData(0x00, 28, 2, 0b00110000000000000000000000000000)]
    [InlineData(0x00, 0, 32, 0xFFFFFFFF)]
    [InlineData(0x00, 60, 2, 0b0011000000000000000000000000000000000000000000000000000000000000)]
    [InlineData(0x00, 0, 64, 0xFFFFFFFFFFFFFFFF)]
    public void SetBits_On_UInt64_Sets_The_Correct_Bits(ulong value, int offset, int size, ulong expected)
    {
        var result = value.SetBits((byte)offset, (byte)size);
        Assert.Equal(expected, result);
    }

    #endregion

    #region single bit tests

    [Theory]
    [InlineData(0x00, 3, 0x08)]
    [InlineData(0x80, 3, 0x88)]
    [InlineData(0x00, 7, 0x80)]
    public void SetBit_On_SByte_Sets_Correct_Bit(ulong initial, int bitToSet, ulong expected)
    {
        var value = (sbyte)initial;
        var result = value.SetBit((byte)bitToSet);
        Assert.Equal((sbyte)expected, result);
    }

    [Theory]
    [InlineData(0x00, 3, 0x08)]
    [InlineData(0x80, 3, 0x88)]
    [InlineData(0x00, 7, 0x80)]
    public void SetBit_On_Byte_Sets_Correct_Bit(ulong initial, int bitToSet, ulong expected)
    {
        var value = (byte)initial;
        var result = value.SetBit((byte)bitToSet);
        Assert.Equal((byte)expected, result);
    }

    [Theory]
    [InlineData(0x00, 3, 0x08)]
    [InlineData(0x80, 3, 0x88)]
    [InlineData(0x00, 7, 0x80)]
    [InlineData(0x00, 8, 0x0100)]
    [InlineData(0x80, 8, 0x0180)]
    [InlineData(0x00, 15, 0x8000)]
    public void SetBit_On_Int16_Sets_Correct_Bit(ulong initial, int bitToSet, ulong expected)
    {
        var value = (short)initial;
        var result = value.SetBit((byte)bitToSet);
        Assert.Equal((short)expected, result);
    }

    [Theory]
    [InlineData(0x00, 3, 0x08)]
    [InlineData(0x80, 3, 0x88)]
    [InlineData(0x00, 7, 0x80)]
    [InlineData(0x00, 8, 0x0100)]
    [InlineData(0x80, 8, 0x0180)]
    [InlineData(0x00, 15, 0x8000)]
    public void SetBit_On_UInt16_Sets_Correct_Bit(ulong initial, int bitToSet, ulong expected)
    {
        var value = (ushort)initial;
        var result = value.SetBit((byte)bitToSet);
        Assert.Equal((ushort)expected, result);
    }

    [Theory]
    [InlineData(0x00, 3, 0x08)]
    [InlineData(0x80, 3, 0x88)]
    [InlineData(0x00, 7, 0x80)]
    [InlineData(0x00, 8, 0x0100)]
    [InlineData(0x80, 8, 0x0180)]
    [InlineData(0x00, 15, 0x8000)]
    [InlineData(0x80, 16, 0x00010080)]
    [InlineData(0x00, 31, 0x80000000)]
    public void SetBit_On_Int32_Sets_Correct_Bit(ulong initial, int bitToSet, ulong expected)
    {
        var value = (int)initial;
        var result = value.SetBit((byte)bitToSet);
        Assert.Equal((int)expected, result);
    }

    [Theory]
    [InlineData(0x00, 3, 0x08)]
    [InlineData(0x80, 3, 0x88)]
    [InlineData(0x00, 7, 0x80)]
    [InlineData(0x00, 8, 0x0100)]
    [InlineData(0x80, 8, 0x0180)]
    [InlineData(0x00, 15, 0x8000)]
    [InlineData(0x80, 16, 0x00010080)]
    [InlineData(0x00, 31, 0x80000000)]
    public void SetBit_On_UInt32_Sets_Correct_Bit(ulong initial, int bitToSet, ulong expected)
    {
        var value = (uint)initial;
        var result = value.SetBit((byte)bitToSet);
        Assert.Equal((uint)expected, result);
    }

    [Theory]
    [InlineData(0x00, 3, 0x08)]
    [InlineData(0x80, 3, 0x88)]
    [InlineData(0x00, 7, 0x80)]
    [InlineData(0x00, 8, 0x0100)]
    [InlineData(0x80, 8, 0x0180)]
    [InlineData(0x00, 15, 0x8000)]
    [InlineData(0x80, 16, 0x00010080)]
    [InlineData(0x00, 31, 0x80000000)]
    [InlineData(0x80, 32, 0x0000000100000080)]
    [InlineData(0x00, 63, 0x8000000000000000)]
    public void SetBit_On_Int64_Sets_Correct_Bit(ulong initial, int bitToSet, ulong expected)
    {
        var value = (long)initial;
        var result = value.SetBit((byte)bitToSet);
        Assert.Equal((long)expected, result);
    }

    [Theory]
    [InlineData(0x00, 3, 0x08)]
    [InlineData(0x80, 3, 0x88)]
    [InlineData(0x00, 7, 0x80)]
    [InlineData(0x00, 8, 0x0100)]
    [InlineData(0x80, 8, 0x0180)]
    [InlineData(0x00, 15, 0x8000)]
    [InlineData(0x80, 16, 0x00010080)]
    [InlineData(0x00, 31, 0x80000000)]
    [InlineData(0x80, 32, 0x0000000100000080)]
    [InlineData(0x00, 63, 0x8000000000000000)]
    public void SetBit_On_UInt64_Sets_Correct_Bit(ulong value, int bitToSet, ulong expected)
    {
        var result = value.SetBit((byte)bitToSet);
        Assert.Equal(expected, result);
    }

    #endregion

    #region BitMask tests

    [Theory]
    [InlineData(0x00, 0x03, 0x03)]
    [InlineData(0x80, 0x03, 0x83)]
    public void SetBits_For_SByte_When_Given_A_Mask_Directly_Sets_Only_The_Specified_Bits(
        uint initialValue, uint maskValue, uint expected)
    {
        // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
        var value = (sbyte)initialValue;
        var mask = new BitMask((sbyte)maskValue);
        var result = value.SetBits(mask);
        Assert.Equal((sbyte)expected, result);
    }

    [Theory]
    [InlineData(0x00, 0x03, 0x03)]
    [InlineData(0x80, 0x03, 0x83)]
    public void SetBits_For_Byte_When_Given_A_Mask_Directly_Sets_Only_The_Specified_Bits(
        uint initialValue, uint maskValue, uint expected)
    {
        // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
        var value = (byte)initialValue;
        var mask = new BitMask((byte)maskValue);
        var result = value.SetBits(mask);
        Assert.Equal((byte)expected, result);
    }

    [Theory]
    [InlineData(0x00, 0x03, 0x03)]
    [InlineData(0x80, 0x03, 0x83)]
    [InlineData(0x0000, 0x0300, 0x0300)]
    [InlineData(0x8000, 0x0300, 0x8300)]
    public void SetBits_For_Int16_When_Given_A_Mask_Directly_Sets_Only_The_Specified_Bits(
        uint initialValue, uint maskValue, uint expected)
    {
        // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
        var value = (short)initialValue;
        var mask = new BitMask((short)maskValue);
        var result = value.SetBits(mask);
        Assert.Equal((short)expected, result);
    }

    [Theory]
    [InlineData(0x00, 0x03, 0x03)]
    [InlineData(0x80, 0x03, 0x83)]
    [InlineData(0x0000, 0x0300, 0x0300)]
    [InlineData(0x8000, 0x0300, 0x8300)]
    public void SetBits_For_UInt16_When_Given_A_Mask_Directly_Sets_Only_The_Specified_Bits(
        uint initialValue, uint maskValue, uint expected)
    {
        // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
        var value = (ushort)initialValue;
        var mask = new BitMask((ushort)maskValue);
        var result = value.SetBits(mask);
        Assert.Equal((ushort)expected, result);
    }

    [Theory]
    [InlineData(0x00, 0x03, 0x03)]
    [InlineData(0x80, 0x03, 0x83)]
    [InlineData(0x0000, 0x0300, 0x0300)]
    [InlineData(0x8000, 0x0300, 0x8300)]
    [InlineData(0x00000000, 0x03000000, 0x03000000)]
    [InlineData(0x80000000, 0x03000000, 0x83000000)]
    public void SetBits_For_Int32_When_Given_A_Mask_Directly_Sets_Only_The_Specified_Bits(
        uint initialValue, uint maskValue, uint expected)
    {
        // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
        var value = (int)initialValue;
        var mask = new BitMask((int)maskValue);
        var result = value.SetBits(mask);
        Assert.Equal((int)expected, result);
    }

    [Theory]
    [InlineData(0x00, 0x03, 0x03)]
    [InlineData(0x80, 0x03, 0x83)]
    [InlineData(0x0000, 0x0300, 0x0300)]
    [InlineData(0x8000, 0x0300, 0x8300)]
    [InlineData(0x00000000, 0x03000000, 0x03000000)]
    [InlineData(0x80000000, 0x03000000, 0x83000000)]
    public void SetBits_For_UInt32_When_Given_A_Mask_Directly_Sets_Only_The_Specified_Bits(
        uint initialValue, uint maskValue, uint expected)
    {
        // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
        var mask = new BitMask(maskValue);
        var result = initialValue.SetBits(mask);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0x00, 0x03, 0x03)]
    [InlineData(0x80, 0x03, 0x83)]
    [InlineData(0x0000, 0x0300, 0x0300)]
    [InlineData(0x8000, 0x0300, 0x8300)]
    [InlineData(0x00000000, 0x03000000, 0x03000000)]
    [InlineData(0x80000000, 0x03000000, 0x83000000)]
    [InlineData(0x0000000000000000, 0x0300000000000000, 0x0300000000000000)]
    [InlineData(0x8000000000000000, 0x0300000000000000, 0x8300000000000000)]
    public void SetBits_For_Int64_When_Given_A_Mask_Directly_Sets_Only_The_Specified_Bits(
        ulong initialValue, ulong maskValue, ulong expected)
    {
        // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
        var value = (long)initialValue;
        var mask = new BitMask((long)maskValue);
        var result = value.SetBits(mask);
        Assert.Equal((long)expected, result);
    }

    [Theory]
    [InlineData(0x00, 0x03, 0x03)]
    [InlineData(0x80, 0x03, 0x83)]
    [InlineData(0x0000, 0x0300, 0x0300)]
    [InlineData(0x8000, 0x0300, 0x8300)]
    [InlineData(0x00000000, 0x03000000, 0x03000000)]
    [InlineData(0x80000000, 0x03000000, 0x83000000)]
    [InlineData(0x0000000000000000, 0x0300000000000000, 0x0300000000000000)]
    [InlineData(0x8000000000000000, 0x0300000000000000, 0x8300000000000000)]
    public void SetBits_For_UInt64_When_Given_A_Mask_Directly_Sets_Only_The_Specified_Bits(
        ulong initialValue, ulong maskValue, ulong expected)
    {
        // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
        var mask = new BitMask(maskValue);
        var result = initialValue.SetBits(mask);
        Assert.Equal(expected, result);
    }

    #endregion
}
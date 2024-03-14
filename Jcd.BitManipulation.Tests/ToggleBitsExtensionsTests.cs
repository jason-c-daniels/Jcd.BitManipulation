#region

using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests;

public class ToggleBitsExtensionsTests
{
   #region range of bits tests

   [Theory]
   [InlineData(0b11111111, 0, 2, 0b11111100)] // toggle lower 2 bits
   [InlineData(0b11111111, 4, 2, 0b11001111)] // toggle middle 2 bits
   [InlineData(0b11111111, 6, 2, 0b00111111)] // toggle upper 2 bits
   public void ToggleBits_On_SByte_Toggles_The_Correct_Bits(uint initial, int offset, int size, uint expected)
   {
      var value  = (sbyte) initial; // coerce to proper type
      var result = value.ToggleBits((byte) offset, (byte) size);
      Assert.Equal((sbyte) expected, result);
   }

   [Theory]
   [InlineData(0b11111111, 0, 2, 0b11111100)] // toggle lower 2 bits
   [InlineData(0b11111111, 4, 2, 0b11001111)] // toggle middle 2 bits
   [InlineData(0b11111111, 6, 2, 0b00111111)] // toggle upper 2 bits
   public void ToggleBits_On_Byte_Toggles_The_Correct_Bits(uint initial, int offset, int size, uint expected)
   {
      var value  = (byte) initial; // coerce to proper type
      var result = value.ToggleBits((byte) offset, (byte) size);
      Assert.Equal((byte) expected, result);
   }

   [Theory]
   [InlineData(0b11111111,     0, 2, 0b11111100)] // toggle lower 2 bits
   [InlineData(0b11111111,     4, 2, 0b11001111)] // toggle middle 2 bits of lower byte
   [InlineData(0b11111111,     6, 2, 0b00111111)] // toggle upper 2 bits of lower byte
   [InlineData(0b111111111111, 8, 2, 0b110011111111)]
   public void ToggleBits_On_Int16_Toggles_The_Correct_Bits(uint initial, int offset, int size, uint expected)
   {
      var value  = (short) initial; // coerce to proper type
      var result = value.ToggleBits((byte) offset, (byte) size);
      Assert.Equal((short) expected, result);
   }

   [Theory]
   [InlineData(0b11111111,     0, 2, 0b11111100)] // toggle lower 2 bits
   [InlineData(0b11111111,     4, 2, 0b11001111)] // toggle middle 2 bits of lower byte
   [InlineData(0b11111111,     6, 2, 0b00111111)] // toggle upper 2 bits of lower byte
   [InlineData(0b111111111111, 8, 2, 0b110011111111)]
   public void ToggleBits_On_UInt16_Toggles_The_Correct_Bits(uint initial, int offset, int size, uint expected)
   {
      var value  = (ushort) initial; // coerce to proper type, test data binder fails to do this correctly.
      var result = value.ToggleBits((byte) offset, (byte) size);
      Assert.Equal((ushort) expected, result);
   }

   [Theory]
   [InlineData(0b11111111,                         0,  2, 0b11111100)] // toggle lower 2 bits
   [InlineData(0b11111111,                         4,  2, 0b11001111)] // toggle middle 2 bits of lower byte
   [InlineData(0b11111111,                         6,  2, 0b00111111)] // toggle upper 2 bits of lower byte
   [InlineData(0b111111111111,                     8,  2, 0b110011111111)]
   [InlineData(0b11111111111111111111111111111111, 26, 2, 0b11110011111111111111111111111111)]
   public void ToggleBits_On_Int32_Toggles_The_Correct_Bits(uint initial, int offset, int size, uint expected)
   {
      var value  = (int) initial; // coerce to proper type
      var result = value.ToggleBits((byte) offset, (byte) size);
      Assert.Equal((int) expected, result);
   }

   [Theory]
   [InlineData(0b11111111,                         0,  2, 0b11111100)] // toggle lower 2 bits
   [InlineData(0b11111111,                         4,  2, 0b11001111)] // toggle middle 2 bits of lower byte
   [InlineData(0b11111111,                         6,  2, 0b00111111)] // toggle upper 2 bits of lower byte
   [InlineData(0b111111111111,                     8,  2, 0b110011111111)]
   [InlineData(0b11111111111111111111111111111111, 26, 2, 0b11110011111111111111111111111111)]
   public void ToggleBits_On_UInt32_Toggles_The_Correct_Bits(uint value, int offset, int size, uint expected)
   {
      var result = value.ToggleBits((byte) offset, (byte) size);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0b11111111,                             0,  2, 0b11111100)] // toggle lower 2 bits
   [InlineData(0b11111111,                             4,  2, 0b11001111)] // toggle middle 2 bits of lower byte
   [InlineData(0b11111111,                             6,  2, 0b00111111)] // toggle upper 2 bits of lower byte
   [InlineData(0b111111111111,                         8,  2, 0b110011111111)]
   [InlineData(0b00111111111111111111111111111111,     26, 2, 0b00110011111111111111111111111111)]
   [InlineData(0b111111111111111111111111111111111111, 32, 2, 0b110011111111111111111111111111111111)]
   public void ToggleBits_On_Int64_Toggles_The_Correct_Bits(ulong initial, int offset, int size, ulong expected)
   {
      var value  = (long) initial; // coerce to proper type
      var result = value.ToggleBits((byte) offset, (byte) size);
      Assert.Equal((long) expected, result);
   }

   [Theory]
   [InlineData(0b11111111,                             0,  2, 0b11111100)] // toggle lower 2 bits
   [InlineData(0b11111111,                             4,  2, 0b11001111)] // toggle middle 2 bits of lower byte
   [InlineData(0b11111111,                             6,  2, 0b00111111)] // toggle upper 2 bits of lower byte
   [InlineData(0b111111111111,                         8,  2, 0b110011111111)]
   [InlineData(0b00111111111111111111111111111111,     26, 2, 0b00110011111111111111111111111111)]
   [InlineData(0b111111111111111111111111111111111111, 32, 2, 0b110011111111111111111111111111111111)]
   public void ToggleBits_On_UInt64_Toggles_The_Correct_Bits(ulong value, int offset, int size, ulong expected)
   {
      var result = value.ToggleBits((byte) offset, (byte) size);
      Assert.Equal(expected, result);
   }

   #endregion

   #region single bit tests

   [Theory]
   [InlineData(0xFF, 0, 0xFE)]
   [InlineData(0xFF, 4, 0xEF)]
   [InlineData(0xFF, 7, 0x7F)]
   public void ToggleBit_On_SByte_Toggles_Correct_Bit(ulong initial, int bitToToggle, ulong expected)
   {
      var value  = (sbyte) initial;
      var result = value.ToggleBit((byte) bitToToggle);
      Assert.Equal((sbyte) expected, result);
   }

   [Theory]
   [InlineData(0xFF, 0, 0xFE)]
   [InlineData(0xFF, 4, 0xEF)]
   [InlineData(0xFF, 7, 0x7F)]
   public void ToggleBit_On_Byte_Toggles_Correct_Bit(ulong initial, int bitToToggle, ulong expected)
   {
      var value  = (byte) initial;
      var result = value.ToggleBit((byte) bitToToggle);
      Assert.Equal((byte) expected, result);
   }

   [Theory]
   [InlineData(0xFFFF, 0,  0xFFFE)]
   [InlineData(0xFFFF, 4,  0xFFEF)]
   [InlineData(0xFFFF, 15, 0x7FFF)]
   public void ToggleBit_On_Int16_Toggles_Correct_Bit(ulong initial, int bitToToggle, ulong expected)
   {
      var value  = (short) initial;
      var result = value.ToggleBit((byte) bitToToggle);
      Assert.Equal((short) expected, result);
   }

   [Theory]
   [InlineData(0xFFFF, 0,  0xFFFE)]
   [InlineData(0xFFFF, 4,  0xFFEF)]
   [InlineData(0xFFFF, 15, 0x7FFF)]
   public void ToggleBit_On_UInt16_Toggles_Correct_Bit(ulong initial, int bitToToggle, ulong expected)
   {
      var value  = (ushort) initial;
      var result = value.ToggleBit((byte) bitToToggle);
      Assert.Equal((ushort) expected, result);
   }

   [Theory]
   [InlineData(0xFFFFFFFF, 0,  0xFFFFFFFE)]
   [InlineData(0xFFFFFFFF, 4,  0xFFFFFFEF)]
   [InlineData(0xFFFFFFFF, 15, 0xFFFF7FFF)]
   [InlineData(0xFFFFFFFF, 31, 0x7FFFFFFF)]
   public void ToggleBit_On_Int32_Toggles_Correct_Bit(ulong initial, int bitToToggle, ulong expected)
   {
      var value  = (int) initial;
      var result = value.ToggleBit((byte) bitToToggle);
      Assert.Equal((int) expected, result);
   }

   [Theory]
   [InlineData(0xFFFFFFFF, 0,  0xFFFFFFFE)]
   [InlineData(0xFFFFFFFF, 4,  0xFFFFFFEF)]
   [InlineData(0xFFFFFFFF, 15, 0xFFFF7FFF)]
   [InlineData(0xFFFFFFFF, 31, 0x7FFFFFFF)]
   public void ToggleBit_On_UInt32_Toggles_Correct_Bit(ulong initial, int bitToToggle, ulong expected)
   {
      var value  = (uint) initial;
      var result = value.ToggleBit((byte) bitToToggle);
      Assert.Equal((uint) expected, result);
   }

   [Theory]
   [InlineData(0xFFFFFFFFFFFFFFFF, 0,  0xFFFFFFFFFFFFFFFE)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 4,  0xFFFFFFFFFFFFFFEF)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 15, 0xFFFFFFFFFFFF7FFF)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 31, 0xFFFFFFFF7FFFFFFF)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 63, 0x7FFFFFFFFFFFFFFF)]
   public void ToggleBit_On_Int64_Toggles_Correct_Bit(ulong initial, int bitToToggle, ulong expected)
   {
      var value  = (long) initial;
      var result = value.ToggleBit((byte) bitToToggle);
      Assert.Equal((long) expected, result);
   }

   [Theory]
   [InlineData(0xFFFFFFFFFFFFFFFF, 0,  0xFFFFFFFFFFFFFFFE)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 4,  0xFFFFFFFFFFFFFFEF)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 15, 0xFFFFFFFFFFFF7FFF)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 31, 0xFFFFFFFF7FFFFFFF)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 63, 0x7FFFFFFFFFFFFFFF)]
   public void ToggleBit_On_UInt64_Toggles_Correct_Bit(ulong value, int bitToToggle, ulong expected)
   {
      var result = value.ToggleBit((byte) bitToToggle);
      Assert.Equal(expected, result);
   }

   #endregion

   #region BitMask tests

   [Theory]
   [InlineData(0b11111111, 0b0000110, 0b11111001)]
   [InlineData(0b10111111, 0b0000100, 0b10111011)]
   public void ToggleBits_For_SByte_When_Given_A_Mask_Directly_Toggles_Only_The_Specified_Bits(
      uint initialValue
    , uint maskValue
    , uint expected
   )
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var value  = (sbyte) initialValue;
      var mask   = new BitMask((sbyte) maskValue);
      var result = value.ToggleBits(mask);
      Assert.Equal((sbyte) expected, result);
   }

   [Theory]
   [InlineData(0b11111111, 0b0000110, 0b11111001)]
   [InlineData(0b10111111, 0b0000100, 0b10111011)]
   public void ToggleBits_For_Byte_When_Given_A_Mask_Directly_Toggles_Only_The_Specified_Bits(
      uint initialValue
    , uint maskValue
    , uint expected
   )
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var value  = (byte) initialValue;
      var mask   = new BitMask((byte) maskValue);
      var result = value.ToggleBits(mask);
      Assert.Equal((byte) expected, result);
   }

   [Theory]
   [InlineData(0b11111111,         0b0000110,          0b11111001)]
   [InlineData(0b10111111,         0b0000100,          0b10111011)]
   [InlineData(0b1111111111111111, 0b0100000000000110, 0b1011111111111001)]
   [InlineData(0b1111111110111111, 0b0100000000000100, 0b1011111110111011)]
   public void ToggleBits_For_Int16_When_Given_A_Mask_Directly_Toggles_Only_The_Specified_Bits(
      uint initialValue
    , uint maskValue
    , uint expected
   )
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var value  = (short) initialValue;
      var mask   = new BitMask((short) maskValue);
      var result = value.ToggleBits(mask);
      Assert.Equal((short) expected, result);
   }

   [Theory]
   [InlineData(0b11111111,         0b0000110,          0b11111001)]
   [InlineData(0b10111111,         0b0000100,          0b10111011)]
   [InlineData(0b1111111111111111, 0b0100000000000110, 0b1011111111111001)]
   [InlineData(0b1111111110111111, 0b0100000000000100, 0b1011111110111011)]
   public void ToggleBits_For_UInt16_When_Given_A_Mask_Directly_Toggles_Only_The_Specified_Bits(
      uint initialValue
    , uint maskValue
    , uint expected
   )
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var value  = (ushort) initialValue;
      var mask   = new BitMask((ushort) maskValue);
      var result = value.ToggleBits(mask);
      Assert.Equal((ushort) expected, result);
   }

   [Theory]
   [InlineData(0b11111111,         0b0000110,          0b11111001)]
   [InlineData(0b10111111,         0b0000100,          0b10111011)]
   [InlineData(0b1111111111111111, 0b0100000000000110, 0b1011111111111001)]
   [InlineData(0b1111111110111111, 0b0100000000000100, 0b1011111110111011)]
   [InlineData(0b11111111111111111111111111111111
             , 0b00100001000000000100000000000110
             , 0b11011110111111111011111111111001
              )]
   public void ToggleBits_For_Int32_When_Given_A_Mask_Directly_Toggles_Only_The_Specified_Bits(
      uint initialValue
    , uint maskValue
    , uint expected
   )
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var value  = (int) initialValue;
      var mask   = new BitMask((int) maskValue);
      var result = value.ToggleBits(mask);
      Assert.Equal((int) expected, result);
   }

   [Theory]
   [InlineData(0b11111111,         0b0000110,          0b11111001)]
   [InlineData(0b10111111,         0b0000100,          0b10111011)]
   [InlineData(0b1111111111111111, 0b0100000000000110, 0b1011111111111001)]
   [InlineData(0b1111111110111111, 0b0100000000000100, 0b1011111110111011)]
   [InlineData(0b11111111111111111111111111111111
             , 0b00100001000000000100000000000110
             , 0b11011110111111111011111111111001
              )]
   public void ToggleBits_For_UInt32_When_Given_A_Mask_Directly_Toggles_Only_The_Specified_Bits(
      uint initialValue
    , uint maskValue
    , uint expected
   )
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var mask   = new BitMask(maskValue);
      var result = initialValue.ToggleBits(mask);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0b11111111,         0b0000110,          0b11111001)]
   [InlineData(0b10111111,         0b0000100,          0b10111011)]
   [InlineData(0b1111111111111111, 0b0100000000000110, 0b1011111111111001)]
   [InlineData(0b1111111110111111, 0b0100000000000100, 0b1011111110111011)]
   [InlineData(0b11111111111111111111111111111111
             , 0b00100001000000000100000000000110
             , 0b11011110111111111011111111111001
              )]
   [InlineData(0b1111111111111111111111111111111111111111111111111111111111111111
             , 0b0000010000000000000000000000000000100001000000000100000000000110
             , 0b1111101111111111111111111111111111011110111111111011111111111001
              )]
   public void ToggleBits_For_Int64_When_Given_A_Mask_Directly_Toggles_Only_The_Specified_Bits(
      ulong initialValue
    , ulong maskValue
    , ulong expected
   )
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var value  = (long) initialValue;
      var mask   = new BitMask((long) maskValue);
      var result = value.ToggleBits(mask);
      Assert.Equal((long) expected, result);
   }

   [Theory]
   [InlineData(0b11111111,         0b0000110,          0b11111001)]
   [InlineData(0b10111111,         0b0000100,          0b10111011)]
   [InlineData(0b1111111111111111, 0b0100000000000110, 0b1011111111111001)]
   [InlineData(0b1111111110111111, 0b0100000000000100, 0b1011111110111011)]
   [InlineData(0b11111111111111111111111111111111
             , 0b00100001000000000100000000000110
             , 0b11011110111111111011111111111001
              )]
   [InlineData(0b1111111111111111111111111111111111111111111111111111111111111111
             , 0b0000010000000000000000000000000000100001000000000100000000000110
             , 0b1111101111111111111111111111111111011110111111111011111111111001
              )]
   public void ToggleBits_For_UInt64_When_Given_A_Mask_Directly_Toggles_Only_The_Specified_Bits(
      ulong initialValue
    , ulong maskValue
    , ulong expected
   )
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var mask   = new BitMask(maskValue);
      var result = initialValue.ToggleBits(mask);
      Assert.Equal(expected, result);
   }

   #endregion
}
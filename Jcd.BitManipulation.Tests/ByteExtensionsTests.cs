#region

using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests;

public class ByteExtensionsTests
{
   [Theory]
   [InlineData(0,     ulong.MaxValue, false)]
   [InlineData(0b11,  ulong.MaxValue, true)]
   [InlineData(0b100, 0b10,           false)]
   [InlineData(0b011, 0b10,           true)]
   public void AreAnyBitsSet_On_A_Byte_Returns_The_Expected_Result(byte data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAnyBitsSet(mask));
   }

   [Theory]
   [InlineData(0,    ulong.MaxValue, false)]
   [InlineData(0b11, ulong.MaxValue, false)]
   [InlineData(0b10, 0b10,           true)]
   [InlineData(0b11, 0b10,           true)]
   public void AreAllBits_On_A_Byte_Returns_The_Expected_Result(byte data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAllBitsSet(mask));
   }

   [Theory]
   [InlineData(0,    ulong.MaxValue, true)]
   [InlineData(0b11, ulong.MaxValue, false)]
   [InlineData(0b10, 0b10,           false)]
   [InlineData(0b11, 0b10,           false)]
   public void AreNoBitsSet_On_A_Byte_Returns_The_Expected_Result(byte data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreNoBitsSet(mask));
   }

   [Theory]
   [InlineData(0b11111111, 0, 2, 0b11111100)] // clear lower 2 bits
   [InlineData(0b11111111, 4, 2, 0b11001111)] // clear middle 2 bits
   [InlineData(0b11111111, 6, 2, 0b00111111)] // clear upper 2 bits
   public void ClearBits_On_Byte_Clears_The_Correct_Bits(byte initial, int offset, int size, byte expected)
   {
      var value = initial; // coerce to proper type
      var result = value.ClearBits((byte) offset, (byte) size);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0xFF, 0, 0xFE)]
   [InlineData(0xFF, 4, 0xEF)]
   [InlineData(0xFF, 7, 0x7F)]
   public void ClearBit_On_Byte_Clears_Correct_Bit(byte initial, int bitToClear, byte expected)
   {
      var value = initial;
      var result = value.ClearBit((byte) bitToClear);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0b11111111, 0b0000110, 0b11111001)]
   [InlineData(0b10111111, 0b0000100, 0b10111011)]
   public void ClearBits_For_Byte_When_Given_A_Mask_Directly_Clears_Only_The_Specified_Bits(byte initialValue, uint maskValue, byte expected)
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var value = initialValue;
      var mask = new BitMask((byte) maskValue);
      var result = value.ClearBits(mask);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0x00, 0, 2, 0x03)]
   [InlineData(0x00, 6, 2, 0b11000000)]
   [InlineData(0x00, 0, 8, 0xFF)]
   public void SetBits_On_Byte_Sets_The_Correct_Bits(byte initial, int offset, int size, byte expected)
   {
      var value = initial; // coerce to proper type
      var result = value.SetBits((byte) offset, (byte) size);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0x00, 3, 0x08)]
   [InlineData(0x80, 3, 0x88)]
   [InlineData(0x00, 7, 0x80)]
   public void SetBit_On_Byte_Sets_Correct_Bit(byte initial, int bitToSet, byte expected)
   {
      var value = initial;
      var result = value.SetBit((byte) bitToSet);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0x00, 0x03, 0x03)]
   [InlineData(0x80, 0x03, 0x83)]
   public void SetBits_For_Byte_When_Given_A_Mask_Directly_Sets_Only_The_Specified_Bits(byte initialValue, byte maskValue, byte expected)
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var value = initialValue;
      var mask = new BitMask(maskValue);
      var result = value.SetBits(mask);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0xFF,       0, 2, 0x03)]
   [InlineData(0b11100000, 6, 2, 0b11)]
   [InlineData(0b11100000, 4, 2, 0b10)]
   [InlineData(0xFF,       0, 8, 0xFF)]
   [InlineData(0x3F,       4, 4, 0x03)]
   public void ReadBits_On_Byte_Reads_The_Correct_Bits(byte initial, int offset, int size, byte expected)
   {
      var bits = initial; // coerce to proper type
      var value = bits.ReadBits(offset, size);
      Assert.Equal(expected, value);
      value = bits.ReadBits(BitMask.FromRange(offset, size));
      Assert.Equal((expected << offset), value);
   }

   [Theory]
   [InlineData(0b11100111, 0, true)]
   [InlineData(0b11100111, 3, false)]
   [InlineData(0b11100111, 7, true)]
   public void ReadBit_For_Byte_Reads_The_Correct_Value(byte bits, int offset, bool expected)
   {
      Assert.Equal(expected, bits.ReadBit((byte) offset));
   }

   [Theory]
   [InlineData(0x00, 0xFF, 0, 2, 0x03)]
   [InlineData(0x00, 0xFF, 6, 2, 0b11000000)]
   [InlineData(0x00, 0xFF, 0, 8, 0xFF)]
   [InlineData(0xF0, 0x03, 0, 4, 0xF3)]
   public void StoreBits_On_Byte_Stores_The_Correct_Bits(byte initial, byte val, int offset, int size, uint expected)
   {
      var destination = initial; // coerce to proper type
      var value = val;
      var result = destination.StoreBits(value, offset, size);
      Assert.Equal((byte) expected, result);
   }

   [Theory]
   [InlineData(0x00, 0, true,  0x01)]
   [InlineData(0x00, 7, true,  0x80)]
   [InlineData(0xFF, 0, false, 0xFE)]
   [InlineData(0xFF, 7, false, 0x7F)]
   public void StoreBit_For_Byte_Sets_The_Specified_Bit_To_The_Target_Value(byte destination, int offset, bool bit, byte expected)
   {
      var value = destination;
      var result = value.StoreBit(bit, offset);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0b11111111, 0, 2, 0b11111100)] // toggle lower 2 bits
   [InlineData(0b11111111, 4, 2, 0b11001111)] // toggle middle 2 bits
   [InlineData(0b11111111, 6, 2, 0b00111111)] // toggle upper 2 bits
   public void ToggleBits_On_Byte_Toggles_The_Correct_Bits(byte initial, int offset, int size, byte expected)
   {
      var value = initial; // coerce to proper type
      var result = value.ToggleBits((byte) offset, (byte) size);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0xFF, 0, 0xFE)]
   [InlineData(0xFF, 4, 0xEF)]
   [InlineData(0xFF, 7, 0x7F)]
   public void ToggleBit_On_Byte_Toggles_Correct_Bit(byte initial, int bitToToggle, byte expected)
   {
      var value = initial;
      var result = value.ToggleBit((byte) bitToToggle);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0b11111111, 0b0000110, 0b11111001)]
   [InlineData(0b10111111, 0b0000100, 0b10111011)]
   public void ToggleBits_For_Byte_When_Given_A_Mask_Directly_Toggles_Only_The_Specified_Bits(byte initialValue, byte maskValue, byte expected)
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var value = initialValue;
      var mask = new BitMask(maskValue);
      var result = value.ToggleBits(mask);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0x00, 0x00)]
   [InlineData(0x01, 0x01)]
   [InlineData(0x7F, 0x7F)]
   public void ToByteArray_On_Byte_Returns_Expected_Value(byte data, byte e0)
   {
      var expected = new[] { e0 };
      Assert.Equal(expected, data.ToByteArray());
   }
}
#region

using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests;

public class StoreBitsExtensionsTests
{
   #region range of bits tests

   [Theory]
   [InlineData(0x00, 0xFF, 0, 2, 0x03)]
   [InlineData(0x00, 0xFF, 6, 2, 0b11000000)]
   [InlineData(0x00, 0xFF, 0, 8, 0xFF)]
   [InlineData(0xF0, 0x03, 0, 4, 0xF3)]
   public void StoreBits_On_SByte_Stores_The_Correct_Bits(uint initial, uint val, int offset, int size, uint expected)
   {
      var destination = (sbyte) initial; // coerce to proper type
      var value       = (sbyte) val;
      var result      = destination.StoreBits(value, offset, size);
      Assert.Equal((sbyte) expected, result);
   }

   [Theory]
   [InlineData(0x00, 0xFF, 0, 2, 0x03)]
   [InlineData(0x00, 0xFF, 6, 2, 0b11000000)]
   [InlineData(0x00, 0xFF, 0, 8, 0xFF)]
   [InlineData(0xF0, 0x03, 0, 4, 0xF3)]
   public void StoreBits_On_Byte_Stores_The_Correct_Bits(uint initial, uint val, int offset, int size, uint expected)
   {
      var destination = (byte) initial; // coerce to proper type
      var value       = (byte) val;
      var result      = destination.StoreBits(value, offset, size);
      Assert.Equal((byte) expected, result);
   }

   [Theory]
   [InlineData(0x00,   0xFF,   0, 2,  0x03)]
   [InlineData(0x00,   0xFF,   6, 2,  0b11000000)]
   [InlineData(0x00,   0xFF,   0, 8,  0xFF)]
   [InlineData(0xF0,   0x03,   0, 4,  0xF3)]
   [InlineData(0x0000, 0xFFFF, 0, 16, 0xFFFF)]
   [InlineData(0xF000, 0x03,   0, 8,  0xF003)]
   public void StoreBits_On_Int16_Stores_The_Correct_Bits(uint initial, uint val, int offset, int size, uint expected)
   {
      var destination = (short) initial; // coerce to proper type
      var value       = (short) val;
      var result      = destination.StoreBits(value, offset, size);
      Assert.Equal((short) expected, result);
   }

   [Theory]
   [InlineData(0x00,   0xFF,   0, 2,  0x03)]
   [InlineData(0x00,   0xFF,   6, 2,  0b11000000)]
   [InlineData(0x00,   0xFF,   0, 8,  0xFF)]
   [InlineData(0xF0,   0x03,   0, 4,  0xF3)]
   [InlineData(0x0000, 0xFFFF, 0, 16, 0xFFFF)]
   [InlineData(0xF000, 0x03,   0, 8,  0xF003)]
   public void StoreBits_On_UInt16_Stores_The_Correct_Bits(uint initial, uint val, int offset, int size, uint expected)
   {
      var destination = (ushort) initial; // coerce to proper type
      var value       = (ushort) val;
      var result      = destination.StoreBits(value, offset, size);
      Assert.Equal((ushort) expected, result);
   }

   [Theory]
   [InlineData(0x00,   0xFF,   0, 2,  0x03)]
   [InlineData(0x00,   0xFF,   6, 2,  0b11000000)]
   [InlineData(0x00,   0xFF,   0, 8,  0xFF)]
   [InlineData(0xF0,   0x03,   0, 4,  0xF3)]
   [InlineData(0x0000, 0xFFFF, 0, 16, 0xFFFF)]
   [InlineData(0xF000, 0x03,   0, 8,  0xF003)]
   public void StoreBits_On_Int32_Stores_The_Correct_Bits(uint initial, uint val, int offset, int size, uint expected)
   {
      var destination = (int) initial; // coerce to proper type
      var value       = (int) val;
      var result      = destination.StoreBits(value, offset, size);
      Assert.Equal((int) expected, result);
   }

   [Theory]
   [InlineData(0x00,   0xFF,   0, 2,  0x03)]
   [InlineData(0x00,   0xFF,   6, 2,  0b11000000)]
   [InlineData(0x00,   0xFF,   0, 8,  0xFF)]
   [InlineData(0xF0,   0x03,   0, 4,  0xF3)]
   [InlineData(0x0000, 0xFFFF, 0, 16, 0xFFFF)]
   [InlineData(0xF000, 0x03,   0, 8,  0xF003)]
   public void StoreBits_On_UInt32_Stores_The_Correct_Bits(uint initial, uint val, int offset, int size, uint expected)
   {
      var result = initial.StoreBits(val, offset, size);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0x00,   0xFF,   0, 2,  0x03)]
   [InlineData(0x00,   0xFF,   6, 2,  0b11000000)]
   [InlineData(0x00,   0xFF,   0, 8,  0xFF)]
   [InlineData(0xF0,   0x03,   0, 4,  0xF3)]
   [InlineData(0x0000, 0xFFFF, 0, 16, 0xFFFF)]
   [InlineData(0xF000, 0x03,   0, 8,  0xF003)]
   public void StoreBits_On_Int64_Stores_The_Correct_Bits(ulong initial, ulong val, int offset, int size, ulong expected)
   {
      var destination = (long) initial; // coerce to proper type
      var value       = (long) val;
      var result      = destination.StoreBits(value, offset, size);
      Assert.Equal((long) expected, result);
   }

   [Theory]
   [InlineData(0x00,   0xFF,   0, 2,  0x03)]
   [InlineData(0x00,   0xFF,   6, 2,  0b11000000)]
   [InlineData(0x00,   0xFF,   0, 8,  0xFF)]
   [InlineData(0xF0,   0x03,   0, 4,  0xF3)]
   [InlineData(0x0000, 0xFFFF, 0, 16, 0xFFFF)]
   [InlineData(0xF000, 0x03,   0, 8,  0xF003)]
   public void StoreBits_On_UInt64_Stores_The_Correct_Bits(ulong initial, ulong val, int offset, int size, ulong expected)
   {
      var result = initial.StoreBits(val, offset, size);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0x00,   0xFF,   0, 2,  0x03)]
   [InlineData(0x00,   0xFF,   6, 2,  0b11000000)]
   [InlineData(0x00,   0xFF,   0, 8,  0xFF)]
   [InlineData(0xF0,   0x03,   0, 4,  0xF3)]
   [InlineData(0x0000, 0xFFFF, 0, 16, 0xFFFF)]
   [InlineData(0xF000, 0x03,   0, 8,  0xF003)]
   public void StoreBits_On_Single_Stores_The_Correct_Bits(uint initial, uint val, int offset, int size, uint expected)
   {
      var result = initial.BitwiseToSingle().StoreBits(val, offset, size);
      Assert.Equal(expected.BitwiseToSingle(), result);
   }

   [Theory]
   [InlineData(0x00,   0xFF,   0, 2,  0x03)]
   [InlineData(0x00,   0xFF,   6, 2,  0b11000000)]
   [InlineData(0x00,   0xFF,   0, 8,  0xFF)]
   [InlineData(0xF0,   0x03,   0, 4,  0xF3)]
   [InlineData(0x0000, 0xFFFF, 0, 16, 0xFFFF)]
   [InlineData(0xF000, 0x03,   0, 8,  0xF003)]
   public void StoreBits_On_Double_Stores_The_Correct_Bits(ulong initial, ulong val, int offset, int size, ulong expected)
   {
      var result = initial.BitwiseToDouble().StoreBits(val, offset, size);
      Assert.Equal(expected.BitwiseToDouble(), result);
   }   
   #endregion

   #region single bit operation tests

   [Theory]
   [InlineData(0x00, 0, true,  0x01)]
   [InlineData(0x00, 7, true,  0x80)]
   [InlineData(0xFF, 0, false, 0xFE)]
   [InlineData(0xFF, 7, false, 0x7F)]
   public void StoreBit_For_SByte_Sets_The_Specified_Bit_To_The_Target_Value(uint destination, int offset, bool bit, uint expected)
   {
      var value  = (sbyte) destination;
      var result = value.StoreBit(bit, offset);
      Assert.Equal((sbyte) expected, result);
   }

   [Theory]
   [InlineData(0x00, 0, true,  0x01)]
   [InlineData(0x00, 7, true,  0x80)]
   [InlineData(0xFF, 0, false, 0xFE)]
   [InlineData(0xFF, 7, false, 0x7F)]
   public void StoreBit_For_Byte_Sets_The_Specified_Bit_To_The_Target_Value(uint destination, int offset, bool bit, uint expected)
   {
      var value  = (byte) destination;
      var result = value.StoreBit(bit, offset);
      Assert.Equal((byte) expected, result);
   }

   [Theory]
   [InlineData(0x00,   0,  true,  0x01)]
   [InlineData(0x00,   7,  true,  0x80)]
   [InlineData(0xFF,   0,  false, 0xFE)]
   [InlineData(0xFF,   7,  false, 0x7F)]
   [InlineData(0x0000, 15, true,  0x8000)]
   [InlineData(0xFFFF, 15, false, 0x7FFF)]
   public void StoreBit_For_Int16_Sets_The_Specified_Bit_To_The_Target_Value(uint destination, int offset, bool bit, uint expected)
   {
      var value  = (short) destination;
      var result = value.StoreBit(bit, offset);
      Assert.Equal((short) expected, result);
   }

   [Theory]
   [InlineData(0x00,   0,  true,  0x01)]
   [InlineData(0x00,   7,  true,  0x80)]
   [InlineData(0xFF,   0,  false, 0xFE)]
   [InlineData(0xFF,   7,  false, 0x7F)]
   [InlineData(0x0000, 15, true,  0x8000)]
   [InlineData(0xFFFF, 15, false, 0x7FFF)]
   public void StoreBit_For_UInt16_Sets_The_Specified_Bit_To_The_Target_Value(uint destination, int offset, bool bit, uint expected)
   {
      var value  = (ushort) destination;
      var result = value.StoreBit(bit, offset);
      Assert.Equal((ushort) expected, result);
   }

   [Theory]
   [InlineData(0x00,       0,  true,  0x01)]
   [InlineData(0x00,       7,  true,  0x80)]
   [InlineData(0xFF,       0,  false, 0xFE)]
   [InlineData(0xFF,       7,  false, 0x7F)]
   [InlineData(0x0000,     15, true,  0x8000)]
   [InlineData(0xFFFF,     15, false, 0x7FFF)]
   [InlineData(0x00000000, 31, true,  0x80000000)]
   [InlineData(0xFFFFFFFF, 31, false, 0x7FFFFFFF)]
   public void StoreBit_For_Int32_Sets_The_Specified_Bit_To_The_Target_Value(uint destination, int offset, bool bit, uint expected)
   {
      var value  = (int) destination;
      var result = value.StoreBit(bit, offset);
      Assert.Equal((int) expected, result);
   }

   [Theory]
   [InlineData(0x00,       0,  true,  0x01)]
   [InlineData(0x00,       7,  true,  0x80)]
   [InlineData(0xFF,       0,  false, 0xFE)]
   [InlineData(0xFF,       7,  false, 0x7F)]
   [InlineData(0x0000,     15, true,  0x8000)]
   [InlineData(0xFFFF,     15, false, 0x7FFF)]
   [InlineData(0x00000000, 31, true,  0x80000000)]
   [InlineData(0xFFFFFFFF, 31, false, 0x7FFFFFFF)]
   public void StoreBit_For_UInt32_Sets_The_Specified_Bit_To_The_Target_Value(uint value, int offset, bool bit, uint expected)
   {
      var result = value.StoreBit(bit, offset);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0x00,               0,  true,  0x01)]
   [InlineData(0x00,               7,  true,  0x80)]
   [InlineData(0xFF,               0,  false, 0xFE)]
   [InlineData(0xFF,               7,  false, 0x7F)]
   [InlineData(0x0000,             15, true,  0x8000)]
   [InlineData(0xFFFF,             15, false, 0x7FFF)]
   [InlineData(0x00000000,         31, true,  0x80000000)]
   [InlineData(0xFFFFFFFF,         31, false, 0x7FFFFFFF)]
   [InlineData(0x0000000000000000, 63, true,  0x8000000000000000)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 63, false, 0x7FFFFFFFFFFFFFFF)]
   public void StoreBit_For_Int64_Sets_The_Specified_Bit_To_The_Target_Value(ulong destination, int offset, bool bit, ulong expected)
   {
      var value  = (long) destination;
      var result = value.StoreBit(bit, offset);
      Assert.Equal((long) expected, result);
   }

   [Theory]
   [InlineData(0x00,               0,  true,  0x01)]
   [InlineData(0x00,               7,  true,  0x80)]
   [InlineData(0xFF,               0,  false, 0xFE)]
   [InlineData(0xFF,               7,  false, 0x7F)]
   [InlineData(0x0000,             15, true,  0x8000)]
   [InlineData(0xFFFF,             15, false, 0x7FFF)]
   [InlineData(0x00000000,         31, true,  0x80000000)]
   [InlineData(0xFFFFFFFF,         31, false, 0x7FFFFFFF)]
   [InlineData(0x0000000000000000, 63, true,  0x8000000000000000)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 63, false, 0x7FFFFFFFFFFFFFFF)]
   public void StoreBit_For_UInt64_Sets_The_Specified_Bit_To_The_Target_Value(ulong value, int offset, bool bit, ulong expected)
   {
      var result = value.StoreBit(bit, offset);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0x00,       0,  true,  0x01)]
   [InlineData(0x00,       7,  true,  0x80)]
   [InlineData(0xFF,       0,  false, 0xFE)]
   [InlineData(0xFF,       7,  false, 0x7F)]
   [InlineData(0x0000,     15, true,  0x8000)]
   [InlineData(0xFFFF,     15, false, 0x7FFF)]
   [InlineData(0x00000000, 31, true,  0x80000000)]
   [InlineData(0xFFFFFFFF, 31, false, 0x7FFFFFFF)]
   public void StoreBit_For_Single_Sets_The_Specified_Bit_To_The_Target_Value(uint value, int offset, bool bit, uint expected)
   {
      var result = value.BitwiseToSingle().StoreBit(bit, offset);
      Assert.Equal(expected.BitwiseToSingle(), result);
   }

   [Theory]
   [InlineData(0x00,               0,  true,  0x01)]
   [InlineData(0x00,               7,  true,  0x80)]
   [InlineData(0xFF,               0,  false, 0xFE)]
   [InlineData(0xFF,               7,  false, 0x7F)]
   [InlineData(0x0000,             15, true,  0x8000)]
   [InlineData(0xFFFF,             15, false, 0x7FFF)]
   [InlineData(0x00000000,         31, true,  0x80000000)]
   [InlineData(0xFFFFFFFF,         31, false, 0x7FFFFFFF)]
   [InlineData(0x0000000000000000, 63, true,  0x8000000000000000)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 63, false, 0x7FFFFFFFFFFFFFFF)]
   public void StoreBit_For_Double_Sets_The_Specified_Bit_To_The_Target_Value(ulong value, int offset, bool bit, ulong expected)
   {
      var result = value.BitwiseToDouble().StoreBit(bit, offset);
      Assert.Equal(expected.BitwiseToDouble(), result);
   }   
   #endregion
}
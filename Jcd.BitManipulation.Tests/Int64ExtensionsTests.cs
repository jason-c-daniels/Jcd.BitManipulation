#region

using System;
using System.Collections.Generic;

using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests;

public class Int64ExtensionsTests
{
   [Theory]
   [InlineData(0,     ulong.MaxValue, false)]
   [InlineData(0b11,  ulong.MaxValue, true)]
   [InlineData(0b100, 0b10,           false)]
   [InlineData(0b011, 0b10,           true)]
   public void AreAnyBitsSet_On_An_Int64_Returns_The_Expected_Result(long data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAnyBitsSet(mask));
   }

   [Theory]
   [InlineData(0,    ulong.MaxValue, false)]
   [InlineData(0b11, ulong.MaxValue, false)]
   [InlineData(0b10, 0b10,           true)]
   [InlineData(0b11, 0b10,           true)]
   public void AreAllBitsSet_On_An_Int64_Returns_The_Expected_Result(long data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAllBitsSet(mask));
   }

   [Theory]
   [InlineData(0,    ulong.MaxValue, true)]
   [InlineData(0b11, ulong.MaxValue, false)]
   [InlineData(0b10, 0b10,           false)]
   [InlineData(0b11, 0b10,           false)]
   public void AreNoBitsSet_On_An_Int64_Returns_The_Expected_Result(long data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreNoBitsSet(mask));
   }

   [Theory]
   [InlineData(0b11111111,                             0,  2, 0b11111100)] // clear lower 2 bits
   [InlineData(0b11111111,                             4,  2, 0b11001111)] // clear middle 2 bits of lower byte
   [InlineData(0b11111111,                             6,  2, 0b00111111)] // clear upper 2 bits of lower byte
   [InlineData(0b111111111111,                         8,  2, 0b110011111111)]
   [InlineData(0b00111111111111111111111111111111,     26, 2, 0b00110011111111111111111111111111)]
   [InlineData(0b111111111111111111111111111111111111, 32, 2, 0b110011111111111111111111111111111111)]
   public void ClearBits_On_Int64_Clears_The_Correct_Bits(ulong initial, int offset, int size, ulong expected)
   {
      var value = (long) initial; // coerce to proper type
      var result = value.ClearBits((byte) offset, (byte) size);
      Assert.Equal((long) expected, result);
   }

   [Theory]
   [InlineData(0xFFFFFFFFFFFFFFFF, 0,  0xFFFFFFFFFFFFFFFE)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 4,  0xFFFFFFFFFFFFFFEF)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 15, 0xFFFFFFFFFFFF7FFF)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 31, 0xFFFFFFFF7FFFFFFF)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 63, 0x7FFFFFFFFFFFFFFF)]
   public void ClearBit_On_Int64_Clears_Correct_Bit(ulong initial, int bitToClear, ulong expected)
   {
      var value = (long) initial;
      var result = value.ClearBit((byte) bitToClear);
      Assert.Equal((long) expected, result);
   }

   [Theory]
   [InlineData(0b11111111,                         0b0000110,                          0b11111001)]
   [InlineData(0b10111111,                         0b0000100,                          0b10111011)]
   [InlineData(0b1111111111111111,                 0b0100000000000110,                 0b1011111111111001)]
   [InlineData(0b1111111110111111,                 0b0100000000000100,                 0b1011111110111011)]
   [InlineData(0b11111111111111111111111111111111, 0b00100001000000000100000000000110, 0b11011110111111111011111111111001)]
   [InlineData(0b1111111111111111111111111111111111111111111111111111111111111111
             , 0b0000010000000000000000000000000000100001000000000100000000000110
             , 0b1111101111111111111111111111111111011110111111111011111111111001
              )]
   public void ClearBits_For_Int64_When_Given_A_Mask_Directly_Clears_Only_The_Specified_Bits(ulong initialValue, ulong maskValue, ulong expected)
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var value = (long) initialValue;
      var mask = new BitMask((long) maskValue);
      var result = value.ClearBits(mask);
      Assert.Equal((long) expected, result);
   }

   [Theory]
   [InlineData(0x00, 0,  2,  0x03)]
   [InlineData(0x00, 6,  2,  0b11000000)]
   [InlineData(0x00, 0,  8,  0xFF)]
   [InlineData(0x00, 12, 2,  0b0011000000000000)]
   [InlineData(0x00, 0,  16, 0xFFFF)]
   [InlineData(0x00, 28, 2,  0b00110000000000000000000000000000)]
   [InlineData(0x00, 0,  32, 0xFFFFFFFF)]
   [InlineData(0x00, 60, 2,  0b0011000000000000000000000000000000000000000000000000000000000000)]
   [InlineData(0x00, 0,  64, 0xFFFFFFFFFFFFFFFF)]
   public void SetBits_On_Int64_Sets_The_Correct_Bits(ulong initial, int offset, int size, ulong expected)
   {
      var value = (long) initial; // coerce to proper type
      var result = value.SetBits((byte) offset, (byte) size);
      Assert.Equal((long) expected, result);
   }

   [Theory]
   [InlineData(0x00, 3,  0x08)]
   [InlineData(0x80, 3,  0x88)]
   [InlineData(0x00, 7,  0x80)]
   [InlineData(0x00, 8,  0x0100)]
   [InlineData(0x80, 8,  0x0180)]
   [InlineData(0x00, 15, 0x8000)]
   [InlineData(0x80, 16, 0x00010080)]
   [InlineData(0x00, 31, 0x80000000)]
   [InlineData(0x80, 32, 0x0000000100000080)]
   [InlineData(0x00, 63, 0x8000000000000000)]
   public void SetBit_On_Int64_Sets_Correct_Bit(ulong initial, int bitToSet, ulong expected)
   {
      var value = (long) initial;
      var result = value.SetBit((byte) bitToSet);
      Assert.Equal((long) expected, result);
   }

   [Theory]
   [InlineData(0x00,               0x03,               0x03)]
   [InlineData(0x80,               0x03,               0x83)]
   [InlineData(0x0000,             0x0300,             0x0300)]
   [InlineData(0x8000,             0x0300,             0x8300)]
   [InlineData(0x00000000,         0x03000000,         0x03000000)]
   [InlineData(0x80000000,         0x03000000,         0x83000000)]
   [InlineData(0x0000000000000000, 0x0300000000000000, 0x0300000000000000)]
   [InlineData(0x8000000000000000, 0x0300000000000000, 0x8300000000000000)]
   public void SetBits_For_Int64_When_Given_A_Mask_Directly_Sets_Only_The_Specified_Bits(ulong initialValue, ulong maskValue, ulong expected)
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var value = (long) initialValue;
      var mask = new BitMask((long) maskValue);
      var result = value.SetBits(mask);
      Assert.Equal((long) expected, result);
   }

   [Theory]
   [InlineData(0xFF,               0,  2, 0x03)]
   [InlineData(0b11100000,         6,  2, 0b11)]
   [InlineData(0b11100000,         4,  2, 0b10)]
   [InlineData(0xFF,               0,  8, 0xFF)]
   [InlineData(0x3F,               4,  4, 0x03)]
   [InlineData(0x300F,             12, 4, 0x03)]
   [InlineData(0xF00F,             14, 2, 0x03)]
   [InlineData(0x3000000F,         28, 4, 0x03)]
   [InlineData(0xF000000F,         30, 2, 0x03)]
   [InlineData(0x300000000000000F, 60, 4, 0x03)]
   [InlineData(0xF00000000000000F, 62, 2, 0x03)]
   public void ReadBits_On_Int64_Reads_The_Correct_Bits(ulong initial, int offset, int size, ulong expected)
   {
      var bits = (long) initial; // coerce to proper type
      var value = bits.ReadBits(offset, size);
      Assert.Equal((long) expected, value);
      value = bits.ReadBits(BitMask.FromRange(offset, size));
      Assert.Equal((long) (expected << offset), value);
   }

   [Theory]
   [InlineData(0b11100111,               0,  true)]
   [InlineData(0b11100111,               3,  false)]
   [InlineData(0b11100111,               7,  true)]
   [InlineData(0b11100111         << 8,  11, false)]
   [InlineData(0b11100111         << 8,  15, true)]
   [InlineData((uint) 0b11100111  << 24, 27, false)]
   [InlineData((uint) 0b11100111  << 24, 31, true)]
   [InlineData((ulong) 0b11100111 << 56, 59, false)]
   [InlineData((ulong) 0b11100111 << 56, 63, true)]
   public void ReadBit_For_Int64_Reads_The_Correct_Value(ulong bits, int offset, bool expected)
   {
      Assert.Equal(expected, ((long) bits).ReadBit((byte) offset));
   }

   [Theory]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 0xF8, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 1, 0xF9, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 2, 0xFA, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 0xFB, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 0xFC, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 0xFD, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 0xFE, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 7, 0xFF, Endian.Little)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 7, 0xF8, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 0xF9, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 0xFA, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 0xFB, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 0xFC, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 2, 0xFD, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 1, 0xFE, Endian.Big)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 0xFF, Endian.Big)]
   public void ReadByte_On_Int64_Returns_Expected_Value(ulong data, int offset, byte expected, Endian endian)
   {
      var ldata = (long) data;
      Assert.Equal(expected, ldata.ReadByte(offset, endian));
   }

   [Theory]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 0, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 3, 4)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 4, 3)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 5, 2)]
   [InlineData(0xFF_FE_FD_FC_FB_FA_F9_F8, 6, 2)]
   public void ReadBytes_On_Int64_Returns_Expected_Array(ulong data, int offset, int size)
   {
      var ldata = (long) data;
      var expected = new List<byte>();

      for (var i = 0; i < size; i++)
      {
         expected.Add(ldata.ReadByte(i + offset));
      }

      Assert.Equal(expected.ToArray(), ldata.ReadBytes(offset, size));
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
      var value = (long) val;
      var result = destination.StoreBits(value, offset, size);
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
   public void StoreBit_For_Int64_Sets_The_Specified_Bit_To_The_Target_Value(ulong destination, int offset, bool bit, ulong expected)
   {
      var value = (long) destination;
      var result = value.StoreBit(bit, offset);
      Assert.Equal((long) expected, result);
   }

   [Theory]
   [InlineData(0, (byte) 0x01, 0, 0x00_00_00_00_00_00_00_01L, Endian.Little)]
   [InlineData(0, (byte) 0x02, 1, 0x00_00_00_00_00_00_02_00L, Endian.Little)]
   [InlineData(0, (byte) 0xFF, 2, 0x00_00_00_00_00_FF_00_00L, Endian.Little)]
   [InlineData(0, (byte) 0xFE, 3, 0x00_00_00_00_FE_00_00_00L, Endian.Little)]
   [InlineData(0, (byte) 0xFD, 4, 0x00_00_00_FD_00_00_00_00L, Endian.Little)]
   [InlineData(0, (byte) 0xFC, 5, 0x00_00_FC_00_00_00_00_00L, Endian.Little)]
   [InlineData(0, (byte) 0xFB, 6, 0x00_FB_00_00_00_00_00_00L, Endian.Little)]
   [InlineData(0, (byte) 0xFA, 7, 0xFA_00_00_00_00_00_00_00L, Endian.Little)]
   [InlineData(0, (byte) 0x01, 7, 0x00_00_00_00_00_00_00_01L, Endian.Big)]
   [InlineData(0, (byte) 0x02, 6, 0x00_00_00_00_00_00_02_00L, Endian.Big)]
   [InlineData(0, (byte) 0xFF, 5, 0x00_00_00_00_00_FF_00_00L, Endian.Big)]
   [InlineData(0, (byte) 0xFE, 4, 0x00_00_00_00_FE_00_00_00L, Endian.Big)]
   [InlineData(0, (byte) 0xFD, 3, 0x00_00_00_FD_00_00_00_00L, Endian.Big)]
   [InlineData(0, (byte) 0xFC, 2, 0x00_00_FC_00_00_00_00_00L, Endian.Big)]
   [InlineData(0, (byte) 0xFB, 1, 0x00_FB_00_00_00_00_00_00L, Endian.Big)]
   [InlineData(0, (byte) 0xFA, 0, 0xFA_00_00_00_00_00_00_00L, Endian.Big)]
   public void StoreByte_On_Int64_Returns_Expected_Value(long value, byte data, int offset, ulong expected, Endian endian)
   {
      Assert.Equal((long) expected, value.StoreByte(data, offset, endian));
   }

   [Theory]
   [MemberData(nameof(Int64StoreBytesWithEndian))]
   public void StoreBytes_For_A_Byte_Array_On_Int64_Returns_Expected_Value(long data, int offset, int size, byte[] bytes, Endian endian)
   {
      var expected = data;

      for (var i = 0; i < size && i + offset < sizeof(long); i++)
      {
         expected = expected.StoreByte(bytes[i], offset + i, endian);
      }

      var actual = data.StoreBytes(bytes, offset, size, endian);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(Int64StoreBytesWithEndian))]
   public void StoreBytes_For_A_ReadOnlySpan_On_Int64_Returns_Expected_Value(long data, int offset, int size, byte[] bytes, Endian endian)
   {
      var expected = data;

      for (var i = 0; i < size && i + offset < sizeof(long); i++)
      {
         expected = expected.StoreByte(bytes[i], offset + i, endian);
      }

      var actual = data.StoreBytes((ReadOnlySpan<byte>) bytes, offset, size, endian);
      Assert.Equal(expected, actual);
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
      var value = (long) initial; // coerce to proper type
      var result = value.ToggleBits((byte) offset, (byte) size);
      Assert.Equal((long) expected, result);
   }

   [Theory]
   [InlineData(0xFFFFFFFFFFFFFFFF, 0,  0xFFFFFFFFFFFFFFFE)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 4,  0xFFFFFFFFFFFFFFEF)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 15, 0xFFFFFFFFFFFF7FFF)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 31, 0xFFFFFFFF7FFFFFFF)]
   [InlineData(0xFFFFFFFFFFFFFFFF, 63, 0x7FFFFFFFFFFFFFFF)]
   public void ToggleBit_On_Int64_Toggles_Correct_Bit(ulong initial, int bitToToggle, ulong expected)
   {
      var value = (long) initial;
      var result = value.ToggleBit((byte) bitToToggle);
      Assert.Equal((long) expected, result);
   }

   [Theory]
   [InlineData(0b11111111,         0b0000110,          0b11111001)]
   [InlineData(0b10111111,         0b0000100,          0b10111011)]
   [InlineData(0b1111111111111111, 0b0100000000000110, 0b1011111111111001)]
   [InlineData(0b1111111110111111, 0b0100000000000100, 0b1011111110111011)]
   public void ToggleBits_For_Int16_When_Given_A_Mask_Directly_Toggles_Only_The_Specified_Bits(uint initialValue, uint maskValue, uint expected)
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var value = (short) initialValue;
      var mask = new BitMask((short) maskValue);
      var result = value.ToggleBits(mask);
      Assert.Equal((short) expected, result);
   }

   [Theory]
   [InlineData(0b11111111,                         0b0000110,                          0b11111001)]
   [InlineData(0b10111111,                         0b0000100,                          0b10111011)]
   [InlineData(0b1111111111111111,                 0b0100000000000110,                 0b1011111111111001)]
   [InlineData(0b1111111110111111,                 0b0100000000000100,                 0b1011111110111011)]
   [InlineData(0b11111111111111111111111111111111, 0b00100001000000000100000000000110, 0b11011110111111111011111111111001)]
   [InlineData(0b1111111111111111111111111111111111111111111111111111111111111111
             , 0b0000010000000000000000000000000000100001000000000100000000000110
             , 0b1111101111111111111111111111111111011110111111111011111111111001
              )]
   public void ToggleBits_For_Int64_When_Given_A_Mask_Directly_Toggles_Only_The_Specified_Bits(ulong initialValue, ulong maskValue, ulong expected)
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var value = (long) initialValue;
      var mask = new BitMask((long) maskValue);
      var result = value.ToggleBits(mask);
      Assert.Equal((long) expected, result);
   }

   [Theory]
   [InlineData(0x0807060504030201, Endian.Little, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08)]
   [InlineData(0x0807060504030201, Endian.Big,    0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01)]
   public void ToByteArray_On_Int64_Returns_Expected_Value(long data, Endian endian, byte e0, byte e1, byte e2, byte e3, byte e4, byte e5, byte e6, byte e7)
   {
      var expected = new[] { e0, e1, e2, e3, e4, e5, e6, e7 };
      Assert.Equal(expected, data.ToByteArray(endian));
   }

   #region DataMember Data Providers

   public static IEnumerable<object[]> UInt64StoreBytes
      => new List<object[]>
         {
            new object[] { 0xFF_00_00_00_00_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE } }
          , new object[] { 0xFE_00_00_00_00_00_00_00, 1, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0xFE_00_00_00_00_00_20_00, 3, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 4, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 5, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 8, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 8, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
         };

   public static IEnumerable<object[]> Int64StoreBytes
      => new List<object[]>
         {
            new object[] { 0x0F_00_00_00_00_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE } }
          , new object[] { 0x0E_00_00_00_00_00_00_00, 1, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0x0E_00_00_00_00_00_20_00, 3, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 4, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 5, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 8, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 8, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
         };

   public static IEnumerable<object[]> UInt32StoreBytes
      => new List<object[]>
         {
            new object[] { 0xFF_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE } }
          , new object[] { 0xFE_00_00_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0xFE_00_00_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0xFE_00_00_00, 3, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0xFE_00_00_00, 4, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0xFE_00_00_00, 4, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
         };

   public static IEnumerable<object[]> Int32StoreBytes
      => new List<object[]>
         {
            new object[] { 0x0F_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE } }
          , new object[] { 0x0E_00_00_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0x0E_00_00_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { 0x0E_00_00_00, 3, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0x0E_00_00_00, 4, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
          , new object[] { 0x0E_00_00_00, 4, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D } }
         };

   public static IEnumerable<object[]> UInt16StoreBytes
      => new List<object[]>
         {
            new object[] { (ushort) 0xFF_00, 0, 2, new byte[] { 0xFF, 0xFE } }
          , new object[] { (ushort) 0xFE_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { (ushort) 0xFE_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { (ushort) 0xFE_00, 2, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
         };

   public static IEnumerable<object[]> Int16StoreBytes
      => new List<object[]>
         {
            new object[] { (short) 0x0F_00, 0, 2, new byte[] { 0xFF, 0xFE } }
          , new object[] { (short) 0x0E_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { (short) 0x0E_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
          , new object[] { (short) 0x0E_00, 2, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB } }
         };

   #endregion

   #region DataMember Data Providers With Endian

   public static IEnumerable<object[]> UInt64StoreBytesWithEndian
      => new List<object[]>
         {
            new object[] { 0xFF_00_00_00_00_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE }, Endian.Little }
          , new object[] { 0xFE_00_00_00_00_00_00_00, 1, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Little }
          , new object[] { 0xFE_00_00_00_00_00_20_00, 3, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Little }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 4, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Little }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 5, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Little }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 8, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Little }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 8, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Little }
          , new object[] { 0xFF_00_00_00_00_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE }, Endian.Big }
          , new object[] { 0xFE_00_00_00_00_00_00_00, 1, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Big }
          , new object[] { 0xFE_00_00_00_00_00_20_00, 3, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Big }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 4, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Big }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 5, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Big }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 8, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Big }
          , new object[] { 0xFE_00_00_00_00_00_00_01, 8, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Big }
         };

   public static IEnumerable<object[]> Int64StoreBytesWithEndian
      => new List<object[]>
         {
            new object[] { 0x0F_00_00_00_00_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE }, Endian.Little }
          , new object[] { 0x0E_00_00_00_00_00_00_00, 1, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Little }
          , new object[] { 0x0E_00_00_00_00_00_20_00, 3, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Little }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 4, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Little }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 5, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Little }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 8, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Little }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 8, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Little }
          , new object[] { 0x0F_00_00_00_00_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE }, Endian.Big }
          , new object[] { 0x0E_00_00_00_00_00_00_00, 1, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Big }
          , new object[] { 0x0E_00_00_00_00_00_20_00, 3, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Big }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 4, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Big }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 5, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Big }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 8, 4, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Big }
          , new object[] { 0x0E_00_00_00_00_00_00_01, 8, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Big }
         };

   public static IEnumerable<object[]> UInt32StoreBytesWithEndian
      => new List<object[]>
         {
            new object[] { 0xFF_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE }, Endian.Little }
          , new object[] { 0xFE_00_00_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Little }
          , new object[] { 0xFE_00_00_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Little }
          , new object[] { 0xFE_00_00_00, 3, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Little }
          , new object[] { 0xFE_00_00_00, 4, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Little }
          , new object[] { 0xFE_00_00_00, 4, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Little }
          , new object[] { 0xFF_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE }, Endian.Big }
          , new object[] { 0xFE_00_00_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Big }
          , new object[] { 0xFE_00_00_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Big }
          , new object[] { 0xFE_00_00_00, 3, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Big }
          , new object[] { 0xFE_00_00_00, 4, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Big }
          , new object[] { 0xFE_00_00_00, 4, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Big }
         };

   public static IEnumerable<object[]> Int32StoreBytesWithEndian
      => new List<object[]>
         {
            new object[] { 0x0F_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE }, Endian.Little }
          , new object[] { 0x0E_00_00_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Little }
          , new object[] { 0x0E_00_00_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Little }
          , new object[] { 0x0E_00_00_00, 3, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Little }
          , new object[] { 0x0E_00_00_00, 4, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Little }
          , new object[] { 0x0E_00_00_00, 4, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Little }
          , new object[] { 0x0F_00_00_00, 0, 2, new byte[] { 0xFF, 0xFE }, Endian.Big }
          , new object[] { 0x0E_00_00_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Big }
          , new object[] { 0x0E_00_00_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Big }
          , new object[] { 0x0E_00_00_00, 3, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Big }
          , new object[] { 0x0E_00_00_00, 4, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Big }
          , new object[] { 0x0E_00_00_00, 4, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB, 0x0C, 0x0D }, Endian.Big }
         };

   public static IEnumerable<object[]> UInt16StoreBytesWithEndian
      => new List<object[]>
         {
            new object[] { (ushort) 0xFF_00, 0, 2, new byte[] { 0xFF, 0xFE }, Endian.Little }
          , new object[] { (ushort) 0xFE_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Little }
          , new object[] { (ushort) 0xFE_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Little }
          , new object[] { (ushort) 0xFE_00, 2, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Little }
          , new object[] { (ushort) 0xFF_00, 0, 2, new byte[] { 0xFF, 0xFE }, Endian.Big }
          , new object[] { (ushort) 0xFE_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Big }
          , new object[] { (ushort) 0xFE_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Big }
          , new object[] { (ushort) 0xFE_00, 2, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Big }
         };

   public static IEnumerable<object[]> Int16StoreBytesWithEndian
      => new List<object[]>
         {
            new object[] { (short) 0x0F_00, 0, 2, new byte[] { 0xFF, 0xFE }, Endian.Little }
          , new object[] { (short) 0x0E_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Little }
          , new object[] { (short) 0x0E_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Little }
          , new object[] { (short) 0x0E_00, 2, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Little }
          , new object[] { (short) 0x0F_00, 0, 2, new byte[] { 0xFF, 0xFE }, Endian.Big }
          , new object[] { (short) 0x0E_00, 1, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Big }
          , new object[] { (short) 0x0E_00, 2, 2, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Big }
          , new object[] { (short) 0x0E_00, 2, -1, new byte[] { 0xAF, 0xEE, 0xFA, 0xBB }, Endian.Big }
         };

   #endregion
}
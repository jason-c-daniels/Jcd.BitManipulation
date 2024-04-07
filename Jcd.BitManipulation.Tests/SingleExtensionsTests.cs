﻿#region

using System;
using System.Collections.Generic;

using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests;

public class SingleExtensionsTests
{
   [Theory]
   [InlineData(0,     ulong.MaxValue, false)]
   [InlineData(0b11,  ulong.MaxValue, true)]
   [InlineData(0b100, 0b10,           false)]
   [InlineData(0b011, 0b10,           true)]
   public void AreAnyBitsSet_Returns_The_Expected_Result(uint data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.BitwiseToSingle().AreAnyBitsSet(mask));
   }

   [Theory]
   [InlineData(0,    ulong.MaxValue, false)]
   [InlineData(0b11, ulong.MaxValue, false)]
   [InlineData(0b10, 0b10,           true)]
   [InlineData(0b11, 0b10,           true)]
   public void AreAllBits_Returns_The_Expected_Result(uint data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.BitwiseToSingle().AreAllBitsSet(mask));
   }

   [Theory]
   [InlineData(0,    ulong.MaxValue, true)]
   [InlineData(0b11, ulong.MaxValue, false)]
   [InlineData(0b10, 0b10,           false)]
   [InlineData(0b11, 0b10,           false)]
   public void AreNoBitsSet_Returns_The_Expected_Result(uint data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.BitwiseToSingle().AreNoBitsSet(mask));
   }

   [Theory]
   [InlineData(0b11111111,                         0,  2, 0b11111100)] // clear lower 2 bits
   [InlineData(0b11111111,                         4,  2, 0b11001111)] // clear middle 2 bits of lower byte
   [InlineData(0b11111111,                         6,  2, 0b00111111)] // clear upper 2 bits of lower byte
   [InlineData(0b111111111111,                     8,  2, 0b110011111111)]
   [InlineData(0b11111111111111111111111111111111, 26, 2, 0b11110011111111111111111111111111)]
   public void ClearBits_Clears_The_Correct_Bits(uint value, int offset, int size, uint expected)
   {
      var result = value.BitwiseToSingle().ClearBits((byte) offset, (byte) size);
      Assert.Equal(expected.BitwiseToSingle(), result);
   }

   [Theory]
   [InlineData(0xFFFFFFFF, 0,  0xFFFFFFFE)]
   [InlineData(0xFFFFFFFF, 4,  0xFFFFFFEF)]
   [InlineData(0xFFFFFFFF, 15, 0xFFFF7FFF)]
   [InlineData(0xFFFFFFFF, 31, 0x7FFFFFFF)]
   public void ClearBit_Clears_Correct_Bit(uint value, int bitToClear, uint expected)
   {
      var result = value.BitwiseToSingle().ClearBit((byte) bitToClear);
      Assert.Equal(expected.BitwiseToSingle(), result);
   }

   [Theory]
   [InlineData(0b11111111,                         0b0000110,                          0b11111001)]
   [InlineData(0b10111111,                         0b0000100,                          0b10111011)]
   [InlineData(0b1111111111111111,                 0b0100000000000110,                 0b1011111111111001)]
   [InlineData(0b1111111110111111,                 0b0100000000000100,                 0b1011111110111011)]
   [InlineData(0b11111111111111111111111111111111, 0b00100001000000000100000000000110, 0b11011110111111111011111111111001)]
   public void ClearBits_When_Given_A_Mask_Directly_Clears_Only_The_Specified_Bits(uint initialValue, uint maskValue, uint expected)
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var mask = (BitMask) maskValue;
      var result = initialValue.BitwiseToSingle().ClearBits(mask);
      Assert.Equal(expected.BitwiseToSingle(), result);
   }

   [Theory]
   [InlineData(0x00, 0,  2,  0x03)]
   [InlineData(0x00, 6,  2,  0b11000000)]
   [InlineData(0x00, 0,  8,  0xFF)]
   [InlineData(0x00, 12, 2,  0b0011000000000000)]
   [InlineData(0x00, 0,  16, 0xFFFF)]
   [InlineData(0x00, 28, 2,  0b00110000000000000000000000000000)]
   [InlineData(0x00, 0,  32, 0xFFFFFFFF)]
   public void SetBits_Sets_The_Correct_Bits(uint value, int offset, int size, uint expected)
   {
      var result = value.BitwiseToSingle().SetBits((byte) offset, (byte) size);
      Assert.Equal(expected.BitwiseToSingle(), result);
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
   public void SetBit_Sets_Correct_Bit(ulong initial, int bitToSet, uint expected)
   {
      var value = (uint) initial;
      var result = value.BitwiseToSingle().SetBit((byte) bitToSet);
      Assert.Equal(expected.BitwiseToSingle(), result);
   }

   [Theory]
   [InlineData(0x00,       0x03,       0x03)]
   [InlineData(0x80,       0x03,       0x83)]
   [InlineData(0x0000,     0x0300,     0x0300)]
   [InlineData(0x8000,     0x0300,     0x8300)]
   [InlineData(0x00000000, 0x03000000, 0x03000000)]
   [InlineData(0x80000000, 0x03000000, 0x83000000)]
   public void SetBits_When_Given_A_Mask_Directly_Sets_Only_The_Specified_Bits(uint uiInitialValue, uint maskValue, uint uiExpected)
   {
      var initialValue = uiInitialValue.BitwiseToSingle();
      var expected = uiExpected.BitwiseToSingle();
      var mask = new BitMask(maskValue);
      var result = initialValue.SetBits(mask);
      Assert.Equal(expected, result);
   }

   [Theory]
   [InlineData(0xFF,       0,  2, 0x03)]
   [InlineData(0b11100000, 6,  2, 0b11)]
   [InlineData(0b11100000, 4,  2, 0b10)]
   [InlineData(0xFF,       0,  8, 0xFF)]
   [InlineData(0x3F,       4,  4, 0x03)]
   [InlineData(0x300F,     12, 4, 0x03)]
   [InlineData(0xF00F,     14, 2, 0x03)]
   [InlineData(0x3000000F, 28, 4, 0x03)]
   [InlineData(0xF000000F, 30, 2, 0x03)]
   public void ReadBits_Reads_The_Correct_Bits(uint initial, int offset, int size, uint expected)
   {
      var bits = initial.BitwiseToSingle();
      var value = bits.ReadBits(offset, size);
      Assert.Equal(expected, value);
      value = bits.ReadBits(BitMask.FromRange(offset, size));
      Assert.Equal((expected << offset), value);
   }

   [Theory]
   [InlineData(0b11100111,              0,  true)]
   [InlineData(0b11100111,              3,  false)]
   [InlineData(0b11100111,              7,  true)]
   [InlineData(0b11100111        << 8,  11, false)]
   [InlineData(0b11100111        << 8,  15, true)]
   [InlineData((uint) 0b11100111 << 24, 27, false)]
   [InlineData((uint) 0b11100111 << 24, 31, true)]
   public void ReadBit_Reads_The_Correct_Value(uint bits, int offset, bool expected)
   {
      Assert.Equal(expected, bits.BitwiseToSingle().ReadBit((byte) offset));
   }

   [Theory]
   [InlineData(0xFB_FA_F9_F8, 0, 0xF8, Endian.Little)]
   [InlineData(0xFB_FA_F9_F8, 1, 0xF9, Endian.Little)]
   [InlineData(0xFB_FA_F9_F8, 2, 0xFA, Endian.Little)]
   [InlineData(0xFB_FA_F9_F8, 3, 0xFB, Endian.Little)]
   [InlineData(0xFB_FA_F9_F8, 3, 0xF8, Endian.Big)]
   [InlineData(0xFB_FA_F9_F8, 2, 0xF9, Endian.Big)]
   [InlineData(0xFB_FA_F9_F8, 1, 0xFA, Endian.Big)]
   [InlineData(0xFB_FA_F9_F8, 0, 0xFB, Endian.Big)]
   public void ReadByte_Returns_Expected_Value(uint data, int offset, byte expected, Endian endian)
   {
      Assert.Equal(expected, data.BitwiseToSingle().ReadByte(offset, endian));
   }

   [Theory]
   [InlineData(0xFB_FA_F9_F8, 0, 4, Endian.Little)]
   [InlineData(0xFB_FA_F9_F8, 1, 3, Endian.Little)]
   [InlineData(0xFB_FA_F9_F8, 2, 2, Endian.Little)]
   [InlineData(0xFB_FA_F9_F8, 0, 3, Endian.Little)]
   [InlineData(0xFB_FA_F9_F8, 0, 4, Endian.Big)]
   [InlineData(0xFB_FA_F9_F8, 1, 3, Endian.Big)]
   [InlineData(0xFB_FA_F9_F8, 2, 2, Endian.Big)]
   [InlineData(0xFB_FA_F9_F8, 0, 3, Endian.Big)]
   public void ReadBytes_Returns_Expected_Array(uint data, int offset, int size, Endian endian)
   {
      var expected = new List<byte>();

      for (var i = 0; i < size; i++)
      {
         expected.Add(data.ReadByte(i + offset, endian));
      }

      Assert.Equal(expected.ToArray(), data.BitwiseToSingle().ReadBytes(offset, size, endian));
   }

   [Theory]
   [InlineData(0x00,   0xFF,   0, 2,  0x03)]
   [InlineData(0x00,   0xFF,   6, 2,  0b11000000)]
   [InlineData(0x00,   0xFF,   0, 8,  0xFF)]
   [InlineData(0xF0,   0x03,   0, 4,  0xF3)]
   [InlineData(0x0000, 0xFFFF, 0, 16, 0xFFFF)]
   [InlineData(0xF000, 0x03,   0, 8,  0xF003)]
   public void StoreBits_Stores_The_Correct_Bits(uint initial, uint val, int offset, int size, uint expected)
   {
      var result = initial.BitwiseToSingle().StoreBits(val, offset, size);
      Assert.Equal(expected.BitwiseToSingle(), result);
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
   public void StoreBit_Sets_The_Specified_Bit_To_The_Target_Value(uint value, int offset, bool bit, uint expected)
   {
      var result = value.BitwiseToSingle().StoreBit(bit, offset);
      Assert.Equal(expected.BitwiseToSingle(), result);
   }

   [Theory]
   [InlineData(0, (byte) 0x01, 0, 0x00_00_00_01, Endian.Little)]
   [InlineData(0, (byte) 0x02, 1, 0x00_00_02_00, Endian.Little)]
   [InlineData(0, (byte) 0xFF, 2, 0x00_FF_00_00, Endian.Little)]
   [InlineData(0, (byte) 0xFE, 3, 0xFE_00_00_00, Endian.Little)]
   [InlineData(0, (byte) 0x01, 0, 0x01_00_00_00, Endian.Big)]
   [InlineData(0, (byte) 0x02, 1, 0x00_02_00_00, Endian.Big)]
   [InlineData(0, (byte) 0xFF, 2, 0x00_00_FF_00, Endian.Big)]
   [InlineData(0, (byte) 0xFE, 3, 0x00_00_00_FE, Endian.Big)]
   public void StoreByte_Returns_Expected_Value(uint value, byte data, int offset, uint expected, Endian endian)
   {
      Assert.Equal(expected.BitwiseToSingle(), value.BitwiseToSingle().StoreByte(data, offset, endian));
   }

   [Theory]
   [MemberData(nameof(UInt32StoreBytesWithEndian))]
   public void StoreBytes_From_Byte_Array_Returns_Expected_Value(uint data, int offset, int size, byte[] bytes, Endian endian)
   {
      var expected = data.BitwiseToSingle();

      for (var i = 0; i < size && i + offset < sizeof(uint); i++)
      {
         expected = expected.StoreByte(bytes[i], offset + i, endian);
      }

      var actual = data.BitwiseToSingle().StoreBytes(bytes, offset, size, endian);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [MemberData(nameof(UInt32StoreBytesWithEndian))]
   public void StoreBytes_From_ReadOnlySpan_Returns_Expected_Value(uint data, int offset, int size, byte[] bytes, Endian endian)
   {
      var expected = data.BitwiseToSingle();

      for (var i = 0; i < size && i + offset < sizeof(uint); i++)
      {
         expected = expected.StoreByte(bytes[i], offset + i, endian);
      }

      var actual = data.BitwiseToSingle().StoreBytes((ReadOnlySpan<byte>) bytes, offset, size, endian);
      Assert.Equal(expected, actual);
   }

   [Theory]
   [InlineData(0b11111111,                         0,  2, 0b11111100)] // toggle lower 2 bits
   [InlineData(0b11111111,                         4,  2, 0b11001111)] // toggle middle 2 bits of lower byte
   [InlineData(0b11111111,                         6,  2, 0b00111111)] // toggle upper 2 bits of lower byte
   [InlineData(0b111111111111,                     8,  2, 0b110011111111)]
   [InlineData(0b11111111111111111111111111111111, 26, 2, 0b11110011111111111111111111111111)]
   public void ToggleBits_Toggles_The_Correct_Bits(uint value, int offset, int size, uint expected)
   {
      var result = value.BitwiseToSingle().ToggleBits((byte) offset, (byte) size);
      Assert.Equal(expected.BitwiseToSingle(), result);
   }

   [Theory]
   [InlineData(0xFFFFFFFF, 0,  0xFFFFFFFE)]
   [InlineData(0xFFFFFFFF, 4,  0xFFFFFFEF)]
   [InlineData(0xFFFFFFFF, 15, 0xFFFF7FFF)]
   [InlineData(0xFFFFFFFF, 31, 0x7FFFFFFF)]
   public void ToggleBit_Toggles_Correct_Bit(uint value, int bitToToggle, uint expected)
   {
      var result = value.BitwiseToSingle().ToggleBit((byte) bitToToggle);
      Assert.Equal(expected.BitwiseToSingle(), result);
   }

   [Theory]
   [InlineData(0b11111111,                         0b0000110,                          0b11111001)]
   [InlineData(0b10111111,                         0b0000100,                          0b10111011)]
   [InlineData(0b1111111111111111,                 0b0100000000000110,                 0b1011111111111001)]
   [InlineData(0b1111111110111111,                 0b0100000000000100,                 0b1011111110111011)]
   [InlineData(0b11111111111111111111111111111111, 0b00100001000000000100000000000110, 0b11011110111111111011111111111001)]
   public void ToggleBits_When_Given_A_Mask_Directly_Toggles_Only_The_Specified_Bits(uint initialValue, uint maskValue, uint expected)
   {
      // forcibly cast so that guarantee the proper data size, and so that the xUnit data binder can bind the values to the params.
      var mask = new BitMask(maskValue);
      var result = initialValue.BitwiseToSingle().ToggleBits(mask);
      Assert.Equal(expected.BitwiseToSingle(), result);
   }

   [Theory]
   [InlineData(0x04030201, Endian.Little, 0x01, 0x02, 0x03, 0x04)]
   [InlineData(0x04030201, Endian.Big,    0x04, 0x03, 0x02, 0x01)]
   public void ToByteArray_Returns_Expected_Value(uint data, Endian endian, byte e0, byte e1, byte e2, byte e3)
   {
      var expected = new[] { e0, e1, e2, e3 };
      Assert.Equal(expected, data.BitwiseToSingle().ToByteArray(endian));
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
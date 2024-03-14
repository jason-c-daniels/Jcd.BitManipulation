#region

using Jcd.BitManipulation.BitIndexers;

using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests.BitIndexersTests;

public class BitMaskTests
{
   [Theory]
   [InlineData(0b1010101010101010101010101010101010101010101010101010101010101010
             , "0b1010101010101010101010101010101010101010101010101010101010101010"
              )]
   [InlineData(0b0101010101010101010101010101010101010101010101010101010101010101
             , "0b0101010101010101010101010101010101010101010101010101010101010101"
              )]
   public void ToString_Outputs_Correct_Formatted_String(ulong maskBits, string expected)
   {
      Assert.Equal(expected, ((BitMask) maskBits).ToString());
   }

   #region Constructor tests

   [Theory]
   [InlineData(byte.MaxValue)]
   [InlineData(ushort.MaxValue)]
   [InlineData(uint.MaxValue)]
   [InlineData(ulong.MaxValue)]
   public void Constructor_UInt64_SetsBitsCorrectly(ulong bits)
   {
      var mask = new BitMask(bits);
      Assert.Equal(bits, mask.Bits);
   }

   [Theory]
   [InlineData(byte.MaxValue)]
   [InlineData(ushort.MaxValue)]
   [InlineData(uint.MaxValue)]
   [InlineData(ulong.MaxValue)]
   public void CopyConstructor_CopiesBitsCorrectly(ulong bits)
   {
      var initialMask = new BitMask(bits);
      var mask        = new BitMask(initialMask);
      Assert.Equal(bits, mask.Bits);
   }

   #endregion

   #region Create tests

   [Theory]
   [InlineData(0,  64, 0xFFFFFFFFFFFFFFFF)] // all bits are set
   [InlineData(0,  63, 0x7FFFFFFFFFFFFFFF)] // high bit is clear
   [InlineData(63, 1,  0x8000000000000000)] // high bit is set
   [InlineData(1,  63, 0xFFFFFFFFFFFFFFFE)] // low bit is clear
   [InlineData(8,  8,  0x000000000000FF00)] // int offset 1, all bits are set
   [InlineData(4,  3,  0x0000000000000070)] // lower 3 bits of upper nybble of first byte are set
   public void CreateRange_Creates_Correct_BitMask(int offset, int size, ulong expected)
   {
      var mask = BitMask.FromRange(offset, size);
      Assert.Equal(expected, mask.Bits);
   }

   [Theory]
   [InlineData(0)]
   [InlineData(1)]
   [InlineData(2)]
   [InlineData(3)]
   [InlineData(7)]
   [InlineData(8)]
   [InlineData(11)]
   [InlineData(13)]
   [InlineData(63)]
   public void CreateSingleBit_Creates_Correct_BitMask(int offset)
   {
      var mask = BitMask.FromSingleBit(offset);
      Assert.Equal((ulong) 1 << offset, mask.Bits);
   }

   #endregion

   #region Implicit Conversion To BitMask tests

   [Theory]
   [InlineData(byte.MaxValue)]
   [InlineData(ushort.MaxValue)]
   [InlineData(uint.MaxValue)]
   [InlineData(ulong.MaxValue)]
   public void Implicit_Conversion_From_UInt64_CopiesBitsCorrectly(ulong bits)
   {
      BitMask mask = bits;
      Assert.Equal(bits, mask.Bits);
   }

   [Theory]
   [InlineData(sbyte.MaxValue)]
   [InlineData(short.MaxValue)]
   [InlineData(int.MaxValue)]
   [InlineData(long.MaxValue)]
   public void Implicit_Conversion_From_Int64_CopiesBitsCorrectly(long bits)
   {
      BitMask mask = bits;
      Assert.Equal((ulong) bits, mask.Bits);
   }

   [Theory]
   [InlineData(byte.MaxValue)]
   [InlineData(ushort.MaxValue)]
   [InlineData(uint.MaxValue)]
   public void Implicit_Conversion_From_UInt32_CopiesBitsCorrectly(uint bits)
   {
      BitMask mask = bits;
      Assert.Equal(bits, mask.Bits);
   }

   [Theory]
   [InlineData(sbyte.MaxValue)]
   [InlineData(short.MaxValue)]
   [InlineData(int.MaxValue)]
   [InlineData(sbyte.MinValue)]
   [InlineData(short.MinValue)]
   [InlineData(int.MinValue)]
   public void Implicit_Conversion_From_Int32_CopiesBitsCorrectly(int bits)
   {
      BitMask mask = bits;
      Assert.Equal((uint) bits, mask.Bits);
   }

   [Theory]
   [InlineData(byte.MaxValue)]
   [InlineData(ushort.MaxValue)]
   public void Implicit_Conversion_From_UInt16_CopiesBitsCorrectly(ushort bits)
   {
      BitMask mask = bits;
      Assert.Equal(bits, mask.Bits);
   }

   [Theory]
   [InlineData(sbyte.MaxValue)]
   [InlineData(short.MaxValue)]
   public void Implicit_Conversion_From_Int16_CopiesBitsCorrectly(short bits)
   {
      BitMask mask = bits;
      Assert.Equal((ushort) bits, mask.Bits);
   }

   [Theory]
   [InlineData(byte.MaxValue)]
   [InlineData(byte.MaxValue - 1)]
   public void Implicit_Conversion_From_Byte_CopiesBitsCorrectly(byte bits)
   {
      BitMask mask = bits;
      Assert.Equal(bits, mask.Bits);
   }

   [Theory]
   [InlineData(sbyte.MaxValue)]
   [InlineData(sbyte.MinValue)]
   public void Implicit_Conversion_From_SByte_CopiesBitsCorrectly(sbyte bits)
   {
      BitMask mask = bits;
      Assert.Equal((byte) bits, mask.Bits);
   }

   #endregion

   #region Implicit conversion From BitMask tests

   [Theory]
   [InlineData(byte.MaxValue)]
   [InlineData(ushort.MaxValue)]
   [InlineData(uint.MaxValue)]
   [InlineData(ulong.MaxValue)]
   public void Implicit_Conversion_To_UInt64_CopiesBitsCorrectly(ulong bits)
   {
      var   mask    = new BitMask(bits);
      ulong newBits = mask;
      Assert.Equal(bits, newBits);
   }

   [Theory]
   [InlineData(sbyte.MaxValue)]
   [InlineData(short.MaxValue)]
   [InlineData(int.MaxValue)]
   [InlineData(long.MaxValue)]
   [InlineData(sbyte.MinValue)]
   [InlineData(short.MinValue)]
   [InlineData(int.MinValue)]
   [InlineData(long.MinValue)]
   public void Implicit_Conversion_To_Int64_CopiesBitsCorrectly(long bits)
   {
      var  mask    = new BitMask(bits);
      long newBits = mask;
      Assert.Equal(bits, newBits);
   }

   [Theory]
   [InlineData(byte.MaxValue)]
   [InlineData(ushort.MaxValue)]
   [InlineData(uint.MaxValue)]
   public void Implicit_Conversion_To_UInt32_CopiesBitsCorrectly(uint bits)
   {
      var  mask    = new BitMask(bits);
      uint newBits = mask;
      Assert.Equal(bits, newBits);
   }

   [Theory]
   [InlineData(sbyte.MaxValue)]
   [InlineData(short.MaxValue)]
   [InlineData(int.MaxValue)]
   public void Implicit_Conversion_To_Int32_CopiesBitsCorrectly(int bits)
   {
      var mask    = new BitMask(bits);
      int newBits = mask;
      Assert.Equal(bits, newBits);
   }

   [Theory]
   [InlineData(byte.MaxValue)]
   [InlineData(ushort.MaxValue)]
   public void Implicit_Conversion_To_UInt16_CopiesBitsCorrectly(ushort bits)
   {
      var    mask    = new BitMask(bits);
      ushort newBits = mask;
      Assert.Equal(bits, newBits);
   }

   [Theory]
   [InlineData(sbyte.MaxValue)]
   [InlineData(short.MaxValue)]
   public void Implicit_Conversion_To_Int16_CopiesBitsCorrectly(short bits)
   {
      var   mask    = new BitMask(bits);
      short newBits = mask;
      Assert.Equal(bits, newBits);
   }

   [Theory]
   [InlineData(byte.MaxValue)]
   [InlineData(byte.MaxValue - 1)]
   public void Implicit_Conversion_To_Byte_CopiesBitsCorrectly(byte bits)
   {
      var  mask    = new BitMask(bits);
      byte newBits = mask;
      Assert.Equal(bits, newBits);
   }

   [Theory]
   [InlineData(sbyte.MinValue)]
   [InlineData(sbyte.MaxValue)]
   public void Implicit_Conversion_To_SByte_CopiesBitsCorrectly(sbyte bits)
   {
      var   mask    = new BitMask((ulong) (byte) bits);
      sbyte newBits = mask;
      Assert.Equal(bits, newBits);
   }

   #endregion
}
#region

using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests;

public class BitMaskTests
{
   [Theory]
   [InlineData(0b1010101010101010101010101010101010101010101010101010101010101010, "0b1010101010101010101010101010101010101010101010101010101010101010")]
   [InlineData(0b0101010101010101010101010101010101010101010101010101010101010101, "0b0101010101010101010101010101010101010101010101010101010101010101")]
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
   public void CopyConstructor_CopiesBitsCorrectly(ulong bits)
   {
      var initialMask = new BitMask(bits);
      var mask = new BitMask(initialMask);
      Assert.Equal(bits, (ulong) mask);
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
      Assert.Equal(expected, (ulong) mask);
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
      Assert.Equal(1ul << offset, (ulong) mask);
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
      Assert.Equal(bits, (ulong) mask);
   }

   [Theory]
   [InlineData(sbyte.MaxValue)]
   [InlineData(short.MaxValue)]
   [InlineData(int.MaxValue)]
   [InlineData(long.MaxValue)]
   public void Implicit_Conversion_From_Int64_CopiesBitsCorrectly(long bits)
   {
      BitMask mask = bits;
      Assert.Equal(bits, (long) mask);
   }

   [Theory]
   [InlineData(byte.MaxValue)]
   [InlineData(ushort.MaxValue)]
   [InlineData(uint.MaxValue)]
   public void Implicit_Conversion_From_UInt32_CopiesBitsCorrectly(uint bits)
   {
      BitMask mask = bits;
      Assert.Equal(bits, (uint) mask);
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
      Assert.Equal(bits, (int) mask);
   }

   [Theory]
   [InlineData(byte.MaxValue)]
   [InlineData(ushort.MaxValue)]
   public void Implicit_Conversion_From_UInt16_CopiesBitsCorrectly(ushort bits)
   {
      BitMask mask = bits;
      Assert.Equal(bits, (ulong) mask);
   }

   [Theory]
   [InlineData(short.MinValue)]
   [InlineData((short) -1)]
   [InlineData((short) 1)]
   [InlineData(short.MaxValue)]
   public void Implicit_Conversion_From_Int16_CopiesBitsCorrectly(short bits)
   {
      BitMask mask = bits;
      Assert.Equal(bits, (short) mask);
   }

   [Theory]
   [InlineData(byte.MaxValue)]
   [InlineData(byte.MaxValue - 1)]
   public void Implicit_Conversion_From_Byte_CopiesBitsCorrectly(byte bits)
   {
      BitMask mask = bits;
      Assert.Equal(bits, (byte) mask);
   }

   [Theory]
   [InlineData(sbyte.MaxValue)]
   [InlineData(sbyte.MinValue)]
   public void Implicit_Conversion_From_SByte_CopiesBitsCorrectly(sbyte bits)
   {
      BitMask mask = bits;
      Assert.Equal(bits, (sbyte) mask);
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
      var mask = new BitMask(bits);
      Assert.Equal(bits, (ulong) mask);
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
      var mask = new BitMask(bits);
      Assert.Equal(bits, (long) mask);
   }

   [Theory]
   [InlineData(byte.MaxValue)]
   [InlineData(ushort.MaxValue)]
   [InlineData(uint.MaxValue)]
   public void Implicit_Conversion_To_UInt32_CopiesBitsCorrectly(uint bits)
   {
      var mask = new BitMask(bits);
      Assert.Equal(bits, (uint) mask);
   }

   [Theory]
   [InlineData(sbyte.MaxValue)]
   [InlineData(short.MaxValue)]
   [InlineData(int.MaxValue)]
   public void Implicit_Conversion_To_Int32_CopiesBitsCorrectly(int bits)
   {
      var mask = new BitMask(bits);
      Assert.Equal(bits, (int) mask);
   }

   [Theory]
   [InlineData(byte.MaxValue)]
   [InlineData(ushort.MaxValue)]
   public void Implicit_Conversion_To_UInt16_CopiesBitsCorrectly(ushort bits)
   {
      var mask = new BitMask(bits);
      Assert.Equal(bits, (ushort) mask);
   }

   [Theory]
   [InlineData(sbyte.MaxValue)]
   [InlineData(short.MaxValue)]
   public void Implicit_Conversion_To_Int16_CopiesBitsCorrectly(short bits)
   {
      var mask = new BitMask(bits);
      Assert.Equal(bits, (short) mask);
   }

   [Theory]
   [InlineData(byte.MaxValue)]
   [InlineData(byte.MaxValue - 1)]
   public void Implicit_Conversion_To_Byte_CopiesBitsCorrectly(byte bits)
   {
      var mask = new BitMask(bits);
      byte newBits = mask;
      Assert.Equal(bits, newBits);
   }

   [Theory]
   [InlineData(sbyte.MinValue)]
   [InlineData(sbyte.MaxValue)]
   public void Implicit_Conversion_To_SByte_CopiesBitsCorrectly(sbyte bits)
   {
      var mask = new BitMask((ulong) (byte) bits);
      sbyte newBits = mask;
      Assert.Equal(bits, newBits);
   }

   #endregion

   #region Equality and HashCode Tests

   [Theory]
   [InlineData(0b0001, 0b0001, true)]
   [InlineData(0b0011, 0b0011, true)]
   [InlineData(0b0010, 0b0011, false)]
   [InlineData(0b0110, 0b0011, false)]
   public void op_Equals_Returns_Expected_Value(uint v1, uint v2, bool expected)
   {
      BitMask b1 = v1;
      BitMask b2 = v2;
      Assert.Equal(expected, b1 == b2);
   }

   [Theory]
   [InlineData(0b0001, 0b0001, false)]
   [InlineData(0b0011, 0b0011, false)]
   [InlineData(0b0010, 0b0011, true)]
   [InlineData(0b0110, 0b0011, true)]
   public void op_NotEquals_Returns_Expected_Value(uint v1, uint v2, bool expected)
   {
      BitMask b1 = v1;
      BitMask b2 = v2;
      Assert.Equal(expected, b1 != b2);
   }

   [Theory]
   [InlineData(0b0001, 0b0001, true)]
   [InlineData(0b0011, 0b0011, true)]
   [InlineData(0b0010, 0b0011, false)]
   [InlineData(0b0110, 0b0011, false)]
   public void Equals_On_Object_Returns_Expected_Value(uint v1, uint v2, bool expected)
   {
      BitMask b1 = v1;
      BitMask b2 = v2;
      Assert.Equal(expected, b1.Equals((object) b2));
   }

   [Fact]
   public void Equals_On_Object_Of_Wrong_Type_Returns_False()
   {
      BitMask b1 = 1;
      Assert.False(b1.Equals(new object()));
   }

   [Theory]
   [InlineData(0b0001)]
   [InlineData(0b0011)]
   [InlineData(0b0010)]
   [InlineData(0b0110)]
   public void GetHashCode_Returns_Expected_Value(ulong v1)
   {
      var expected = v1.GetHashCode();
      BitMask b1 = v1;
      Assert.Equal(expected, b1.GetHashCode());
   }

   #endregion

   #region Bit Manipulation Tests

   [Theory]
   [InlineData(1ul,    1, 1ul    << 1)]
   [InlineData(1ul,    2, 1ul    << 2)]
   [InlineData(1ul,    3, 1ul    << 3)]
   [InlineData(1ul,    4, 1ul    << 4)]
   [InlineData(0b11ul, 4, 0b11ul << 4)]
   public void op_LeftShift_Returns_Expected_Result(ulong value, int shift, ulong result)
   {
      BitMask bv = value;
      BitMask expected = result;
      Assert.Equal(expected, (bv << shift));
   }

   [Theory]
   [InlineData(0b100000000ul, 1, 0b100000000ul >> 1)]
   [InlineData(0b100000000ul, 2, 0b100000000ul >> 2)]
   [InlineData(0b100000000ul, 3, 0b100000000ul >> 3)]
   [InlineData(0b100000000ul, 4, 0b100000000ul >> 4)]
   [InlineData(0b110000000ul, 4, 0b110000000ul >> 4)]
   public void op_RightShift_Returns_Expected_Result(ulong value, int shift, ulong result)
   {
      BitMask bv = value;
      BitMask expected = result;
      Assert.Equal(expected, (bv >> shift));
   }

   [Theory]
   [InlineData(0b100000000ul, 0b100001000ul, 0b100000000ul | 0b100001000ul)]
   [InlineData(0b100000000ul, 0b100000001ul, 0b100000000ul | 0b100000001ul)]
   [InlineData(0b100000000ul, 0b100100000ul, 0b100000000ul | 0b100100000ul)]
   [InlineData(0b100000000ul, 0b100110000ul, 0b100000000ul | 0b100110000ul)]
   [InlineData(0b110000000ul, 0b100000111ul, 0b110000000ul | 0b100000111ul)]
   public void op_BitwiseOr_Returns_Expected_Result(ulong v1, ulong v2, ulong result)
   {
      BitMask bv1 = v1;
      BitMask bv2 = v2;
      BitMask expected = result;
      Assert.Equal(expected, bv1 | bv2);
   }

   [Theory]
   [InlineData(0b111111100ul, 0b100001000ul, 0b111111100ul & 0b100001000ul)]
   [InlineData(0b111111100ul, 0b100000001ul, 0b111111100ul & 0b100000001ul)]
   [InlineData(0b111111100ul, 0b100100000ul, 0b111111100ul & 0b100100000ul)]
   [InlineData(0b111111100ul, 0b100110000ul, 0b111111100ul & 0b100110000ul)]
   [InlineData(0b111111101ul, 0b100000111ul, 0b111111101ul & 0b100000111ul)]
   public void op_BitwiseAnd_Returns_Expected_Result(ulong v1, ulong v2, ulong result)
   {
      BitMask bv1 = v1;
      BitMask bv2 = v2;
      BitMask expected = result;
      Assert.Equal(expected, bv1 & bv2);
   }

   [Theory]
   [InlineData(0b111111100ul, 0b100001000ul, 0b111111100ul ^ 0b100001000ul)]
   [InlineData(0b111111100ul, 0b100000001ul, 0b111111100ul ^ 0b100000001ul)]
   [InlineData(0b111111100ul, 0b100100000ul, 0b111111100ul ^ 0b100100000ul)]
   [InlineData(0b111111100ul, 0b100110000ul, 0b111111100ul ^ 0b100110000ul)]
   [InlineData(0b111111101ul, 0b100000111ul, 0b111111101ul ^ 0b100000111ul)]
   public void op_BitwiseXor_Returns_Expected_Result(ulong v1, ulong v2, ulong result)
   {
      BitMask bv1 = v1;
      BitMask bv2 = v2;
      BitMask expected = result;
      Assert.Equal(expected, bv1 ^ bv2);
   }

   [Theory]
   [InlineData(0b100000000ul, ~0b100000000ul)]
   [InlineData(0b100001000ul, ~0b100001000ul)]
   [InlineData(0b100010000ul, ~0b100010000ul)]
   [InlineData(0b100000010ul, ~0b100000010ul)]
   [InlineData(0b110000000ul, ~0b110000000ul)]
   public void op_BitWiseComplement_Returns_Expected_Result(ulong value, ulong result)
   {
      BitMask bv = value;
      BitMask expected = result;
      Assert.Equal(expected, ~bv);
   }

   #endregion
}
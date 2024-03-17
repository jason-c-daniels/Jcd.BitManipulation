using Xunit;

namespace Jcd.BitManipulation.Tests;

public class AreAllBitsSetExtensionsTests
{
   [Theory]
   [InlineData(0,    ulong.MaxValue, false)]
   [InlineData(0b11, ulong.MaxValue, false)]
   [InlineData(0b10, 0b10,           true)]
   [InlineData(0b11, 0b10,           true)]
   public void AreAllBits_On_A_UInt64_Returns_The_Expected_Result(ulong data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAllBitsSet(mask));
   }

   [Theory]
   [InlineData(0,    ulong.MaxValue, false)]
   [InlineData(0b11, ulong.MaxValue, false)]
   [InlineData(0b10, 0b10,           true)]
   [InlineData(0b11, 0b10,           true)]
   public void AreAllBits_On_An_Int64_Returns_The_Expected_Result(long data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAllBitsSet(mask));
   }

   [Theory]
   [InlineData(0,    ulong.MaxValue, false)]
   [InlineData(0b11, ulong.MaxValue, false)]
   [InlineData(0b10, 0b10,           true)]
   [InlineData(0b11, 0b10,           true)]
   public void AreAllBits_On_A_UInt32_Returns_The_Expected_Result(uint data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAllBitsSet(mask));
   }

   [Theory]
   [InlineData(0,    ulong.MaxValue, false)]
   [InlineData(0b11, ulong.MaxValue, false)]
   [InlineData(0b10, 0b10,           true)]
   [InlineData(0b11, 0b10,           true)]
   public void AreAllBits_On_An_Int32_Returns_The_Expected_Result(int data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAllBitsSet(mask));
   }

   [Theory]
   [InlineData(0,    ulong.MaxValue, false)]
   [InlineData(0b11, ulong.MaxValue, false)]
   [InlineData(0b10, 0b10,           true)]
   [InlineData(0b11, 0b10,           true)]
   public void AreAllBits_On_A_UInt16_Returns_The_Expected_Result(ushort data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAllBitsSet(mask));
   }

   [Theory]
   [InlineData(0,    ulong.MaxValue, false)]
   [InlineData(0b11, ulong.MaxValue, false)]
   [InlineData(0b10, 0b10,           true)]
   [InlineData(0b11, 0b10,           true)]
   public void AreAllBits_On_An_Int16_Returns_The_Expected_Result(short data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAllBitsSet(mask));
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
   [InlineData(0,    ulong.MaxValue, false)]
   [InlineData(0b11, ulong.MaxValue, false)]
   [InlineData(0b10, 0b10,           true)]
   [InlineData(0b11, 0b10,           true)]
   public void AreAllBits_On_An_SByte_Returns_The_Expected_Result(sbyte data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAllBitsSet(mask));
   }
}
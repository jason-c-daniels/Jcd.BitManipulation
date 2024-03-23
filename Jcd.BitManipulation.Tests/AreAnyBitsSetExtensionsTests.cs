#region

using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests;

public class AreAnyBitsSetExtensionsTests
{
   [Theory]
   [InlineData(0,     ulong.MaxValue, false)]
   [InlineData(0b11,  ulong.MaxValue, true)]
   [InlineData(0b100, 0b10,           false)]
   [InlineData(0b011, 0b10,           true)]
   public void AreAnyBits_On_A_UInt64_Returns_The_Expected_Result(ulong data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAnyBitsSet(mask));
   }

   [Theory]
   [InlineData(0,     ulong.MaxValue, false)]
   [InlineData(0b11,  ulong.MaxValue, true)]
   [InlineData(0b100, 0b10,           false)]
   [InlineData(0b011, 0b10,           true)]
   public void AreAnyBits_On_An_Int64_Returns_The_Expected_Result(long data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAnyBitsSet(mask));
   }

   [Theory]
   [InlineData(0,     ulong.MaxValue, false)]
   [InlineData(0b11,  ulong.MaxValue, true)]
   [InlineData(0b100, 0b10,           false)]
   [InlineData(0b011, 0b10,           true)]
   public void AreAnyBits_On_A_UInt32_Returns_The_Expected_Result(uint data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAnyBitsSet(mask));
   }

   [Theory]
   [InlineData(0,     ulong.MaxValue, false)]
   [InlineData(0b11,  ulong.MaxValue, true)]
   [InlineData(0b100, 0b10,           false)]
   [InlineData(0b011, 0b10,           true)]
   public void AreAnyBits_On_An_Int32_Returns_The_Expected_Result(int data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAnyBitsSet(mask));
   }

   [Theory]
   [InlineData(0,     ulong.MaxValue, false)]
   [InlineData(0b11,  ulong.MaxValue, true)]
   [InlineData(0b100, 0b10,           false)]
   [InlineData(0b011, 0b10,           true)]
   public void AreAnyBits_On_A_UInt16_Returns_The_Expected_Result(ushort data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAnyBitsSet(mask));
   }

   [Theory]
   [InlineData(0,     ulong.MaxValue, false)]
   [InlineData(0b11,  ulong.MaxValue, true)]
   [InlineData(0b100, 0b10,           false)]
   [InlineData(0b011, 0b10,           true)]
   public void AreAnyBits_On_An_Int16_Returns_The_Expected_Result(short data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAnyBitsSet(mask));
   }

   [Theory]
   [InlineData(0,     ulong.MaxValue, false)]
   [InlineData(0b11,  ulong.MaxValue, true)]
   [InlineData(0b100, 0b10,           false)]
   [InlineData(0b011, 0b10,           true)]
   public void AreAnyBits_On_A_Byte_Returns_The_Expected_Result(byte data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAnyBitsSet(mask));
   }

   [Theory]
   [InlineData(0,     ulong.MaxValue, false)]
   [InlineData(0b11,  ulong.MaxValue, true)]
   [InlineData(0b100, 0b10,           false)]
   [InlineData(0b011, 0b10,           true)]
   public void AreAnyBits_On_An_SByte_Returns_The_Expected_Result(sbyte data, ulong mask, bool expected)
   {
      Assert.Equal(expected, data.AreAnyBitsSet(mask));
   }
}
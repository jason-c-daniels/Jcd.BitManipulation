#region

using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests;

public class BooleanArrayExtensionsTests
{
   [Theory]
   [InlineData(0xFF)]
   [InlineData(0xF3)]
   [InlineData(0x71)]
   public void ToBooleanArray_ToByte_Round_Trip_Value_Remains_Unaltered(uint data)
   {
      var expected = (byte) data;
      var actual = expected.ToBooleanArray().ToByte();
      Assert.Equal(expected, actual);
   }

   [Theory]
   [InlineData(0xFF)]
   [InlineData(0xF3)]
   [InlineData(0x71)]
   public void ToBooleanArray_ToSByte_Round_Trip_Value_Remains_Unaltered(uint data)
   {
      var expected = (sbyte) data;
      var actual = expected.ToBooleanArray().ToSByte();
      Assert.Equal(expected, actual);
   }

   [Theory]
   [InlineData(0xFFFF)]
   [InlineData(0xF3FF)]
   [InlineData(0x71FF)]
   public void ToBooleanArray_ToUInt16_Round_Trip_Value_Remains_Unaltered(uint data)
   {
      var expected = (ushort) data;
      var actual = expected.ToBooleanArray().ToUInt16();
      Assert.Equal(expected, actual);
   }

   [Theory]
   [InlineData(0xEEFF)]
   [InlineData(0xEEF3)]
   [InlineData(0xEE71)]
   public void ToBooleanArray_ToInt16_Round_Trip_Value_Remains_Unaltered(uint data)
   {
      var expected = (short) data;
      var actual = expected.ToBooleanArray().ToInt16();
      Assert.Equal(expected, actual);
   }

   [Theory]
   [InlineData(0xFFEEAACC)]
   [InlineData(0xF3EEAACC)]
   [InlineData(0x71EEAACC)]
   public void ToBooleanArray_ToUInt32_Round_Trip_Value_Remains_Unaltered(uint expected)
   {
      var actual = expected.ToBooleanArray().ToUInt32();
      Assert.Equal(expected, actual);
   }

   [Theory]
   [InlineData(0xEEAACCFF)]
   [InlineData(0xEEAACCF3)]
   [InlineData(0xEEAACC71)]
   public void ToBooleanArray_ToInt32_Round_Trip_Value_Remains_Unaltered(uint data)
   {
      var expected = (int) data;
      var actual = expected.ToBooleanArray().ToInt32();
      Assert.Equal(expected, actual);
   }

   [Theory]
   [InlineData(0xFFEEAACC11223344)]
   [InlineData(0xF3EEAACC11223344)]
   [InlineData(0x71EEAACC11223344)]
   public void ToBooleanArray_ToUInt64_Round_Trip_Value_Remains_Unaltered(ulong expected)
   {
      var actual = expected.ToBooleanArray().ToUInt64();
      Assert.Equal(expected, actual);
   }

   [Theory]
   [InlineData(0xEEAACC11223344FF)]
   [InlineData(0xEEAACC11223344F3)]
   [InlineData(0xEEAACC1122334471)]
   public void ToBooleanArray_ToInt64_Round_Trip_Value_Remains_Unaltered(ulong data)
   {
      var expected = (long) data;
      var actual = expected.ToBooleanArray().ToInt64();
      Assert.Equal(expected, actual);
   }

   [Theory]
   [InlineData(1.33f)]
   [InlineData(1.22f)]
   [InlineData(1.11f)]
   public void ToBooleanArray_ToFloat_Round_Trip_Value_Remains_Unaltered(float data)
   {
      var actual = data.ToBooleanArray().ToSingle();
      Assert.Equal(data, actual);
   }

   [Theory]
   [InlineData(1.33d)]
   [InlineData(1.22d)]
   [InlineData(1.11d)]
   public void ToBooleanArray_ebvToDouble_Round_Trip_Value_Remains_Unaltered(double data)
   {
      var actual = data.ToBooleanArray().ToDouble();
      Assert.Equal(data, actual);
   }
}
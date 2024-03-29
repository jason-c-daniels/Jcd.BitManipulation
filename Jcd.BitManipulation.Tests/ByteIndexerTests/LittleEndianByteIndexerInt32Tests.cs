#region

using System;
using System.Collections.Generic;

using Xunit;

// ReSharper disable HeapView.DelegateAllocation
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable InlineTemporaryVariable
// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.ClosureAllocation

#endregion

namespace Jcd.BitManipulation.Tests.ByteIndexerTests;

public class LittleEndianByteIndexerInt32Tests
{
   [Fact]
   public void Length_Is_BitSize()
   {
      LittleEndianByteIndexer sut = 0;
      Assert.Equal(sizeof(int), sut.Length);
   }

   [Theory]
   [InlineData(0x01FFDEAD)]
   [InlineData(0x20FEBEEF)]
   [InlineData(0x337FC0DE)]
   public void Implicit_Conversion_Operators_Round_Trip_Returns_Original_Value(uint data)
   {
      var expected = (int) data;
      LittleEndianByteIndexer sut = expected;
      int convertedBack = sut;
      Assert.Equal(expected, convertedBack);
   }

   [Theory]
   [InlineData(0x01FF0000, 3, 0x01)]
   [InlineData(0xFB0AFCFD, 2, 0x0A)]
   [InlineData(0xFEF702FA, 1, 0x02)]
   [InlineData(0xFE7FFF03, 0, 0x03)]
   public void Indexer_Get_Returns_Expected_Value(uint data, int index, byte extractedData)
   {
      var expected = extractedData;
      LittleEndianByteIndexer sut = (int) data;
      Assert.Equal(expected, sut[index]);
   }

   [Theory]
   [InlineData(0x0101, 1, 0x7F, 0x7F01)]
   [InlineData(0x0202, 1, 0x7E, 0x7E02)]
   [InlineData(0x0303, 1, 0x7D, 0x7D03)]
   [InlineData(0x0101, 0, 0xFF, 0x01FF)]
   [InlineData(0x0202, 0, 0xFE, 0x02FE)]
   [InlineData(0x0303, 0, 0x7F, 0x037F)]
   public void Indexer_Set_Sets_The_Expected_Value(int data, int index, byte dataToSet, int expected)
   {
      LittleEndianByteIndexer sut = data;
      sut[index] = dataToSet;
      Assert.Equal(expected, (int) sut);
   }

   [Theory]
   [InlineData(-1)]
   [InlineData(sizeof(int))]
   public void Indexer_Get_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                 {
                                                    LittleEndianByteIndexer sut = 0xFF;

                                                    return sut[index];
                                                 }
                                                );
   }

   [Theory]
   [InlineData(-1)]
   [InlineData(sizeof(int))]
   public void Indexer_Set_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                 {
                                                    LittleEndianByteIndexer sut = 0xFF;

                                                    return sut[index] = 0;
                                                 }
                                                );
   }

   [Theory]
   [InlineData(0x010101FF, 0, 1, 1, 0xFF)]
   [InlineData(0x010202FE, 0, 2, 2, 0xFE, 0x02)]
   [InlineData(0x0102037F, 0, 3, 3, 0x7F, 0x03, 0x02)]
   [InlineData(0x030201FF, 0, 4, 4, 0xFF, 0x01, 0x02, 0x03)]
   [InlineData(0x040302FE, 1, 3, 3, 0x02, 0x03, 0x04)]
   [InlineData(0x05060708, 2, 2, 2, 0x06, 0x05)]
   [InlineData(0x0F060708, 3, 1, 1, 0x0F)]
   public void Slice_Returns_Expected_Subset(int data, int index, int size, int expectedArraySize, byte e0, byte e1 = 0, byte e2 = 0, byte e3 = 0)
   {
      var expected = CreateExpectedArray(expectedArraySize, e0, e1, e2, e3);

      LittleEndianByteIndexer sut = data;
      Assert.Equal(expected.ToArray(), sut.Slice(index, size));
   }

   [Theory]
   [InlineData(0x6F01010F, "0F 01 01 6F")]
   [InlineData(0x7F03020F, "0F 02 03 7F")]
   public void ToString_Returns_Expected_Value(int data, string expectedValue)
   {
      LittleEndianByteIndexer sut = data;
      Assert.Equal(sut.ToString(), expectedValue);
   }

   private static List<byte> CreateExpectedArray(int expectedSize, byte e0, byte e1, byte e2, byte e3)
   {
      var expected = new List<byte>(new[] { e0 });
      if (expectedSize >= 2)
         expected.Add(e1);
      if (expectedSize >= 3)
         expected.Add(e2);
      if (expectedSize >= 4)
         expected.Add(e3);

      return expected;
   }
}
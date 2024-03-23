#region

using System;
using System.Collections.Generic;

using Jcd.BitManipulation.ByteIndexers;

using Xunit;

// ReSharper disable HeapView.DelegateAllocation
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable InlineTemporaryVariable
// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.ClosureAllocation

#endregion

namespace Jcd.BitManipulation.Tests.ByteIndexerTests;

public class BigEndianByteIndexerInt32Tests
{
   [Fact]
   public void Length_Is_SizeOf_Int32()
   {
      BigEndianByteIndexer sut = 0;
      Assert.Equal(sizeof(int), sut.Length);
   }

   [Theory]
   [InlineData(0x01FFDEAD)]
   [InlineData(0x20FEBEEF)]
   [InlineData(0x337FC0DE)]
   public void Implicit_Conversion_Operators_Round_Trip_Returns_Original_Value(uint data)
   {
      var expected = (int) data;
      BigEndianByteIndexer sut = expected;
      int convertedBack = sut;
      Assert.Equal(expected, convertedBack);
   }

   [Theory]
   [InlineData(0x01FF0000, 0, 0x01)]
   [InlineData(0xFB0AFCFD, 1, 0x0A)]
   [InlineData(0xFEF702FA, 2, 0x02)]
   [InlineData(0xFE7FFF03, 3, 0x03)]
   public void Indexer_Get_Returns_Expected_Value(uint data, int index, byte extractedData)
   {
      var expected = extractedData;
      BigEndianByteIndexer sut = (int) data;
      Assert.Equal(expected, sut[index]);
   }

   [Theory]
   [InlineData(0x01010101, 0, 0x7F, 0x7F010101)]
   [InlineData(0x02020202, 1, 0x7E, 0x027E0202)]
   [InlineData(0x03030303, 2, 0x7D, 0x03037D03)]
   [InlineData(0xFEFEFEFE, 3, 0x0A, 0xFEFEFE0A)]
   public void Indexer_Set_Sets_The_Expected_Value(uint udata, int index, byte dataToSet, uint uexpected)
   {
      BigEndianByteIndexer sut = (int) udata;
      var expected = (int) uexpected;
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
                                                    BigEndianByteIndexer sut = 0xFF;

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
                                                    BigEndianByteIndexer sut = 0xFF;

                                                    return sut[index] = 0;
                                                 }
                                                );
   }

   [Theory]
   [InlineData(0xFF010101, 0, 1, 1, 0xFF)]
   [InlineData(0xFE020102, 0, 2, 2, 0xFE, 0x02)]
   [InlineData(0x7F030201, 0, 3, 3, 0x7F, 0x03, 0x02)]
   [InlineData(0xFF010203, 0, 4, 4, 0xFF, 0x01, 0x02, 0x03)]
   [InlineData(0xFE020304, 1, 3, 3, 0x02, 0x03, 0x04)]
   [InlineData(0x08070605, 2, 2, 2, 0x06, 0x05)]
   [InlineData(0x0807060F, 3, 1, 1, 0x0F)]
   public void Slice_Returns_Expected_Subset(uint udata, int index, int size, int expectedArraySize, byte e0, byte e1 = 0, byte e2 = 0, byte e3 = 0)
   {
      var data = (int) udata;
      var expected = CreateExpectedArray(expectedArraySize, e0, e1, e2, e3);

      BigEndianByteIndexer sut = data;
      Assert.Equal(expected.ToArray(), sut.Slice(index, size));
   }

   [Theory]
   [InlineData(0x6F010101, "6F 01 01 01")]
   [InlineData(0x7F030201, "7F 03 02 01")]
   public void ToString_Returns_Expected_Value(int data, string expectedValue)
   {
      BigEndianByteIndexer sut = data;
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
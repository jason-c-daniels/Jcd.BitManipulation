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

public class LittleEndianByteIndexerInt16Tests
{
   [Fact]
   public void Length_Is_BitSize()
   {
      LittleEndianByteIndexer sut = (short) 0;
      Assert.Equal(sizeof(short), sut.Length);
   }

   [Theory]
   [InlineData(0x01FF)]
   [InlineData(0x20FE)]
   [InlineData(0x337F)]
   [InlineData(0b111001100011000)]
   public void Implicit_Conversion_Operators_Round_Trip_Returns_Original_Value(uint data)
   {
      var expected = (short) data;
      LittleEndianByteIndexer sut = expected;
      short convertedBack = sut;
      Assert.Equal(expected, convertedBack);
   }

   [Theory]
   [InlineData(0x01FF, 0, 0xFF)]
   [InlineData(0x02FE, 0, 0xFE)]
   [InlineData(0x037F, 0, 0x7F)]
   [InlineData(0x01FF, 1, 0x01)]
   [InlineData(0x02FE, 1, 0x02)]
   [InlineData(0x037F, 1, 0x03)]
   public void Indexer_Get_Returns_Expected_Value(uint data, int index, byte extractedData)
   {
      var expected = (short) extractedData;
      LittleEndianByteIndexer sut = (short) data;
      Assert.Equal(expected, sut[index]);
   }

   [Theory]
   [InlineData(0x0101, 1, 0x7F, 0x7F01)]
   [InlineData(0x0202, 1, 0x7E, 0x7E02)]
   [InlineData(0x0303, 1, 0x7D, 0x7D03)]
   [InlineData(0x0101, 0, 0xFF, 0x01FF)]
   [InlineData(0x0202, 0, 0xFE, 0x02FE)]
   [InlineData(0x0303, 0, 0x7F, 0x037F)]
   public void Indexer_Set_Sets_The_Expected_Value(short data, int index, byte dataToSet, short expected)
   {
      LittleEndianByteIndexer sut = data;
      sut[index] = dataToSet;
      Assert.Equal(expected, (short) sut);
   }

   [Theory]
   [InlineData(-1)]
   [InlineData(sizeof(short))]
   public void Indexer_Get_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                 {
                                                    LittleEndianByteIndexer sut = (short) 0xFF;

                                                    return sut[index];
                                                 }
                                                );
   }

   [Theory]
   [InlineData(-1)]
   [InlineData(sizeof(short))]
   public void Indexer_Set_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                 {
                                                    LittleEndianByteIndexer sut = (short) 0xFF;

                                                    return sut[index] = 0;
                                                 }
                                                );
   }

   [Theory]
   [InlineData(0x01FF, 0, 1, 1, 0xFF)]
   [InlineData(0x02FE, 0, 1, 1, 0xFE)]
   [InlineData(0x037F, 0, 1, 1, 0x7F)]
   [InlineData(0x01FF, 1, 1, 1, 0x01)]
   [InlineData(0x02FE, 1, 1, 1, 0x02)]
   [InlineData(0x037F, 1, 1, 1, 0x03)]
   [InlineData(0x01FF, 0, 2, 2, 0xFF, 0x01)]
   [InlineData(0x02FE, 0, 2, 2, 0xFE, 0x02)]
   [InlineData(0x037F, 0, 2, 2, 0x7F, 0x03)]
   public void Slice_Returns_Expected_Subset(short data, int index, int size, int expectedArraySize, byte e0, byte e1 = 0)
   {
      var expected = CreateExpectedArray(expectedArraySize, e0, e1);

      LittleEndianByteIndexer sut = data;
      Assert.Equal(expected.ToArray(), sut.Slice(index, size));
   }

   [Theory]
   [InlineData(0x6F01, "01 6F")]
   [InlineData(0x7F03, "03 7F")]
   public void ToString_Returns_Expected_Value(short data, string expectedValue)
   {
      LittleEndianByteIndexer sut = data;
      Assert.Equal(sut.ToString(), expectedValue);
   }

   private static List<byte> CreateExpectedArray(int expectedSize, byte e0, byte e1)
   {
      var expected = new List<byte>(new[] { e0 });

      if (expectedSize >= 2)
      {
         expected.Add(e1);
      }

      return expected;
   }
}
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

public class LittleEndianByteIndexerSByteTests
{
   [Fact]
   public void Length_Is_SizeOf_Byte()
   {
      LittleEndianByteIndexer sut = (sbyte) 0;
      Assert.Equal(sizeof(sbyte), sut.Length);
   }

   [Theory]
   [InlineData(0x01)]
   [InlineData(0x20)]
   [InlineData(0x33)]
   [InlineData(0b01110011)]
   public void Implicit_Conversion_Operators_Round_Trip_Returns_Original_Value(sbyte data)
   {
      var expected = data;
      LittleEndianByteIndexer sut = data;
      sbyte convertedBack = sut;
      Assert.Equal(expected, convertedBack);
   }

   [Theory]
   [InlineData(0xFF, 0, 0xFF)]
   [InlineData(0xFE, 0, 0xFE)]
   public void Indexer_Get_Returns_Expected_Value(byte data, int index, byte extractedData)
   {
      var expected = extractedData;
      LittleEndianByteIndexer sut = (sbyte) data;
      Assert.Equal(expected, sut[index]);
   }

   [Theory]
   [InlineData(0x01, 0, 0x7F, 0x7F)]
   [InlineData(0x02, 0, 0x7E, 0x7E)]
   [InlineData(0x03, 0, 0x7D, 0x7D)]
   public void Indexer_Set_Sets_The_Expected_Value(sbyte data, int index, byte dataToSet, sbyte expected)
   {
      LittleEndianByteIndexer sut = data;
      sut[index] = dataToSet;
      Assert.Equal(expected, (sbyte) sut);
   }

   [Theory]
   [InlineData(-1)]
   [InlineData(sizeof(sbyte))]
   public void Indexer_Get_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                 {
                                                    LittleEndianByteIndexer sut = (sbyte) 0x7F;

                                                    return sut[index];
                                                 }
                                                );
   }

   [Theory]
   [InlineData(-1)]
   [InlineData(sizeof(sbyte))]
   public void Indexer_Set_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                 {
                                                    LittleEndianByteIndexer sut = (sbyte) 0x7F;

                                                    return sut[index] = 0;
                                                 }
                                                );
   }

   [Theory]
   [InlineData(0xFF, 0, 1, 0xFF)]
   [InlineData(0xFE, 0, 1, 0xFE)]
   [InlineData(0x7F, 0, 1, 0x7F)]
   public void Slice_Returns_Expected_Subset(ushort udata, int index, int size, byte e0)
   {
      var data = (sbyte) udata;
      var expected = new List<byte>(new[] { e0 });

      LittleEndianByteIndexer sut = data;
      Assert.Equal(expected.ToArray(), sut.Slice(index, size));
   }

   [Theory]
   [InlineData(0x7E, "7E")]
   [InlineData(0x7A, "7A")]
   public void ToString_Returns_Expected_Value(sbyte value, string expectedValue)
   {
      BigEndianByteIndexer sut = value;
      Assert.Equal(sut.ToString(), expectedValue);
   }
}
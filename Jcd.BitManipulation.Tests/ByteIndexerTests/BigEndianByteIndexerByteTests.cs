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

public class BigEndianByteIndexerByteTests
{
   [Fact]
   public void Length_Is_SizeOf_Byte()
   {
      BigEndianByteIndexer sut = (byte) 0;
      Assert.Equal(sizeof(byte), sut.Length);
   }

   [Theory]
   [InlineData(0x01)]
   [InlineData(0x20)]
   [InlineData(0x33)]
   [InlineData(0b01110011)]
   public void Implicit_Conversion_Operators_Round_Trip_Returns_Original_Value(byte data)
   {
      var expected = data;
      BigEndianByteIndexer sut = data;
      byte convertedBack = sut;
      Assert.Equal(expected, convertedBack);
   }

   [Theory]
   [InlineData(0xFF, 0, 0xFF)]
   [InlineData(0xFE, 0, 0xFE)]
   public void Indexer_Get_Returns_Expected_Value(byte data, int index, byte extractedData)
   {
      var expected = extractedData;
      BigEndianByteIndexer sut = data;
      Assert.Equal(expected, sut[index]);
   }

   [Theory]
   [InlineData(0x01, 0, 0x7F, 0x7F)]
   [InlineData(0x02, 0, 0x7E, 0x7E)]
   [InlineData(0x03, 0, 0x7D, 0x7D)]
   public void Indexer_Set_Sets_The_Expected_Value(byte data, int index, byte dataToSet, byte expected)
   {
      BigEndianByteIndexer sut = data;
      sut[index] = dataToSet;
      Assert.Equal(expected, (byte) sut);
   }

   [Theory]
   [InlineData(-1)]
   [InlineData(sizeof(byte))]
   public void Indexer_Get_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                 {
                                                    BigEndianByteIndexer sut = (byte) 0xFF;

                                                    return sut[index];
                                                 }
                                                );
   }

   [Theory]
   [InlineData(-1)]
   [InlineData(sizeof(byte))]
   public void Indexer_Set_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                 {
                                                    BigEndianByteIndexer sut = (byte) 0xFF;

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
      var data = (byte) udata;
      var expected = new List<byte>(new[] { e0 });

      BigEndianByteIndexer sut = data;
      Assert.Equal(expected.ToArray(), sut.Slice(index, size));
   }

   [Theory]
   [InlineData(0xFE, "FE")]
   [InlineData(0xAE, "AE")]
   public void ToString_Returns_Expected_Value(byte value, string expectedValue)
   {
      BigEndianByteIndexer sut = value;
      Assert.Equal(sut.ToString(), expectedValue);
   }
}
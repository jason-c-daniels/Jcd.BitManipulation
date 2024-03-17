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

public class BigEndianByteIndexerUInt32Tests
{
   [Fact]
   public void Constant_ByteSize_Is_Two() { Assert.Equal(sizeof(int), BigEndianByteIndexerUInt32.ByteSize); }

   [Fact]
   public void Length_Is_BitSize()
   {
      BigEndianByteIndexerUInt32 sut = 0;
      Assert.Equal(BigEndianByteIndexerUInt32.ByteSize, sut.Length);
   }

   [Theory]
   [InlineData(0x01FFDEAD)]
   [InlineData(0x20FEBEEF)]
   [InlineData(0x337FC0DE)]
   public void Implicit_Conversion_Operators_Round_Trip_Returns_Original_Value(uint data)
   {
      var                        expected      = data;
      BigEndianByteIndexerUInt32 sut           = expected;
      uint                       convertedBack = sut;
      Assert.Equal(expected, convertedBack);
   }

   [Theory]
   [InlineData(0x01FF0000, 0, 0x01)]
   [InlineData(0xFB0AFCFD, 1, 0x0A)]
   [InlineData(0xFEF702FA, 2, 0x02)]
   [InlineData(0xFE7FFF03, 3, 0x03)]
   public void Indexer_Get_Returns_Expected_Value(uint data, int index, byte extractedData)
   {
      var                        expected = extractedData;
      BigEndianByteIndexerUInt32 sut      = data;
      Assert.Equal(expected, sut[index]);
   }

   [Theory]
   [InlineData(0x01010101, 0, 0x7F, 0x7F010101)]
   [InlineData(0x02020202, 1, 0x7E, 0x027E0202)]
   [InlineData(0x03030303, 2, 0x7D, 0x03037D03)]
   [InlineData(0xFEFEFEFE, 3, 0x0A, 0xFEFEFE0A)]
   public void Indexer_Set_Sets_The_Expected_Value(uint data, int index, byte dataToSet, uint uexpected)
   {
      BigEndianByteIndexerUInt32 sut      = data;
      var                        expected = uexpected;
      sut[index] = dataToSet;
      Assert.Equal(expected, (uint) sut);
   }

   [Theory]
   [InlineData(-1)]
   [InlineData(BigEndianByteIndexerUInt32.ByteSize)]
   public void Indexer_Get_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
   {
      BigEndianByteIndexerUInt32 sut = 0xFF;
      Assert.Throws<ArgumentOutOfRangeException>(() => sut[index]);
   }

   [Theory]
   [InlineData(-1)]
   [InlineData(BigEndianByteIndexerUInt32.ByteSize)]
   public void Indexer_Set_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
   {
      BigEndianByteIndexerUInt32 sut = 0xFF;
      Assert.Throws<ArgumentOutOfRangeException>(() => sut[index] = 0);
   }

   [Theory]
   [InlineData(0xFF010101, 0, 1, 1, 0xFF)]
   [InlineData(0xFE020102
             , 0
             , 2
             , 2
             , 0xFE
             , 0x02
              )]
   [InlineData(0x7F030201
             , 0
             , 3
             , 3
             , 0x7F
             , 0x03
             , 0x02
              )]
   [InlineData(0xFF010203
             , 0
             , 4
             , 4
             , 0xFF
             , 0x01
             , 0x02
             , 0x03
              )]
   [InlineData(0xFE020304
             , 1
             , 3
             , 3
             , 0x02
             , 0x03
             , 0x04
              )]
   [InlineData(0x08070605
             , 2
             , 2
             , 2
             , 0x06
             , 0x05
              )]
   [InlineData(0x0807060F, 3, 1, 1, 0x0F)]
   public void Slice_Returns_Expected_Subset(
      uint data
    , int  index
    , int  size
    , int  expectedSize
    , byte e0
    , byte e1 = 0
    , byte e2 = 0
    , byte e3 = 0
   )
   {
      var expected = new List<byte>(new[] { e0 });
      if (expectedSize >= 2) expected.Add(e1);
      if (expectedSize >= 3) expected.Add(e2);
      if (expectedSize >= 4) expected.Add(e3);

      BigEndianByteIndexerUInt32 sut = data;
      Assert.Equal(expected.ToArray(), sut.Slice(index, size));
   }
}
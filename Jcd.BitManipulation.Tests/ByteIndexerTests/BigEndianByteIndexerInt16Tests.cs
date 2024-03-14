﻿#region

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

public class BigEndianByteIndexerInt16Tests
{
   [Fact]
   public void Constant_ByteSize_Is_Two() { Assert.Equal(sizeof(short), BigEndianByteIndexerInt16.ByteSize); }

   [Fact]
   public void Length_Is_BitSize()
   {
      BigEndianByteIndexerInt16 sut = 0;
      Assert.Equal(BigEndianByteIndexerInt16.ByteSize, sut.Length);
   }

   [Theory]
   [InlineData(0x01FF)]
   [InlineData(0x20FE)]
   [InlineData(0x337F)]
   [InlineData(0b111001100011000)]
   public void Implicit_Conversion_Operators_Round_Trip_Returns_Original_Value(uint data)
   {
      var                       expected      = (short) data;
      BigEndianByteIndexerInt16 sut           = expected;
      short                     convertedBack = sut;
      Assert.Equal(expected, convertedBack);
   }

   [Theory]
   [InlineData(0x01FF, 1, 0xFF)]
   [InlineData(0x02FE, 1, 0xFE)]
   [InlineData(0x037F, 1, 0x7F)]
   [InlineData(0x01FF, 0, 0x01)]
   [InlineData(0x02FE, 0, 0x02)]
   [InlineData(0x037F, 0, 0x03)]
   public void Indexer_Get_Returns_Expected_Value(uint data, int index, byte extractedData)
   {
      var                       expected = (short) extractedData;
      BigEndianByteIndexerInt16 sut      = (short) data;
      Assert.Equal(expected, sut[index]);
   }

   [Theory]
   [InlineData(0x0101, 0, 0x7F, 0x7F01)]
   [InlineData(0x0202, 0, 0x7E, 0x7E02)]
   [InlineData(0x0303, 0, 0x7D, 0x7D03)]
   [InlineData(0x0101, 1, 0xFF, 0x01FF)]
   [InlineData(0x0202, 1, 0xFE, 0x02FE)]
   [InlineData(0x0303, 1, 0x7F, 0x037F)]
   public void Indexer_Set_Sets_The_Expected_Value(short data, int index, byte dataToSet, short expected)
   {
      BigEndianByteIndexerInt16 sut = data;
      sut[index] = dataToSet;
      Assert.Equal(expected, (short) sut);
   }

   [Theory]
   [InlineData(-1)]
   [InlineData(BigEndianByteIndexerInt16.ByteSize)]
   public void Indexer_Get_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
   {
      BigEndianByteIndexerInt16 sut = 0xFF;
      Assert.Throws<ArgumentOutOfRangeException>(() => sut[index]);
   }

   [Theory]
   [InlineData(-1)]
   [InlineData(LittleEndianByteIndexerInt32.ByteSize)]
   public void Indexer_Set_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
   {
      BigEndianByteIndexerInt16 sut = 0xFF;
      Assert.Throws<ArgumentOutOfRangeException>(() => sut[index] = 0);
   }

   [Theory]
   [InlineData(0xFF01, 0, 1, 1, 0xFF)]
   [InlineData(0xFE02, 0, 1, 1, 0xFE)]
   [InlineData(0x7F03, 0, 1, 1, 0x7F)]
   [InlineData(0xFF01, 1, 1, 1, 0x01)]
   [InlineData(0xFE02, 1, 1, 1, 0x02)]
   [InlineData(0x7F03, 1, 1, 1, 0x03)]
   [InlineData(0xFF01
             , 0
             , 2
             , 2
             , 0xFF
             , 0x01
              )]
   [InlineData(0xFE02
             , 0
             , 2
             , 2
             , 0xFE
             , 0x02
              )]
   [InlineData(0x7F03
             , 0
             , 2
             , 2
             , 0x7F
             , 0x03
              )]
   public void Slice_Returns_Expected_Subset(
      ushort udata
    , int    index
    , int    size
    , int    expectedSize
    , byte   e0
    , byte   e1 = 0
   )
   {
      var data     = (short) udata;
      var expected = new List<byte>(new[] { e0 });
      if (expectedSize >= 2) expected.Add(e1);

      BigEndianByteIndexerInt16 sut = data;
      Assert.Equal(expected.ToArray(), sut.Slice(index, size));
   }
}
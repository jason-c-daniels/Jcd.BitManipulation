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

public class LittleEndianByteIndexerUInt64Tests
{
   [Fact]
   public void Length_Is_BitSize()
   {
      LittleEndianByteIndexer sut = 0ul;
      Assert.Equal(sizeof(ulong), sut.Length);
   }

   [Theory]
   [InlineData(0x01FF)]
   [InlineData(0x20FE)]
   [InlineData(0x337F)]
   [InlineData(0b111001100011000)]
   public void Implicit_Conversion_Operators_Round_Trip_Returns_Original_Value(ulong data)
   {
      var expected = data;
      LittleEndianByteIndexer sut = expected;
      ulong convertedBack = sut;
      Assert.Equal(expected, convertedBack);
   }

   [Theory]
   [InlineData(0x01FF, 0, 0xFF)]
   [InlineData(0x02FE, 0, 0xFE)]
   [InlineData(0x037F, 0, 0x7F)]
   [InlineData(0x01FF, 1, 0x01)]
   [InlineData(0x02FE, 1, 0x02)]
   [InlineData(0x037F, 1, 0x03)]
   public void Indexer_Get_Returns_Expected_Value(ulong data, int index, byte expected)
   {
      LittleEndianByteIndexer sut = data;
      Assert.Equal(expected, sut[index]);
   }

   [Theory]
   [InlineData(0x0101010101010101, 7, 0x7F, 0x7F01010101010101)]
   [InlineData(0x0202020202020202, 6, 0x7E, 0x027E020202020202)]
   [InlineData(0x0303030303030303, 5, 0x7D, 0x03037D0303030303)]
   [InlineData(0x0404040404040404, 4, 0x7C, 0x0404047C04040404)]
   [InlineData(0x0505050505050505, 3, 0x7B, 0x050505057B050505)]
   [InlineData(0x0606060606060606, 2, 0x7A, 0x06060606067A0606)]
   [InlineData(0x0707070707070707, 1, 0x79, 0x0707070707077907)]
   [InlineData(0x0808080808080808, 0, 0x78, 0x0808080808080878)]
   public void Indexer_Set_Sets_The_Expected_Value(ulong data, int index, byte dataToSet, ulong expected)
   {
      LittleEndianByteIndexer sut = data;
      sut[index] = dataToSet;
      Assert.Equal(expected, (ulong) sut);
   }

   [Theory]
   [InlineData(-1)]
   [InlineData(sizeof(ulong))]
   public void Indexer_Get_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                 {
                                                    LittleEndianByteIndexer sut = 0xFFul;

                                                    return sut[index];
                                                 }
                                                );
   }

   [Theory]
   [InlineData(-1)]
   [InlineData(sizeof(ulong))]
   public void Indexer_Set_Throws_Exception_When_Index_Is_Out_Of_Range(int index)
   {
      Assert.Throws<ArgumentOutOfRangeException>(() =>
                                                 {
                                                    LittleEndianByteIndexer sut = 0xFFul;

                                                    return sut[index] = 0;
                                                 }
                                                );
   }

   [Theory]
   [InlineData(0x00000000010101FF, 0, 1, 1, 0xFF)]
   [InlineData(0x00000000010202FE, 0, 2, 2, 0xFE, 0x02)]
   [InlineData(0x000000000102037F, 0, 3, 3, 0x7F, 0x03, 0x02)]
   [InlineData(0x00000000030201FF, 0, 4, 4, 0xFF, 0x01, 0x02, 0x03)]
   [InlineData(0x07060504030201FF, 0, 5, 5, 0xFF, 0x01, 0x02, 0x03, 0x04)]
   [InlineData(0x07060504030201FF, 0, 6, 6, 0xFF, 0x01, 0x02, 0x03, 0x04, 0x05)]
   [InlineData(0x07060504030201FF, 0, 7, 7, 0xFF, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06)]
   [InlineData(0x07060504030201FF, 0, 8, 8, 0xFF, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07)]
   [InlineData(0x00000000040302FE, 1, 3, 3, 0x02, 0x03, 0x04)]
   [InlineData(0x0000000005060708, 2, 2, 2, 0x06, 0x05)]
   [InlineData(0x000000000F060708, 3, 1, 1, 0x0F)]
   public void Slice_Returns_Expected_Subset(
      ulong data, int index, int size, int expectedSize, byte e0, byte e1 = 0, byte e2 = 0, byte e3 = 0, byte e4 = 0, byte e5 = 0, byte e6 = 0, byte e7 = 0
   )
   {
      var expected = new List<byte>(new[] { e0 });
      if (expectedSize >= 2)
         expected.Add(e1);
      if (expectedSize >= 3)
         expected.Add(e2);
      if (expectedSize >= 4)
         expected.Add(e3);
      if (expectedSize >= 5)
         expected.Add(e4);
      if (expectedSize >= 6)
         expected.Add(e5);
      if (expectedSize >= 7)
         expected.Add(e6);
      if (expectedSize == 8)
         expected.Add(e7);

      LittleEndianByteIndexer sut = data;
      Assert.Equal(expected.ToArray(), sut.Slice(index, size));
   }
}
﻿#region

using Jcd.BitManipulation.BitIndexers;

using Xunit;

// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Possible

#endregion

namespace Jcd.BitManipulation.Tests.BitIndexersTests;

public class BitIndexerSingleTests
{
   [Fact]
   public void Length_Is_Correct_Bit_Size()
   {
      BitIndexer sut = 0f;
      Assert.Equal(32, sut.Length);
   }

   [Theory]
   [InlineData(0x0FFF)]
   [InlineData(0x7DFE)]
   [InlineData(0x7FD1)]
   [InlineData(0b00011000)]
   public void Implicit_Operator_To_BitIndexerSingle_From_Single_Sets_All_Bits_Correctly(uint data)
   {
      var fdata = data.BitwiseToSingle();
      BitIndexer indexer = fdata;
      Assert.Equal(fdata, (float) indexer);
   }

   [Theory]
   [InlineData(0xFF)]
   [InlineData(0xFE)]
   [InlineData(0x7F)]
   [InlineData(0b00011000)]
   public void Implicit_Operator_From_BitIndexerSingle_To_Single_Sets_All_Bits_Correctly(uint data)
   {
      var fdata = data.BitwiseToSingle();
      BitIndexer indexer = fdata;
      float bits = indexer;

      Assert.Equal(fdata, bits);
   }

   [Theory]
   [InlineData(0b0101010101000001)]
   [InlineData(0b1010101001000001)]
   [InlineData(0b1011111001000001)]
   [InlineData(0b0100000101000001)]
   public void Indexer_Returns_Correct_Bit_Value(uint data)
   {
      BitIndexer indexer = data.BitwiseToSingle();
      uint mask = 0;

      for (var i = 0; i < indexer.Length; i++)
      {
         mask = mask.SetBit(i);
         var bit = (data & mask) != 0;
         Assert.Equal(bit, indexer[i]);
         mask = mask.ClearBit(i);
      }
   }

   [Theory]
   [InlineData(0)]
   [InlineData(2)]
   [InlineData(6)]
   [InlineData(14)]
   public void Indexer_Sets_Correct_Bit_Value(int index)
   {
      BitIndexer indexer = 0;
      float expected = 0;
      expected = expected.SetBit(index);
      indexer[index] = true;
      Assert.Equal(expected, (float) indexer);
      Assert.True(indexer[index]);
      indexer[index] = false;
      Assert.False(indexer[index]);
   }

   [Theory]
   [InlineData(0b00000000000000000000000000000000, "0b00000000000000000000000000000000")]
   [InlineData(0b00100000000111000000000000000000, "0b00100000000111000000000000000000")]
   [InlineData(0b00000000000000001110000000000000, "0b00000000000000001110000000000000")]
   public void ToString_Formats_As_Binary_Int_Representation(uint data, string expected)
   {
      BitIndexer indexer = data.BitwiseToSingle();
      Assert.Equal(expected, indexer.ToString());
   }

   [Theory]
   [InlineData(0b00011100, 0, 4)]
   [InlineData(0b00011100, 2, 6)]
   [InlineData(0b00011100, 0, 8)]
   public void Slice_Returns_Correct_Subset_Of_Bools(uint data, int start, int end)
   {
      BitIndexer indexer = data.BitwiseToSingle();
      var bits = data.ToBooleanArray();
      var expected = bits[start..end];
      var actual = indexer[start..end];
      Assert.Equal(expected, actual);
   }
}
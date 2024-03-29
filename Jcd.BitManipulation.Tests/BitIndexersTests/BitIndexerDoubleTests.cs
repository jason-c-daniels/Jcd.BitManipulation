#region

using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests.BitIndexersTests;

public class BitIndexerDoubleTests
{
   [Fact]
   public void Length_Is_Correct_Bit_Size()
   {
      Assert.Equal(64, ((BitIndexer) 0d).Length);
   }

   [Theory]
   [InlineData(0x0FFF)]
   [InlineData(0x7DFE)]
   [InlineData(0x7FD1)]
   [InlineData(0b00011000)]
   public void Implicit_Operator_To_BitIndexerDouble_From_Double_Sets_All_Bits_Correctly(ulong data)
   {
      BitIndexer indexer = data.BitwiseToDouble();
      Assert.Equal(data.BitwiseToDouble(), (double) indexer);
   }

   [Theory]
   [InlineData(0xFF)]
   [InlineData(0xFE)]
   [InlineData(0x7F)]
   [InlineData(0b00011000)]
   public void Implicit_Operator_From_BitIndexerDouble_To_Double_Sets_All_Bits_Correctly(ulong data)
   {
      var expected = data.BitwiseToDouble();
      BitIndexer indexer = data.BitwiseToDouble();
      double actual = indexer;

      Assert.Equal(expected, actual);
   }

   [Theory]
   [InlineData(0b0101010101000001)]
   [InlineData(0b1010101001000001)]
   [InlineData(0b1011111001000001)]
   [InlineData(0b0100000101000001)]
   public void Indexer_Returns_Correct_Bit_Value(ulong data)
   {
      BitIndexer indexer = data.BitwiseToDouble();
      ulong mask = 0;

      for (var i = 0; i < indexer.Length; i++)
      {
         mask = mask.SetBit(i);
         var expected = (data & mask) != 0;
         Assert.Equal(expected, indexer[i]);
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
      BitIndexer indexer = 0ul;
      double expected = 0;
      expected = expected.SetBit(index);
      indexer[index] = true;
      Assert.Equal(expected, (double) indexer);
      Assert.True(indexer[index]);
      indexer[index] = false;
      Assert.False(indexer[index]);
   }

   [Theory]
   [InlineData(0b0000000000000000000000000000000000000000000000000000000000000100, "0b0000000000000000000000000000000000000000000000000000000000000100")]
   [InlineData(0b0010000000011100000000000000000000000000000000000000000000000000, "0b0010000000011100000000000000000000000000000000000000000000000000")]
   [InlineData(0b0000000000000000111000000000000000000000000000000000000000000000, "0b0000000000000000111000000000000000000000000000000000000000000000")]
   public void ToString_Formats_As_Binary_Int_Representation(ulong data, string expected)
   {
      BitIndexer indexer = data.BitwiseToDouble();
      Assert.Equal(expected, indexer.ToString());
   }

   [Theory]
   [InlineData(0b00011100, 0, 4)]
   [InlineData(0b00011100, 2, 6)]
   [InlineData(0b00011100, 0, 8)]
   public void Slice_Returns_Correct_Subset_Of_Bools(ulong data, int start, int end)
   {
      BitIndexer indexer = data.BitwiseToDouble();
      var bits = data.ToBooleanArray();

      // ReSharper disable once HeapView.ObjectAllocation
      var expected = bits[start..end];
      var actual = indexer[start..end];
      Assert.Equal(expected, actual);
   }
}
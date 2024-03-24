#region

using System;

using Xunit;

// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Possible

#endregion

namespace Jcd.BitManipulation.Tests.BitIndexersTests;

public class BitIndexerInt64Tests
{
   [Fact]
   public void Length_Is_Correct_Bit_Size()
   {
      BitIndexer sut = (long) 0;
      Assert.Equal(64, sut.Length);
   }

   [Theory]
   [InlineData(0x0FFF)]
   [InlineData(0x7DFE)]
   [InlineData(0x7FD1)]
   [InlineData(0b00011000)]
   public void Implicit_Operator_To_BitIndexerInt64_From_Int64_Sets_All_Bits_Correctly(long data)
   {
      BitIndexer indexer = data;
      Assert.Equal(data, (long) indexer);
   }

   [Theory]
   [InlineData(0xFF)]
   [InlineData(0xFE)]
   [InlineData(0x7F)]
   [InlineData(0b00011000)]
   public void Implicit_Operator_From_BitIndexerInt64_To_Int64_Sets_All_Bits_Correctly(long data)
   {
      BitIndexer indexer = data;
      long bits = indexer;

      Assert.Equal((long) indexer, bits);
   }

   [Theory]
   [InlineData(0b0101010101000001)]
   [InlineData(0b1010101001000001)]
   [InlineData(0b1011111001000001)]
   [InlineData(0b0100000101000001)]
   public void Indexer_Returns_Correct_Bit_Value(long data)
   {
      BitIndexer indexer = data;
      long mask = 0;

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
      long expected = 0;
      expected = expected.SetBit(index);
      indexer[index] = true;
      Assert.Equal(expected, (long) indexer);
      Assert.True(indexer[index]);
      indexer[index] = false;
      Assert.False(indexer[index]);
   }

   [Fact]
   public void Enumerator_Enumerates_Correct_Number_Of_Bits()
   {
      BitIndexer indexer = 0x7Eul;
      Assert.Equal(64, indexer.Length);
   }

   [Theory]
   [InlineData(0b0000000000000000000000000000000000000000000000000000000000000100, "0b0000000000000000000000000000000000000000000000000000000000000100")]
   [InlineData(0b0010000000011100000000000000000000000000000000000000000000000000, "0b0010000000011100000000000000000000000000000000000000000000000000")]
   [InlineData(0b0000000000000000111000000000000000000000000000000000000000000000, "0b0000000000000000111000000000000000000000000000000000000000000000")]
   public void ToString_Formats_As_Binary_Int_Representation(long data, string expected)
   {
      BitIndexer indexer = data;
      Assert.Equal(expected, indexer.ToString());
   }

   [Theory]
   [InlineData(0b00011100, 0, 4)]
   [InlineData(0b00011100, 2, 6)]
   [InlineData(0b00011100, 0, 8)]
   public void Slice_Returns_Correct_Subset_Of_Bools(long data, int start, int end)
   {
      BitIndexer indexer = data;
      var bits = data.ToBooleanArray();
      var expected = bits[start..end];
      var actual = indexer[start..end];
      Assert.Equal(expected, actual);
   }
}

public static class RuntimeHelpers
{
   /// <summary>
   /// Slices the specified array using the specified range.
   /// </summary>
   public static T[] GetSubArray<T>(T[] array, Range range)
   {
      if (array == null)
         throw new ArgumentNullException(nameof(array));

      var (offset, length) = range.GetOffsetAndLength(array.Length);

      if (length == 0)
         return Array.Empty<T>();

      ReadOnlySpan<T> span = array;
      var subset = span.Slice(offset, length);

      return subset.ToArray();
   }
}
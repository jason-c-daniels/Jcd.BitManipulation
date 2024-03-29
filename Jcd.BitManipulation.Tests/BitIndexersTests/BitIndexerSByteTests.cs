#region

using Xunit;

// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Possible

#endregion

namespace Jcd.BitManipulation.Tests.BitIndexersTests;

public class BitIndexerSByteTests
{
   [Fact]
   public void Length_Is_Correct_Bit_Size()
   {
      BitIndexer sut = (sbyte) 0;
      Assert.Equal(8, sut.Length);
   }

   [Theory]
   [InlineData(0x7F)]
   [InlineData(0x7E)]
   [InlineData(0x7C)]
   [InlineData(0b00011000)]
   public void Implicit_Operator_To_BitIndexerSByte_From_Byte_Sets_All_Bits_Correctly(sbyte data)
   {
      var bits = data;
      BitIndexer indexer = bits;
      Assert.Equal(data, (sbyte) indexer);
   }

   [Theory]
   [InlineData(0x7F)]
   [InlineData(0x7E)]
   [InlineData(0x7C)]
   [InlineData(0b00011000)]
   public void Implicit_Operator_From_BitIndexerSByte_To_Byte_Sets_All_Bits_Correctly(sbyte data)
   {
      // HACK: Type binder for xUnit hates bytes as params. Coerce the value here.
      BitIndexer indexer = data;
      sbyte bits = indexer;

      Assert.Equal(data, bits);
   }

   [Theory]
   [InlineData(0b01010101)]
   [InlineData(0b10101010)]
   [InlineData(0b10111110)]
   [InlineData(0b01000001)]
   public void Indexer_Returns_Correct_Bit_Value(uint data)
   {
      var value = (sbyte) data;
      BitIndexer indexer = value;
      byte mask = 0;

      for (var i = 0; i < indexer.Length; i++)
      {
         mask = mask.SetBit(i);
         var bit = (value & mask) > 0;
         Assert.Equal(bit, indexer[i]);
         mask = mask.ClearBit(i);
      }
   }

   [Theory]
   [InlineData(0)]
   [InlineData(2)]
   [InlineData(6)]
   public void Indexer_Sets_Correct_Bit_Value(int index)
   {
      BitIndexer indexer = 0;
      sbyte expected = 0;
      expected = expected.SetBit(index);
      indexer[index] = true;
      Assert.Equal(expected, (sbyte) indexer);
      Assert.True(indexer[index]);
      indexer[index] = false;
      Assert.False(indexer[index]);
   }

   [Theory]
   [InlineData(0b00000000, "0b00000000")]
   [InlineData(0b00011100, "0b00011100")]
   [InlineData(0b11100000, "0b11100000")]
   public void ToString_Formats_As_Binary_Int_Representation(byte data, string expected)
   {
      BitIndexer indexer = (sbyte) data;
      Assert.Equal(expected, indexer.ToString());
   }

   [Theory]
   [InlineData(0b00011100, 0, 4)]
   [InlineData(0b00011100, 2, 6)]
   [InlineData(0b00011100, 0, 8)]
   public void Slice_Returns_Correct_Subset_Of_Bools(sbyte data, int start, int end)
   {
      BitIndexer indexer = data;
      var bits = data.ToBooleanArray();
      var expected = bits[start..end];
      var actual = indexer[start..end];
      Assert.Equal(expected, actual);
   }
}
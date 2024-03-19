#region

using System.Collections;
using System.Linq;

using Jcd.BitManipulation.BitIndexers;

using Xunit;

// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation.Possible

#endregion

namespace Jcd.BitManipulation.Tests.BitIndexersTests;

public class BitIndexerDoubleTests
{
   [Fact]
   public void Constant_Bit_Size_Is_64_Bits() { Assert.Equal(64, BitIndexerDouble.BitSize); }

   [Fact]
   public void Length_Is_Bit_Size() { Assert.Equal(BitIndexerDouble.BitSize, new BitIndexerDouble().Length); }

   [Theory]
   [InlineData(0x0FFF)]
   [InlineData(0x7DFE)]
   [InlineData(0x7FD1)]
   [InlineData(0b00011000)]
   public void Implicit_Operator_To_BitIndexerDouble_From_Double_Sets_All_Bits_Correctly(ulong data)
   {
      BitIndexerDouble indexer = data;
      Assert.Equal(data, indexer.Bits);
   }

   [Theory]
   [InlineData(0xFF)]
   [InlineData(0xFE)]
   [InlineData(0x7F)]
   [InlineData(0b00011000)]
   public void Implicit_Operator_From_BitIndexerDouble_To_Double_Sets_All_Bits_Correctly(ulong data)
   {
      var    expected = data.BitwiseToDouble();
      var    indexer  = new BitIndexerDouble { Bits = expected };
      double actual   = indexer;

      Assert.Equal(expected, actual);
   }

   [Theory]
   [InlineData(0b0101010101000001)]
   [InlineData(0b1010101001000001)]
   [InlineData(0b1011111001000001)]
   [InlineData(0b0100000101000001)]
   public void Indexer_Returns_Correct_Bit_Value(ulong data)
   {
      BitIndexerDouble indexer = data.BitwiseToDouble();
      ulong            mask    = 0;

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
      BitIndexerDouble indexer  = 0;
      double           expected = 0;
      expected       = expected.SetBit(index);
      indexer[index] = true;
      Assert.Equal(expected, indexer.Bits);
      Assert.True(indexer[index]);
      indexer[index] = false;
      Assert.False(indexer[index]);
   }

   [Fact]
   public void Enumerator_Enumerates_Correct_Number_Of_Bits()
   {
      var indexer = new BitIndexerDouble { Bits = 0x7Eul.BitwiseToDouble() };
      Assert.Equal(BitIndexerDouble.BitSize, indexer.ToArray().Length);
   }

   [Theory]
   [InlineData(0b10101000000000)]
   [InlineData(0b11101100000000)]
   public void Enumerator_Enumerates_Bits_In_Correct_Order_LSB_to_MSB(ulong data)
   {
      var indexer   = new BitIndexerDouble { Bits = data.BitwiseToDouble() };
      var bitValues = indexer.ToArray();

      for (var i = 0; i < indexer.Length; i++) Assert.Equal(indexer.Bits.ReadBit(i), bitValues[i]);
   }

   [Theory]
   [InlineData(0b0000000000000000000000000000000000000000000000000000000000000100, "0b0000000000000000000000000000000000000000000000000000000000000100")]
   [InlineData(0b0010000000011100000000000000000000000000000000000000000000000000, "0b0010000000011100000000000000000000000000000000000000000000000000")]
   [InlineData(0b0000000000000000111000000000000000000000000000000000000000000000, "0b0000000000000000111000000000000000000000000000000000000000000000")]
   public void ToString_Formats_As_Binary_Int_Representation(ulong data, string expected)
   {
      var indexer = new BitIndexerDouble { Bits = data.BitwiseToDouble() };
      Assert.Equal(expected, indexer.ToString());
   }

   [Theory]
   [InlineData(0b00011100, 0, 4)]
   [InlineData(0b00011100, 2, 6)]
   [InlineData(0b00011100, 0, 8)]
   public void Slice_Returns_Correct_Subset_Of_Bools(ulong data, int start, int end)
   {
      var indexer  = new BitIndexerDouble { Bits = data.BitwiseToDouble() };
      var bits     = indexer.ToArray();
      var expected = bits[start..end];
      var actual   = indexer[start..end];
      Assert.Equal(expected, actual);
   }

   [Fact]
   public void IEnumerable_GetEnumerator_Enumerates_The_Correct_Number_Of_Items()
   {
      var itemCount  = 0;
      var enumerable = (IEnumerable) new BitIndexerDouble { Bits = 0x7FFFul.BitwiseToDouble() };

      foreach (var item in enumerable)
      {
         Assert.IsType<bool>(item);
         itemCount++;
      }

      Assert.Equal(BitIndexerDouble.BitSize, itemCount);
   }
}
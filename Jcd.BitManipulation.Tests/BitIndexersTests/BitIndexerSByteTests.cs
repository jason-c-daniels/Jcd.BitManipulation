#region

using System.Collections;
using System.Linq;

using Jcd.BitManipulation.BitIndexers;

using Xunit;

// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Possible

#endregion

namespace Jcd.BitManipulation.Tests.BitIndexersTests;

public class BitIndexerSByteTests
{
   [Fact]
   public void Constant_Bit_Size_Is_8_Bits() { Assert.Equal(8, BitIndexerSByte.BitSize); }

   [Fact]
   public void Length_Is_Bit_Size() { Assert.Equal(BitIndexerSByte.BitSize, new BitIndexerSByte().Length); }

   [Theory]
   [InlineData(0xFF)]
   [InlineData(0xFE)]
   [InlineData(0x7F)]
   [InlineData(0b00011000)]
   public void Implicit_Operator_To_BitIndexerSByte_From_Byte_Sets_All_Bits_Correctly(uint data)
   {
      // HACK: Type binder for xUnit hates bytes as params. Coerce the value here.
      var             bits    = (sbyte) data;
      BitIndexerSByte indexer = bits;
      Assert.Equal(bits, indexer.Bits);
   }

   [Theory]
   [InlineData(0xFF)]
   [InlineData(0xFE)]
   [InlineData(0x7F)]
   [InlineData(0b00011000)]
   public void Implicit_Operator_From_BitIndexerSByte_To_Byte_Sets_All_Bits_Correctly(uint data)
   {
      // HACK: Type binder for xUnit hates bytes as params. Coerce the value here.
      var   indexer = new BitIndexerSByte { Bits = (sbyte) data };
      sbyte bits    = indexer;

      Assert.Equal(indexer.Bits, bits);
   }

   [Theory]
   [InlineData(0b01010101)]
   [InlineData(0b10101010)]
   [InlineData(0b10111110)]
   [InlineData(0b01000001)]
   public void Indexer_Returns_Correct_Bit_Value(uint data)
   {
      var             value   = (sbyte) data;
      BitIndexerSByte indexer = value;
      byte            mask    = 0;

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
      BitIndexerSByte indexer  = 0;
      sbyte           expected = 0;
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
      var indexer = new BitIndexerSByte { Bits = 0x7e };
      Assert.Equal(BitIndexerSByte.BitSize, indexer.ToArray().Length);
   }

   [Theory]
   [InlineData(0b101010)]
   [InlineData(0b111011)]
   public void Enumerator_Enumerates_Bits_In_Correct_Order_LSB_to_MSB(int data)
   {
      var indexer   = new BitIndexerSByte { Bits = (sbyte) data };
      var bitValues = indexer.ToArray();

      for (var i = 0; i < indexer.Length; i++) Assert.Equal(indexer.Bits.ReadBit(i), bitValues[i]);
   }

   [Theory]
   [InlineData(0b00000000, "0b00000000")]
   [InlineData(0b00011100, "0b00011100")]
   [InlineData(0b11100000, "0b11100000")]
   public void ToString_Formats_As_Binary_Int_Representation(uint data, string expected)
   {
      var indexer = new BitIndexerSByte { Bits = (sbyte) data };
      Assert.Equal(expected, indexer.ToString());
   }

   [Theory]
   [InlineData(0b00011100, 0, 4)]
   [InlineData(0b00011100, 2, 6)]
   [InlineData(0b00011100, 0, 8)]
   public void Slice_Returns_Correct_Subset_Of_Bools(uint data, int start, int end)
   {
      var indexer  = new BitIndexerSByte { Bits = (sbyte) data };
      var bits     = indexer.ToArray();
      var expected = bits[start..end];
      var actual   = indexer[start..end];
      Assert.Equal(expected, actual);
   }

   [Fact]
   public void IEnumerable_GetEnumerator_Enumerates_The_Correct_Number_Of_Items()
   {
      var itemCount  = 0;
      var enumerable = (IEnumerable) new BitIndexerSByte { Bits = -7 };

      foreach (var item in enumerable)
      {
         Assert.IsType<bool>(item);
         itemCount++;
      }

      Assert.Equal(BitIndexerSByte.BitSize, itemCount);
   }
}
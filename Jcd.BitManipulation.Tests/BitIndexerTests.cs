#region

using Xunit;

#endregion

// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Possible

namespace Jcd.BitManipulation.Tests;

public class BitIndexerTests
{
   public static TheoryData<object, int> ValuesAndSizes
      => new()
         {
            { 0x02000000CC000001ul, 64 }
          , { 0x01000000CC000001L, 64 }
          , { 0x01000002u, 32 }
          , { 0x01000001, 32 }
          , { (short) 0x0100, 16 }
          , { (ushort) 0x0200, 16 }
          , { 0x0FFC00A0.BitwiseToSingle(), 32 }
          , { 0xCFEFEFEF0FFC00A0.BitwiseToDouble(), 64 }
          , { (byte) 0xFC, 8 }
          , { (sbyte) 0x7E, 8 }
          , { (bool[]) [true, true, false, false, true, true, true, true], 8 }
          , { (bool[]) [true, true, false, false, true, true, true, true, false], 16 }
           ,
            {
               (bool[])
               [
                  true
                , true
                , false
                , false
                , true
                , true
                , true
                , true
                , true
                , true
                , false
                , false
                , true
                , true
                , true
                , true
               ]
             , 16
            }
           ,
            {
               (bool[])
               [
                  true
                , true
                , false
                , false
                , true
                , true
                , true
                , true
                , false
                , true
                , true
                , false
                , false
                , true
                , true
                , true
                , true
               ]
             , 32
            }
           ,
            {
               (bool[])
               [
                  true
                , true
                , false
                , false
                , true
                , true
                , true
                , true
                , true
                , true
                , false
                , false
                , true
                , true
                , true
                , true
                , true
                , true
                , false
                , false
                , true
                , true
                , true
                , true
                , true
                , true
                , false
                , false
                , true
                , true
                , true
                , true
               ]
             , 32
            }
           ,
            {
               (bool[])
               [
                  true
                , true
                , false
                , false
                , true
                , true
                , true
                , true
                , true
                , true
                , false
                , false
                , true
                , true
                , true
                , true
                , true
                , true
                , false
                , false
                , true
                , true
                , true
                , true
                , true
                , true
                , false
                , false
                , true
                , true
                , true
                , true
                , false
               ]
             , 64
            }
         };

   public static TheoryData<object, string> ValuesAndStrings
      => new()
         {
            { 0b1000111110100101100011111010010110001111101001011000111110100101, "0b1000111110100101100011111010010110001111101001011000111110100101" }
          , { 0b00000111110100101100011111010010110001111101001011000111110100101, "0b0000111110100101100011111010010110001111101001011000111110100101" }
          , { 0b10001111101001011000111110100100, "0b10001111101001011000111110100100" }
          , { 0b00000111110100101100011111010010, "0b00000111110100101100011111010010" }
          , { (ushort) 0b1000111110100100, "0b1000111110100100" }
          , { (short) 0b0000011111010010, "0b0000011111010010" }
          , { 0b10001111101001011000111110100100.BitwiseToSingle(), "0b10001111101001011000111110100100" }
           ,
            {
               0b1000111110100101100011111010010110001111101001011000111110100101.BitwiseToDouble()
             , "0b1000111110100101100011111010010110001111101001011000111110100101"
            }
          , { (byte) 0b11110011, "0b11110011" }
          , { (sbyte) 0b01110011, "0b01110011" }
          , { (bool[]) [true, true, false, false, true, true, true, true], "0b11110011" }
         };

   [Theory]
   [MemberData(nameof(ValuesAndSizes))]
   public void Conversion_Operator_Sets_Expected_Values(object item, int bitSize)
   {
      var sut = GetBitIndexer(item);
      Assert.Equal(bitSize,        sut.Length);
      Assert.Equal(ToUInt64(item), (ulong) sut);
   }

   [Theory]
   [MemberData(nameof(ValuesAndSizes))]
   public void Indexer_Returns_Correct_Bit_Value(object item, int bitSize)
   {
      var indexer = GetBitIndexer(item);
      var value = ToUInt64(item);
      var mask = 0ul;

      Assert.Equal(bitSize, indexer.Length);

      for (var i = 0; i < indexer.Length; i++)
      {
         mask = mask.SetBit(i);
         var bit = (value & mask) != 0;
         var actual = indexer[i];
         Assert.Equal(bit, actual);
         mask = mask.ClearBit(i);
      }
   }

   [Theory]
   [MemberData(nameof(ValuesAndSizes))]
   public void Indexer_Sets_No_Bit_Value_When_Index_Is_Out_Of_Range(object item, int bitSize)
   {
      var indexer = GetBitIndexer(item);
      ulong expected = indexer;
      indexer[-1] = true;
      Assert.Equal(expected, (ulong) indexer);
      Assert.False(indexer[-1]);
      indexer[bitSize + 1] = true;
      Assert.Equal(expected, (ulong) indexer);
      Assert.False(indexer[bitSize + 1]);
   }

   [Theory]
   [InlineData(0)]
   [InlineData(2)]
   [InlineData(6)]
   [InlineData(8)]
   [InlineData(14)]
   [InlineData(16)]
   [InlineData(30)]
   [InlineData(34)]
   [InlineData(60)]
   [InlineData(63)]
   public void Indexer_Sets_Correct_Bit_Value(int index)
   {
      BitIndexer indexer = 0ul;
      var expected = 0ul;
      expected = expected.SetBit(index);
      indexer[index] = true;
      Assert.Equal(expected, (ulong) indexer);
      Assert.True(indexer[index]);
      indexer[index] = false;
      Assert.False(indexer[index]);
   }

   [Theory]
   [MemberData(nameof(ValuesAndStrings))]
   public void ToString_Formats_As_Binary_Representation(object data, string expected)
   {
      var indexer = GetBitIndexer(data);
      Assert.Equal(expected, indexer.ToString());
   }

   [Theory]
   [InlineData(0b1000111110100101100011111010010110001111101001011000111110100101, 0,  1)]
   [InlineData(0b1000111110100101100011111010010110001111101001011000111110100101, 0,  2)]
   [InlineData(0b1000111110100101100011111010010110001111101001011000111110100101, 0,  3)]
   [InlineData(0b1000111110100101100011111010010110001111101001011000111110100101, 0,  4)]
   [InlineData(0b1000111110100101100011111010010110001111101001011000111110100101, 10, 1)]
   [InlineData(0b1000111110100101100011111010010110001111101001011000111110100101, 10, 2)]
   [InlineData(0b1000111110100101100011111010010110001111101001011000111110100101, 10, 3)]
   [InlineData(0b1000111110100101100011111010010110001111101001011000111110100101, 10, 4)]
   [InlineData(0b1000111110100101100011111010010110001111101001011000111110100101, 2,  6)]
   [InlineData(0b1000111110100101100011111010010110001111101001011000111110100101, 0,  8)]
   [InlineData(0b1000111110100101100011111010010110001111101001011000111110100101, 58, 6)]
   public void Slice_Returns_Correct_Subset_Of_Bools(ulong data, int start, int length)
   {
      BitIndexer indexer = data;
      var bits = data.ToBooleanArray();
      var expected = bits[start..(start + length)];
      var actual = indexer.Slice(start, length);
      Assert.Equal(expected, actual);
   }

   #region Helpers

   private static ulong ToUInt64(object o)
   {
      return o switch
             {
                ulong ul  => ul
              , long l    => (ulong) l
              , uint ui   => ui
              , int i     => (ulong) i
              , ushort us => us
              , short us  => (ulong) us
              , sbyte sb  => (ulong) sb
              , byte b    => b
              , float f   => f.BitwiseToUInt32()
              , double d  => d.BitwiseToUInt64()
              , bool[] ba => BitArrayToUInt64(ba)
              , _         => 0xDEADBEEFFA17C0DEul
             };
   }

   private static ulong BitArrayToUInt64(bool[] bits)
   {
      var result = 0ul;

      for (var i = 0; i < bits.Length; i++)
      {
         result = result.StoreBit(bits[i], i);
      }

      return result;
   }

   private static BitIndexer GetBitIndexer(object o)
   {
      return o switch
             {
                ulong ul  => ul
              , long l    => l
              , uint ui   => ui
              , int i     => i
              , ushort us => us
              , short us  => us
              , sbyte sb  => sb
              , byte b    => b
              , float f   => f
              , double d  => d
              , bool[] ba => (BitIndexer) ba
              , _         => 0xDEADBEEFFA17C0DEul
             };
   }

   #endregion
}
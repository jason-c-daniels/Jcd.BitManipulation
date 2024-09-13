#region

using System.Collections.Generic;

using Jcd.BitManipulation.Algorithms;

using Xunit;

#pragma warning disable CA1868

#endregion

namespace Jcd.BitManipulation.Tests.Algorithms;

public class Int32AlgorithmsExtensionsTests
{
   private const int BitSize = 32;

   private const int RotationBase = BitSize - 5;

   [Theory]
   [MemberData(nameof(IsPowerOfTwoData))]
   public void IsPowerOfTwo_Returns_Expected_Value(int number, bool expected)
   {
      Assert.Equal(expected, number.IsPowerOfTwo());
   }

   [Theory]
   [MemberData(nameof(CountSetBitsData))]
   public void CountBitsSet_Returns_Expected_Value(int number, int expected)
   {
      Assert.Equal(expected, number.CountBitsSet());
   }

   [Theory]
   [MemberData(nameof(AreOnlyFirstAndLastBitsSetData))]
   public void AreOnlyFirstAndLastBitsSet_Returns_Expected_Value(int number, bool expected)
   {
      Assert.Equal(expected, number.AreOnlyFirstAndLastBitsSet());
   }

   [Theory]
   [MemberData(nameof(RoundUpToPowerOfTwoData))]
   public void RoundUpToPowerOfTwo_Returns_Expected_Value(int number, int expected)
   {
      Assert.Equal(expected, number.RoundUpToPowerOfTwo());
   }

   [Theory]
   [MemberData(nameof(GetHighestBitSetData))]
   public void GetHighestBitSet_Returns_Expected_Value(int number, int expected)
   {
      Assert.Equal(expected, number.GetHighestBitSet());
   }

   [Theory]
   [MemberData(nameof(GetLowestBitSetData))]
   public void GetLowestBitSet_Returns_Expected_Value(int number, int expected)
   {
      Assert.Equal(expected, number.GetLowestBitSet());
   }

   [Theory]
   [InlineData(0,  true)]
   [InlineData(1,  false)]
   [InlineData(-1, false)]
   [InlineData(2,  true)]
   [InlineData(-2, true)]
   [InlineData(3,  false)]
   [InlineData(-3, false)]
   [InlineData(4,  true)]
   [InlineData(-4, true)]
   public void IsEven_Returns_Expected_Value(int value, bool expected)
   {
      Assert.Equal(expected, value.IsEven());
   }

   [Theory]
   [InlineData(0,  false)]
   [InlineData(1,  true)]
   [InlineData(-1, true)]
   [InlineData(2,  false)]
   [InlineData(-2, false)]
   [InlineData(3,  true)]
   [InlineData(-3, true)]
   [InlineData(4,  false)]
   [InlineData(-4, false)]
   public void IsOdd_Returns_Expected_Value(int value, bool expected)
   {
      Assert.Equal(expected, value.IsOdd());
   }

   [Theory]
   [InlineData(0,  true)]
   [InlineData(1,  true)]
   [InlineData(-1, false)]
   [InlineData(2,  true)]
   [InlineData(-2, false)]
   [InlineData(3,  true)]
   [InlineData(-3, false)]
   [InlineData(4,  true)]
   [InlineData(-4, false)]
   public void IsPositive_Returns_Expected_Value(int value, bool expected)
   {
      Assert.Equal(expected, value.IsPositive());
   }

   [Theory]
   [InlineData(0,  false)]
   [InlineData(1,  false)]
   [InlineData(-1, true)]
   [InlineData(2,  false)]
   [InlineData(-2, true)]
   [InlineData(3,  false)]
   [InlineData(-3, true)]
   [InlineData(4,  false)]
   [InlineData(-4, true)]
   public void IsNegative_Returns_Expected_Value(int value, bool expected)
   {
      Assert.Equal(expected, value.IsNegative());
   }

   [Theory]
   [MemberData(nameof(CountLeadingZerosData))]
   public void CountLeadingZeros_Returns_Expected_Value(uint number, int expected)
   {
      Assert.Equal(expected, ((int) number).CountLeadingZeros());
   }

   [Theory]
   [MemberData(nameof(CountTrailingZerosData))]
   public void CountTrailingZeros_Returns_Expected_Value(int number, int expected)
   {
      Assert.Equal(expected, number.CountTrailingZeros());
   }

   [Theory]
   [InlineData(0b00000000_00000000_00000000_00001111, RotationBase + 6, 0b00000000_00000000_00000000_00011110)]
   [InlineData(0b00000000_00000000_00000000_00001111, RotationBase + 5, 0b00000000_00000000_00000000_00001111)]
   [InlineData(0b00000000_00000000_00000000_00001111, RotationBase + 4, 0b10000000_00000000_00000000_00000111)]
   [InlineData(0b00000000_00000000_00000000_00001111, RotationBase + 3, 0b11000000_00000000_00000000_00000011)]
   [InlineData(0b00000000_00000000_00000000_00001111, RotationBase + 2, 0b11100000_00000000_00000000_00000001)]
   [InlineData(0b00000000_00000000_00000000_00001111, RotationBase + 1, 0b11110000_00000000_00000000_00000000)]
   [InlineData(0b00000000_00000000_00000000_00001111, RotationBase + 0, 0b01111000_00000000_00000000_00000000)]
   public void RotateLeft_Returns_Expected_Value(uint value, int rot, uint expected)
   {
      Assert.Equal((int) expected, ((int) value).RotateLeft(rot));
   }

   [Theory]
   [InlineData(0b11110000_00000000_00000000_00000000, RotationBase + 0, 0b00000000_00000000_00000000_00011110)]
   [InlineData(0b11110000_00000000_00000000_00000000, RotationBase + 1, 0b00000000_00000000_00000000_00001111)]
   [InlineData(0b11110000_00000000_00000000_00000000, RotationBase + 2, 0b10000000_00000000_00000000_00000111)]
   [InlineData(0b11110000_00000000_00000000_00000000, RotationBase + 3, 0b11000000_00000000_00000000_00000011)]
   [InlineData(0b11110000_00000000_00000000_00000000, RotationBase + 4, 0b11100000_00000000_00000000_00000001)]
   [InlineData(0b11110000_00000000_00000000_00000000, RotationBase + 5, 0b11110000_00000000_00000000_00000000)]
   [InlineData(0b11110000_00000000_00000000_00000000, RotationBase + 6, 0b01111000_00000000_00000000_00000000)]
   public void RotateRight_Returns_Expected_Value(uint value, int rot, uint expected)
   {
      Assert.Equal((int) expected, ((int) value).RotateRight(rot));
   }

   [Theory]
   [InlineData(short.MaxValue, 1)]
   [InlineData(1,              1)]
   [InlineData(0,              0)]
   [InlineData(-1,             -1)]
   [InlineData(short.MinValue, -1)]
   public void GetSign_Returns_Expected_Result(int value, int expected)
   {
      Assert.Equal(expected, value.GetSign());
   }

   [Theory]
   [InlineData(0b01000000_00000010_00000000_00000010, 0b01000000_00000000_01000000_00000010)]
   [InlineData(0b01000010_00000100_00000000_00000100, 0b00100000_00000000_00100000_01000010)]
   [InlineData(0b01100010_00001000_00000000_00001000, 0b00010000_00000000_00010000_01000110)]
   public void ReverseBits_Returns_Expected_Result(int source, int expected)
   {
      Assert.Equal(expected, source.ReverseBits());
   }

   #region DataMember Data

   public static TheoryData<int, bool> IsPowerOfTwoData
   {
      get
      {
         var result = new TheoryData<int, bool>();

         const int bit = 0;

         for (var i = 0; i < BitSize; i++)
         {
            var x = bit.SetBit(i);
            result.Add(x, x > 0);

            if (x > 1)
            {
               result.Add(x.SetBit(0), false);
            }
         }

         return result;
      }
   }

   public static TheoryData<int, bool> AreOnlyFirstAndLastBitsSetData
   {
      get
      {
         var result = new TheoryData<int, bool>();
         HashSet<KeyValuePair<int, bool>> hs = [];
         ulong j = 0;

         for (var i = int.MinValue
              ; j <= int.MaxValue
              ; i = i > 33
                       ? (int) ((i * 13.733333) + 1)
                       : i + 1, j = j > 33
                                       ? (ulong) ((j * 13.733333) + 1)
                                       : j + 1)
         {
            var v = i.RoundUpToPowerOfTwo() | 1;
            var k = v                       | 2;
            Add(i, result);
            Add(v, result);
            Add(k, result);

            void Add(int x, TheoryData<int, bool> r)
            {
               var kvp = new KeyValuePair<int, bool>(x, (x.CountBitsSet() == 2 && ((x & 1) == 1)) || x == 1);

               if (!hs.Contains(kvp))
               {
                  hs.Add(kvp);
                  r.Add(kvp.Key, kvp.Value);
               }
            }
         }

         return result;
      }
   }

   public static TheoryData<int, int> CountSetBitsData
   {
      get
      {
         var result = new TheoryData<int, int>();

         result.Add(0b01000100010101, 5);

         for (var i = 0; i < BitSize + 1; i++)
         {
            result.Add(BitMask.FromRange(0,           i), i);
            result.Add(BitMask.FromRange(BitSize - i, i), i);
         }

         result.Add(0b1010100010000010, 5);

         return result;
      }
   }

   public static TheoryData<int, int> RoundUpToPowerOfTwoData
   {
      get
      {
         var result = new TheoryData<int, int>();

         const int bit = 1;
         result.Add(int.MinValue, 0);
         result.Add(-1,           0);

         for (var i = 0; i < BitSize - 1; i++)
         {
            var v = (bit  << i);
            var v1 = (bit << (i + 1));
            var vp1 = (v + 1);
            result.Add(v, v);
            result.Add(vp1
                     , i + 1 < BitSize - 1
                          ? v1
                          : 0
                      );
         }

         return result;
      }
   }

   public static TheoryData<int, int> GetHighestBitSetData
   {
      get
      {
         var result = new TheoryData<int, int>();

         for (var i = 0; i < BitSize + 1; i++)
         {
            result.Add(BitMask.FromRange(0, i), i - 1);
            result.Add(BitMask.FromRange(BitSize - i, i)
                     , i == 0
                          ? -1
                          : BitSize - 1
                      );
         }

         return result;
      }
   }

   public static TheoryData<int, int> GetLowestBitSetData
   {
      get
      {
         var result = new TheoryData<int, int>();

         for (var i = 0; i < BitSize + 1; i++)
         {
            result.Add(BitMask.FromRange(0, i)
                     , i == 0
                          ? -1
                          : 0
                      );
            result.Add(BitMask.FromRange(BitSize - i, i)
                     , i == 0
                          ? -1
                          : BitSize - i
                      );
         }

         return result;
      }
   }

   public static TheoryData<uint, int> CountLeadingZerosData
   {
      get
      {
         var result = new TheoryData<uint, int>();

         for (var i = 0; i <= BitSize; i++)
         {
            result.Add(BitMask.FromRange(0, i), BitSize - i);
            result.Add(BitMask.FromRange(BitSize - i, i)
                     , i == 0
                          ? BitSize
                          : 0
                      );
         }

         return result;
      }
   }

   public static TheoryData<int, int> CountTrailingZerosData
   {
      get
      {
         var result = new TheoryData<int, int>();

         for (var i = 0; i < BitSize + 1; i++)
         {
            result.Add(BitMask.FromRange(0, i)
                     , i == 0
                          ? BitSize
                          : 0
                      );
            result.Add(BitMask.FromRange(BitSize - i, i)
                     , i == 0
                          ? BitSize
                          : BitSize - i
                      );
         }

         return result;
      }
   }

   #endregion
}
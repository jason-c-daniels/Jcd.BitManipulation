#region

using System.Collections.Generic;
using System.Numerics;

using Jcd.BitManipulation.Algorithms;

using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests.Algorithms;

public class UInt64AlgorithmsExtensionsTests
{
   private const int BitSize = 64;

   private const int RotationBase = BitSize - 5;

   [Theory]
   [MemberData(nameof(IsPowerOfTwoData))]
   public void IsPowerOfTwo_Returns_Expected_Value(ulong number, bool expected)
   {
      Assert.Equal(expected, number.IsPowerOfTwo());
   }

   [Theory]
   [MemberData(nameof(CountSetBitsData))]
   public void CountBitsSet_Returns_Expected_Value(ulong number, int expected)
   {
      Assert.Equal(expected, number.CountBitsSet());
   }

   [Theory]
   [MemberData(nameof(AreOnlyFirstAndLastBitsSetData))]
   public void AreOnlyFirstAndLastBitsSet_Returns_Expected_Value(ulong number, bool expected)
   {
      Assert.Equal(expected, number.AreOnlyFirstAndLastBitsSet());
   }

   [Theory]
   [MemberData(nameof(RoundUpToPowerOfTwoData))]
   public void RoundUpToPowerOfTwo_Returns_Expected_Value(ulong number, ulong expected)
   {
      Assert.Equal(expected, number.RoundUpToPowerOfTwo());
   }

   [Theory]
   [MemberData(nameof(GetHighestBitSetData))]
   public void GetHighestBitSet_Returns_Expected_Value(ulong number, int expected)
   {
      Assert.Equal(expected, number.GetHighestBitSet());
   }

   [Theory]
   [MemberData(nameof(GetLowestBitSetData))]
   public void GetLowestBitSet_Returns_Expected_Value(ulong number, int expected)
   {
      Assert.Equal(expected, number.GetLowestBitSet());
   }

   [Theory]
   [InlineData(0,              true)]
   [InlineData(1,              false)]
   [InlineData(2,              true)]
   [InlineData(3,              false)]
   [InlineData(4,              true)]
   [InlineData(ulong.MaxValue, false)]
   public void IsEven_Returns_Expected_Value(ulong value, bool expected)
   {
      Assert.Equal(expected, value.IsEven());
   }

   [Theory]
   [InlineData(0,              false)]
   [InlineData(1,              true)]
   [InlineData(2,              false)]
   [InlineData(3,              true)]
   [InlineData(4,              false)]
   [InlineData(ulong.MaxValue, true)]
   public void IsOdd_Returns_Expected_Value(ulong value, bool expected)
   {
      Assert.Equal(expected, value.IsOdd());
   }

   [Theory]
   [InlineData(0x00, true)]
   [InlineData(0x01, true)]
   [InlineData(0xFF, true)]
   public void IsPositive_Returns_Expected_Value(ulong value, bool expected)
   {
      Assert.Equal(expected, value.IsPositive());
   }

   [Theory]
   [InlineData(0,               false)]
   [InlineData(1,               false)]
   [InlineData(ushort.MaxValue, false)]
   public void IsNegative_Returns_Expected_Value(ulong value, bool expected)
   {
      Assert.Equal(expected, value.IsNegative());
   }

   [Theory]
   [MemberData(nameof(CountLeadingZerosData))]
   public void CountLeadingZeros_Returns_Expected_Value(ulong number, int expected)
   {
      Assert.Equal(expected, number.CountLeadingZeros());
   }

   [Theory]
   [MemberData(nameof(CountTrailingZerosData))]
   public void CountTrailingZeros_Returns_Expected_Value(ulong number, int expected)
   {
      Assert.Equal(expected, number.CountTrailingZeros());
   }

   [Theory]
   [InlineData(0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00001111
             , RotationBase + 6
             , 0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00011110
              )]
   [InlineData(0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00001111
             , RotationBase + 5
             , 0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00001111
              )]
   [InlineData(0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00001111
             , RotationBase + 4
             , 0b10000000_00000000_00000000_00000000_00000000_00000000_00000000_00000111
              )]
   [InlineData(0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00001111
             , RotationBase + 3
             , 0b11000000_00000000_00000000_00000000_00000000_00000000_00000000_00000011
              )]
   [InlineData(0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00001111
             , RotationBase + 2
             , 0b11100000_00000000_00000000_00000000_00000000_00000000_00000000_00000001
              )]
   [InlineData(0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00001111
             , RotationBase + 1
             , 0b11110000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
              )]
   [InlineData(0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00001111
             , RotationBase + 0
             , 0b01111000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
              )]
   public void RotateLeft_Returns_Expected_Value(ulong value, int rot, ulong expected)
   {
      Assert.Equal(expected, value.RotateLeft(rot));
   }

   [Theory]
   [InlineData(0b11110000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
             , RotationBase + 0
             , 0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00011110
              )]
   [InlineData(0b11110000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
             , RotationBase + 1
             , 0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00001111
              )]
   [InlineData(0b11110000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
             , RotationBase + 2
             , 0b10000000_00000000_00000000_00000000_00000000_00000000_00000000_00000111
              )]
   [InlineData(0b11110000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
             , RotationBase + 3
             , 0b11000000_00000000_00000000_00000000_00000000_00000000_00000000_00000011
              )]
   [InlineData(0b11110000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
             , RotationBase + 4
             , 0b11100000_00000000_00000000_00000000_00000000_00000000_00000000_00000001
              )]
   [InlineData(0b11110000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
             , RotationBase + 5
             , 0b11110000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
              )]
   [InlineData(0b11110000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
             , RotationBase + 6
             , 0b01111000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
              )]
   public void RotateRight_Returns_Expected_Value(ulong value, int rot, ulong expected)
   {
      Assert.Equal(expected, value.RotateRight(rot));
   }

   #region DataMember Data

   public static TheoryData<ulong, bool> IsPowerOfTwoData
   {
      get
      {
         var result = new TheoryData<ulong, bool>();

         for (var i = 0; i < BitSize; i++)
         {
            result.Add(1ul << i, true);

            if (i > 0)
            {
               result.Add((1ul << i) | 1, false);
            }
         }

         return result;
      }
   }

   public static TheoryData<ulong, bool> AreOnlyFirstAndLastBitsSetData
   {
      get
      {
         var result = new TheoryData<ulong, bool>();
         HashSet<KeyValuePair<ulong, bool>> hs = [];
         BigInteger j = 0;

         for (var i = ulong.MinValue
              ; j < ulong.MaxValue
              ; i = i > 33
                       ? (ulong) ((i * 13.733333) + 1)
                       : i + 1, j = j > 33
                                       ? ((j * (BigInteger) 13.733333) + 1)
                                       : j + 1)
         {
            var v = i.RoundUpToPowerOfTwo() | 1;
            var k = v                                  | 2;
            Add(i, result);
            Add(v, result);
            Add(k, result);

            void Add(ulong x, TheoryData<ulong, bool> r)
            {
               var kvp = new KeyValuePair<ulong, bool>(x, (x.CountBitsSet() == 2 && ((x & 1) == 1)) || x == 1);

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

   public static TheoryData<ulong, int> CountSetBitsData
   {
      get
      {
         var result = new TheoryData<ulong, int>();

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

   public static TheoryData<ulong, ulong> RoundUpToPowerOfTwoData
   {
      get
      {
         var result = new TheoryData<ulong, ulong>();

         const ulong bit = 1;

         for (var i = 0; i < BitSize - 1; i++)
         {
            var v = bit  << i;
            var v1 = bit << (i + 1);
            result.Add(v,     v);
            result.Add(v + 1, v1);
         }

         return result;
      }
   }

   public static TheoryData<ulong, int> GetHighestBitSetData
   {
      get
      {
         var result = new TheoryData<ulong, int>();

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

   public static TheoryData<ulong, int> GetLowestBitSetData
   {
      get
      {
         var result = new TheoryData<ulong, int>();

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

   public static TheoryData<ulong, int> CountLeadingZerosData
   {
      get
      {
         var result = new TheoryData<ulong, int>();

         for (var i = 0; i < BitSize + 1; i++)
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

   public static TheoryData<ulong, int> CountTrailingZerosData
   {
      get
      {
         var result = new TheoryData<ulong, int>();

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
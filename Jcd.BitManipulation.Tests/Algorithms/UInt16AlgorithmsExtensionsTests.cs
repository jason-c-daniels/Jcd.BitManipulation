﻿#region

using System.Collections.Generic;

using Jcd.BitManipulation.Algorithms;

using Xunit;

#pragma warning disable CA1868

#endregion

namespace Jcd.BitManipulation.Tests.Algorithms;

public class UInt16AlgorithmsExtensionsTests
{
   private const int BitSize = 16;

   private const int RotationBase = BitSize - 5;

   [Theory]
   [MemberData(nameof(IsPowerOfTwoData))]
   public void IsPowerOfTwo_Returns_Expected_Value(ushort number, bool expected)
   {
      Assert.Equal(expected, number.IsPowerOfTwo());
   }

   [Theory]
   [MemberData(nameof(CountSetBitsData))]
   public void CountBitsSet_Returns_Expected_Value(ushort number, int expected)
   {
      Assert.Equal(expected, number.CountBitsSet());
   }

   [Theory]
   [MemberData(nameof(AreOnlyFirstAndLastBitsSetData))]
   public void AreOnlyFirstAndLastBitsSet_Returns_Expected_Value(ushort number, bool expected)
   {
      Assert.Equal(expected, number.AreOnlyFirstAndLastBitsSet());
   }

   [Theory]
   [MemberData(nameof(RoundUpToPowerOfTwoData))]
   public void RoundUpToPowerOfTwo_Returns_Expected_Value(ushort number, ushort expected)
   {
      Assert.Equal(expected, number.RoundUpToPowerOfTwo());
   }

   [Theory]
   [MemberData(nameof(GetHighestBitSetData))]
   public void GetHighestBitSet_Returns_Expected_Value(ushort number, int expected)
   {
      Assert.Equal(expected, number.GetHighestBitSet());
   }

   [Theory]
   [MemberData(nameof(GetLowestBitSetData))]
   public void GetLowestBitSet_Returns_Expected_Value(ushort number, int expected)
   {
      Assert.Equal(expected, number.GetLowestBitSet());
   }

   [Theory]
   [InlineData(0,               true)]
   [InlineData(1,               false)]
   [InlineData(2,               true)]
   [InlineData(3,               false)]
   [InlineData(4,               true)]
   [InlineData(ushort.MaxValue, false)]
   public void IsEven_Returns_Expected_Value(ushort value, bool expected)
   {
      Assert.Equal(expected, value.IsEven());
   }

   [Theory]
   [InlineData(0,               false)]
   [InlineData(1,               true)]
   [InlineData(2,               false)]
   [InlineData(3,               true)]
   [InlineData(4,               false)]
   [InlineData(ushort.MaxValue, true)]
   public void IsOdd_Returns_Expected_Value(ushort value, bool expected)
   {
      Assert.Equal(expected, value.IsOdd());
   }

   [Theory]
   [InlineData(0x00, true)]
   [InlineData(0x01, true)]
   [InlineData(0xFF, true)]
   public void IsPositive_Returns_Expected_Value(ushort value, bool expected)
   {
      Assert.Equal(expected, value.IsPositive());
   }

   [Theory]
   [InlineData(0,               false)]
   [InlineData(1,               false)]
   [InlineData(ushort.MaxValue, false)]
   public void IsNegative_Returns_Expected_Value(ushort value, bool expected)
   {
      Assert.Equal(expected, value.IsNegative());
   }

   [Theory]
   [MemberData(nameof(CountLeadingZerosData))]
   public void CountLeadingZeros_Returns_Expected_Value(ushort number, int expected)
   {
      Assert.Equal(expected, number.CountLeadingZeros());
   }

   [Theory]
   [MemberData(nameof(CountTrailingZerosData))]
   public void CountTrailingZeros_Returns_Expected_Value(ushort number, int expected)
   {
      Assert.Equal(expected, number.CountTrailingZeros());
   }

   [Theory]
   [InlineData(0b00000000_00001111, RotationBase + 0, 0b01111000_00000000)]
   [InlineData(0b00000000_00001111, RotationBase + 1, 0b11110000_00000000)]
   [InlineData(0b00000000_00001111, RotationBase + 2, 0b11100000_00000001)]
   [InlineData(0b00000000_00001111, RotationBase + 3, 0b11000000_00000011)]
   [InlineData(0b00000000_00001111, RotationBase + 4, 0b10000000_00000111)]
   [InlineData(0b00000000_00001111, RotationBase + 5, 0b00000000_00001111)]
   [InlineData(0b00000000_00001111, RotationBase + 6, 0b00000000_00011110)]
   public void RotateLeft_Returns_Expected_Value(ushort value, int rot, ushort expected)
   {
      Assert.Equal(expected, value.RotateLeft(rot));
   }

   [Theory]
   [InlineData(0b11110000_00000000, RotationBase + 0, 0b00000000_00011110)]
   [InlineData(0b11110000_00000000, RotationBase + 1, 0b00000000_00001111)]
   [InlineData(0b11110000_00000000, RotationBase + 2, 0b10000000_00000111)]
   [InlineData(0b11110000_00000000, RotationBase + 3, 0b11000000_00000011)]
   [InlineData(0b11110000_00000000, RotationBase + 4, 0b11100000_00000001)]
   [InlineData(0b11110000_00000000, RotationBase + 5, 0b11110000_00000000)]
   [InlineData(0b11110000_00000000, RotationBase + 6, 0b01111000_00000000)]
   public void RotateRight_Returns_Expected_Value(ushort value, int rot, ushort expected)
   {
      Assert.Equal(expected, value.RotateRight(rot));
   }

   [Theory]
   [InlineData(ushort.MaxValue, 1)]
   [InlineData(1,               1)]
   [InlineData(0,               0)]
   public void GetSign_Returns_Expected_Result(ushort value, int expected)
   {
      Assert.Equal(expected, value.GetSign());
   }

   [Theory]
   [InlineData(0b01000000_00000010, 0b01000000_00000010)]
   [InlineData(0b01000010_00000100, 0b00100000_01000010)]
   [InlineData(0b01100010_00001000, 0b00010000_01000110)]
   public void ReverseBits_Returns_Expected_Result(ushort source, ushort expected)
   {
      Assert.Equal(expected, source.ReverseBits());
   }

   #region DataMember Data

   public static TheoryData<ushort, bool> IsPowerOfTwoData
   {
      get
      {
         var result = new TheoryData<ushort, bool>();

         const ushort bit = 1;

         for (ushort i = 0; i < BitSize; i++)
         {
            result.Add((ushort) (bit << i), true);

            if (i > 0)
            {
               result.Add((ushort) ((bit << i) | 1), false);
            }
         }

         return result;
      }
   }

   public static TheoryData<ushort, bool> AreOnlyFirstAndLastBitsSetData
   {
      get
      {
         var result = new TheoryData<ushort, bool>();
         HashSet<KeyValuePair<ushort, bool>> hs = [];
         uint j = 0;

         for (var i = ushort.MinValue
              ; j <= ushort.MaxValue
              ; i = (ushort) (i > 33
                                 ? (ushort) ((i * 1.01733333) + 1)
                                 : i + 1), j = j > 33
                                                  ? (uint) ((j * 1.01733333) + 1)
                                                  : j + 1)
         {
            var v = (ushort) (i.RoundUpToPowerOfTwo() | 1);
            var k = (ushort) (v                       | 2);
            Add(i, result);
            Add(v, result);
            Add(k, result);

            void Add(ushort x, TheoryData<ushort, bool> r)
            {
               var kvp = new KeyValuePair<ushort, bool>(x, (x.CountBitsSet() == 2 && ((x & 1) == 1)) || x == 1);

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

   public static TheoryData<ushort, int> CountSetBitsData
   {
      get
      {
         var result = new TheoryData<ushort, int>();

         result.Add(0b01010101, 4);

         for (ushort i = 0; i < BitSize + 1; i++)
         {
            result.Add(BitMask.FromRange(0,           i), i);
            result.Add(BitMask.FromRange(BitSize - i, i), i);
         }

         result.Add(0b10101010, 4);

         return result;
      }
   }

   public static TheoryData<ushort, ushort> RoundUpToPowerOfTwoData
   {
      get
      {
         var result = new TheoryData<ushort, ushort>();

         const ushort bit = 1;

         for (ushort i = 0; i < BitSize - 1; i++)
         {
            var v = (ushort) (bit  << i);
            var v1 = (ushort) (bit << (i + 1));
            result.Add(v,                v);
            result.Add((ushort) (v + 1), v1);
         }

         return result;
      }
   }

   public static TheoryData<ushort, int> GetHighestBitSetData
   {
      get
      {
         var result = new TheoryData<ushort, int>();

         for (ushort i = 0; i < BitSize + 1; i++)
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

   public static TheoryData<ushort, int> GetLowestBitSetData
   {
      get
      {
         var result = new TheoryData<ushort, int>();

         for (ushort i = 0; i < BitSize + 1; i++)
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

   public static TheoryData<ushort, int> CountLeadingZerosData
   {
      get
      {
         var result = new TheoryData<ushort, int>();

         for (ushort i = 0; i < BitSize + 1; i++)
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

   public static TheoryData<ushort, int> CountTrailingZerosData
   {
      get
      {
         var result = new TheoryData<ushort, int>();

         for (ushort i = 0; i < BitSize + 1; i++)
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
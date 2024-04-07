#region

using Jcd.BitManipulation.Algorithms;

using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests.Algorithms;

public class SByteAlgorithmsExtensionsTests
{
   private const int BitSize = 8;

   private const int RotationBase = BitSize - 5;

   [Theory]
   [MemberData(nameof(IsPowerOfTwoData))]
   public void IsPowerOfTwo_Returns_Expected_Value(sbyte number, bool expected)
   {
      Assert.Equal(expected, number.IsPowerOfTwo());
   }

   [Theory]
   [MemberData(nameof(CountSetBitsData))]
   public void CountBitsSet_Returns_Expected_Value(byte number, int expected)
   {
      Assert.Equal(expected, ((sbyte) number).CountBitsSet());
   }

   [Theory]
   [MemberData(nameof(AreOnlyFirstAndLastBitsSetData))]
   public void AreOnlyFirstAndLastBitsSet_Returns_Expected_Value(sbyte number, bool expected)
   {
      Assert.Equal(expected, number.AreOnlyFirstAndLastBitsSet());
   }

   [Theory]
   [MemberData(nameof(RoundUpToPowerOfTwoData))]
   public void RoundUpToPowerOfTwo_Returns_Expected_Value(sbyte number, sbyte expected)
   {
      Assert.Equal(expected, number.RoundUpToPowerOfTwo());
   }

   [Theory]
   [MemberData(nameof(GetHighestBitSetData))]
   public void GetHighestBitSet_Returns_Expected_Value(sbyte number, int expected)
   {
      Assert.Equal(expected, number.GetHighestBitSet());
   }

   [Theory]
   [MemberData(nameof(GetLowestBitSetData))]
   public void GetLowestBitSet_Returns_Expected_Value(sbyte number, int expected)
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
   public void IsEven_Returns_Expected_Value(sbyte value, bool expected)
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
   public void IsOdd_Returns_Expected_Value(sbyte value, bool expected)
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
   public void IsPositive_Returns_Expected_Value(sbyte value, bool expected)
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
   public void IsNegative_Returns_Expected_Value(sbyte value, bool expected)
   {
      Assert.Equal(expected, value.IsNegative());
   }

   [Theory]
   [MemberData(nameof(CountLeadingZerosData))]
   public void CountLeadingZeros_Returns_Expected_Value(sbyte number, int expected)
   {
      Assert.Equal(expected, number.CountLeadingZeros());
   }

   [Theory]
   [MemberData(nameof(CountTrailingZerosData))]
   public void CountTrailingZeros_Returns_Expected_Value(sbyte number, int expected)
   {
      Assert.Equal(expected, number.CountTrailingZeros());
   }

   [Theory]
   [InlineData(0b00001111, RotationBase + 0, 0b01111000)]
   [InlineData(0b00001111, RotationBase + 1, 0b11110000)]
   [InlineData(0b00001111, RotationBase + 2, 0b11100001)]
   [InlineData(0b00001111, RotationBase + 3, 0b11000011)]
   [InlineData(0b00001111, RotationBase + 4, 0b10000111)]
   [InlineData(0b00001111, RotationBase + 5, 0b00001111)]
   [InlineData(0b00001111, RotationBase + 6, 0b00011110)]
   public void RotateLeft_Returns_Expected_Value(sbyte value, int rot, byte expected)
   {
      Assert.Equal((sbyte) expected, value.RotateLeft(rot));
   }

   [Theory]
   [InlineData(0b11110000, RotationBase + 0, 0b00011110)]
   [InlineData(0b11110000, RotationBase + 1, 0b00001111)]
   [InlineData(0b11110000, RotationBase + 2, 0b10000111)]
   [InlineData(0b11110000, RotationBase + 3, 0b11000011)]
   [InlineData(0b11110000, RotationBase + 4, 0b11100001)]
   [InlineData(0b11110000, RotationBase + 5, 0b11110000)]
   [InlineData(0b11110000, RotationBase + 6, 0b01111000)]
   public void RotateRight_Returns_Expected_Value(byte value, int rot, byte expected)
   {
      Assert.Equal((sbyte) expected, ((sbyte) value).RotateRight(rot));
   }

   [Theory]
   [InlineData(sbyte.MaxValue, 1)]
   [InlineData(1,              1)]
   [InlineData(0,              0)]
   [InlineData(-1,             -1)]
   [InlineData(sbyte.MinValue, -1)]
   public void GetSign_Returns_Expected_Result(sbyte value, int expected)
   {
      Assert.Equal(expected, value.GetSign());
   }

   #region DataMember Data

   public static TheoryData<sbyte, bool> IsPowerOfTwoData
   {
      get
      {
         var result = new TheoryData<sbyte, bool>();

         const sbyte bit = 0;

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

   public static TheoryData<sbyte, bool> AreOnlyFirstAndLastBitsSetData
   {
      get
      {
         var result = new TheoryData<sbyte, bool>();

         ulong j = 0;
         var trueValue = ((sbyte) 0).SetBit(0).SetBit(BitSize - 1);

         for (var i = sbyte.MinValue; j <= (byte) sbyte.MaxValue; i++, j++)
         {
            result.Add(i, (i < 0 && i == trueValue) || (i.CountBitsSet() == 2 && ((i & 1) == 1)) || i == 1);
         }

         return result;
      }
   }

   public static TheoryData<byte, int> CountSetBitsData
   {
      get
      {
         var result = new TheoryData<byte, int>();

         result.Add(0b01010101, 4);

         for (var i = 0; i <= BitSize; i++)
         {
            result.Add(BitMask.FromRange(0,           i), i);
            result.Add(BitMask.FromRange(BitSize - i, i), i);
         }

         result.Add(0b10101010, 4);

         return result;
      }
   }

   public static TheoryData<sbyte, sbyte> RoundUpToPowerOfTwoData
   {
      get
      {
         var result = new TheoryData<sbyte, sbyte>();

         const sbyte bit = 1;

         result.Add(sbyte.MinValue, 0);
         result.Add(-1,             0);

         for (sbyte i = 0; i < BitSize - 1; i++)
         {
            var v = (sbyte) (bit  << i);
            var v1 = (sbyte) (bit << (i + 1));
            var vp1 = (sbyte) (v + 1);
            result.Add(v, v);
            result.Add(vp1
                     , i + 1 < BitSize - 1
                          ? v1
                          : (sbyte) 0
                      );
         }

         return result;
      }
   }

   public static TheoryData<sbyte, int> GetHighestBitSetData
   {
      get
      {
         var result = new TheoryData<sbyte, int>();

         for (var i = 0; i < BitSize; i++)
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

   public static TheoryData<sbyte, int> GetLowestBitSetData
   {
      get
      {
         var result = new TheoryData<sbyte, int>();

         for (var i = 0; i < BitSize; i++)
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

   public static TheoryData<sbyte, int> CountLeadingZerosData
   {
      get
      {
         var result = new TheoryData<sbyte, int>();

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

   public static TheoryData<sbyte, int> CountTrailingZerosData
   {
      get
      {
         var result = new TheoryData<sbyte, int>();

         for (var i = 0; i <= BitSize; i++)
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
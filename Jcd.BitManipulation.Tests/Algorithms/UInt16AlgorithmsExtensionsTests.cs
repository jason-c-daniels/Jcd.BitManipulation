#region

using Jcd.BitManipulation.Algorithms;

using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests.Algorithms;

public class UInt16AlgorithmsExtensionsTests
{
   private const int BitSize = 16;

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
      var x = number.CountBitsSet();
      Assert.Equal(expected, x);
   }

   [Theory]
   [MemberData(nameof(AreOnlyFirstAndLastBitsSetData))]
   public void AreOnlyFirstAndLastBitsSet_Returns_Expected_Value(ushort number, bool expected)
   {
      Assert.Equal(expected, number.AreOnlyFirstAndLastBitsSet());
   }

   [Theory]
   [MemberData(nameof(GetValueOrNextHigherPowerOfTwoData))]
   public void GetValueOrNextHigherPowerOfTwo_Returns_Expected_Value(ushort number, ushort expected)
   {
      Assert.Equal(expected, number.GetValueOrNextHigherPowerOfTwo());
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

         ulong j = 0;

         for (var i = ushort.MinValue; j <= ushort.MaxValue; i = (ushort) ((i * 1.05) + 1), j = (ulong) ((j * 1.05) + 1))
         {
            var v = (ushort) (i.GetValueOrNextHigherPowerOfTwo() | 1);
            var k = (ushort) (v                                  | 2);
            result.Add(i, (i.CountBitsSet() == 2 && ((i & 1) == 1)) || i == 1);
            result.Add(v, (v.CountBitsSet() == 2 && ((v & 1) == 1)) || v == 1);
            result.Add(k, (k.CountBitsSet() == 2 && ((k & 1) == 1)) || k == 1);
         }

         return result;
      }
   }

   public static TheoryData<ushort, int> CountSetBitsData
   {
      get
      {
         var result = new TheoryData<ushort, int>();

         result.Add(0b01000100010101, 5);

         for (ushort i = 0; i < BitSize + 1; i++)
         {
            result.Add(BitMask.FromRange(0,           i), i);
            result.Add(BitMask.FromRange(BitSize - i, i), i);
         }

         result.Add(0b1010100010000010, 5);

         return result;
      }
   }

   public static TheoryData<ushort, ushort> GetValueOrNextHigherPowerOfTwoData
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

   private const int RotationBase = BitSize - 5;

   [Theory]
   [InlineData(0b00000000_00001111, RotationBase + 6, 0b0000000000011110)]
   [InlineData(0b00000000_00001111, RotationBase + 5, 0b0000000000001111)]
   [InlineData(0b00000000_00001111, RotationBase + 4, 0b1000000000000111)]
   [InlineData(0b00000000_00001111, RotationBase + 3, 0b1100000000000011)]
   [InlineData(0b00000000_00001111, RotationBase + 2, 0b1110000000000001)]
   [InlineData(0b00000000_00001111, RotationBase + 1, 0b1111000000000000)]
   [InlineData(0b00000000_00001111, RotationBase + 0, 0b0111100000000000)]
   public void RotateLeft_Returns_Expected_Value(ushort value, int rot, ushort expected)
   {
      Assert.Equal(expected, value.RotateLeft(rot));
   }

   [Theory]
   [InlineData(0b1111000000000000, RotationBase + 0, 0b0000000000011110)]
   [InlineData(0b1111000000000000, RotationBase + 1, 0b0000000000001111)]
   [InlineData(0b1111000000000000, RotationBase + 2, 0b1000000000000111)]
   [InlineData(0b1111000000000000, RotationBase + 3, 0b1100000000000011)]
   [InlineData(0b1111000000000000, RotationBase + 4, 0b1110000000000001)]
   [InlineData(0b1111000000000000, RotationBase + 5, 0b1111000000000000)]
   [InlineData(0b1111000000000000, RotationBase + 6, 0b0111100000000000)]
   public void RotateRight_Returns_Expected_Value(ushort value, int rot, ushort expected)
   {
      Assert.Equal(expected, value.RotateRight(rot));
   }

   #endregion
}
#region

using Jcd.BitManipulation.Algorithms;

using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests.Algorithms;

public class ByteAlgorithmsExtensionsTests
{
   private const int BitSize = 8;

   [Theory]
   [MemberData(nameof(IsPowerOfTwoData))]
   public void IsPowerOfTwo_Returns_Expected_Value(byte number, bool expected)
   {
      Assert.Equal(expected, number.IsPowerOfTwo());
   }

   [Theory]
   [MemberData(nameof(CountSetBitsData))]
   public void CountBitsSet_Returns_Expected_Value(byte number, int expected)
   {
      Assert.Equal(expected, number.CountBitsSet());
   }

   [Theory]
   [MemberData(nameof(AreOnlyFirstAndLastBitsSetData))]
   public void AreOnlyFirstAndLastBitsSet_Returns_Expected_Value(byte number, bool expected)
   {
      Assert.Equal(expected, number.AreOnlyFirstAndLastBitsSet());
   }

   [Theory]
   [MemberData(nameof(GetValueOrNextHigherPowerOfTwoData))]
   public void GetValueOrNextHigherPowerOfTwo_Returns_Expected_Value(byte number, byte expected)
   {
      Assert.Equal(expected, number.GetValueOrNextHigherPowerOfTwo());
   }

   [Theory]
   [MemberData(nameof(GetHighestBitSetData))]
   public void GetHighestBitSet_Returns_Expected_Value(byte number, int expected)
   {
      Assert.Equal(expected, number.GetHighestBitSet());
   }

   [Theory]
   [MemberData(nameof(GetLowestBitSetData))]
   public void GetLowestBitSet_Returns_Expected_Value(byte number, int expected)
   {
      Assert.Equal(expected, number.GetLowestBitSet());
   }

   [Theory]
   [MemberData(nameof(CountLeadingZerosData))]
   public void CountLeadingZeros_Returns_Expected_Value(byte number, int expected)
   {
      Assert.Equal(expected, number.CountLeadingZeros());
   }

   [Theory]
   [MemberData(nameof(CountTrailingZerosData))]
   public void CountTrailingZeros_Returns_Expected_Value(byte number, int expected)
   {
      Assert.Equal(expected, number.CountTrailingZeros());
   }

   #region DataMember Data

   public static TheoryData<byte, bool> IsPowerOfTwoData
   {
      get
      {
         var result = new TheoryData<byte, bool>();

         const byte bit = 1;

         for (byte i = 0; i < BitSize; i++)
         {
            result.Add((byte) (bit << i), true);

            if (i > 0)
            {
               result.Add((byte) ((bit << i) | 1), false);
            }
         }

         return result;
      }
   }

   public static TheoryData<byte, bool> AreOnlyFirstAndLastBitsSetData
   {
      get
      {
         var result = new TheoryData<byte, bool>();

         ulong j = 0;

         for (var i = byte.MinValue; j <= byte.MaxValue; i++, j++)
         {
            result.Add(i, (i.CountBitsSet() == 2 && ((i & 1) == 1)) || i == 1);
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

         for (byte i = 0; i < BitSize + 1; i++)
         {
            result.Add(BitMask.FromRange(0,           i), i);
            result.Add(BitMask.FromRange(BitSize - i, i), i);
         }

         result.Add(0b10101010, 4);

         return result;
      }
   }

   public static TheoryData<byte, byte> GetValueOrNextHigherPowerOfTwoData
   {
      get
      {
         var result = new TheoryData<byte, byte>();

         const byte bit = 1;

         for (byte i = 0; i < BitSize - 1; i++)
         {
            var v = (byte) (bit  << i);
            var v1 = (byte) (bit << (i + 1));
            result.Add(v,              v);
            result.Add((byte) (v + 1), v1);
         }

         return result;
      }
   }

   public static TheoryData<byte, int> GetHighestBitSetData
   {
      get
      {
         var result = new TheoryData<byte, int>();

         for (byte i = 0; i < BitSize + 1; i++)
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

   public static TheoryData<byte, int> GetLowestBitSetData
   {
      get
      {
         var result = new TheoryData<byte, int>();

         for (byte i = 0; i < BitSize + 1; i++)
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

   public static TheoryData<byte, int> CountLeadingZerosData
   {
      get
      {
         var result = new TheoryData<byte, int>();

         for (byte i = 0; i < BitSize + 1; i++)
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

   public static TheoryData<byte, int> CountTrailingZerosData
   {
      get
      {
         var result = new TheoryData<byte, int>();

         for (byte i = 0; i < BitSize + 1; i++)
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
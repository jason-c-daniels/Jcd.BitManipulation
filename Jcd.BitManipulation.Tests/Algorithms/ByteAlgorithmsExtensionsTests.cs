#region

using Jcd.BitManipulation.Algorithms;

using Xunit;

#endregion

namespace Jcd.BitManipulation.Tests.Algorithms;

public class ByteAlgorithmsExtensionsTests
{
   private const int BitSize = 8;

   private const int RotationBase = BitSize - 5;

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
   [MemberData(nameof(RoundUpToPowerOfTwoData))]
   public void RoundUpToPowerOfTwo_Returns_Expected_Value(byte number, byte expected)
   {
      Assert.Equal(expected, number.RoundUpToPowerOfTwo());
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
   [InlineData(0, true)]
   [InlineData(1, false)]
   [InlineData(2, true)]
   [InlineData(3, false)]
   [InlineData(4, true)]
   public void IsEven_Returns_Expected_Value(byte value, bool expected)
   {
      Assert.Equal(expected, value.IsEven());
   }

   [Theory]
   [InlineData(0,             false)]
   [InlineData(1,             true)]
   [InlineData(2,             false)]
   [InlineData(3,             true)]
   [InlineData(4,             false)]
   [InlineData(byte.MaxValue, true)]
   public void IsOdd_Returns_Expected_Value(byte value, bool expected)
   {
      Assert.Equal(expected, value.IsOdd());
   }

   [Theory]
   [InlineData(0x00, true)]
   [InlineData(0x01, true)]
   [InlineData(0xFF, true)]
   public void IsPositive_Returns_Expected_Value(byte value, bool expected)
   {
      Assert.Equal(expected, value.IsPositive());
   }

   [Theory]
   [InlineData(0,             false)]
   [InlineData(1,             false)]
   [InlineData(byte.MaxValue, false)]
   public void IsNegative_Returns_Expected_Value(byte value, bool expected)
   {
      Assert.Equal(expected, value.IsNegative());
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

   [Theory]
   [InlineData(0b00001111, RotationBase + 0, 0b01111000)]
   [InlineData(0b00001111, RotationBase + 1, 0b11110000)]
   [InlineData(0b00001111, RotationBase + 2, 0b11100001)]
   [InlineData(0b00001111, RotationBase + 3, 0b11000011)]
   [InlineData(0b00001111, RotationBase + 4, 0b10000111)]
   [InlineData(0b00001111, RotationBase + 5, 0b00001111)]
   [InlineData(0b00001111, RotationBase + 6, 0b00011110)]
   public void RotateLeft_Returns_Expected_Value(byte value, int rot, byte expected)
   {
      Assert.Equal(expected, value.RotateLeft(rot));
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
      Assert.Equal(expected, value.RotateRight(rot));
   }

   [Theory]
   [InlineData(byte.MaxValue, 1)]
   [InlineData(1,             1)]
   [InlineData(0,             0)]
   public void GetSign_Returns_Expected_Result(byte value, int expected)
   {
      Assert.Equal(expected, value.GetSign());
   }

   [Theory]
   [InlineData(0b0,        0b0)]
   [InlineData(0b10000000, 0b00000001)]
   [InlineData(0b10000010, 0b01000001)]
   [InlineData(0b10100010, 0b01000101)]
   public void ReverseBits_Returns_Expected_Result(byte source, byte expected)
   {
      Assert.Equal(expected, source.ReverseBits());
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

   public static TheoryData<byte, byte> RoundUpToPowerOfTwoData
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
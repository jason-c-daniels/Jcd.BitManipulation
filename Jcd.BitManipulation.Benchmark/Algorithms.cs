using BenchmarkDotNet.Attributes;

using Jcd.BitManipulation.Algorithms;

namespace Jcd.BitManipulation.Benchmark;

public class Algorithms
{
   private byte bv;
   private ushort us;
   private uint ui;
   private ulong ul;

   [Benchmark]
   public bool IsPowerOfTwo_On_Byte()
   {
      unchecked { bv++; }
      return bv.IsPowerOfTwo();
   }
   
   [Benchmark]
   public bool IsPowerOfTwo_On_UInt16()
   {
      unchecked { us++; }
      return us.IsPowerOfTwo();
   }
   
   [Benchmark]
   public bool IsPowerOfTwo_On_UInt32()
   {
      unchecked { ui++; }
      return ui.IsPowerOfTwo();
   }

   [Benchmark]
   public bool IsPowerOfTwo_On_UInt64()
   {
      unchecked { ul++; }
      return ui.IsPowerOfTwo();
   }
   
   [Benchmark]
   public int CountBitsSet_On_Byte()
   {
      unchecked { bv++; }

      return bv.CountBitsSet();
   }

   [Benchmark]
   public int CountBitsSet_On_UInt16()
   {
      unchecked { us++; }

      return us.CountBitsSet();
   }
   
   [Benchmark]
   public int CountBitsSet_On_UInt32()
   {
      unchecked { ui++; }

      return ui.CountBitsSet();
   }
   
   [Benchmark]
   public int CountBitsSet_On_UInt64()
   {
      unchecked { ul++; }

      return ul.CountBitsSet();
   }
   [Benchmark]
   public int CountLeadingZeros_On_Byte()
   {
      unchecked { bv++; }

      return bv.CountLeadingZeros();
   }

   [Benchmark]
   public int CountLeadingZeros_On_UInt16()
   {
      unchecked { us++; }

      return us.CountLeadingZeros();
   }
   
   [Benchmark]
   public int CountLeadingZeros_On_UInt32()
   {
      unchecked { ui++; }

      return ui.CountLeadingZeros();
   }
   
   [Benchmark]
   public int CountLeadingZeros_On_UInt64()
   {
      unchecked { ul++; }

      return ul.CountLeadingZeros();
   }
   
   [Benchmark]
   public int CountTrailingZeros_On_Byte()
   {
      unchecked { bv++; }

      return bv.CountTrailingZeros();
   }

   [Benchmark]
   public int CountTrailingZeros_On_UInt16()
   {
      unchecked { us++; }

      return us.CountTrailingZeros();
   }
   
   [Benchmark]
   public int CountTrailingZeros_On_UInt32()
   {
      unchecked { ui++; }

      return ui.CountTrailingZeros();
   }
   
   [Benchmark]
   public int CountTrailingZeros_On_UInt64()
   {
      unchecked { ul++; }

      return ul.CountTrailingZeros();
   }
   [Benchmark]
   public bool AreOnlyFirstAndLastBitsSet_On_Byte()
   {
      unchecked { bv++; }
      return bv.AreOnlyFirstAndLastBitsSet();
   }
   
   [Benchmark]
   public bool AreOnlyFirstAndLastBitsSet_On_UInt16()
   {
      unchecked { us++; }
      return us.AreOnlyFirstAndLastBitsSet();
   }
   
   [Benchmark]
   public bool AreOnlyFirstAndLastBitsSet_On_UInt32()
   {
      unchecked { ui++; }
      return ui.AreOnlyFirstAndLastBitsSet();
   }

   [Benchmark]
   public bool AreOnlyFirstAndLastBitsSet_On_UInt64()
   {
      unchecked { ul++; }
      return ui.AreOnlyFirstAndLastBitsSet();
   }
   
   [Benchmark]
   public int GetHighestBitSet_On_Byte()
   {
      unchecked { bv++; }

      return bv.GetHighestBitSet();
   }

   [Benchmark]
   public int GetHighestBitSet_On_UInt16()
   {
      unchecked { us++; }

      return us.GetHighestBitSet();
   }
   
   [Benchmark]
   public int GetHighestBitSet_On_UInt32()
   {
      unchecked { ui++; }

      return ui.GetHighestBitSet();
   }
   
   [Benchmark]
   public int GetHighestBitSet_On_UInt64()
   {
      unchecked { ul++; }

      return ul.GetHighestBitSet();
   }
   
   [Benchmark]
   public int GetLowestBitSet_On_Byte()
   {
      unchecked { bv++; }

      return bv.GetLowestBitSet();
   }

   [Benchmark]
   public int GetLowestBitSet_On_UInt16()
   {
      unchecked { us++; }

      return us.GetLowestBitSet();
   }
   
   [Benchmark]
   public int GetLowestBitSet_On_UInt32()
   {
      unchecked { ui++; }

      return ui.GetLowestBitSet();
   }
   
   [Benchmark]
   public int GetLowestBitSet_On_UInt64()
   {
      unchecked { ul++; }

      return ul.GetLowestBitSet();
   }
   
   [Benchmark]
   public byte GetValueOrNextHigherPowerOfTwo_On_Byte()
   {
      unchecked { bv++; }

      return bv.GetValueOrNextHigherPowerOfTwo();
   }

   [Benchmark]
   public ushort GetValueOrNextHigherPowerOfTwo_On_UInt16()
   {
      unchecked { us++; }

      return us.GetValueOrNextHigherPowerOfTwo();
   }
   
   [Benchmark]
   public uint GetValueOrNextHigherPowerOfTwo_On_UInt32()
   {
      unchecked { ui++; }

      return ui.GetValueOrNextHigherPowerOfTwo();
   }
   
   [Benchmark]
   public ulong GetValueOrNextHigherPowerOfTwo_On_UInt64()
   {
      unchecked { ul++; }

      return ul.GetValueOrNextHigherPowerOfTwo();
   }
}
#region

using BenchmarkDotNet.Attributes;

using Jcd.BitManipulation.Algorithms;

#endregion

namespace Jcd.BitManipulation.Benchmark.Algorithms;

public class RoundUpToPowerOfTwo
{
   private static readonly Random Rnd = new();
   private byte bv = (byte) (Rnd.Next()                                % byte.MaxValue);
   private uint ui = (uint) (Rnd.Next()                                % uint.MaxValue);
   private ulong ul = ((ulong) Rnd.Next() << 32) | ((ulong) Rnd.Next() % ulong.MaxValue);
   private ushort us = (ushort) (Rnd.Next()                            % ushort.MaxValue);

   [Benchmark]
   public ulong Unchecked_Increment_Subtract_From_Results()
   {
      unchecked
      {
         return ul++;
      }
   }

   [Benchmark]
   public byte On_Byte()
   {
      unchecked
      {
         bv++;
      }

      return bv.RoundUpToPowerOfTwo();
   }

   [Benchmark]
   public ushort On_UInt16()
   {
      unchecked
      {
         us++;
      }

      return us.RoundUpToPowerOfTwo();
   }

   [Benchmark]
   public uint On_UInt32()
   {
      unchecked
      {
         ui++;
      }

      return ui.RoundUpToPowerOfTwo();
   }

   [Benchmark]
   public ulong On_UInt64()
   {
      unchecked
      {
         ul++;
      }

      return ul.RoundUpToPowerOfTwo();
   }
}
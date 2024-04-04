#region

using BenchmarkDotNet.Attributes;

using Jcd.BitManipulation.Algorithms;

#pragma warning disable S3400

#endregion

namespace Jcd.BitManipulation.Benchmark.Algorithms;

public class CountLeadingZeros
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
   public int On_Byte()
   {
      unchecked
      {
         bv++;
      }

      return bv.CountLeadingZeros();
   }

   [Benchmark]
   public int On_UInt16()
   {
      unchecked
      {
         us++;
      }

      return us.CountLeadingZeros();
   }

   [Benchmark]
   public int On_UInt32()
   {
      unchecked
      {
         ui++;
      }

      return ui.CountLeadingZeros();
   }

   [Benchmark]
   public int On_UInt64()
   {
      unchecked
      {
         ul++;
      }

      return ul.CountLeadingZeros();
   }

   [Benchmark]
   public ushort BuiltIn_On_Byte()
   {
      #if BUILTIN_BITMANIPULATION
      unchecked
      {
         ui++;
      }

      return byte.LeadingZeroCount(bv);
      #else
      return default;
      #endif
   }

   [Benchmark]
   public ushort BuiltIn_On_UInt16()
   {
      #if BUILTIN_BITMANIPULATION
      unchecked
      {
         ui++;
      }

      return ushort.LeadingZeroCount(us);
      #else
      return default;
      #endif
   }

   [Benchmark]
   public uint BuiltIn_On_UInt32()
   {
      #if BUILTIN_BITMANIPULATION
      unchecked
      {
         ui++;
      }

      return uint.LeadingZeroCount(ui);
      #else
      return default;
      #endif
   }

   [Benchmark]
   public ulong BuiltIn_On_UInt64()
   {
      #if BUILTIN_BITMANIPULATION
      unchecked
      {
         ul++;
      }

      return ulong.LeadingZeroCount(ul);
      #else
      return default;
      #endif
   }
}
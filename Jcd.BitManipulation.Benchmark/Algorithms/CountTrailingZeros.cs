#region

using BenchmarkDotNet.Attributes;

using Jcd.BitManipulation.Algorithms;

#pragma warning disable CA1822
#pragma warning disable S109
#pragma warning disable S3400

#endregion

namespace Jcd.BitManipulation.Benchmark.Algorithms;

public class CountTrailingZeros
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

      return bv.CountTrailingZeros();
   }

   [Benchmark]
   public int On_UInt16()
   {
      unchecked
      {
         us++;
      }

      return us.CountTrailingZeros();
   }

   [Benchmark]
   public int On_UInt32()
   {
      unchecked
      {
         ui++;
      }

      return ui.CountTrailingZeros();
   }

   [Benchmark]
   public int On_UInt64()
   {
      unchecked
      {
         ul++;
      }

      return ul.CountTrailingZeros();
   }

   [Benchmark]
   public ushort BuiltIn_On_Byte()
   {
      #if BUILTIN_BITMANIPULATION
      unchecked
      {
         ui++;
      }

      return byte.TrailingZeroCount(bv);
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

      return ushort.TrailingZeroCount(us);
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

      return uint.TrailingZeroCount(ui);
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

      return ulong.TrailingZeroCount(ul);
      #else
      return default;
      #endif
   }
}
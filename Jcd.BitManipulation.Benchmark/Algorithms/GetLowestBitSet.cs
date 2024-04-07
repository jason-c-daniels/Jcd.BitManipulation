﻿#region

using BenchmarkDotNet.Attributes;

using Jcd.BitManipulation.Algorithms;

#pragma warning disable CA1822
#pragma warning disable S109

#endregion

namespace Jcd.BitManipulation.Benchmark.Algorithms;

public class GetLowestBitSet
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

      return bv.GetLowestBitSet();
   }

   [Benchmark]
   public int On_UInt16()
   {
      unchecked
      {
         us++;
      }

      return us.GetLowestBitSet();
   }

   [Benchmark]
   public int On_UInt32()
   {
      unchecked
      {
         ui++;
      }

      return ui.GetLowestBitSet();
   }

   [Benchmark]
   public int On_UInt64()
   {
      unchecked
      {
         ul++;
      }

      return ul.GetLowestBitSet();
   }
}
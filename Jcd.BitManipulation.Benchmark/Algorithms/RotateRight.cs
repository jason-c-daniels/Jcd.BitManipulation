#region

using BenchmarkDotNet.Attributes;

using Jcd.BitManipulation.Algorithms;

#region

// ReSharper disable once RedundantUsingDirective
using System.Numerics;

#endregion

#pragma warning disable S3400

#endregion

namespace Jcd.BitManipulation.Benchmark.Algorithms;

public class RotateRight
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

      return bv.RotateRight(113);
   }

   [Benchmark]
   public ushort On_UInt16()
   {
      unchecked
      {
         us++;
      }

      return us.RotateRight(113);
   }

   [Benchmark]
   public uint On_UInt32()
   {
      unchecked
      {
         ui++;
      }

      return ui.RotateRight(113);
   }

   [Benchmark]
   public ulong On_UInt64()
   {
      unchecked
      {
         ul++;
      }

      return ul.RotateRight(113);
   }

   [Benchmark]
   public uint BitOperations_On_UInt32()
   {
      #if BITOPERATIONS
      unchecked
      {
         ui++;
      }

      return BitOperations.RotateRight(ui, 113);
      #else
      return default;
      #endif
   }

   [Benchmark]
   public ulong BitOperations_On_UInt64()
   {
      #if BITOPERATIONS
      unchecked
      {
         ul++;
      }

      return BitOperations.RotateRight(ul, 113);
      #else
      return default;
      #endif
   }

   [Benchmark]
   public ushort BuiltIn_On_Byte()
   {
      #if BUILTIN_BITMANIPULATION
      unchecked
      {
         ui++;
      }

      return byte.RotateRight(bv, 113);
      #else
      return default;
      #endif
   }

   public ushort BuiltIn_On_UInt16()
   {
      #if BUILTIN_BITMANIPULATION
      unchecked
      {
         ui++;
      }

      return ushort.RotateRight(us, 113);
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

      return uint.RotateRight(ui, 113);
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

      return ulong.RotateRight(ul, 113);
      #else
      return default;
      #endif
   }
}
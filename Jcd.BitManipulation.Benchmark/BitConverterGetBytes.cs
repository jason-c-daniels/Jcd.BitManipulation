using BenchmarkDotNet.Attributes;

// ReSharper disable UnusedMember.Local

namespace Jcd.BitManipulation.Benchmark;

public class BitConverterGetBytes
{
   private const ulong Ui64 = ulong.MaxValue / 2;
   private const long  I64  = long.MaxValue  / 2;
   private const uint  Ui32 = uint.MaxValue  / 2;
   private const int   I32  = int.MaxValue   / 2;

   [Benchmark]
   public byte[] ReadAllBytesOnUInt64AsNativeEndian() { return BitConverter.GetBytes(Ui64); }

   [Benchmark]
   public byte[] ReadAllBytesOnUInt64AsNativeEndianAndReverse()
   {
      var bytes = BitConverter.GetBytes(Ui64);
      Array.Reverse(bytes);

      return bytes;
   }
}
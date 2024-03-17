using BenchmarkDotNet.Attributes;

namespace Jcd.BitManipulation.Benchmark;

public class BitConverterGetBytes
{
   private const ulong ui64 = ulong.MaxValue / 2;
   private const long  i64  = long.MaxValue  / 2;
   private const uint  ui32 = uint.MaxValue  / 2;
   private const int   i32  = int.MaxValue   / 2;

   [Benchmark]
   public byte[] ReadAllBytesOnUInt64AsNativeEndian() { return BitConverter.GetBytes(ui64); }

   [Benchmark]
   public byte[] ReadAllBytesOnUInt64AsNativeEndianAndReverse()
   {
      var bytes = BitConverter.GetBytes(ui64);
      Array.Reverse(bytes);

      return bytes;
   }
}
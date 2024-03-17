using BenchmarkDotNet.Attributes;

namespace Jcd.BitManipulation.Benchmark;

public class ReadBytesBenchmarks
{
   private const ulong ui64 = ulong.MaxValue / 2;
   private const long  i64  = long.MaxValue  / 2;
   private const uint  ui32 = uint.MaxValue  / 2;
   private const int   i32  = int.MaxValue   / 2;

   [Benchmark]
   public byte[] ReadAllBytesOnUInt64AsLittleEndian() { return ui64.ReadBytes(0, sizeof(ulong), Endian.Little); }

   [Benchmark]
   public byte[] ReadAllBytesOnUInt64AsBigEndian() { return ui64.ReadBytes(0, sizeof(ulong), Endian.Big); }

   [Benchmark]
   public byte[] ReadFirstFourBytesOnUInt64AsLittleEndian()
   {
      return ui64.ReadBytes(0, sizeof(ulong) / 2, Endian.Little);
   }

   [Benchmark]
   public byte[] ReadFirstFourBytesOnUInt64AsBigEndian() { return ui64.ReadBytes(0, sizeof(ulong) / 2, Endian.Big); }
}
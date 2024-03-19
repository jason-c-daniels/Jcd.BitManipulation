using BenchmarkDotNet.Attributes;

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable UnusedMember.Local
// ReSharper disable MemberCanBePrivate.Global

namespace Jcd.BitManipulation.Benchmark;

public class ReadBytesBenchmarks
{
   private const ulong Ui64 = ulong.MaxValue / 2;
   private const long  I64  = long.MaxValue  / 2;
   private const uint  Ui32 = uint.MaxValue  / 2;
   private const int   I32  = int.MaxValue   / 2;

   [Benchmark]
   public byte[] ReadAllBytesOnUInt64AsLittleEndian() { return Ui64.ReadBytes(0, sizeof(ulong), Endian.Little); }

   [Benchmark]
   public byte[] ReadAllBytesOnUInt64AsBigEndian() { return Ui64.ReadBytes(0, sizeof(ulong), Endian.Big); }

   [Benchmark]
   public byte[] ReadFirstFourBytesOnUInt64AsLittleEndian() { return Ui64.ReadBytes(0, sizeof(ulong) / 2, Endian.Little); }

   [Benchmark]
   public byte[] ReadFirstFourBytesOnUInt64AsBigEndian() { return Ui64.ReadBytes(0, sizeof(ulong) / 2, Endian.Big); }
}
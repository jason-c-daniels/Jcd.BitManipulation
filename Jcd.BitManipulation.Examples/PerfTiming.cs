#region

using System;
using System.Diagnostics;
using System.Numerics;

using Jcd.BitManipulation.Algorithms;
using Jcd.Units;
using Jcd.Units.UnitsOfMeasure;
using Jcd.Units.UnitsOfMeasure.Data;
using Jcd.Units.UnitsOfMeasure.SI;

// ReSharper disable NotAccessedVariable
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable RedundantAssignment
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable ConvertToConstant.Local
// ReSharper disable UnusedMember.Local
// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable UnusedVariable
#pragma warning disable S1481
#pragma warning disable S1854
#pragma warning disable S125
#pragma warning disable S3254
#pragma warning disable S4055
#pragma warning disable S4056
#pragma warning disable S109
#pragma warning disable S1192

#endregion

namespace Jcd.BitManipulation.Examples;

public static class PerfTiming
{
   public static void TimeBitOperationsRotateRightOnUInt64(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeBitOperationsRotateRightOnUInt64)}");
      }

      const int opsPerIteration = 1;
      var data = 0ul;
      byte upperByte = 0;
      var sw = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         data = BitOperations.RotateRight(data, i);
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeBitOperationsRotateLeftOnUInt64(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeBitOperationsRotateLeftOnUInt64)}");
      }

      const int opsPerIteration = 1;
      var data = 0ul;
      byte upperByte = 0;
      var sw = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         data = BitOperations.RotateLeft(data, i);
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeRotateRightOnUInt64(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeRotateRightOnUInt64)}");
      }

      const int opsPerIteration = 1;
      var data = 0ul;
      byte upperByte = 0;
      var sw = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         data = data.RotateRight(i);
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeRotateLeftOnUInt64(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeRotateLeftOnUInt64)}");
      }

      const int opsPerIteration = 1;
      var data = 0ul;
      byte upperByte = 0;
      var sw = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         data = data.RotateLeft(i);
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeBitManipulations(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeBitManipulations)}");
      }

      const int opsPerIteration = 6;
      var data = 0;
      byte upperByte = 0;
      var sw = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         data = i.SetBits(0, 16)  // value is now 0b1111111111111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 8) // value is now 0b1111000000001111
                 .ToggleBits();   // value is now 0b0000111111110000

         upperByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
           .StoreBits(0b1011, 4, 4);              // store the value in the upper 4 bits, now upperByte is now 0b10111111
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeStoreByteAndReadByteCalls(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeStoreByteAndReadByteCalls)}");
      }

      const int opsPerIteration = 2;
      long data = 0;
      byte upperByte = 0;
      var sw = Stopwatch.StartNew();

      for (long i = 0; i < iterations; i++)
      {
         data = i.StoreByte(0xFF, 1);

         upperByte = data.ReadByte(7); // extract the upper byte
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeStoreByteAndReadByteFromIndexerCalls(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeStoreByteAndReadByteFromIndexerCalls)}");
      }

      const int opsPerIteration = 2;
      long data = 0;
      byte upperByte = 0;
      var sw = Stopwatch.StartNew();
      LittleEndianByteIndexer indexer = 0ul;

      for (long i = 0; i < iterations; i++)
      {
         indexer[1] = 0xFF;
         upperByte = indexer[7];
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeStore8BytesToLongCalls(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeStore8BytesToLongCalls)}");
      }

      const int opsPerIteration = 1;
      long data = 0;
      byte upperByte = 0;
      var bytes = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B, 0xFF, 0xFE, 0x0A, 0x0B };
      var sw = Stopwatch.StartNew();

      for (long i = 0; i < iterations; i++)
      {
         data = i.StoreBytes(bytes, 0);
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeStore4BytesToLongCalls(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeStore4BytesToLongCalls)}");
      }

      const int opsPerIteration = 1;
      long data = 0;
      byte upperByte = 0;
      var bytes = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B, 0xFF, 0xFE, 0x0A, 0x0B };
      var sw = Stopwatch.StartNew();

      for (long i = 0; i < iterations; i++)
      {
         data = i.StoreBytes(bytes, 0, 4);
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeStore2BytesToLongCalls(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeStore2BytesToLongCalls)}");
      }

      const int opsPerIteration = 1;
      long data = 0;
      byte upperByte = 0;
      var bytes = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B, 0xFF, 0xFE, 0x0A, 0x0B };
      var sw = Stopwatch.StartNew();

      for (long i = 0; i < iterations; i++)
      {
         data = i.StoreBytes(bytes, 0, 2);
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeStore8BytesToIndexerCalls(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeStore8BytesToIndexerCalls)}");
      }

      const int opsPerIteration = 1;
      byte upperByte = 0;
      var bytes = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B, 0xFF, 0xFE, 0x0A, 0x0B };
      LittleEndianByteIndexer data = 0;
      var sw = Stopwatch.StartNew();

      for (long i = 0; i < iterations; i++)
      {
         data.StoreBytes(bytes, 0);
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeStore4BytesToIndexerCalls(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeStore4BytesToIndexerCalls)}");
      }

      const int opsPerIteration = 1;
      LittleEndianByteIndexer data = 0;
      byte upperByte = 0;
      var bytes = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B, 0xFF, 0xFE, 0x0A, 0x0B };
      var sw = Stopwatch.StartNew();

      for (long i = 0; i < iterations; i++)
      {
         data.StoreBytes(bytes, 0, 4);
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeStore2BytesToIndexerCalls(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeStore2BytesToIndexerCalls)}");
      }

      const int opsPerIteration = 1;
      LittleEndianByteIndexer data = 0;
      byte upperByte = 0;
      var bytes = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B, 0xFF, 0xFE, 0x0A, 0x0B };
      var sw = Stopwatch.StartNew();

      for (long i = 0; i < iterations; i++)
      {
         data.StoreBytes(bytes, 0, 2);
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeByteArrayToUInt64LittleEndianByteIndexer(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeByteArrayToUInt64LittleEndianByteIndexer)}");
      }

      const int opsPerIteration = 1;
      ulong data = 0;
      byte upperByte = 0;
      var bytes = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B, 0xFF, 0xFE, 0x0A, 0x0B };
      var sw = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         bytes[0] = (byte) (i % 256);
         data = bytes.ToUInt64();
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeByteArrayModificationInALoopSubtractFromOtherResults(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeByteArrayModificationInALoopSubtractFromOtherResults)}");
      }

      const int opsPerIteration = 1;
      ulong data = 0;
      byte upperByte = 0;
      var bytes = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B, 0xFF, 0xFE, 0x0A, 0x0B };
      var sw = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         bytes[0] = (byte) (i % 256);
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (bytes[0].ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeByteArrayToUInt64BigEndianByteIndexer(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeByteArrayToUInt64BigEndianByteIndexer)}");
      }

      const int opsPerIteration = 1;
      ulong data = 0;
      byte upperByte = 0;
      var bytes = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B, 0xFF, 0xFE, 0x0A, 0x0B };
      var sw = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         bytes[0] = (byte) (i % 256);
         data = bytes.ToUInt64(Endian.Big);
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeLittleEndianByteIndexerCastOperations(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeLittleEndianByteIndexerCastOperations)}");
      }

      const int opsPerIteration = 2;
      LittleEndianByteIndexer idx = 0L;
      long convertedBack = 0;
      var sw = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         idx = i;
         convertedBack = idx;
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (((long) idx).ToString() == "super happy fun time")
      {
         Console.WriteLine($"{convertedBack}");
      }
   }

   public static void TimeBigEndianByteIndexerCastOperations(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeBigEndianByteIndexerCastOperations)}");
      }

      const int opsPerIteration = 2;
      BigEndianByteIndexer idx = 0L;
      long convertedBack = 0;
      var sw = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         idx = i;
         convertedBack = idx;
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (((long) idx).ToString() == "super happy fun time")
      {
         Console.WriteLine($"{convertedBack}");
      }
   }

   public static void TimeReadOnlySpanOfByteToUInt64LittleEndian(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeReadOnlySpanOfByteToUInt64LittleEndian)}");
      }

      const int opsPerIteration = 1;
      ulong data = 0;
      byte upperByte = 0;
      var actualBytes = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B, 0xFF, 0xFE, 0x0A, 0x0B };
      var bytes = new ReadOnlySpan<byte>();
      var sw = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         actualBytes[0] = (byte) (i % 256);
         data = bytes.ToUInt64();
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeReadOnlySpanOfByteToUInt64BigEndian(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeReadOnlySpanOfByteToUInt64BigEndian)}");
      }

      const int opsPerIteration = 1;
      ulong data = 0;
      byte upperByte = 0;
      var actualBytes = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B, 0xFF, 0xFE, 0x0A, 0x0B };
      var bytes = new ReadOnlySpan<byte>();
      var sw = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         actualBytes[0] = (byte) (i % 256);
         data = bytes.ToUInt64(Endian.Big);
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeByteArrayToUInt64_BitConverter_NativeEndian(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeByteArrayToUInt64_BitConverter_NativeEndian)}");
      }

      const int opsPerIteration = 1;
      ulong data = 0;
      byte upperByte = 0;
      var bytes = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B, 0xFF, 0xFE, 0x0A, 0x0B };
      var sw = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         bytes[0] = (byte) (i % 256);
         data = BitConverter.ToUInt64(bytes);
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void TimeByteArrayToUInt64_BitConverter_ReversedFromNativeEndian(long iterations, bool report = true)
   {
      if (report)
      {
         SystemInfo.Instance.RefreshInfo();
      }

      if (report)
      {
         Console.WriteLine($"  - Name: {nameof(TimeByteArrayToUInt64_BitConverter_ReversedFromNativeEndian)}");
      }

      const int opsPerIteration = 1;
      ulong data = 0;
      byte upperByte = 0;
      var bytes = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B, 0xFF, 0xFE, 0x0A, 0x0B };
      var sw = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         bytes[0] = (byte) (i % 256);
         Array.Reverse(bytes);
         data = bytes.ToUInt64(Endian.Big);
      }

      sw.Stop();

      if (!report)
      {
         return;
      }

      var operationCount = iterations * opsPerIteration;
      var stats = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);

      if (data.ToString() == "super happy fun time")
      {
         Console.WriteLine($"{upperByte} {data}");
      }
   }

   public static void ReportSystemInfo()
   {
      var sysInfo = SystemInfo.Instance;

      var cpu = sysInfo.Cpu;
      Console.WriteLine($"Run Date and Time: {DateTimeOffset.UtcNow:yyyy'-'MM'-'dd' 'HH':'mm':'ss} UTC");
      Console.WriteLine("CPU Info:");
      Console.WriteLine($"  Name: {cpu.Name}");
      Console.WriteLine($"  Maximum CPU Frequency: {sysInfo.MaximumCpuFrequency:n2}");
      Console.WriteLine($"  Manufacturer: {cpu.Manufacturer}");
      Console.WriteLine($"  Description: {cpu.Description}");
      Console.WriteLine($"  ProcId: {cpu.ProcessorId}");
      Console.WriteLine($"  Socket: {cpu.SocketDesignation}");
      Console.WriteLine($"  Number of Cores: {cpu.NumberOfCores}");
      Console.WriteLine($"  Number of Logical Processors : {cpu.NumberOfLogicalProcessors}");

      Console.WriteLine($"  L2 Cache Size: {cpu.L2CacheSize.As(StorageUnits.Byte).To(StorageUnits.Mebibyte):n2}");

      Console.WriteLine($"  L3 Cache Size: {cpu.L3CacheSize.As(StorageUnits.Byte).To(StorageUnits.Mebibyte):n2}");

      Console.WriteLine($"  Virtualization Firmware Enabled: {cpu.VirtualizationFirmwareEnabled}");
      Console.WriteLine();
      Console.WriteLine("Tests:");
   }

   private static void ReportStats(RunStats stats, long operationCount, long iterations)
   {
      Console.WriteLine($"    Average CPU Frequency: {stats.AverageCpuFrequency:n3}");
      Console.WriteLine($"    Iteration Count: {iterations:n0}");
      Console.WriteLine($"    Operations Per Iteration: {stats.OperationsPerIteration:n0}");
      Console.WriteLine($"    Total Operation Count: {operationCount:n0}");
      Console.WriteLine($"    Total Time Elapsed: {stats.Elapsed:n3}");
      Console.WriteLine($"    Total CPU Cycles: {stats.TotalCpuCycles:n0}");

      Console.WriteLine($"    Time Elapsed Per Iteration: {stats.ElapsedPerOperation * stats.OperationsPerIteration:n3}");

      Console.WriteLine($"    CPU Cycles Per Iteration: {stats.CpuCyclesPerOperation * stats.OperationsPerIteration:n3}");
      Console.WriteLine($"    Time Elapsed Per Operation: {stats.ElapsedPerOperation:n3}");
      Console.WriteLine($"    CPU Cycles Per Operation: {stats.CpuCyclesPerOperation:n3}");

      Console.WriteLine();
   }

   private static RunStats CalculateStats(Stopwatch stopwatch, long operationCount, long iterations)
   {
      var cpuF1 = SystemInfo.Instance.CurrentCpuFrequency;
      SystemInfo.Instance.RefreshInfo();
      var cpuF2 = SystemInfo.Instance.CurrentCpuFrequency;
      var freq = (cpuF1 + cpuF2) / 2;

      if (freq < 1.As(Frequencies.Gigahertz))
      {
         freq = freq.To(Frequencies.Megahertz);
      }

      var duration = stopwatch.Elapsed.As(Durations.Microsecond);
      var durationPer = (duration / operationCount).To(Durations.Nanosecond);

      var totalCpuCycles = freq.To(Frequencies.Hertz).RawValue * duration.To(Durations.Second).RawValue;

      var cpuCyclesPer = totalCpuCycles / operationCount;

      return new RunStats(duration, durationPer, totalCpuCycles, cpuCyclesPer, freq, operationCount / iterations);
   }
}
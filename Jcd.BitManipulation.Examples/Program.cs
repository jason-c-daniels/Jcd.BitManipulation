// ReSharper disable RedundantArgumentDefaultValue

#region

using System;
using System.Diagnostics;

using Jcd.Units;
using Jcd.Units.UnitsOfMeasure;
using Jcd.Units.UnitsOfMeasure.Data;
using Jcd.Units.UnitsOfMeasure.SI;

// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable RedundantAssignment
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable ConvertToConstant.Local
// ReSharper disable UnusedMember.Local
// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable UnusedVariable

#endregion

namespace Jcd.BitManipulation.Examples;

internal static class Program
{
   private static void Main()
   {
      // chaining operations, the same steps and end results

      #if DEBUG
      const int iterations = 1_000_000;
      #else
        const int iterations = 100_000_000;
      #endif
      var ul     = 0xFFFEFDFEFCFBFAF9;
      var ulbi   = (BigEndianByteIndexerUInt64) ul;
      var b0     = ulbi[0];
      var b1     = ulbi[1];
      var b2     = ulbi[2];
      var ba     = ul.ToByteArray();
      var baBigE = ul.ToByteArray(Endian.Big);
      var ul1    = ba.ToUInt64();
      var ul2    = ba.ToUInt64(Endian.Big);
      var ul3    = baBigE.ToUInt64(Endian.Big);
      var ul4    = baBigE.ToUInt64();
      var ba1    = ul1.ToByteArray();
      var ba2    = ul2.ToByteArray();

      // warm things up        
      TimeBitManipulations(iterations                     / 10, false);
      TimeStoreByteAndReadByteCalls(iterations            / 10, false);
      TimeStoreByteAndReadByteFromIndexerCalls(iterations / 10, false);
      TimeCastOperations(iterations                       / 10, false);
      TimeStore8BytesToLongCalls(iterations               / 10, false);
      TimeStore4BytesToLongCalls(iterations               / 10, false);
      TimeStore2BytesToLongCalls(iterations               / 10, false);
      TimeStore8BytesToIndexerCalls(iterations            / 10, false);
      TimeStore4BytesToIndexerCalls(iterations            / 10, false);
      TimeStore2BytesToIndexerCalls(iterations            / 10, false);
      TimeByteArrayToUInt64(iterations                    / 10, false);
      TimeByteArrayToUInt64BigEndian(iterations           / 10, false);
      TimeReadOnlySpanOfByteToUInt64(iterations           / 10, false);
      TimeReadOnlySpanOfByteToUInt64BigEndian(iterations  / 10, false);

      // now run and report.
      ReportSystemInfo();
      TimeBitManipulations(iterations);
      TimeStoreByteAndReadByteCalls(iterations);
      TimeStoreByteAndReadByteFromIndexerCalls(iterations);
      TimeCastOperations(iterations);
      TimeStore8BytesToLongCalls(iterations);
      TimeStore4BytesToLongCalls(iterations);
      TimeStore2BytesToLongCalls(iterations);
      TimeStore8BytesToIndexerCalls(iterations);
      TimeStore4BytesToIndexerCalls(iterations);
      TimeStore2BytesToIndexerCalls(iterations);
      TimeByteArrayToUInt64(iterations);
      TimeByteArrayToUInt64BigEndian(iterations);
      TimeReadOnlySpanOfByteToUInt64(iterations);
      TimeReadOnlySpanOfByteToUInt64BigEndian(iterations);
   }

   private static void ReportSystemInfo()
   {
      var sysInfo = SystemInfo.Instance;

      var cpu = sysInfo.CPU;
      Console.WriteLine($"Run Date and Time: {DateTime.UtcNow:yyyy'-'MM'-'dd' 'HH':'mm':'ss} UTC");
      Console.WriteLine("CPU Info:");
      Console.WriteLine($"  Name: {cpu.Name}");
      Console.WriteLine($"  Maximum CPU Frequency: {sysInfo.MaximumCPUFrequency:n2}");
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

   private static void TimeBitManipulations(int iterations, bool report = true)
   {
      if (report) SystemInfo.Instance.RefreshInfo();
      if (report) Console.WriteLine($"  - Name: {nameof(TimeBitManipulations)}");
      const int opsPerIteration = 6;
      var       data            = 0;
      byte      upperByte       = 0;
      var       sw              = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         data = i.SetBits(0, 16)  // value is now 0b1111111111111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 8) // value is now 0b1111000000001111
                 .ToggleBits();   // value is now 0b0000111111110000

         upperByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
           .StoreBits(0b1011, 4, 4); // store the value in the upper 4 bits, now upperByte is now 0b10111111
      }

      sw.Stop();

      if (!report) return;
      var operationCount = iterations * opsPerIteration;
      var stats          = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);
      if ("super happy fun time" == data.ToString()) Console.WriteLine($"{upperByte} {data}");
   }

   private static void TimeStoreByteAndReadByteCalls(int iterations, bool report = true)
   {
      if (report) SystemInfo.Instance.RefreshInfo();
      if (report) Console.WriteLine($"  - Name: {nameof(TimeStoreByteAndReadByteCalls)}");
      const int opsPerIteration = 2;
      long      data            = 0;
      byte      upperByte       = 0;
      var       fourBytes       = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B };
      var       sw              = Stopwatch.StartNew();

      for (long i = 0; i < iterations; i++)
      {
         data = i.StoreByte(0xFF, 1);

         upperByte = data.ReadByte(7); // extract the upper byte
      }

      sw.Stop();

      if (!report) return;
      var operationCount = iterations * opsPerIteration;
      var stats          = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);
      if ("super happy fun time" == data.ToString()) Console.WriteLine($"{upperByte} {data}");
   }

   private static void TimeStoreByteAndReadByteFromIndexerCalls(int iterations, bool report = true)
   {
      if (report) SystemInfo.Instance.RefreshInfo();
      if (report) Console.WriteLine($"  - Name: {nameof(TimeStoreByteAndReadByteFromIndexerCalls)}");
      const int                     opsPerIteration = 2;
      long                          data            = 0;
      byte                          upperByte       = 0;
      var                           fourBytes       = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B };
      var                           sw              = Stopwatch.StartNew();
      LittleEndianByteIndexerUInt64 indexer         = 0ul;

      for (long i = 0; i < iterations; i++)
      {
         indexer[1] = 0xFF;
         upperByte  = indexer[7];
      }

      sw.Stop();

      if (!report) return;
      var operationCount = iterations * opsPerIteration;
      var stats          = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);
      if ("super happy fun time" == data.ToString()) Console.WriteLine($"{upperByte} {data}");
   }

   private static void TimeStore8BytesToLongCalls(int iterations, bool report = true)
   {
      if (report) SystemInfo.Instance.RefreshInfo();
      if (report) Console.WriteLine($"  - Name: {nameof(TimeStore8BytesToLongCalls)}");
      const int opsPerIteration = 1;
      long      data            = 0;
      byte      upperByte       = 0;
      var bytes = new byte[]
                  {
                     0xFF
                   , 0xFE
                   , 0x0A
                   , 0x0B
                   , 0xFF
                   , 0xFE
                   , 0x0A
                   , 0x0B
                  };
      var sw                                     = Stopwatch.StartNew();
      for (long i = 0; i < iterations; i++) data = i.StoreBytes(bytes, 0);

      sw.Stop();

      if (!report) return;
      var operationCount = iterations * opsPerIteration;
      var stats          = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);
      if ("super happy fun time" == data.ToString()) Console.WriteLine($"{upperByte} {data}");
   }

   private static void TimeStore4BytesToLongCalls(int iterations, bool report = true)
   {
      if (report) SystemInfo.Instance.RefreshInfo();
      if (report) Console.WriteLine($"  - Name: {nameof(TimeStore4BytesToLongCalls)}");
      const int opsPerIteration = 1;
      long      data            = 0;
      byte      upperByte       = 0;
      var bytes = new byte[]
                  {
                     0xFF
                   , 0xFE
                   , 0x0A
                   , 0x0B
                   , 0xFF
                   , 0xFE
                   , 0x0A
                   , 0x0B
                  };
      var sw                                     = Stopwatch.StartNew();
      for (long i = 0; i < iterations; i++) data = i.StoreBytes(bytes, 0, 4);

      sw.Stop();

      if (!report) return;
      var operationCount = iterations * opsPerIteration;
      var stats          = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);
      if ("super happy fun time" == data.ToString()) Console.WriteLine($"{upperByte} {data}");
   }

   private static void TimeStore2BytesToLongCalls(int iterations, bool report = true)
   {
      if (report) SystemInfo.Instance.RefreshInfo();
      if (report) Console.WriteLine($"  - Name: {nameof(TimeStore2BytesToLongCalls)}");
      const int opsPerIteration = 1;
      long      data            = 0;
      byte      upperByte       = 0;
      var bytes = new byte[]
                  {
                     0xFF
                   , 0xFE
                   , 0x0A
                   , 0x0B
                   , 0xFF
                   , 0xFE
                   , 0x0A
                   , 0x0B
                  };
      var sw                                     = Stopwatch.StartNew();
      for (long i = 0; i < iterations; i++) data = i.StoreBytes(bytes, 0, 2);

      sw.Stop();

      if (!report) return;
      var operationCount = iterations * opsPerIteration;
      var stats          = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);
      if ("super happy fun time" == data.ToString()) Console.WriteLine($"{upperByte} {data}");
   }

   private static void TimeStore8BytesToIndexerCalls(int iterations, bool report = true)
   {
      if (report) SystemInfo.Instance.RefreshInfo();
      if (report) Console.WriteLine($"  - Name: {nameof(TimeStore8BytesToIndexerCalls)}");
      const int opsPerIteration = 1;
      byte      upperByte       = 0;
      var bytes = new byte[]
                  {
                     0xFF
                   , 0xFE
                   , 0x0A
                   , 0x0B
                   , 0xFF
                   , 0xFE
                   , 0x0A
                   , 0x0B
                  };
      LittleEndianByteIndexerInt64 data = 0;
      var                          sw   = Stopwatch.StartNew();
      for (long i = 0; i < iterations; i++) data.StoreBytes(bytes, 0);

      sw.Stop();

      if (!report) return;
      var operationCount = iterations * opsPerIteration;
      var stats          = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);
      if ("super happy fun time" == data.ToString()) Console.WriteLine($"{upperByte} {data}");
   }

   private static void TimeStore4BytesToIndexerCalls(int iterations, bool report = true)
   {
      if (report) SystemInfo.Instance.RefreshInfo();
      if (report) Console.WriteLine($"  - Name: {nameof(TimeStore4BytesToIndexerCalls)}");
      const int                    opsPerIteration = 1;
      LittleEndianByteIndexerInt64 data            = 0;
      byte                         upperByte       = 0;
      var bytes = new byte[]
                  {
                     0xFF
                   , 0xFE
                   , 0x0A
                   , 0x0B
                   , 0xFF
                   , 0xFE
                   , 0x0A
                   , 0x0B
                  };
      var sw = Stopwatch.StartNew();
      for (long i = 0; i < iterations; i++) data.StoreBytes(bytes, 0, 4);

      sw.Stop();

      if (!report) return;
      var operationCount = iterations * opsPerIteration;
      var stats          = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);
      if ("super happy fun time" == data.ToString()) Console.WriteLine($"{upperByte} {data}");
   }

   private static void TimeStore2BytesToIndexerCalls(int iterations, bool report = true)
   {
      if (report) SystemInfo.Instance.RefreshInfo();
      if (report) Console.WriteLine($"  - Name: {nameof(TimeStore2BytesToIndexerCalls)}");
      const int                    opsPerIteration = 1;
      LittleEndianByteIndexerInt64 data            = 0;
      byte                         upperByte       = 0;
      var bytes = new byte[]
                  {
                     0xFF
                   , 0xFE
                   , 0x0A
                   , 0x0B
                   , 0xFF
                   , 0xFE
                   , 0x0A
                   , 0x0B
                  };
      var sw = Stopwatch.StartNew();
      for (long i = 0; i < iterations; i++) data.StoreBytes(bytes, 0, 2);

      sw.Stop();

      if (!report) return;
      var operationCount = iterations * opsPerIteration;
      var stats          = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);
      if ("super happy fun time" == data.ToString()) Console.WriteLine($"{upperByte} {data}");
   }

   private static void TimeByteArrayToUInt64(int iterations, bool report = true)
   {
      if (report) SystemInfo.Instance.RefreshInfo();
      if (report) Console.WriteLine($"  - Name: {nameof(TimeByteArrayToUInt64)}");
      const int opsPerIteration = 1;
      ulong     data            = 0;
      byte      upperByte       = 0;
      var bytes = new byte[]
                  {
                     0xFF
                   , 0xFE
                   , 0x0A
                   , 0x0B
                   , 0xFF
                   , 0xFE
                   , 0x0A
                   , 0x0B
                  };
      var sw = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         bytes[0] = (byte) (i % 256);
         data     = bytes.ToUInt64();
      }

      sw.Stop();

      if (!report) return;
      var operationCount = iterations * opsPerIteration;
      var stats          = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);
      if ("super happy fun time" == data.ToString()) Console.WriteLine($"{upperByte} {data}");
   }

   private static void TimeByteArrayToUInt64BigEndian(int iterations, bool report = true)
   {
      if (report) SystemInfo.Instance.RefreshInfo();
      if (report) Console.WriteLine($"  - Name: {nameof(TimeByteArrayToUInt64BigEndian)}");
      const int opsPerIteration = 1;
      ulong     data            = 0;
      byte      upperByte       = 0;
      var bytes = new byte[]
                  {
                     0xFF
                   , 0xFE
                   , 0x0A
                   , 0x0B
                   , 0xFF
                   , 0xFE
                   , 0x0A
                   , 0x0B
                  };
      var sw = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         bytes[0] = (byte) (i % 256);
         data     = bytes.ToUInt64(Endian.Big);
      }

      sw.Stop();

      if (!report) return;
      var operationCount = iterations * opsPerIteration;
      var stats          = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);
      if ("super happy fun time" == data.ToString()) Console.WriteLine($"{upperByte} {data}");
   }

   private static void TimeCastOperations(int iterations, bool report = true)
   {
      if (report) SystemInfo.Instance.RefreshInfo();
      if (report) Console.WriteLine($"  - Name: {nameof(TimeCastOperations)}");
      const int                    opsPerIteration = 2;
      LittleEndianByteIndexerInt64 idx             = 0;
      long                         convertedBack   = 0;
      var                          sw              = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         idx           = i;
         convertedBack = idx;
      }

      sw.Stop();

      if (!report) return;
      var operationCount = iterations * opsPerIteration;
      var stats          = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);
      if ("super happy fun time" == ((long) idx).ToString()) Console.WriteLine($"{convertedBack}");
   }

   private static void TimeReadOnlySpanOfByteToUInt64(int iterations, bool report = true)
   {
      if (report) SystemInfo.Instance.RefreshInfo();
      if (report) Console.WriteLine($"  - Name: {nameof(TimeReadOnlySpanOfByteToUInt64)}");
      const int opsPerIteration = 1;
      ulong     data            = 0;
      byte      upperByte       = 0;
      var actualBytes = new byte[]
                        {
                           0xFF
                         , 0xFE
                         , 0x0A
                         , 0x0B
                         , 0xFF
                         , 0xFE
                         , 0x0A
                         , 0x0B
                        };
      var bytes = new ReadOnlySpan<byte>();
      var sw    = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         actualBytes[0] = (byte) (i % 256);
         data           = bytes.ToUInt64();
      }

      sw.Stop();

      if (!report) return;
      var operationCount = iterations * opsPerIteration;
      var stats          = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);
      if ("super happy fun time" == data.ToString()) Console.WriteLine($"{upperByte} {data}");
   }

   private static void TimeReadOnlySpanOfByteToUInt64BigEndian(int iterations, bool report = true)
   {
      if (report) SystemInfo.Instance.RefreshInfo();
      if (report) Console.WriteLine($"  - Name: {nameof(TimeReadOnlySpanOfByteToUInt64BigEndian)}");
      const int opsPerIteration = 1;
      ulong     data            = 0;
      byte      upperByte       = 0;
      var actualBytes = new byte[]
                        {
                           0xFF
                         , 0xFE
                         , 0x0A
                         , 0x0B
                         , 0xFF
                         , 0xFE
                         , 0x0A
                         , 0x0B
                        };
      var bytes = new ReadOnlySpan<byte>();
      var sw    = Stopwatch.StartNew();

      for (var i = 0; i < iterations; i++)
      {
         actualBytes[0] = (byte) (i % 256);
         data           = bytes.ToUInt64(Endian.Big);
      }

      sw.Stop();

      if (!report) return;
      var operationCount = iterations * opsPerIteration;
      var stats          = CalculateStats(sw, operationCount, iterations);
      ReportStats(stats, operationCount, iterations);
      if ("super happy fun time" == data.ToString()) Console.WriteLine($"{upperByte} {data}");
   }

   private static void ReportStats(RunStats stats, int operationCount, int iterations)
   {
      Console.WriteLine($"    Average CPU Frequency: {stats.AverageCpuFrequency:n3}");
      Console.WriteLine($"    Iteration Count: {iterations:n0}");
      Console.WriteLine($"    Operations Per Iteration: {stats.OperationsPerIteration:n0}");
      Console.WriteLine($"    Total Operation Count: {operationCount:n0}");
      Console.WriteLine($"    Total Time Elapsed: {stats.Elapsed:n3}");
      Console.WriteLine($"    Total CPU Cycles: {stats.TotalCpuCycles:n0}");

      Console.WriteLine($"    Time Elapsed Per Iteration: {stats.ElapsedPerOperation * stats.OperationsPerIteration:n3}"
                       );

      Console.WriteLine($"    CPU Cycles Per Iteration: {stats.CpuCyclesPerOperation * stats.OperationsPerIteration:n3}"
                       );
      Console.WriteLine($"    Time Elapsed Per Operation: {stats.ElapsedPerOperation:n3}");
      Console.WriteLine($"    CPU Cycles Per Operation: {stats.CpuCyclesPerOperation:n3}");

      Console.WriteLine();
   }

   private static RunStats CalculateStats(Stopwatch stopwatch, int operationCount, int iterations)
   {
      var cpuF1 = SystemInfo.Instance.CurrentCPUFrequency;
      SystemInfo.Instance.RefreshInfo();
      var cpuF2                                    = SystemInfo.Instance.CurrentCPUFrequency;
      var freq                                     = (cpuF1 + cpuF2) / 2;
      if (freq < 1.As(Frequencies.Gigahertz)) freq = freq.To(Frequencies.Megahertz);
      var duration                                 = stopwatch.Elapsed.As(Durations.Microsecond);
      var durationPer                              = (duration / operationCount).To(Durations.Nanosecond);

      var totalCpuCycles = freq.To(Frequencies.Hertz)
                               .RawValue
                         * duration.To(Durations.Second)
                                   .RawValue;

      var cpuCyclesPer = totalCpuCycles / operationCount;

      return new RunStats(duration
                        , durationPer
                        , totalCpuCycles
                        , cpuCyclesPer
                        , freq
                        , operationCount / iterations
                         );
   }

   private static void ReadMe_BitManipulation_Example()
   {
      ushort data = 0b0000000000000000;

      // turn on all the bits
      data = data.SetBits(0, 16); // value is now 0b1111111111111111

      // this is the equivalent as above
      data = data.SetBits();

      // Clear the middle 4 bits.
      data = data.ClearBits(4, 8); // value is now 0b1111000000001111

      // Toggle all the bits.
      data = data.ToggleBits(); // value is now 0b0000111111110000

      // read the upper byte 
      var upperByte = (byte) data.ReadBits(8, 8); // upperByte is now 0b00001111

      // write 0b1011 into the upper nybble
      upperByte = upperByte.StoreBits(0b1011, 4, 4); // upperByte is now 0b10111111

      // chaining operations, the same steps and end results
      data.ClearBits();
      data = data.SetBits(0, 16)  // value is now 0b1111111111111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 8) // value is now 0b1111000000001111
                 .ToggleBits();   // value is now 0b0000111111110000

      upperByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
        .StoreBits(0b1011, 4, 4);              // store the value in the upper 4 bits, now upperByte is now 0b10111111
   }
}
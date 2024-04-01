#region

using System;
using System.Diagnostics;

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

internal static class Program
{
   public static void Main()
   {
      BitIndexer_Example();
      ByteIndexer_Example();
      ReadMe_BitManipulation_Byte_Example();
      ReadMe_BitManipulation_SByte_Example();
      ReadMe_BitManipulation_UInt16_Example();
      ReadMe_BitManipulation_Int16_Example();
      ReadMe_BitManipulation_UInt32_Example();
      ReadMe_BitManipulation_Int32_Example();
      ReadMe_BitManipulation_UInt64_Example();
      ReadMe_BitManipulation_Int64_Example();

      BigEndianByteIndexer bebiFlt = float.MaxValue / 2;
      var bebifltbytes = bebiFlt[..];

      // chaining operations, the same steps and end results

      #if DEBUG
      const long iterations = 1_000_000;
      #else
      const long iterations = 75_000_000;
      #endif
      var f = 1.33f;
      var bits = f.BitwiseToUInt32().ReadBits(0, 4);
      var ul = 0xDECAFFC0FFEEC0DE;
      var ulbi = (BigEndianByteIndexer) ul;
      var b0 = ulbi[0];
      var b1 = ulbi[1];
      var b2 = ulbi[2];
      var ba = ul.ToByteArray();
      var baBigE = ul.ToByteArray(Endian.Big);
      var ul1 = ba.ToUInt64();
      var ul2 = ba.ToUInt64(Endian.Big);
      var ul3 = baBigE.ToUInt64(Endian.Big);
      var ul4 = baBigE.ToUInt64();
      var ba1 = ul1.ToByteArray();
      var ba2 = ul2.ToByteArray();

      // warm things up
      TimeBitManipulations(iterations                                        / 10, false);
      TimeStoreByteAndReadByteCalls(iterations                               / 10, false);
      TimeStoreByteAndReadByteFromIndexerCalls(iterations                    / 10, false);
      TimeLittleEndianByteIndexerCastOperations(iterations                   / 10, false);
      TimeBigEndianByteIndexerCastOperations(iterations                      / 10, false);
      TimeByteArrayModificationInALoopSubtractFromOtherResults(iterations    / 10, false);
      TimeStore8BytesToLongCalls(iterations                                  / 10, false);
      TimeStore4BytesToLongCalls(iterations                                  / 10, false);
      TimeStore2BytesToLongCalls(iterations                                  / 10, false);
      TimeStore8BytesToIndexerCalls(iterations                               / 10, false);
      TimeStore4BytesToIndexerCalls(iterations                               / 10, false);
      TimeStore2BytesToIndexerCalls(iterations                               / 10, false);
      TimeByteArrayToUInt64_BitConverter_NativeEndian(iterations             / 10, false);
      TimeByteArrayToUInt64_BitConverter_ReversedFromNativeEndian(iterations / 10, false);
      TimeByteArrayToUInt64LittleEndianByteIndexer(iterations                / 10, false);
      TimeByteArrayToUInt64BigEndianByteIndexer(iterations                   / 10, false);
      TimeReadOnlySpanOfByteToUInt64LittleEndian(iterations                  / 10, false);
      TimeReadOnlySpanOfByteToUInt64BigEndian(iterations                     / 10, false);

      // now run and report.
      ReportSystemInfo();
      TimeBitManipulations(iterations);
      TimeStoreByteAndReadByteCalls(iterations);
      TimeStoreByteAndReadByteFromIndexerCalls(iterations);
      TimeLittleEndianByteIndexerCastOperations(iterations);
      TimeBigEndianByteIndexerCastOperations(iterations);
      TimeByteArrayModificationInALoopSubtractFromOtherResults(iterations / 10);
      TimeStore8BytesToLongCalls(iterations);
      TimeStore4BytesToLongCalls(iterations);
      TimeStore2BytesToLongCalls(iterations);
      TimeStore8BytesToIndexerCalls(iterations);
      TimeStore4BytesToIndexerCalls(iterations);
      TimeStore2BytesToIndexerCalls(iterations);
      TimeByteArrayToUInt64_BitConverter_NativeEndian(iterations             / 10);
      TimeByteArrayToUInt64_BitConverter_ReversedFromNativeEndian(iterations / 10);
      TimeByteArrayToUInt64LittleEndianByteIndexer(iterations);
      TimeByteArrayToUInt64BigEndianByteIndexer(iterations);
      TimeReadOnlySpanOfByteToUInt64LittleEndian(iterations);
      TimeReadOnlySpanOfByteToUInt64BigEndian(iterations);
   }

   private static void ReportSystemInfo()
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

   private static void TimeBitManipulations(long iterations, bool report = true)
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

   private static void TimeStoreByteAndReadByteCalls(long iterations, bool report = true)
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
      var fourBytes = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B };
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

   private static void TimeStoreByteAndReadByteFromIndexerCalls(long iterations, bool report = true)
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
      var fourBytes = new byte[] { 0xFF, 0xFE, 0x0A, 0x0B };
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

   private static void TimeStore8BytesToLongCalls(long iterations, bool report = true)
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

   private static void TimeStore4BytesToLongCalls(long iterations, bool report = true)
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

   private static void TimeStore2BytesToLongCalls(long iterations, bool report = true)
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

   private static void TimeStore8BytesToIndexerCalls(long iterations, bool report = true)
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

   private static void TimeStore4BytesToIndexerCalls(long iterations, bool report = true)
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

   private static void TimeStore2BytesToIndexerCalls(long iterations, bool report = true)
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

   private static void TimeByteArrayToUInt64LittleEndianByteIndexer(long iterations, bool report = true)
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

   private static void TimeByteArrayModificationInALoopSubtractFromOtherResults(long iterations, bool report = true)
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

   private static void TimeByteArrayToUInt64BigEndianByteIndexer(long iterations, bool report = true)
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

   private static void TimeLittleEndianByteIndexerCastOperations(long iterations, bool report = true)
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

   private static void TimeBigEndianByteIndexerCastOperations(long iterations, bool report = true)
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

   private static void TimeReadOnlySpanOfByteToUInt64LittleEndian(long iterations, bool report = true)
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

   private static void TimeReadOnlySpanOfByteToUInt64BigEndian(long iterations, bool report = true)
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

   private static void TimeByteArrayToUInt64_BitConverter_NativeEndian(long iterations, bool report = true)
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

   private static void TimeByteArrayToUInt64_BitConverter_ReversedFromNativeEndian(long iterations, bool report = true)
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

   private static void ReadMe_BitManipulation_Byte_Example()
   {
      byte data = 0b00000000;

      // turn on all the bits
      data = data.SetBits(0, 8); // value is now 0b11111111

      // this is the equivalent as above
      data = data.SetBits();

      // Clear the upper 4 bits.
      data = data.ClearBits(4, 4); // value is now 0b00001111

      // Toggle all the bits.
      data = data.ToggleBits(); // value is now 0b11110000

      // read the upper nybble as a byte
      var upperNybble = data.ReadBits(4, 4); // upperNybble is now 0b00001111

      // write 0b1011 into the upper nybble of data
      data = data.StoreBits(0b1011, 4, 4); // data is now 0b10110000

      // chaining operations, the same steps and end results
      data.ClearBits();
      data = data.SetBits(0, 8)   // value is now 0b11111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 4) // value is now 0b00001111
                 .ToggleBits();   // value is now 0b11110000

      upperNybble = data.ReadBits(4, 4)           // extract the upper nybble (0b00001111)
                        .StoreBits(0b1011, 4, 4); // store the value in the upper 4 bits, now upperByte is now 0b10111111
   }

   private static void ReadMe_BitManipulation_SByte_Example()
   {
      sbyte data = 0b00000000;

      // turn on all the bits
      data = data.SetBits(0, 8); // value is now 0b11111111

      // this is the equivalent as above
      data = data.SetBits();

      // Clear the upper 4 bits.
      data = data.ClearBits(4, 4); // value is now 0b00001111

      // Toggle all the bits.
      data = data.ToggleBits(); // value is now 0b11110000

      // read the upper nybble as a byte
      var upperNybble = data.ReadBits(4, 4); // upperNybble is now 0b00001111

      // write 0b1011 into the upper nybble of data
      data = data.StoreBits(0b1011, 4, 4); // data is now 0b10110000

      // chaining operations, the same steps and end results
      data.ClearBits();
      data = data.SetBits(0, 8)   // value is now 0b11111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 4) // value is now 0b00001111
                 .ToggleBits();   // value is now 0b11110000

      upperNybble = data.ReadBits(4, 4)           // extract the upper nybble (0b00001111)
                        .StoreBits(0b1011, 4, 4); // store the value in the upper 4 bits, now upperByte is now 0b10111111
   }

   private static void ReadMe_BitManipulation_UInt16_Example()
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

      var finalData = data;

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

      // finalData 0b0000111111110000
      var beByte0 = finalData.ReadByte(0, Endian.Big);    // 00001111
      var leByte0 = finalData.ReadByte(0, Endian.Little); // 11110000

      var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big).StoreByte(0b01010101, 0, Endian.Little) // lower byte is now 0b01010101
         ;                                                                                                     // mutatedData is now 0b1011111101010101

      var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b01010101]

      var leBa = mutatedData.ToByteArray(Endian.Little); // leBa=[0b01010101, 0b10111111]

      var leBaToUInt16Le = leBa.ToUInt16(Endian.Little); // leBaToUInt16Le = 0b1011111101010101

      var leBaToUInt16Be = leBa.ToUInt16(Endian.Big); // leBaToUInt16Le  = 0b0101010110111111
   }

   private static void ReadMe_BitManipulation_Int16_Example()
   {
      short data = 0b0000000000000000;

      // turn on all the bits
      data = data.SetBits(0, 16); // value is now 0b1111111111111111

      // this is the equivalent as above
      data = data.SetBits();

      // Clear the middle 4 bits.
      data = data.ClearBits(4, 8); // value is now 0b1111000000001111

      // Toggle all the bits.
      data = data.ToggleBits(); // value is now 0b0000111111110000

      var finalData = data;

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

      // finalData 0b0000111111110000
      var beByte0 = finalData.ReadByte(0, Endian.Big);    // 00001111
      var leByte0 = finalData.ReadByte(0, Endian.Little); // 11110000

      var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big).StoreByte(0b01010101, 0, Endian.Little) // lower byte is now 0b01010101
         ;                                                                                                     // mutatedData is now 0b1011111101010101

      var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b01010101]

      var leBa = mutatedData.ToByteArray(Endian.Little); // leBa=[0b01010101, 0b10111111]

      var leBaToInt16Le = leBa.ToInt16(Endian.Little); // leBaToInt16Le = 0b1011111101010101

      var leBaToInt16Be = leBa.ToInt16(Endian.Big); // leBaToInt16Le  = 0b0101010110111111
   }

   private static void ReadMe_BitManipulation_UInt32_Example()
   {
      uint data = 0;

      // turn on all the bits
      data = data.SetBits(0, 32); // value is now 0b11111111111111111111111111111111

      // this is the equivalent as above
      data = data.SetBits();

      // Clear the middle 4 bits.
      data = data.ClearBits(4, 8); // value is now 0b11111111111111111111000000001111

      // Toggle all the bits.
      data = data.ToggleBits(); // value is now 0b00000000000000000000111111110000

      var finalData = data;

      // read the second byte
      var secondByte = (byte) data.ReadBits(8, 8); // secondByte is now 0b00001111

      // write 0b1011 into the upper nybble
      secondByte = secondByte.StoreBits(0b1011, 4, 4); // secondByte is now 0b10111111

      // chaining operations, the same steps and end results
      data.ClearBits();
      data = data.SetBits(0, 32)  // value is now 0b11111111111111111111111111111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 8) // value is now 01111111111111111b1111000000001111
                 .ToggleBits();   // value is now 0b00000000000000000000111111110000

      secondByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
        .StoreBits(0b1011, 4, 4);               // store the value in the upper 4 bits, now upperByte is now 0b10111111

      // finalData is 0b00000000000000000000111111110000

      var beByte0 = finalData.ReadByte(0, Endian.Big);    // 00001111
      var leByte0 = finalData.ReadByte(0, Endian.Little); // 11110000

      var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big).StoreByte(0b01010101, 0, Endian.Little) // lower byte is now 0b01010101
         ;

      // mutatedData is now 0b10111111000000000000111101010101

      var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b00000000, 0b00001111, 0b01010101]

      var leBa = mutatedData.ToByteArray(Endian.Little); // leBa=[0b01010101, 0b00001111, 0b00000000, 0b10111111]

      var leBaToUInt32Le = leBa.ToUInt32(Endian.Little); // leBaToUInt32Le = 0b10111111000000000000111101010101

      var leBaToUInt32Be = leBa.ToUInt32(Endian.Big); // leBaToUInt32Be  = 0b01010101000011110000000010111111
   }

   private static void ReadMe_BitManipulation_Int32_Example()
   {
      var data = 0;

      // turn on all the bits
      data = data.SetBits(0, 32); // value is now 0b11111111111111111111111111111111

      // this is the equivalent as above
      data = data.SetBits();

      // Clear the middle 4 bits.
      data = data.ClearBits(4, 8); // value is now 0b11111111111111111111000000001111

      // Toggle all the bits.
      data = data.ToggleBits(); // value is now 0b00000000000000000000111111110000

      var finalData = data;

      // read the second byte
      var secondByte = (byte) data.ReadBits(8, 8); // secondByte is now 0b00001111

      // write 0b1011 into the upper nybble
      secondByte = secondByte.StoreBits(0b1011, 4, 4); // secondByte is now 0b10111111

      // chaining operations, the same steps and end results
      data.ClearBits();
      data = data.SetBits(0, 32)  // value is now 0b11111111111111111111111111111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 8) // value is now 01111111111111111b1111000000001111
                 .ToggleBits();   // value is now 0b00000000000000000000111111110000

      secondByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
        .StoreBits(0b1011, 4, 4);               // store the value in the upper 4 bits, now upperByte is now 0b10111111

      // finalData is 0b00000000000000000000111111110000

      var beByte0 = finalData.ReadByte(0, Endian.Big);    // 00001111
      var leByte0 = finalData.ReadByte(0, Endian.Little); // 11110000

      var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big).StoreByte(0b01010101, 0, Endian.Little) // lower byte is now 0b01010101
         ;

      // mutatedData is now 0b10111111000000000000111101010101

      var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b00000000, 0b00001111, 0b01010101]

      var leBa = mutatedData.ToByteArray(Endian.Little); // leBa=[0b01010101, 0b00001111, 0b00000000, 0b10111111]

      var leBaToInt32Le = leBa.ToInt32(Endian.Little); // leBaToInt32Le = 0b10111111000000000000111101010101

      var leBaToInt32Be = leBa.ToInt32(Endian.Big); // leBaToInt32Be  = 0b01010101000011110000000010111111
   }

   private static void ReadMe_BitManipulation_UInt64_Example()
   {
      ulong data = 0;

      // turn on all the bits
      data = data.SetBits(0, 64); // value is now 0b1111111111111111111111111111111111111111111111111111111111111111

      // this is the equivalent as above
      data = data.SetBits();

      // Clear the middle 4 bits.
      data = data.ClearBits(4, 8); // value is now 0b1111111111111111111111111111111111111111111111111111000000001111

      // Toggle all the bits.
      data = data.ToggleBits(); // value is now 0b0000000000000000000000000000000000000000000000000000111111110000

      var finalData = data;

      // read the second byte
      var secondByte = (byte) data.ReadBits(8, 8); // secondByte is now 0b00001111

      // write 0b1011 into the upper nybble
      secondByte = secondByte.StoreBits(0b1011, 4, 4); // secondByte is now 0b10111111

      // chaining operations, the same steps and end results
      data.ClearBits();
      data = data.SetBits(0, 64)  // value is now 0b1111111111111111111111111111111111111111111111111111111111111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 8) // value is now 0b1111111111111111111111111111111111111111111111111111000000001111
                 .ToggleBits();   // value is now 0b0000000000000000000000000000000000000000000000000000111111110000

      secondByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
        .StoreBits(0b1011, 4, 4);               // store the value in the upper 4 bits, now upperByte is now 0b10111111

      // finalData is 0b0000000000000000000000000000000000000000000000000000111111110000
      var beByte0 = finalData.ReadByte(0, Endian.Big);    // 00001111
      var leByte0 = finalData.ReadByte(0, Endian.Little); // 11110000

      var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big).StoreByte(0b01010101, 0, Endian.Little);

      // mutatedData is now 0b1011111100000000000000000000000000000000000000000000111101010101

      var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b00000000, 0b00000000, 0b00000000, 0b00000000, 0b00000000, 0b00001111, 0b01010101]

      var leBa = mutatedData.ToByteArray(Endian.Little); // leBa=[0b01010101, 0b00001111, 0b00000000, 0b00000000, 0b00000000, 0b00000000, 0b00000000, 0b10111111]

      var leBaToUInt64Le = leBa.ToUInt64(Endian.Little); // leBaToUInt64Le = 0b1011111100000000000000000000000000000000000000000000111101010101

      var leBaToUInt64Be = leBa.ToUInt64(Endian.Big); // leBaToUInt64Be  = 0b0101010100001111000000000000000000000000000000000000000010111111
   }

   private static void ReadMe_BitManipulation_Int64_Example()
   {
      long data = 0;

      // turn on all the bits
      data = data.SetBits(0, 64); // value is now 0b1111111111111111111111111111111111111111111111111111111111111111

      // this is the equivalent as above
      data = data.SetBits();

      // Clear the middle 4 bits.
      data = data.ClearBits(4, 8); // value is now 0b1111111111111111111111111111111111111111111111111111000000001111

      // Toggle all the bits.
      data = data.ToggleBits(); // value is now 0b0000000000000000000000000000000000000000000000000000111111110000

      var finalData = data;

      // read the second byte
      var secondByte = (byte) data.ReadBits(8, 8); // secondByte is now 0b00001111

      // write 0b1011 into the upper nybble
      secondByte = secondByte.StoreBits(0b1011, 4, 4); // secondByte is now 0b10111111

      // chaining operations, the same steps and end results
      data.ClearBits();
      data = data.SetBits(0, 64)  // value is now 0b1111111111111111111111111111111111111111111111111111111111111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 8) // value is now 0b1111111111111111111111111111111111111111111111111111000000001111
                 .ToggleBits();   // value is now 0b0000000000000000000000000000000000000000000000000000111111110000

      secondByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
        .StoreBits(0b1011, 4, 4);               // store the value in the upper 4 bits, now upperByte is now 0b10111111

      // finalData is 0b0000000000000000000000000000000000000000000000000000111111110000
      var beByte0 = finalData.ReadByte(0, Endian.Big);    // 00001111
      var leByte0 = finalData.ReadByte(0, Endian.Little); // 11110000

      var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big).StoreByte(0b01010101, 0, Endian.Little);

      // mutatedData is now 0b1011111100000000000000000000000000000000000000000000111101010101

      var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b00000000, 0b00000000, 0b00000000, 0b00000000, 0b00000000, 0b00001111, 0b01010101]

      var leBa = mutatedData.ToByteArray(Endian.Little); // leBa=[0b01010101, 0b00001111, 0b00000000, 0b00000000, 0b00000000, 0b00000000, 0b00000000, 0b10111111]

      var leBaToInt64Le = leBa.ToInt64(Endian.Little); // leBaToInt64Le = 0b1011111100000000000000000000000000000000000000000000111101010101

      var leBaToInt64Be = leBa.ToInt64(Endian.Big); // leBaToInt64Be  = 0b0101010100001111000000000000000000000000000000000000000010111111
   }

   private static void BitIndexer_Example()
   {
      ushort ui16 = 0b1011110001010101;
      BitIndexer bi = ui16;
      Console.WriteLine(bi.ToString()); // outputs: 0b1011110001010101

      if (bi[0])
      {
         Console.WriteLine("Index 0 is set/true!"); // this will write to the output.
      }

      if (bi[1])
      {
         Console.WriteLine("Index 1 is set/true!"); // this will not write to the output.
      }

      if (bi[10])
      {
         Console.WriteLine("Index 10 is set/true!");
      }

      bi[1] = true; // bi is now 0b1011110001010111

      if (bi[1])
      {
         Console.WriteLine("Index 1 is set/true!"); // this will write to the output.
      }

      Console.WriteLine(bi.ToString()); // outputs: 0b1011110001010111

      var flags = bi[..];
      Array.Reverse(flags);
      var ui16Reversed = flags.ToUInt16(); // ui16Reversed = 0b1110101000111101;
      BitIndexer biReversed = ui16Reversed;

      Console.WriteLine(biReversed.ToString()); // outputs: 0b1110101000111101
   }

   private static void ByteIndexer_Example()
   {
      // ByteIndexers on 64 bit values
      BigEndianByteIndexer bebi = 0xDECAFFC0FFEEC0DE;
      LittleEndianByteIndexer lebi = 0xDECAFFC0FFEEC0DE;

      Console.WriteLine(bebi.ToString()); // outputs: "DE CA FF C0 FF EE C0 DE"
      Console.WriteLine(lebi.ToString()); // outputs: "DE C0 EE FF C0 FF CA DE"

      var bebib1 = bebi[1]; // bebib1 = 0xCA 
      var lebib1 = lebi[1]; // lebib1 = 0xC0

      bebi[0] = 0x0A;
      lebi[0] = 0x0B;

      Console.WriteLine(bebi.ToString()); // outputs: "0A CA FF C0 FF EE C0 DE"
      Console.WriteLine(lebi.ToString()); // outputs: "0B C0 EE FF C0 FF CA DE"

      // ByteIndexers on 32 bit values
      bebi = 0x600DC0DE;
      lebi = 0x600DC0DE;

      Console.WriteLine(bebi.ToString()); // outputs: "60 0D C0 DE"
      Console.WriteLine(lebi.ToString()); // outputs: "DE C0 0D 60"

      bebib1 = bebi[1]; // bebib1 = 0x0D
      lebib1 = lebi[1]; // lebib1 = 0xC0

      bebi[0] = 0x0A;
      lebi[0] = 0x0B;

      Console.WriteLine(bebi.ToString()); // outputs: "0A 0D C0 DE"
      Console.WriteLine(lebi.ToString()); // outputs: "0B C0 0D 60"
   }
}
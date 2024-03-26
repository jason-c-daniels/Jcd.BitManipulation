```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-HIGWSP : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-DFUPFJ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                 | Runtime              |       Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  1.3464 ns | 0.0709 ns | 0.0628 ns |  0.39 |    0.02 |
| BitConverter_ToFloat   | .NET 8.0             |  1.4539 ns | 0.0283 ns | 0.0148 ns |  0.42 |    0.00 |
| BitConverter_ToUInt64  | .NET 8.0             |  1.2462 ns | 0.0262 ns | 0.0156 ns |  0.36 |    0.00 |
| BitConverter_ToInt64   | .NET 8.0             |  1.7763 ns | 0.0931 ns | 0.0871 ns |  0.50 |    0.03 |
| BitConverter_ToUInt32  | .NET 8.0             |  1.2478 ns | 0.0500 ns | 0.0362 ns |  0.36 |    0.01 |
| BitConverter_ToInt32   | .NET 8.0             |  1.6623 ns | 0.0419 ns | 0.0250 ns |  0.48 |    0.01 |
| BitConverter_ToUInt16  | .NET 8.0             |  3.2787 ns | 0.0973 ns | 0.0704 ns |  0.94 |    0.02 |
| BitConverter_ToInt16   | .NET 8.0             |  3.4851 ns | 0.0458 ns | 0.0273 ns |  1.00 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  1.4232 ns | 0.0895 ns | 0.0793 ns |  0.42 |    0.02 |
| ExtensionMethod_Float  | .NET 8.0             |  0.5871 ns | 0.0266 ns | 0.0158 ns |  0.17 |    0.00 |
| ExtensionMethod_UInt64 | .NET 8.0             |  1.2402 ns | 0.0558 ns | 0.0495 ns |  0.35 |    0.02 |
| ExtensionMethod_Int64  | .NET 8.0             |  1.2941 ns | 0.0517 ns | 0.0458 ns |  0.37 |    0.02 |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.3069 ns | 0.0206 ns | 0.0136 ns |  0.09 |    0.00 |
| ExtensionMethod_Int32  | .NET 8.0             |  0.3011 ns | 0.0127 ns | 0.0075 ns |  0.09 |    0.00 |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.1634 ns | 0.0399 ns | 0.0373 ns |  0.05 |    0.01 |
| ExtensionMethod_Int16  | .NET 8.0             |  0.1366 ns | 0.0157 ns | 0.0104 ns |  0.04 |    0.00 |
| ByteIndexer_Double     | .NET 8.0             |  1.2970 ns | 0.0463 ns | 0.0306 ns |  0.37 |    0.01 |
| ByteIndexer_Float      | .NET 8.0             |  0.3591 ns | 0.0328 ns | 0.0217 ns |  0.10 |    0.01 |
| ByteIndexer_UInt64     | .NET 8.0             |  1.1845 ns | 0.0326 ns | 0.0194 ns |  0.34 |    0.00 |
| ByteIndexer_Int64      | .NET 8.0             |  1.3023 ns | 0.1075 ns | 0.1005 ns |  0.37 |    0.03 |
| ByteIndexer_UInt32     | .NET 8.0             |  0.2817 ns | 0.0192 ns | 0.0127 ns |  0.08 |    0.00 |
| ByteIndexer_Int32      | .NET 8.0             |  0.2934 ns | 0.0170 ns | 0.0101 ns |  0.08 |    0.00 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.1283 ns | 0.0381 ns | 0.0356 ns |  0.04 |    0.01 |
| ByteIndexer_Int16      | .NET 8.0             |  0.1188 ns | 0.0149 ns | 0.0099 ns |  0.03 |    0.00 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 | 26.0769 ns | 0.3779 ns | 0.2499 ns |  7.47 |    0.10 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 | 24.5047 ns | 0.5255 ns | 0.4915 ns |  7.05 |    0.18 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 | 26.2159 ns | 0.3287 ns | 0.1719 ns |  7.53 |    0.04 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 | 25.2126 ns | 0.4420 ns | 0.2630 ns |  7.23 |    0.10 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 | 24.1579 ns | 0.1274 ns | 0.0758 ns |  6.93 |    0.05 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 | 23.3351 ns | 0.3653 ns | 0.2417 ns |  6.70 |    0.11 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 | 23.2004 ns | 0.4747 ns | 0.4441 ns |  6.64 |    0.17 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 | 21.5197 ns | 0.4126 ns | 0.3221 ns |  6.18 |    0.10 |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  6.8513 ns | 0.0867 ns | 0.0516 ns |  1.97 |    0.02 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 12.4430 ns | 0.2573 ns | 0.1861 ns |  3.58 |    0.06 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  6.4366 ns | 0.1411 ns | 0.0933 ns |  1.84 |    0.03 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  6.4714 ns | 0.1177 ns | 0.0779 ns |  1.86 |    0.02 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  2.9286 ns | 0.0677 ns | 0.0354 ns |  0.84 |    0.01 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  2.9336 ns | 0.0361 ns | 0.0215 ns |  0.84 |    0.01 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  1.4152 ns | 0.0445 ns | 0.0294 ns |  0.41 |    0.01 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  1.4444 ns | 0.0511 ns | 0.0338 ns |  0.42 |    0.01 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  6.8402 ns | 0.1312 ns | 0.0868 ns |  1.96 |    0.03 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 13.5955 ns | 0.9632 ns | 0.9010 ns |  3.79 |    0.22 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  6.6920 ns | 0.0967 ns | 0.0640 ns |  1.92 |    0.03 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  6.6695 ns | 0.1059 ns | 0.0700 ns |  1.91 |    0.01 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  2.9584 ns | 0.0755 ns | 0.0449 ns |  0.85 |    0.01 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  2.9562 ns | 0.0619 ns | 0.0409 ns |  0.85 |    0.01 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.4643 ns | 0.0520 ns | 0.0486 ns |  0.42 |    0.01 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.4380 ns | 0.0492 ns | 0.0410 ns |  0.41 |    0.01 |

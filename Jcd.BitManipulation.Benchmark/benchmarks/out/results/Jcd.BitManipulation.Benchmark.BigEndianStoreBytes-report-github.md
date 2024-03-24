```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-YATUCA : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-DNRXWD : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  1.473 ns | 0.0631 ns | 0.0560 ns |  0.43 |    0.02 |
| BitConverter_ToFloat   | .NET 8.0             |  1.484 ns | 0.0551 ns | 0.0515 ns |  0.43 |    0.02 |
| BitConverter_ToUInt64  | .NET 8.0             |  1.259 ns | 0.0497 ns | 0.0415 ns |  0.37 |    0.01 |
| BitConverter_ToInt64   | .NET 8.0             |  1.673 ns | 0.0342 ns | 0.0226 ns |  0.49 |    0.01 |
| BitConverter_ToUInt32  | .NET 8.0             |  1.665 ns | 0.0347 ns | 0.0229 ns |  0.48 |    0.01 |
| BitConverter_ToInt32   | .NET 8.0             |  1.510 ns | 0.0553 ns | 0.0462 ns |  0.44 |    0.01 |
| BitConverter_ToUInt16  | .NET 8.0             |  3.236 ns | 0.0596 ns | 0.0394 ns |  0.94 |    0.02 |
| BitConverter_ToInt16   | .NET 8.0             |  3.448 ns | 0.0733 ns | 0.0485 ns |  1.00 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  5.130 ns | 0.0542 ns | 0.0284 ns |  1.49 |    0.02 |
| ExtensionMethod_Float  | .NET 8.0             |  6.777 ns | 0.3025 ns | 0.2681 ns |  1.98 |    0.08 |
| ExtensionMethod_UInt64 | .NET 8.0             |  4.926 ns | 0.1265 ns | 0.0837 ns |  1.43 |    0.03 |
| ExtensionMethod_Int64  | .NET 8.0             |  5.058 ns | 0.2626 ns | 0.2193 ns |  1.47 |    0.08 |
| ExtensionMethod_UInt32 | .NET 8.0             |  2.498 ns | 0.0876 ns | 0.0777 ns |  0.72 |    0.02 |
| ExtensionMethod_Int32  | .NET 8.0             |  2.408 ns | 0.1214 ns | 0.1076 ns |  0.70 |    0.04 |
| ExtensionMethod_UInt16 | .NET 8.0             |  1.149 ns | 0.1400 ns | 0.1241 ns |  0.34 |    0.04 |
| ExtensionMethod_Int16  | .NET 8.0             |  1.066 ns | 0.0778 ns | 0.0728 ns |  0.31 |    0.02 |
| ByteIndexer_Double     | .NET 8.0             |  5.076 ns | 0.2148 ns | 0.2009 ns |  1.46 |    0.06 |
| ByteIndexer_Float      | .NET 8.0             |  6.296 ns | 0.1585 ns | 0.1146 ns |  1.83 |    0.02 |
| ByteIndexer_UInt64     | .NET 8.0             |  4.580 ns | 0.1520 ns | 0.1347 ns |  1.34 |    0.04 |
| ByteIndexer_Int64      | .NET 8.0             |  4.743 ns | 0.1529 ns | 0.1430 ns |  1.37 |    0.04 |
| ByteIndexer_UInt32     | .NET 8.0             |  2.208 ns | 0.0669 ns | 0.0398 ns |  0.64 |    0.01 |
| ByteIndexer_Int32      | .NET 8.0             |  2.472 ns | 0.0686 ns | 0.0496 ns |  0.72 |    0.02 |
| ByteIndexer_UInt16     | .NET 8.0             |  1.096 ns | 0.0290 ns | 0.0192 ns |  0.32 |    0.01 |
| ByteIndexer_Int16      | .NET 8.0             |  1.129 ns | 0.0243 ns | 0.0144 ns |  0.33 |    0.01 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 | 25.491 ns | 0.3119 ns | 0.1856 ns |  7.38 |    0.13 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 | 23.287 ns | 0.4840 ns | 0.3500 ns |  6.75 |    0.09 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 | 26.709 ns | 1.2900 ns | 1.2066 ns |  7.89 |    0.39 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 | 24.770 ns | 0.5178 ns | 0.4043 ns |  7.21 |    0.16 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 | 23.459 ns | 0.4002 ns | 0.2382 ns |  6.79 |    0.11 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 | 23.140 ns | 0.5694 ns | 0.4754 ns |  6.75 |    0.16 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 | 22.683 ns | 0.4281 ns | 0.2832 ns |  6.58 |    0.12 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 | 21.071 ns | 0.4151 ns | 0.3241 ns |  6.11 |    0.08 |
| ExtensionMethod_Double | .NET Framework 4.6.2 | 16.594 ns | 0.5884 ns | 0.5504 ns |  4.84 |    0.18 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 17.141 ns | 0.3520 ns | 0.2328 ns |  4.97 |    0.07 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 | 17.416 ns | 0.8817 ns | 0.8248 ns |  4.94 |    0.16 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 | 17.420 ns | 0.5784 ns | 0.5128 ns |  5.06 |    0.15 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  8.695 ns | 0.3725 ns | 0.3302 ns |  2.53 |    0.11 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  8.202 ns | 0.1642 ns | 0.1187 ns |  2.39 |    0.05 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  4.634 ns | 0.1064 ns | 0.0557 ns |  1.35 |    0.01 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  5.021 ns | 0.1871 ns | 0.1750 ns |  1.47 |    0.05 |
| ByteIndexer_Double     | .NET Framework 4.6.2 | 14.719 ns | 1.0355 ns | 0.9179 ns |  4.32 |    0.30 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 18.743 ns | 1.4129 ns | 1.2525 ns |  5.56 |    0.33 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 | 14.280 ns | 0.2984 ns | 0.2791 ns |  4.15 |    0.12 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 | 14.216 ns | 0.2883 ns | 0.2084 ns |  4.13 |    0.08 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  7.990 ns | 0.6519 ns | 0.6098 ns |  2.28 |    0.18 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  7.173 ns | 0.2061 ns | 0.1827 ns |  2.07 |    0.05 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  4.143 ns | 0.0681 ns | 0.0356 ns |  1.20 |    0.02 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  4.042 ns | 0.1662 ns | 0.1473 ns |  1.17 |    0.04 |

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-RTWBQH : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-MJEWHE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |       Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  1.4867 ns | 0.0533 ns | 0.0472 ns |  0.39 |    0.02 |
| BitConverter_ToFloat   | .NET 8.0             |  1.6791 ns | 0.1616 ns | 0.1511 ns |  0.44 |    0.05 |
| BitConverter_ToUInt64  | .NET 8.0             |  2.0463 ns | 0.3771 ns | 0.3528 ns |  0.54 |    0.12 |
| BitConverter_ToInt64   | .NET 8.0             |  1.7827 ns | 0.1284 ns | 0.1072 ns |  0.47 |    0.04 |
| BitConverter_ToUInt32  | .NET 8.0             |  1.5566 ns | 0.2125 ns | 0.1884 ns |  0.41 |    0.05 |
| BitConverter_ToInt32   | .NET 8.0             |  2.0389 ns | 0.2165 ns | 0.2025 ns |  0.54 |    0.06 |
| BitConverter_ToUInt16  | .NET 8.0             |  3.6560 ns | 0.3773 ns | 0.3529 ns |  0.98 |    0.11 |
| BitConverter_ToInt16   | .NET 8.0             |  3.7870 ns | 0.2743 ns | 0.2431 ns |  1.00 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  4.5764 ns | 0.2287 ns | 0.2139 ns |  1.20 |    0.08 |
| ExtensionMethod_Float  | .NET 8.0             |  2.2598 ns | 0.1371 ns | 0.1216 ns |  0.60 |    0.05 |
| ExtensionMethod_UInt64 | .NET 8.0             |  4.2259 ns | 0.3647 ns | 0.3412 ns |  1.13 |    0.12 |
| ExtensionMethod_Int64  | .NET 8.0             |  4.0818 ns | 0.2305 ns | 0.2044 ns |  1.08 |    0.08 |
| ExtensionMethod_UInt32 | .NET 8.0             |  1.7943 ns | 0.1242 ns | 0.1162 ns |  0.48 |    0.04 |
| ExtensionMethod_Int32  | .NET 8.0             |  1.6419 ns | 0.0744 ns | 0.0659 ns |  0.44 |    0.04 |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.8298 ns | 0.0782 ns | 0.0732 ns |  0.22 |    0.02 |
| ExtensionMethod_Int16  | .NET 8.0             |  0.8537 ns | 0.0745 ns | 0.0622 ns |  0.23 |    0.02 |
| ByteIndexer_Double     | .NET 8.0             |  4.1238 ns | 0.2214 ns | 0.1848 ns |  1.09 |    0.08 |
| ByteIndexer_Float      | .NET 8.0             |  2.2878 ns | 0.1170 ns | 0.1037 ns |  0.61 |    0.04 |
| ByteIndexer_UInt64     | .NET 8.0             |  3.7587 ns | 0.0994 ns | 0.0776 ns |  0.99 |    0.05 |
| ByteIndexer_Int64      | .NET 8.0             |  4.0939 ns | 0.1686 ns | 0.1577 ns |  1.09 |    0.08 |
| ByteIndexer_UInt32     | .NET 8.0             |  1.9935 ns | 0.1313 ns | 0.1164 ns |  0.53 |    0.05 |
| ByteIndexer_Int32      | .NET 8.0             |  2.4200 ns | 0.1763 ns | 0.1649 ns |  0.65 |    0.06 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.8006 ns | 0.0813 ns | 0.0761 ns |  0.21 |    0.03 |
| ByteIndexer_Int16      | .NET 8.0             |  0.7570 ns | 0.1106 ns | 0.1035 ns |  0.20 |    0.03 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 | 27.6566 ns | 1.0573 ns | 0.9373 ns |  7.34 |    0.62 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 | 25.8631 ns | 1.3873 ns | 1.2976 ns |  6.81 |    0.53 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 | 30.2616 ns | 3.1008 ns | 2.9005 ns |  8.07 |    0.97 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 | 28.3247 ns | 2.0875 ns | 1.9526 ns |  7.52 |    0.59 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 | 29.1005 ns | 2.2476 ns | 2.1025 ns |  7.69 |    0.78 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 | 26.5525 ns | 2.6847 ns | 2.5112 ns |  7.07 |    0.56 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 | 25.3761 ns | 1.8877 ns | 1.7657 ns |  6.74 |    0.51 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 | 23.0160 ns | 1.3700 ns | 1.2815 ns |  6.12 |    0.62 |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  7.5373 ns | 0.4537 ns | 0.4244 ns |  1.99 |    0.15 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 15.2582 ns | 1.0362 ns | 0.9692 ns |  4.03 |    0.24 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  6.9323 ns | 0.2503 ns | 0.2342 ns |  1.83 |    0.12 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  6.7315 ns | 0.1527 ns | 0.1192 ns |  1.77 |    0.12 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  3.2876 ns | 0.2428 ns | 0.2271 ns |  0.88 |    0.08 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  3.2750 ns | 0.3225 ns | 0.3016 ns |  0.87 |    0.08 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  1.6294 ns | 0.1464 ns | 0.1369 ns |  0.43 |    0.05 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  1.6211 ns | 0.1885 ns | 0.1764 ns |  0.43 |    0.06 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  7.1478 ns | 0.1662 ns | 0.1298 ns |  1.88 |    0.12 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 14.6847 ns | 0.7647 ns | 0.7153 ns |  3.86 |    0.22 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  7.6999 ns | 0.7672 ns | 0.7177 ns |  2.05 |    0.27 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  7.7849 ns | 0.4926 ns | 0.4608 ns |  2.06 |    0.17 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  3.6033 ns | 0.3153 ns | 0.2949 ns |  0.96 |    0.12 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  3.2406 ns | 0.2487 ns | 0.2327 ns |  0.86 |    0.07 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.4932 ns | 0.2501 ns | 0.2339 ns |  0.40 |    0.05 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.6411 ns | 0.1165 ns | 0.1089 ns |  0.43 |    0.03 |

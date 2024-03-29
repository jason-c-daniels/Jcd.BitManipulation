```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-JSKQEV : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-FYSSQN : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median |   Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|--------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0394 ns | 0.0244 ns | 0.0228 ns |  0.0408 ns |   0.622 |    0.44 |
| BitConverter_ToFloat   | .NET 8.0             |  0.0014 ns | 0.0051 ns | 0.0027 ns |  0.0000 ns |   0.022 |    0.05 |
| BitConverter_ToUInt64  | .NET 8.0             |  0.0058 ns | 0.0136 ns | 0.0099 ns |  0.0000 ns |   0.095 |    0.16 |
| BitConverter_ToInt64   | .NET 8.0             |  0.1488 ns | 0.0349 ns | 0.0309 ns |  0.1421 ns |   2.477 |    0.64 |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0686 ns | 0.0628 ns | 0.0557 ns |  0.0539 ns |   1.346 |    1.05 |
| BitConverter_ToInt32   | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |   0.000 |    0.00 |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0009 ns | 0.0041 ns | 0.0034 ns |  0.0000 ns |   0.020 |    0.06 |
| BitConverter_ToInt16   | .NET 8.0             |  0.0626 ns | 0.0132 ns | 0.0088 ns |  0.0638 ns |   1.000 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  1.3801 ns | 0.0305 ns | 0.0160 ns |  1.3766 ns |  21.976 |    2.43 |
| ExtensionMethod_Float  | .NET 8.0             |  0.4696 ns | 0.0845 ns | 0.0790 ns |  0.4619 ns |   7.195 |    1.35 |
| ExtensionMethod_UInt64 | .NET 8.0             |  1.3153 ns | 0.0933 ns | 0.0873 ns |  1.2898 ns |  21.345 |    4.19 |
| ExtensionMethod_Int64  | .NET 8.0             |  1.3091 ns | 0.1140 ns | 0.1067 ns |  1.2815 ns |  21.146 |    3.43 |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.1243 ns | 0.0329 ns | 0.0292 ns |  0.1176 ns |   2.150 |    0.53 |
| ExtensionMethod_Int32  | .NET 8.0             |  0.1343 ns | 0.0323 ns | 0.0302 ns |  0.1261 ns |   2.235 |    0.77 |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0001 ns | 0.0003 ns | 0.0002 ns |  0.0000 ns |   0.001 |    0.00 |
| ExtensionMethod_Int16  | .NET 8.0             |  0.1295 ns | 0.0226 ns | 0.0118 ns |  0.1281 ns |   2.058 |    0.26 |
| ByteIndexer_Double     | .NET 8.0             |  1.4543 ns | 0.0614 ns | 0.0544 ns |  1.4344 ns |  23.918 |    4.13 |
| ByteIndexer_Float      | .NET 8.0             |  0.1427 ns | 0.0268 ns | 0.0209 ns |  0.1374 ns |   2.322 |    0.32 |
| ByteIndexer_UInt64     | .NET 8.0             |  1.3319 ns | 0.0558 ns | 0.0522 ns |  1.3156 ns |  21.715 |    3.98 |
| ByteIndexer_Int64      | .NET 8.0             |  1.3463 ns | 0.0492 ns | 0.0411 ns |  1.3468 ns |  21.943 |    3.22 |
| ByteIndexer_UInt32     | .NET 8.0             |  0.3516 ns | 0.0314 ns | 0.0187 ns |  0.3437 ns |   5.807 |    0.85 |
| ByteIndexer_Int32      | .NET 8.0             |  0.3443 ns | 0.0172 ns | 0.0102 ns |  0.3403 ns |   5.698 |    0.92 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.1386 ns | 0.0343 ns | 0.0321 ns |  0.1305 ns |   2.062 |    0.40 |
| ByteIndexer_Int16      | .NET 8.0             |  0.1325 ns | 0.0175 ns | 0.0116 ns |  0.1322 ns |   2.169 |    0.44 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  2.7447 ns | 0.0868 ns | 0.0812 ns |  2.7615 ns |  44.655 |    7.89 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  1.9248 ns | 0.0459 ns | 0.0240 ns |  1.9310 ns |  30.664 |    3.50 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  2.8136 ns | 0.0892 ns | 0.0835 ns |  2.8234 ns |  45.653 |    6.90 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  1.2678 ns | 0.0353 ns | 0.0233 ns |  1.2695 ns |  20.655 |    3.16 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  1.5368 ns | 0.0555 ns | 0.0519 ns |  1.5319 ns |  25.212 |    3.67 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  0.6100 ns | 0.0115 ns | 0.0068 ns |  0.6092 ns |  10.095 |    1.59 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  2.6837 ns | 0.0654 ns | 0.0432 ns |  2.6975 ns |  43.705 |    6.46 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  0.8371 ns | 0.0178 ns | 0.0093 ns |  0.8342 ns |  13.343 |    1.60 |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  2.7400 ns | 0.0455 ns | 0.0271 ns |  2.7318 ns |  45.319 |    6.92 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 11.9277 ns | 0.2582 ns | 0.2156 ns | 11.8520 ns | 195.045 |   28.87 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  3.4664 ns | 0.0824 ns | 0.0545 ns |  3.4797 ns |  56.463 |    8.40 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  3.5441 ns | 0.0682 ns | 0.0451 ns |  3.5585 ns |  57.742 |    8.68 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  2.2577 ns | 0.0658 ns | 0.0476 ns |  2.2718 ns |  36.695 |    5.14 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  2.2258 ns | 0.0809 ns | 0.0717 ns |  2.2136 ns |  36.399 |    6.13 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  1.6352 ns | 0.0524 ns | 0.0464 ns |  1.6290 ns |  26.590 |    4.50 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  1.4081 ns | 0.0729 ns | 0.0646 ns |  1.4021 ns |  22.999 |    3.44 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  2.8975 ns | 0.0843 ns | 0.0747 ns |  2.8746 ns |  47.115 |    7.64 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 11.4872 ns | 0.2159 ns | 0.1428 ns | 11.4950 ns | 187.240 |   28.74 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  3.5940 ns | 0.0925 ns | 0.0865 ns |  3.5730 ns |  58.543 |    8.51 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  3.6299 ns | 0.0756 ns | 0.0631 ns |  3.6280 ns |  59.063 |    9.03 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.6390 ns | 0.0527 ns | 0.0440 ns |  1.6233 ns |  26.717 |    4.07 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.5929 ns | 0.0516 ns | 0.0403 ns |  1.5867 ns |  25.967 |    4.28 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.1992 ns | 0.0289 ns | 0.0172 ns |  1.2005 ns |  19.824 |    2.94 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.1664 ns | 0.0406 ns | 0.0317 ns |  1.1623 ns |  19.002 |    3.16 |

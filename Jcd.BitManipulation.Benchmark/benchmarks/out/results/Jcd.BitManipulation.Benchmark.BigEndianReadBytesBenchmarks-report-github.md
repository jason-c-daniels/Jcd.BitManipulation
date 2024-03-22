```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-TUAXFB : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-IVQORW : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=11  MinIterationCount=10  
WarmupCount=10  

```

| Method                                     | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double               | .NET 8.0             |  4.654 ns | 0.4759 ns | 0.3148 ns |  1.12 |    0.07 |
| BitConverter_GetBytes_Float                | .NET 8.0             |  4.248 ns | 0.2916 ns | 0.2108 ns |  1.02 |    0.05 |
| BitConverter_GetBytes_UInt64               | .NET 8.0             |  4.390 ns | 0.0859 ns | 0.0568 ns |  1.05 |    0.01 |
| BitConverter_GetBytes_Int64                | .NET 8.0             |  4.466 ns | 0.1055 ns | 0.0698 ns |  1.07 |    0.02 |
| BitConverter_GetBytes_UInt32               | .NET 8.0             |  4.213 ns | 0.1260 ns | 0.0833 ns |  1.01 |    0.01 |
| BitConverter_GetBytes_Int32                | .NET 8.0             |  4.211 ns | 0.1127 ns | 0.0671 ns |  1.01 |    0.02 |
| BitConverter_GetBytes_UInt16               | .NET 8.0             |  4.375 ns | 0.2281 ns | 0.1649 ns |  1.05 |    0.04 |
| BitConverter_GetBytes_Int16                | .NET 8.0             |  4.170 ns | 0.0959 ns | 0.0634 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Double_New_Inst | .NET 8.0             |  5.617 ns | 0.0701 ns | 0.0367 ns |  1.35 |    0.02 |
| BigEndianByteIndexer_Slice_Float_New_Inst  | .NET 8.0             |  6.889 ns | 0.1659 ns | 0.1200 ns |  1.65 |    0.03 |
| BigEndianByteIndexer_Slice_UInt64_New_Inst | .NET 8.0             |  5.771 ns | 0.0665 ns | 0.0396 ns |  1.38 |    0.02 |
| BigEndianByteIndexer_Slice_Int64_New_Inst  | .NET 8.0             |  5.872 ns | 0.2283 ns | 0.1510 ns |  1.41 |    0.04 |
| BigEndianByteIndexer_Slice_UInt32_New_Inst | .NET 8.0             |  4.390 ns | 0.1970 ns | 0.1424 ns |  1.06 |    0.04 |
| BigEndianByteIndexer_Slice_Int32_New_Inst  | .NET 8.0             |  4.504 ns | 0.2445 ns | 0.1768 ns |  1.08 |    0.05 |
| BigEndianByteIndexer_Slice_UInt16_New_Inst | .NET 8.0             |  3.291 ns | 0.0996 ns | 0.0659 ns |  0.79 |    0.02 |
| BigEndianByteIndexer_Slice_Int16_New_Inst  | .NET 8.0             |  3.442 ns | 0.0780 ns | 0.0516 ns |  0.83 |    0.01 |
| ExtensionMethod_ReadBytes_Double           | .NET 8.0             |  5.649 ns | 0.0727 ns | 0.0481 ns |  1.35 |    0.02 |
| ExtensionMethod_ReadBytes_Float            | .NET 8.0             |  6.747 ns | 0.0973 ns | 0.0644 ns |  1.62 |    0.03 |
| ExtensionMethod_ReadBytes_UInt64           | .NET 8.0             |  5.704 ns | 0.0899 ns | 0.0595 ns |  1.37 |    0.03 |
| ExtensionMethod_ReadBytes_Int64            | .NET 8.0             |  4.411 ns | 0.1460 ns | 0.0966 ns |  1.06 |    0.02 |
| ExtensionMethod_ReadBytes_UInt32           | .NET 8.0             |  4.261 ns | 0.0780 ns | 0.0516 ns |  1.02 |    0.02 |
| ExtensionMethod_ReadBytes_Int32            | .NET 8.0             |  3.717 ns | 0.0385 ns | 0.0229 ns |  0.89 |    0.02 |
| ExtensionMethod_ReadBytes_UInt16           | .NET 8.0             |  3.689 ns | 0.0765 ns | 0.0506 ns |  0.88 |    0.01 |
| ExtensionMethod_ReadBytes_Int16            | .NET 8.0             |  3.011 ns | 0.0810 ns | 0.0536 ns |  0.72 |    0.02 |
| BigEndianByteIndexerFloat_Slice            | .NET 8.0             |  4.859 ns | 0.3200 ns | 0.2117 ns |  1.17 |    0.06 |
| BigEndianByteIndexerDouble_Slice           | .NET 8.0             |  6.383 ns | 0.1379 ns | 0.0721 ns |  1.53 |    0.03 |
| BigEndianByteIndexerUInt64_Slice           | .NET 8.0             |  5.891 ns | 0.1359 ns | 0.0899 ns |  1.41 |    0.04 |
| BigEndianByteIndexerInt64_Slice            | .NET 8.0             |  6.246 ns | 0.1624 ns | 0.1074 ns |  1.50 |    0.02 |
| BigEndianByteIndexerUInt32_Slice           | .NET 8.0             |  5.661 ns | 1.3504 ns | 0.8932 ns |  1.36 |    0.22 |
| BigEndianByteIndexerInt32_Slice            | .NET 8.0             |  4.528 ns | 0.1205 ns | 0.0797 ns |  1.09 |    0.02 |
| BigEndianByteIndexerUInt16_Slice           | .NET 8.0             |  3.607 ns | 0.0865 ns | 0.0514 ns |  0.86 |    0.02 |
| BigEndianByteIndexerInt16_Slice            | .NET 8.0             |  3.736 ns | 0.2220 ns | 0.1469 ns |  0.90 |    0.03 |
| BigEndianByteIndexerDouble_Slice_New_Inst  | .NET 8.0             |  5.515 ns | 0.1289 ns | 0.0853 ns |  1.32 |    0.03 |
| BigEndianByteIndexerFloat_Slice_New_Inst   | .NET 8.0             |  7.139 ns | 0.1261 ns | 0.0751 ns |  1.71 |    0.03 |
| BigEndianByteIndexerUInt64_Slice_New_Inst  | .NET 8.0             |  6.069 ns | 0.4917 ns | 0.3555 ns |  1.44 |    0.08 |
| BigEndianByteIndexerInt64_Slice_New_Inst   | .NET 8.0             |  5.393 ns | 0.1191 ns | 0.0709 ns |  1.29 |    0.03 |
| BigEndianByteIndexerUInt32_Slice_New_Inst  | .NET 8.0             |  5.329 ns | 0.0818 ns | 0.0541 ns |  1.28 |    0.03 |
| BigEndianByteIndexerInt32_Slice_New_Inst   | .NET 8.0             |  5.198 ns | 0.2381 ns | 0.1575 ns |  1.25 |    0.05 |
| BigEndianByteIndexerUInt16_Slice_New_Inst  | .NET 8.0             |  3.771 ns | 0.1553 ns | 0.1123 ns |  0.91 |    0.03 |
| BigEndianByteIndexerInt16_Slice_New_Inst   | .NET 8.0             |  3.502 ns | 0.1404 ns | 0.1015 ns |  0.84 |    0.03 |
| BitConverter_GetBytes_Double               | .NET Framework 4.6.2 | 26.153 ns | 0.7772 ns | 0.5619 ns |  6.26 |    0.16 |
| BitConverter_GetBytes_Float                | .NET Framework 4.6.2 | 24.900 ns | 0.6629 ns | 0.4793 ns |  5.97 |    0.15 |
| BitConverter_GetBytes_UInt64               | .NET Framework 4.6.2 | 25.602 ns | 0.4458 ns | 0.2949 ns |  6.14 |    0.11 |
| BitConverter_GetBytes_Int64                | .NET Framework 4.6.2 | 25.787 ns | 0.3998 ns | 0.2379 ns |  6.18 |    0.09 |
| BitConverter_GetBytes_UInt32               | .NET Framework 4.6.2 | 24.533 ns | 0.3862 ns | 0.2020 ns |  5.89 |    0.11 |
| BitConverter_GetBytes_Int32                | .NET Framework 4.6.2 | 24.382 ns | 0.4119 ns | 0.2451 ns |  5.85 |    0.14 |
| BitConverter_GetBytes_UInt16               | .NET Framework 4.6.2 | 23.003 ns | 0.2441 ns | 0.1453 ns |  5.51 |    0.07 |
| BitConverter_GetBytes_Int16                | .NET Framework 4.6.2 | 23.549 ns | 0.8100 ns | 0.5857 ns |  5.67 |    0.15 |
| BigEndianByteIndexer_Slice_Double_New_Inst | .NET Framework 4.6.2 |  6.401 ns | 0.1664 ns | 0.1203 ns |  1.53 |    0.04 |
| BigEndianByteIndexer_Slice_Float_New_Inst  | .NET Framework 4.6.2 | 10.087 ns | 0.1735 ns | 0.1033 ns |  2.42 |    0.06 |
| BigEndianByteIndexer_Slice_UInt64_New_Inst | .NET Framework 4.6.2 |  6.532 ns | 0.1486 ns | 0.0983 ns |  1.57 |    0.03 |
| BigEndianByteIndexer_Slice_Int64_New_Inst  | .NET Framework 4.6.2 |  6.409 ns | 0.0516 ns | 0.0307 ns |  1.54 |    0.02 |
| BigEndianByteIndexer_Slice_UInt32_New_Inst | .NET Framework 4.6.2 |  3.747 ns | 0.0375 ns | 0.0223 ns |  0.90 |    0.01 |
| BigEndianByteIndexer_Slice_Int32_New_Inst  | .NET Framework 4.6.2 |  4.279 ns | 0.2060 ns | 0.1363 ns |  1.03 |    0.03 |
| BigEndianByteIndexer_Slice_UInt16_New_Inst | .NET Framework 4.6.2 |  3.047 ns | 0.0976 ns | 0.0581 ns |  0.73 |    0.02 |
| BigEndianByteIndexer_Slice_Int16_New_Inst  | .NET Framework 4.6.2 |  3.087 ns | 0.1099 ns | 0.0794 ns |  0.74 |    0.03 |
| ExtensionMethod_ReadBytes_Double           | .NET Framework 4.6.2 |  6.445 ns | 0.1780 ns | 0.1177 ns |  1.55 |    0.04 |
| ExtensionMethod_ReadBytes_Float            | .NET Framework 4.6.2 |  8.828 ns | 0.2344 ns | 0.1551 ns |  2.12 |    0.04 |
| ExtensionMethod_ReadBytes_UInt64           | .NET Framework 4.6.2 |  6.474 ns | 0.1647 ns | 0.1089 ns |  1.55 |    0.03 |
| ExtensionMethod_ReadBytes_Int64            | .NET Framework 4.6.2 |  4.694 ns | 0.0407 ns | 0.0242 ns |  1.13 |    0.02 |
| ExtensionMethod_ReadBytes_UInt32           | .NET Framework 4.6.2 |  4.205 ns | 0.0827 ns | 0.0547 ns |  1.01 |    0.02 |
| ExtensionMethod_ReadBytes_Int32            | .NET Framework 4.6.2 |  2.995 ns | 0.0382 ns | 0.0200 ns |  0.72 |    0.01 |
| ExtensionMethod_ReadBytes_UInt16           | .NET Framework 4.6.2 |  3.287 ns | 0.0670 ns | 0.0443 ns |  0.79 |    0.02 |
| ExtensionMethod_ReadBytes_Int16            | .NET Framework 4.6.2 |  2.474 ns | 0.0304 ns | 0.0159 ns |  0.59 |    0.01 |
| BigEndianByteIndexerFloat_Slice            | .NET Framework 4.6.2 |  4.063 ns | 0.1303 ns | 0.0862 ns |  0.97 |    0.03 |
| BigEndianByteIndexerDouble_Slice           | .NET Framework 4.6.2 |  7.976 ns | 0.1937 ns | 0.1281 ns |  1.91 |    0.04 |
| BigEndianByteIndexerUInt64_Slice           | .NET Framework 4.6.2 |  6.905 ns | 0.0976 ns | 0.0645 ns |  1.66 |    0.03 |
| BigEndianByteIndexerInt64_Slice            | .NET Framework 4.6.2 |  6.934 ns | 0.0879 ns | 0.0523 ns |  1.66 |    0.03 |
| BigEndianByteIndexerUInt32_Slice           | .NET Framework 4.6.2 |  3.962 ns | 0.0542 ns | 0.0283 ns |  0.95 |    0.02 |
| BigEndianByteIndexerInt32_Slice            | .NET Framework 4.6.2 |  4.265 ns | 0.2945 ns | 0.2130 ns |  1.03 |    0.05 |
| BigEndianByteIndexerUInt16_Slice           | .NET Framework 4.6.2 |  3.200 ns | 0.3828 ns | 0.2278 ns |  0.77 |    0.06 |
| BigEndianByteIndexerInt16_Slice            | .NET Framework 4.6.2 |  3.456 ns | 0.4528 ns | 0.2695 ns |  0.83 |    0.06 |
| BigEndianByteIndexerDouble_Slice_New_Inst  | .NET Framework 4.6.2 |  7.949 ns | 0.4486 ns | 0.2670 ns |  1.91 |    0.08 |
| BigEndianByteIndexerFloat_Slice_New_Inst   | .NET Framework 4.6.2 |  9.369 ns | 0.3938 ns | 0.2847 ns |  2.24 |    0.08 |
| BigEndianByteIndexerUInt64_Slice_New_Inst  | .NET Framework 4.6.2 |  6.444 ns | 0.0305 ns | 0.0182 ns |  1.54 |    0.03 |
| BigEndianByteIndexerInt64_Slice_New_Inst   | .NET Framework 4.6.2 |  6.527 ns | 0.0473 ns | 0.0281 ns |  1.56 |    0.03 |
| BigEndianByteIndexerUInt32_Slice_New_Inst  | .NET Framework 4.6.2 |  3.801 ns | 0.0332 ns | 0.0219 ns |  0.91 |    0.01 |
| BigEndianByteIndexerInt32_Slice_New_Inst   | .NET Framework 4.6.2 |  4.167 ns | 0.0288 ns | 0.0150 ns |  1.00 |    0.02 |
| BigEndianByteIndexerUInt16_Slice_New_Inst  | .NET Framework 4.6.2 |  5.896 ns | 0.0698 ns | 0.0462 ns |  1.41 |    0.02 |
| BigEndianByteIndexerInt16_Slice_New_Inst   | .NET Framework 4.6.2 |  3.169 ns | 0.0932 ns | 0.0616 ns |  0.76 |    0.02 |

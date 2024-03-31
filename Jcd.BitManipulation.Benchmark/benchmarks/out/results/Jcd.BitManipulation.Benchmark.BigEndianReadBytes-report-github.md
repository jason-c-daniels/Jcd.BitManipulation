```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-VBQYBY : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-NFESSE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                                | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|---------------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double          | .NET 8.0             |  7.247 ns | 0.8114 ns | 0.7590 ns |  1.73 |    0.21 |
| BitConverter_GetBytes_Float           | .NET 8.0             |  5.093 ns | 0.3506 ns | 0.3279 ns |  1.22 |    0.09 |
| BitConverter_GetBytes_UInt64          | .NET 8.0             |  4.917 ns | 0.1438 ns | 0.1201 ns |  1.17 |    0.06 |
| BitConverter_GetBytes_Int64           | .NET 8.0             |  5.087 ns | 0.1821 ns | 0.1703 ns |  1.21 |    0.05 |
| BitConverter_GetBytes_UInt32          | .NET 8.0             |  5.096 ns | 0.1986 ns | 0.1858 ns |  1.21 |    0.05 |
| BitConverter_GetBytes_Int32           | .NET 8.0             |  5.213 ns | 0.2594 ns | 0.2427 ns |  1.24 |    0.05 |
| BitConverter_GetBytes_UInt16          | .NET 8.0             |  4.621 ns | 0.1620 ns | 0.1353 ns |  1.10 |    0.05 |
| BitConverter_GetBytes_Int16           | .NET 8.0             |  4.886 ns | 0.1603 ns | 0.1500 ns |  1.16 |    0.07 |
| BigEndianByteIndexer_Slice_Double     | .NET 8.0             |  4.238 ns | 0.1670 ns | 0.1562 ns |  1.00 |    0.05 |
| BigEndianByteIndexer_Slice_Float      | .NET 8.0             |  3.960 ns | 0.1490 ns | 0.1394 ns |  0.94 |    0.05 |
| BigEndianByteIndexer_Slice_UInt64     | .NET 8.0             |  4.222 ns | 0.1600 ns | 0.1418 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Int64      | .NET 8.0             |  4.360 ns | 0.2258 ns | 0.2002 ns |  1.03 |    0.07 |
| BigEndianByteIndexer_Slice_UInt32     | .NET 8.0             |  3.467 ns | 0.1143 ns | 0.0598 ns |  0.82 |    0.02 |
| BigEndianByteIndexer_Slice_Int32      | .NET 8.0             |  3.911 ns | 0.1653 ns | 0.1547 ns |  0.93 |    0.05 |
| BigEndianByteIndexer_Slice_UInt16     | .NET 8.0             |  3.997 ns | 0.2207 ns | 0.2064 ns |  0.95 |    0.06 |
| BigEndianByteIndexer_Slice_Int16      | .NET 8.0             |  3.900 ns | 0.1248 ns | 0.1042 ns |  0.92 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET 8.0             |  4.121 ns | 0.1315 ns | 0.0951 ns |  0.99 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET 8.0             |  4.260 ns | 0.2625 ns | 0.2455 ns |  1.01 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET 8.0             |  4.326 ns | 0.1944 ns | 0.1819 ns |  1.03 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET 8.0             |  5.662 ns | 0.2533 ns | 0.2370 ns |  1.35 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET 8.0             |  3.945 ns | 0.1847 ns | 0.1637 ns |  0.93 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET 8.0             |  4.776 ns | 0.1516 ns | 0.1418 ns |  1.13 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET 8.0             |  3.968 ns | 0.1802 ns | 0.1686 ns |  0.94 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET 8.0             |  3.904 ns | 0.1810 ns | 0.1693 ns |  0.92 |    0.06 |
| BitConverter_GetBytes_Double          | .NET Framework 4.6.2 | 28.260 ns | 0.7207 ns | 0.6018 ns |  6.71 |    0.33 |
| BitConverter_GetBytes_Float           | .NET Framework 4.6.2 | 27.283 ns | 0.9064 ns | 0.8479 ns |  6.47 |    0.26 |
| BitConverter_GetBytes_UInt64          | .NET Framework 4.6.2 | 28.351 ns | 0.6106 ns | 0.5711 ns |  6.72 |    0.30 |
| BitConverter_GetBytes_Int64           | .NET Framework 4.6.2 | 28.129 ns | 0.8124 ns | 0.7599 ns |  6.68 |    0.23 |
| BitConverter_GetBytes_UInt32          | .NET Framework 4.6.2 | 26.164 ns | 0.7125 ns | 0.6316 ns |  6.20 |    0.21 |
| BitConverter_GetBytes_Int32           | .NET Framework 4.6.2 | 26.451 ns | 0.5868 ns | 0.5489 ns |  6.28 |    0.19 |
| BitConverter_GetBytes_UInt16          | .NET Framework 4.6.2 | 25.639 ns | 0.5380 ns | 0.4769 ns |  6.08 |    0.20 |
| BitConverter_GetBytes_Int16           | .NET Framework 4.6.2 | 25.237 ns | 0.5243 ns | 0.4093 ns |  6.02 |    0.22 |
| BigEndianByteIndexer_Slice_Double     | .NET Framework 4.6.2 |  9.228 ns | 0.2739 ns | 0.2562 ns |  2.18 |    0.09 |
| BigEndianByteIndexer_Slice_Float      | .NET Framework 4.6.2 | 10.828 ns | 0.5860 ns | 0.5481 ns |  2.57 |    0.16 |
| BigEndianByteIndexer_Slice_UInt64     | .NET Framework 4.6.2 |  9.099 ns | 0.4222 ns | 0.3950 ns |  2.16 |    0.10 |
| BigEndianByteIndexer_Slice_Int64      | .NET Framework 4.6.2 |  9.203 ns | 0.3660 ns | 0.3423 ns |  2.19 |    0.11 |
| BigEndianByteIndexer_Slice_UInt32     | .NET Framework 4.6.2 |  5.619 ns | 0.2480 ns | 0.2198 ns |  1.33 |    0.08 |
| BigEndianByteIndexer_Slice_Int32      | .NET Framework 4.6.2 |  6.013 ns | 0.3568 ns | 0.3337 ns |  1.43 |    0.11 |
| BigEndianByteIndexer_Slice_UInt16     | .NET Framework 4.6.2 |  4.791 ns | 0.2227 ns | 0.2083 ns |  1.14 |    0.06 |
| BigEndianByteIndexer_Slice_Int16      | .NET Framework 4.6.2 |  4.651 ns | 0.2441 ns | 0.2164 ns |  1.10 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET Framework 4.6.2 |  9.295 ns | 0.4134 ns | 0.3867 ns |  2.20 |    0.14 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET Framework 4.6.2 | 10.148 ns | 0.3736 ns | 0.3495 ns |  2.40 |    0.13 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET Framework 4.6.2 |  9.096 ns | 0.4229 ns | 0.3749 ns |  2.16 |    0.12 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET Framework 4.6.2 |  5.521 ns | 0.1589 ns | 0.1408 ns |  1.31 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET Framework 4.6.2 |  6.017 ns | 0.3906 ns | 0.3654 ns |  1.42 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET Framework 4.6.2 |  3.929 ns | 0.1228 ns | 0.1026 ns |  0.93 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET Framework 4.6.2 |  5.041 ns | 0.1427 ns | 0.1192 ns |  1.20 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET Framework 4.6.2 |  3.232 ns | 0.1045 ns | 0.0926 ns |  0.77 |    0.04 |

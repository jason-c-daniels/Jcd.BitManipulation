```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-XPKBTN : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-HBVPVO : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                                | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|---------------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double          | .NET 8.0             |  4.662 ns | 0.2736 ns | 0.2425 ns |  1.10 |    0.07 |
| BitConverter_GetBytes_Float           | .NET 8.0             |  4.770 ns | 0.6787 ns | 0.6349 ns |  1.14 |    0.18 |
| BitConverter_GetBytes_UInt64          | .NET 8.0             |  4.675 ns | 0.6453 ns | 0.6036 ns |  1.12 |    0.17 |
| BitConverter_GetBytes_Int64           | .NET 8.0             |  4.117 ns | 0.3969 ns | 0.3518 ns |  0.97 |    0.11 |
| BitConverter_GetBytes_UInt32          | .NET 8.0             |  3.843 ns | 0.2532 ns | 0.2369 ns |  0.91 |    0.09 |
| BitConverter_GetBytes_Int32           | .NET 8.0             |  4.064 ns | 0.3145 ns | 0.2942 ns |  0.97 |    0.09 |
| BitConverter_GetBytes_UInt16          | .NET 8.0             |  4.060 ns | 0.3220 ns | 0.3012 ns |  0.96 |    0.11 |
| BitConverter_GetBytes_Int16           | .NET 8.0             |  4.163 ns | 0.4875 ns | 0.4560 ns |  0.99 |    0.14 |
| LittleEndianByteIndexer_Slice_Double  | .NET 8.0             |  4.751 ns | 0.2650 ns | 0.2213 ns |  1.12 |    0.10 |
| LittleEndianByteIndexer_Slice_Float   | .NET 8.0             |  4.334 ns | 0.2069 ns | 0.1728 ns |  1.02 |    0.07 |
| LittleEndianByteIndexer_Slice_UInt64  | .NET 8.0             |  4.251 ns | 0.2853 ns | 0.2529 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Int64   | .NET 8.0             |  5.391 ns | 0.9643 ns | 0.9020 ns |  1.23 |    0.14 |
| LittleEndianByteIndexer_Slice_UInt32  | .NET 8.0             |  4.642 ns | 0.3421 ns | 0.3200 ns |  1.10 |    0.11 |
| LittleEndianByteIndexer_Slice_Int32   | .NET 8.0             |  4.108 ns | 0.2093 ns | 0.1748 ns |  0.97 |    0.06 |
| LittleEndianByteIndexer_Slice_UInt16  | .NET 8.0             |  4.073 ns | 0.1682 ns | 0.1574 ns |  0.96 |    0.09 |
| LittleEndianByteIndexer_Slice_Int16   | .NET 8.0             |  4.549 ns | 0.5037 ns | 0.4711 ns |  1.09 |    0.15 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET 8.0             |  4.580 ns | 0.1506 ns | 0.1335 ns |  1.08 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET 8.0             |  4.298 ns | 0.2380 ns | 0.2227 ns |  1.02 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET 8.0             |  4.879 ns | 0.3389 ns | 0.3170 ns |  1.16 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET 8.0             |  5.366 ns | 0.4150 ns | 0.3882 ns |  1.25 |    0.09 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET 8.0             |  4.817 ns | 0.6350 ns | 0.5939 ns |  1.15 |    0.17 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET 8.0             |  4.750 ns | 0.3383 ns | 0.2825 ns |  1.12 |    0.09 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET 8.0             |  4.292 ns | 0.4583 ns | 0.4063 ns |  1.01 |    0.10 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET 8.0             |  4.155 ns | 0.2742 ns | 0.2565 ns |  0.99 |    0.09 |
| BitConverter_GetBytes_Double          | .NET Framework 4.6.2 |  4.433 ns | 0.1387 ns | 0.1297 ns |  1.04 |    0.06 |
| BitConverter_GetBytes_Float           | .NET Framework 4.6.2 |  3.811 ns | 0.0827 ns | 0.0547 ns |  0.92 |    0.03 |
| BitConverter_GetBytes_UInt64          | .NET Framework 4.6.2 |  4.370 ns | 0.1349 ns | 0.0976 ns |  1.05 |    0.05 |
| BitConverter_GetBytes_Int64           | .NET Framework 4.6.2 |  4.939 ns | 0.7500 ns | 0.7016 ns |  1.18 |    0.18 |
| BitConverter_GetBytes_UInt32          | .NET Framework 4.6.2 |  4.329 ns | 0.4145 ns | 0.3877 ns |  1.03 |    0.09 |
| BitConverter_GetBytes_Int32           | .NET Framework 4.6.2 |  4.042 ns | 0.2838 ns | 0.2655 ns |  0.96 |    0.07 |
| BitConverter_GetBytes_UInt16          | .NET Framework 4.6.2 |  4.267 ns | 0.3889 ns | 0.3638 ns |  1.00 |    0.12 |
| BitConverter_GetBytes_Int16           | .NET Framework 4.6.2 |  4.577 ns | 0.5324 ns | 0.4980 ns |  1.07 |    0.15 |
| LittleEndianByteIndexer_Slice_Double  | .NET Framework 4.6.2 |  6.435 ns | 0.4704 ns | 0.3928 ns |  1.52 |    0.11 |
| LittleEndianByteIndexer_Slice_Float   | .NET Framework 4.6.2 | 10.131 ns | 1.0885 ns | 1.0181 ns |  2.41 |    0.34 |
| LittleEndianByteIndexer_Slice_UInt64  | .NET Framework 4.6.2 |  6.288 ns | 0.8655 ns | 0.8096 ns |  1.47 |    0.15 |
| LittleEndianByteIndexer_Slice_Int64   | .NET Framework 4.6.2 |  6.101 ns | 0.3894 ns | 0.3643 ns |  1.44 |    0.15 |
| LittleEndianByteIndexer_Slice_UInt32  | .NET Framework 4.6.2 |  5.300 ns | 0.2534 ns | 0.2370 ns |  1.25 |    0.08 |
| LittleEndianByteIndexer_Slice_Int32   | .NET Framework 4.6.2 |  4.949 ns | 0.2198 ns | 0.2056 ns |  1.16 |    0.08 |
| LittleEndianByteIndexer_Slice_UInt16  | .NET Framework 4.6.2 |  4.761 ns | 0.1615 ns | 0.1510 ns |  1.12 |    0.07 |
| LittleEndianByteIndexer_Slice_Int16   | .NET Framework 4.6.2 |  4.752 ns | 0.1557 ns | 0.1300 ns |  1.12 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET Framework 4.6.2 |  6.269 ns | 0.2310 ns | 0.2161 ns |  1.48 |    0.11 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET Framework 4.6.2 |  9.735 ns | 0.4274 ns | 0.3337 ns |  2.33 |    0.14 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET Framework 4.6.2 |  6.118 ns | 0.2406 ns | 0.2251 ns |  1.44 |    0.11 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET Framework 4.6.2 |  5.082 ns | 0.1198 ns | 0.0713 ns |  1.23 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET Framework 4.6.2 |  5.446 ns | 0.6197 ns | 0.5797 ns |  1.30 |    0.18 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET Framework 4.6.2 |  4.496 ns | 0.4713 ns | 0.4178 ns |  1.06 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET Framework 4.6.2 |  4.692 ns | 0.2109 ns | 0.1761 ns |  1.11 |    0.10 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET Framework 4.6.2 |  4.123 ns | 0.4217 ns | 0.3945 ns |  0.98 |    0.12 |

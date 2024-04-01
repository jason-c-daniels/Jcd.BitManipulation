```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ROZSUB : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-TSPCCX : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                                | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|---------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double          | .NET 8.0             | 3.459 ns | 0.1439 ns | 0.1346 ns |  0.99 |    0.08 |
| BitConverter_GetBytes_Float           | .NET 8.0             | 3.440 ns | 0.1607 ns | 0.1503 ns |  0.98 |    0.08 |
| BitConverter_GetBytes_UInt64          | .NET 8.0             | 3.206 ns | 0.1122 ns | 0.1049 ns |  0.92 |    0.06 |
| BitConverter_GetBytes_Int64           | .NET 8.0             | 3.782 ns | 0.9133 ns | 0.8096 ns |  1.07 |    0.22 |
| BitConverter_GetBytes_UInt32          | .NET 8.0             | 3.485 ns | 0.4277 ns | 0.4001 ns |  1.00 |    0.13 |
| BitConverter_GetBytes_Int32           | .NET 8.0             | 3.329 ns | 0.2941 ns | 0.2608 ns |  0.95 |    0.11 |
| BitConverter_GetBytes_UInt16          | .NET 8.0             | 3.456 ns | 0.2458 ns | 0.2299 ns |  0.99 |    0.08 |
| BitConverter_GetBytes_Int16           | .NET 8.0             | 3.071 ns | 0.0989 ns | 0.0654 ns |  0.87 |    0.06 |
| LittleEndianByteIndexer_Slice_Double  | .NET 8.0             | 3.915 ns | 0.2037 ns | 0.1905 ns |  1.12 |    0.09 |
| LittleEndianByteIndexer_Slice_Float   | .NET 8.0             | 3.652 ns | 0.5884 ns | 0.4913 ns |  1.03 |    0.13 |
| LittleEndianByteIndexer_Slice_UInt64  | .NET 8.0             | 3.513 ns | 0.2338 ns | 0.2187 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Int64   | .NET 8.0             | 3.676 ns | 0.1095 ns | 0.0724 ns |  1.04 |    0.07 |
| LittleEndianByteIndexer_Slice_UInt32  | .NET 8.0             | 3.438 ns | 0.0703 ns | 0.0419 ns |  0.97 |    0.07 |
| LittleEndianByteIndexer_Slice_Int32   | .NET 8.0             | 3.525 ns | 0.1626 ns | 0.1358 ns |  1.00 |    0.07 |
| LittleEndianByteIndexer_Slice_UInt16  | .NET 8.0             | 3.415 ns | 0.2212 ns | 0.1847 ns |  0.97 |    0.09 |
| LittleEndianByteIndexer_Slice_Int16   | .NET 8.0             | 3.735 ns | 0.3220 ns | 0.3012 ns |  1.07 |    0.11 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET 8.0             | 4.213 ns | 0.4858 ns | 0.4544 ns |  1.20 |    0.14 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET 8.0             | 3.516 ns | 0.1481 ns | 0.1385 ns |  1.00 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET 8.0             | 3.836 ns | 0.1145 ns | 0.0956 ns |  1.09 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET 8.0             | 4.754 ns | 0.1380 ns | 0.1152 ns |  1.35 |    0.10 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET 8.0             | 3.290 ns | 0.0706 ns | 0.0467 ns |  0.93 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET 8.0             | 3.893 ns | 0.0771 ns | 0.0510 ns |  1.10 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET 8.0             | 3.395 ns | 0.2283 ns | 0.2136 ns |  0.97 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET 8.0             | 3.929 ns | 0.3858 ns | 0.3609 ns |  1.12 |    0.10 |
| BitConverter_GetBytes_Double          | .NET Framework 4.6.2 | 4.472 ns | 0.3367 ns | 0.2985 ns |  1.27 |    0.11 |
| BitConverter_GetBytes_Float           | .NET Framework 4.6.2 | 3.875 ns | 0.1492 ns | 0.1323 ns |  1.10 |    0.07 |
| BitConverter_GetBytes_UInt64          | .NET Framework 4.6.2 | 4.443 ns | 0.1586 ns | 0.1484 ns |  1.27 |    0.09 |
| BitConverter_GetBytes_Int64           | .NET Framework 4.6.2 | 4.412 ns | 0.2488 ns | 0.2327 ns |  1.26 |    0.11 |
| BitConverter_GetBytes_UInt32          | .NET Framework 4.6.2 | 3.623 ns | 0.0678 ns | 0.0403 ns |  1.02 |    0.08 |
| BitConverter_GetBytes_Int32           | .NET Framework 4.6.2 | 3.788 ns | 0.0608 ns | 0.0318 ns |  1.08 |    0.08 |
| BitConverter_GetBytes_UInt16          | .NET Framework 4.6.2 | 4.073 ns | 0.1629 ns | 0.1444 ns |  1.16 |    0.09 |
| BitConverter_GetBytes_Int16           | .NET Framework 4.6.2 | 3.844 ns | 0.0499 ns | 0.0330 ns |  1.09 |    0.07 |
| LittleEndianByteIndexer_Slice_Double  | .NET Framework 4.6.2 | 5.916 ns | 0.1558 ns | 0.1301 ns |  1.68 |    0.12 |
| LittleEndianByteIndexer_Slice_Float   | .NET Framework 4.6.2 | 8.170 ns | 0.1115 ns | 0.0664 ns |  2.31 |    0.18 |
| LittleEndianByteIndexer_Slice_UInt64  | .NET Framework 4.6.2 | 5.740 ns | 0.1457 ns | 0.1291 ns |  1.64 |    0.12 |
| LittleEndianByteIndexer_Slice_Int64   | .NET Framework 4.6.2 | 5.664 ns | 0.2604 ns | 0.2436 ns |  1.62 |    0.12 |
| LittleEndianByteIndexer_Slice_UInt32  | .NET Framework 4.6.2 | 4.595 ns | 0.1245 ns | 0.0972 ns |  1.30 |    0.09 |
| LittleEndianByteIndexer_Slice_Int32   | .NET Framework 4.6.2 | 4.579 ns | 0.0827 ns | 0.0433 ns |  1.30 |    0.10 |
| LittleEndianByteIndexer_Slice_UInt16  | .NET Framework 4.6.2 | 4.326 ns | 0.0720 ns | 0.0376 ns |  1.23 |    0.08 |
| LittleEndianByteIndexer_Slice_Int16   | .NET Framework 4.6.2 | 4.563 ns | 0.1461 ns | 0.1220 ns |  1.29 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET Framework 4.6.2 | 5.924 ns | 0.4153 ns | 0.3885 ns |  1.69 |    0.15 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET Framework 4.6.2 | 8.754 ns | 0.4003 ns | 0.3549 ns |  2.49 |    0.14 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET Framework 4.6.2 | 5.920 ns | 0.2430 ns | 0.2154 ns |  1.69 |    0.10 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET Framework 4.6.2 | 4.826 ns | 0.0407 ns | 0.0269 ns |  1.36 |    0.10 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET Framework 4.6.2 | 4.356 ns | 0.1245 ns | 0.0741 ns |  1.23 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET Framework 4.6.2 | 3.615 ns | 0.0871 ns | 0.0576 ns |  1.02 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET Framework 4.6.2 | 3.927 ns | 0.1172 ns | 0.0775 ns |  1.11 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET Framework 4.6.2 | 3.066 ns | 0.0894 ns | 0.0746 ns |  0.87 |    0.06 |

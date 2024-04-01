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

| Method                                | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|---------------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double          | .NET 8.0             |  4.495 ns | 0.1117 ns | 0.0739 ns |  1.26 |    0.03 |
| BitConverter_GetBytes_Float           | .NET 8.0             |  4.546 ns | 0.1150 ns | 0.0761 ns |  1.27 |    0.03 |
| BitConverter_GetBytes_UInt64          | .NET 8.0             |  4.272 ns | 0.1144 ns | 0.0893 ns |  1.20 |    0.03 |
| BitConverter_GetBytes_Int64           | .NET 8.0             |  4.366 ns | 0.1181 ns | 0.0781 ns |  1.22 |    0.03 |
| BitConverter_GetBytes_UInt32          | .NET 8.0             |  4.389 ns | 0.1251 ns | 0.1109 ns |  1.23 |    0.03 |
| BitConverter_GetBytes_Int32           | .NET 8.0             |  4.287 ns | 0.1309 ns | 0.0866 ns |  1.20 |    0.02 |
| BitConverter_GetBytes_UInt16          | .NET 8.0             |  4.152 ns | 0.0882 ns | 0.0583 ns |  1.16 |    0.02 |
| BitConverter_GetBytes_Int16           | .NET 8.0             |  4.168 ns | 0.1100 ns | 0.0727 ns |  1.17 |    0.02 |
| BigEndianByteIndexer_Slice_Double     | .NET 8.0             |  3.761 ns | 0.0813 ns | 0.0425 ns |  1.05 |    0.01 |
| BigEndianByteIndexer_Slice_Float      | .NET 8.0             |  3.302 ns | 0.0562 ns | 0.0334 ns |  0.92 |    0.02 |
| BigEndianByteIndexer_Slice_UInt64     | .NET 8.0             |  3.568 ns | 0.0947 ns | 0.0626 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Int64      | .NET 8.0             |  3.653 ns | 0.1119 ns | 0.0992 ns |  1.03 |    0.03 |
| BigEndianByteIndexer_Slice_UInt32     | .NET 8.0             |  3.389 ns | 0.0645 ns | 0.0427 ns |  0.95 |    0.02 |
| BigEndianByteIndexer_Slice_Int32      | .NET 8.0             |  3.418 ns | 0.1022 ns | 0.0798 ns |  0.96 |    0.03 |
| BigEndianByteIndexer_Slice_UInt16     | .NET 8.0             |  3.307 ns | 0.0836 ns | 0.0553 ns |  0.93 |    0.01 |
| BigEndianByteIndexer_Slice_Int16      | .NET 8.0             |  3.326 ns | 0.1136 ns | 0.1063 ns |  0.94 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET 8.0             |  3.632 ns | 0.1188 ns | 0.1111 ns |  1.03 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET 8.0             |  3.600 ns | 0.0716 ns | 0.0426 ns |  1.01 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET 8.0             |  3.656 ns | 0.0974 ns | 0.0644 ns |  1.02 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET 8.0             |  5.174 ns | 0.1499 ns | 0.1402 ns |  1.45 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET 8.0             |  3.431 ns | 0.0812 ns | 0.0537 ns |  0.96 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET 8.0             |  3.927 ns | 0.0729 ns | 0.0482 ns |  1.10 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET 8.0             |  3.218 ns | 0.0567 ns | 0.0375 ns |  0.90 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET 8.0             |  3.320 ns | 0.0628 ns | 0.0374 ns |  0.93 |    0.02 |
| BitConverter_GetBytes_Double          | .NET Framework 4.6.2 | 24.730 ns | 0.0594 ns | 0.0353 ns |  6.93 |    0.12 |
| BitConverter_GetBytes_Float           | .NET Framework 4.6.2 | 23.605 ns | 0.3004 ns | 0.1787 ns |  6.61 |    0.13 |
| BitConverter_GetBytes_UInt64          | .NET Framework 4.6.2 | 25.213 ns | 0.3299 ns | 0.2182 ns |  7.07 |    0.15 |
| BitConverter_GetBytes_Int64           | .NET Framework 4.6.2 | 26.311 ns | 1.1054 ns | 0.9799 ns |  7.32 |    0.36 |
| BitConverter_GetBytes_UInt32          | .NET Framework 4.6.2 | 24.029 ns | 0.5716 ns | 0.5067 ns |  6.74 |    0.23 |
| BitConverter_GetBytes_Int32           | .NET Framework 4.6.2 | 25.396 ns | 3.1686 ns | 2.8089 ns |  6.69 |    0.23 |
| BitConverter_GetBytes_UInt16          | .NET Framework 4.6.2 | 23.884 ns | 0.9453 ns | 0.8842 ns |  6.71 |    0.24 |
| BitConverter_GetBytes_Int16           | .NET Framework 4.6.2 | 22.704 ns | 0.3561 ns | 0.2355 ns |  6.36 |    0.10 |
| BigEndianByteIndexer_Slice_Double     | .NET Framework 4.6.2 |  8.439 ns | 0.2054 ns | 0.1358 ns |  2.37 |    0.05 |
| BigEndianByteIndexer_Slice_Float      | .NET Framework 4.6.2 |  9.022 ns | 0.1447 ns | 0.0957 ns |  2.53 |    0.06 |
| BigEndianByteIndexer_Slice_UInt64     | .NET Framework 4.6.2 |  7.981 ns | 0.1681 ns | 0.1112 ns |  2.24 |    0.05 |
| BigEndianByteIndexer_Slice_Int64      | .NET Framework 4.6.2 |  8.144 ns | 0.2054 ns | 0.1486 ns |  2.28 |    0.06 |
| BigEndianByteIndexer_Slice_UInt32     | .NET Framework 4.6.2 |  5.137 ns | 0.1397 ns | 0.1010 ns |  1.44 |    0.04 |
| BigEndianByteIndexer_Slice_Int32      | .NET Framework 4.6.2 |  4.998 ns | 0.1925 ns | 0.1607 ns |  1.39 |    0.05 |
| BigEndianByteIndexer_Slice_UInt16     | .NET Framework 4.6.2 |  4.202 ns | 0.0527 ns | 0.0348 ns |  1.18 |    0.02 |
| BigEndianByteIndexer_Slice_Int16      | .NET Framework 4.6.2 |  4.175 ns | 0.0296 ns | 0.0196 ns |  1.17 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET Framework 4.6.2 |  8.353 ns | 0.2007 ns | 0.1676 ns |  2.34 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET Framework 4.6.2 |  9.152 ns | 0.2154 ns | 0.1558 ns |  2.56 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET Framework 4.6.2 |  8.167 ns | 0.2138 ns | 0.1896 ns |  2.31 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET Framework 4.6.2 |  5.118 ns | 0.0840 ns | 0.0439 ns |  1.43 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET Framework 4.6.2 |  5.210 ns | 0.1435 ns | 0.1272 ns |  1.46 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET Framework 4.6.2 |  3.571 ns | 0.0647 ns | 0.0428 ns |  1.00 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET Framework 4.6.2 |  4.566 ns | 0.0727 ns | 0.0481 ns |  1.28 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET Framework 4.6.2 |  2.856 ns | 0.0393 ns | 0.0234 ns |  0.80 |    0.01 |

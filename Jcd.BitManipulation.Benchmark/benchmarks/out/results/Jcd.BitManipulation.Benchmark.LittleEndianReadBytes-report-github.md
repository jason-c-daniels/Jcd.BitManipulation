```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ROROES : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-CCUDDK : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                               | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double         | .NET 8.0             | 3.263 ns | 0.1436 ns | 0.1344 ns |  0.90 |    0.14 |
| BitConverter_GetBytes_Float          | .NET 8.0             | 3.825 ns | 0.1852 ns | 0.1642 ns |  1.04 |    0.16 |
| BitConverter_GetBytes_UInt64         | .NET 8.0             | 3.258 ns | 0.1386 ns | 0.1296 ns |  0.90 |    0.15 |
| BitConverter_GetBytes_Int64          | .NET 8.0             | 3.293 ns | 0.1365 ns | 0.1277 ns |  0.91 |    0.17 |
| BitConverter_GetBytes_UInt32         | .NET 8.0             | 3.186 ns | 0.1207 ns | 0.1129 ns |  0.88 |    0.15 |
| BitConverter_GetBytes_Int32          | .NET 8.0             | 3.823 ns | 0.6852 ns | 0.6409 ns |  1.05 |    0.21 |
| BitConverter_GetBytes_UInt16         | .NET 8.0             | 3.489 ns | 0.5360 ns | 0.5014 ns |  0.95 |    0.16 |
| BitConverter_GetBytes_Int16          | .NET 8.0             | 3.725 ns | 0.6213 ns | 0.5812 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Double | .NET 8.0             | 5.711 ns | 0.8949 ns | 0.8371 ns |  1.60 |    0.49 |
| LittleEndianByteIndexer_Slice_Float  | .NET 8.0             | 6.404 ns | 0.7096 ns | 0.6638 ns |  1.76 |    0.32 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET 8.0             | 6.366 ns | 0.9146 ns | 0.8555 ns |  1.75 |    0.39 |
| LittleEndianByteIndexer_Slice_Int64  | .NET 8.0             | 5.851 ns | 0.6024 ns | 0.5030 ns |  1.57 |    0.21 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET 8.0             | 4.017 ns | 0.0889 ns | 0.0588 ns |  0.99 |    0.08 |
| LittleEndianByteIndexer_Slice_Int32  | .NET 8.0             | 4.095 ns | 0.1156 ns | 0.0902 ns |  1.08 |    0.17 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET 8.0             | 3.903 ns | 0.5732 ns | 0.5362 ns |  1.05 |    0.07 |
| LittleEndianByteIndexer_Slice_Int16  | .NET 8.0             | 3.960 ns | 0.5913 ns | 0.5531 ns |  1.07 |    0.12 |
| ExtensionMethod_ReadBytes_Double     | .NET 8.0             | 6.137 ns | 0.6981 ns | 0.6530 ns |  1.70 |    0.42 |
| ExtensionMethod_ReadBytes_Float      | .NET 8.0             | 6.656 ns | 0.7462 ns | 0.6980 ns |  1.83 |    0.36 |
| ExtensionMethod_ReadBytes_UInt64     | .NET 8.0             | 5.274 ns | 0.5607 ns | 0.5245 ns |  1.44 |    0.19 |
| ExtensionMethod_ReadBytes_Int64      | .NET 8.0             | 4.729 ns | 0.1596 ns | 0.1493 ns |  1.30 |    0.20 |
| ExtensionMethod_ReadBytes_UInt32     | .NET 8.0             | 4.443 ns | 0.6909 ns | 0.6463 ns |  1.22 |    0.23 |
| ExtensionMethod_ReadBytes_Int32      | .NET 8.0             | 3.755 ns | 0.3868 ns | 0.3618 ns |  1.03 |    0.19 |
| ExtensionMethod_ReadBytes_UInt16     | .NET 8.0             | 3.543 ns | 0.2658 ns | 0.2356 ns |  0.98 |    0.21 |
| ExtensionMethod_ReadBytes_Int16      | .NET 8.0             | 3.689 ns | 0.5047 ns | 0.4721 ns |  1.01 |    0.19 |
| BitConverter_GetBytes_Double         | .NET Framework 4.6.2 | 3.597 ns | 0.1561 ns | 0.1460 ns |  0.99 |    0.15 |
| BitConverter_GetBytes_Float          | .NET Framework 4.6.2 | 3.172 ns | 0.1799 ns | 0.1683 ns |  0.87 |    0.15 |
| BitConverter_GetBytes_UInt64         | .NET Framework 4.6.2 | 3.506 ns | 0.1155 ns | 0.0764 ns |  0.86 |    0.07 |
| BitConverter_GetBytes_Int64          | .NET Framework 4.6.2 | 3.413 ns | 0.1517 ns | 0.1344 ns |  0.93 |    0.16 |
| BitConverter_GetBytes_UInt32         | .NET Framework 4.6.2 | 3.061 ns | 0.1603 ns | 0.1499 ns |  0.84 |    0.14 |
| BitConverter_GetBytes_Int32          | .NET Framework 4.6.2 | 2.941 ns | 0.0938 ns | 0.0620 ns |  0.73 |    0.06 |
| BitConverter_GetBytes_UInt16         | .NET Framework 4.6.2 | 3.366 ns | 0.2158 ns | 0.2019 ns |  0.92 |    0.13 |
| BitConverter_GetBytes_Int16          | .NET Framework 4.6.2 | 2.910 ns | 0.0650 ns | 0.0340 ns |  0.70 |    0.04 |
| LittleEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 | 6.412 ns | 0.2204 ns | 0.2062 ns |  1.76 |    0.30 |
| LittleEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 | 8.831 ns | 0.1444 ns | 0.0755 ns |  2.14 |    0.12 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 | 6.121 ns | 0.1119 ns | 0.0666 ns |  1.48 |    0.07 |
| LittleEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 | 6.317 ns | 0.2602 ns | 0.2307 ns |  1.73 |    0.31 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 | 3.607 ns | 0.1438 ns | 0.1345 ns |  1.00 |    0.19 |
| LittleEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 | 3.745 ns | 0.1979 ns | 0.1852 ns |  1.03 |    0.18 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 | 2.727 ns | 0.1862 ns | 0.1742 ns |  0.75 |    0.14 |
| LittleEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 | 2.788 ns | 0.3562 ns | 0.3332 ns |  0.77 |    0.19 |
| ExtensionMethod_ReadBytes_Double     | .NET Framework 4.6.2 | 5.874 ns | 0.1619 ns | 0.1352 ns |  1.58 |    0.28 |
| ExtensionMethod_ReadBytes_Float      | .NET Framework 4.6.2 | 8.201 ns | 0.7471 ns | 0.6988 ns |  2.24 |    0.31 |
| ExtensionMethod_ReadBytes_UInt64     | .NET Framework 4.6.2 | 6.420 ns | 0.5950 ns | 0.5274 ns |  1.76 |    0.31 |
| ExtensionMethod_ReadBytes_Int64      | .NET Framework 4.6.2 | 3.572 ns | 0.0897 ns | 0.0534 ns |  0.86 |    0.04 |
| ExtensionMethod_ReadBytes_UInt32     | .NET Framework 4.6.2 | 3.207 ns | 0.1072 ns | 0.0638 ns |  0.77 |    0.04 |
| ExtensionMethod_ReadBytes_Int32      | .NET Framework 4.6.2 | 2.419 ns | 0.0591 ns | 0.0352 ns |  0.58 |    0.03 |
| ExtensionMethod_ReadBytes_UInt16     | .NET Framework 4.6.2 | 2.199 ns | 0.1040 ns | 0.0922 ns |  0.60 |    0.12 |
| ExtensionMethod_ReadBytes_Int16      | .NET Framework 4.6.2 | 2.070 ns | 0.0856 ns | 0.0509 ns |  0.50 |    0.03 |

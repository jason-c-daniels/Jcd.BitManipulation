```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ICMWHD : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-OXTARK : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                            | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|-----------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double      | .NET 8.0             |  4.783 ns | 0.1328 ns | 0.1109 ns |  1.23 |    0.05 |
| BitConverter_GetBytes_Float       | .NET 8.0             |  4.762 ns | 0.1695 ns | 0.1586 ns |  1.24 |    0.05 |
| BitConverter_GetBytes_UInt64      | .NET 8.0             |  4.217 ns | 0.3387 ns | 0.3168 ns |  1.10 |    0.09 |
| BitConverter_GetBytes_Int64       | .NET 8.0             |  4.275 ns | 0.2024 ns | 0.1690 ns |  1.09 |    0.04 |
| BitConverter_GetBytes_UInt32      | .NET 8.0             |  4.311 ns | 0.1090 ns | 0.0570 ns |  1.10 |    0.03 |
| BitConverter_GetBytes_Int32       | .NET 8.0             |  4.346 ns | 0.0997 ns | 0.0832 ns |  1.12 |    0.03 |
| BitConverter_GetBytes_UInt16      | .NET 8.0             |  4.090 ns | 0.1213 ns | 0.1075 ns |  1.06 |    0.04 |
| BitConverter_GetBytes_Int16       | .NET 8.0             |  3.902 ns | 0.1211 ns | 0.0801 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Double | .NET 8.0             |  4.281 ns | 0.1624 ns | 0.1440 ns |  1.09 |    0.04 |
| BigEndianByteIndexer_Slice_Float  | .NET 8.0             |  4.311 ns | 0.1326 ns | 0.0959 ns |  1.11 |    0.04 |
| BigEndianByteIndexer_Slice_UInt64 | .NET 8.0             |  4.318 ns | 0.1457 ns | 0.1292 ns |  1.10 |    0.04 |
| BigEndianByteIndexer_Slice_Int64  | .NET 8.0             |  4.333 ns | 0.1813 ns | 0.1696 ns |  1.11 |    0.05 |
| BigEndianByteIndexer_Slice_UInt32 | .NET 8.0             |  4.451 ns | 0.1478 ns | 0.1311 ns |  1.14 |    0.05 |
| BigEndianByteIndexer_Slice_Int32  | .NET 8.0             |  4.535 ns | 0.1588 ns | 0.1407 ns |  1.17 |    0.03 |
| BigEndianByteIndexer_Slice_UInt16 | .NET 8.0             |  4.030 ns | 0.1390 ns | 0.1300 ns |  1.02 |    0.04 |
| BigEndianByteIndexer_Slice_Int16  | .NET 8.0             |  4.066 ns | 0.1781 ns | 0.1666 ns |  1.06 |    0.04 |
| ExtensionMethod_ReadBytes_Double  | .NET 8.0             |  4.734 ns | 1.7355 ns | 1.5385 ns |  1.04 |    0.22 |
| ExtensionMethod_ReadBytes_Float   | .NET 8.0             |  4.604 ns | 0.1970 ns | 0.1843 ns |  1.18 |    0.06 |
| ExtensionMethod_ReadBytes_UInt64  | .NET 8.0             |  4.664 ns | 0.2359 ns | 0.2092 ns |  1.21 |    0.05 |
| ExtensionMethod_ReadBytes_Int64   | .NET 8.0             |  4.911 ns | 0.1408 ns | 0.1249 ns |  1.26 |    0.06 |
| ExtensionMethod_ReadBytes_UInt32  | .NET 8.0             |  4.470 ns | 0.2492 ns | 0.2209 ns |  1.13 |    0.05 |
| ExtensionMethod_ReadBytes_Int32   | .NET 8.0             |  4.061 ns | 0.5317 ns | 0.4974 ns |  1.09 |    0.12 |
| ExtensionMethod_ReadBytes_UInt16  | .NET 8.0             |  3.890 ns | 0.1289 ns | 0.1143 ns |  0.99 |    0.04 |
| ExtensionMethod_ReadBytes_Int16   | .NET 8.0             |  3.178 ns | 0.2683 ns | 0.2509 ns |  0.80 |    0.05 |
| BitConverter_GetBytes_Double      | .NET Framework 4.6.2 | 25.339 ns | 0.2502 ns | 0.1655 ns |  6.50 |    0.15 |
| BitConverter_GetBytes_Float       | .NET Framework 4.6.2 | 23.702 ns | 0.4187 ns | 0.2492 ns |  6.06 |    0.12 |
| BitConverter_GetBytes_UInt64      | .NET Framework 4.6.2 | 25.287 ns | 0.2752 ns | 0.1820 ns |  6.48 |    0.13 |
| BitConverter_GetBytes_Int64       | .NET Framework 4.6.2 | 25.107 ns | 0.3394 ns | 0.2245 ns |  6.44 |    0.13 |
| BitConverter_GetBytes_UInt32      | .NET Framework 4.6.2 | 23.549 ns | 0.3743 ns | 0.2476 ns |  6.04 |    0.12 |
| BitConverter_GetBytes_Int32       | .NET Framework 4.6.2 | 23.986 ns | 0.4814 ns | 0.4020 ns |  6.13 |    0.16 |
| BitConverter_GetBytes_UInt16      | .NET Framework 4.6.2 | 22.587 ns | 0.4549 ns | 0.3289 ns |  5.79 |    0.16 |
| BitConverter_GetBytes_Int16       | .NET Framework 4.6.2 | 22.421 ns | 0.4851 ns | 0.3508 ns |  5.74 |    0.15 |
| BigEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 |  6.647 ns | 0.1104 ns | 0.0657 ns |  1.70 |    0.03 |
| BigEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 |  7.632 ns | 0.1280 ns | 0.0846 ns |  1.96 |    0.05 |
| BigEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 |  6.684 ns | 0.1060 ns | 0.0631 ns |  1.71 |    0.04 |
| BigEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 |  6.750 ns | 0.1752 ns | 0.1639 ns |  1.73 |    0.04 |
| BigEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 |  4.263 ns | 0.1787 ns | 0.1671 ns |  1.09 |    0.04 |
| BigEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 |  4.055 ns | 0.0953 ns | 0.0498 ns |  1.04 |    0.02 |
| BigEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 |  2.593 ns | 0.1416 ns | 0.1325 ns |  0.67 |    0.04 |
| BigEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 |  2.527 ns | 0.0842 ns | 0.0501 ns |  0.65 |    0.02 |
| ExtensionMethod_ReadBytes_Double  | .NET Framework 4.6.2 |  6.456 ns | 0.1323 ns | 0.0788 ns |  1.65 |    0.04 |
| ExtensionMethod_ReadBytes_Float   | .NET Framework 4.6.2 |  8.509 ns | 0.5511 ns | 0.4885 ns |  2.20 |    0.13 |
| ExtensionMethod_ReadBytes_UInt64  | .NET Framework 4.6.2 |  7.595 ns | 0.3423 ns | 0.3035 ns |  1.97 |    0.10 |
| ExtensionMethod_ReadBytes_Int64   | .NET Framework 4.6.2 |  4.185 ns | 0.1198 ns | 0.0935 ns |  1.07 |    0.04 |
| ExtensionMethod_ReadBytes_UInt32  | .NET Framework 4.6.2 |  3.988 ns | 0.3560 ns | 0.3156 ns |  1.02 |    0.07 |
| ExtensionMethod_ReadBytes_Int32   | .NET Framework 4.6.2 |  2.909 ns | 0.0920 ns | 0.0609 ns |  0.75 |    0.02 |
| ExtensionMethod_ReadBytes_UInt16  | .NET Framework 4.6.2 |  2.527 ns | 0.0645 ns | 0.0426 ns |  0.65 |    0.01 |
| ExtensionMethod_ReadBytes_Int16   | .NET Framework 4.6.2 |  2.341 ns | 0.0634 ns | 0.0332 ns |  0.60 |    0.01 |

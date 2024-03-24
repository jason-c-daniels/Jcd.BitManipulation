```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-FWIUQP : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-NXBAGE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                            | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|-----------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double      | .NET 8.0             |  4.471 ns | 0.1905 ns | 0.1688 ns |  1.14 |    0.06 |
| BitConverter_GetBytes_Float       | .NET 8.0             |  4.430 ns | 0.2762 ns | 0.2583 ns |  1.13 |    0.06 |
| BitConverter_GetBytes_UInt64      | .NET 8.0             |  3.930 ns | 0.1320 ns | 0.1170 ns |  1.00 |    0.03 |
| BitConverter_GetBytes_Int64       | .NET 8.0             |  3.998 ns | 0.1606 ns | 0.1424 ns |  1.02 |    0.05 |
| BitConverter_GetBytes_UInt32      | .NET 8.0             |  4.115 ns | 0.1347 ns | 0.1260 ns |  1.05 |    0.03 |
| BitConverter_GetBytes_Int32       | .NET 8.0             |  3.918 ns | 0.1563 ns | 0.1462 ns |  1.00 |    0.04 |
| BitConverter_GetBytes_UInt16      | .NET 8.0             |  3.965 ns | 0.1628 ns | 0.1523 ns |  1.01 |    0.05 |
| BitConverter_GetBytes_Int16       | .NET 8.0             |  3.935 ns | 0.1212 ns | 0.1074 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Double | .NET 8.0             |  6.393 ns | 0.1295 ns | 0.0770 ns |  1.63 |    0.04 |
| BigEndianByteIndexer_Slice_Float  | .NET 8.0             |  5.122 ns | 0.2283 ns | 0.2136 ns |  1.30 |    0.05 |
| BigEndianByteIndexer_Slice_UInt64 | .NET 8.0             |  6.609 ns | 0.2155 ns | 0.2016 ns |  1.68 |    0.05 |
| BigEndianByteIndexer_Slice_Int64  | .NET 8.0             |  6.210 ns | 0.1152 ns | 0.0762 ns |  1.58 |    0.05 |
| BigEndianByteIndexer_Slice_UInt32 | .NET 8.0             |  5.012 ns | 0.1924 ns | 0.1800 ns |  1.27 |    0.04 |
| BigEndianByteIndexer_Slice_Int32  | .NET 8.0             |  5.457 ns | 0.2669 ns | 0.2496 ns |  1.39 |    0.08 |
| BigEndianByteIndexer_Slice_UInt16 | .NET 8.0             |  3.936 ns | 0.1418 ns | 0.1327 ns |  1.00 |    0.05 |
| BigEndianByteIndexer_Slice_Int16  | .NET 8.0             |  3.626 ns | 0.0658 ns | 0.0391 ns |  0.92 |    0.03 |
| ExtensionMethod_ReadBytes_Double  | .NET 8.0             |  6.318 ns | 0.1457 ns | 0.0964 ns |  1.61 |    0.05 |
| ExtensionMethod_ReadBytes_Float   | .NET 8.0             |  5.033 ns | 0.1715 ns | 0.1604 ns |  1.28 |    0.06 |
| ExtensionMethod_ReadBytes_UInt64  | .NET 8.0             |  6.275 ns | 0.1762 ns | 0.1562 ns |  1.60 |    0.04 |
| ExtensionMethod_ReadBytes_Int64   | .NET 8.0             |  4.454 ns | 0.1334 ns | 0.1248 ns |  1.13 |    0.04 |
| ExtensionMethod_ReadBytes_UInt32  | .NET 8.0             |  4.544 ns | 0.2630 ns | 0.2460 ns |  1.16 |    0.06 |
| ExtensionMethod_ReadBytes_Int32   | .NET 8.0             |  3.783 ns | 0.1195 ns | 0.0790 ns |  0.96 |    0.03 |
| ExtensionMethod_ReadBytes_UInt16  | .NET 8.0             |  3.646 ns | 0.1137 ns | 0.0752 ns |  0.93 |    0.02 |
| ExtensionMethod_ReadBytes_Int16   | .NET 8.0             |  3.300 ns | 0.1716 ns | 0.1605 ns |  0.84 |    0.05 |
| BitConverter_GetBytes_Double      | .NET Framework 4.6.2 | 25.436 ns | 0.5510 ns | 0.4302 ns |  6.47 |    0.21 |
| BitConverter_GetBytes_Float       | .NET Framework 4.6.2 | 24.461 ns | 0.4887 ns | 0.3233 ns |  6.22 |    0.18 |
| BitConverter_GetBytes_UInt64      | .NET Framework 4.6.2 | 30.323 ns | 6.1884 ns | 5.7886 ns |  7.76 |    1.58 |
| BitConverter_GetBytes_Int64       | .NET Framework 4.6.2 | 26.418 ns | 0.8273 ns | 0.7739 ns |  6.73 |    0.27 |
| BitConverter_GetBytes_UInt32      | .NET Framework 4.6.2 | 25.015 ns | 1.2102 ns | 1.0728 ns |  6.36 |    0.34 |
| BitConverter_GetBytes_Int32       | .NET Framework 4.6.2 | 24.344 ns | 0.5160 ns | 0.4827 ns |  6.18 |    0.21 |
| BitConverter_GetBytes_UInt16      | .NET Framework 4.6.2 | 22.431 ns | 0.3433 ns | 0.2271 ns |  5.70 |    0.13 |
| BitConverter_GetBytes_Int16       | .NET Framework 4.6.2 | 22.482 ns | 0.1885 ns | 0.1247 ns |  5.71 |    0.16 |
| BigEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 |  6.720 ns | 0.1741 ns | 0.1259 ns |  1.71 |    0.05 |
| BigEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 |  7.728 ns | 0.1609 ns | 0.1064 ns |  1.96 |    0.06 |
| BigEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 |  7.316 ns | 0.1022 ns | 0.0608 ns |  1.86 |    0.05 |
| BigEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 |  7.231 ns | 0.1516 ns | 0.0902 ns |  1.84 |    0.04 |
| BigEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 |  4.043 ns | 0.0721 ns | 0.0477 ns |  1.03 |    0.03 |
| BigEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 |  4.064 ns | 0.0575 ns | 0.0380 ns |  1.03 |    0.02 |
| BigEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 |  2.918 ns | 0.0787 ns | 0.0520 ns |  0.74 |    0.03 |
| BigEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 |  2.850 ns | 0.0641 ns | 0.0424 ns |  0.72 |    0.02 |
| ExtensionMethod_ReadBytes_Double  | .NET Framework 4.6.2 |  6.690 ns | 0.1226 ns | 0.0730 ns |  1.70 |    0.05 |
| ExtensionMethod_ReadBytes_Float   | .NET Framework 4.6.2 |  7.850 ns | 0.1884 ns | 0.1121 ns |  2.00 |    0.06 |
| ExtensionMethod_ReadBytes_UInt64  | .NET Framework 4.6.2 |  6.784 ns | 0.0998 ns | 0.0660 ns |  1.72 |    0.03 |
| ExtensionMethod_ReadBytes_Int64   | .NET Framework 4.6.2 |  3.885 ns | 0.1130 ns | 0.0882 ns |  0.99 |    0.04 |
| ExtensionMethod_ReadBytes_UInt32  | .NET Framework 4.6.2 |  3.543 ns | 0.0792 ns | 0.0471 ns |  0.90 |    0.03 |
| ExtensionMethod_ReadBytes_Int32   | .NET Framework 4.6.2 |  2.705 ns | 0.0283 ns | 0.0168 ns |  0.69 |    0.02 |
| ExtensionMethod_ReadBytes_UInt16  | .NET Framework 4.6.2 |  2.463 ns | 0.0844 ns | 0.0610 ns |  0.62 |    0.02 |
| ExtensionMethod_ReadBytes_Int16   | .NET Framework 4.6.2 |  1.960 ns | 0.0662 ns | 0.0438 ns |  0.50 |    0.02 |

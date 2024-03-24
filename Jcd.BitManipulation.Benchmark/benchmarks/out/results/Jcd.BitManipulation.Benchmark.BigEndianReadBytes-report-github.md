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

| Method                            | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|-----------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double      | .NET 8.0             |  4.528 ns | 0.2671 ns | 0.2499 ns |  1.11 |    0.08 |
| BitConverter_GetBytes_Float       | .NET 8.0             |  3.809 ns | 0.1447 ns | 0.1283 ns |  0.93 |    0.04 |
| BitConverter_GetBytes_UInt64      | .NET 8.0             |  4.037 ns | 0.1962 ns | 0.1835 ns |  0.99 |    0.06 |
| BitConverter_GetBytes_Int64       | .NET 8.0             |  4.613 ns | 0.2277 ns | 0.2129 ns |  1.13 |    0.05 |
| BitConverter_GetBytes_UInt32      | .NET 8.0             |  4.115 ns | 0.0865 ns | 0.0572 ns |  1.00 |    0.03 |
| BitConverter_GetBytes_Int32       | .NET 8.0             |  4.010 ns | 0.1024 ns | 0.0678 ns |  0.97 |    0.02 |
| BitConverter_GetBytes_UInt16      | .NET 8.0             |  3.998 ns | 0.0799 ns | 0.0418 ns |  0.97 |    0.03 |
| BitConverter_GetBytes_Int16       | .NET 8.0             |  4.110 ns | 0.1210 ns | 0.1011 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Double | .NET 8.0             |  5.490 ns | 0.1028 ns | 0.0680 ns |  1.33 |    0.05 |
| BigEndianByteIndexer_Slice_Float  | .NET 8.0             |  5.998 ns | 0.2494 ns | 0.2083 ns |  1.46 |    0.07 |
| BigEndianByteIndexer_Slice_UInt64 | .NET 8.0             |  5.811 ns | 0.1332 ns | 0.0881 ns |  1.41 |    0.03 |
| BigEndianByteIndexer_Slice_Int64  | .NET 8.0             |  5.910 ns | 0.1286 ns | 0.0851 ns |  1.43 |    0.04 |
| BigEndianByteIndexer_Slice_UInt32 | .NET 8.0             |  4.220 ns | 0.1294 ns | 0.0935 ns |  1.02 |    0.03 |
| BigEndianByteIndexer_Slice_Int32  | .NET 8.0             |  4.356 ns | 0.1301 ns | 0.0861 ns |  1.06 |    0.04 |
| BigEndianByteIndexer_Slice_UInt16 | .NET 8.0             |  3.595 ns | 0.1168 ns | 0.1092 ns |  0.87 |    0.03 |
| BigEndianByteIndexer_Slice_Int16  | .NET 8.0             |  3.131 ns | 0.1021 ns | 0.0797 ns |  0.76 |    0.03 |
| ExtensionMethod_ReadBytes_Double  | .NET 8.0             |  5.696 ns | 0.1365 ns | 0.0903 ns |  1.38 |    0.04 |
| ExtensionMethod_ReadBytes_Float   | .NET 8.0             |  6.482 ns | 0.1023 ns | 0.0676 ns |  1.57 |    0.04 |
| ExtensionMethod_ReadBytes_UInt64  | .NET 8.0             |  5.413 ns | 0.1193 ns | 0.0789 ns |  1.31 |    0.04 |
| ExtensionMethod_ReadBytes_Int64   | .NET 8.0             |  4.803 ns | 0.1030 ns | 0.0681 ns |  1.16 |    0.03 |
| ExtensionMethod_ReadBytes_UInt32  | .NET 8.0             |  4.787 ns | 0.1343 ns | 0.0971 ns |  1.16 |    0.03 |
| ExtensionMethod_ReadBytes_Int32   | .NET 8.0             |  3.640 ns | 0.0919 ns | 0.0547 ns |  0.88 |    0.02 |
| ExtensionMethod_ReadBytes_UInt16  | .NET 8.0             |  3.560 ns | 0.1041 ns | 0.0923 ns |  0.86 |    0.03 |
| ExtensionMethod_ReadBytes_Int16   | .NET 8.0             |  3.171 ns | 0.1206 ns | 0.1069 ns |  0.77 |    0.02 |
| BitConverter_GetBytes_Double      | .NET Framework 4.6.2 | 24.306 ns | 0.2819 ns | 0.1474 ns |  5.89 |    0.16 |
| BitConverter_GetBytes_Float       | .NET Framework 4.6.2 | 23.403 ns | 0.5036 ns | 0.3932 ns |  5.69 |    0.17 |
| BitConverter_GetBytes_UInt64      | .NET Framework 4.6.2 | 24.285 ns | 0.4090 ns | 0.2705 ns |  5.88 |    0.17 |
| BitConverter_GetBytes_Int64       | .NET Framework 4.6.2 | 23.961 ns | 0.3999 ns | 0.2645 ns |  5.81 |    0.19 |
| BitConverter_GetBytes_UInt32      | .NET Framework 4.6.2 | 23.955 ns | 0.5497 ns | 0.5142 ns |  5.83 |    0.17 |
| BitConverter_GetBytes_Int32       | .NET Framework 4.6.2 | 23.364 ns | 0.5130 ns | 0.4284 ns |  5.69 |    0.16 |
| BitConverter_GetBytes_UInt16      | .NET Framework 4.6.2 | 22.083 ns | 0.7352 ns | 0.6517 ns |  5.38 |    0.22 |
| BitConverter_GetBytes_Int16       | .NET Framework 4.6.2 | 22.094 ns | 0.6433 ns | 0.6018 ns |  5.39 |    0.20 |
| BigEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 |  6.466 ns | 0.1574 ns | 0.1138 ns |  1.57 |    0.04 |
| BigEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 |  8.452 ns | 0.2173 ns | 0.1293 ns |  2.04 |    0.05 |
| BigEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 |  6.758 ns | 0.1694 ns | 0.1008 ns |  1.63 |    0.03 |
| BigEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 |  6.762 ns | 0.1189 ns | 0.0786 ns |  1.64 |    0.05 |
| BigEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 |  3.514 ns | 0.0827 ns | 0.0492 ns |  0.85 |    0.03 |
| BigEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 |  3.588 ns | 0.1359 ns | 0.1271 ns |  0.87 |    0.05 |
| BigEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 |  2.473 ns | 0.0934 ns | 0.0556 ns |  0.60 |    0.01 |
| BigEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 |  2.495 ns | 0.0854 ns | 0.0565 ns |  0.60 |    0.02 |
| ExtensionMethod_ReadBytes_Double  | .NET Framework 4.6.2 |  6.391 ns | 0.2377 ns | 0.2107 ns |  1.56 |    0.05 |
| ExtensionMethod_ReadBytes_Float   | .NET Framework 4.6.2 |  7.735 ns | 0.1462 ns | 0.0870 ns |  1.87 |    0.05 |
| ExtensionMethod_ReadBytes_UInt64  | .NET Framework 4.6.2 |  6.153 ns | 0.1750 ns | 0.1552 ns |  1.50 |    0.04 |
| ExtensionMethod_ReadBytes_Int64   | .NET Framework 4.6.2 |  3.607 ns | 0.0622 ns | 0.0412 ns |  0.87 |    0.03 |
| ExtensionMethod_ReadBytes_UInt32  | .NET Framework 4.6.2 |  3.249 ns | 0.0759 ns | 0.0452 ns |  0.78 |    0.02 |
| ExtensionMethod_ReadBytes_Int32   | .NET Framework 4.6.2 |  2.443 ns | 0.0912 ns | 0.0659 ns |  0.59 |    0.03 |
| ExtensionMethod_ReadBytes_UInt16  | .NET Framework 4.6.2 |  2.346 ns | 0.0662 ns | 0.0438 ns |  0.57 |    0.02 |
| ExtensionMethod_ReadBytes_Int16   | .NET Framework 4.6.2 |  2.028 ns | 0.0621 ns | 0.0370 ns |  0.49 |    0.02 |

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-EEUGLS : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-HWBWFM : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                            | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|-----------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double      | .NET 8.0             |  4.649 ns | 0.1748 ns | 0.1550 ns |  1.23 |    0.03 |
| BitConverter_GetBytes_Float       | .NET 8.0             |  4.886 ns | 0.0970 ns | 0.0642 ns |  1.28 |    0.03 |
| BitConverter_GetBytes_UInt64      | .NET 8.0             |  4.187 ns | 0.1003 ns | 0.0663 ns |  1.10 |    0.03 |
| BitConverter_GetBytes_Int64       | .NET 8.0             |  4.351 ns | 0.1305 ns | 0.1157 ns |  1.15 |    0.03 |
| BitConverter_GetBytes_UInt32      | .NET 8.0             |  4.011 ns | 0.0444 ns | 0.0232 ns |  1.05 |    0.01 |
| BitConverter_GetBytes_Int32       | .NET 8.0             |  4.180 ns | 0.0639 ns | 0.0380 ns |  1.10 |    0.02 |
| BitConverter_GetBytes_UInt16      | .NET 8.0             |  3.816 ns | 0.0551 ns | 0.0365 ns |  1.00 |    0.01 |
| BitConverter_GetBytes_Int16       | .NET 8.0             |  3.814 ns | 0.0727 ns | 0.0433 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Double | .NET 8.0             |  4.427 ns | 0.0727 ns | 0.0481 ns |  1.16 |    0.02 |
| BigEndianByteIndexer_Slice_Float  | .NET 8.0             |  4.067 ns | 0.0517 ns | 0.0307 ns |  1.07 |    0.01 |
| BigEndianByteIndexer_Slice_UInt64 | .NET 8.0             |  4.287 ns | 0.0615 ns | 0.0407 ns |  1.12 |    0.02 |
| BigEndianByteIndexer_Slice_Int64  | .NET 8.0             |  4.442 ns | 0.1134 ns | 0.0675 ns |  1.16 |    0.02 |
| BigEndianByteIndexer_Slice_UInt32 | .NET 8.0             |  4.334 ns | 0.1305 ns | 0.1089 ns |  1.13 |    0.02 |
| BigEndianByteIndexer_Slice_Int32  | .NET 8.0             |  4.360 ns | 0.0856 ns | 0.0566 ns |  1.14 |    0.02 |
| BigEndianByteIndexer_Slice_UInt16 | .NET 8.0             |  3.675 ns | 0.0408 ns | 0.0213 ns |  0.96 |    0.01 |
| BigEndianByteIndexer_Slice_Int16  | .NET 8.0             |  4.514 ns | 0.2195 ns | 0.2053 ns |  1.20 |    0.05 |
| ExtensionMethod_ReadBytes_Double  | .NET 8.0             |  4.727 ns | 0.1324 ns | 0.1174 ns |  1.25 |    0.05 |
| ExtensionMethod_ReadBytes_Float   | .NET 8.0             |  5.059 ns | 0.1642 ns | 0.1536 ns |  1.34 |    0.04 |
| ExtensionMethod_ReadBytes_UInt64  | .NET 8.0             |  4.867 ns | 0.1413 ns | 0.1252 ns |  1.27 |    0.05 |
| ExtensionMethod_ReadBytes_Int64   | .NET 8.0             |  5.350 ns | 0.1428 ns | 0.0850 ns |  1.40 |    0.02 |
| ExtensionMethod_ReadBytes_UInt32  | .NET 8.0             |  4.503 ns | 0.1304 ns | 0.1156 ns |  1.18 |    0.04 |
| ExtensionMethod_ReadBytes_Int32   | .NET 8.0             |  4.129 ns | 0.1756 ns | 0.1643 ns |  1.09 |    0.06 |
| ExtensionMethod_ReadBytes_UInt16  | .NET 8.0             |  4.025 ns | 0.1178 ns | 0.1045 ns |  1.06 |    0.02 |
| ExtensionMethod_ReadBytes_Int16   | .NET 8.0             |  3.522 ns | 0.1509 ns | 0.1411 ns |  0.93 |    0.04 |
| BitConverter_GetBytes_Double      | .NET Framework 4.6.2 | 27.569 ns | 0.7527 ns | 0.7041 ns |  7.24 |    0.21 |
| BitConverter_GetBytes_Float       | .NET Framework 4.6.2 | 26.264 ns | 0.5461 ns | 0.4560 ns |  6.90 |    0.14 |
| BitConverter_GetBytes_UInt64      | .NET Framework 4.6.2 | 28.079 ns | 0.8291 ns | 0.7755 ns |  7.40 |    0.24 |
| BitConverter_GetBytes_Int64       | .NET Framework 4.6.2 | 27.226 ns | 0.5902 ns | 0.4268 ns |  7.17 |    0.11 |
| BitConverter_GetBytes_UInt32      | .NET Framework 4.6.2 | 23.805 ns | 0.1800 ns | 0.1071 ns |  6.24 |    0.08 |
| BitConverter_GetBytes_Int32       | .NET Framework 4.6.2 | 24.081 ns | 0.2393 ns | 0.1583 ns |  6.31 |    0.07 |
| BitConverter_GetBytes_UInt16      | .NET Framework 4.6.2 | 23.096 ns | 0.5058 ns | 0.3657 ns |  6.04 |    0.10 |
| BitConverter_GetBytes_Int16       | .NET Framework 4.6.2 | 23.714 ns | 0.4834 ns | 0.4522 ns |  6.24 |    0.16 |
| BigEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 |  6.622 ns | 0.0646 ns | 0.0338 ns |  1.73 |    0.01 |
| BigEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 |  7.694 ns | 0.1575 ns | 0.1041 ns |  2.01 |    0.03 |
| BigEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 |  7.318 ns | 0.0488 ns | 0.0291 ns |  1.92 |    0.03 |
| BigEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 |  7.276 ns | 0.0655 ns | 0.0342 ns |  1.91 |    0.03 |
| BigEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 |  4.073 ns | 0.0441 ns | 0.0292 ns |  1.07 |    0.01 |
| BigEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 |  4.035 ns | 0.0426 ns | 0.0282 ns |  1.06 |    0.01 |
| BigEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 |  2.839 ns | 0.0686 ns | 0.0454 ns |  0.75 |    0.02 |
| BigEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 |  2.938 ns | 0.0672 ns | 0.0400 ns |  0.77 |    0.02 |
| ExtensionMethod_ReadBytes_Double  | .NET Framework 4.6.2 |  6.602 ns | 0.0954 ns | 0.0568 ns |  1.73 |    0.02 |
| ExtensionMethod_ReadBytes_Float   | .NET Framework 4.6.2 |  8.055 ns | 0.1424 ns | 0.0942 ns |  2.11 |    0.04 |
| ExtensionMethod_ReadBytes_UInt64  | .NET Framework 4.6.2 |  7.249 ns | 0.1145 ns | 0.0682 ns |  1.90 |    0.02 |
| ExtensionMethod_ReadBytes_Int64   | .NET Framework 4.6.2 |  4.114 ns | 0.0560 ns | 0.0370 ns |  1.08 |    0.01 |
| ExtensionMethod_ReadBytes_UInt32  | .NET Framework 4.6.2 |  4.112 ns | 0.0394 ns | 0.0234 ns |  1.08 |    0.01 |
| ExtensionMethod_ReadBytes_Int32   | .NET Framework 4.6.2 |  3.175 ns | 0.0442 ns | 0.0263 ns |  0.83 |    0.01 |
| ExtensionMethod_ReadBytes_UInt16  | .NET Framework 4.6.2 |  2.869 ns | 0.0284 ns | 0.0188 ns |  0.75 |    0.01 |
| ExtensionMethod_ReadBytes_Int16   | .NET Framework 4.6.2 |  2.200 ns | 0.0268 ns | 0.0159 ns |  0.58 |    0.01 |

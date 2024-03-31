```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-LRLIBL : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-MDTRPR : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                                | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|---------------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double          | .NET 8.0             |  4.635 ns | 0.5473 ns | 0.5119 ns |  1.24 |    0.09 |
| BitConverter_GetBytes_Float           | .NET 8.0             |  5.228 ns | 0.7212 ns | 0.6393 ns |  1.41 |    0.12 |
| BitConverter_GetBytes_UInt64          | .NET 8.0             |  4.358 ns | 0.3530 ns | 0.3129 ns |  1.25 |    0.09 |
| BitConverter_GetBytes_Int64           | .NET 8.0             |  4.450 ns | 0.1337 ns | 0.1116 ns |  1.25 |    0.03 |
| BitConverter_GetBytes_UInt32          | .NET 8.0             |  4.735 ns | 0.1353 ns | 0.0707 ns |  1.32 |    0.03 |
| BitConverter_GetBytes_Int32           | .NET 8.0             |  4.125 ns | 0.0492 ns | 0.0325 ns |  1.15 |    0.02 |
| BitConverter_GetBytes_UInt16          | .NET 8.0             |  3.896 ns | 0.0523 ns | 0.0312 ns |  1.09 |    0.01 |
| BitConverter_GetBytes_Int16           | .NET 8.0             |  4.024 ns | 0.0808 ns | 0.0535 ns |  1.12 |    0.03 |
| BigEndianByteIndexer_Slice_Double     | .NET 8.0             |  3.517 ns | 0.0444 ns | 0.0294 ns |  0.98 |    0.02 |
| BigEndianByteIndexer_Slice_Float      | .NET 8.0             |  3.283 ns | 0.0685 ns | 0.0408 ns |  0.92 |    0.02 |
| BigEndianByteIndexer_Slice_UInt64     | .NET 8.0             |  3.580 ns | 0.0916 ns | 0.0606 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Int64      | .NET 8.0             |  3.403 ns | 0.0354 ns | 0.0211 ns |  0.95 |    0.02 |
| BigEndianByteIndexer_Slice_UInt32     | .NET 8.0             |  3.261 ns | 0.0481 ns | 0.0318 ns |  0.91 |    0.02 |
| BigEndianByteIndexer_Slice_Int32      | .NET 8.0             |  3.429 ns | 0.0505 ns | 0.0334 ns |  0.96 |    0.02 |
| BigEndianByteIndexer_Slice_UInt16     | .NET 8.0             |  3.311 ns | 0.0537 ns | 0.0355 ns |  0.93 |    0.02 |
| BigEndianByteIndexer_Slice_Int16      | .NET 8.0             |  3.363 ns | 0.0562 ns | 0.0372 ns |  0.94 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET 8.0             |  3.625 ns | 0.0662 ns | 0.0394 ns |  1.01 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET 8.0             |  3.301 ns | 0.0481 ns | 0.0318 ns |  0.92 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET 8.0             |  3.635 ns | 0.0872 ns | 0.0576 ns |  1.02 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET 8.0             |  5.030 ns | 0.0858 ns | 0.0568 ns |  1.41 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET 8.0             |  3.401 ns | 0.0375 ns | 0.0248 ns |  0.95 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET 8.0             |  3.842 ns | 0.0475 ns | 0.0314 ns |  1.07 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET 8.0             |  3.744 ns | 0.4809 ns | 0.4498 ns |  1.10 |    0.13 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET 8.0             |  3.395 ns | 0.0549 ns | 0.0363 ns |  0.95 |    0.02 |
| BitConverter_GetBytes_Double          | .NET Framework 4.6.2 | 25.082 ns | 0.3286 ns | 0.2174 ns |  7.01 |    0.12 |
| BitConverter_GetBytes_Float           | .NET Framework 4.6.2 | 23.202 ns | 0.1051 ns | 0.0626 ns |  6.47 |    0.10 |
| BitConverter_GetBytes_UInt64          | .NET Framework 4.6.2 | 24.875 ns | 0.1977 ns | 0.1308 ns |  6.95 |    0.12 |
| BitConverter_GetBytes_Int64           | .NET Framework 4.6.2 | 24.970 ns | 0.1684 ns | 0.1002 ns |  6.96 |    0.11 |
| BitConverter_GetBytes_UInt32          | .NET Framework 4.6.2 | 23.181 ns | 0.2121 ns | 0.1403 ns |  6.48 |    0.11 |
| BitConverter_GetBytes_Int32           | .NET Framework 4.6.2 | 23.485 ns | 0.2213 ns | 0.1317 ns |  6.54 |    0.09 |
| BitConverter_GetBytes_UInt16          | .NET Framework 4.6.2 | 22.435 ns | 0.2981 ns | 0.1972 ns |  6.27 |    0.13 |
| BitConverter_GetBytes_Int16           | .NET Framework 4.6.2 | 22.148 ns | 0.1185 ns | 0.0784 ns |  6.19 |    0.10 |
| BigEndianByteIndexer_Slice_Double     | .NET Framework 4.6.2 |  8.217 ns | 0.0536 ns | 0.0319 ns |  2.29 |    0.04 |
| BigEndianByteIndexer_Slice_Float      | .NET Framework 4.6.2 |  8.925 ns | 0.0849 ns | 0.0562 ns |  2.49 |    0.05 |
| BigEndianByteIndexer_Slice_UInt64     | .NET Framework 4.6.2 |  7.894 ns | 0.0807 ns | 0.0534 ns |  2.21 |    0.04 |
| BigEndianByteIndexer_Slice_Int64      | .NET Framework 4.6.2 |  7.905 ns | 0.0995 ns | 0.0658 ns |  2.21 |    0.04 |
| BigEndianByteIndexer_Slice_UInt32     | .NET Framework 4.6.2 |  4.886 ns | 0.0803 ns | 0.0420 ns |  1.36 |    0.03 |
| BigEndianByteIndexer_Slice_Int32      | .NET Framework 4.6.2 |  4.851 ns | 0.0280 ns | 0.0186 ns |  1.36 |    0.02 |
| BigEndianByteIndexer_Slice_UInt16     | .NET Framework 4.6.2 |  4.001 ns | 0.0262 ns | 0.0174 ns |  1.12 |    0.02 |
| BigEndianByteIndexer_Slice_Int16      | .NET Framework 4.6.2 |  4.067 ns | 0.0823 ns | 0.0545 ns |  1.14 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET Framework 4.6.2 |  8.199 ns | 0.1074 ns | 0.0639 ns |  2.28 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET Framework 4.6.2 |  9.126 ns | 0.1425 ns | 0.0943 ns |  2.55 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET Framework 4.6.2 |  8.165 ns | 0.1155 ns | 0.0764 ns |  2.28 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET Framework 4.6.2 |  4.673 ns | 0.1176 ns | 0.0778 ns |  1.31 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET Framework 4.6.2 |  5.189 ns | 0.0575 ns | 0.0342 ns |  1.45 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET Framework 4.6.2 |  3.781 ns | 0.0561 ns | 0.0371 ns |  1.06 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET Framework 4.6.2 |  4.680 ns | 0.0497 ns | 0.0329 ns |  1.31 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET Framework 4.6.2 |  2.912 ns | 0.1474 ns | 0.1378 ns |  0.82 |    0.04 |

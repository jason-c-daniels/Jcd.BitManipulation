```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-CXBWXK : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-SUYWZE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```
| Method                                | Runtime              | Mean      | Error     | StdDev    | Ratio | RatioSD |
|-------------------------------------- |--------------------- |----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double          | .NET 8.0             |  4.558 ns | 0.2966 ns | 0.2629 ns |  1.16 |    0.07 |
| BitConverter_GetBytes_Float           | .NET 8.0             |  4.339 ns | 0.1260 ns | 0.0911 ns |  1.12 |    0.04 |
| BitConverter_GetBytes_UInt64          | .NET 8.0             |  4.519 ns | 0.1657 ns | 0.1550 ns |  1.18 |    0.05 |
| BitConverter_GetBytes_Int64           | .NET 8.0             |  4.513 ns | 0.2354 ns | 0.2202 ns |  1.16 |    0.07 |
| BitConverter_GetBytes_UInt32          | .NET 8.0             |  4.054 ns | 0.1692 ns | 0.1582 ns |  1.06 |    0.05 |
| BitConverter_GetBytes_Int32           | .NET 8.0             |  4.361 ns | 0.1648 ns | 0.1542 ns |  1.13 |    0.05 |
| BitConverter_GetBytes_UInt16          | .NET 8.0             |  4.125 ns | 0.1212 ns | 0.0802 ns |  1.07 |    0.03 |
| BitConverter_GetBytes_Int16           | .NET 8.0             |  4.140 ns | 0.1174 ns | 0.1041 ns |  1.06 |    0.03 |
| BigEndianByteIndexer_Slice_Double     | .NET 8.0             |  3.769 ns | 0.1127 ns | 0.0880 ns |  0.97 |    0.03 |
| BigEndianByteIndexer_Slice_Float      | .NET 8.0             |  3.498 ns | 0.1623 ns | 0.1518 ns |  0.89 |    0.03 |
| BigEndianByteIndexer_Slice_UInt64     | .NET 8.0             |  3.873 ns | 0.1140 ns | 0.0678 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Int64      | .NET 8.0             |  3.914 ns | 0.1673 ns | 0.1565 ns |  0.99 |    0.04 |
| BigEndianByteIndexer_Slice_UInt32     | .NET 8.0             |  3.485 ns | 0.1396 ns | 0.1237 ns |  0.90 |    0.04 |
| BigEndianByteIndexer_Slice_Int32      | .NET 8.0             |  3.420 ns | 0.1205 ns | 0.1006 ns |  0.88 |    0.04 |
| BigEndianByteIndexer_Slice_UInt16     | .NET 8.0             |  3.400 ns | 0.2072 ns | 0.1837 ns |  0.86 |    0.03 |
| BigEndianByteIndexer_Slice_Int16      | .NET 8.0             |  3.551 ns | 0.1712 ns | 0.1602 ns |  0.91 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET 8.0             |  4.034 ns | 0.2743 ns | 0.2566 ns |  1.05 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET 8.0             |  3.672 ns | 0.1327 ns | 0.1108 ns |  0.94 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET 8.0             |  3.802 ns | 0.2491 ns | 0.2330 ns |  0.99 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET 8.0             |  5.396 ns | 0.2734 ns | 0.2557 ns |  1.41 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET 8.0             |  3.519 ns | 0.1520 ns | 0.1422 ns |  0.91 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET 8.0             |  4.175 ns | 0.1914 ns | 0.1790 ns |  1.07 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET 8.0             |  4.081 ns | 0.3654 ns | 0.3418 ns |  1.05 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET 8.0             |  4.411 ns | 0.4739 ns | 0.4433 ns |  1.11 |    0.12 |
| BitConverter_GetBytes_Double          | .NET Framework 4.6.2 | 27.221 ns | 2.2422 ns | 2.0973 ns |  7.31 |    0.62 |
| BitConverter_GetBytes_Float           | .NET Framework 4.6.2 | 24.229 ns | 0.4562 ns | 0.2715 ns |  6.26 |    0.15 |
| BitConverter_GetBytes_UInt64          | .NET Framework 4.6.2 | 27.204 ns | 1.4865 ns | 1.3177 ns |  7.12 |    0.37 |
| BitConverter_GetBytes_Int64           | .NET Framework 4.6.2 | 25.626 ns | 0.4536 ns | 0.2699 ns |  6.62 |    0.18 |
| BitConverter_GetBytes_UInt32          | .NET Framework 4.6.2 | 23.400 ns | 0.4511 ns | 0.2685 ns |  6.04 |    0.13 |
| BitConverter_GetBytes_Int32           | .NET Framework 4.6.2 | 23.699 ns | 0.5246 ns | 0.4650 ns |  6.13 |    0.14 |
| BitConverter_GetBytes_UInt16          | .NET Framework 4.6.2 | 25.028 ns | 2.2302 ns | 2.0861 ns |  6.37 |    0.54 |
| BitConverter_GetBytes_Int16           | .NET Framework 4.6.2 | 22.569 ns | 0.3606 ns | 0.2385 ns |  5.82 |    0.11 |
| BigEndianByteIndexer_Slice_Double     | .NET Framework 4.6.2 |  8.084 ns | 0.1395 ns | 0.0830 ns |  2.09 |    0.04 |
| BigEndianByteIndexer_Slice_Float      | .NET Framework 4.6.2 |  8.778 ns | 0.1312 ns | 0.0686 ns |  2.27 |    0.05 |
| BigEndianByteIndexer_Slice_UInt64     | .NET Framework 4.6.2 |  8.176 ns | 0.1991 ns | 0.1440 ns |  2.12 |    0.03 |
| BigEndianByteIndexer_Slice_Int64      | .NET Framework 4.6.2 |  8.825 ns | 0.7723 ns | 0.7224 ns |  2.19 |    0.15 |
| BigEndianByteIndexer_Slice_UInt32     | .NET Framework 4.6.2 |  5.483 ns | 0.4522 ns | 0.4008 ns |  1.43 |    0.11 |
| BigEndianByteIndexer_Slice_Int32      | .NET Framework 4.6.2 |  5.503 ns | 0.2196 ns | 0.1715 ns |  1.42 |    0.06 |
| BigEndianByteIndexer_Slice_UInt16     | .NET Framework 4.6.2 |  3.976 ns | 0.1235 ns | 0.0735 ns |  1.03 |    0.02 |
| BigEndianByteIndexer_Slice_Int16      | .NET Framework 4.6.2 |  4.153 ns | 0.1803 ns | 0.1598 ns |  1.07 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET Framework 4.6.2 |  8.140 ns | 0.1074 ns | 0.0562 ns |  2.10 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET Framework 4.6.2 |  8.847 ns | 0.1673 ns | 0.1107 ns |  2.28 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET Framework 4.6.2 |  8.021 ns | 0.1855 ns | 0.1549 ns |  2.07 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET Framework 4.6.2 |  4.967 ns | 0.0732 ns | 0.0484 ns |  1.28 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET Framework 4.6.2 |  4.933 ns | 0.0949 ns | 0.0628 ns |  1.28 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET Framework 4.6.2 |  3.808 ns | 0.1370 ns | 0.1281 ns |  0.99 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET Framework 4.6.2 |  4.142 ns | 0.0843 ns | 0.0557 ns |  1.07 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET Framework 4.6.2 |  3.293 ns | 0.0347 ns | 0.0207 ns |  0.85 |    0.01 |

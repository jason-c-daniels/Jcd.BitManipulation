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
| BitConverter_GetBytes_Double          | .NET 8.0             |  3.427 ns | 0.1344 ns | 0.1258 ns |  0.88 |    0.03 |
| BitConverter_GetBytes_Float           | .NET 8.0             |  3.484 ns | 0.1680 ns | 0.1571 ns |  0.90 |    0.05 |
| BitConverter_GetBytes_UInt64          | .NET 8.0             |  3.246 ns | 0.0891 ns | 0.0644 ns |  0.83 |    0.03 |
| BitConverter_GetBytes_Int64           | .NET 8.0             |  3.323 ns | 0.2237 ns | 0.2092 ns |  0.86 |    0.06 |
| BitConverter_GetBytes_UInt32          | .NET 8.0             |  3.337 ns | 0.2369 ns | 0.2100 ns |  0.86 |    0.06 |
| BitConverter_GetBytes_Int32           | .NET 8.0             |  3.211 ns | 0.1084 ns | 0.0784 ns |  0.82 |    0.04 |
| BitConverter_GetBytes_UInt16          | .NET 8.0             |  3.298 ns | 0.1056 ns | 0.0936 ns |  0.85 |    0.05 |
| BitConverter_GetBytes_Int16           | .NET 8.0             |  3.290 ns | 0.1328 ns | 0.1243 ns |  0.85 |    0.06 |
| LittleEndianByteIndexer_Slice_Double  | .NET 8.0             |  4.068 ns | 0.1540 ns | 0.1365 ns |  1.05 |    0.05 |
| LittleEndianByteIndexer_Slice_Float   | .NET 8.0             |  3.847 ns | 0.2133 ns | 0.1891 ns |  0.99 |    0.07 |
| LittleEndianByteIndexer_Slice_UInt64  | .NET 8.0             |  3.889 ns | 0.2029 ns | 0.1898 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Int64   | .NET 8.0             |  3.779 ns | 0.1718 ns | 0.1607 ns |  0.97 |    0.05 |
| LittleEndianByteIndexer_Slice_UInt32  | .NET 8.0             |  3.726 ns | 0.1838 ns | 0.1720 ns |  0.96 |    0.06 |
| LittleEndianByteIndexer_Slice_Int32   | .NET 8.0             |  3.768 ns | 0.1128 ns | 0.0746 ns |  0.96 |    0.04 |
| LittleEndianByteIndexer_Slice_UInt16  | .NET 8.0             |  3.533 ns | 0.0751 ns | 0.0447 ns |  0.90 |    0.04 |
| LittleEndianByteIndexer_Slice_Int16   | .NET 8.0             |  3.585 ns | 0.1141 ns | 0.0891 ns |  0.92 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET 8.0             |  3.931 ns | 0.1680 ns | 0.1403 ns |  1.01 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET 8.0             |  3.569 ns | 0.1827 ns | 0.1709 ns |  0.92 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET 8.0             |  3.991 ns | 0.1228 ns | 0.0813 ns |  1.02 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET 8.0             |  4.612 ns | 0.1369 ns | 0.1213 ns |  1.19 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET 8.0             |  3.664 ns | 0.1173 ns | 0.1040 ns |  0.94 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET 8.0             |  3.989 ns | 0.1062 ns | 0.0632 ns |  1.01 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET 8.0             |  3.314 ns | 0.1084 ns | 0.0784 ns |  0.84 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET 8.0             |  3.652 ns | 0.3489 ns | 0.3264 ns |  0.94 |    0.08 |
| BitConverter_GetBytes_Double          | .NET Framework 4.6.2 |  4.227 ns | 0.0659 ns | 0.0436 ns |  1.08 |    0.06 |
| BitConverter_GetBytes_Float           | .NET Framework 4.6.2 |  3.732 ns | 0.1205 ns | 0.1006 ns |  0.96 |    0.06 |
| BitConverter_GetBytes_UInt64          | .NET Framework 4.6.2 |  4.219 ns | 0.0796 ns | 0.0526 ns |  1.07 |    0.05 |
| BitConverter_GetBytes_Int64           | .NET Framework 4.6.2 |  4.039 ns | 0.0810 ns | 0.0482 ns |  1.03 |    0.05 |
| BitConverter_GetBytes_UInt32          | .NET Framework 4.6.2 |  3.687 ns | 0.1115 ns | 0.0871 ns |  0.95 |    0.05 |
| BitConverter_GetBytes_Int32           | .NET Framework 4.6.2 |  3.657 ns | 0.0909 ns | 0.0541 ns |  0.93 |    0.04 |
| BitConverter_GetBytes_UInt16          | .NET Framework 4.6.2 |  3.783 ns | 0.1080 ns | 0.0714 ns |  0.96 |    0.05 |
| BitConverter_GetBytes_Int16           | .NET Framework 4.6.2 |  3.786 ns | 0.1082 ns | 0.0845 ns |  0.97 |    0.05 |
| LittleEndianByteIndexer_Slice_Double  | .NET Framework 4.6.2 |  5.534 ns | 0.1507 ns | 0.1090 ns |  1.41 |    0.06 |
| LittleEndianByteIndexer_Slice_Float   | .NET Framework 4.6.2 |  8.270 ns | 0.1946 ns | 0.1287 ns |  2.11 |    0.12 |
| LittleEndianByteIndexer_Slice_UInt64  | .NET Framework 4.6.2 |  5.218 ns | 0.1339 ns | 0.0886 ns |  1.33 |    0.07 |
| LittleEndianByteIndexer_Slice_Int64   | .NET Framework 4.6.2 |  5.272 ns | 0.1412 ns | 0.1179 ns |  1.36 |    0.06 |
| LittleEndianByteIndexer_Slice_UInt32  | .NET Framework 4.6.2 |  4.629 ns | 0.0537 ns | 0.0355 ns |  1.18 |    0.05 |
| LittleEndianByteIndexer_Slice_Int32   | .NET Framework 4.6.2 |  4.503 ns | 0.0455 ns | 0.0301 ns |  1.15 |    0.05 |
| LittleEndianByteIndexer_Slice_UInt16  | .NET Framework 4.6.2 |  4.358 ns | 0.1086 ns | 0.0785 ns |  1.11 |    0.06 |
| LittleEndianByteIndexer_Slice_Int16   | .NET Framework 4.6.2 |  4.288 ns | 0.0912 ns | 0.0543 ns |  1.09 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET Framework 4.6.2 |  5.625 ns | 0.1726 ns | 0.1530 ns |  1.45 |    0.09 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET Framework 4.6.2 | 12.203 ns | 0.2375 ns | 0.1571 ns |  3.11 |    0.16 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET Framework 4.6.2 |  5.581 ns | 0.1407 ns | 0.1018 ns |  1.42 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET Framework 4.6.2 |  4.965 ns | 0.0741 ns | 0.0387 ns |  1.27 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET Framework 4.6.2 |  4.436 ns | 0.1230 ns | 0.0814 ns |  1.13 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET Framework 4.6.2 |  3.947 ns | 0.0968 ns | 0.0808 ns |  1.02 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET Framework 4.6.2 |  4.219 ns | 0.1495 ns | 0.1398 ns |  1.09 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET Framework 4.6.2 |  3.556 ns | 0.1070 ns | 0.1001 ns |  0.92 |    0.05 |

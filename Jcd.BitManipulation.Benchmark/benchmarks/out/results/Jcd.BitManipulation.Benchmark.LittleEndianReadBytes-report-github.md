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

| Method                               | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double         | .NET 8.0             | 3.285 ns | 0.1404 ns | 0.1313 ns |  1.10 |    0.06 |
| BitConverter_GetBytes_Float          | .NET 8.0             | 3.208 ns | 0.1400 ns | 0.1310 ns |  1.08 |    0.06 |
| BitConverter_GetBytes_UInt64         | .NET 8.0             | 2.946 ns | 0.1450 ns | 0.1356 ns |  0.99 |    0.07 |
| BitConverter_GetBytes_Int64          | .NET 8.0             | 3.031 ns | 0.1086 ns | 0.1016 ns |  1.02 |    0.03 |
| BitConverter_GetBytes_UInt32         | .NET 8.0             | 3.026 ns | 0.1334 ns | 0.1248 ns |  1.02 |    0.06 |
| BitConverter_GetBytes_Int32          | .NET 8.0             | 2.941 ns | 0.1313 ns | 0.1228 ns |  0.99 |    0.04 |
| BitConverter_GetBytes_UInt16         | .NET 8.0             | 3.008 ns | 0.1420 ns | 0.1328 ns |  1.01 |    0.06 |
| BitConverter_GetBytes_Int16          | .NET 8.0             | 2.977 ns | 0.1126 ns | 0.1053 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Double | .NET 8.0             | 6.025 ns | 0.2396 ns | 0.2242 ns |  2.03 |    0.11 |
| LittleEndianByteIndexer_Slice_Float  | .NET 8.0             | 4.364 ns | 0.1830 ns | 0.1622 ns |  1.47 |    0.08 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET 8.0             | 5.778 ns | 0.1602 ns | 0.1158 ns |  1.92 |    0.07 |
| LittleEndianByteIndexer_Slice_Int64  | .NET 8.0             | 6.161 ns | 0.6237 ns | 0.4869 ns |  2.06 |    0.17 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET 8.0             | 4.678 ns | 0.3660 ns | 0.3245 ns |  1.58 |    0.12 |
| LittleEndianByteIndexer_Slice_Int32  | .NET 8.0             | 4.273 ns | 0.1144 ns | 0.0757 ns |  1.43 |    0.05 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET 8.0             | 3.584 ns | 0.1577 ns | 0.1475 ns |  1.21 |    0.07 |
| LittleEndianByteIndexer_Slice_Int16  | .NET 8.0             | 3.689 ns | 0.1326 ns | 0.1176 ns |  1.24 |    0.06 |
| ExtensionMethod_ReadBytes_Double     | .NET 8.0             | 6.625 ns | 0.2076 ns | 0.1942 ns |  2.23 |    0.09 |
| ExtensionMethod_ReadBytes_Float      | .NET 8.0             | 4.223 ns | 0.1906 ns | 0.1690 ns |  1.42 |    0.08 |
| ExtensionMethod_ReadBytes_UInt64     | .NET 8.0             | 6.162 ns | 0.2655 ns | 0.2217 ns |  2.07 |    0.10 |
| ExtensionMethod_ReadBytes_Int64      | .NET 8.0             | 4.870 ns | 0.1462 ns | 0.0967 ns |  1.63 |    0.07 |
| ExtensionMethod_ReadBytes_UInt32     | .NET 8.0             | 4.099 ns | 0.1795 ns | 0.1679 ns |  1.38 |    0.08 |
| ExtensionMethod_ReadBytes_Int32      | .NET 8.0             | 4.431 ns | 0.7332 ns | 0.6858 ns |  1.49 |    0.24 |
| ExtensionMethod_ReadBytes_UInt16     | .NET 8.0             | 3.708 ns | 0.1212 ns | 0.1134 ns |  1.25 |    0.04 |
| ExtensionMethod_ReadBytes_Int16      | .NET 8.0             | 3.384 ns | 0.1276 ns | 0.1194 ns |  1.14 |    0.04 |
| BitConverter_GetBytes_Double         | .NET Framework 4.6.2 | 4.181 ns | 0.1609 ns | 0.1426 ns |  1.41 |    0.07 |
| BitConverter_GetBytes_Float          | .NET Framework 4.6.2 | 3.876 ns | 0.1886 ns | 0.1764 ns |  1.30 |    0.07 |
| BitConverter_GetBytes_UInt64         | .NET Framework 4.6.2 | 4.220 ns | 0.2907 ns | 0.2427 ns |  1.42 |    0.10 |
| BitConverter_GetBytes_Int64          | .NET Framework 4.6.2 | 4.096 ns | 0.0957 ns | 0.0570 ns |  1.36 |    0.04 |
| BitConverter_GetBytes_UInt32         | .NET Framework 4.6.2 | 3.995 ns | 0.2499 ns | 0.2338 ns |  1.34 |    0.08 |
| BitConverter_GetBytes_Int32          | .NET Framework 4.6.2 | 3.651 ns | 0.1169 ns | 0.0773 ns |  1.22 |    0.05 |
| BitConverter_GetBytes_UInt16         | .NET Framework 4.6.2 | 3.774 ns | 0.1362 ns | 0.1274 ns |  1.27 |    0.06 |
| BitConverter_GetBytes_Int16          | .NET Framework 4.6.2 | 3.816 ns | 0.1340 ns | 0.1119 ns |  1.28 |    0.06 |
| LittleEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 | 6.604 ns | 0.2704 ns | 0.2529 ns |  2.22 |    0.09 |
| LittleEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 | 7.922 ns | 0.1917 ns | 0.1268 ns |  2.64 |    0.08 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 | 6.030 ns | 0.2264 ns | 0.2007 ns |  2.03 |    0.11 |
| LittleEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 | 6.023 ns | 0.0934 ns | 0.0618 ns |  2.01 |    0.06 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 | 3.581 ns | 0.0679 ns | 0.0449 ns |  1.19 |    0.03 |
| LittleEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 | 3.682 ns | 0.2652 ns | 0.2481 ns |  1.24 |    0.08 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 | 2.583 ns | 0.0508 ns | 0.0336 ns |  0.86 |    0.03 |
| LittleEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 | 2.473 ns | 0.1131 ns | 0.0944 ns |  0.83 |    0.05 |
| ExtensionMethod_ReadBytes_Double     | .NET Framework 4.6.2 | 6.395 ns | 0.1047 ns | 0.0693 ns |  2.13 |    0.06 |
| ExtensionMethod_ReadBytes_Float      | .NET Framework 4.6.2 | 7.955 ns | 0.1297 ns | 0.0772 ns |  2.65 |    0.10 |
| ExtensionMethod_ReadBytes_UInt64     | .NET Framework 4.6.2 | 6.051 ns | 0.1501 ns | 0.0893 ns |  2.01 |    0.07 |
| ExtensionMethod_ReadBytes_Int64      | .NET Framework 4.6.2 | 3.633 ns | 0.0780 ns | 0.0516 ns |  1.21 |    0.04 |
| ExtensionMethod_ReadBytes_UInt32     | .NET Framework 4.6.2 | 3.564 ns | 0.0778 ns | 0.0515 ns |  1.19 |    0.04 |
| ExtensionMethod_ReadBytes_Int32      | .NET Framework 4.6.2 | 2.984 ns | 0.4164 ns | 0.3251 ns |  1.00 |    0.12 |
| ExtensionMethod_ReadBytes_UInt16     | .NET Framework 4.6.2 | 2.518 ns | 0.0506 ns | 0.0335 ns |  0.84 |    0.03 |
| ExtensionMethod_ReadBytes_Int16      | .NET Framework 4.6.2 | 1.939 ns | 0.0798 ns | 0.0528 ns |  0.65 |    0.03 |

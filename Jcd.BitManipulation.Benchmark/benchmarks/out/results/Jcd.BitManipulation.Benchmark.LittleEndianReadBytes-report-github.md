```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-VBQYBY : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-NFESSE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                                | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|---------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double          | .NET 8.0             | 3.981 ns | 0.2328 ns | 0.2177 ns |  0.81 |    0.06 |
| BitConverter_GetBytes_Float           | .NET 8.0             | 4.049 ns | 0.3236 ns | 0.2702 ns |  0.82 |    0.04 |
| BitConverter_GetBytes_UInt64          | .NET 8.0             | 4.166 ns | 0.2255 ns | 0.2110 ns |  0.84 |    0.04 |
| BitConverter_GetBytes_Int64           | .NET 8.0             | 4.082 ns | 0.1501 ns | 0.1404 ns |  0.83 |    0.04 |
| BitConverter_GetBytes_UInt32          | .NET 8.0             | 3.854 ns | 0.1675 ns | 0.1399 ns |  0.78 |    0.03 |
| BitConverter_GetBytes_Int32           | .NET 8.0             | 4.080 ns | 0.2650 ns | 0.2349 ns |  0.82 |    0.05 |
| BitConverter_GetBytes_UInt16          | .NET 8.0             | 4.606 ns | 0.7225 ns | 0.6759 ns |  0.93 |    0.12 |
| BitConverter_GetBytes_Int16           | .NET 8.0             | 3.893 ns | 0.3312 ns | 0.2766 ns |  0.79 |    0.06 |
| LittleEndianByteIndexer_Slice_Double  | .NET 8.0             | 5.179 ns | 0.3576 ns | 0.3170 ns |  1.05 |    0.08 |
| LittleEndianByteIndexer_Slice_Float   | .NET 8.0             | 4.562 ns | 0.3938 ns | 0.3684 ns |  0.92 |    0.08 |
| LittleEndianByteIndexer_Slice_UInt64  | .NET 8.0             | 4.942 ns | 0.1472 ns | 0.1377 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Int64   | .NET 8.0             | 5.318 ns | 0.3038 ns | 0.2693 ns |  1.07 |    0.06 |
| LittleEndianByteIndexer_Slice_UInt32  | .NET 8.0             | 4.425 ns | 0.3482 ns | 0.3257 ns |  0.90 |    0.07 |
| LittleEndianByteIndexer_Slice_Int32   | .NET 8.0             | 4.574 ns | 0.1306 ns | 0.1020 ns |  0.92 |    0.03 |
| LittleEndianByteIndexer_Slice_UInt16  | .NET 8.0             | 4.498 ns | 0.2376 ns | 0.2106 ns |  0.91 |    0.05 |
| LittleEndianByteIndexer_Slice_Int16   | .NET 8.0             | 4.568 ns | 0.1602 ns | 0.1498 ns |  0.93 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET 8.0             | 4.676 ns | 0.2981 ns | 0.2789 ns |  0.95 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET 8.0             | 4.061 ns | 0.2468 ns | 0.2187 ns |  0.82 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET 8.0             | 4.712 ns | 0.3959 ns | 0.3703 ns |  0.95 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET 8.0             | 5.346 ns | 0.4696 ns | 0.4163 ns |  1.08 |    0.10 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET 8.0             | 4.213 ns | 0.4528 ns | 0.4014 ns |  0.85 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET 8.0             | 4.859 ns | 0.3328 ns | 0.2779 ns |  0.98 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET 8.0             | 4.472 ns | 0.4625 ns | 0.4326 ns |  0.91 |    0.09 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET 8.0             | 4.209 ns | 0.3999 ns | 0.3340 ns |  0.85 |    0.07 |
| BitConverter_GetBytes_Double          | .NET Framework 4.6.2 | 4.649 ns | 0.1816 ns | 0.1699 ns |  0.94 |    0.03 |
| BitConverter_GetBytes_Float           | .NET Framework 4.6.2 | 4.479 ns | 0.2474 ns | 0.2193 ns |  0.91 |    0.06 |
| BitConverter_GetBytes_UInt64          | .NET Framework 4.6.2 | 5.100 ns | 0.4881 ns | 0.4565 ns |  1.03 |    0.10 |
| BitConverter_GetBytes_Int64           | .NET Framework 4.6.2 | 4.749 ns | 0.1637 ns | 0.1532 ns |  0.96 |    0.04 |
| BitConverter_GetBytes_UInt32          | .NET Framework 4.6.2 | 4.249 ns | 0.1454 ns | 0.1360 ns |  0.86 |    0.04 |
| BitConverter_GetBytes_Int32           | .NET Framework 4.6.2 | 4.154 ns | 0.1300 ns | 0.1216 ns |  0.84 |    0.03 |
| BitConverter_GetBytes_UInt16          | .NET Framework 4.6.2 | 4.410 ns | 0.1656 ns | 0.1549 ns |  0.89 |    0.05 |
| BitConverter_GetBytes_Int16           | .NET Framework 4.6.2 | 4.386 ns | 0.1671 ns | 0.1563 ns |  0.89 |    0.04 |
| LittleEndianByteIndexer_Slice_Double  | .NET Framework 4.6.2 | 6.409 ns | 0.1605 ns | 0.1253 ns |  1.29 |    0.05 |
| LittleEndianByteIndexer_Slice_Float   | .NET Framework 4.6.2 | 9.387 ns | 0.3283 ns | 0.3071 ns |  1.90 |    0.08 |
| LittleEndianByteIndexer_Slice_UInt64  | .NET Framework 4.6.2 | 6.096 ns | 0.1779 ns | 0.1664 ns |  1.23 |    0.05 |
| LittleEndianByteIndexer_Slice_Int64   | .NET Framework 4.6.2 | 5.940 ns | 0.2131 ns | 0.1993 ns |  1.20 |    0.04 |
| LittleEndianByteIndexer_Slice_UInt32  | .NET Framework 4.6.2 | 5.003 ns | 0.1292 ns | 0.0676 ns |  1.00 |    0.03 |
| LittleEndianByteIndexer_Slice_Int32   | .NET Framework 4.6.2 | 5.026 ns | 0.1861 ns | 0.1741 ns |  1.02 |    0.04 |
| LittleEndianByteIndexer_Slice_UInt16  | .NET Framework 4.6.2 | 4.667 ns | 0.1679 ns | 0.1571 ns |  0.94 |    0.04 |
| LittleEndianByteIndexer_Slice_Int16   | .NET Framework 4.6.2 | 4.728 ns | 0.1617 ns | 0.1513 ns |  0.96 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET Framework 4.6.2 | 6.376 ns | 0.3409 ns | 0.2847 ns |  1.29 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET Framework 4.6.2 | 9.158 ns | 0.2270 ns | 0.1501 ns |  1.83 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET Framework 4.6.2 | 6.229 ns | 0.3282 ns | 0.3070 ns |  1.26 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET Framework 4.6.2 | 5.102 ns | 0.1464 ns | 0.1143 ns |  1.03 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET Framework 4.6.2 | 4.723 ns | 0.1683 ns | 0.1575 ns |  0.96 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET Framework 4.6.2 | 3.833 ns | 0.1143 ns | 0.0954 ns |  0.77 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET Framework 4.6.2 | 4.254 ns | 0.0958 ns | 0.0634 ns |  0.85 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET Framework 4.6.2 | 3.455 ns | 0.1145 ns | 0.0956 ns |  0.70 |    0.03 |

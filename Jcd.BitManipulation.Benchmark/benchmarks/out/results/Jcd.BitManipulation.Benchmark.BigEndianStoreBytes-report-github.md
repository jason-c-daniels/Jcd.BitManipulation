```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-EEBDNP : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-NOGGYQ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                                   | Runtime              | Mean       | Error     | StdDev    | Ratio | RatioSD |
|----------------------------------------- |--------------------- |-----------:|----------:|----------:|------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  1.1341 ns | 0.1847 ns | 0.1637 ns |  0.87 |    0.17 |
| BitConverter_ToFloat                     | .NET 8.0             |  2.0456 ns | 0.4272 ns | 0.3996 ns |  1.55 |    0.34 |
| BitConverter_ToUInt64                    | .NET 8.0             |  1.3037 ns | 0.0692 ns | 0.0613 ns |  0.99 |    0.07 |
| BitConverter_ToInt64                     | .NET 8.0             |  1.9110 ns | 0.2283 ns | 0.2136 ns |  1.47 |    0.19 |
| BitConverter_ToUInt32                    | .NET 8.0             |  1.2543 ns | 0.0756 ns | 0.0631 ns |  0.95 |    0.09 |
| BitConverter_ToInt32                     | .NET 8.0             |  1.7057 ns | 0.0740 ns | 0.0618 ns |  1.29 |    0.09 |
| BitConverter_ToUInt16                    | .NET 8.0             |  3.6209 ns | 0.1299 ns | 0.1215 ns |  2.76 |    0.20 |
| BitConverter_ToInt16                     | .NET 8.0             |  3.7664 ns | 0.0594 ns | 0.0393 ns |  2.81 |    0.20 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.2048 ns | 0.0259 ns | 0.0135 ns |  0.90 |    0.07 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.1708 ns | 0.0434 ns | 0.0362 ns |  0.13 |    0.03 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.3170 ns | 0.1092 ns | 0.0968 ns |  1.00 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.1884 ns | 0.0250 ns | 0.0165 ns |  0.89 |    0.06 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.1264 ns | 0.0187 ns | 0.0098 ns |  0.09 |    0.01 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.1611 ns | 0.0420 ns | 0.0393 ns |  0.12 |    0.04 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1443 ns | 0.0468 ns | 0.0438 ns |  0.11 |    0.04 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1498 ns | 0.0219 ns | 0.0115 ns |  0.11 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.2611 ns | 0.0713 ns | 0.0667 ns |  1.73 |    0.11 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.7785 ns | 0.0647 ns | 0.0605 ns |  0.59 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.1254 ns | 0.1419 ns | 0.1258 ns |  1.62 |    0.13 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.0295 ns | 0.0358 ns | 0.0187 ns |  1.52 |    0.11 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.5766 ns | 0.0520 ns | 0.0486 ns |  0.44 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.6597 ns | 0.1034 ns | 0.0967 ns |  0.51 |    0.08 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.3874 ns | 0.0695 ns | 0.0616 ns |  0.30 |    0.06 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.3794 ns | 0.0319 ns | 0.0211 ns |  0.28 |    0.02 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.3483 ns | 0.1085 ns | 0.1015 ns |  1.03 |    0.09 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.3980 ns | 0.0624 ns | 0.0584 ns |  0.31 |    0.05 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.2093 ns | 0.0498 ns | 0.0388 ns |  0.91 |    0.08 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.2136 ns | 0.0345 ns | 0.0205 ns |  0.90 |    0.07 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1675 ns | 0.0549 ns | 0.0487 ns |  0.13 |    0.04 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.1488 ns | 0.0385 ns | 0.0341 ns |  0.11 |    0.03 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.1545 ns | 0.0261 ns | 0.0172 ns |  0.12 |    0.01 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.1386 ns | 0.0203 ns | 0.0134 ns |  0.10 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  0.6833 ns | 0.0387 ns | 0.0256 ns |  0.51 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  0.1672 ns | 0.0434 ns | 0.0406 ns |  0.13 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  0.5985 ns | 0.0338 ns | 0.0201 ns |  0.44 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  0.6112 ns | 0.0292 ns | 0.0174 ns |  0.45 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  0.1161 ns | 0.0203 ns | 0.0134 ns |  0.09 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  0.1246 ns | 0.0226 ns | 0.0150 ns |  0.09 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  0.1213 ns | 0.0187 ns | 0.0111 ns |  0.09 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  0.1313 ns | 0.0246 ns | 0.0162 ns |  0.10 |    0.01 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 | 25.0355 ns | 0.5831 ns | 0.5454 ns | 19.05 |    1.47 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 | 23.9753 ns | 0.4719 ns | 0.3121 ns | 17.90 |    1.28 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 | 26.4176 ns | 0.4013 ns | 0.2099 ns | 19.76 |    1.56 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 | 25.0769 ns | 0.3547 ns | 0.2346 ns | 18.72 |    1.32 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 | 23.9627 ns | 0.4412 ns | 0.2918 ns | 17.89 |    1.27 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 | 23.1356 ns | 0.3663 ns | 0.2180 ns | 17.18 |    1.20 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 | 22.9829 ns | 0.3550 ns | 0.2348 ns | 17.16 |    1.27 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 | 21.8044 ns | 0.4293 ns | 0.4016 ns | 16.65 |    1.27 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 |  6.8506 ns | 0.0400 ns | 0.0265 ns |  5.11 |    0.37 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 12.5179 ns | 0.1432 ns | 0.0852 ns |  9.30 |    0.72 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 |  6.6443 ns | 0.1007 ns | 0.0666 ns |  4.96 |    0.35 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 |  6.6310 ns | 0.0714 ns | 0.0472 ns |  4.95 |    0.36 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  3.0108 ns | 0.0800 ns | 0.0529 ns |  2.25 |    0.17 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  3.0296 ns | 0.0855 ns | 0.0758 ns |  2.31 |    0.18 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  1.4485 ns | 0.0463 ns | 0.0306 ns |  1.08 |    0.09 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  1.4541 ns | 0.0782 ns | 0.0731 ns |  1.10 |    0.08 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 | 10.5459 ns | 0.1190 ns | 0.0787 ns |  7.87 |    0.58 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 14.3598 ns | 0.1541 ns | 0.0806 ns | 10.74 |    0.85 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 | 10.3634 ns | 0.0786 ns | 0.0520 ns |  7.74 |    0.55 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 | 10.3372 ns | 0.1369 ns | 0.0905 ns |  7.72 |    0.56 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  4.8625 ns | 0.0684 ns | 0.0407 ns |  3.61 |    0.28 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.6222 ns | 0.1140 ns | 0.0754 ns |  1.96 |    0.16 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  2.4370 ns | 0.0665 ns | 0.0440 ns |  1.82 |    0.16 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  2.4343 ns | 0.0350 ns | 0.0231 ns |  1.82 |    0.13 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 |  6.7493 ns | 0.0722 ns | 0.0478 ns |  5.04 |    0.37 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 13.3474 ns | 0.7571 ns | 0.6322 ns | 10.13 |    0.86 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 |  6.4193 ns | 0.1199 ns | 0.0714 ns |  4.77 |    0.35 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 |  6.4316 ns | 0.1091 ns | 0.0649 ns |  4.78 |    0.35 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  2.9961 ns | 0.0772 ns | 0.0685 ns |  2.29 |    0.17 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  3.0281 ns | 0.0891 ns | 0.0790 ns |  2.31 |    0.14 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  1.5017 ns | 0.0784 ns | 0.0733 ns |  1.15 |    0.10 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  1.4403 ns | 0.0495 ns | 0.0414 ns |  1.09 |    0.08 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  2.6529 ns | 0.1403 ns | 0.1313 ns |  2.03 |    0.20 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  6.3002 ns | 0.5322 ns | 0.4978 ns |  4.81 |    0.53 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  2.5689 ns | 0.2198 ns | 0.2056 ns |  1.97 |    0.17 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  2.4080 ns | 0.0805 ns | 0.0753 ns |  1.83 |    0.14 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  0.7908 ns | 0.0403 ns | 0.0377 ns |  0.61 |    0.06 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  0.7790 ns | 0.0263 ns | 0.0174 ns |  0.58 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  0.6323 ns | 0.0338 ns | 0.0282 ns |  0.48 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  0.6186 ns | 0.0564 ns | 0.0527 ns |  0.47 |    0.05 |

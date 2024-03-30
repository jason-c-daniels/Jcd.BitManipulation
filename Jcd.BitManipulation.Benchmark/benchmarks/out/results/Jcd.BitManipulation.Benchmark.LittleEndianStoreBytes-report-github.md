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

| Method                                   | Runtime              | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD |
|----------------------------------------- |--------------------- |-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  0.2153 ns | 0.1800 ns | 0.1684 ns |  0.1801 ns | 0.161 |    0.13 |
| BitConverter_ToFloat                     | .NET 8.0             |  0.1363 ns | 0.1256 ns | 0.1114 ns |  0.1010 ns | 0.100 |    0.08 |
| BitConverter_ToUInt64                    | .NET 8.0             |  0.0278 ns | 0.0685 ns | 0.0641 ns |  0.0000 ns | 0.018 |    0.04 |
| BitConverter_ToInt64                     | .NET 8.0             |  0.1707 ns | 0.2006 ns | 0.1877 ns |  0.1465 ns | 0.102 |    0.11 |
| BitConverter_ToUInt32                    | .NET 8.0             |  0.0011 ns | 0.0035 ns | 0.0023 ns |  0.0000 ns | 0.001 |    0.00 |
| BitConverter_ToInt32                     | .NET 8.0             |  0.0269 ns | 0.0507 ns | 0.0449 ns |  0.0016 ns | 0.019 |    0.03 |
| BitConverter_ToUInt16                    | .NET 8.0             |  0.0183 ns | 0.0261 ns | 0.0244 ns |  0.0106 ns | 0.014 |    0.02 |
| BitConverter_ToInt16                     | .NET 8.0             |  0.1729 ns | 0.0578 ns | 0.0540 ns |  0.1489 ns | 0.129 |    0.04 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.6396 ns | 0.1900 ns | 0.1777 ns |  1.6190 ns | 1.226 |    0.17 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.3646 ns | 0.0155 ns | 0.0081 ns |  0.3639 ns | 0.261 |    0.02 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.3575 ns | 0.1116 ns | 0.0990 ns |  1.3219 ns | 1.000 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.5047 ns | 0.1871 ns | 0.1750 ns |  1.4681 ns | 1.120 |    0.11 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.3589 ns | 0.0182 ns | 0.0108 ns |  0.3587 ns | 0.259 |    0.02 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.3406 ns | 0.0161 ns | 0.0084 ns |  0.3397 ns | 0.244 |    0.02 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1395 ns | 0.0184 ns | 0.0121 ns |  0.1366 ns | 0.101 |    0.01 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1522 ns | 0.0376 ns | 0.0352 ns |  0.1474 ns | 0.114 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.4342 ns | 0.0844 ns | 0.0748 ns |  2.4246 ns | 1.802 |    0.14 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.7870 ns | 0.0268 ns | 0.0194 ns |  0.7804 ns | 0.574 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.1481 ns | 0.0655 ns | 0.0474 ns |  2.1323 ns | 1.568 |    0.13 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.2284 ns | 0.0612 ns | 0.0405 ns |  2.2229 ns | 1.619 |    0.12 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.7762 ns | 0.1247 ns | 0.1166 ns |  0.7311 ns | 0.580 |    0.09 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.7135 ns | 0.0740 ns | 0.0692 ns |  0.6980 ns | 0.525 |    0.06 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.1808 ns | 0.0425 ns | 0.0398 ns |  0.1692 ns | 0.135 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.1383 ns | 0.0419 ns | 0.0392 ns |  0.1287 ns | 0.105 |    0.03 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.4605 ns | 0.0521 ns | 0.0345 ns |  1.4544 ns | 1.061 |    0.07 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.3806 ns | 0.0322 ns | 0.0252 ns |  0.3846 ns | 0.279 |    0.02 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.2584 ns | 0.0438 ns | 0.0289 ns |  1.2537 ns | 0.914 |    0.06 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.4714 ns | 0.1621 ns | 0.1516 ns |  1.4496 ns | 1.096 |    0.12 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1281 ns | 0.0182 ns | 0.0095 ns |  0.1325 ns | 0.092 |    0.01 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.1025 ns | 0.0223 ns | 0.0132 ns |  0.1039 ns | 0.074 |    0.01 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.0039 ns | 0.0095 ns | 0.0057 ns |  0.0000 ns | 0.003 |    0.00 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.1405 ns | 0.0216 ns | 0.0156 ns |  0.1354 ns | 0.103 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  0.6804 ns | 0.0370 ns | 0.0245 ns |  0.6736 ns | 0.494 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  0.1353 ns | 0.0172 ns | 0.0102 ns |  0.1326 ns | 0.097 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  0.6032 ns | 0.0187 ns | 0.0124 ns |  0.6063 ns | 0.438 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  0.6365 ns | 0.0359 ns | 0.0336 ns |  0.6244 ns | 0.472 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  0.2083 ns | 0.0781 ns | 0.0693 ns |  0.2096 ns | 0.154 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  0.1734 ns | 0.0617 ns | 0.0577 ns |  0.1552 ns | 0.122 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  0.1481 ns | 0.0300 ns | 0.0251 ns |  0.1446 ns | 0.110 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  0.1531 ns | 0.0575 ns | 0.0538 ns |  0.1357 ns | 0.110 |    0.04 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 |  2.7322 ns | 0.1626 ns | 0.1442 ns |  2.6968 ns | 2.023 |    0.19 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 |  1.9059 ns | 0.0487 ns | 0.0290 ns |  1.9022 ns | 1.375 |    0.10 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 |  2.7473 ns | 0.3114 ns | 0.2912 ns |  2.6288 ns | 2.037 |    0.27 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 |  1.2935 ns | 0.0454 ns | 0.0425 ns |  1.2992 ns | 0.956 |    0.07 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 |  1.4903 ns | 0.0980 ns | 0.0869 ns |  1.4564 ns | 1.100 |    0.05 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 |  0.5138 ns | 0.0266 ns | 0.0158 ns |  0.5128 ns | 0.371 |    0.03 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 |  2.7260 ns | 0.0756 ns | 0.0707 ns |  2.7335 ns | 2.021 |    0.14 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 |  0.7831 ns | 0.0341 ns | 0.0246 ns |  0.7849 ns | 0.571 |    0.04 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 |  2.8901 ns | 0.0520 ns | 0.0309 ns |  2.8889 ns | 2.084 |    0.15 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 11.2877 ns | 0.2119 ns | 0.1401 ns | 11.3328 ns | 8.201 |    0.57 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 |  3.4997 ns | 0.1078 ns | 0.1009 ns |  3.4912 ns | 2.590 |    0.19 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 |  3.4637 ns | 0.1055 ns | 0.0987 ns |  3.4496 ns | 2.566 |    0.18 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  1.8559 ns | 0.0506 ns | 0.0301 ns |  1.8581 ns | 1.339 |    0.10 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  1.8782 ns | 0.0749 ns | 0.0701 ns |  1.8553 ns | 1.396 |    0.12 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  0.8923 ns | 0.0373 ns | 0.0270 ns |  0.8903 ns | 0.651 |    0.05 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  0.9652 ns | 0.0310 ns | 0.0205 ns |  0.9652 ns | 0.702 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  4.7540 ns | 0.1072 ns | 0.0775 ns |  4.7672 ns | 3.468 |    0.25 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 12.1370 ns | 0.2603 ns | 0.2032 ns | 12.0473 ns | 8.908 |    0.69 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  6.5879 ns | 0.1432 ns | 0.1036 ns |  6.6038 ns | 4.805 |    0.33 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.5411 ns | 0.1491 ns | 0.1395 ns |  6.5387 ns | 4.838 |    0.33 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  2.5395 ns | 0.1278 ns | 0.1195 ns |  2.5804 ns | 1.884 |    0.14 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.5779 ns | 0.1694 ns | 0.1585 ns |  2.5183 ns | 1.916 |    0.19 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  1.9222 ns | 0.0922 ns | 0.0863 ns |  1.9399 ns | 1.419 |    0.13 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  1.9800 ns | 0.0651 ns | 0.0609 ns |  1.9901 ns | 1.464 |    0.13 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 |  2.9899 ns | 0.0727 ns | 0.0481 ns |  2.9721 ns | 2.174 |    0.18 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 11.3124 ns | 0.1218 ns | 0.0725 ns | 11.3269 ns | 8.158 |    0.57 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 |  3.0916 ns | 0.0367 ns | 0.0192 ns |  3.0922 ns | 2.217 |    0.18 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 |  2.6462 ns | 0.0395 ns | 0.0235 ns |  2.6521 ns | 1.909 |    0.14 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  1.2641 ns | 0.0387 ns | 0.0256 ns |  1.2722 ns | 0.918 |    0.06 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  1.2275 ns | 0.0373 ns | 0.0247 ns |  1.2264 ns | 0.892 |    0.06 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  1.0056 ns | 0.0430 ns | 0.0285 ns |  1.0031 ns | 0.731 |    0.06 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  0.9380 ns | 0.0212 ns | 0.0126 ns |  0.9354 ns | 0.677 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  2.5347 ns | 0.0703 ns | 0.0549 ns |  2.5320 ns | 1.860 |    0.14 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  5.7654 ns | 0.1386 ns | 0.1229 ns |  5.7336 ns | 4.263 |    0.25 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  2.3380 ns | 0.0651 ns | 0.0430 ns |  2.3276 ns | 1.699 |    0.12 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  2.3405 ns | 0.0454 ns | 0.0300 ns |  2.3333 ns | 1.702 |    0.14 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  0.7771 ns | 0.0381 ns | 0.0252 ns |  0.7800 ns | 0.565 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  0.7799 ns | 0.0416 ns | 0.0390 ns |  0.7709 ns | 0.578 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  0.6206 ns | 0.0331 ns | 0.0219 ns |  0.6196 ns | 0.451 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  0.6203 ns | 0.0865 ns | 0.0809 ns |  0.5931 ns | 0.460 |    0.08 |

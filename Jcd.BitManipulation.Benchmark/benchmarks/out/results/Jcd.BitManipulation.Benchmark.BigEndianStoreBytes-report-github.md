```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-UWWGLV : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-IXAHBT : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                                   | Runtime              |       Mean |     Error |    StdDev |     Median |  Ratio | RatioSD |
|------------------------------------------|----------------------|-----------:|----------:|----------:|-----------:|-------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  1.4481 ns | 0.0307 ns | 0.0183 ns |  1.4454 ns |  1.152 |    0.03 |
| BitConverter_ToFloat                     | .NET 8.0             |  1.4858 ns | 0.0958 ns | 0.0849 ns |  1.4467 ns |  1.196 |    0.09 |
| BitConverter_ToUInt64                    | .NET 8.0             |  1.2219 ns | 0.0401 ns | 0.0239 ns |  1.2283 ns |  0.971 |    0.02 |
| BitConverter_ToInt64                     | .NET 8.0             |  1.6643 ns | 0.0195 ns | 0.0102 ns |  1.6614 ns |  1.321 |    0.04 |
| BitConverter_ToUInt32                    | .NET 8.0             |  1.1801 ns | 0.0479 ns | 0.0400 ns |  1.1607 ns |  0.945 |    0.03 |
| BitConverter_ToInt32                     | .NET 8.0             |  1.7266 ns | 0.1065 ns | 0.0889 ns |  1.7209 ns |  1.358 |    0.08 |
| BitConverter_ToUInt16                    | .NET 8.0             |  3.2727 ns | 0.1172 ns | 0.1039 ns |  3.2508 ns |  2.623 |    0.11 |
| BitConverter_ToInt16                     | .NET 8.0             |  3.4867 ns | 0.0769 ns | 0.0508 ns |  3.4875 ns |  2.778 |    0.07 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.4131 ns | 0.1275 ns | 0.1130 ns |  1.4107 ns |  1.132 |    0.09 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.1720 ns | 0.0618 ns | 0.0578 ns |  0.1488 ns |  0.154 |    0.05 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.2556 ns | 0.0478 ns | 0.0316 ns |  1.2473 ns |  1.000 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.2653 ns | 0.0498 ns | 0.0360 ns |  1.2748 ns |  1.007 |    0.04 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.2090 ns | 0.1195 ns | 0.1118 ns |  0.1858 ns |  0.121 |    0.04 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.1423 ns | 0.0337 ns | 0.0316 ns |  0.1413 ns |  0.105 |    0.02 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1323 ns | 0.0100 ns | 0.0066 ns |  0.1302 ns |  0.105 |    0.01 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1885 ns | 0.0328 ns | 0.0307 ns |  0.1767 ns |  0.161 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.2561 ns | 0.0862 ns | 0.0806 ns |  2.2452 ns |  1.782 |    0.06 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.7510 ns | 0.0573 ns | 0.0536 ns |  0.7563 ns |  0.598 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.2258 ns | 0.1754 ns | 0.1641 ns |  2.1889 ns |  1.707 |    0.12 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.0395 ns | 0.0572 ns | 0.0378 ns |  2.0265 ns |  1.625 |    0.06 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.5685 ns | 0.0663 ns | 0.0554 ns |  0.5523 ns |  0.461 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.5810 ns | 0.0373 ns | 0.0311 ns |  0.5753 ns |  0.464 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.3493 ns | 0.0336 ns | 0.0280 ns |  0.3442 ns |  0.275 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.3534 ns | 0.0205 ns | 0.0136 ns |  0.3533 ns |  0.282 |    0.01 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.2725 ns | 0.0294 ns | 0.0154 ns |  1.2716 ns |  1.010 |    0.03 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.3494 ns | 0.0223 ns | 0.0133 ns |  0.3537 ns |  0.278 |    0.01 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.1999 ns | 0.0282 ns | 0.0147 ns |  1.1975 ns |  0.952 |    0.02 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.1894 ns | 0.0333 ns | 0.0174 ns |  1.1942 ns |  0.944 |    0.03 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1400 ns | 0.0223 ns | 0.0133 ns |  0.1363 ns |  0.111 |    0.01 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.1310 ns | 0.0245 ns | 0.0162 ns |  0.1310 ns |  0.104 |    0.01 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.0037 ns | 0.0082 ns | 0.0054 ns |  0.0000 ns |  0.003 |    0.00 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.0017 ns | 0.0081 ns | 0.0048 ns |  0.0000 ns |  0.001 |    0.00 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  0.6712 ns | 0.0270 ns | 0.0161 ns |  0.6700 ns |  0.534 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  0.3567 ns | 0.0235 ns | 0.0140 ns |  0.3547 ns |  0.284 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  0.5953 ns | 0.0242 ns | 0.0160 ns |  0.5929 ns |  0.475 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  0.6029 ns | 0.0203 ns | 0.0121 ns |  0.6085 ns |  0.480 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  0.1947 ns | 0.0827 ns | 0.0773 ns |  0.2141 ns |  0.185 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  0.1330 ns | 0.0281 ns | 0.0167 ns |  0.1329 ns |  0.106 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  0.0075 ns | 0.0169 ns | 0.0122 ns |  0.0000 ns |  0.006 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  0.0098 ns | 0.0152 ns | 0.0100 ns |  0.0089 ns |  0.008 |    0.01 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 | 26.1321 ns | 0.3441 ns | 0.2276 ns | 26.0896 ns | 20.824 |    0.56 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 | 23.6953 ns | 0.4820 ns | 0.4025 ns | 23.6501 ns | 18.866 |    0.36 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 | 28.8321 ns | 1.6377 ns | 1.5319 ns | 28.1473 ns | 23.371 |    1.35 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 | 25.0509 ns | 0.5097 ns | 0.3371 ns | 25.0966 ns | 19.963 |    0.60 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 | 24.0853 ns | 0.8326 ns | 0.7381 ns | 23.8257 ns | 18.998 |    0.73 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 | 22.7062 ns | 0.3871 ns | 0.2561 ns | 22.7129 ns | 18.095 |    0.52 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 | 23.3360 ns | 0.4509 ns | 0.2683 ns | 23.3723 ns | 18.559 |    0.54 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 | 21.7106 ns | 0.8760 ns | 0.7765 ns | 21.6810 ns | 17.432 |    0.71 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 |  6.7898 ns | 0.0742 ns | 0.0491 ns |  6.7897 ns |  5.410 |    0.11 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 12.7105 ns | 0.2664 ns | 0.1585 ns | 12.7350 ns | 10.109 |    0.30 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 |  6.6417 ns | 0.1462 ns | 0.1296 ns |  6.6128 ns |  5.286 |    0.17 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 |  6.6019 ns | 0.1257 ns | 0.0909 ns |  6.5946 ns |  5.257 |    0.15 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  2.9919 ns | 0.0217 ns | 0.0113 ns |  2.9893 ns |  2.375 |    0.06 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  3.0270 ns | 0.1119 ns | 0.1046 ns |  2.9971 ns |  2.425 |    0.10 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  1.4698 ns | 0.0529 ns | 0.0495 ns |  1.4486 ns |  1.173 |    0.05 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  1.4782 ns | 0.0488 ns | 0.0381 ns |  1.4893 ns |  1.178 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 | 10.6675 ns | 0.2141 ns | 0.1274 ns | 10.6889 ns |  8.484 |    0.24 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 14.4468 ns | 0.3789 ns | 0.3544 ns | 14.3665 ns | 11.550 |    0.40 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 | 10.4140 ns | 0.2258 ns | 0.1886 ns | 10.4283 ns |  8.314 |    0.24 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 | 10.3814 ns | 0.3130 ns | 0.2775 ns | 10.2883 ns |  8.314 |    0.31 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  4.8991 ns | 0.1180 ns | 0.0985 ns |  4.9101 ns |  3.918 |    0.11 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  4.8665 ns | 0.1198 ns | 0.0866 ns |  4.8521 ns |  3.887 |    0.13 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  2.8060 ns | 0.3880 ns | 0.3629 ns |  2.7180 ns |  2.081 |    0.21 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  2.5130 ns | 0.1370 ns | 0.1282 ns |  2.4634 ns |  2.044 |    0.12 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 |  6.7174 ns | 0.1458 ns | 0.1055 ns |  6.6758 ns |  5.349 |    0.13 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 12.1354 ns | 0.1811 ns | 0.1198 ns | 12.1295 ns |  9.670 |    0.22 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 |  6.4226 ns | 0.0887 ns | 0.0528 ns |  6.4216 ns |  5.108 |    0.16 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 |  6.2934 ns | 0.0616 ns | 0.0408 ns |  6.2852 ns |  5.015 |    0.11 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  3.0312 ns | 0.0825 ns | 0.0732 ns |  3.0279 ns |  2.425 |    0.08 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  2.9294 ns | 0.0737 ns | 0.0487 ns |  2.9084 ns |  2.335 |    0.08 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  1.3893 ns | 0.0395 ns | 0.0235 ns |  1.3854 ns |  1.105 |    0.03 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  1.4499 ns | 0.0862 ns | 0.0806 ns |  1.4051 ns |  1.173 |    0.08 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  2.5040 ns | 0.0658 ns | 0.0391 ns |  2.4886 ns |  1.991 |    0.06 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  5.7042 ns | 0.1612 ns | 0.1429 ns |  5.6378 ns |  4.563 |    0.16 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  2.2710 ns | 0.0312 ns | 0.0206 ns |  2.2747 ns |  1.810 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  2.2676 ns | 0.0272 ns | 0.0162 ns |  2.2659 ns |  1.803 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  0.6687 ns | 0.0174 ns | 0.0115 ns |  0.6693 ns |  0.533 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  0.6590 ns | 0.0123 ns | 0.0082 ns |  0.6605 ns |  0.525 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  0.6279 ns | 0.0346 ns | 0.0289 ns |  0.6294 ns |  0.495 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  0.6355 ns | 0.0107 ns | 0.0071 ns |  0.6358 ns |  0.506 |    0.01 |

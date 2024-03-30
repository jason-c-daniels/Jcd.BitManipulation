```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-YHHOLE : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-SKCLAR : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```
| Method                                   | Runtime              | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD |
|----------------------------------------- |--------------------- |-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  0.0069 ns | 0.0157 ns | 0.0139 ns |  0.0000 ns | 0.004 |    0.01 |
| BitConverter_ToFloat                     | .NET 8.0             |  0.0217 ns | 0.0258 ns | 0.0241 ns |  0.0126 ns | 0.014 |    0.02 |
| BitConverter_ToUInt64                    | .NET 8.0             |  0.0045 ns | 0.0097 ns | 0.0064 ns |  0.0016 ns | 0.003 |    0.00 |
| BitConverter_ToInt64                     | .NET 8.0             |  0.1565 ns | 0.0283 ns | 0.0205 ns |  0.1576 ns | 0.108 |    0.02 |
| BitConverter_ToUInt32                    | .NET 8.0             |  0.0019 ns | 0.0055 ns | 0.0049 ns |  0.0000 ns | 0.001 |    0.00 |
| BitConverter_ToInt32                     | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns | 0.000 |    0.00 |
| BitConverter_ToUInt16                    | .NET 8.0             |  0.0050 ns | 0.0137 ns | 0.0128 ns |  0.0000 ns | 0.004 |    0.01 |
| BitConverter_ToInt16                     | .NET 8.0             |  0.1699 ns | 0.0323 ns | 0.0287 ns |  0.1695 ns | 0.118 |    0.02 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.4471 ns | 0.0540 ns | 0.0357 ns |  1.4401 ns | 0.980 |    0.14 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.3591 ns | 0.0316 ns | 0.0280 ns |  0.3529 ns | 0.249 |    0.03 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.4502 ns | 0.1996 ns | 0.1867 ns |  1.3430 ns | 1.000 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.3299 ns | 0.0664 ns | 0.0621 ns |  1.3063 ns | 0.933 |    0.14 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.3586 ns | 0.0280 ns | 0.0185 ns |  0.3612 ns | 0.242 |    0.03 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.3679 ns | 0.0309 ns | 0.0289 ns |  0.3647 ns | 0.256 |    0.03 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1351 ns | 0.0269 ns | 0.0178 ns |  0.1317 ns | 0.092 |    0.02 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1767 ns | 0.0456 ns | 0.0427 ns |  0.1613 ns | 0.124 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.2769 ns | 0.0397 ns | 0.0236 ns |  2.2688 ns | 1.522 |    0.20 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  1.0207 ns | 0.1662 ns | 0.1555 ns |  1.0145 ns | 0.713 |    0.13 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.1559 ns | 0.0887 ns | 0.0741 ns |  2.1217 ns | 1.488 |    0.19 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.4255 ns | 0.3564 ns | 0.3160 ns |  2.2791 ns | 1.700 |    0.37 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.6746 ns | 0.0478 ns | 0.0447 ns |  0.6576 ns | 0.471 |    0.06 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.6248 ns | 0.0636 ns | 0.0595 ns |  0.6143 ns | 0.436 |    0.06 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.1071 ns | 0.0369 ns | 0.0345 ns |  0.1117 ns | 0.075 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.3797 ns | 0.0341 ns | 0.0285 ns |  0.3858 ns | 0.262 |    0.03 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.4897 ns | 0.0574 ns | 0.0479 ns |  1.4903 ns | 1.028 |    0.13 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.4841 ns | 0.1144 ns | 0.1070 ns |  0.4604 ns | 0.337 |    0.08 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.3239 ns | 0.0856 ns | 0.0715 ns |  1.3096 ns | 0.912 |    0.11 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.4140 ns | 0.1250 ns | 0.1170 ns |  1.4306 ns | 0.988 |    0.14 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1667 ns | 0.0505 ns | 0.0473 ns |  0.1582 ns | 0.116 |    0.03 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.1882 ns | 0.0395 ns | 0.0330 ns |  0.1956 ns | 0.131 |    0.03 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.0594 ns | 0.0279 ns | 0.0247 ns |  0.0608 ns | 0.041 |    0.02 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.1485 ns | 0.0361 ns | 0.0338 ns |  0.1483 ns | 0.105 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  0.6827 ns | 0.0437 ns | 0.0409 ns |  0.6782 ns | 0.477 |    0.06 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  0.1338 ns | 0.0275 ns | 0.0229 ns |  0.1293 ns | 0.092 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  0.6014 ns | 0.0361 ns | 0.0261 ns |  0.5955 ns | 0.412 |    0.06 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  0.6358 ns | 0.0356 ns | 0.0236 ns |  0.6350 ns | 0.430 |    0.06 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  0.1273 ns | 0.0270 ns | 0.0179 ns |  0.1242 ns | 0.087 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  0.1392 ns | 0.0328 ns | 0.0307 ns |  0.1292 ns | 0.097 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  0.0213 ns | 0.0215 ns | 0.0113 ns |  0.0208 ns | 0.014 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  0.1131 ns | 0.0617 ns | 0.0578 ns |  0.0992 ns | 0.079 |    0.04 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 |  2.9080 ns | 0.2558 ns | 0.2392 ns |  2.9445 ns | 2.032 |    0.28 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 |  2.0809 ns | 0.1294 ns | 0.1211 ns |  2.0535 ns | 1.448 |    0.13 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 |  2.6945 ns | 0.0749 ns | 0.0542 ns |  2.6929 ns | 1.845 |    0.26 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 |  1.2823 ns | 0.0453 ns | 0.0300 ns |  1.2782 ns | 0.868 |    0.12 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 |  1.4709 ns | 0.0477 ns | 0.0345 ns |  1.4776 ns | 1.007 |    0.14 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 |  0.5138 ns | 0.0238 ns | 0.0142 ns |  0.5146 ns | 0.343 |    0.05 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 |  2.8720 ns | 0.1577 ns | 0.1398 ns |  2.9033 ns | 1.996 |    0.23 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 |  0.8198 ns | 0.0679 ns | 0.0635 ns |  0.8185 ns | 0.575 |    0.09 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 |  2.9100 ns | 0.0663 ns | 0.0438 ns |  2.9014 ns | 1.971 |    0.27 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 11.1810 ns | 0.1919 ns | 0.1269 ns | 11.1862 ns | 7.575 |    1.04 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 |  3.4166 ns | 0.0852 ns | 0.0712 ns |  3.4302 ns | 2.362 |    0.31 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 |  3.3897 ns | 0.1093 ns | 0.1023 ns |  3.3385 ns | 2.369 |    0.27 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  1.8054 ns | 0.0358 ns | 0.0237 ns |  1.8016 ns | 1.222 |    0.16 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  1.8250 ns | 0.0537 ns | 0.0355 ns |  1.8265 ns | 1.235 |    0.16 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  0.8746 ns | 0.0366 ns | 0.0242 ns |  0.8770 ns | 0.591 |    0.07 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  0.9497 ns | 0.0209 ns | 0.0124 ns |  0.9533 ns | 0.635 |    0.09 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  4.7834 ns | 0.1755 ns | 0.1641 ns |  4.7581 ns | 3.341 |    0.38 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 12.2323 ns | 0.2117 ns | 0.1400 ns | 12.2094 ns | 8.281 |    1.09 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  6.5168 ns | 0.1457 ns | 0.1217 ns |  6.5451 ns | 4.501 |    0.57 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.3708 ns | 0.1669 ns | 0.1479 ns |  6.3941 ns | 4.435 |    0.55 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  2.6212 ns | 0.1454 ns | 0.1360 ns |  2.6328 ns | 1.835 |    0.25 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.5006 ns | 0.1216 ns | 0.1138 ns |  2.4676 ns | 1.752 |    0.24 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  1.9250 ns | 0.0676 ns | 0.0632 ns |  1.9236 ns | 1.345 |    0.16 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  1.8852 ns | 0.0825 ns | 0.0772 ns |  1.8940 ns | 1.319 |    0.17 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 |  2.9136 ns | 0.0326 ns | 0.0194 ns |  2.9115 ns | 1.948 |    0.26 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 11.4644 ns | 0.2353 ns | 0.1556 ns | 11.4463 ns | 7.768 |    1.08 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 |  3.0323 ns | 0.0543 ns | 0.0323 ns |  3.0363 ns | 2.030 |    0.29 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 |  2.6264 ns | 0.0464 ns | 0.0307 ns |  2.6269 ns | 1.779 |    0.24 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  1.2154 ns | 0.0451 ns | 0.0400 ns |  1.2235 ns | 0.844 |    0.09 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  1.2041 ns | 0.0443 ns | 0.0320 ns |  1.2063 ns | 0.825 |    0.12 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  0.9565 ns | 0.0396 ns | 0.0331 ns |  0.9480 ns | 0.660 |    0.08 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  1.0816 ns | 0.0839 ns | 0.0785 ns |  1.0826 ns | 0.756 |    0.10 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  2.6396 ns | 0.1826 ns | 0.1708 ns |  2.5882 ns | 1.835 |    0.14 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  6.1415 ns | 0.2020 ns | 0.1687 ns |  6.1165 ns | 4.238 |    0.51 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  2.3553 ns | 0.0593 ns | 0.0463 ns |  2.3599 ns | 1.616 |    0.21 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  2.4002 ns | 0.0598 ns | 0.0467 ns |  2.4014 ns | 1.647 |    0.22 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  0.7549 ns | 0.0254 ns | 0.0151 ns |  0.7537 ns | 0.505 |    0.07 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  0.8437 ns | 0.0722 ns | 0.0675 ns |  0.8432 ns | 0.591 |    0.09 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  0.6924 ns | 0.0406 ns | 0.0379 ns |  0.6945 ns | 0.485 |    0.07 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  0.5430 ns | 0.0291 ns | 0.0211 ns |  0.5433 ns | 0.371 |    0.05 |

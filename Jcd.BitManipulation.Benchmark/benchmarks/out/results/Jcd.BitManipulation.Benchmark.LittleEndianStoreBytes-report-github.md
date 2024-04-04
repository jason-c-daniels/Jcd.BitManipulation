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
| Method                                   | Runtime              | Mean       | Error     | StdDev    | Median     | Ratio  | RatioSD |
|----------------------------------------- |--------------------- |-----------:|----------:|----------:|-----------:|-------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  0.0055 ns | 0.0079 ns | 0.0047 ns |  0.0065 ns |  0.004 |    0.00 |
| BitConverter_ToFloat                     | .NET 8.0             |  0.0059 ns | 0.0145 ns | 0.0096 ns |  0.0000 ns |  0.004 |    0.01 |
| BitConverter_ToUInt64                    | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| BitConverter_ToInt64                     | .NET 8.0             |  0.1349 ns | 0.0157 ns | 0.0104 ns |  0.1323 ns |  0.102 |    0.01 |
| BitConverter_ToUInt32                    | .NET 8.0             |  0.0071 ns | 0.0111 ns | 0.0073 ns |  0.0065 ns |  0.005 |    0.01 |
| BitConverter_ToInt32                     | .NET 8.0             |  0.0034 ns | 0.0087 ns | 0.0057 ns |  0.0006 ns |  0.003 |    0.00 |
| BitConverter_ToUInt16                    | .NET 8.0             |  0.0029 ns | 0.0058 ns | 0.0038 ns |  0.0010 ns |  0.002 |    0.00 |
| BitConverter_ToInt16                     | .NET 8.0             |  0.1050 ns | 0.0268 ns | 0.0178 ns |  0.0978 ns |  0.080 |    0.01 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.4623 ns | 0.0757 ns | 0.0671 ns |  1.4408 ns |  1.109 |    0.07 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.5787 ns | 0.2575 ns | 0.2409 ns |  0.4643 ns |  0.444 |    0.19 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.3201 ns | 0.0496 ns | 0.0440 ns |  1.3095 ns |  1.000 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.4503 ns | 0.1023 ns | 0.0957 ns |  1.4256 ns |  1.104 |    0.08 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.1364 ns | 0.0368 ns | 0.0344 ns |  0.1182 ns |  0.105 |    0.03 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.1960 ns | 0.0736 ns | 0.0689 ns |  0.1571 ns |  0.143 |    0.05 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1422 ns | 0.0416 ns | 0.0389 ns |  0.1321 ns |  0.110 |    0.03 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1420 ns | 0.0270 ns | 0.0179 ns |  0.1399 ns |  0.108 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.3183 ns | 0.0738 ns | 0.0654 ns |  2.3015 ns |  1.758 |    0.08 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.7881 ns | 0.0727 ns | 0.0680 ns |  0.7563 ns |  0.601 |    0.06 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.3121 ns | 0.1412 ns | 0.1179 ns |  2.3137 ns |  1.749 |    0.11 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.2694 ns | 0.0920 ns | 0.0861 ns |  2.2603 ns |  1.724 |    0.09 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.7554 ns | 0.0641 ns | 0.0501 ns |  0.7620 ns |  0.573 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.7423 ns | 0.0645 ns | 0.0572 ns |  0.7420 ns |  0.562 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.1008 ns | 0.0518 ns | 0.0484 ns |  0.0919 ns |  0.078 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.1739 ns | 0.0568 ns | 0.0474 ns |  0.1649 ns |  0.132 |    0.04 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.5066 ns | 0.0836 ns | 0.0741 ns |  1.4985 ns |  1.143 |    0.08 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.2874 ns | 0.0209 ns | 0.0109 ns |  0.2888 ns |  0.217 |    0.01 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.4681 ns | 0.2430 ns | 0.2029 ns |  1.4422 ns |  1.111 |    0.16 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.5495 ns | 0.1758 ns | 0.1644 ns |  1.5399 ns |  1.157 |    0.11 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1418 ns | 0.0284 ns | 0.0252 ns |  0.1329 ns |  0.108 |    0.02 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.1201 ns | 0.0263 ns | 0.0174 ns |  0.1163 ns |  0.091 |    0.01 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.1829 ns | 0.0479 ns | 0.0448 ns |  0.1948 ns |  0.137 |    0.03 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.1306 ns | 0.0402 ns | 0.0376 ns |  0.1349 ns |  0.102 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  2.1597 ns | 0.0620 ns | 0.0517 ns |  2.1675 ns |  1.634 |    0.07 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  1.7180 ns | 0.0392 ns | 0.0259 ns |  1.7178 ns |  1.303 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  2.0771 ns | 0.0646 ns | 0.0427 ns |  2.0736 ns |  1.575 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  2.0303 ns | 0.0555 ns | 0.0367 ns |  2.0365 ns |  1.540 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  2.1630 ns | 0.0917 ns | 0.0858 ns |  2.1433 ns |  1.640 |    0.07 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  2.1226 ns | 0.0657 ns | 0.0475 ns |  2.0982 ns |  1.606 |    0.06 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  1.5292 ns | 0.0484 ns | 0.0253 ns |  1.5317 ns |  1.157 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  1.3660 ns | 0.0417 ns | 0.0276 ns |  1.3741 ns |  1.036 |    0.04 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 |  2.7841 ns | 0.1190 ns | 0.1113 ns |  2.7628 ns |  2.103 |    0.12 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 |  1.9392 ns | 0.0647 ns | 0.0540 ns |  1.9392 ns |  1.467 |    0.07 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 |  2.7759 ns | 0.0639 ns | 0.0422 ns |  2.7841 ns |  2.106 |    0.08 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 |  1.2866 ns | 0.0229 ns | 0.0120 ns |  1.2848 ns |  0.973 |    0.03 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 |  1.4566 ns | 0.0474 ns | 0.0396 ns |  1.4405 ns |  1.102 |    0.06 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 |  0.5186 ns | 0.0150 ns | 0.0099 ns |  0.5232 ns |  0.394 |    0.02 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 |  2.7108 ns | 0.0721 ns | 0.0477 ns |  2.7195 ns |  2.056 |    0.08 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 |  0.8323 ns | 0.0775 ns | 0.0687 ns |  0.8008 ns |  0.630 |    0.04 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 | 12.1673 ns | 0.2548 ns | 0.2128 ns | 12.1129 ns |  9.203 |    0.35 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 15.4418 ns | 0.1745 ns | 0.0912 ns | 15.4146 ns | 11.678 |    0.43 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 | 11.0516 ns | 0.2015 ns | 0.1333 ns | 11.0652 ns |  8.383 |    0.29 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 | 10.8952 ns | 0.2228 ns | 0.1474 ns | 10.8924 ns |  8.264 |    0.28 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  7.9594 ns | 0.1512 ns | 0.1000 ns |  7.9737 ns |  6.038 |    0.22 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  7.9450 ns | 0.1467 ns | 0.0970 ns |  7.9599 ns |  6.028 |    0.24 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  7.0320 ns | 0.0935 ns | 0.0618 ns |  7.0264 ns |  5.335 |    0.20 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  7.2155 ns | 0.1114 ns | 0.0737 ns |  7.2043 ns |  5.474 |    0.20 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  4.8950 ns | 0.1108 ns | 0.0865 ns |  4.8954 ns |  3.713 |    0.15 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 11.9549 ns | 0.2125 ns | 0.1406 ns | 11.9540 ns |  9.070 |    0.36 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  6.4452 ns | 0.1911 ns | 0.1788 ns |  6.4630 ns |  4.867 |    0.16 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.6116 ns | 0.2221 ns | 0.1969 ns |  6.6690 ns |  5.013 |    0.22 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  2.4103 ns | 0.1193 ns | 0.1116 ns |  2.4278 ns |  1.831 |    0.12 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.6197 ns | 0.1064 ns | 0.0995 ns |  2.6249 ns |  1.981 |    0.11 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  1.9152 ns | 0.0988 ns | 0.0924 ns |  1.9249 ns |  1.450 |    0.07 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  1.8958 ns | 0.0888 ns | 0.0831 ns |  1.8819 ns |  1.435 |    0.08 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 | 12.2232 ns | 0.2585 ns | 0.1869 ns | 12.1308 ns |  9.248 |    0.33 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 16.0939 ns | 0.6359 ns | 0.5637 ns | 15.9349 ns | 12.203 |    0.57 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 | 10.8613 ns | 0.2335 ns | 0.1688 ns | 10.8564 ns |  8.216 |    0.25 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 | 11.5800 ns | 0.9742 ns | 0.9113 ns | 11.3582 ns |  8.828 |    0.73 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  7.9109 ns | 0.1754 ns | 0.1268 ns |  7.8818 ns |  5.985 |    0.22 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  8.0452 ns | 0.1696 ns | 0.1010 ns |  8.0854 ns |  6.108 |    0.18 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  7.0309 ns | 0.1730 ns | 0.1618 ns |  6.9755 ns |  5.339 |    0.22 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  7.7934 ns | 0.4019 ns | 0.3760 ns |  7.7415 ns |  5.886 |    0.29 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  3.8069 ns | 0.1289 ns | 0.1206 ns |  3.7828 ns |  2.877 |    0.13 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  7.5513 ns | 0.3377 ns | 0.2994 ns |  7.5402 ns |  5.728 |    0.33 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  5.0112 ns | 0.1495 ns | 0.1399 ns |  5.0053 ns |  3.807 |    0.14 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  4.8542 ns | 0.1293 ns | 0.1209 ns |  4.8225 ns |  3.683 |    0.18 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  3.3209 ns | 0.1572 ns | 0.1394 ns |  3.3253 ns |  2.518 |    0.13 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  3.2206 ns | 0.1487 ns | 0.1391 ns |  3.1523 ns |  2.450 |    0.15 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  2.6312 ns | 0.0805 ns | 0.0753 ns |  2.6208 ns |  1.998 |    0.09 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  2.6991 ns | 0.0802 ns | 0.0750 ns |  2.6852 ns |  2.047 |    0.07 |

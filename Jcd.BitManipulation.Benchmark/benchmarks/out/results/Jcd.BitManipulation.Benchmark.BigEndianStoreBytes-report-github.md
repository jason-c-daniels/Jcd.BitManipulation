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

| Method                                   | Runtime              |       Mean |     Error |    StdDev |     Median |  Ratio | RatioSD |
|------------------------------------------|----------------------|-----------:|----------:|----------:|-----------:|-------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  1.4831 ns | 0.0355 ns | 0.0235 ns |  1.4770 ns |  1.179 |    0.02 |
| BitConverter_ToFloat                     | .NET 8.0             |  1.4798 ns | 0.0455 ns | 0.0271 ns |  1.4908 ns |  1.174 |    0.03 |
| BitConverter_ToUInt64                    | .NET 8.0             |  1.2960 ns | 0.0488 ns | 0.0407 ns |  1.2884 ns |  1.015 |    0.04 |
| BitConverter_ToInt64                     | .NET 8.0             |  1.6543 ns | 0.0157 ns | 0.0104 ns |  1.6552 ns |  1.313 |    0.02 |
| BitConverter_ToUInt32                    | .NET 8.0             |  1.2119 ns | 0.0144 ns | 0.0085 ns |  1.2140 ns |  0.961 |    0.01 |
| BitConverter_ToInt32                     | .NET 8.0             |  1.6950 ns | 0.0469 ns | 0.0310 ns |  1.6845 ns |  1.346 |    0.03 |
| BitConverter_ToUInt16                    | .NET 8.0             |  3.5428 ns | 0.0224 ns | 0.0148 ns |  3.5438 ns |  2.811 |    0.03 |
| BitConverter_ToInt16                     | .NET 8.0             |  3.7649 ns | 0.0140 ns | 0.0093 ns |  3.7611 ns |  2.987 |    0.03 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.2582 ns | 0.0171 ns | 0.0113 ns |  1.2550 ns |  0.999 |    0.02 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.1450 ns | 0.0144 ns | 0.0095 ns |  0.1429 ns |  0.116 |    0.01 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.2608 ns | 0.0247 ns | 0.0147 ns |  1.2622 ns |  1.000 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.2406 ns | 0.0215 ns | 0.0142 ns |  1.2353 ns |  0.985 |    0.02 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.1961 ns | 0.0589 ns | 0.0551 ns |  0.1859 ns |  0.134 |    0.03 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.1289 ns | 0.0107 ns | 0.0071 ns |  0.1268 ns |  0.103 |    0.01 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1493 ns | 0.0134 ns | 0.0089 ns |  0.1479 ns |  0.118 |    0.01 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1335 ns | 0.0153 ns | 0.0101 ns |  0.1330 ns |  0.106 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.2389 ns | 0.0313 ns | 0.0207 ns |  2.2374 ns |  1.774 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.7530 ns | 0.0269 ns | 0.0178 ns |  0.7565 ns |  0.600 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.0159 ns | 0.0329 ns | 0.0196 ns |  2.0100 ns |  1.599 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.0317 ns | 0.0244 ns | 0.0161 ns |  2.0233 ns |  1.610 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.5385 ns | 0.0180 ns | 0.0119 ns |  0.5347 ns |  0.428 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.5493 ns | 0.0170 ns | 0.0113 ns |  0.5510 ns |  0.436 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.3470 ns | 0.0110 ns | 0.0072 ns |  0.3503 ns |  0.276 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.3448 ns | 0.0269 ns | 0.0178 ns |  0.3423 ns |  0.275 |    0.01 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.2529 ns | 0.0169 ns | 0.0100 ns |  1.2511 ns |  0.994 |    0.02 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.3517 ns | 0.0101 ns | 0.0067 ns |  0.3534 ns |  0.279 |    0.01 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.2130 ns | 0.0150 ns | 0.0089 ns |  1.2126 ns |  0.962 |    0.01 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.1874 ns | 0.0187 ns | 0.0111 ns |  1.1925 ns |  0.942 |    0.01 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1267 ns | 0.0107 ns | 0.0071 ns |  0.1246 ns |  0.099 |    0.00 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.1240 ns | 0.0101 ns | 0.0067 ns |  0.1235 ns |  0.099 |    0.00 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.1490 ns | 0.0161 ns | 0.0096 ns |  0.1501 ns |  0.118 |    0.01 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.0022 ns | 0.0056 ns | 0.0037 ns |  0.0000 ns |  0.002 |    0.00 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  0.6789 ns | 0.0163 ns | 0.0108 ns |  0.6796 ns |  0.539 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  0.1386 ns | 0.0122 ns | 0.0081 ns |  0.1372 ns |  0.109 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  0.5987 ns | 0.0044 ns | 0.0023 ns |  0.5984 ns |  0.475 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  0.6326 ns | 0.0267 ns | 0.0177 ns |  0.6370 ns |  0.500 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  0.1449 ns | 0.0262 ns | 0.0174 ns |  0.1412 ns |  0.115 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  0.1197 ns | 0.0234 ns | 0.0155 ns |  0.1158 ns |  0.095 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  0.1055 ns | 0.0145 ns | 0.0096 ns |  0.1058 ns |  0.084 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  0.1294 ns | 0.0199 ns | 0.0131 ns |  0.1272 ns |  0.103 |    0.01 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 | 26.8367 ns | 0.5066 ns | 0.3351 ns | 26.8389 ns | 21.356 |    0.31 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 | 23.5174 ns | 0.1211 ns | 0.0801 ns | 23.5286 ns | 18.651 |    0.24 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 | 26.1375 ns | 0.1522 ns | 0.1007 ns | 26.1169 ns | 20.742 |    0.26 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 | 24.8332 ns | 0.1641 ns | 0.1085 ns | 24.8589 ns | 19.721 |    0.20 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 | 23.2592 ns | 0.4035 ns | 0.2669 ns | 23.3177 ns | 18.446 |    0.35 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 | 22.0768 ns | 0.6906 ns | 0.6460 ns | 21.9655 ns | 17.713 |    0.73 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 | 22.8981 ns | 0.1359 ns | 0.0809 ns | 22.8885 ns | 18.164 |    0.20 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 | 21.1306 ns | 0.1645 ns | 0.1088 ns | 21.1016 ns | 16.746 |    0.24 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 |  2.9790 ns | 0.0408 ns | 0.0270 ns |  2.9749 ns |  2.363 |    0.03 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 11.0300 ns | 0.2208 ns | 0.1461 ns | 10.9614 ns |  8.731 |    0.16 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 |  2.9116 ns | 0.0698 ns | 0.0462 ns |  2.9072 ns |  2.307 |    0.04 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 |  2.8914 ns | 0.0451 ns | 0.0268 ns |  2.8901 ns |  2.294 |    0.04 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  1.5618 ns | 0.0422 ns | 0.0279 ns |  1.5618 ns |  1.242 |    0.02 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  1.5254 ns | 0.0520 ns | 0.0344 ns |  1.5186 ns |  1.213 |    0.04 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  0.8817 ns | 0.0154 ns | 0.0092 ns |  0.8821 ns |  0.699 |    0.01 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  0.9525 ns | 0.0177 ns | 0.0105 ns |  0.9515 ns |  0.755 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  4.8270 ns | 0.0507 ns | 0.0301 ns |  4.8369 ns |  3.829 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 11.8343 ns | 0.0483 ns | 0.0319 ns | 11.8391 ns |  9.386 |    0.11 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  6.2772 ns | 0.1059 ns | 0.0701 ns |  6.2792 ns |  4.976 |    0.11 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.2887 ns | 0.0846 ns | 0.0559 ns |  6.2975 ns |  4.998 |    0.08 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  2.9031 ns | 0.1277 ns | 0.1132 ns |  2.9362 ns |  2.318 |    0.07 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.8737 ns | 0.0455 ns | 0.0238 ns |  2.8779 ns |  2.281 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  1.8514 ns | 0.0422 ns | 0.0279 ns |  1.8632 ns |  1.472 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  1.8859 ns | 0.0520 ns | 0.0406 ns |  1.8772 ns |  1.500 |    0.04 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 |  2.7407 ns | 0.0240 ns | 0.0143 ns |  2.7427 ns |  2.174 |    0.02 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 10.9051 ns | 0.2067 ns | 0.1230 ns | 10.8762 ns |  8.650 |    0.13 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 |  2.7763 ns | 0.0274 ns | 0.0163 ns |  2.7717 ns |  2.202 |    0.03 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 |  2.7942 ns | 0.0272 ns | 0.0180 ns |  2.7979 ns |  2.217 |    0.03 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  1.4735 ns | 0.0187 ns | 0.0123 ns |  1.4725 ns |  1.168 |    0.01 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  1.4228 ns | 0.0250 ns | 0.0149 ns |  1.4233 ns |  1.129 |    0.02 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  0.9592 ns | 0.0133 ns | 0.0079 ns |  0.9565 ns |  0.761 |    0.01 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  0.9417 ns | 0.0204 ns | 0.0135 ns |  0.9396 ns |  0.746 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  2.4860 ns | 0.0143 ns | 0.0075 ns |  2.4867 ns |  1.973 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  5.8939 ns | 0.1345 ns | 0.1123 ns |  5.8678 ns |  4.697 |    0.13 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  2.3677 ns | 0.0252 ns | 0.0150 ns |  2.3629 ns |  1.878 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  2.3414 ns | 0.0119 ns | 0.0079 ns |  2.3436 ns |  1.859 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  0.7819 ns | 0.0222 ns | 0.0147 ns |  0.7780 ns |  0.620 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  0.7797 ns | 0.0159 ns | 0.0094 ns |  0.7800 ns |  0.619 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  0.6426 ns | 0.0213 ns | 0.0141 ns |  0.6459 ns |  0.509 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  0.5703 ns | 0.0146 ns | 0.0097 ns |  0.5717 ns |  0.453 |    0.01 |

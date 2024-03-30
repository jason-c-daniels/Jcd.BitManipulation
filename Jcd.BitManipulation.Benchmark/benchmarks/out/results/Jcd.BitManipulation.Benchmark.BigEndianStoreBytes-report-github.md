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

| Method                                   | Runtime              | Mean       | Error     | StdDev    | Median     | Ratio  | RatioSD |
|----------------------------------------- |--------------------- |-----------:|----------:|----------:|-----------:|-------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  1.5354 ns | 0.1019 ns | 0.0904 ns |  1.5387 ns |  1.202 |    0.11 |
| BitConverter_ToFloat                     | .NET 8.0             |  1.4633 ns | 0.0524 ns | 0.0347 ns |  1.4489 ns |  1.148 |    0.05 |
| BitConverter_ToUInt64                    | .NET 8.0             |  1.2444 ns | 0.0331 ns | 0.0259 ns |  1.2483 ns |  0.979 |    0.06 |
| BitConverter_ToInt64                     | .NET 8.0             |  1.7093 ns | 0.0571 ns | 0.0446 ns |  1.6955 ns |  1.343 |    0.07 |
| BitConverter_ToUInt32                    | .NET 8.0             |  1.2425 ns | 0.0425 ns | 0.0377 ns |  1.2247 ns |  0.972 |    0.06 |
| BitConverter_ToInt32                     | .NET 8.0             |  1.6698 ns | 0.0427 ns | 0.0283 ns |  1.6623 ns |  1.311 |    0.08 |
| BitConverter_ToUInt16                    | .NET 8.0             |  3.6224 ns | 0.0979 ns | 0.0868 ns |  3.6206 ns |  2.832 |    0.16 |
| BitConverter_ToInt16                     | .NET 8.0             |  3.9518 ns | 0.4280 ns | 0.4004 ns |  3.7799 ns |  3.075 |    0.30 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.5640 ns | 0.3415 ns | 0.3028 ns |  1.4729 ns |  1.220 |    0.22 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.7634 ns | 0.4583 ns | 0.4286 ns |  0.6866 ns |  0.599 |    0.34 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.2863 ns | 0.0654 ns | 0.0612 ns |  1.2695 ns |  1.000 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.2473 ns | 0.0483 ns | 0.0428 ns |  1.2356 ns |  0.975 |    0.06 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.1444 ns | 0.0297 ns | 0.0278 ns |  0.1381 ns |  0.113 |    0.02 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.1755 ns | 0.0366 ns | 0.0342 ns |  0.1786 ns |  0.136 |    0.02 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1297 ns | 0.0178 ns | 0.0093 ns |  0.1300 ns |  0.101 |    0.01 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1624 ns | 0.0401 ns | 0.0375 ns |  0.1668 ns |  0.127 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.3086 ns | 0.0561 ns | 0.0438 ns |  2.3047 ns |  1.815 |    0.10 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.7933 ns | 0.0905 ns | 0.0847 ns |  0.7704 ns |  0.618 |    0.08 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.1176 ns | 0.1001 ns | 0.0836 ns |  2.0965 ns |  1.665 |    0.08 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.1248 ns | 0.1153 ns | 0.1022 ns |  2.1292 ns |  1.660 |    0.09 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.5789 ns | 0.0435 ns | 0.0407 ns |  0.5652 ns |  0.451 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.6250 ns | 0.0663 ns | 0.0620 ns |  0.6286 ns |  0.486 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.3504 ns | 0.0317 ns | 0.0209 ns |  0.3435 ns |  0.275 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.3364 ns | 0.0322 ns | 0.0251 ns |  0.3359 ns |  0.264 |    0.01 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.3617 ns | 0.0599 ns | 0.0531 ns |  1.3385 ns |  1.064 |    0.05 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.3889 ns | 0.0658 ns | 0.0583 ns |  0.3801 ns |  0.304 |    0.04 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.1584 ns | 0.0254 ns | 0.0133 ns |  1.1640 ns |  0.900 |    0.04 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.2372 ns | 0.0521 ns | 0.0462 ns |  1.2332 ns |  0.968 |    0.06 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1545 ns | 0.0368 ns | 0.0345 ns |  0.1483 ns |  0.120 |    0.03 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.1464 ns | 0.0302 ns | 0.0283 ns |  0.1468 ns |  0.114 |    0.02 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.1466 ns | 0.0093 ns | 0.0062 ns |  0.1454 ns |  0.115 |    0.01 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.0066 ns | 0.0148 ns | 0.0088 ns |  0.0024 ns |  0.005 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  0.6837 ns | 0.0281 ns | 0.0186 ns |  0.6923 ns |  0.537 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  0.1576 ns | 0.0273 ns | 0.0163 ns |  0.1583 ns |  0.124 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  0.5883 ns | 0.0353 ns | 0.0313 ns |  0.5742 ns |  0.460 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  0.6130 ns | 0.0261 ns | 0.0172 ns |  0.6138 ns |  0.481 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  0.1463 ns | 0.0253 ns | 0.0167 ns |  0.1470 ns |  0.115 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  0.1443 ns | 0.0218 ns | 0.0144 ns |  0.1417 ns |  0.113 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  0.1912 ns | 0.0617 ns | 0.0578 ns |  0.1736 ns |  0.149 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  0.1538 ns | 0.0656 ns | 0.0614 ns |  0.1479 ns |  0.119 |    0.05 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 | 26.6465 ns | 0.5644 ns | 0.5003 ns | 26.5022 ns | 20.834 |    1.08 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 | 23.8896 ns | 0.3407 ns | 0.2253 ns | 23.8874 ns | 18.749 |    0.84 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 | 26.4530 ns | 0.3762 ns | 0.2488 ns | 26.4271 ns | 20.761 |    0.93 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 | 24.8886 ns | 0.2985 ns | 0.1776 ns | 24.9352 ns | 19.512 |    0.98 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 | 23.7386 ns | 0.4493 ns | 0.3752 ns | 23.8726 ns | 18.674 |    0.81 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 | 22.8372 ns | 0.3354 ns | 0.2218 ns | 22.8331 ns | 17.933 |    1.01 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 | 23.1601 ns | 0.3773 ns | 0.2495 ns | 23.0537 ns | 18.182 |    0.94 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 | 21.3233 ns | 0.3872 ns | 0.2561 ns | 21.3644 ns | 16.738 |    0.82 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 |  2.9240 ns | 0.0803 ns | 0.0580 ns |  2.9193 ns |  2.298 |    0.11 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 11.0382 ns | 0.2413 ns | 0.1745 ns | 10.9720 ns |  8.677 |    0.49 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 |  2.9292 ns | 0.0877 ns | 0.0820 ns |  2.9467 ns |  2.282 |    0.13 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 |  2.9771 ns | 0.0702 ns | 0.0508 ns |  2.9818 ns |  2.339 |    0.10 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  1.5199 ns | 0.0565 ns | 0.0529 ns |  1.4922 ns |  1.184 |    0.07 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  1.5461 ns | 0.0513 ns | 0.0401 ns |  1.5363 ns |  1.215 |    0.07 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  0.8472 ns | 0.0157 ns | 0.0082 ns |  0.8476 ns |  0.658 |    0.03 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  0.9430 ns | 0.0356 ns | 0.0212 ns |  0.9435 ns |  0.739 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  5.0269 ns | 0.1156 ns | 0.0836 ns |  5.0261 ns |  3.952 |    0.24 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 12.1419 ns | 0.1899 ns | 0.1130 ns | 12.1289 ns |  9.521 |    0.53 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  6.4162 ns | 0.0988 ns | 0.0654 ns |  6.4270 ns |  5.037 |    0.25 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.4296 ns | 0.1421 ns | 0.1027 ns |  6.4295 ns |  5.052 |    0.24 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  2.9191 ns | 0.1867 ns | 0.1747 ns |  2.9473 ns |  2.274 |    0.17 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.9524 ns | 0.0518 ns | 0.0308 ns |  2.9473 ns |  2.314 |    0.11 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  1.8979 ns | 0.0582 ns | 0.0516 ns |  1.8910 ns |  1.483 |    0.08 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  1.9520 ns | 0.1053 ns | 0.0985 ns |  1.9560 ns |  1.521 |    0.11 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 |  2.8180 ns | 0.0719 ns | 0.0476 ns |  2.8258 ns |  2.212 |    0.10 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 11.0096 ns | 0.3280 ns | 0.3068 ns | 10.8714 ns |  8.578 |    0.50 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 |  3.4712 ns | 0.1605 ns | 0.1423 ns |  3.4254 ns |  2.713 |    0.16 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 |  2.9886 ns | 0.1343 ns | 0.1256 ns |  2.9443 ns |  2.329 |    0.17 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  1.4909 ns | 0.0773 ns | 0.0723 ns |  1.5224 ns |  1.162 |    0.08 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  1.3900 ns | 0.0507 ns | 0.0396 ns |  1.3772 ns |  1.092 |    0.05 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  1.0002 ns | 0.0518 ns | 0.0404 ns |  1.0086 ns |  0.786 |    0.04 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  0.9881 ns | 0.0500 ns | 0.0468 ns |  0.9941 ns |  0.770 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  2.6273 ns | 0.0955 ns | 0.0847 ns |  2.6125 ns |  2.054 |    0.13 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  5.9179 ns | 0.2585 ns | 0.2418 ns |  5.9062 ns |  4.612 |    0.32 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  2.4457 ns | 0.0871 ns | 0.0815 ns |  2.4262 ns |  1.905 |    0.10 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  2.4156 ns | 0.0831 ns | 0.0737 ns |  2.3972 ns |  1.889 |    0.11 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  0.7797 ns | 0.0386 ns | 0.0361 ns |  0.7732 ns |  0.607 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  0.7981 ns | 0.0537 ns | 0.0502 ns |  0.7846 ns |  0.622 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  0.6215 ns | 0.0406 ns | 0.0360 ns |  0.6405 ns |  0.485 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  0.5830 ns | 0.0455 ns | 0.0403 ns |  0.5743 ns |  0.456 |    0.04 |

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

| Method                                   | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  0.0014 ns | 0.0053 ns | 0.0031 ns |  0.0000 ns | 0.001 |    0.00 |
| BitConverter_ToFloat                     | .NET 8.0             |  0.0059 ns | 0.0145 ns | 0.0096 ns |  0.0000 ns | 0.004 |    0.01 |
| BitConverter_ToUInt64                    | .NET 8.0             |  0.0204 ns | 0.0201 ns | 0.0178 ns |  0.0136 ns | 0.014 |    0.01 |
| BitConverter_ToInt64                     | .NET 8.0             |  0.1425 ns | 0.0251 ns | 0.0149 ns |  0.1369 ns | 0.100 |    0.01 |
| BitConverter_ToUInt32                    | .NET 8.0             |  0.0064 ns | 0.0092 ns | 0.0061 ns |  0.0050 ns | 0.004 |    0.00 |
| BitConverter_ToInt32                     | .NET 8.0             |  0.0067 ns | 0.0132 ns | 0.0079 ns |  0.0021 ns | 0.005 |    0.01 |
| BitConverter_ToUInt16                    | .NET 8.0             |  0.0052 ns | 0.0170 ns | 0.0113 ns |  0.0000 ns | 0.004 |    0.01 |
| BitConverter_ToInt16                     | .NET 8.0             |  0.1375 ns | 0.0193 ns | 0.0128 ns |  0.1337 ns | 0.097 |    0.01 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.4800 ns | 0.0451 ns | 0.0268 ns |  1.4902 ns | 1.041 |    0.05 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.4044 ns | 0.0325 ns | 0.0253 ns |  0.3985 ns | 0.285 |    0.01 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.4230 ns | 0.0538 ns | 0.0477 ns |  1.4174 ns | 1.000 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.4270 ns | 0.0510 ns | 0.0399 ns |  1.4286 ns | 1.006 |    0.04 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.4117 ns | 0.0438 ns | 0.0410 ns |  0.3937 ns | 0.287 |    0.03 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.4631 ns | 0.0596 ns | 0.0557 ns |  0.4463 ns | 0.325 |    0.04 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1510 ns | 0.0258 ns | 0.0216 ns |  0.1488 ns | 0.106 |    0.02 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1609 ns | 0.0449 ns | 0.0420 ns |  0.1481 ns | 0.114 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.5436 ns | 0.0858 ns | 0.0761 ns |  2.5386 ns | 1.790 |    0.10 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.9956 ns | 0.0917 ns | 0.0858 ns |  0.9887 ns | 0.701 |    0.07 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.4684 ns | 0.1026 ns | 0.0960 ns |  2.4553 ns | 1.731 |    0.07 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.4089 ns | 0.1219 ns | 0.1141 ns |  2.3966 ns | 1.691 |    0.09 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.7628 ns | 0.0415 ns | 0.0388 ns |  0.7593 ns | 0.537 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.7831 ns | 0.0837 ns | 0.0783 ns |  0.7452 ns | 0.545 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.1518 ns | 0.0298 ns | 0.0265 ns |  0.1556 ns | 0.107 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.4200 ns | 0.0349 ns | 0.0292 ns |  0.4194 ns | 0.295 |    0.02 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.6606 ns | 0.0652 ns | 0.0610 ns |  1.6638 ns | 1.174 |    0.05 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.2081 ns | 0.0644 ns | 0.0602 ns |  0.1940 ns | 0.150 |    0.04 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.4510 ns | 0.0631 ns | 0.0590 ns |  1.4370 ns | 1.018 |    0.05 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.4123 ns | 0.0524 ns | 0.0437 ns |  1.3963 ns | 0.993 |    0.04 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1795 ns | 0.0305 ns | 0.0255 ns |  0.1858 ns | 0.126 |    0.02 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.1490 ns | 0.0459 ns | 0.0429 ns |  0.1318 ns | 0.108 |    0.03 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.0343 ns | 0.0289 ns | 0.0270 ns |  0.0320 ns | 0.024 |    0.02 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.1690 ns | 0.0376 ns | 0.0351 ns |  0.1678 ns | 0.118 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  0.7876 ns | 0.0576 ns | 0.0511 ns |  0.7761 ns | 0.554 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  0.1655 ns | 0.0295 ns | 0.0214 ns |  0.1657 ns | 0.117 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  0.6960 ns | 0.0434 ns | 0.0406 ns |  0.7021 ns | 0.490 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  0.6793 ns | 0.0237 ns | 0.0141 ns |  0.6805 ns | 0.478 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  0.1421 ns | 0.0260 ns | 0.0231 ns |  0.1430 ns | 0.100 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  0.1687 ns | 0.0291 ns | 0.0243 ns |  0.1703 ns | 0.119 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  0.1519 ns | 0.0245 ns | 0.0162 ns |  0.1486 ns | 0.107 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  0.1460 ns | 0.0303 ns | 0.0180 ns |  0.1402 ns | 0.103 |    0.01 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 |  3.0043 ns | 0.0764 ns | 0.0552 ns |  3.0065 ns | 2.115 |    0.09 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 |  2.1085 ns | 0.0679 ns | 0.0602 ns |  2.1191 ns | 1.483 |    0.06 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 |  2.9563 ns | 0.0836 ns | 0.0698 ns |  2.9357 ns | 2.079 |    0.08 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 |  1.4024 ns | 0.0530 ns | 0.0315 ns |  1.4153 ns | 0.986 |    0.05 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 |  1.6607 ns | 0.0574 ns | 0.0448 ns |  1.6619 ns | 1.170 |    0.06 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 |  0.5809 ns | 0.0325 ns | 0.0215 ns |  0.5738 ns | 0.408 |    0.02 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 |  2.9500 ns | 0.0786 ns | 0.0656 ns |  2.9542 ns | 2.075 |    0.09 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 |  0.8794 ns | 0.0418 ns | 0.0249 ns |  0.8750 ns | 0.618 |    0.02 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 |  3.2267 ns | 0.0388 ns | 0.0256 ns |  3.2322 ns | 2.266 |    0.09 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 12.1541 ns | 0.1686 ns | 0.1003 ns | 12.1263 ns | 8.547 |    0.39 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 |  3.6541 ns | 0.0874 ns | 0.0520 ns |  3.6396 ns | 2.569 |    0.10 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 |  3.7602 ns | 0.1334 ns | 0.1247 ns |  3.7224 ns | 2.650 |    0.15 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  1.9944 ns | 0.0637 ns | 0.0596 ns |  1.9874 ns | 1.404 |    0.05 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  1.9479 ns | 0.0392 ns | 0.0233 ns |  1.9541 ns | 1.370 |    0.06 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  1.0006 ns | 0.0371 ns | 0.0245 ns |  0.9966 ns | 0.703 |    0.04 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  1.0438 ns | 0.0298 ns | 0.0177 ns |  1.0517 ns | 0.734 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  5.2100 ns | 0.1201 ns | 0.0938 ns |  5.2094 ns | 3.671 |    0.13 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 12.8974 ns | 0.2431 ns | 0.1608 ns | 12.9544 ns | 9.058 |    0.36 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  6.9466 ns | 0.1289 ns | 0.0853 ns |  6.9084 ns | 4.879 |    0.18 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.9413 ns | 0.1337 ns | 0.0884 ns |  6.9518 ns | 4.876 |    0.22 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  2.8982 ns | 0.1412 ns | 0.1321 ns |  2.9363 ns | 2.038 |    0.13 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.9994 ns | 0.1015 ns | 0.0900 ns |  2.9887 ns | 2.109 |    0.08 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  2.1225 ns | 0.0814 ns | 0.0762 ns |  2.1250 ns | 1.495 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  2.1291 ns | 0.0864 ns | 0.0766 ns |  2.1379 ns | 1.497 |    0.06 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 |  3.1960 ns | 0.0777 ns | 0.0562 ns |  3.2002 ns | 2.249 |    0.08 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 12.5324 ns | 0.2550 ns | 0.2260 ns | 12.4864 ns | 8.817 |    0.35 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 |  3.3145 ns | 0.1110 ns | 0.0984 ns |  3.3251 ns | 2.331 |    0.08 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 |  2.8012 ns | 0.0526 ns | 0.0313 ns |  2.8025 ns | 1.969 |    0.07 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  1.3473 ns | 0.0487 ns | 0.0322 ns |  1.3400 ns | 0.946 |    0.04 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  1.4056 ns | 0.0459 ns | 0.0304 ns |  1.4074 ns | 0.987 |    0.04 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  1.0953 ns | 0.0381 ns | 0.0252 ns |  1.0910 ns | 0.770 |    0.04 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  1.0596 ns | 0.0340 ns | 0.0203 ns |  1.0625 ns | 0.745 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  2.7116 ns | 0.0779 ns | 0.0516 ns |  2.7038 ns | 1.905 |    0.10 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  6.4442 ns | 0.1317 ns | 0.1028 ns |  6.4274 ns | 4.541 |    0.17 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  2.4702 ns | 0.0627 ns | 0.0373 ns |  2.4807 ns | 1.737 |    0.08 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  2.5929 ns | 0.0756 ns | 0.0590 ns |  2.5846 ns | 1.827 |    0.08 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  0.8477 ns | 0.0389 ns | 0.0257 ns |  0.8535 ns | 0.595 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  0.8205 ns | 0.0624 ns | 0.0553 ns |  0.8282 ns | 0.577 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  0.7147 ns | 0.0540 ns | 0.0505 ns |  0.7032 ns | 0.499 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  0.7036 ns | 0.1266 ns | 0.1122 ns |  0.6985 ns | 0.495 |    0.08 |

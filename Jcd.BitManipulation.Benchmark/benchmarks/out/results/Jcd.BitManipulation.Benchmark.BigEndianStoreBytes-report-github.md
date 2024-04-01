```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-XPKBTN : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-HBVPVO : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                                   | Runtime              |       Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------------------------|----------------------|-----------:|----------:|----------:|------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  1.6499 ns | 0.0694 ns | 0.0649 ns |  1.24 |    0.08 |
| BitConverter_ToFloat                     | .NET 8.0             |  1.6946 ns | 0.1535 ns | 0.1361 ns |  1.27 |    0.15 |
| BitConverter_ToUInt64                    | .NET 8.0             |  1.3765 ns | 0.0528 ns | 0.0468 ns |  1.03 |    0.07 |
| BitConverter_ToInt64                     | .NET 8.0             |  1.9046 ns | 0.1832 ns | 0.1714 ns |  1.42 |    0.15 |
| BitConverter_ToUInt32                    | .NET 8.0             |  1.7307 ns | 0.0570 ns | 0.0339 ns |  1.28 |    0.06 |
| BitConverter_ToInt32                     | .NET 8.0             |  1.5122 ns | 0.0404 ns | 0.0267 ns |  1.13 |    0.05 |
| BitConverter_ToUInt16                    | .NET 8.0             |  3.8407 ns | 0.1007 ns | 0.0786 ns |  2.88 |    0.12 |
| BitConverter_ToInt16                     | .NET 8.0             |  3.7601 ns | 0.1705 ns | 0.1595 ns |  2.82 |    0.20 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.3881 ns | 0.0541 ns | 0.0423 ns |  1.04 |    0.05 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.3986 ns | 0.0358 ns | 0.0335 ns |  0.30 |    0.04 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.3389 ns | 0.0822 ns | 0.0729 ns |  1.00 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.4108 ns | 0.0736 ns | 0.0689 ns |  1.06 |    0.07 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.1640 ns | 0.0358 ns | 0.0317 ns |  0.12 |    0.02 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.1783 ns | 0.0473 ns | 0.0395 ns |  0.13 |    0.03 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1749 ns | 0.0391 ns | 0.0366 ns |  0.13 |    0.03 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1558 ns | 0.0322 ns | 0.0302 ns |  0.12 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.3752 ns | 0.0915 ns | 0.0811 ns |  1.78 |    0.09 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.8143 ns | 0.0477 ns | 0.0446 ns |  0.61 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.2506 ns | 0.0892 ns | 0.0835 ns |  1.69 |    0.12 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.1920 ns | 0.0663 ns | 0.0480 ns |  1.64 |    0.08 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.6629 ns | 0.0713 ns | 0.0667 ns |  0.49 |    0.06 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.6809 ns | 0.0412 ns | 0.0385 ns |  0.51 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.4164 ns | 0.0695 ns | 0.0650 ns |  0.32 |    0.06 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.4119 ns | 0.0491 ns | 0.0436 ns |  0.31 |    0.04 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.3736 ns | 0.0675 ns | 0.0631 ns |  1.03 |    0.07 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.1709 ns | 0.0214 ns | 0.0112 ns |  0.13 |    0.01 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.3949 ns | 0.0523 ns | 0.0489 ns |  1.04 |    0.06 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.3880 ns | 0.0732 ns | 0.0684 ns |  1.04 |    0.05 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.4068 ns | 0.0382 ns | 0.0358 ns |  0.30 |    0.02 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.4335 ns | 0.0416 ns | 0.0368 ns |  0.32 |    0.03 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.0212 ns | 0.0259 ns | 0.0243 ns |  0.02 |    0.02 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.1537 ns | 0.0271 ns | 0.0196 ns |  0.12 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  2.4799 ns | 0.0715 ns | 0.0634 ns |  1.86 |    0.11 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  1.9060 ns | 0.0622 ns | 0.0411 ns |  1.42 |    0.08 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  2.1790 ns | 0.0677 ns | 0.0634 ns |  1.63 |    0.09 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  2.1896 ns | 0.0663 ns | 0.0439 ns |  1.63 |    0.08 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  2.2548 ns | 0.0725 ns | 0.0643 ns |  1.69 |    0.11 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  2.3606 ns | 0.0534 ns | 0.0279 ns |  1.74 |    0.07 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  1.6355 ns | 0.0706 ns | 0.0625 ns |  1.22 |    0.08 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  1.5099 ns | 0.0953 ns | 0.0891 ns |  1.14 |    0.07 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 | 28.5626 ns | 0.7465 ns | 0.6982 ns | 21.38 |    1.25 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 | 25.3367 ns | 0.5216 ns | 0.4624 ns | 18.97 |    1.03 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 | 28.5105 ns | 0.9042 ns | 0.8015 ns | 21.36 |    1.39 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 | 27.1844 ns | 0.7075 ns | 0.6272 ns | 20.35 |    1.07 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 | 25.6285 ns | 0.7076 ns | 0.6619 ns | 19.22 |    1.28 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 | 24.2693 ns | 0.6733 ns | 0.6298 ns | 18.12 |    1.01 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 | 25.0905 ns | 0.6143 ns | 0.5445 ns | 18.79 |    1.06 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 | 23.2485 ns | 0.5335 ns | 0.4990 ns | 17.36 |    1.00 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 | 12.6603 ns | 0.2135 ns | 0.1412 ns |  9.45 |    0.50 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 17.2832 ns | 0.3647 ns | 0.3412 ns | 12.95 |    0.70 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 | 11.7073 ns | 0.2937 ns | 0.2747 ns |  8.76 |    0.48 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 | 11.4403 ns | 0.2504 ns | 0.2091 ns |  8.63 |    0.41 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  8.4811 ns | 0.1192 ns | 0.0710 ns |  6.28 |    0.26 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  8.4435 ns | 0.1442 ns | 0.0954 ns |  6.30 |    0.31 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  7.7727 ns | 0.0812 ns | 0.0537 ns |  5.80 |    0.26 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  7.7607 ns | 0.1188 ns | 0.0786 ns |  5.79 |    0.24 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  5.4396 ns | 0.1491 ns | 0.1322 ns |  4.07 |    0.20 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 12.6159 ns | 0.2309 ns | 0.1374 ns |  9.34 |    0.39 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  6.7005 ns | 0.1061 ns | 0.0631 ns |  4.96 |    0.18 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.7705 ns | 0.1483 ns | 0.0981 ns |  5.05 |    0.21 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  3.2848 ns | 0.0539 ns | 0.0321 ns |  2.43 |    0.10 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  3.3732 ns | 0.1274 ns | 0.1191 ns |  2.52 |    0.14 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  2.1422 ns | 0.1007 ns | 0.0941 ns |  1.61 |    0.10 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  2.1621 ns | 0.1098 ns | 0.0973 ns |  1.62 |    0.13 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 | 12.8401 ns | 0.2393 ns | 0.1583 ns |  9.58 |    0.50 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 17.1963 ns | 0.3727 ns | 0.3486 ns | 12.90 |    0.74 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 | 11.4031 ns | 0.2341 ns | 0.2076 ns |  8.54 |    0.46 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 | 11.5095 ns | 0.3303 ns | 0.3090 ns |  8.59 |    0.48 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  8.8414 ns | 0.2077 ns | 0.1943 ns |  6.64 |    0.38 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  8.6888 ns | 0.1004 ns | 0.0597 ns |  6.43 |    0.22 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  7.6282 ns | 0.1388 ns | 0.0918 ns |  5.69 |    0.29 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  7.7885 ns | 0.0698 ns | 0.0462 ns |  5.81 |    0.27 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  4.2369 ns | 0.2349 ns | 0.2083 ns |  3.18 |    0.29 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  7.4910 ns | 0.1666 ns | 0.1204 ns |  5.62 |    0.31 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  5.1691 ns | 0.1915 ns | 0.1791 ns |  3.87 |    0.21 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  5.2068 ns | 0.1403 ns | 0.1313 ns |  3.90 |    0.18 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  3.4839 ns | 0.0913 ns | 0.0660 ns |  2.61 |    0.11 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  3.5942 ns | 0.1991 ns | 0.1765 ns |  2.69 |    0.19 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  2.9354 ns | 0.1392 ns | 0.1302 ns |  2.20 |    0.15 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  2.9649 ns | 0.0826 ns | 0.0690 ns |  2.24 |    0.10 |

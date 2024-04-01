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

| Method                                   | Runtime              |       Mean |     Error |    StdDev |     Median |  Ratio | RatioSD |
|------------------------------------------|----------------------|-----------:|----------:|----------:|-----------:|-------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| BitConverter_ToFloat                     | .NET 8.0             |  0.0256 ns | 0.0247 ns | 0.0231 ns |  0.0220 ns |  0.017 |    0.02 |
| BitConverter_ToUInt64                    | .NET 8.0             |  0.0425 ns | 0.0535 ns | 0.0501 ns |  0.0235 ns |  0.029 |    0.03 |
| BitConverter_ToInt64                     | .NET 8.0             |  0.1579 ns | 0.0284 ns | 0.0251 ns |  0.1582 ns |  0.107 |    0.02 |
| BitConverter_ToUInt32                    | .NET 8.0             |  0.0003 ns | 0.0013 ns | 0.0012 ns |  0.0000 ns |  0.000 |    0.00 |
| BitConverter_ToInt32                     | .NET 8.0             |  0.0103 ns | 0.0189 ns | 0.0168 ns |  0.0000 ns |  0.007 |    0.01 |
| BitConverter_ToUInt16                    | .NET 8.0             |  0.0300 ns | 0.0293 ns | 0.0274 ns |  0.0280 ns |  0.020 |    0.02 |
| BitConverter_ToInt16                     | .NET 8.0             |  0.1737 ns | 0.0415 ns | 0.0388 ns |  0.1754 ns |  0.118 |    0.03 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.5731 ns | 0.0831 ns | 0.0737 ns |  1.5482 ns |  1.070 |    0.09 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.3410 ns | 0.0305 ns | 0.0220 ns |  0.3323 ns |  0.236 |    0.02 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.4890 ns | 0.1219 ns | 0.1141 ns |  1.4375 ns |  1.000 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.5602 ns | 0.1698 ns | 0.1588 ns |  1.5055 ns |  1.055 |    0.14 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.1599 ns | 0.0412 ns | 0.0344 ns |  0.1575 ns |  0.109 |    0.03 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.1942 ns | 0.0649 ns | 0.0607 ns |  0.1881 ns |  0.132 |    0.05 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1755 ns | 0.0439 ns | 0.0410 ns |  0.1674 ns |  0.119 |    0.03 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1172 ns | 0.0231 ns | 0.0153 ns |  0.1182 ns |  0.080 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.5924 ns | 0.1643 ns | 0.1537 ns |  2.5585 ns |  1.751 |    0.18 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.8909 ns | 0.0450 ns | 0.0298 ns |  0.8819 ns |  0.612 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.3080 ns | 0.0725 ns | 0.0566 ns |  2.3259 ns |  1.582 |    0.10 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.3821 ns | 0.0865 ns | 0.0809 ns |  2.3610 ns |  1.609 |    0.15 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.7538 ns | 0.0734 ns | 0.0687 ns |  0.7367 ns |  0.508 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.8435 ns | 0.0735 ns | 0.0688 ns |  0.8551 ns |  0.569 |    0.06 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.1384 ns | 0.0312 ns | 0.0276 ns |  0.1333 ns |  0.094 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.1582 ns | 0.0255 ns | 0.0199 ns |  0.1656 ns |  0.108 |    0.01 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.5923 ns | 0.0760 ns | 0.0711 ns |  1.5717 ns |  1.074 |    0.08 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.4429 ns | 0.0628 ns | 0.0587 ns |  0.4571 ns |  0.298 |    0.03 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.4223 ns | 0.0896 ns | 0.0838 ns |  1.4060 ns |  0.961 |    0.09 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.4146 ns | 0.0608 ns | 0.0568 ns |  1.4393 ns |  0.955 |    0.08 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1608 ns | 0.0311 ns | 0.0276 ns |  0.1590 ns |  0.110 |    0.02 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.1957 ns | 0.0448 ns | 0.0419 ns |  0.2025 ns |  0.132 |    0.03 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.1512 ns | 0.0334 ns | 0.0313 ns |  0.1508 ns |  0.102 |    0.02 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.0333 ns | 0.0353 ns | 0.0330 ns |  0.0322 ns |  0.022 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  2.5717 ns | 0.1142 ns | 0.1069 ns |  2.6083 ns |  1.737 |    0.16 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  1.9840 ns | 0.0864 ns | 0.0766 ns |  1.9948 ns |  1.349 |    0.10 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  2.2369 ns | 0.0724 ns | 0.0604 ns |  2.2529 ns |  1.523 |    0.11 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  2.1362 ns | 0.0932 ns | 0.0827 ns |  2.1536 ns |  1.454 |    0.13 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  2.2421 ns | 0.0887 ns | 0.0830 ns |  2.2405 ns |  1.515 |    0.14 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  2.2513 ns | 0.0727 ns | 0.0433 ns |  2.2596 ns |  1.541 |    0.09 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  1.7174 ns | 0.0860 ns | 0.0763 ns |  1.7024 ns |  1.168 |    0.10 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  1.5412 ns | 0.1075 ns | 0.0953 ns |  1.5107 ns |  1.048 |    0.09 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 |  3.1361 ns | 0.1112 ns | 0.0929 ns |  3.1445 ns |  2.134 |    0.14 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 |  2.2444 ns | 0.1326 ns | 0.1241 ns |  2.2407 ns |  1.514 |    0.13 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 |  2.9802 ns | 0.1501 ns | 0.1404 ns |  2.9983 ns |  2.011 |    0.17 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 |  1.4217 ns | 0.0700 ns | 0.0655 ns |  1.4197 ns |  0.962 |    0.10 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 |  1.6422 ns | 0.0935 ns | 0.0875 ns |  1.6229 ns |  1.106 |    0.07 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 |  0.5927 ns | 0.0338 ns | 0.0316 ns |  0.5925 ns |  0.399 |    0.03 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 |  2.9691 ns | 0.0840 ns | 0.0786 ns |  2.9744 ns |  2.004 |    0.14 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 |  1.0119 ns | 0.1264 ns | 0.1121 ns |  0.9664 ns |  0.688 |    0.09 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 | 13.0455 ns | 0.2418 ns | 0.1599 ns | 13.0132 ns |  8.968 |    0.60 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 16.8484 ns | 0.4896 ns | 0.4580 ns | 16.7315 ns | 11.368 |    0.79 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 | 11.7936 ns | 0.4324 ns | 0.3833 ns | 11.7245 ns |  8.014 |    0.55 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 | 12.2615 ns | 0.4413 ns | 0.4128 ns | 12.2679 ns |  8.269 |    0.55 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  8.3942 ns | 0.2442 ns | 0.2285 ns |  8.3918 ns |  5.665 |    0.40 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  8.3959 ns | 0.2720 ns | 0.2544 ns |  8.3591 ns |  5.672 |    0.49 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  7.6027 ns | 0.1844 ns | 0.1725 ns |  7.5804 ns |  5.132 |    0.38 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  7.7213 ns | 0.2150 ns | 0.2011 ns |  7.6879 ns |  5.216 |    0.44 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  5.1955 ns | 0.1338 ns | 0.1251 ns |  5.1941 ns |  3.510 |    0.30 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 13.6154 ns | 0.3948 ns | 0.3500 ns | 13.6069 ns |  9.255 |    0.63 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  7.4796 ns | 0.2753 ns | 0.2441 ns |  7.5513 ns |  5.091 |    0.45 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  7.2329 ns | 0.1296 ns | 0.1082 ns |  7.2341 ns |  4.925 |    0.35 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  3.0007 ns | 0.1325 ns | 0.1106 ns |  2.9931 ns |  2.044 |    0.17 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.9868 ns | 0.1672 ns | 0.1564 ns |  2.9694 ns |  2.019 |    0.21 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  2.1787 ns | 0.1736 ns | 0.1624 ns |  2.1932 ns |  1.472 |    0.17 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  2.1764 ns | 0.1153 ns | 0.1078 ns |  2.1716 ns |  1.467 |    0.10 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 | 13.1642 ns | 0.3026 ns | 0.2830 ns | 13.1415 ns |  8.883 |    0.61 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 17.3574 ns | 0.5499 ns | 0.5144 ns | 17.3742 ns | 11.729 |    1.05 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 | 11.8252 ns | 0.3325 ns | 0.3110 ns | 11.9247 ns |  7.976 |    0.51 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 | 12.2828 ns | 0.9247 ns | 0.8649 ns | 11.8927 ns |  8.290 |    0.81 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  8.4972 ns | 0.2166 ns | 0.2026 ns |  8.4814 ns |  5.734 |    0.41 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  8.3768 ns | 0.2297 ns | 0.1918 ns |  8.3446 ns |  5.704 |    0.43 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  7.3166 ns | 0.0903 ns | 0.0472 ns |  7.3065 ns |  4.971 |    0.33 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  7.6867 ns | 0.1619 ns | 0.1264 ns |  7.6522 ns |  5.276 |    0.40 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  4.1689 ns | 0.1736 ns | 0.1539 ns |  4.1444 ns |  2.836 |    0.24 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  7.8612 ns | 0.3161 ns | 0.2957 ns |  7.7604 ns |  5.312 |    0.49 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  5.2377 ns | 0.1668 ns | 0.1560 ns |  5.2072 ns |  3.534 |    0.24 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  5.1120 ns | 0.1698 ns | 0.1588 ns |  5.1405 ns |  3.453 |    0.30 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  3.4557 ns | 0.1447 ns | 0.1353 ns |  3.4994 ns |  2.333 |    0.20 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  3.4505 ns | 0.0886 ns | 0.0692 ns |  3.4293 ns |  2.368 |    0.18 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  2.8882 ns | 0.0755 ns | 0.0499 ns |  2.9047 ns |  1.986 |    0.14 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  2.8646 ns | 0.1020 ns | 0.0905 ns |  2.8394 ns |  1.950 |    0.17 |

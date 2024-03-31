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
| BitConverter_ToDouble                    | .NET 8.0             |  1.6508 ns | 0.0679 ns | 0.0567 ns |  1.6627 ns |  1.20 |    0.06 |
| BitConverter_ToFloat                     | .NET 8.0             |  1.8562 ns | 0.0905 ns | 0.0847 ns |  1.8776 ns |  1.36 |    0.08 |
| BitConverter_ToUInt64                    | .NET 8.0             |  1.4786 ns | 0.1021 ns | 0.0955 ns |  1.4888 ns |  1.07 |    0.05 |
| BitConverter_ToInt64                     | .NET 8.0             |  2.0230 ns | 0.1337 ns | 0.1251 ns |  2.0515 ns |  1.48 |    0.10 |
| BitConverter_ToUInt32                    | .NET 8.0             |  1.4657 ns | 0.1213 ns | 0.1075 ns |  1.4869 ns |  1.09 |    0.08 |
| BitConverter_ToInt32                     | .NET 8.0             |  1.9981 ns | 0.1143 ns | 0.1069 ns |  2.0122 ns |  1.46 |    0.10 |
| BitConverter_ToUInt16                    | .NET 8.0             |  3.9306 ns | 0.1295 ns | 0.1148 ns |  3.9434 ns |  2.88 |    0.11 |
| BitConverter_ToInt16                     | .NET 8.0             |  3.9043 ns | 0.1823 ns | 0.1705 ns |  3.9697 ns |  2.90 |    0.12 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.4384 ns | 0.0692 ns | 0.0647 ns |  1.4470 ns |  1.05 |    0.07 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.1876 ns | 0.0399 ns | 0.0374 ns |  0.1861 ns |  0.14 |    0.03 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.3698 ns | 0.0503 ns | 0.0364 ns |  1.3601 ns |  1.00 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.4219 ns | 0.0764 ns | 0.0677 ns |  1.4221 ns |  1.05 |    0.06 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.1756 ns | 0.0351 ns | 0.0328 ns |  0.1849 ns |  0.13 |    0.03 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.1845 ns | 0.0284 ns | 0.0238 ns |  0.1837 ns |  0.14 |    0.02 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1482 ns | 0.0278 ns | 0.0217 ns |  0.1458 ns |  0.11 |    0.02 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1852 ns | 0.0304 ns | 0.0254 ns |  0.1804 ns |  0.14 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.5032 ns | 0.0752 ns | 0.0587 ns |  2.5120 ns |  1.83 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.8534 ns | 0.0608 ns | 0.0508 ns |  0.8568 ns |  0.62 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.3972 ns | 0.0844 ns | 0.0705 ns |  2.4066 ns |  1.75 |    0.07 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.4384 ns | 0.2095 ns | 0.1959 ns |  2.4037 ns |  1.80 |    0.17 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.6477 ns | 0.1205 ns | 0.1069 ns |  0.6233 ns |  0.44 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.7216 ns | 0.1028 ns | 0.0961 ns |  0.7015 ns |  0.54 |    0.07 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.4103 ns | 0.0404 ns | 0.0378 ns |  0.4143 ns |  0.30 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.4350 ns | 0.0577 ns | 0.0540 ns |  0.4318 ns |  0.30 |    0.03 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.3115 ns | 0.1555 ns | 0.1454 ns |  1.2778 ns |  0.96 |    0.12 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.1912 ns | 0.0536 ns | 0.0418 ns |  0.2001 ns |  0.14 |    0.03 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.4724 ns | 0.1084 ns | 0.1014 ns |  1.4689 ns |  1.09 |    0.07 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.2810 ns | 0.0748 ns | 0.0663 ns |  1.2746 ns |  0.93 |    0.04 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1433 ns | 0.0296 ns | 0.0214 ns |  0.1369 ns |  0.10 |    0.02 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.1511 ns | 0.0292 ns | 0.0228 ns |  0.1510 ns |  0.11 |    0.02 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.1570 ns | 0.0134 ns | 0.0089 ns |  0.1582 ns |  0.11 |    0.01 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.0159 ns | 0.0228 ns | 0.0135 ns |  0.0103 ns |  0.01 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  0.7928 ns | 0.0502 ns | 0.0470 ns |  0.8004 ns |  0.58 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  0.2319 ns | 0.1156 ns | 0.1081 ns |  0.2141 ns |  0.14 |    0.07 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  0.7046 ns | 0.0934 ns | 0.0874 ns |  0.7033 ns |  0.52 |    0.07 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  0.7411 ns | 0.0812 ns | 0.0759 ns |  0.7527 ns |  0.56 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  0.2204 ns | 0.0611 ns | 0.0571 ns |  0.2185 ns |  0.15 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  0.1634 ns | 0.0370 ns | 0.0346 ns |  0.1671 ns |  0.11 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  0.1490 ns | 0.0398 ns | 0.0373 ns |  0.1470 ns |  0.12 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  0.1430 ns | 0.0255 ns | 0.0169 ns |  0.1458 ns |  0.10 |    0.01 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 | 27.3077 ns | 0.6926 ns | 0.6140 ns | 27.0722 ns | 19.91 |    0.76 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 | 25.7478 ns | 0.8095 ns | 0.7572 ns | 25.4394 ns | 18.93 |    0.75 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 | 28.7817 ns | 0.5841 ns | 0.4878 ns | 28.8071 ns | 21.10 |    0.70 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 | 28.2197 ns | 0.8647 ns | 0.8089 ns | 28.3937 ns | 20.62 |    0.73 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 | 26.9085 ns | 0.5932 ns | 0.5549 ns | 26.6911 ns | 19.74 |    0.47 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 | 25.5150 ns | 0.7342 ns | 0.6867 ns | 25.3994 ns | 18.60 |    0.84 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 | 25.9183 ns | 0.5128 ns | 0.3708 ns | 25.7777 ns | 18.93 |    0.52 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 | 24.0299 ns | 0.6333 ns | 0.5614 ns | 23.8899 ns | 17.48 |    0.61 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 |  3.2445 ns | 0.0841 ns | 0.0656 ns |  3.2306 ns |  2.37 |    0.08 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 12.0181 ns | 0.2521 ns | 0.1668 ns | 12.0032 ns |  8.76 |    0.24 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 |  3.2840 ns | 0.0912 ns | 0.0762 ns |  3.3032 ns |  2.39 |    0.08 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 |  3.1506 ns | 0.1073 ns | 0.0896 ns |  3.1539 ns |  2.29 |    0.11 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  1.8340 ns | 0.0737 ns | 0.0653 ns |  1.8354 ns |  1.33 |    0.05 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  1.8623 ns | 0.1504 ns | 0.1407 ns |  1.7920 ns |  1.34 |    0.12 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  1.0298 ns | 0.0739 ns | 0.0691 ns |  1.0300 ns |  0.74 |    0.05 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  1.0739 ns | 0.0616 ns | 0.0576 ns |  1.0676 ns |  0.77 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  5.6601 ns | 0.2185 ns | 0.2044 ns |  5.6172 ns |  4.09 |    0.10 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 13.0377 ns | 0.2494 ns | 0.1650 ns | 13.0025 ns |  9.50 |    0.19 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  6.8422 ns | 0.1077 ns | 0.0713 ns |  6.8238 ns |  4.99 |    0.15 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.9822 ns | 0.1437 ns | 0.1039 ns |  7.0124 ns |  5.10 |    0.13 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  3.4185 ns | 0.1205 ns | 0.1127 ns |  3.4565 ns |  2.51 |    0.08 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  3.4396 ns | 0.1576 ns | 0.1474 ns |  3.4143 ns |  2.50 |    0.07 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  2.1879 ns | 0.1050 ns | 0.0983 ns |  2.2097 ns |  1.60 |    0.09 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  2.1756 ns | 0.1086 ns | 0.1016 ns |  2.1405 ns |  1.61 |    0.09 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 |  3.0330 ns | 0.1071 ns | 0.1001 ns |  3.0099 ns |  2.19 |    0.10 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 11.8597 ns | 0.3220 ns | 0.3012 ns | 11.8966 ns |  8.68 |    0.31 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 |  3.6010 ns | 0.1099 ns | 0.1028 ns |  3.5839 ns |  2.62 |    0.13 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 |  3.1390 ns | 0.0659 ns | 0.0436 ns |  3.1505 ns |  2.29 |    0.06 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  1.6921 ns | 0.0693 ns | 0.0649 ns |  1.6928 ns |  1.24 |    0.05 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  1.6600 ns | 0.0595 ns | 0.0557 ns |  1.6787 ns |  1.22 |    0.06 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  1.0546 ns | 0.0401 ns | 0.0313 ns |  1.0557 ns |  0.77 |    0.03 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  1.0889 ns | 0.0452 ns | 0.0423 ns |  1.0901 ns |  0.80 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  2.7042 ns | 0.0282 ns | 0.0186 ns |  2.7087 ns |  1.97 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  6.4451 ns | 0.1120 ns | 0.0741 ns |  6.4407 ns |  4.70 |    0.12 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  2.4458 ns | 0.0715 ns | 0.0517 ns |  2.4646 ns |  1.79 |    0.06 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  2.4502 ns | 0.0712 ns | 0.0594 ns |  2.4497 ns |  1.79 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  0.7910 ns | 0.0320 ns | 0.0212 ns |  0.7968 ns |  0.58 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  0.9548 ns | 0.1291 ns | 0.1144 ns |  0.9862 ns |  0.69 |    0.10 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  0.7644 ns | 0.1001 ns | 0.0887 ns |  0.7573 ns |  0.56 |    0.07 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  0.6386 ns | 0.0338 ns | 0.0264 ns |  0.6409 ns |  0.47 |    0.02 |

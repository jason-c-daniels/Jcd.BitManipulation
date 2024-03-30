```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-NGSTAA : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-DGGSAB : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```
| Method                                   | Runtime              | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD |
|----------------------------------------- |--------------------- |-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  0.0544 ns | 0.0493 ns | 0.0461 ns |  0.0499 ns | 0.037 |    0.03 |
| BitConverter_ToFloat                     | .NET 8.0             |  0.0034 ns | 0.0090 ns | 0.0079 ns |  0.0000 ns | 0.002 |    0.01 |
| BitConverter_ToUInt64                    | .NET 8.0             |  0.0035 ns | 0.0103 ns | 0.0086 ns |  0.0000 ns | 0.002 |    0.01 |
| BitConverter_ToInt64                     | .NET 8.0             |  0.1823 ns | 0.0257 ns | 0.0186 ns |  0.1861 ns | 0.127 |    0.01 |
| BitConverter_ToUInt32                    | .NET 8.0             |  0.0620 ns | 0.0478 ns | 0.0447 ns |  0.0502 ns | 0.044 |    0.03 |
| BitConverter_ToInt32                     | .NET 8.0             |  0.0076 ns | 0.0215 ns | 0.0201 ns |  0.0000 ns | 0.006 |    0.02 |
| BitConverter_ToUInt16                    | .NET 8.0             |  0.0132 ns | 0.0192 ns | 0.0127 ns |  0.0119 ns | 0.009 |    0.01 |
| BitConverter_ToInt16                     | .NET 8.0             |  0.1037 ns | 0.0443 ns | 0.0414 ns |  0.0893 ns | 0.072 |    0.03 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.5881 ns | 0.1329 ns | 0.1243 ns |  1.5970 ns | 1.103 |    0.11 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.4891 ns | 0.0861 ns | 0.0763 ns |  0.5051 ns | 0.338 |    0.05 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.4427 ns | 0.0649 ns | 0.0607 ns |  1.4506 ns | 1.000 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.3066 ns | 0.0493 ns | 0.0356 ns |  1.3020 ns | 0.910 |    0.06 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.3566 ns | 0.0504 ns | 0.0471 ns |  0.3518 ns | 0.248 |    0.04 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.4329 ns | 0.0944 ns | 0.0837 ns |  0.4078 ns | 0.301 |    0.06 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1116 ns | 0.0262 ns | 0.0232 ns |  0.1094 ns | 0.078 |    0.02 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1423 ns | 0.0134 ns | 0.0089 ns |  0.1422 ns | 0.099 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.3370 ns | 0.0393 ns | 0.0205 ns |  2.3423 ns | 1.609 |    0.08 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.9476 ns | 0.0958 ns | 0.0849 ns |  0.9637 ns | 0.656 |    0.06 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.2445 ns | 0.0815 ns | 0.0681 ns |  2.2433 ns | 1.558 |    0.08 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.3133 ns | 0.1199 ns | 0.1122 ns |  2.3228 ns | 1.606 |    0.10 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.6883 ns | 0.0380 ns | 0.0297 ns |  0.6857 ns | 0.478 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.7139 ns | 0.0428 ns | 0.0379 ns |  0.7077 ns | 0.495 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.1750 ns | 0.0495 ns | 0.0439 ns |  0.1750 ns | 0.121 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.1520 ns | 0.0462 ns | 0.0409 ns |  0.1408 ns | 0.106 |    0.03 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.4311 ns | 0.0199 ns | 0.0119 ns |  1.4344 ns | 0.991 |    0.05 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.3743 ns | 0.0316 ns | 0.0228 ns |  0.3733 ns | 0.260 |    0.02 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.2841 ns | 0.0455 ns | 0.0301 ns |  1.2773 ns | 0.895 |    0.04 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.2936 ns | 0.0332 ns | 0.0197 ns |  1.2961 ns | 0.896 |    0.05 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1309 ns | 0.0219 ns | 0.0145 ns |  0.1332 ns | 0.091 |    0.01 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.1304 ns | 0.0154 ns | 0.0102 ns |  0.1311 ns | 0.091 |    0.01 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.0015 ns | 0.0051 ns | 0.0034 ns |  0.0000 ns | 0.001 |    0.00 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.1390 ns | 0.0126 ns | 0.0083 ns |  0.1368 ns | 0.097 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  0.6858 ns | 0.0295 ns | 0.0176 ns |  0.6808 ns | 0.475 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  0.1766 ns | 0.0297 ns | 0.0215 ns |  0.1877 ns | 0.123 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  0.6764 ns | 0.0730 ns | 0.0683 ns |  0.6570 ns | 0.470 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  0.6622 ns | 0.0776 ns | 0.0726 ns |  0.6652 ns | 0.459 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  0.2374 ns | 0.1610 ns | 0.1345 ns |  0.2234 ns | 0.165 |    0.09 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  0.1850 ns | 0.1146 ns | 0.1072 ns |  0.1308 ns | 0.130 |    0.08 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  0.1703 ns | 0.0663 ns | 0.0620 ns |  0.1644 ns | 0.118 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  0.1620 ns | 0.0343 ns | 0.0320 ns |  0.1524 ns | 0.112 |    0.02 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 |  2.7467 ns | 0.0497 ns | 0.0328 ns |  2.7497 ns | 1.915 |    0.09 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 |  1.9684 ns | 0.0561 ns | 0.0371 ns |  1.9730 ns | 1.373 |    0.09 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 |  2.8868 ns | 0.1195 ns | 0.1118 ns |  2.8776 ns | 2.003 |    0.08 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 |  1.3758 ns | 0.0816 ns | 0.0763 ns |  1.3507 ns | 0.955 |    0.07 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 |  1.8091 ns | 0.1241 ns | 0.1100 ns |  1.7716 ns | 1.252 |    0.07 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 |  0.5250 ns | 0.0532 ns | 0.0472 ns |  0.5255 ns | 0.363 |    0.03 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 |  2.9407 ns | 0.1292 ns | 0.1145 ns |  2.9342 ns | 2.039 |    0.13 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 |  0.9374 ns | 0.0783 ns | 0.0732 ns |  0.9161 ns | 0.650 |    0.04 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 |  4.0013 ns | 1.0560 ns | 0.8245 ns |  3.7847 ns | 2.768 |    0.51 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 12.1447 ns | 0.2623 ns | 0.2326 ns | 12.1080 ns | 8.414 |    0.36 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 |  3.7824 ns | 0.1161 ns | 0.0970 ns |  3.7745 ns | 2.626 |    0.13 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 |  3.9158 ns | 0.1653 ns | 0.1465 ns |  3.9141 ns | 2.713 |    0.15 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  1.9601 ns | 0.0641 ns | 0.0536 ns |  1.9646 ns | 1.361 |    0.08 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  1.9856 ns | 0.0581 ns | 0.0384 ns |  1.9750 ns | 1.383 |    0.06 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  1.0003 ns | 0.0444 ns | 0.0393 ns |  0.9857 ns | 0.693 |    0.04 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  1.0769 ns | 0.0461 ns | 0.0360 ns |  1.0795 ns | 0.748 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  5.0705 ns | 0.1188 ns | 0.0859 ns |  5.0905 ns | 3.527 |    0.14 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 13.3425 ns | 0.4486 ns | 0.4196 ns | 13.4814 ns | 9.265 |    0.51 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  7.0491 ns | 0.1119 ns | 0.0740 ns |  7.0413 ns | 4.914 |    0.24 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.9890 ns | 0.1627 ns | 0.0968 ns |  6.9714 ns | 4.843 |    0.30 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  2.8613 ns | 0.0779 ns | 0.0650 ns |  2.8810 ns | 1.986 |    0.09 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.9773 ns | 0.1008 ns | 0.0943 ns |  2.9914 ns | 2.066 |    0.07 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  2.1113 ns | 0.0628 ns | 0.0588 ns |  2.1079 ns | 1.466 |    0.08 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  2.2104 ns | 0.1223 ns | 0.1144 ns |  2.2436 ns | 1.535 |    0.11 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 |  3.1591 ns | 0.0542 ns | 0.0323 ns |  3.1616 ns | 2.188 |    0.11 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 12.1566 ns | 0.2657 ns | 0.1921 ns | 12.1833 ns | 8.458 |    0.37 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 |  3.2526 ns | 0.0885 ns | 0.0527 ns |  3.2497 ns | 2.253 |    0.13 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 |  2.7734 ns | 0.0502 ns | 0.0332 ns |  2.7751 ns | 1.934 |    0.11 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  1.3414 ns | 0.0485 ns | 0.0430 ns |  1.3427 ns | 0.929 |    0.05 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  1.3215 ns | 0.0440 ns | 0.0262 ns |  1.3130 ns | 0.915 |    0.04 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  1.0594 ns | 0.0411 ns | 0.0297 ns |  1.0607 ns | 0.737 |    0.04 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  1.0234 ns | 0.0336 ns | 0.0200 ns |  1.0215 ns | 0.709 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  2.6074 ns | 0.0578 ns | 0.0483 ns |  2.5984 ns | 1.811 |    0.10 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  6.4842 ns | 0.3697 ns | 0.3458 ns |  6.4304 ns | 4.500 |    0.27 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  2.5867 ns | 0.0813 ns | 0.0761 ns |  2.5717 ns | 1.797 |    0.11 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  2.5313 ns | 0.1023 ns | 0.0957 ns |  2.5298 ns | 1.757 |    0.09 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  0.8254 ns | 0.0540 ns | 0.0451 ns |  0.8296 ns | 0.573 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  0.8078 ns | 0.0466 ns | 0.0436 ns |  0.8019 ns | 0.561 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  0.6977 ns | 0.0644 ns | 0.0571 ns |  0.6724 ns | 0.484 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  0.6848 ns | 0.0680 ns | 0.0636 ns |  0.7075 ns | 0.476 |    0.05 |

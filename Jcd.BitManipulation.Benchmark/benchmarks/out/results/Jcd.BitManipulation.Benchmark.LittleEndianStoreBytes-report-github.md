```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-LONWEL : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-UAIUVB : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```
| Method                                   | Runtime              | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD |
|----------------------------------------- |--------------------- |-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  0.0011 ns | 0.0031 ns | 0.0016 ns |  0.0000 ns | 0.001 |    0.00 |
| BitConverter_ToFloat                     | .NET 8.0             |  0.0042 ns | 0.0048 ns | 0.0025 ns |  0.0035 ns | 0.003 |    0.00 |
| BitConverter_ToUInt64                    | .NET 8.0             |  0.0003 ns | 0.0011 ns | 0.0007 ns |  0.0000 ns | 0.000 |    0.00 |
| BitConverter_ToInt64                     | .NET 8.0             |  0.1330 ns | 0.0066 ns | 0.0040 ns |  0.1321 ns | 0.102 |    0.00 |
| BitConverter_ToUInt32                    | .NET 8.0             |  0.0016 ns | 0.0023 ns | 0.0012 ns |  0.0016 ns | 0.001 |    0.00 |
| BitConverter_ToInt32                     | .NET 8.0             |  0.0036 ns | 0.0045 ns | 0.0027 ns |  0.0038 ns | 0.003 |    0.00 |
| BitConverter_ToUInt16                    | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns | 0.000 |    0.00 |
| BitConverter_ToInt16                     | .NET 8.0             |  0.1357 ns | 0.0071 ns | 0.0037 ns |  0.1369 ns | 0.104 |    0.00 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.4181 ns | 0.0125 ns | 0.0083 ns |  1.4169 ns | 1.084 |    0.03 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.3631 ns | 0.0211 ns | 0.0140 ns |  0.3617 ns | 0.278 |    0.01 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.3083 ns | 0.0463 ns | 0.0306 ns |  1.2994 ns | 1.000 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.3243 ns | 0.0218 ns | 0.0130 ns |  1.3205 ns | 1.011 |    0.02 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.3435 ns | 0.0211 ns | 0.0140 ns |  0.3382 ns | 0.263 |    0.01 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.3404 ns | 0.0112 ns | 0.0058 ns |  0.3423 ns | 0.260 |    0.01 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1388 ns | 0.0069 ns | 0.0046 ns |  0.1386 ns | 0.106 |    0.00 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1395 ns | 0.0042 ns | 0.0025 ns |  0.1398 ns | 0.106 |    0.00 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.2957 ns | 0.0453 ns | 0.0300 ns |  2.2943 ns | 1.755 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.7925 ns | 0.0189 ns | 0.0125 ns |  0.7922 ns | 0.606 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.1156 ns | 0.0171 ns | 0.0113 ns |  2.1152 ns | 1.618 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.1178 ns | 0.0125 ns | 0.0074 ns |  2.1159 ns | 1.617 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.6517 ns | 0.0130 ns | 0.0086 ns |  0.6505 ns | 0.498 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.6806 ns | 0.0365 ns | 0.0285 ns |  0.6733 ns | 0.525 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.1280 ns | 0.0179 ns | 0.0118 ns |  0.1289 ns | 0.098 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.3624 ns | 0.0274 ns | 0.0181 ns |  0.3685 ns | 0.277 |    0.01 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.4008 ns | 0.0158 ns | 0.0094 ns |  1.3974 ns | 1.069 |    0.02 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.3503 ns | 0.0072 ns | 0.0048 ns |  0.3517 ns | 0.268 |    0.01 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.2569 ns | 0.0132 ns | 0.0087 ns |  1.2568 ns | 0.961 |    0.02 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.2642 ns | 0.0059 ns | 0.0031 ns |  1.2650 ns | 0.965 |    0.02 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1290 ns | 0.0107 ns | 0.0071 ns |  0.1276 ns | 0.099 |    0.01 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.3578 ns | 0.0317 ns | 0.0265 ns |  0.3491 ns | 0.277 |    0.03 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.0012 ns | 0.0039 ns | 0.0026 ns |  0.0000 ns | 0.001 |    0.00 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.1350 ns | 0.0091 ns | 0.0060 ns |  0.1346 ns | 0.103 |    0.00 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  0.6747 ns | 0.0135 ns | 0.0089 ns |  0.6719 ns | 0.516 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  0.1462 ns | 0.0145 ns | 0.0096 ns |  0.1424 ns | 0.112 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  0.6071 ns | 0.0182 ns | 0.0120 ns |  0.6060 ns | 0.464 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  0.6108 ns | 0.0074 ns | 0.0044 ns |  0.6097 ns | 0.466 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  0.1352 ns | 0.0223 ns | 0.0133 ns |  0.1368 ns | 0.103 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  0.1419 ns | 0.0207 ns | 0.0123 ns |  0.1463 ns | 0.108 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  0.1101 ns | 0.0074 ns | 0.0049 ns |  0.1112 ns | 0.084 |    0.00 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  0.1220 ns | 0.0049 ns | 0.0029 ns |  0.1233 ns | 0.093 |    0.00 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 |  2.5960 ns | 0.0599 ns | 0.0396 ns |  2.6089 ns | 1.985 |    0.05 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 |  1.9333 ns | 0.0468 ns | 0.0309 ns |  1.9383 ns | 1.479 |    0.05 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 |  2.6551 ns | 0.0371 ns | 0.0221 ns |  2.6514 ns | 2.027 |    0.05 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 |  1.2216 ns | 0.0121 ns | 0.0072 ns |  1.2210 ns | 0.933 |    0.02 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 |  1.4014 ns | 0.0241 ns | 0.0159 ns |  1.4003 ns | 1.072 |    0.03 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 |  0.5330 ns | 0.0099 ns | 0.0066 ns |  0.5347 ns | 0.408 |    0.01 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 |  2.6459 ns | 0.0556 ns | 0.0368 ns |  2.6450 ns | 2.024 |    0.06 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 |  0.7731 ns | 0.0108 ns | 0.0056 ns |  0.7752 ns | 0.590 |    0.01 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 |  2.8423 ns | 0.0177 ns | 0.0117 ns |  2.8421 ns | 2.174 |    0.05 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 11.1649 ns | 0.0571 ns | 0.0378 ns | 11.1739 ns | 8.538 |    0.20 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 |  3.1606 ns | 0.0390 ns | 0.0232 ns |  3.1562 ns | 2.413 |    0.05 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 |  3.2591 ns | 0.0380 ns | 0.0251 ns |  3.2554 ns | 2.492 |    0.06 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  1.7761 ns | 0.0246 ns | 0.0163 ns |  1.7748 ns | 1.358 |    0.03 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  1.7873 ns | 0.0399 ns | 0.0264 ns |  1.7880 ns | 1.367 |    0.03 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  0.8948 ns | 0.0161 ns | 0.0107 ns |  0.8973 ns | 0.684 |    0.02 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  0.9287 ns | 0.0324 ns | 0.0214 ns |  0.9225 ns | 0.710 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  4.5853 ns | 0.0737 ns | 0.0487 ns |  4.5673 ns | 3.507 |    0.09 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 11.9621 ns | 0.1314 ns | 0.0869 ns | 11.9634 ns | 9.148 |    0.23 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  6.3022 ns | 0.1462 ns | 0.0967 ns |  6.3060 ns | 4.820 |    0.15 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.3290 ns | 0.0894 ns | 0.0591 ns |  6.3299 ns | 4.840 |    0.12 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  2.4284 ns | 0.0534 ns | 0.0353 ns |  2.4165 ns | 1.857 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.4815 ns | 0.1058 ns | 0.0990 ns |  2.4746 ns | 1.901 |    0.11 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  1.8791 ns | 0.1013 ns | 0.0898 ns |  1.8729 ns | 1.447 |    0.09 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  1.8273 ns | 0.0561 ns | 0.0438 ns |  1.8281 ns | 1.394 |    0.04 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 |  2.8933 ns | 0.0295 ns | 0.0195 ns |  2.8964 ns | 2.212 |    0.05 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 11.2624 ns | 0.0612 ns | 0.0405 ns | 11.2629 ns | 8.613 |    0.21 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 |  3.0862 ns | 0.0396 ns | 0.0236 ns |  3.0873 ns | 2.356 |    0.06 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 |  2.6612 ns | 0.0276 ns | 0.0183 ns |  2.6627 ns | 2.035 |    0.05 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  1.1778 ns | 0.0452 ns | 0.0378 ns |  1.1651 ns | 0.902 |    0.04 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  1.1909 ns | 0.0330 ns | 0.0218 ns |  1.1958 ns | 0.911 |    0.03 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  0.9464 ns | 0.0159 ns | 0.0105 ns |  0.9445 ns | 0.724 |    0.02 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  0.9342 ns | 0.0108 ns | 0.0072 ns |  0.9327 ns | 0.714 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  2.4734 ns | 0.0173 ns | 0.0103 ns |  2.4750 ns | 1.888 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  5.6818 ns | 0.0426 ns | 0.0254 ns |  5.6836 ns | 4.338 |    0.11 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  2.3236 ns | 0.0173 ns | 0.0115 ns |  2.3250 ns | 1.777 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  2.3065 ns | 0.0175 ns | 0.0116 ns |  2.3081 ns | 1.764 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  0.7679 ns | 0.0151 ns | 0.0100 ns |  0.7701 ns | 0.587 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  0.7721 ns | 0.0197 ns | 0.0117 ns |  0.7750 ns | 0.589 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  0.6186 ns | 0.0113 ns | 0.0067 ns |  0.6161 ns | 0.472 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  0.5572 ns | 0.0307 ns | 0.0203 ns |  0.5558 ns | 0.426 |    0.02 |

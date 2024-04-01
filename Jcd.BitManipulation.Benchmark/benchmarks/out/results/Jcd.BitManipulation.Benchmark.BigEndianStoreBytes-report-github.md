```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ROZSUB : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-TSPCCX : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                                   | Runtime              |       Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------------------------|----------------------|-----------:|----------:|----------:|------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  1.4664 ns | 0.0388 ns | 0.0231 ns |  1.21 |    0.02 |
| BitConverter_ToFloat                     | .NET 8.0             |  1.5055 ns | 0.0547 ns | 0.0485 ns |  1.26 |    0.04 |
| BitConverter_ToUInt64                    | .NET 8.0             |  1.2462 ns | 0.0247 ns | 0.0147 ns |  1.03 |    0.02 |
| BitConverter_ToInt64                     | .NET 8.0             |  1.6791 ns | 0.0354 ns | 0.0185 ns |  1.39 |    0.02 |
| BitConverter_ToUInt32                    | .NET 8.0             |  1.2780 ns | 0.0411 ns | 0.0272 ns |  1.05 |    0.02 |
| BitConverter_ToInt32                     | .NET 8.0             |  1.6501 ns | 0.0315 ns | 0.0209 ns |  1.37 |    0.02 |
| BitConverter_ToUInt16                    | .NET 8.0             |  3.5723 ns | 0.0392 ns | 0.0259 ns |  2.96 |    0.03 |
| BitConverter_ToInt16                     | .NET 8.0             |  3.7842 ns | 0.0587 ns | 0.0388 ns |  3.14 |    0.04 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.2707 ns | 0.0169 ns | 0.0112 ns |  1.05 |    0.02 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.3664 ns | 0.0277 ns | 0.0183 ns |  0.30 |    0.02 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.2084 ns | 0.0183 ns | 0.0109 ns |  1.00 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.2544 ns | 0.0334 ns | 0.0221 ns |  1.04 |    0.02 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.1473 ns | 0.0205 ns | 0.0136 ns |  0.12 |    0.01 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.1227 ns | 0.0149 ns | 0.0078 ns |  0.10 |    0.01 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1541 ns | 0.0136 ns | 0.0090 ns |  0.13 |    0.01 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1337 ns | 0.0161 ns | 0.0106 ns |  0.11 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.2607 ns | 0.0564 ns | 0.0373 ns |  1.87 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.7512 ns | 0.0365 ns | 0.0241 ns |  0.62 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.0327 ns | 0.0557 ns | 0.0368 ns |  1.69 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.0098 ns | 0.0173 ns | 0.0115 ns |  1.66 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.5459 ns | 0.0247 ns | 0.0163 ns |  0.45 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.5559 ns | 0.0217 ns | 0.0144 ns |  0.46 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.3359 ns | 0.0114 ns | 0.0060 ns |  0.28 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.3393 ns | 0.0212 ns | 0.0140 ns |  0.28 |    0.01 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.2678 ns | 0.0457 ns | 0.0330 ns |  1.05 |    0.04 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.1495 ns | 0.0141 ns | 0.0093 ns |  0.12 |    0.01 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.2435 ns | 0.0357 ns | 0.0236 ns |  1.03 |    0.02 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.2827 ns | 0.0502 ns | 0.0332 ns |  1.06 |    0.03 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.3552 ns | 0.0263 ns | 0.0174 ns |  0.30 |    0.02 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.3717 ns | 0.0290 ns | 0.0210 ns |  0.31 |    0.02 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.0149 ns | 0.0157 ns | 0.0104 ns |  0.01 |    0.01 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.1352 ns | 0.0134 ns | 0.0089 ns |  0.11 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  0.6755 ns | 0.0064 ns | 0.0038 ns |  0.56 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  0.1386 ns | 0.0099 ns | 0.0059 ns |  0.11 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  0.6046 ns | 0.0282 ns | 0.0186 ns |  0.50 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  0.6126 ns | 0.0219 ns | 0.0130 ns |  0.51 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  0.1309 ns | 0.0277 ns | 0.0200 ns |  0.10 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  0.1414 ns | 0.0221 ns | 0.0146 ns |  0.12 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  0.1413 ns | 0.0163 ns | 0.0108 ns |  0.12 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  0.1508 ns | 0.0162 ns | 0.0107 ns |  0.12 |    0.01 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 | 26.0936 ns | 0.1815 ns | 0.1080 ns | 21.59 |    0.21 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 | 23.7695 ns | 0.2704 ns | 0.1414 ns | 19.65 |    0.17 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 | 26.5311 ns | 0.5337 ns | 0.4731 ns | 21.90 |    0.61 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 | 25.5004 ns | 0.3912 ns | 0.2588 ns | 21.13 |    0.28 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 | 22.4731 ns | 0.3687 ns | 0.2439 ns | 18.57 |    0.23 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 | 22.6054 ns | 0.1556 ns | 0.0814 ns | 18.69 |    0.20 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 | 22.8381 ns | 0.1924 ns | 0.1145 ns | 18.90 |    0.21 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 | 20.9561 ns | 0.2506 ns | 0.1311 ns | 17.33 |    0.19 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 | 11.9066 ns | 0.0802 ns | 0.0530 ns |  9.85 |    0.10 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 15.6733 ns | 0.1951 ns | 0.1161 ns | 12.97 |    0.15 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 | 10.9672 ns | 0.2325 ns | 0.1538 ns |  9.07 |    0.12 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 | 10.7976 ns | 0.1800 ns | 0.1190 ns |  8.92 |    0.13 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  8.0116 ns | 0.0779 ns | 0.0515 ns |  6.63 |    0.09 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  8.2867 ns | 0.0530 ns | 0.0315 ns |  6.86 |    0.06 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  7.2146 ns | 0.0546 ns | 0.0361 ns |  5.98 |    0.06 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  7.4600 ns | 0.0318 ns | 0.0189 ns |  6.17 |    0.06 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  4.9682 ns | 0.1169 ns | 0.0976 ns |  4.11 |    0.10 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 11.8673 ns | 0.1944 ns | 0.1286 ns |  9.81 |    0.09 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  6.4378 ns | 0.1176 ns | 0.0778 ns |  5.33 |    0.09 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.3535 ns | 0.0656 ns | 0.0391 ns |  5.26 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  2.9983 ns | 0.0752 ns | 0.0544 ns |  2.49 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.9242 ns | 0.0628 ns | 0.0415 ns |  2.42 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  1.8745 ns | 0.0522 ns | 0.0311 ns |  1.55 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  1.8643 ns | 0.0443 ns | 0.0293 ns |  1.54 |    0.04 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 | 11.9691 ns | 0.0391 ns | 0.0258 ns |  9.91 |    0.08 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 15.7909 ns | 0.1689 ns | 0.1117 ns | 13.08 |    0.12 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 | 10.7083 ns | 0.1336 ns | 0.0884 ns |  8.86 |    0.10 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 | 10.5729 ns | 0.0545 ns | 0.0324 ns |  8.75 |    0.08 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  9.0165 ns | 0.6024 ns | 0.5030 ns |  7.54 |    0.46 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  8.0411 ns | 0.0573 ns | 0.0379 ns |  6.65 |    0.06 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  7.4006 ns | 0.0561 ns | 0.0371 ns |  6.12 |    0.08 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  7.4340 ns | 0.0721 ns | 0.0477 ns |  6.15 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  2.5223 ns | 0.0210 ns | 0.0139 ns |  2.09 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  5.7530 ns | 0.1330 ns | 0.1038 ns |  4.78 |    0.08 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  2.3814 ns | 0.0279 ns | 0.0185 ns |  1.97 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  2.4101 ns | 0.0684 ns | 0.0534 ns |  2.01 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  0.7785 ns | 0.0395 ns | 0.0330 ns |  0.65 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  0.6308 ns | 0.0368 ns | 0.0243 ns |  0.52 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  0.6123 ns | 0.0155 ns | 0.0103 ns |  0.51 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  0.5819 ns | 0.0336 ns | 0.0243 ns |  0.48 |    0.02 |

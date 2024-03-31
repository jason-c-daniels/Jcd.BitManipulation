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

| Method                                   | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  0.0003 ns | 0.0011 ns | 0.0010 ns |  0.0000 ns | 0.000 |    0.00 |
| BitConverter_ToFloat                     | .NET 8.0             |  0.0065 ns | 0.0164 ns | 0.0097 ns |  0.0013 ns | 0.005 |    0.01 |
| BitConverter_ToUInt64                    | .NET 8.0             |  0.0033 ns | 0.0114 ns | 0.0068 ns |  0.0000 ns | 0.002 |    0.01 |
| BitConverter_ToInt64                     | .NET 8.0             |  0.1396 ns | 0.0273 ns | 0.0143 ns |  0.1365 ns | 0.101 |    0.01 |
| BitConverter_ToUInt32                    | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns | 0.000 |    0.00 |
| BitConverter_ToInt32                     | .NET 8.0             |  0.0457 ns | 0.0433 ns | 0.0405 ns |  0.0463 ns | 0.033 |    0.03 |
| BitConverter_ToUInt16                    | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns | 0.000 |    0.00 |
| BitConverter_ToInt16                     | .NET 8.0             |  0.1428 ns | 0.0228 ns | 0.0136 ns |  0.1434 ns | 0.104 |    0.01 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.4582 ns | 0.0512 ns | 0.0454 ns |  1.4585 ns | 1.070 |    0.07 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.3941 ns | 0.0258 ns | 0.0154 ns |  0.3972 ns | 0.287 |    0.01 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.3612 ns | 0.0628 ns | 0.0587 ns |  1.3346 ns | 1.000 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.3494 ns | 0.0408 ns | 0.0243 ns |  1.3519 ns | 0.985 |    0.04 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.3506 ns | 0.0206 ns | 0.0136 ns |  0.3445 ns | 0.254 |    0.01 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.3569 ns | 0.0245 ns | 0.0162 ns |  0.3502 ns | 0.259 |    0.02 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1447 ns | 0.0272 ns | 0.0197 ns |  0.1353 ns | 0.105 |    0.02 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1255 ns | 0.0143 ns | 0.0085 ns |  0.1266 ns | 0.092 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.5154 ns | 0.2086 ns | 0.1849 ns |  2.5106 ns | 1.845 |    0.15 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.7251 ns | 0.0528 ns | 0.0412 ns |  0.7158 ns | 0.529 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.3530 ns | 0.2110 ns | 0.1974 ns |  2.3420 ns | 1.731 |    0.16 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.5473 ns | 0.4370 ns | 0.4088 ns |  2.4192 ns | 1.870 |    0.28 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.7468 ns | 0.1624 ns | 0.1519 ns |  0.7135 ns | 0.549 |    0.11 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.7251 ns | 0.0785 ns | 0.0695 ns |  0.7107 ns | 0.531 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.1404 ns | 0.0155 ns | 0.0081 ns |  0.1426 ns | 0.102 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.1749 ns | 0.0279 ns | 0.0185 ns |  0.1729 ns | 0.127 |    0.02 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.4240 ns | 0.0247 ns | 0.0147 ns |  1.4305 ns | 1.039 |    0.05 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.3534 ns | 0.0272 ns | 0.0162 ns |  0.3507 ns | 0.258 |    0.01 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.2636 ns | 0.0462 ns | 0.0275 ns |  1.2635 ns | 0.922 |    0.04 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.2598 ns | 0.0285 ns | 0.0170 ns |  1.2529 ns | 0.919 |    0.04 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1615 ns | 0.0214 ns | 0.0142 ns |  0.1643 ns | 0.117 |    0.01 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.1694 ns | 0.0280 ns | 0.0203 ns |  0.1674 ns | 0.123 |    0.02 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.0011 ns | 0.0061 ns | 0.0032 ns |  0.0000 ns | 0.001 |    0.00 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.0936 ns | 0.0265 ns | 0.0175 ns |  0.0908 ns | 0.068 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  0.7000 ns | 0.0209 ns | 0.0125 ns |  0.7033 ns | 0.511 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  0.2070 ns | 0.0877 ns | 0.0821 ns |  0.2064 ns | 0.151 |    0.06 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  0.6388 ns | 0.0652 ns | 0.0578 ns |  0.6313 ns | 0.469 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  0.6309 ns | 0.0684 ns | 0.0640 ns |  0.6085 ns | 0.463 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  0.1268 ns | 0.0167 ns | 0.0111 ns |  0.1270 ns | 0.092 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  0.1960 ns | 0.0780 ns | 0.0691 ns |  0.1788 ns | 0.145 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  0.1470 ns | 0.0736 ns | 0.0653 ns |  0.1396 ns | 0.108 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  0.1298 ns | 0.0491 ns | 0.0436 ns |  0.1108 ns | 0.095 |    0.03 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 |  2.7028 ns | 0.1938 ns | 0.1718 ns |  2.6048 ns | 1.984 |    0.17 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 |  2.1380 ns | 0.1076 ns | 0.0954 ns |  2.1379 ns | 1.568 |    0.09 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 |  2.7863 ns | 0.1247 ns | 0.1105 ns |  2.7470 ns | 2.042 |    0.08 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 |  1.3471 ns | 0.0816 ns | 0.0763 ns |  1.3100 ns | 0.992 |    0.07 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 |  1.4060 ns | 0.0518 ns | 0.0405 ns |  1.3950 ns | 1.026 |    0.05 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 |  0.5369 ns | 0.0400 ns | 0.0334 ns |  0.5240 ns | 0.393 |    0.03 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 |  2.6407 ns | 0.0590 ns | 0.0460 ns |  2.6354 ns | 1.926 |    0.07 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 |  0.7473 ns | 0.0420 ns | 0.0393 ns |  0.7370 ns | 0.550 |    0.04 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 |  2.8813 ns | 0.0418 ns | 0.0277 ns |  2.8726 ns | 2.089 |    0.10 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 11.3003 ns | 0.1248 ns | 0.0825 ns | 11.2712 ns | 8.193 |    0.40 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 |  3.3768 ns | 0.0895 ns | 0.0647 ns |  3.3619 ns | 2.455 |    0.12 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 |  3.3143 ns | 0.0475 ns | 0.0314 ns |  3.3070 ns | 2.403 |    0.11 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  1.9058 ns | 0.0704 ns | 0.0588 ns |  1.9067 ns | 1.396 |    0.09 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  1.8047 ns | 0.0480 ns | 0.0251 ns |  1.8106 ns | 1.311 |    0.06 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  0.9212 ns | 0.0285 ns | 0.0189 ns |  0.9209 ns | 0.668 |    0.03 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  0.9945 ns | 0.0550 ns | 0.0515 ns |  0.9758 ns | 0.732 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  4.5340 ns | 0.0925 ns | 0.0612 ns |  4.5290 ns | 3.287 |    0.14 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 12.6730 ns | 0.3620 ns | 0.3209 ns | 12.6783 ns | 9.291 |    0.37 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  6.2577 ns | 0.2587 ns | 0.2293 ns |  6.2216 ns | 4.591 |    0.28 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.4459 ns | 0.1759 ns | 0.1559 ns |  6.4158 ns | 4.729 |    0.26 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  2.2873 ns | 0.0542 ns | 0.0323 ns |  2.2882 ns | 1.669 |    0.06 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.6176 ns | 0.0803 ns | 0.0712 ns |  2.6227 ns | 1.919 |    0.07 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  1.7238 ns | 0.0520 ns | 0.0344 ns |  1.7256 ns | 1.249 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  1.8101 ns | 0.0269 ns | 0.0178 ns |  1.8082 ns | 1.313 |    0.07 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 |  2.9160 ns | 0.0273 ns | 0.0180 ns |  2.9145 ns | 2.114 |    0.09 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 11.3787 ns | 0.0963 ns | 0.0573 ns | 11.3950 ns | 8.304 |    0.35 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 |  2.6067 ns | 0.0274 ns | 0.0181 ns |  2.6055 ns | 1.890 |    0.09 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 |  2.6406 ns | 0.0205 ns | 0.0136 ns |  2.6375 ns | 1.914 |    0.08 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  1.2188 ns | 0.0293 ns | 0.0194 ns |  1.2155 ns | 0.883 |    0.03 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  1.2024 ns | 0.0871 ns | 0.0727 ns |  1.1883 ns | 0.881 |    0.07 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  0.9670 ns | 0.0378 ns | 0.0274 ns |  0.9730 ns | 0.703 |    0.03 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  0.9264 ns | 0.0196 ns | 0.0129 ns |  0.9251 ns | 0.672 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  2.4813 ns | 0.0272 ns | 0.0162 ns |  2.4834 ns | 1.811 |    0.08 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  5.7968 ns | 0.1366 ns | 0.1211 ns |  5.7643 ns | 4.252 |    0.21 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  2.3948 ns | 0.0386 ns | 0.0255 ns |  2.3947 ns | 1.736 |    0.08 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  2.4108 ns | 0.0646 ns | 0.0427 ns |  2.4034 ns | 1.748 |    0.10 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  0.7597 ns | 0.0174 ns | 0.0115 ns |  0.7598 ns | 0.551 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  0.7843 ns | 0.0377 ns | 0.0250 ns |  0.7865 ns | 0.569 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  0.7003 ns | 0.0879 ns | 0.0779 ns |  0.6820 ns | 0.514 |    0.06 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  0.5784 ns | 0.0203 ns | 0.0121 ns |  0.5769 ns | 0.422 |    0.02 |

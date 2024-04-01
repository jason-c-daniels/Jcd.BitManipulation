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

| Method                                   | Runtime              |       Mean |     Error |    StdDev |     Median |  Ratio | RatioSD |
|------------------------------------------|----------------------|-----------:|----------:|----------:|-----------:|-------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  0.0079 ns | 0.0126 ns | 0.0083 ns |  0.0062 ns |  0.006 |    0.01 |
| BitConverter_ToFloat                     | .NET 8.0             |  0.0047 ns | 0.0063 ns | 0.0042 ns |  0.0038 ns |  0.004 |    0.00 |
| BitConverter_ToUInt64                    | .NET 8.0             |  0.0029 ns | 0.0041 ns | 0.0025 ns |  0.0031 ns |  0.002 |    0.00 |
| BitConverter_ToInt64                     | .NET 8.0             |  0.1408 ns | 0.0087 ns | 0.0052 ns |  0.1397 ns |  0.105 |    0.00 |
| BitConverter_ToUInt32                    | .NET 8.0             |  0.0087 ns | 0.0154 ns | 0.0102 ns |  0.0053 ns |  0.006 |    0.01 |
| BitConverter_ToInt32                     | .NET 8.0             |  0.0136 ns | 0.0149 ns | 0.0099 ns |  0.0121 ns |  0.010 |    0.01 |
| BitConverter_ToUInt16                    | .NET 8.0             |  0.0019 ns | 0.0041 ns | 0.0027 ns |  0.0007 ns |  0.001 |    0.00 |
| BitConverter_ToInt16                     | .NET 8.0             |  0.1414 ns | 0.0147 ns | 0.0097 ns |  0.1364 ns |  0.106 |    0.01 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.4224 ns | 0.0195 ns | 0.0102 ns |  1.4217 ns |  1.061 |    0.02 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.3716 ns | 0.0107 ns | 0.0064 ns |  0.3729 ns |  0.277 |    0.01 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.3373 ns | 0.0347 ns | 0.0230 ns |  1.3390 ns |  1.000 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.3076 ns | 0.0508 ns | 0.0396 ns |  1.3020 ns |  0.983 |    0.04 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.1541 ns | 0.0292 ns | 0.0273 ns |  0.1509 ns |  0.120 |    0.02 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.1349 ns | 0.0191 ns | 0.0126 ns |  0.1335 ns |  0.101 |    0.01 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1449 ns | 0.0216 ns | 0.0129 ns |  0.1441 ns |  0.108 |    0.01 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1440 ns | 0.0218 ns | 0.0144 ns |  0.1392 ns |  0.108 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.3231 ns | 0.0687 ns | 0.0536 ns |  2.3021 ns |  1.742 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.8852 ns | 0.0627 ns | 0.0587 ns |  0.9030 ns |  0.650 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.3347 ns | 0.1840 ns | 0.1721 ns |  2.2924 ns |  1.722 |    0.13 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.2990 ns | 0.0297 ns | 0.0197 ns |  2.3054 ns |  1.720 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.7211 ns | 0.0426 ns | 0.0377 ns |  0.7268 ns |  0.538 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.7729 ns | 0.0301 ns | 0.0158 ns |  0.7713 ns |  0.577 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.1260 ns | 0.0440 ns | 0.0390 ns |  0.1119 ns |  0.090 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.1163 ns | 0.0279 ns | 0.0166 ns |  0.1185 ns |  0.087 |    0.01 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.4546 ns | 0.0349 ns | 0.0183 ns |  1.4534 ns |  1.085 |    0.02 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.3700 ns | 0.0331 ns | 0.0259 ns |  0.3703 ns |  0.274 |    0.02 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.3457 ns | 0.0792 ns | 0.0740 ns |  1.3257 ns |  1.001 |    0.06 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.3768 ns | 0.1229 ns | 0.1150 ns |  1.3612 ns |  1.010 |    0.09 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1367 ns | 0.0629 ns | 0.0588 ns |  0.1283 ns |  0.110 |    0.05 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.1933 ns | 0.0195 ns | 0.0129 ns |  0.1898 ns |  0.145 |    0.01 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.1630 ns | 0.0341 ns | 0.0319 ns |  0.1564 ns |  0.117 |    0.03 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.1432 ns | 0.0147 ns | 0.0097 ns |  0.1420 ns |  0.107 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  0.6974 ns | 0.0371 ns | 0.0221 ns |  0.6973 ns |  0.521 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  0.1556 ns | 0.0269 ns | 0.0160 ns |  0.1532 ns |  0.116 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  0.5374 ns | 0.0354 ns | 0.0256 ns |  0.5262 ns |  0.402 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  0.6254 ns | 0.0381 ns | 0.0319 ns |  0.6193 ns |  0.465 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  0.1738 ns | 0.0479 ns | 0.0448 ns |  0.1663 ns |  0.138 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  0.1177 ns | 0.0245 ns | 0.0146 ns |  0.1145 ns |  0.088 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  0.0075 ns | 0.0138 ns | 0.0100 ns |  0.0000 ns |  0.006 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  0.1402 ns | 0.0183 ns | 0.0121 ns |  0.1424 ns |  0.105 |    0.01 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 |  2.7430 ns | 0.0576 ns | 0.0381 ns |  2.7480 ns |  2.052 |    0.06 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 |  1.9836 ns | 0.0535 ns | 0.0354 ns |  1.9835 ns |  1.484 |    0.03 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 |  2.6753 ns | 0.0733 ns | 0.0530 ns |  2.6721 ns |  2.001 |    0.05 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 |  1.2935 ns | 0.0409 ns | 0.0271 ns |  1.2916 ns |  0.968 |    0.03 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 |  1.4785 ns | 0.0522 ns | 0.0345 ns |  1.4805 ns |  1.106 |    0.04 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 |  0.5075 ns | 0.0263 ns | 0.0174 ns |  0.5058 ns |  0.380 |    0.02 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 |  2.7037 ns | 0.0762 ns | 0.0551 ns |  2.6907 ns |  2.025 |    0.05 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 |  0.8492 ns | 0.0595 ns | 0.0556 ns |  0.8574 ns |  0.621 |    0.04 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 | 11.9583 ns | 0.1959 ns | 0.1024 ns | 11.9489 ns |  8.924 |    0.15 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 15.8887 ns | 0.3812 ns | 0.3379 ns | 15.8662 ns | 11.902 |    0.28 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 | 11.2820 ns | 0.3323 ns | 0.3109 ns | 11.4027 ns |  8.420 |    0.32 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 | 11.1810 ns | 0.1479 ns | 0.0978 ns | 11.1884 ns |  8.364 |    0.18 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  7.8517 ns | 0.0806 ns | 0.0533 ns |  7.8340 ns |  5.873 |    0.10 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  7.9272 ns | 0.1516 ns | 0.1002 ns |  7.9071 ns |  5.929 |    0.09 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  7.1958 ns | 0.0952 ns | 0.0566 ns |  7.1986 ns |  5.371 |    0.11 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  7.2869 ns | 0.0886 ns | 0.0586 ns |  7.2805 ns |  5.451 |    0.11 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  4.6816 ns | 0.0540 ns | 0.0321 ns |  4.6900 ns |  3.494 |    0.06 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 12.6752 ns | 0.4585 ns | 0.4289 ns | 12.5903 ns |  9.398 |    0.39 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  6.5704 ns | 0.1412 ns | 0.0934 ns |  6.5755 ns |  4.915 |    0.11 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.5165 ns | 0.1193 ns | 0.0789 ns |  6.5343 ns |  4.874 |    0.08 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  2.6456 ns | 0.0660 ns | 0.0437 ns |  2.6381 ns |  1.979 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.5752 ns | 0.1065 ns | 0.0996 ns |  2.5705 ns |  1.936 |    0.07 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  1.9034 ns | 0.1079 ns | 0.1009 ns |  1.9162 ns |  1.454 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  1.8560 ns | 0.0591 ns | 0.0427 ns |  1.8771 ns |  1.386 |    0.04 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 | 12.1730 ns | 0.2530 ns | 0.2243 ns | 12.1964 ns |  9.090 |    0.26 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 16.0018 ns | 0.4991 ns | 0.4669 ns | 16.0968 ns | 12.047 |    0.35 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 | 10.9494 ns | 0.1629 ns | 0.0969 ns | 10.9206 ns |  8.172 |    0.18 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 | 10.9086 ns | 0.1196 ns | 0.0712 ns | 10.9110 ns |  8.141 |    0.15 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  8.3427 ns | 0.2533 ns | 0.2369 ns |  8.3542 ns |  6.253 |    0.15 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  7.9064 ns | 0.1154 ns | 0.0686 ns |  7.8833 ns |  5.901 |    0.10 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  7.2130 ns | 0.0359 ns | 0.0237 ns |  7.2035 ns |  5.395 |    0.10 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  7.4459 ns | 0.1631 ns | 0.1180 ns |  7.4425 ns |  5.578 |    0.13 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  2.5748 ns | 0.0544 ns | 0.0393 ns |  2.5876 ns |  1.925 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  5.8626 ns | 0.0883 ns | 0.0525 ns |  5.8523 ns |  4.376 |    0.09 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  2.3708 ns | 0.0339 ns | 0.0202 ns |  2.3758 ns |  1.769 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  2.4087 ns | 0.0612 ns | 0.0405 ns |  2.4110 ns |  1.802 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  0.7778 ns | 0.0184 ns | 0.0110 ns |  0.7800 ns |  0.580 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  0.7504 ns | 0.0082 ns | 0.0049 ns |  0.7506 ns |  0.560 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  0.6211 ns | 0.0203 ns | 0.0121 ns |  0.6198 ns |  0.463 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  0.5798 ns | 0.0333 ns | 0.0220 ns |  0.5804 ns |  0.434 |    0.02 |

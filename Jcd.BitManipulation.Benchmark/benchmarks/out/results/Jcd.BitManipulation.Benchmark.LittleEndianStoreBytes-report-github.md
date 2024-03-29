```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-AXMJZY : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-RMJZWN : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                               | Runtime              |       Mean |     Error |    StdDev |     Median |  Ratio | RatioSD |
|--------------------------------------|----------------------|-----------:|----------:|----------:|-----------:|-------:|--------:|
| BitConverter_ToDouble                | .NET 8.0             |  0.0119 ns | 0.0193 ns | 0.0180 ns |  0.0000 ns |  0.118 |    0.16 |
| BitConverter_ToFloat                 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| BitConverter_ToUInt64                | .NET 8.0             |  0.0064 ns | 0.0181 ns | 0.0131 ns |  0.0000 ns |  0.060 |    0.11 |
| BitConverter_ToInt64                 | .NET 8.0             |  0.1498 ns | 0.0205 ns | 0.0136 ns |  0.1488 ns |  1.154 |    0.14 |
| BitConverter_ToUInt32                | .NET 8.0             |  0.0008 ns | 0.0028 ns | 0.0015 ns |  0.0000 ns |  0.006 |    0.01 |
| BitConverter_ToInt32                 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| BitConverter_ToUInt16                | .NET 8.0             |  0.0090 ns | 0.0147 ns | 0.0097 ns |  0.0056 ns |  0.058 |    0.07 |
| BitConverter_ToInt16                 | .NET 8.0             |  0.1312 ns | 0.0130 ns | 0.0077 ns |  0.1320 ns |  1.000 |    0.00 |
| ByteIndexer_Double                   | .NET 8.0             |  1.4556 ns | 0.0685 ns | 0.0641 ns |  1.4416 ns | 11.267 |    0.87 |
| ByteIndexer_Float                    | .NET 8.0             |  0.4240 ns | 0.0619 ns | 0.0579 ns |  0.4293 ns |  3.092 |    0.65 |
| ByteIndexer_UInt64                   | .NET 8.0             |  1.3098 ns | 0.0476 ns | 0.0372 ns |  1.3145 ns |  9.956 |    0.69 |
| ByteIndexer_Int64                    | .NET 8.0             |  1.2364 ns | 0.0484 ns | 0.0320 ns |  1.2226 ns |  9.464 |    0.57 |
| ByteIndexer_UInt32                   | .NET 8.0             |  0.4189 ns | 0.0831 ns | 0.0737 ns |  0.4157 ns |  3.423 |    0.79 |
| ByteIndexer_Int32                    | .NET 8.0             |  0.3815 ns | 0.0519 ns | 0.0460 ns |  0.3671 ns |  2.865 |    0.46 |
| ByteIndexer_UInt16                   | .NET 8.0             |  0.1066 ns | 0.0259 ns | 0.0216 ns |  0.1088 ns |  0.802 |    0.13 |
| ByteIndexer_Int16                    | .NET 8.0             |  0.0855 ns | 0.0310 ns | 0.0290 ns |  0.0747 ns |  0.566 |    0.18 |
| ByteIndexer_On_ReadOnlySpanOf_Double | .NET 8.0             |  2.4072 ns | 0.0707 ns | 0.0552 ns |  2.4243 ns | 18.482 |    1.29 |
| ByteIndexer_On_ReadOnlySpanOf_Float  | .NET 8.0             |  0.7994 ns | 0.0812 ns | 0.0759 ns |  0.7748 ns |  6.065 |    0.59 |
| ByteIndexer_On_ReadOnlySpanOf_UInt64 | .NET 8.0             |  2.1505 ns | 0.0879 ns | 0.0734 ns |  2.1254 ns | 16.622 |    1.59 |
| ByteIndexer_On_ReadOnlySpanOf_Int64  | .NET 8.0             |  2.2737 ns | 0.1274 ns | 0.1129 ns |  2.2646 ns | 17.197 |    1.38 |
| ByteIndexer_On_ReadOnlySpanOf_UInt32 | .NET 8.0             |  0.7170 ns | 0.0916 ns | 0.0765 ns |  0.6794 ns |  5.412 |    0.61 |
| ByteIndexer_On_ReadOnlySpanOf_Int32  | .NET 8.0             |  0.6725 ns | 0.0652 ns | 0.0610 ns |  0.6587 ns |  5.164 |    0.65 |
| ByteIndexer_On_ReadOnlySpanOf_UInt16 | .NET 8.0             |  0.3692 ns | 0.0854 ns | 0.0667 ns |  0.3460 ns |  2.851 |    0.68 |
| ByteIndexer_On_ReadOnlySpanOf_Int16  | .NET 8.0             |  0.3425 ns | 0.0213 ns | 0.0141 ns |  0.3401 ns |  2.617 |    0.18 |
| ExtensionMethod_Double               | .NET 8.0             |  1.4155 ns | 0.0535 ns | 0.0387 ns |  1.3943 ns | 10.898 |    0.80 |
| ExtensionMethod_Float                | .NET 8.0             |  0.3635 ns | 0.0261 ns | 0.0173 ns |  0.3627 ns |  2.783 |    0.25 |
| ExtensionMethod_UInt64               | .NET 8.0             |  1.2611 ns | 0.0332 ns | 0.0219 ns |  1.2601 ns |  9.657 |    0.68 |
| ExtensionMethod_Int64                | .NET 8.0             |  1.2619 ns | 0.0412 ns | 0.0245 ns |  1.2554 ns |  9.648 |    0.59 |
| ExtensionMethod_UInt32               | .NET 8.0             |  0.1140 ns | 0.0135 ns | 0.0081 ns |  0.1155 ns |  0.870 |    0.05 |
| ExtensionMethod_Int32                | .NET 8.0             |  0.1150 ns | 0.0139 ns | 0.0083 ns |  0.1119 ns |  0.879 |    0.08 |
| ExtensionMethod_UInt16               | .NET 8.0             |  0.0006 ns | 0.0028 ns | 0.0017 ns |  0.0000 ns |  0.004 |    0.01 |
| ExtensionMethod_Int16                | .NET 8.0             |  0.1339 ns | 0.0160 ns | 0.0106 ns |  0.1353 ns |  1.036 |    0.07 |
| ExtensionMethod_ToDouble             | .NET 8.0             |  0.6614 ns | 0.0190 ns | 0.0126 ns |  0.6603 ns |  5.064 |    0.36 |
| ExtensionMethod_ToFloat              | .NET 8.0             |  0.3621 ns | 0.0296 ns | 0.0176 ns |  0.3569 ns |  2.769 |    0.21 |
| ExtensionMethod_ToUInt64             | .NET 8.0             |  0.6067 ns | 0.0259 ns | 0.0171 ns |  0.6072 ns |  4.628 |    0.28 |
| ExtensionMethod_ToInt64              | .NET 8.0             |  0.6037 ns | 0.0257 ns | 0.0170 ns |  0.6077 ns |  4.620 |    0.38 |
| ExtensionMethod_ToUInt32             | .NET 8.0             |  0.1215 ns | 0.0171 ns | 0.0113 ns |  0.1226 ns |  0.943 |    0.13 |
| ExtensionMethod_ToInt32              | .NET 8.0             |  0.1229 ns | 0.0185 ns | 0.0122 ns |  0.1258 ns |  0.935 |    0.08 |
| ExtensionMethod_ToUInt16             | .NET 8.0             |  0.0038 ns | 0.0092 ns | 0.0055 ns |  0.0000 ns |  0.028 |    0.04 |
| ExtensionMethod_ToInt16              | .NET 8.0             |  0.0033 ns | 0.0083 ns | 0.0055 ns |  0.0000 ns |  0.019 |    0.04 |
| BitConverter_ToDouble                | .NET Framework 4.6.2 |  2.6110 ns | 0.0727 ns | 0.0568 ns |  2.6032 ns | 19.867 |    1.37 |
| BitConverter_ToFloat                 | .NET Framework 4.6.2 |  1.9015 ns | 0.0213 ns | 0.0112 ns |  1.9009 ns | 14.542 |    0.93 |
| BitConverter_ToUInt64                | .NET Framework 4.6.2 |  2.5511 ns | 0.0406 ns | 0.0269 ns |  2.5534 ns | 19.510 |    1.27 |
| BitConverter_ToInt64                 | .NET Framework 4.6.2 |  1.2453 ns | 0.0302 ns | 0.0180 ns |  1.2538 ns |  9.527 |    0.67 |
| BitConverter_ToUInt32                | .NET Framework 4.6.2 |  1.4107 ns | 0.0153 ns | 0.0080 ns |  1.4145 ns | 10.790 |    0.72 |
| BitConverter_ToInt32                 | .NET Framework 4.6.2 |  0.5316 ns | 0.0109 ns | 0.0065 ns |  0.5341 ns |  4.063 |    0.21 |
| BitConverter_ToUInt16                | .NET Framework 4.6.2 |  2.5822 ns | 0.0677 ns | 0.0448 ns |  2.5867 ns | 19.720 |    1.25 |
| BitConverter_ToInt16                 | .NET Framework 4.6.2 |  0.7960 ns | 0.0349 ns | 0.0252 ns |  0.7913 ns |  6.081 |    0.38 |
| ByteIndexer_Double                   | .NET Framework 4.6.2 |  2.8648 ns | 0.0217 ns | 0.0114 ns |  2.8654 ns | 21.911 |    1.43 |
| ByteIndexer_Float                    | .NET Framework 4.6.2 | 11.1990 ns | 0.1025 ns | 0.0678 ns | 11.2279 ns | 85.710 |    5.26 |
| ByteIndexer_UInt64                   | .NET Framework 4.6.2 |  3.3387 ns | 0.0868 ns | 0.0769 ns |  3.3173 ns | 25.604 |    1.54 |
| ByteIndexer_Int64                    | .NET Framework 4.6.2 |  3.3555 ns | 0.0873 ns | 0.0577 ns |  3.3652 ns | 25.630 |    1.59 |
| ByteIndexer_UInt32                   | .NET Framework 4.6.2 |  1.8001 ns | 0.0355 ns | 0.0186 ns |  1.8017 ns | 13.768 |    0.91 |
| ByteIndexer_Int32                    | .NET Framework 4.6.2 |  1.7798 ns | 0.0517 ns | 0.0374 ns |  1.7947 ns | 13.620 |    0.91 |
| ByteIndexer_UInt16                   | .NET Framework 4.6.2 |  0.8580 ns | 0.0323 ns | 0.0169 ns |  0.8590 ns |  6.563 |    0.45 |
| ByteIndexer_Int16                    | .NET Framework 4.6.2 |  1.0085 ns | 0.0570 ns | 0.0533 ns |  1.0087 ns |  7.769 |    0.45 |
| ByteIndexer_On_ReadOnlySpanOf_Double | .NET Framework 4.6.2 |  4.7263 ns | 0.1621 ns | 0.1516 ns |  4.6586 ns | 36.371 |    2.30 |
| ByteIndexer_On_ReadOnlySpanOf_Float  | .NET Framework 4.6.2 | 11.9951 ns | 0.1962 ns | 0.1168 ns | 12.0232 ns | 91.712 |    5.33 |
| ByteIndexer_On_ReadOnlySpanOf_UInt64 | .NET Framework 4.6.2 |  6.5053 ns | 0.1916 ns | 0.1792 ns |  6.4957 ns | 50.293 |    2.53 |
| ByteIndexer_On_ReadOnlySpanOf_Int64  | .NET Framework 4.6.2 |  6.5278 ns | 0.0886 ns | 0.0527 ns |  6.5231 ns | 49.927 |    3.19 |
| ByteIndexer_On_ReadOnlySpanOf_UInt32 | .NET Framework 4.6.2 |  2.5053 ns | 0.1201 ns | 0.1065 ns |  2.4880 ns | 19.298 |    1.22 |
| ByteIndexer_On_ReadOnlySpanOf_Int32  | .NET Framework 4.6.2 |  2.4020 ns | 0.2085 ns | 0.1950 ns |  2.3752 ns | 17.768 |    1.67 |
| ByteIndexer_On_ReadOnlySpanOf_UInt16 | .NET Framework 4.6.2 |  1.9104 ns | 0.0985 ns | 0.0873 ns |  1.8912 ns | 14.723 |    0.99 |
| ByteIndexer_On_ReadOnlySpanOf_Int16  | .NET Framework 4.6.2 |  1.9839 ns | 0.1817 ns | 0.1700 ns |  1.9727 ns | 15.014 |    1.88 |
| ExtensionMethod_Double               | .NET Framework 4.6.2 |  2.9270 ns | 0.0514 ns | 0.0306 ns |  2.9308 ns | 22.383 |    1.38 |
| ExtensionMethod_Float                | .NET Framework 4.6.2 | 11.2096 ns | 0.1875 ns | 0.1240 ns | 11.2100 ns | 85.828 |    5.33 |
| ExtensionMethod_UInt64               | .NET Framework 4.6.2 |  3.0663 ns | 0.0589 ns | 0.0389 ns |  3.0647 ns | 23.481 |    1.51 |
| ExtensionMethod_Int64                | .NET Framework 4.6.2 |  2.6248 ns | 0.0571 ns | 0.0340 ns |  2.6256 ns | 20.073 |    1.25 |
| ExtensionMethod_UInt32               | .NET Framework 4.6.2 |  1.2060 ns | 0.0451 ns | 0.0326 ns |  1.2041 ns |  9.200 |    0.62 |
| ExtensionMethod_Int32                | .NET Framework 4.6.2 |  1.2055 ns | 0.0554 ns | 0.0518 ns |  1.1872 ns |  9.348 |    0.83 |
| ExtensionMethod_UInt16               | .NET Framework 4.6.2 |  0.9782 ns | 0.0402 ns | 0.0291 ns |  0.9634 ns |  7.468 |    0.45 |
| ExtensionMethod_Int16                | .NET Framework 4.6.2 |  0.9504 ns | 0.0364 ns | 0.0217 ns |  0.9413 ns |  7.271 |    0.54 |
| ExtensionMethod_ToDouble             | .NET Framework 4.6.2 |  2.5132 ns | 0.0490 ns | 0.0324 ns |  2.5143 ns | 19.227 |    1.22 |
| ExtensionMethod_ToFloat              | .NET Framework 4.6.2 |  6.2429 ns | 0.2190 ns | 0.1942 ns |  6.1969 ns | 48.339 |    3.40 |
| ExtensionMethod_ToUInt64             | .NET Framework 4.6.2 |  2.9809 ns | 0.0770 ns | 0.0682 ns |  2.9764 ns | 22.965 |    1.59 |
| ExtensionMethod_ToInt64              | .NET Framework 4.6.2 |  2.9209 ns | 0.0817 ns | 0.0591 ns |  2.9251 ns | 22.421 |    1.39 |
| ExtensionMethod_ToUInt32             | .NET Framework 4.6.2 |  1.8120 ns | 0.0473 ns | 0.0281 ns |  1.8156 ns | 13.855 |    0.84 |
| ExtensionMethod_ToInt32              | .NET Framework 4.6.2 |  1.7920 ns | 0.0381 ns | 0.0252 ns |  1.7974 ns | 13.696 |    0.90 |
| ExtensionMethod_ToUInt16             | .NET Framework 4.6.2 |  1.0088 ns | 0.0204 ns | 0.0122 ns |  1.0090 ns |  7.711 |    0.41 |
| ExtensionMethod_ToInt16              | .NET Framework 4.6.2 |  0.9864 ns | 0.0200 ns | 0.0132 ns |  0.9827 ns |  7.547 |    0.45 |

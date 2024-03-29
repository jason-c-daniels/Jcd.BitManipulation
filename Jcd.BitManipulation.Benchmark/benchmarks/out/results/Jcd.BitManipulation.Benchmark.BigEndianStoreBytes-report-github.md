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

| Method                               | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|--------------------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble                | .NET 8.0             |  1.5708 ns | 0.1217 ns | 0.1079 ns |  1.5561 ns | 0.429 |    0.02 |
| BitConverter_ToFloat                 | .NET 8.0             |  2.2050 ns | 0.5987 ns | 0.4999 ns |  2.2773 ns | 0.607 |    0.15 |
| BitConverter_ToUInt64                | .NET 8.0             |  1.2448 ns | 0.0946 ns | 0.0839 ns |  1.2211 ns | 0.354 |    0.03 |
| BitConverter_ToInt64                 | .NET 8.0             |  1.6161 ns | 0.0684 ns | 0.0640 ns |  1.5925 ns | 0.453 |    0.02 |
| BitConverter_ToUInt32                | .NET 8.0             |  1.2816 ns | 0.0669 ns | 0.0626 ns |  1.2752 ns | 0.360 |    0.02 |
| BitConverter_ToInt32                 | .NET 8.0             |  1.6424 ns | 0.0229 ns | 0.0152 ns |  1.6443 ns | 0.459 |    0.01 |
| BitConverter_ToUInt16                | .NET 8.0             |  3.4665 ns | 0.0348 ns | 0.0231 ns |  3.4652 ns | 0.969 |    0.01 |
| BitConverter_ToInt16                 | .NET 8.0             |  3.5781 ns | 0.0670 ns | 0.0443 ns |  3.5708 ns | 1.000 |    0.00 |
| ByteIndexer_Double                   | .NET 8.0             |  1.2523 ns | 0.0360 ns | 0.0238 ns |  1.2534 ns | 0.350 |    0.01 |
| ByteIndexer_Float                    | .NET 8.0             |  0.1372 ns | 0.0133 ns | 0.0079 ns |  0.1346 ns | 0.038 |    0.00 |
| ByteIndexer_UInt64                   | .NET 8.0             |  1.2215 ns | 0.0294 ns | 0.0175 ns |  1.2225 ns | 0.342 |    0.01 |
| ByteIndexer_Int64                    | .NET 8.0             |  1.2402 ns | 0.0441 ns | 0.0319 ns |  1.2292 ns | 0.347 |    0.01 |
| ByteIndexer_UInt32                   | .NET 8.0             |  0.1371 ns | 0.0257 ns | 0.0201 ns |  0.1325 ns | 0.039 |    0.01 |
| ByteIndexer_Int32                    | .NET 8.0             |  0.1274 ns | 0.0266 ns | 0.0222 ns |  0.1178 ns | 0.037 |    0.01 |
| ByteIndexer_UInt16                   | .NET 8.0             |  0.1462 ns | 0.0141 ns | 0.0084 ns |  0.1439 ns | 0.041 |    0.00 |
| ByteIndexer_Int16                    | .NET 8.0             |  0.1370 ns | 0.0252 ns | 0.0167 ns |  0.1318 ns | 0.038 |    0.00 |
| ByteIndexer_On_ReadOnlySpanOf_Double | .NET 8.0             |  2.2526 ns | 0.0451 ns | 0.0298 ns |  2.2480 ns | 0.630 |    0.01 |
| ByteIndexer_On_ReadOnlySpanOf_Float  | .NET 8.0             |  0.6996 ns | 0.0181 ns | 0.0119 ns |  0.6977 ns | 0.196 |    0.00 |
| ByteIndexer_On_ReadOnlySpanOf_UInt64 | .NET 8.0             |  2.0392 ns | 0.0632 ns | 0.0457 ns |  2.0112 ns | 0.571 |    0.02 |
| ByteIndexer_On_ReadOnlySpanOf_Int64  | .NET 8.0             |  2.0168 ns | 0.0443 ns | 0.0232 ns |  2.0227 ns | 0.563 |    0.01 |
| ByteIndexer_On_ReadOnlySpanOf_UInt32 | .NET 8.0             |  0.5851 ns | 0.0380 ns | 0.0355 ns |  0.5677 ns | 0.167 |    0.01 |
| ByteIndexer_On_ReadOnlySpanOf_Int32  | .NET 8.0             |  0.5480 ns | 0.0157 ns | 0.0082 ns |  0.5492 ns | 0.153 |    0.00 |
| ByteIndexer_On_ReadOnlySpanOf_UInt16 | .NET 8.0             |  0.3491 ns | 0.0189 ns | 0.0125 ns |  0.3478 ns | 0.098 |    0.00 |
| ByteIndexer_On_ReadOnlySpanOf_Int16  | .NET 8.0             |  0.3487 ns | 0.0322 ns | 0.0269 ns |  0.3478 ns | 0.098 |    0.01 |
| ExtensionMethod_Double               | .NET 8.0             |  1.2493 ns | 0.0440 ns | 0.0262 ns |  1.2490 ns | 0.349 |    0.01 |
| ExtensionMethod_Float                | .NET 8.0             |  0.3570 ns | 0.0319 ns | 0.0190 ns |  0.3650 ns | 0.100 |    0.01 |
| ExtensionMethod_UInt64               | .NET 8.0             |  1.2481 ns | 0.0780 ns | 0.0692 ns |  1.2333 ns | 0.349 |    0.02 |
| ExtensionMethod_Int64                | .NET 8.0             |  1.1958 ns | 0.0433 ns | 0.0287 ns |  1.1904 ns | 0.334 |    0.01 |
| ExtensionMethod_UInt32               | .NET 8.0             |  0.1347 ns | 0.0286 ns | 0.0268 ns |  0.1267 ns | 0.038 |    0.01 |
| ExtensionMethod_Int32                | .NET 8.0             |  0.2259 ns | 0.1155 ns | 0.1080 ns |  0.1692 ns | 0.069 |    0.04 |
| ExtensionMethod_UInt16               | .NET 8.0             |  0.1315 ns | 0.0138 ns | 0.0091 ns |  0.1320 ns | 0.037 |    0.00 |
| ExtensionMethod_Int16                | .NET 8.0             |  0.0051 ns | 0.0156 ns | 0.0093 ns |  0.0003 ns | 0.001 |    0.00 |
| ExtensionMethod_ToDouble             | .NET 8.0             |  0.6709 ns | 0.0388 ns | 0.0280 ns |  0.6680 ns | 0.188 |    0.01 |
| ExtensionMethod_ToFloat              | .NET 8.0             |  0.3659 ns | 0.0246 ns | 0.0146 ns |  0.3635 ns | 0.102 |    0.00 |
| ExtensionMethod_ToUInt64             | .NET 8.0             |  0.5979 ns | 0.0289 ns | 0.0172 ns |  0.5959 ns | 0.167 |    0.01 |
| ExtensionMethod_ToInt64              | .NET 8.0             |  0.6101 ns | 0.0270 ns | 0.0179 ns |  0.6048 ns | 0.171 |    0.01 |
| ExtensionMethod_ToUInt32             | .NET 8.0             |  0.1291 ns | 0.0277 ns | 0.0183 ns |  0.1291 ns | 0.036 |    0.01 |
| ExtensionMethod_ToInt32              | .NET 8.0             |  0.1646 ns | 0.0360 ns | 0.0337 ns |  0.1627 ns | 0.051 |    0.01 |
| ExtensionMethod_ToUInt16             | .NET 8.0             |  0.0211 ns | 0.0305 ns | 0.0285 ns |  0.0041 ns | 0.006 |    0.01 |
| ExtensionMethod_ToInt16              | .NET 8.0             |  0.0131 ns | 0.0199 ns | 0.0156 ns |  0.0026 ns | 0.004 |    0.00 |
| BitConverter_ToDouble                | .NET Framework 4.6.2 | 26.5569 ns | 0.7307 ns | 0.6835 ns | 26.6154 ns | 7.394 |    0.24 |
| BitConverter_ToFloat                 | .NET Framework 4.6.2 | 24.1751 ns | 0.5402 ns | 0.4788 ns | 24.0730 ns | 6.730 |    0.16 |
| BitConverter_ToUInt64                | .NET Framework 4.6.2 | 26.5549 ns | 0.4370 ns | 0.2601 ns | 26.5116 ns | 7.425 |    0.11 |
| BitConverter_ToInt64                 | .NET Framework 4.6.2 | 25.1728 ns | 0.4958 ns | 0.3871 ns | 25.1248 ns | 7.042 |    0.15 |
| BitConverter_ToUInt32                | .NET Framework 4.6.2 | 23.9321 ns | 0.5507 ns | 0.4882 ns | 23.9396 ns | 6.664 |    0.15 |
| BitConverter_ToInt32                 | .NET Framework 4.6.2 | 22.7866 ns | 0.1770 ns | 0.0926 ns | 22.7727 ns | 6.359 |    0.09 |
| BitConverter_ToUInt16                | .NET Framework 4.6.2 | 23.4861 ns | 0.6683 ns | 0.6251 ns | 23.3698 ns | 6.536 |    0.13 |
| BitConverter_ToInt16                 | .NET Framework 4.6.2 | 21.1708 ns | 0.2741 ns | 0.1813 ns | 21.2345 ns | 5.918 |    0.08 |
| ByteIndexer_Double                   | .NET Framework 4.6.2 |  6.7090 ns | 0.0575 ns | 0.0342 ns |  6.7091 ns | 1.876 |    0.03 |
| ByteIndexer_Float                    | .NET Framework 4.6.2 | 12.9021 ns | 0.3948 ns | 0.3500 ns | 12.8832 ns | 3.599 |    0.13 |
| ByteIndexer_UInt64                   | .NET Framework 4.6.2 |  6.5943 ns | 0.1228 ns | 0.0812 ns |  6.6216 ns | 1.843 |    0.03 |
| ByteIndexer_Int64                    | .NET Framework 4.6.2 |  6.6216 ns | 0.1471 ns | 0.1228 ns |  6.6052 ns | 1.847 |    0.05 |
| ByteIndexer_UInt32                   | .NET Framework 4.6.2 |  2.9337 ns | 0.0617 ns | 0.0482 ns |  2.9287 ns | 0.820 |    0.01 |
| ByteIndexer_Int32                    | .NET Framework 4.6.2 |  3.0337 ns | 0.0986 ns | 0.0874 ns |  3.0144 ns | 0.846 |    0.03 |
| ByteIndexer_UInt16                   | .NET Framework 4.6.2 |  1.4224 ns | 0.0384 ns | 0.0228 ns |  1.4277 ns | 0.398 |    0.01 |
| ByteIndexer_Int16                    | .NET Framework 4.6.2 |  1.4155 ns | 0.0499 ns | 0.0261 ns |  1.4150 ns | 0.395 |    0.01 |
| ByteIndexer_On_ReadOnlySpanOf_Double | .NET Framework 4.6.2 | 10.5889 ns | 0.1142 ns | 0.0755 ns | 10.5657 ns | 2.960 |    0.04 |
| ByteIndexer_On_ReadOnlySpanOf_Float  | .NET Framework 4.6.2 | 14.2831 ns | 0.1587 ns | 0.0830 ns | 14.3177 ns | 3.986 |    0.05 |
| ByteIndexer_On_ReadOnlySpanOf_UInt64 | .NET Framework 4.6.2 | 10.2660 ns | 0.1343 ns | 0.0702 ns | 10.2876 ns | 2.865 |    0.04 |
| ByteIndexer_On_ReadOnlySpanOf_Int64  | .NET Framework 4.6.2 | 10.3026 ns | 0.1237 ns | 0.0647 ns | 10.2875 ns | 2.875 |    0.04 |
| ByteIndexer_On_ReadOnlySpanOf_UInt32 | .NET Framework 4.6.2 |  4.9372 ns | 0.1195 ns | 0.0998 ns |  4.9836 ns | 1.385 |    0.03 |
| ByteIndexer_On_ReadOnlySpanOf_Int32  | .NET Framework 4.6.2 |  4.8389 ns | 0.0431 ns | 0.0257 ns |  4.8398 ns | 1.353 |    0.02 |
| ByteIndexer_On_ReadOnlySpanOf_UInt16 | .NET Framework 4.6.2 |  2.3564 ns | 0.0373 ns | 0.0222 ns |  2.3650 ns | 0.659 |    0.01 |
| ByteIndexer_On_ReadOnlySpanOf_Int16  | .NET Framework 4.6.2 |  2.4203 ns | 0.0257 ns | 0.0170 ns |  2.4156 ns | 0.677 |    0.01 |
| ExtensionMethod_Double               | .NET Framework 4.6.2 |  6.7613 ns | 0.0999 ns | 0.0661 ns |  6.7690 ns | 1.890 |    0.03 |
| ExtensionMethod_Float                | .NET Framework 4.6.2 | 12.2415 ns | 0.1965 ns | 0.1169 ns | 12.2222 ns | 3.423 |    0.06 |
| ExtensionMethod_UInt64               | .NET Framework 4.6.2 |  6.3854 ns | 0.0401 ns | 0.0210 ns |  6.3822 ns | 1.782 |    0.02 |
| ExtensionMethod_Int64                | .NET Framework 4.6.2 |  6.2668 ns | 0.0448 ns | 0.0296 ns |  6.2655 ns | 1.752 |    0.02 |
| ExtensionMethod_UInt32               | .NET Framework 4.6.2 |  2.9172 ns | 0.0462 ns | 0.0306 ns |  2.9196 ns | 0.815 |    0.02 |
| ExtensionMethod_Int32                | .NET Framework 4.6.2 |  2.9257 ns | 0.0359 ns | 0.0214 ns |  2.9239 ns | 0.818 |    0.01 |
| ExtensionMethod_UInt16               | .NET Framework 4.6.2 |  1.3844 ns | 0.0395 ns | 0.0235 ns |  1.3810 ns | 0.387 |    0.01 |
| ExtensionMethod_Int16                | .NET Framework 4.6.2 |  1.4279 ns | 0.0528 ns | 0.0494 ns |  1.4084 ns | 0.402 |    0.01 |
| ExtensionMethod_ToDouble             | .NET Framework 4.6.2 |  2.6280 ns | 0.0769 ns | 0.0643 ns |  2.6016 ns | 0.734 |    0.02 |
| ExtensionMethod_ToFloat              | .NET Framework 4.6.2 |  6.3803 ns | 0.2338 ns | 0.2187 ns |  6.3255 ns | 1.776 |    0.07 |
| ExtensionMethod_ToUInt64             | .NET Framework 4.6.2 |  3.0194 ns | 0.0957 ns | 0.0848 ns |  3.0056 ns | 0.847 |    0.03 |
| ExtensionMethod_ToInt64              | .NET Framework 4.6.2 |  2.9545 ns | 0.0941 ns | 0.0880 ns |  2.9546 ns | 0.822 |    0.02 |
| ExtensionMethod_ToUInt32             | .NET Framework 4.6.2 |  1.8537 ns | 0.0553 ns | 0.0431 ns |  1.8586 ns | 0.519 |    0.01 |
| ExtensionMethod_ToInt32              | .NET Framework 4.6.2 |  1.8018 ns | 0.0469 ns | 0.0310 ns |  1.7971 ns | 0.504 |    0.01 |
| ExtensionMethod_ToUInt16             | .NET Framework 4.6.2 |  1.0174 ns | 0.0192 ns | 0.0127 ns |  1.0150 ns | 0.284 |    0.00 |
| ExtensionMethod_ToInt16              | .NET Framework 4.6.2 |  0.9868 ns | 0.0162 ns | 0.0096 ns |  0.9884 ns | 0.276 |    0.00 |

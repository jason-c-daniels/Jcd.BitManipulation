```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-VCRXGK : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-DBRHDI : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=100.0000 ms  MaxIterationCount=11  MinIterationCount=10  
WarmupCount=10  

```

| Method                                     | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BigEndianByteIndexer_Slice_Double          | .NET 8.0             |  7.190 ns | 0.3848 ns | 0.2782 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Double          | .NET Framework 4.6.2 |  7.210 ns | 1.0657 ns | 0.7705 ns |  1.00 |    0.12 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexer_Slice_Float           | .NET 8.0             |  6.554 ns | 0.3935 ns | 0.2845 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Float           | .NET Framework 4.6.2 |  4.330 ns | 0.1801 ns | 0.1191 ns |  0.66 |    0.03 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexer_Slice_UInt64          | .NET 8.0             |  6.752 ns | 0.2374 ns | 0.1570 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_UInt64          | .NET Framework 4.6.2 |  6.772 ns | 0.2561 ns | 0.1852 ns |  1.00 |    0.04 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexer_Slice_Int64           | .NET 8.0             |  7.539 ns | 0.5330 ns | 0.3854 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Int64           | .NET Framework 4.6.2 |  7.042 ns | 0.2681 ns | 0.1939 ns |  0.94 |    0.06 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexer_Slice_UInt32          | .NET 8.0             |  6.171 ns | 0.2553 ns | 0.1519 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_UInt32          | .NET Framework 4.6.2 |  4.538 ns | 0.1745 ns | 0.1262 ns |  0.74 |    0.03 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexer_Slice_Int32           | .NET 8.0             |  5.714 ns | 0.3546 ns | 0.2564 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Int32           | .NET Framework 4.6.2 |  4.538 ns | 0.4421 ns | 0.3197 ns |  0.80 |    0.07 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexer_Slice_UInt16          | .NET 8.0             |  5.181 ns | 0.3459 ns | 0.2501 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_UInt16          | .NET Framework 4.6.2 |  3.476 ns | 0.1231 ns | 0.0733 ns |  0.68 |    0.03 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexer_Slice_Int16           | .NET 8.0             |  4.976 ns | 0.2002 ns | 0.1324 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Int16           | .NET Framework 4.6.2 |  3.477 ns | 0.1440 ns | 0.1041 ns |  0.70 |    0.03 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexer_Slice_Double_New_Inst | .NET 8.0             |  5.923 ns | 0.3939 ns | 0.2848 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Double_New_Inst | .NET Framework 4.6.2 |  6.811 ns | 0.4576 ns | 0.3309 ns |  1.15 |    0.09 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexer_Slice_Float_New_Inst  | .NET 8.0             |  7.217 ns | 0.4556 ns | 0.3294 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Float_New_Inst  | .NET Framework 4.6.2 | 10.582 ns | 0.6224 ns | 0.4501 ns |  1.47 |    0.09 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexer_Slice_UInt64_New_Inst | .NET 8.0             |  5.661 ns | 0.4027 ns | 0.2912 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_UInt64_New_Inst | .NET Framework 4.6.2 |  6.567 ns | 0.2993 ns | 0.1980 ns |  1.16 |    0.07 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexer_Slice_Int64_New_Inst  | .NET 8.0             |  6.248 ns | 0.3330 ns | 0.2202 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Int64_New_Inst  | .NET Framework 4.6.2 |  6.734 ns | 0.3912 ns | 0.2829 ns |  1.07 |    0.04 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexer_Slice_UInt32_New_Inst | .NET 8.0             |  4.623 ns | 0.6100 ns | 0.4411 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_UInt32_New_Inst | .NET Framework 4.6.2 |  4.038 ns | 0.1870 ns | 0.1352 ns |  0.88 |    0.09 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexer_Slice_Int32_New_Inst  | .NET 8.0             |  4.392 ns | 0.2167 ns | 0.1567 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Int32_New_Inst  | .NET Framework 4.6.2 |  4.060 ns | 0.1264 ns | 0.0836 ns |  0.92 |    0.04 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexer_Slice_UInt16_New_Inst | .NET 8.0             |  3.406 ns | 0.2406 ns | 0.1740 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_UInt16_New_Inst | .NET Framework 4.6.2 |  3.027 ns | 0.1829 ns | 0.1322 ns |  0.89 |    0.05 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexer_Slice_Int16_New_Inst  | .NET 8.0             |  3.438 ns | 0.3313 ns | 0.2396 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Int16_New_Inst  | .NET Framework 4.6.2 |  3.018 ns | 0.1116 ns | 0.0807 ns |  0.88 |    0.07 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexerFloat_Slice            | .NET 8.0             |  4.753 ns | 0.1757 ns | 0.1162 ns |  1.00 |    0.00 |
| BigEndianByteIndexerFloat_Slice            | .NET Framework 4.6.2 |  4.783 ns | 0.2289 ns | 0.1655 ns |  1.00 |    0.05 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexerDouble_Slice           | .NET 8.0             |  5.769 ns | 0.3072 ns | 0.2221 ns |  1.00 |    0.00 |
| BigEndianByteIndexerDouble_Slice           | .NET Framework 4.6.2 |  8.782 ns | 0.6905 ns | 0.4993 ns |  1.53 |    0.12 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexerUInt64_Slice           | .NET 8.0             |  6.244 ns | 0.2093 ns | 0.1384 ns |  1.00 |    0.00 |
| BigEndianByteIndexerUInt64_Slice           | .NET Framework 4.6.2 |  7.840 ns | 0.2265 ns | 0.1498 ns |  1.26 |    0.04 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexerInt64_Slice            | .NET 8.0             |  6.169 ns | 0.2218 ns | 0.1604 ns |  1.00 |    0.00 |
| BigEndianByteIndexerInt64_Slice            | .NET Framework 4.6.2 |  7.640 ns | 0.1946 ns | 0.1287 ns |  1.24 |    0.04 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexerUInt32_Slice           | .NET 8.0             |  4.553 ns | 0.2992 ns | 0.2164 ns |  1.00 |    0.00 |
| BigEndianByteIndexerUInt32_Slice           | .NET Framework 4.6.2 |  4.941 ns | 0.2315 ns | 0.1674 ns |  1.09 |    0.06 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexerInt32_Slice            | .NET 8.0             |  4.205 ns | 0.2225 ns | 0.1472 ns |  1.00 |    0.00 |
| BigEndianByteIndexerInt32_Slice            | .NET Framework 4.6.2 |  4.667 ns | 0.1345 ns | 0.0801 ns |  1.11 |    0.03 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexerUInt16_Slice           | .NET 8.0             |  3.364 ns | 0.2084 ns | 0.1507 ns |  1.00 |    0.00 |
| BigEndianByteIndexerUInt16_Slice           | .NET Framework 4.6.2 |  3.816 ns | 0.1235 ns | 0.0893 ns |  1.14 |    0.06 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexerInt16_Slice            | .NET 8.0             |  4.004 ns | 0.3565 ns | 0.2578 ns |  1.00 |    0.00 |
| BigEndianByteIndexerInt16_Slice            | .NET Framework 4.6.2 |  3.798 ns | 0.1779 ns | 0.1286 ns |  0.95 |    0.07 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexerDouble_Slice_New_Inst  | .NET 8.0             |  5.439 ns | 0.2618 ns | 0.1732 ns |  1.00 |    0.00 |
| BigEndianByteIndexerDouble_Slice_New_Inst  | .NET Framework 4.6.2 |  8.090 ns | 0.3961 ns | 0.2620 ns |  1.49 |    0.08 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexerFloat_Slice_New_Inst   | .NET 8.0             |  7.359 ns | 0.3425 ns | 0.2476 ns |  1.00 |    0.00 |
| BigEndianByteIndexerFloat_Slice_New_Inst   | .NET Framework 4.6.2 |  9.018 ns | 0.3178 ns | 0.2102 ns |  1.23 |    0.04 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexerUInt64_Slice_New_Inst  | .NET 8.0             |  5.809 ns | 0.4591 ns | 0.3319 ns |  1.00 |    0.00 |
| BigEndianByteIndexerUInt64_Slice_New_Inst  | .NET Framework 4.6.2 |  6.685 ns | 0.1996 ns | 0.1443 ns |  1.15 |    0.07 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexerInt64_Slice_New_Inst   | .NET 8.0             |  6.013 ns | 0.4145 ns | 0.2997 ns |  1.00 |    0.00 |
| BigEndianByteIndexerInt64_Slice_New_Inst   | .NET Framework 4.6.2 |  6.853 ns | 0.3573 ns | 0.2584 ns |  1.14 |    0.07 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexerUInt32_Slice_New_Inst  | .NET 8.0             |  5.333 ns | 0.2817 ns | 0.2037 ns |  1.00 |    0.00 |
| BigEndianByteIndexerUInt32_Slice_New_Inst  | .NET Framework 4.6.2 |  4.146 ns | 0.1850 ns | 0.1337 ns |  0.78 |    0.05 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexerInt32_Slice_New_Inst   | .NET 8.0             |  5.410 ns | 0.2093 ns | 0.1384 ns |  1.00 |    0.00 |
| BigEndianByteIndexerInt32_Slice_New_Inst   | .NET Framework 4.6.2 |  3.951 ns | 0.1734 ns | 0.1254 ns |  0.73 |    0.02 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexerUInt16_Slice_New_Inst  | .NET 8.0             |  4.861 ns | 0.4551 ns | 0.3010 ns |  1.00 |    0.00 |
| BigEndianByteIndexerUInt16_Slice_New_Inst  | .NET Framework 4.6.2 |  5.898 ns | 0.1419 ns | 0.1026 ns |  1.22 |    0.09 |
|                                            |                      |           |           |           |       |         |
| BigEndianByteIndexerInt16_Slice_New_Inst   | .NET 8.0             |  4.371 ns | 0.5174 ns | 0.3741 ns |  1.00 |    0.00 |
| BigEndianByteIndexerInt16_Slice_New_Inst   | .NET Framework 4.6.2 |  3.037 ns | 0.1885 ns | 0.1363 ns |  0.70 |    0.05 |

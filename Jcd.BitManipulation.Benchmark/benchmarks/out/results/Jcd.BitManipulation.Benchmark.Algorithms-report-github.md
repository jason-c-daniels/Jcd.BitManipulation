```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ENIIYX : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-VBNJUD : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```
| Method                                   | Runtime              | Mean      | Error     | StdDev    | Median    | Ratio  | RatioSD |
|----------------------------------------- |--------------------- |----------:|----------:|----------:|----------:|-------:|--------:|
| IsPowerOfTwo_On_Byte                     | .NET 8.0             | 0.3694 ns | 0.0443 ns | 0.0393 ns | 0.3590 ns |   1.00 |    0.00 |
| IsPowerOfTwo_On_Byte                     | .NET Framework 4.6.2 | 0.1201 ns | 0.0194 ns | 0.0140 ns | 0.1209 ns |   0.32 |    0.04 |
|                                          |                      |           |           |           |           |        |         |
| IsPowerOfTwo_On_UInt16                   | .NET 8.0             | 0.2564 ns | 0.0434 ns | 0.0406 ns | 0.2402 ns |   1.00 |    0.00 |
| IsPowerOfTwo_On_UInt16                   | .NET Framework 4.6.2 | 0.5074 ns | 0.0221 ns | 0.0131 ns | 0.5108 ns |   2.06 |    0.31 |
|                                          |                      |           |           |           |           |        |         |
| IsPowerOfTwo_On_UInt32                   | .NET 8.0             | 0.1321 ns | 0.0144 ns | 0.0086 ns | 0.1290 ns |   1.00 |    0.00 |
| IsPowerOfTwo_On_UInt32                   | .NET Framework 4.6.2 | 0.0922 ns | 0.0136 ns | 0.0090 ns | 0.0944 ns |   0.71 |    0.10 |
|                                          |                      |           |           |           |           |        |         |
| IsPowerOfTwo_On_UInt64                   | .NET 8.0             | 0.0123 ns | 0.0173 ns | 0.0154 ns | 0.0034 ns |      ? |       ? |
| IsPowerOfTwo_On_UInt64                   | .NET Framework 4.6.2 | 0.1066 ns | 0.0130 ns | 0.0086 ns | 0.1060 ns |      ? |       ? |
|                                          |                      |           |           |           |           |        |         |
| CountBitsSet_On_Byte                     | .NET 8.0             | 1.2828 ns | 0.0679 ns | 0.0635 ns | 1.2677 ns |   1.00 |    0.00 |
| CountBitsSet_On_Byte                     | .NET Framework 4.6.2 | 1.4019 ns | 0.0286 ns | 0.0189 ns | 1.3999 ns |   1.10 |    0.06 |
|                                          |                      |           |           |           |           |        |         |
| CountBitsSet_On_UInt16                   | .NET 8.0             | 2.3126 ns | 0.0495 ns | 0.0259 ns | 2.3094 ns |   1.00 |    0.00 |
| CountBitsSet_On_UInt16                   | .NET Framework 4.6.2 | 2.6649 ns | 0.0250 ns | 0.0149 ns | 2.6609 ns |   1.15 |    0.01 |
|                                          |                      |           |           |           |           |        |         |
| CountBitsSet_On_UInt32                   | .NET 8.0             | 4.0255 ns | 0.1310 ns | 0.1226 ns | 4.0664 ns |   1.00 |    0.00 |
| CountBitsSet_On_UInt32                   | .NET Framework 4.6.2 | 4.3974 ns | 0.1040 ns | 0.0868 ns | 4.3718 ns |   1.09 |    0.02 |
|                                          |                      |           |           |           |           |        |         |
| CountBitsSet_On_UInt64                   | .NET 8.0             | 3.9358 ns | 0.0992 ns | 0.0656 ns | 3.9551 ns |   1.00 |    0.00 |
| CountBitsSet_On_UInt64                   | .NET Framework 4.6.2 | 4.5928 ns | 0.1356 ns | 0.1268 ns | 4.5745 ns |   1.18 |    0.02 |
|                                          |                      |           |           |           |           |        |         |
| CountLeadingZeros_On_Byte                | .NET 8.0             | 0.3266 ns | 0.0486 ns | 0.0454 ns | 0.3173 ns |   1.00 |    0.00 |
| CountLeadingZeros_On_Byte                | .NET Framework 4.6.2 | 0.8096 ns | 0.0146 ns | 0.0076 ns | 0.8114 ns |   2.30 |    0.26 |
|                                          |                      |           |           |           |           |        |         |
| CountLeadingZeros_On_UInt16              | .NET 8.0             | 0.5299 ns | 0.0235 ns | 0.0140 ns | 0.5283 ns |   1.00 |    0.00 |
| CountLeadingZeros_On_UInt16              | .NET Framework 4.6.2 | 1.4627 ns | 0.0607 ns | 0.0538 ns | 1.4633 ns |   2.78 |    0.15 |
|                                          |                      |           |           |           |           |        |         |
| CountLeadingZeros_On_UInt32              | .NET 8.0             | 0.1299 ns | 0.0280 ns | 0.0219 ns | 0.1271 ns |   1.00 |    0.00 |
| CountLeadingZeros_On_UInt32              | .NET Framework 4.6.2 | 1.2471 ns | 0.0758 ns | 0.0709 ns | 1.2387 ns |   9.96 |    1.64 |
|                                          |                      |           |           |           |           |        |         |
| CountLeadingZeros_On_UInt64              | .NET 8.0             | 0.9981 ns | 0.4404 ns | 0.4120 ns | 1.2287 ns |   1.00 |    0.00 |
| CountLeadingZeros_On_UInt64              | .NET Framework 4.6.2 | 1.4300 ns | 0.0501 ns | 0.0262 ns | 1.4356 ns |   1.05 |    0.07 |
|                                          |                      |           |           |           |           |        |         |
| CountTrailingZeros_On_Byte               | .NET 8.0             | 0.5255 ns | 0.0233 ns | 0.0154 ns | 0.5291 ns |   1.00 |    0.00 |
| CountTrailingZeros_On_Byte               | .NET Framework 4.6.2 | 1.1021 ns | 0.0438 ns | 0.0366 ns | 1.0856 ns |   2.11 |    0.07 |
|                                          |                      |           |           |           |           |        |         |
| CountTrailingZeros_On_UInt16             | .NET 8.0             | 0.5108 ns | 0.0107 ns | 0.0071 ns | 0.5100 ns |   1.00 |    0.00 |
| CountTrailingZeros_On_UInt16             | .NET Framework 4.6.2 | 1.8076 ns | 0.0545 ns | 0.0324 ns | 1.8046 ns |   3.53 |    0.07 |
|                                          |                      |           |           |           |           |        |         |
| CountTrailingZeros_On_UInt32             | .NET 8.0             | 0.5148 ns | 0.0161 ns | 0.0107 ns | 0.5106 ns |   1.00 |    0.00 |
| CountTrailingZeros_On_UInt32             | .NET Framework 4.6.2 | 1.7798 ns | 0.0491 ns | 0.0325 ns | 1.7770 ns |   3.46 |    0.11 |
|                                          |                      |           |           |           |           |        |         |
| CountTrailingZeros_On_UInt64             | .NET 8.0             | 0.5081 ns | 0.0231 ns | 0.0153 ns | 0.5019 ns |   1.00 |    0.00 |
| CountTrailingZeros_On_UInt64             | .NET Framework 4.6.2 | 2.1362 ns | 0.0410 ns | 0.0271 ns | 2.1348 ns |   4.21 |    0.14 |
|                                          |                      |           |           |           |           |        |         |
| AreOnlyFirstAndLastBitsSet_On_Byte       | .NET 8.0             | 0.4109 ns | 0.0221 ns | 0.0146 ns | 0.4112 ns |   1.00 |    0.00 |
| AreOnlyFirstAndLastBitsSet_On_Byte       | .NET Framework 4.6.2 | 0.9787 ns | 0.0355 ns | 0.0314 ns | 0.9664 ns |   2.40 |    0.14 |
|                                          |                      |           |           |           |           |        |         |
| AreOnlyFirstAndLastBitsSet_On_UInt16     | .NET 8.0             | 0.7545 ns | 0.0348 ns | 0.0207 ns | 0.7493 ns |   1.00 |    0.00 |
| AreOnlyFirstAndLastBitsSet_On_UInt16     | .NET Framework 4.6.2 | 0.8567 ns | 0.0389 ns | 0.0204 ns | 0.8644 ns |   1.14 |    0.04 |
|                                          |                      |           |           |           |           |        |         |
| AreOnlyFirstAndLastBitsSet_On_UInt32     | .NET 8.0             | 0.4063 ns | 0.0324 ns | 0.0234 ns | 0.4020 ns |   1.00 |    0.00 |
| AreOnlyFirstAndLastBitsSet_On_UInt32     | .NET Framework 4.6.2 | 0.9804 ns | 0.0402 ns | 0.0266 ns | 0.9773 ns |   2.43 |    0.14 |
|                                          |                      |           |           |           |           |        |         |
| AreOnlyFirstAndLastBitsSet_On_UInt64     | .NET 8.0             | 0.0111 ns | 0.0151 ns | 0.0090 ns | 0.0102 ns |   1.00 |    0.00 |
| AreOnlyFirstAndLastBitsSet_On_UInt64     | .NET Framework 4.6.2 | 0.3955 ns | 0.0468 ns | 0.0438 ns | 0.3910 ns | 250.98 |  613.24 |
|                                          |                      |           |           |           |           |        |         |
| GetHighestBitSet_On_Byte                 | .NET 8.0             | 0.1781 ns | 0.0181 ns | 0.0095 ns | 0.1799 ns |   1.00 |    0.00 |
| GetHighestBitSet_On_Byte                 | .NET Framework 4.6.2 | 0.9090 ns | 0.0379 ns | 0.0354 ns | 0.9101 ns |   5.05 |    0.34 |
|                                          |                      |           |           |           |           |        |         |
| GetHighestBitSet_On_UInt16               | .NET 8.0             | 0.4671 ns | 0.0219 ns | 0.0145 ns | 0.4667 ns |   1.00 |    0.00 |
| GetHighestBitSet_On_UInt16               | .NET Framework 4.6.2 | 1.3235 ns | 0.0471 ns | 0.0394 ns | 1.3322 ns |   2.84 |    0.11 |
|                                          |                      |           |           |           |           |        |         |
| GetHighestBitSet_On_UInt32               | .NET 8.0             | 0.7674 ns | 0.4875 ns | 0.4560 ns | 0.3729 ns |   1.00 |    0.00 |
| GetHighestBitSet_On_UInt32               | .NET Framework 4.6.2 | 1.3616 ns | 0.0384 ns | 0.0300 ns | 1.3669 ns |   2.25 |    1.42 |
|                                          |                      |           |           |           |           |        |         |
| GetHighestBitSet_On_UInt64               | .NET 8.0             | 0.5628 ns | 0.0344 ns | 0.0227 ns | 0.5600 ns |   1.00 |    0.00 |
| GetHighestBitSet_On_UInt64               | .NET Framework 4.6.2 | 2.1473 ns | 0.0596 ns | 0.0431 ns | 2.1528 ns |   3.82 |    0.18 |
|                                          |                      |           |           |           |           |        |         |
| GetLowestBitSet_On_Byte                  | .NET 8.0             | 0.3888 ns | 0.0231 ns | 0.0153 ns | 0.3878 ns |   1.00 |    0.00 |
| GetLowestBitSet_On_Byte                  | .NET Framework 4.6.2 | 1.0136 ns | 0.0325 ns | 0.0254 ns | 1.0156 ns |   2.61 |    0.13 |
|                                          |                      |           |           |           |           |        |         |
| GetLowestBitSet_On_UInt16                | .NET 8.0             | 0.3248 ns | 0.0209 ns | 0.0125 ns | 0.3243 ns |   1.00 |    0.00 |
| GetLowestBitSet_On_UInt16                | .NET Framework 4.6.2 | 1.5599 ns | 0.0533 ns | 0.0317 ns | 1.5634 ns |   4.81 |    0.24 |
|                                          |                      |           |           |           |           |        |         |
| GetLowestBitSet_On_UInt32                | .NET 8.0             | 0.5444 ns | 0.0334 ns | 0.0261 ns | 0.5461 ns |   1.00 |    0.00 |
| GetLowestBitSet_On_UInt32                | .NET Framework 4.6.2 | 2.0304 ns | 0.0562 ns | 0.0439 ns | 2.0339 ns |   3.74 |    0.19 |
|                                          |                      |           |           |           |           |        |         |
| GetLowestBitSet_On_UInt64                | .NET 8.0             | 0.2458 ns | 0.0215 ns | 0.0142 ns | 0.2436 ns |   1.00 |    0.00 |
| GetLowestBitSet_On_UInt64                | .NET Framework 4.6.2 | 2.0880 ns | 0.0607 ns | 0.0402 ns | 2.0782 ns |   8.51 |    0.39 |
|                                          |                      |           |           |           |           |        |         |
| GetValueOrNextHigherPowerOfTwo_On_Byte   | .NET 8.0             | 0.6255 ns | 0.0136 ns | 0.0081 ns | 0.6271 ns |   1.00 |    0.00 |
| GetValueOrNextHigherPowerOfTwo_On_Byte   | .NET Framework 4.6.2 | 1.5104 ns | 0.0264 ns | 0.0157 ns | 1.5110 ns |   2.42 |    0.04 |
|                                          |                      |           |           |           |           |        |         |
| GetValueOrNextHigherPowerOfTwo_On_UInt16 | .NET 8.0             | 0.7040 ns | 0.0371 ns | 0.0268 ns | 0.7049 ns |   1.00 |    0.00 |
| GetValueOrNextHigherPowerOfTwo_On_UInt16 | .NET Framework 4.6.2 | 2.1558 ns | 0.0580 ns | 0.0419 ns | 2.1457 ns |   3.07 |    0.13 |
|                                          |                      |           |           |           |           |        |         |
| GetValueOrNextHigherPowerOfTwo_On_UInt32 | .NET 8.0             | 0.7256 ns | 0.1139 ns | 0.1066 ns | 0.7851 ns |   1.00 |    0.00 |
| GetValueOrNextHigherPowerOfTwo_On_UInt32 | .NET Framework 4.6.2 | 1.8545 ns | 0.0979 ns | 0.0868 ns | 1.8627 ns |   2.56 |    0.37 |
|                                          |                      |           |           |           |           |        |         |
| GetValueOrNextHigherPowerOfTwo_On_UInt64 | .NET 8.0             | 1.3571 ns | 0.2742 ns | 0.2565 ns | 1.4699 ns |   1.00 |    0.00 |
| GetValueOrNextHigherPowerOfTwo_On_UInt64 | .NET Framework 4.6.2 | 3.7342 ns | 0.1693 ns | 0.1583 ns | 3.7777 ns |   2.87 |    0.71 |

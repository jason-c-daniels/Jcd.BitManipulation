```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-XPKBTN : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-HBVPVO : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                                | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|---------------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double          | .NET 8.0             |  5.682 ns | 0.5435 ns | 0.5083 ns |  1.15 |    0.13 |
| BitConverter_GetBytes_Float           | .NET 8.0             |  5.376 ns | 0.2692 ns | 0.2518 ns |  1.09 |    0.08 |
| BitConverter_GetBytes_UInt64          | .NET 8.0             |  5.066 ns | 0.2660 ns | 0.2488 ns |  1.03 |    0.08 |
| BitConverter_GetBytes_Int64           | .NET 8.0             |  5.267 ns | 0.3321 ns | 0.3106 ns |  1.07 |    0.06 |
| BitConverter_GetBytes_UInt32          | .NET 8.0             |  5.582 ns | 0.3313 ns | 0.2937 ns |  1.13 |    0.08 |
| BitConverter_GetBytes_Int32           | .NET 8.0             |  5.021 ns | 0.2714 ns | 0.2539 ns |  1.02 |    0.06 |
| BitConverter_GetBytes_UInt16          | .NET 8.0             |  4.927 ns | 0.2456 ns | 0.2297 ns |  1.00 |    0.06 |
| BitConverter_GetBytes_Int16           | .NET 8.0             |  5.552 ns | 1.1092 ns | 1.0375 ns |  1.13 |    0.21 |
| BigEndianByteIndexer_Slice_Double     | .NET 8.0             |  4.321 ns | 0.1880 ns | 0.1666 ns |  0.87 |    0.04 |
| BigEndianByteIndexer_Slice_Float      | .NET 8.0             |  4.365 ns | 0.2764 ns | 0.2450 ns |  0.88 |    0.06 |
| BigEndianByteIndexer_Slice_UInt64     | .NET 8.0             |  4.942 ns | 0.2521 ns | 0.2358 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Int64      | .NET 8.0             |  4.633 ns | 0.2623 ns | 0.2453 ns |  0.94 |    0.05 |
| BigEndianByteIndexer_Slice_UInt32     | .NET 8.0             |  4.202 ns | 0.2321 ns | 0.2057 ns |  0.85 |    0.06 |
| BigEndianByteIndexer_Slice_Int32      | .NET 8.0             |  4.332 ns | 0.2072 ns | 0.1938 ns |  0.88 |    0.06 |
| BigEndianByteIndexer_Slice_UInt16     | .NET 8.0             |  3.983 ns | 0.1689 ns | 0.1579 ns |  0.81 |    0.05 |
| BigEndianByteIndexer_Slice_Int16      | .NET 8.0             |  4.083 ns | 0.1509 ns | 0.1338 ns |  0.83 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET 8.0             |  4.593 ns | 0.2156 ns | 0.2017 ns |  0.93 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET 8.0             |  4.313 ns | 0.1648 ns | 0.1541 ns |  0.87 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET 8.0             |  4.661 ns | 0.1805 ns | 0.1689 ns |  0.95 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET 8.0             |  5.812 ns | 0.3743 ns | 0.3501 ns |  1.18 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET 8.0             |  3.857 ns | 0.2712 ns | 0.2537 ns |  0.78 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET 8.0             |  5.050 ns | 0.1990 ns | 0.1764 ns |  1.02 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET 8.0             |  4.222 ns | 0.1980 ns | 0.1852 ns |  0.86 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET 8.0             |  4.157 ns | 0.2659 ns | 0.2487 ns |  0.84 |    0.05 |
| BitConverter_GetBytes_Double          | .NET Framework 4.6.2 | 28.556 ns | 1.0338 ns | 0.9670 ns |  5.79 |    0.35 |
| BitConverter_GetBytes_Float           | .NET Framework 4.6.2 | 26.318 ns | 0.6749 ns | 0.6313 ns |  5.34 |    0.26 |
| BitConverter_GetBytes_UInt64          | .NET Framework 4.6.2 | 28.491 ns | 0.7476 ns | 0.6993 ns |  5.77 |    0.24 |
| BitConverter_GetBytes_Int64           | .NET Framework 4.6.2 | 28.579 ns | 0.7493 ns | 0.7009 ns |  5.80 |    0.31 |
| BitConverter_GetBytes_UInt32          | .NET Framework 4.6.2 | 26.570 ns | 0.5628 ns | 0.4989 ns |  5.38 |    0.27 |
| BitConverter_GetBytes_Int32           | .NET Framework 4.6.2 | 27.157 ns | 0.9419 ns | 0.8810 ns |  5.51 |    0.35 |
| BitConverter_GetBytes_UInt16          | .NET Framework 4.6.2 | 25.178 ns | 0.9039 ns | 0.8455 ns |  5.10 |    0.24 |
| BitConverter_GetBytes_Int16           | .NET Framework 4.6.2 | 24.644 ns | 0.6222 ns | 0.5820 ns |  5.00 |    0.22 |
| BigEndianByteIndexer_Slice_Double     | .NET Framework 4.6.2 |  8.749 ns | 0.3097 ns | 0.2897 ns |  1.77 |    0.08 |
| BigEndianByteIndexer_Slice_Float      | .NET Framework 4.6.2 |  9.905 ns | 0.3060 ns | 0.2862 ns |  2.01 |    0.12 |
| BigEndianByteIndexer_Slice_UInt64     | .NET Framework 4.6.2 |  8.769 ns | 0.4091 ns | 0.3626 ns |  1.78 |    0.12 |
| BigEndianByteIndexer_Slice_Int64      | .NET Framework 4.6.2 |  8.819 ns | 0.2256 ns | 0.2000 ns |  1.79 |    0.08 |
| BigEndianByteIndexer_Slice_UInt32     | .NET Framework 4.6.2 |  5.608 ns | 0.2045 ns | 0.1913 ns |  1.14 |    0.08 |
| BigEndianByteIndexer_Slice_Int32      | .NET Framework 4.6.2 |  5.766 ns | 0.2119 ns | 0.1982 ns |  1.17 |    0.07 |
| BigEndianByteIndexer_Slice_UInt16     | .NET Framework 4.6.2 |  4.457 ns | 0.2177 ns | 0.2036 ns |  0.90 |    0.06 |
| BigEndianByteIndexer_Slice_Int16      | .NET Framework 4.6.2 |  4.244 ns | 0.1681 ns | 0.1490 ns |  0.86 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET Framework 4.6.2 |  9.049 ns | 0.2095 ns | 0.1857 ns |  1.83 |    0.11 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET Framework 4.6.2 |  9.817 ns | 0.2957 ns | 0.2766 ns |  1.99 |    0.13 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET Framework 4.6.2 |  8.737 ns | 0.2119 ns | 0.1402 ns |  1.77 |    0.09 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET Framework 4.6.2 |  5.233 ns | 0.1423 ns | 0.0941 ns |  1.06 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET Framework 4.6.2 |  5.661 ns | 0.2725 ns | 0.2549 ns |  1.15 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET Framework 4.6.2 |  3.882 ns | 0.0927 ns | 0.0552 ns |  0.79 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET Framework 4.6.2 |  4.684 ns | 0.2239 ns | 0.2094 ns |  0.95 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET Framework 4.6.2 |  3.390 ns | 0.1220 ns | 0.1019 ns |  0.68 |    0.03 |

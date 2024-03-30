```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-UWWGLV : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-IXAHBT : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                                | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|---------------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double          | .NET 8.0             |  5.571 ns | 0.2744 ns | 0.2567 ns |  1.27 |    0.09 |
| BitConverter_GetBytes_Float           | .NET 8.0             |  5.690 ns | 0.2393 ns | 0.2122 ns |  1.30 |    0.07 |
| BitConverter_GetBytes_UInt64          | .NET 8.0             |  4.910 ns | 0.2428 ns | 0.2271 ns |  1.12 |    0.09 |
| BitConverter_GetBytes_Int64           | .NET 8.0             |  5.089 ns | 0.1574 ns | 0.1229 ns |  1.18 |    0.06 |
| BitConverter_GetBytes_UInt32          | .NET 8.0             |  5.466 ns | 0.5366 ns | 0.5019 ns |  1.25 |    0.12 |
| BitConverter_GetBytes_Int32           | .NET 8.0             |  5.856 ns | 0.5814 ns | 0.5439 ns |  1.33 |    0.12 |
| BitConverter_GetBytes_UInt16          | .NET 8.0             |  5.383 ns | 0.5640 ns | 0.5276 ns |  1.23 |    0.16 |
| BitConverter_GetBytes_Int16           | .NET 8.0             |  4.632 ns | 0.3657 ns | 0.3054 ns |  1.06 |    0.09 |
| BigEndianByteIndexer_Slice_Double     | .NET 8.0             |  4.450 ns | 0.2435 ns | 0.2277 ns |  1.02 |    0.09 |
| BigEndianByteIndexer_Slice_Float      | .NET 8.0             |  4.166 ns | 0.1829 ns | 0.1711 ns |  0.95 |    0.07 |
| BigEndianByteIndexer_Slice_UInt64     | .NET 8.0             |  4.398 ns | 0.2594 ns | 0.2426 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Int64      | .NET 8.0             |  4.748 ns | 0.4042 ns | 0.3583 ns |  1.09 |    0.12 |
| BigEndianByteIndexer_Slice_UInt32     | .NET 8.0             |  4.350 ns | 0.2294 ns | 0.2145 ns |  0.99 |    0.06 |
| BigEndianByteIndexer_Slice_Int32      | .NET 8.0             |  3.973 ns | 0.1863 ns | 0.1743 ns |  0.91 |    0.06 |
| BigEndianByteIndexer_Slice_UInt16     | .NET 8.0             |  4.452 ns | 0.4296 ns | 0.4018 ns |  1.02 |    0.11 |
| BigEndianByteIndexer_Slice_Int16      | .NET 8.0             |  4.143 ns | 0.2379 ns | 0.2225 ns |  0.95 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET 8.0             |  4.552 ns | 0.1419 ns | 0.1185 ns |  1.05 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET 8.0             |  4.438 ns | 0.3029 ns | 0.2834 ns |  1.01 |    0.11 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET 8.0             |  5.024 ns | 0.3745 ns | 0.3503 ns |  1.14 |    0.09 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET 8.0             |  6.143 ns | 0.1708 ns | 0.1017 ns |  1.41 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET 8.0             |  4.275 ns | 0.2820 ns | 0.2500 ns |  0.98 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET 8.0             |  4.956 ns | 0.1518 ns | 0.1004 ns |  1.14 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET 8.0             |  4.065 ns | 0.2497 ns | 0.2335 ns |  0.93 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET 8.0             |  4.476 ns | 0.3347 ns | 0.3130 ns |  1.02 |    0.10 |
| BitConverter_GetBytes_Double          | .NET Framework 4.6.2 | 29.031 ns | 1.2476 ns | 1.1670 ns |  6.62 |    0.49 |
| BitConverter_GetBytes_Float           | .NET Framework 4.6.2 | 26.700 ns | 0.5646 ns | 0.5005 ns |  6.11 |    0.38 |
| BitConverter_GetBytes_UInt64          | .NET Framework 4.6.2 | 29.041 ns | 0.8159 ns | 0.7632 ns |  6.62 |    0.44 |
| BitConverter_GetBytes_Int64           | .NET Framework 4.6.2 | 28.700 ns | 0.6238 ns | 0.5209 ns |  6.59 |    0.42 |
| BitConverter_GetBytes_UInt32          | .NET Framework 4.6.2 | 26.845 ns | 0.6949 ns | 0.6500 ns |  6.12 |    0.27 |
| BitConverter_GetBytes_Int32           | .NET Framework 4.6.2 | 26.512 ns | 0.6404 ns | 0.5348 ns |  6.09 |    0.34 |
| BitConverter_GetBytes_UInt16          | .NET Framework 4.6.2 | 25.798 ns | 0.6294 ns | 0.5580 ns |  5.90 |    0.34 |
| BitConverter_GetBytes_Int16           | .NET Framework 4.6.2 | 26.178 ns | 0.9007 ns | 0.8425 ns |  5.97 |    0.31 |
| BigEndianByteIndexer_Slice_Double     | .NET Framework 4.6.2 |  9.797 ns | 0.3983 ns | 0.3726 ns |  2.23 |    0.13 |
| BigEndianByteIndexer_Slice_Float      | .NET Framework 4.6.2 | 10.262 ns | 0.4339 ns | 0.4059 ns |  2.34 |    0.17 |
| BigEndianByteIndexer_Slice_UInt64     | .NET Framework 4.6.2 |  9.275 ns | 0.3374 ns | 0.3156 ns |  2.12 |    0.14 |
| BigEndianByteIndexer_Slice_Int64      | .NET Framework 4.6.2 |  9.337 ns | 0.4740 ns | 0.4434 ns |  2.13 |    0.15 |
| BigEndianByteIndexer_Slice_UInt32     | .NET Framework 4.6.2 |  5.744 ns | 0.2728 ns | 0.2552 ns |  1.31 |    0.08 |
| BigEndianByteIndexer_Slice_Int32      | .NET Framework 4.6.2 |  5.805 ns | 0.2523 ns | 0.2360 ns |  1.32 |    0.10 |
| BigEndianByteIndexer_Slice_UInt16     | .NET Framework 4.6.2 |  4.820 ns | 0.1907 ns | 0.1783 ns |  1.10 |    0.08 |
| BigEndianByteIndexer_Slice_Int16      | .NET Framework 4.6.2 |  4.650 ns | 0.2553 ns | 0.2388 ns |  1.06 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET Framework 4.6.2 |  9.929 ns | 0.3798 ns | 0.3367 ns |  2.27 |    0.16 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET Framework 4.6.2 | 10.328 ns | 0.4163 ns | 0.3894 ns |  2.36 |    0.16 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET Framework 4.6.2 |  9.447 ns | 0.4445 ns | 0.4158 ns |  2.16 |    0.16 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET Framework 4.6.2 |  5.991 ns | 0.1737 ns | 0.1540 ns |  1.37 |    0.09 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET Framework 4.6.2 |  6.274 ns | 0.3209 ns | 0.2505 ns |  1.45 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET Framework 4.6.2 |  3.903 ns | 0.1311 ns | 0.0948 ns |  0.91 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET Framework 4.6.2 |  5.168 ns | 0.1133 ns | 0.0674 ns |  1.19 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET Framework 4.6.2 |  3.267 ns | 0.1165 ns | 0.0973 ns |  0.75 |    0.05 |

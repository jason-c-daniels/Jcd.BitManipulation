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
| Method                                | Runtime              | Mean      | Error     | StdDev    | Ratio | RatioSD |
|-------------------------------------- |--------------------- |----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double          | .NET 8.0             |  4.804 ns | 0.4688 ns | 0.4156 ns |  1.39 |    0.13 |
| BitConverter_GetBytes_Float           | .NET 8.0             |  4.449 ns | 0.0722 ns | 0.0477 ns |  1.26 |    0.01 |
| BitConverter_GetBytes_UInt64          | .NET 8.0             |  4.164 ns | 0.0953 ns | 0.0630 ns |  1.18 |    0.02 |
| BitConverter_GetBytes_Int64           | .NET 8.0             |  4.275 ns | 0.0806 ns | 0.0533 ns |  1.21 |    0.02 |
| BitConverter_GetBytes_UInt32          | .NET 8.0             |  4.288 ns | 0.0567 ns | 0.0375 ns |  1.22 |    0.01 |
| BitConverter_GetBytes_Int32           | .NET 8.0             |  4.235 ns | 0.1229 ns | 0.1150 ns |  1.21 |    0.03 |
| BitConverter_GetBytes_UInt16          | .NET 8.0             |  3.974 ns | 0.1121 ns | 0.0741 ns |  1.13 |    0.02 |
| BitConverter_GetBytes_Int16           | .NET 8.0             |  4.046 ns | 0.0882 ns | 0.0584 ns |  1.15 |    0.02 |
| BigEndianByteIndexer_Slice_Double     | .NET 8.0             |  3.634 ns | 0.0537 ns | 0.0355 ns |  1.03 |    0.01 |
| BigEndianByteIndexer_Slice_Float      | .NET 8.0             |  3.333 ns | 0.0626 ns | 0.0414 ns |  0.95 |    0.01 |
| BigEndianByteIndexer_Slice_UInt64     | .NET 8.0             |  3.524 ns | 0.0271 ns | 0.0179 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Int64      | .NET 8.0             |  3.522 ns | 0.0443 ns | 0.0293 ns |  1.00 |    0.01 |
| BigEndianByteIndexer_Slice_UInt32     | .NET 8.0             |  3.306 ns | 0.0434 ns | 0.0287 ns |  0.94 |    0.01 |
| BigEndianByteIndexer_Slice_Int32      | .NET 8.0             |  3.425 ns | 0.0636 ns | 0.0420 ns |  0.97 |    0.01 |
| BigEndianByteIndexer_Slice_UInt16     | .NET 8.0             |  3.293 ns | 0.0516 ns | 0.0307 ns |  0.93 |    0.01 |
| BigEndianByteIndexer_Slice_Int16      | .NET 8.0             |  3.280 ns | 0.0498 ns | 0.0329 ns |  0.93 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET 8.0             |  3.645 ns | 0.0929 ns | 0.0615 ns |  1.03 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET 8.0             |  3.709 ns | 0.3712 ns | 0.3473 ns |  1.00 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET 8.0             |  3.370 ns | 0.0671 ns | 0.0351 ns |  0.96 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET 8.0             |  4.982 ns | 0.0667 ns | 0.0397 ns |  1.41 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET 8.0             |  3.389 ns | 0.0902 ns | 0.0597 ns |  0.96 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET 8.0             |  3.874 ns | 0.0709 ns | 0.0469 ns |  1.10 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET 8.0             |  3.061 ns | 0.1043 ns | 0.0621 ns |  0.87 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET 8.0             |  3.338 ns | 0.0761 ns | 0.0453 ns |  0.95 |    0.01 |
| BitConverter_GetBytes_Double          | .NET Framework 4.6.2 | 24.727 ns | 0.2755 ns | 0.1822 ns |  7.02 |    0.05 |
| BitConverter_GetBytes_Float           | .NET Framework 4.6.2 | 23.263 ns | 0.2603 ns | 0.1722 ns |  6.60 |    0.07 |
| BitConverter_GetBytes_UInt64          | .NET Framework 4.6.2 | 24.736 ns | 0.2041 ns | 0.1350 ns |  7.02 |    0.04 |
| BitConverter_GetBytes_Int64           | .NET Framework 4.6.2 | 24.620 ns | 0.1769 ns | 0.1053 ns |  6.99 |    0.05 |
| BitConverter_GetBytes_UInt32          | .NET Framework 4.6.2 | 23.253 ns | 0.1182 ns | 0.0703 ns |  6.60 |    0.04 |
| BitConverter_GetBytes_Int32           | .NET Framework 4.6.2 | 23.720 ns | 0.4675 ns | 0.2782 ns |  6.73 |    0.07 |
| BitConverter_GetBytes_UInt16          | .NET Framework 4.6.2 | 22.209 ns | 0.1886 ns | 0.0987 ns |  6.30 |    0.05 |
| BitConverter_GetBytes_Int16           | .NET Framework 4.6.2 | 22.059 ns | 0.1285 ns | 0.0765 ns |  6.26 |    0.03 |
| BigEndianByteIndexer_Slice_Double     | .NET Framework 4.6.2 |  8.231 ns | 0.1081 ns | 0.0715 ns |  2.34 |    0.01 |
| BigEndianByteIndexer_Slice_Float      | .NET Framework 4.6.2 |  8.875 ns | 0.1055 ns | 0.0698 ns |  2.52 |    0.02 |
| BigEndianByteIndexer_Slice_UInt64     | .NET Framework 4.6.2 |  7.806 ns | 0.0798 ns | 0.0528 ns |  2.21 |    0.02 |
| BigEndianByteIndexer_Slice_Int64      | .NET Framework 4.6.2 |  7.870 ns | 0.1255 ns | 0.0830 ns |  2.23 |    0.03 |
| BigEndianByteIndexer_Slice_UInt32     | .NET Framework 4.6.2 |  4.869 ns | 0.0889 ns | 0.0588 ns |  1.38 |    0.02 |
| BigEndianByteIndexer_Slice_Int32      | .NET Framework 4.6.2 |  4.912 ns | 0.0865 ns | 0.0572 ns |  1.39 |    0.02 |
| BigEndianByteIndexer_Slice_UInt16     | .NET Framework 4.6.2 |  3.993 ns | 0.0598 ns | 0.0356 ns |  1.13 |    0.01 |
| BigEndianByteIndexer_Slice_Int16      | .NET Framework 4.6.2 |  4.039 ns | 0.0458 ns | 0.0303 ns |  1.15 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET Framework 4.6.2 |  8.242 ns | 0.1067 ns | 0.0706 ns |  2.34 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET Framework 4.6.2 |  9.047 ns | 0.1049 ns | 0.0694 ns |  2.57 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET Framework 4.6.2 |  7.911 ns | 0.0663 ns | 0.0438 ns |  2.24 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET Framework 4.6.2 |  5.110 ns | 0.0319 ns | 0.0211 ns |  1.45 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET Framework 4.6.2 |  5.210 ns | 0.0917 ns | 0.0546 ns |  1.48 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET Framework 4.6.2 |  3.550 ns | 0.0500 ns | 0.0330 ns |  1.01 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET Framework 4.6.2 |  4.574 ns | 0.0189 ns | 0.0125 ns |  1.30 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET Framework 4.6.2 |  2.939 ns | 0.0359 ns | 0.0213 ns |  0.83 |    0.01 |

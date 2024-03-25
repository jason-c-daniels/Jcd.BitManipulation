```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-XAMXXP : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-HWKQSQ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                            | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|-----------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double      | .NET 8.0             |  5.494 ns | 0.3743 ns | 0.3126 ns |  1.11 |    0.14 |
| BitConverter_GetBytes_Float       | .NET 8.0             |  5.332 ns | 0.3285 ns | 0.2912 ns |  1.09 |    0.13 |
| BitConverter_GetBytes_UInt64      | .NET 8.0             |  5.113 ns | 0.2193 ns | 0.2051 ns |  1.05 |    0.09 |
| BitConverter_GetBytes_Int64       | .NET 8.0             |  5.158 ns | 0.4208 ns | 0.3936 ns |  1.06 |    0.13 |
| BitConverter_GetBytes_UInt32      | .NET 8.0             |  5.030 ns | 0.1311 ns | 0.1095 ns |  1.01 |    0.09 |
| BitConverter_GetBytes_Int32       | .NET 8.0             |  5.100 ns | 0.1258 ns | 0.0749 ns |  1.00 |    0.11 |
| BitConverter_GetBytes_UInt16      | .NET 8.0             |  5.190 ns | 0.2493 ns | 0.2332 ns |  1.07 |    0.13 |
| BitConverter_GetBytes_Int16       | .NET 8.0             |  4.909 ns | 0.5698 ns | 0.5330 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Double | .NET 8.0             |  5.433 ns | 0.4729 ns | 0.4423 ns |  1.12 |    0.16 |
| BigEndianByteIndexer_Slice_Float  | .NET 8.0             |  4.558 ns | 0.1330 ns | 0.0791 ns |  0.90 |    0.10 |
| BigEndianByteIndexer_Slice_UInt64 | .NET 8.0             |  4.980 ns | 0.5939 ns | 0.5555 ns |  1.03 |    0.19 |
| BigEndianByteIndexer_Slice_Int64  | .NET 8.0             |  5.673 ns | 0.5935 ns | 0.5261 ns |  1.16 |    0.17 |
| BigEndianByteIndexer_Slice_UInt32 | .NET 8.0             |  5.255 ns | 0.1810 ns | 0.1693 ns |  1.08 |    0.10 |
| BigEndianByteIndexer_Slice_Int32  | .NET 8.0             |  5.084 ns | 0.2151 ns | 0.2012 ns |  1.05 |    0.12 |
| BigEndianByteIndexer_Slice_UInt16 | .NET 8.0             |  4.696 ns | 0.2719 ns | 0.2544 ns |  0.96 |    0.08 |
| BigEndianByteIndexer_Slice_Int16  | .NET 8.0             |  4.645 ns | 0.1807 ns | 0.1691 ns |  0.95 |    0.08 |
| ExtensionMethod_ReadBytes_Double  | .NET 8.0             |  4.972 ns | 0.1422 ns | 0.1331 ns |  1.02 |    0.11 |
| ExtensionMethod_ReadBytes_Float   | .NET 8.0             |  5.480 ns | 0.5412 ns | 0.5062 ns |  1.13 |    0.18 |
| ExtensionMethod_ReadBytes_UInt64  | .NET 8.0             |  4.985 ns | 0.1971 ns | 0.1843 ns |  1.03 |    0.14 |
| ExtensionMethod_ReadBytes_Int64   | .NET 8.0             |  5.602 ns | 0.2831 ns | 0.2364 ns |  1.13 |    0.12 |
| ExtensionMethod_ReadBytes_UInt32  | .NET 8.0             |  4.862 ns | 0.2392 ns | 0.1997 ns |  0.98 |    0.12 |
| ExtensionMethod_ReadBytes_Int32   | .NET 8.0             |  4.430 ns | 0.1728 ns | 0.1616 ns |  0.91 |    0.10 |
| ExtensionMethod_ReadBytes_UInt16  | .NET 8.0             |  4.429 ns | 0.1711 ns | 0.1601 ns |  0.91 |    0.09 |
| ExtensionMethod_ReadBytes_Int16   | .NET 8.0             |  4.003 ns | 0.5054 ns | 0.4728 ns |  0.83 |    0.14 |
| BitConverter_GetBytes_Double      | .NET Framework 4.6.2 | 26.176 ns | 0.7120 ns | 0.6312 ns |  5.36 |    0.57 |
| BitConverter_GetBytes_Float       | .NET Framework 4.6.2 | 24.621 ns | 0.7603 ns | 0.7112 ns |  5.07 |    0.57 |
| BitConverter_GetBytes_UInt64      | .NET Framework 4.6.2 | 24.996 ns | 0.4817 ns | 0.2866 ns |  4.92 |    0.56 |
| BitConverter_GetBytes_Int64       | .NET Framework 4.6.2 | 25.410 ns | 0.5551 ns | 0.4014 ns |  5.10 |    0.50 |
| BitConverter_GetBytes_UInt32      | .NET Framework 4.6.2 | 23.704 ns | 0.2893 ns | 0.1513 ns |  4.62 |    0.51 |
| BitConverter_GetBytes_Int32       | .NET Framework 4.6.2 | 24.457 ns | 0.4963 ns | 0.3875 ns |  4.93 |    0.53 |
| BitConverter_GetBytes_UInt16      | .NET Framework 4.6.2 | 22.831 ns | 0.3824 ns | 0.2529 ns |  4.56 |    0.51 |
| BitConverter_GetBytes_Int16       | .NET Framework 4.6.2 | 23.247 ns | 0.6657 ns | 0.6227 ns |  4.79 |    0.51 |
| BigEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 |  7.400 ns | 0.5397 ns | 0.5048 ns |  1.52 |    0.14 |
| BigEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 |  8.497 ns | 0.4692 ns | 0.4389 ns |  1.75 |    0.23 |
| BigEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 |  7.894 ns | 0.3002 ns | 0.2809 ns |  1.63 |    0.18 |
| BigEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 |  7.896 ns | 0.3453 ns | 0.3230 ns |  1.63 |    0.19 |
| BigEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 |  4.148 ns | 0.0525 ns | 0.0313 ns |  0.82 |    0.09 |
| BigEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 |  4.148 ns | 0.0744 ns | 0.0492 ns |  0.83 |    0.09 |
| BigEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 |  3.018 ns | 0.0646 ns | 0.0427 ns |  0.60 |    0.06 |
| BigEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 |  3.258 ns | 0.2721 ns | 0.2412 ns |  0.67 |    0.09 |
| ExtensionMethod_ReadBytes_Double  | .NET Framework 4.6.2 |  7.090 ns | 0.2953 ns | 0.2762 ns |  1.46 |    0.16 |
| ExtensionMethod_ReadBytes_Float   | .NET Framework 4.6.2 |  8.326 ns | 0.1949 ns | 0.1160 ns |  1.64 |    0.19 |
| ExtensionMethod_ReadBytes_UInt64  | .NET Framework 4.6.2 |  7.777 ns | 0.4189 ns | 0.3919 ns |  1.60 |    0.16 |
| ExtensionMethod_ReadBytes_Int64   | .NET Framework 4.6.2 |  4.091 ns | 0.1705 ns | 0.1595 ns |  0.84 |    0.09 |
| ExtensionMethod_ReadBytes_UInt32  | .NET Framework 4.6.2 |  4.236 ns | 0.0519 ns | 0.0271 ns |  0.83 |    0.09 |
| ExtensionMethod_ReadBytes_Int32   | .NET Framework 4.6.2 |  3.474 ns | 0.1219 ns | 0.0952 ns |  0.70 |    0.07 |
| ExtensionMethod_ReadBytes_UInt16  | .NET Framework 4.6.2 |  3.006 ns | 0.1643 ns | 0.1537 ns |  0.62 |    0.08 |
| ExtensionMethod_ReadBytes_Int16   | .NET Framework 4.6.2 |  2.451 ns | 0.1625 ns | 0.1520 ns |  0.50 |    0.04 |

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

| Method                               | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double         | .NET 8.0             | 3.869 ns | 0.2428 ns | 0.2271 ns |  1.19 |    0.10 |
| BitConverter_GetBytes_Float          | .NET 8.0             | 3.877 ns | 0.2261 ns | 0.2115 ns |  1.19 |    0.09 |
| BitConverter_GetBytes_UInt64         | .NET 8.0             | 3.900 ns | 0.3690 ns | 0.3452 ns |  1.21 |    0.15 |
| BitConverter_GetBytes_Int64          | .NET 8.0             | 3.641 ns | 0.2000 ns | 0.1870 ns |  1.12 |    0.09 |
| BitConverter_GetBytes_UInt32         | .NET 8.0             | 3.733 ns | 0.3208 ns | 0.2843 ns |  1.15 |    0.12 |
| BitConverter_GetBytes_Int32          | .NET 8.0             | 3.766 ns | 0.6715 ns | 0.6282 ns |  1.16 |    0.19 |
| BitConverter_GetBytes_UInt16         | .NET 8.0             | 3.451 ns | 0.1967 ns | 0.1744 ns |  1.06 |    0.07 |
| BitConverter_GetBytes_Int16          | .NET 8.0             | 3.270 ns | 0.1789 ns | 0.1586 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Double | .NET 8.0             | 3.432 ns | 0.1800 ns | 0.1405 ns |  1.06 |    0.07 |
| LittleEndianByteIndexer_Slice_Float  | .NET 8.0             | 3.891 ns | 0.0944 ns | 0.0788 ns |  1.19 |    0.07 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET 8.0             | 3.746 ns | 0.2710 ns | 0.2535 ns |  1.15 |    0.10 |
| LittleEndianByteIndexer_Slice_Int64  | .NET 8.0             | 3.308 ns | 0.1255 ns | 0.1174 ns |  1.02 |    0.07 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET 8.0             | 3.209 ns | 0.0979 ns | 0.0647 ns |  1.00 |    0.06 |
| LittleEndianByteIndexer_Slice_Int32  | .NET 8.0             | 3.274 ns | 0.1323 ns | 0.1105 ns |  1.00 |    0.06 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET 8.0             | 3.641 ns | 0.2276 ns | 0.2018 ns |  1.12 |    0.09 |
| LittleEndianByteIndexer_Slice_Int16  | .NET 8.0             | 4.166 ns | 0.2338 ns | 0.2073 ns |  1.28 |    0.10 |
| ExtensionMethod_ReadBytes_Double     | .NET 8.0             | 3.425 ns | 0.3633 ns | 0.3034 ns |  1.05 |    0.11 |
| ExtensionMethod_ReadBytes_Float      | .NET 8.0             | 7.608 ns | 1.8867 ns | 1.7648 ns |  2.40 |    0.61 |
| ExtensionMethod_ReadBytes_UInt64     | .NET 8.0             | 4.162 ns | 0.8438 ns | 0.7480 ns |  1.27 |    0.22 |
| ExtensionMethod_ReadBytes_Int64      | .NET 8.0             | 5.385 ns | 0.3957 ns | 0.3702 ns |  1.66 |    0.15 |
| ExtensionMethod_ReadBytes_UInt32     | .NET 8.0             | 3.971 ns | 0.3411 ns | 0.3190 ns |  1.23 |    0.13 |
| ExtensionMethod_ReadBytes_Int32      | .NET 8.0             | 4.552 ns | 0.3975 ns | 0.3718 ns |  1.38 |    0.13 |
| ExtensionMethod_ReadBytes_UInt16     | .NET 8.0             | 3.935 ns | 0.4504 ns | 0.4213 ns |  1.22 |    0.16 |
| ExtensionMethod_ReadBytes_Int16      | .NET 8.0             | 3.622 ns | 0.2709 ns | 0.2534 ns |  1.10 |    0.07 |
| BitConverter_GetBytes_Double         | .NET Framework 4.6.2 | 4.243 ns | 0.1550 ns | 0.1450 ns |  1.30 |    0.07 |
| BitConverter_GetBytes_Float          | .NET Framework 4.6.2 | 3.745 ns | 0.1370 ns | 0.1281 ns |  1.15 |    0.06 |
| BitConverter_GetBytes_UInt64         | .NET Framework 4.6.2 | 4.024 ns | 0.1124 ns | 0.0743 ns |  1.25 |    0.05 |
| BitConverter_GetBytes_Int64          | .NET Framework 4.6.2 | 3.995 ns | 0.0602 ns | 0.0358 ns |  1.24 |    0.06 |
| BitConverter_GetBytes_UInt32         | .NET Framework 4.6.2 | 3.805 ns | 0.1125 ns | 0.0879 ns |  1.17 |    0.06 |
| BitConverter_GetBytes_Int32          | .NET Framework 4.6.2 | 3.775 ns | 0.0553 ns | 0.0365 ns |  1.17 |    0.06 |
| BitConverter_GetBytes_UInt16         | .NET Framework 4.6.2 | 3.939 ns | 0.2181 ns | 0.2040 ns |  1.20 |    0.06 |
| BitConverter_GetBytes_Int16          | .NET Framework 4.6.2 | 4.074 ns | 0.2215 ns | 0.1963 ns |  1.25 |    0.11 |
| LittleEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 | 6.826 ns | 0.2066 ns | 0.1932 ns |  2.09 |    0.10 |
| LittleEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 | 8.138 ns | 0.2324 ns | 0.2174 ns |  2.49 |    0.13 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 | 6.526 ns | 0.3789 ns | 0.3544 ns |  1.99 |    0.14 |
| LittleEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 | 6.062 ns | 0.1482 ns | 0.1237 ns |  1.86 |    0.09 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 | 3.638 ns | 0.0482 ns | 0.0287 ns |  1.13 |    0.06 |
| LittleEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 | 3.692 ns | 0.0986 ns | 0.0652 ns |  1.15 |    0.06 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 | 2.811 ns | 0.1858 ns | 0.1738 ns |  0.86 |    0.05 |
| LittleEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 | 2.788 ns | 0.0992 ns | 0.0928 ns |  0.85 |    0.05 |
| ExtensionMethod_ReadBytes_Double     | .NET Framework 4.6.2 | 6.588 ns | 0.2168 ns | 0.2028 ns |  2.02 |    0.13 |
| ExtensionMethod_ReadBytes_Float      | .NET Framework 4.6.2 | 8.490 ns | 0.3555 ns | 0.3151 ns |  2.60 |    0.14 |
| ExtensionMethod_ReadBytes_UInt64     | .NET Framework 4.6.2 | 6.153 ns | 0.1589 ns | 0.1149 ns |  1.90 |    0.08 |
| ExtensionMethod_ReadBytes_Int64      | .NET Framework 4.6.2 | 4.819 ns | 0.2524 ns | 0.2361 ns |  1.48 |    0.12 |
| ExtensionMethod_ReadBytes_UInt32     | .NET Framework 4.6.2 | 3.728 ns | 0.1158 ns | 0.1026 ns |  1.14 |    0.07 |
| ExtensionMethod_ReadBytes_Int32      | .NET Framework 4.6.2 | 3.822 ns | 0.2462 ns | 0.2182 ns |  1.17 |    0.09 |
| ExtensionMethod_ReadBytes_UInt16     | .NET Framework 4.6.2 | 3.082 ns | 0.4607 ns | 0.4084 ns |  0.94 |    0.13 |
| ExtensionMethod_ReadBytes_Int16      | .NET Framework 4.6.2 | 2.320 ns | 0.1081 ns | 0.0958 ns |  0.71 |    0.05 |

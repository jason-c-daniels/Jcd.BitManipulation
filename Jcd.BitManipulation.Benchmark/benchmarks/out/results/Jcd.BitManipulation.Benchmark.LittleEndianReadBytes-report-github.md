```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-WBOMYL : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-YFPBER : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                               | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double         | .NET 8.0             | 3.720 ns | 0.4220 ns | 0.3524 ns |  1.13 |    0.13 |
| BitConverter_GetBytes_Float          | .NET 8.0             | 3.573 ns | 0.0653 ns | 0.0432 ns |  1.08 |    0.05 |
| BitConverter_GetBytes_UInt64         | .NET 8.0             | 3.337 ns | 0.1069 ns | 0.0636 ns |  1.00 |    0.05 |
| BitConverter_GetBytes_Int64          | .NET 8.0             | 3.241 ns | 0.0967 ns | 0.0576 ns |  0.97 |    0.05 |
| BitConverter_GetBytes_UInt32         | .NET 8.0             | 3.197 ns | 0.0762 ns | 0.0504 ns |  0.96 |    0.05 |
| BitConverter_GetBytes_Int32          | .NET 8.0             | 3.355 ns | 0.1797 ns | 0.1681 ns |  1.01 |    0.07 |
| BitConverter_GetBytes_UInt16         | .NET 8.0             | 3.279 ns | 0.1615 ns | 0.1511 ns |  0.99 |    0.05 |
| BitConverter_GetBytes_Int16          | .NET 8.0             | 3.329 ns | 0.1633 ns | 0.1527 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Double | .NET 8.0             | 4.275 ns | 0.1680 ns | 0.1489 ns |  1.29 |    0.08 |
| LittleEndianByteIndexer_Slice_Float  | .NET 8.0             | 4.123 ns | 0.1274 ns | 0.0843 ns |  1.24 |    0.04 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET 8.0             | 3.593 ns | 0.0663 ns | 0.0347 ns |  1.08 |    0.05 |
| LittleEndianByteIndexer_Slice_Int64  | .NET 8.0             | 3.718 ns | 0.1184 ns | 0.0856 ns |  1.12 |    0.05 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET 8.0             | 3.715 ns | 0.1729 ns | 0.1533 ns |  1.12 |    0.08 |
| LittleEndianByteIndexer_Slice_Int32  | .NET 8.0             | 3.746 ns | 0.1250 ns | 0.1169 ns |  1.13 |    0.08 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET 8.0             | 3.663 ns | 0.1359 ns | 0.1271 ns |  1.10 |    0.06 |
| LittleEndianByteIndexer_Slice_Int16  | .NET 8.0             | 3.681 ns | 0.1860 ns | 0.1740 ns |  1.11 |    0.07 |
| ExtensionMethod_ReadBytes_Double     | .NET 8.0             | 3.881 ns | 0.1769 ns | 0.1654 ns |  1.17 |    0.07 |
| ExtensionMethod_ReadBytes_Float      | .NET 8.0             | 3.620 ns | 0.1538 ns | 0.1438 ns |  1.09 |    0.07 |
| ExtensionMethod_ReadBytes_UInt64     | .NET 8.0             | 3.795 ns | 0.2006 ns | 0.1876 ns |  1.14 |    0.07 |
| ExtensionMethod_ReadBytes_Int64      | .NET 8.0             | 5.061 ns | 0.1587 ns | 0.1485 ns |  1.52 |    0.08 |
| ExtensionMethod_ReadBytes_UInt32     | .NET 8.0             | 3.808 ns | 0.1586 ns | 0.1483 ns |  1.15 |    0.05 |
| ExtensionMethod_ReadBytes_Int32      | .NET 8.0             | 4.387 ns | 0.2422 ns | 0.2265 ns |  1.32 |    0.08 |
| ExtensionMethod_ReadBytes_UInt16     | .NET 8.0             | 3.430 ns | 0.0741 ns | 0.0441 ns |  1.03 |    0.05 |
| ExtensionMethod_ReadBytes_Int16      | .NET 8.0             | 3.359 ns | 0.0661 ns | 0.0393 ns |  1.01 |    0.04 |
| BitConverter_GetBytes_Double         | .NET Framework 4.6.2 | 4.239 ns | 0.0739 ns | 0.0489 ns |  1.28 |    0.06 |
| BitConverter_GetBytes_Float          | .NET Framework 4.6.2 | 3.697 ns | 0.0267 ns | 0.0177 ns |  1.12 |    0.05 |
| BitConverter_GetBytes_UInt64         | .NET Framework 4.6.2 | 4.126 ns | 0.0446 ns | 0.0265 ns |  1.24 |    0.06 |
| BitConverter_GetBytes_Int64          | .NET Framework 4.6.2 | 4.267 ns | 0.1295 ns | 0.0771 ns |  1.28 |    0.06 |
| BitConverter_GetBytes_UInt32         | .NET Framework 4.6.2 | 3.773 ns | 0.1150 ns | 0.0760 ns |  1.14 |    0.06 |
| BitConverter_GetBytes_Int32          | .NET Framework 4.6.2 | 3.661 ns | 0.0705 ns | 0.0466 ns |  1.10 |    0.05 |
| BitConverter_GetBytes_UInt16         | .NET Framework 4.6.2 | 3.902 ns | 0.0961 ns | 0.0635 ns |  1.18 |    0.05 |
| BitConverter_GetBytes_Int16          | .NET Framework 4.6.2 | 3.975 ns | 0.1230 ns | 0.0889 ns |  1.19 |    0.07 |
| LittleEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 | 5.929 ns | 0.1495 ns | 0.1081 ns |  1.78 |    0.08 |
| LittleEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 | 8.954 ns | 0.3026 ns | 0.2831 ns |  2.70 |    0.14 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 | 6.121 ns | 0.2964 ns | 0.2772 ns |  1.84 |    0.14 |
| LittleEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 | 6.080 ns | 0.3089 ns | 0.2890 ns |  1.83 |    0.12 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 | 4.281 ns | 0.0499 ns | 0.0330 ns |  1.29 |    0.06 |
| LittleEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 | 4.474 ns | 0.0380 ns | 0.0199 ns |  1.35 |    0.06 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 | 4.142 ns | 0.0528 ns | 0.0276 ns |  1.25 |    0.05 |
| LittleEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 | 4.185 ns | 0.0878 ns | 0.0523 ns |  1.26 |    0.06 |
| ExtensionMethod_ReadBytes_Double     | .NET Framework 4.6.2 | 5.726 ns | 0.1162 ns | 0.0769 ns |  1.73 |    0.09 |
| ExtensionMethod_ReadBytes_Float      | .NET Framework 4.6.2 | 8.253 ns | 0.1089 ns | 0.0720 ns |  2.49 |    0.12 |
| ExtensionMethod_ReadBytes_UInt64     | .NET Framework 4.6.2 | 5.614 ns | 0.1514 ns | 0.1416 ns |  1.69 |    0.07 |
| ExtensionMethod_ReadBytes_Int64      | .NET Framework 4.6.2 | 4.573 ns | 0.0525 ns | 0.0274 ns |  1.38 |    0.06 |
| ExtensionMethod_ReadBytes_UInt32     | .NET Framework 4.6.2 | 4.249 ns | 0.0241 ns | 0.0126 ns |  1.28 |    0.06 |
| ExtensionMethod_ReadBytes_Int32      | .NET Framework 4.6.2 | 3.469 ns | 0.1096 ns | 0.0856 ns |  1.05 |    0.07 |
| ExtensionMethod_ReadBytes_UInt16     | .NET Framework 4.6.2 | 3.811 ns | 0.0313 ns | 0.0207 ns |  1.15 |    0.05 |
| ExtensionMethod_ReadBytes_Int16      | .NET Framework 4.6.2 | 2.848 ns | 0.0607 ns | 0.0401 ns |  0.86 |    0.04 |

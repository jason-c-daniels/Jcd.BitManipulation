```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-CYDLTE : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-CSEHTA : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                               | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double         | .NET 8.0             | 3.450 ns | 0.2098 ns | 0.1752 ns |  1.15 |    0.07 |
| BitConverter_GetBytes_Float          | .NET 8.0             | 3.280 ns | 0.1021 ns | 0.0738 ns |  1.10 |    0.04 |
| BitConverter_GetBytes_UInt64         | .NET 8.0             | 3.208 ns | 0.2083 ns | 0.1847 ns |  1.07 |    0.08 |
| BitConverter_GetBytes_Int64          | .NET 8.0             | 3.230 ns | 0.2764 ns | 0.2585 ns |  1.08 |    0.10 |
| BitConverter_GetBytes_UInt32         | .NET 8.0             | 3.147 ns | 0.2581 ns | 0.2415 ns |  1.05 |    0.09 |
| BitConverter_GetBytes_Int32          | .NET 8.0             | 2.958 ns | 0.0715 ns | 0.0374 ns |  0.98 |    0.03 |
| BitConverter_GetBytes_UInt16         | .NET 8.0             | 3.089 ns | 0.1986 ns | 0.1658 ns |  1.03 |    0.06 |
| BitConverter_GetBytes_Int16          | .NET 8.0             | 3.009 ns | 0.1101 ns | 0.1030 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Double | .NET 8.0             | 3.363 ns | 0.0709 ns | 0.0422 ns |  1.12 |    0.05 |
| LittleEndianByteIndexer_Slice_Float  | .NET 8.0             | 3.409 ns | 0.0673 ns | 0.0401 ns |  1.14 |    0.04 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET 8.0             | 3.919 ns | 0.5983 ns | 0.5597 ns |  1.31 |    0.22 |
| LittleEndianByteIndexer_Slice_Int64  | .NET 8.0             | 3.293 ns | 0.0815 ns | 0.0485 ns |  1.10 |    0.05 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET 8.0             | 3.939 ns | 0.7000 ns | 0.6548 ns |  1.31 |    0.22 |
| LittleEndianByteIndexer_Slice_Int32  | .NET 8.0             | 3.389 ns | 0.1630 ns | 0.1445 ns |  1.13 |    0.07 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET 8.0             | 3.624 ns | 0.2767 ns | 0.2453 ns |  1.21 |    0.09 |
| LittleEndianByteIndexer_Slice_Int16  | .NET 8.0             | 4.198 ns | 1.2130 ns | 1.1347 ns |  1.39 |    0.35 |
| ExtensionMethod_ReadBytes_Double     | .NET 8.0             | 3.550 ns | 0.0880 ns | 0.0582 ns |  1.19 |    0.04 |
| ExtensionMethod_ReadBytes_Float      | .NET 8.0             | 3.306 ns | 0.1010 ns | 0.0668 ns |  1.11 |    0.04 |
| ExtensionMethod_ReadBytes_UInt64     | .NET 8.0             | 3.489 ns | 0.0861 ns | 0.0512 ns |  1.17 |    0.05 |
| ExtensionMethod_ReadBytes_Int64      | .NET 8.0             | 5.200 ns | 0.8935 ns | 0.8358 ns |  1.73 |    0.29 |
| ExtensionMethod_ReadBytes_UInt32     | .NET 8.0             | 3.232 ns | 0.0965 ns | 0.0574 ns |  1.08 |    0.05 |
| ExtensionMethod_ReadBytes_Int32      | .NET 8.0             | 3.698 ns | 0.1036 ns | 0.0749 ns |  1.24 |    0.05 |
| ExtensionMethod_ReadBytes_UInt16     | .NET 8.0             | 3.163 ns | 0.0733 ns | 0.0485 ns |  1.06 |    0.04 |
| ExtensionMethod_ReadBytes_Int16      | .NET 8.0             | 3.245 ns | 0.1048 ns | 0.0624 ns |  1.08 |    0.04 |
| BitConverter_GetBytes_Double         | .NET Framework 4.6.2 | 4.186 ns | 0.0532 ns | 0.0352 ns |  1.40 |    0.05 |
| BitConverter_GetBytes_Float          | .NET Framework 4.6.2 | 3.728 ns | 0.0825 ns | 0.0546 ns |  1.25 |    0.05 |
| BitConverter_GetBytes_UInt64         | .NET Framework 4.6.2 | 4.153 ns | 0.0746 ns | 0.0493 ns |  1.39 |    0.05 |
| BitConverter_GetBytes_Int64          | .NET Framework 4.6.2 | 4.024 ns | 0.0799 ns | 0.0528 ns |  1.35 |    0.05 |
| BitConverter_GetBytes_UInt32         | .NET Framework 4.6.2 | 3.812 ns | 0.0620 ns | 0.0410 ns |  1.28 |    0.05 |
| BitConverter_GetBytes_Int32          | .NET Framework 4.6.2 | 3.793 ns | 0.0368 ns | 0.0243 ns |  1.27 |    0.04 |
| BitConverter_GetBytes_UInt16         | .NET Framework 4.6.2 | 3.709 ns | 0.0289 ns | 0.0191 ns |  1.24 |    0.04 |
| BitConverter_GetBytes_Int16          | .NET Framework 4.6.2 | 3.694 ns | 0.0464 ns | 0.0307 ns |  1.24 |    0.04 |
| LittleEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 | 5.785 ns | 0.1578 ns | 0.1044 ns |  1.94 |    0.06 |
| LittleEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 | 8.379 ns | 0.0688 ns | 0.0455 ns |  2.81 |    0.10 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 | 5.459 ns | 0.0767 ns | 0.0456 ns |  1.82 |    0.07 |
| LittleEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 | 5.508 ns | 0.2015 ns | 0.1682 ns |  1.84 |    0.10 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 | 4.292 ns | 0.0430 ns | 0.0256 ns |  1.43 |    0.05 |
| LittleEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 | 4.336 ns | 0.0716 ns | 0.0474 ns |  1.45 |    0.06 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 | 4.179 ns | 0.0451 ns | 0.0298 ns |  1.40 |    0.05 |
| LittleEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 | 4.250 ns | 0.0879 ns | 0.0581 ns |  1.43 |    0.06 |
| ExtensionMethod_ReadBytes_Double     | .NET Framework 4.6.2 | 5.825 ns | 0.1930 ns | 0.1711 ns |  1.94 |    0.10 |
| ExtensionMethod_ReadBytes_Float      | .NET Framework 4.6.2 | 8.391 ns | 0.1963 ns | 0.1299 ns |  2.82 |    0.11 |
| ExtensionMethod_ReadBytes_UInt64     | .NET Framework 4.6.2 | 5.903 ns | 0.3810 ns | 0.3564 ns |  1.96 |    0.12 |
| ExtensionMethod_ReadBytes_Int64      | .NET Framework 4.6.2 | 5.136 ns | 0.3461 ns | 0.3237 ns |  1.71 |    0.09 |
| ExtensionMethod_ReadBytes_UInt32     | .NET Framework 4.6.2 | 5.490 ns | 0.3191 ns | 0.2829 ns |  1.83 |    0.12 |
| ExtensionMethod_ReadBytes_Int32      | .NET Framework 4.6.2 | 3.289 ns | 0.0605 ns | 0.0400 ns |  1.10 |    0.03 |
| ExtensionMethod_ReadBytes_UInt16     | .NET Framework 4.6.2 | 3.991 ns | 0.3060 ns | 0.2862 ns |  1.33 |    0.10 |
| ExtensionMethod_ReadBytes_Int16      | .NET Framework 4.6.2 | 2.715 ns | 0.0896 ns | 0.0593 ns |  0.91 |    0.04 |

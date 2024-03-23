```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-JSAIVR : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-PHWTJI : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                               | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double         | .NET 8.0             | 3.096 ns | 0.0620 ns | 0.0410 ns |  1.01 |    0.02 |
| BitConverter_GetBytes_Float          | .NET 8.0             | 3.066 ns | 0.0491 ns | 0.0292 ns |  1.00 |    0.01 |
| BitConverter_GetBytes_UInt64         | .NET 8.0             | 2.999 ns | 0.0330 ns | 0.0218 ns |  0.98 |    0.01 |
| BitConverter_GetBytes_Int64          | .NET 8.0             | 3.069 ns | 0.0175 ns | 0.0104 ns |  1.00 |    0.01 |
| BitConverter_GetBytes_UInt32         | .NET 8.0             | 3.008 ns | 0.0692 ns | 0.0457 ns |  0.98 |    0.02 |
| BitConverter_GetBytes_Int32          | .NET 8.0             | 3.165 ns | 0.0938 ns | 0.0620 ns |  1.03 |    0.02 |
| BitConverter_GetBytes_UInt16         | .NET 8.0             | 3.053 ns | 0.0836 ns | 0.0553 ns |  1.00 |    0.02 |
| BitConverter_GetBytes_Int16          | .NET 8.0             | 3.060 ns | 0.0514 ns | 0.0340 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Double | .NET 8.0             | 5.189 ns | 0.0498 ns | 0.0330 ns |  1.70 |    0.03 |
| LittleEndianByteIndexer_Slice_Float  | .NET 8.0             | 5.996 ns | 0.0806 ns | 0.0533 ns |  1.96 |    0.03 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET 8.0             | 5.684 ns | 0.1474 ns | 0.0975 ns |  1.86 |    0.04 |
| LittleEndianByteIndexer_Slice_Int64  | .NET 8.0             | 5.800 ns | 0.2843 ns | 0.2659 ns |  1.92 |    0.07 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET 8.0             | 4.875 ns | 0.0492 ns | 0.0325 ns |  1.59 |    0.02 |
| LittleEndianByteIndexer_Slice_Int32  | .NET 8.0             | 5.022 ns | 0.0978 ns | 0.0647 ns |  1.64 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET 8.0             | 3.537 ns | 0.0424 ns | 0.0280 ns |  1.16 |    0.02 |
| LittleEndianByteIndexer_Slice_Int16  | .NET 8.0             | 3.594 ns | 0.0562 ns | 0.0372 ns |  1.17 |    0.01 |
| ExtensionMethod_ReadBytes_Double     | .NET 8.0             | 6.007 ns | 0.2016 ns | 0.1886 ns |  1.97 |    0.07 |
| ExtensionMethod_ReadBytes_Float      | .NET 8.0             | 6.917 ns | 0.0915 ns | 0.0605 ns |  2.26 |    0.03 |
| ExtensionMethod_ReadBytes_UInt64     | .NET 8.0             | 5.326 ns | 0.0549 ns | 0.0363 ns |  1.74 |    0.02 |
| ExtensionMethod_ReadBytes_Int64      | .NET 8.0             | 4.579 ns | 0.1200 ns | 0.0868 ns |  1.50 |    0.03 |
| ExtensionMethod_ReadBytes_UInt32     | .NET 8.0             | 4.015 ns | 0.0482 ns | 0.0319 ns |  1.31 |    0.02 |
| ExtensionMethod_ReadBytes_Int32      | .NET 8.0             | 3.298 ns | 0.0410 ns | 0.0271 ns |  1.08 |    0.02 |
| ExtensionMethod_ReadBytes_UInt16     | .NET 8.0             | 3.706 ns | 0.0784 ns | 0.0519 ns |  1.21 |    0.02 |
| ExtensionMethod_ReadBytes_Int16      | .NET 8.0             | 3.013 ns | 0.0455 ns | 0.0271 ns |  0.99 |    0.02 |
| BitConverter_GetBytes_Double         | .NET Framework 4.6.2 | 4.096 ns | 0.0592 ns | 0.0309 ns |  1.34 |    0.01 |
| BitConverter_GetBytes_Float          | .NET Framework 4.6.2 | 3.715 ns | 0.0173 ns | 0.0091 ns |  1.21 |    0.01 |
| BitConverter_GetBytes_UInt64         | .NET Framework 4.6.2 | 4.116 ns | 0.0401 ns | 0.0239 ns |  1.35 |    0.02 |
| BitConverter_GetBytes_Int64          | .NET Framework 4.6.2 | 3.508 ns | 0.0191 ns | 0.0126 ns |  1.15 |    0.01 |
| BitConverter_GetBytes_UInt32         | .NET Framework 4.6.2 | 3.702 ns | 0.0526 ns | 0.0348 ns |  1.21 |    0.01 |
| BitConverter_GetBytes_Int32          | .NET Framework 4.6.2 | 3.163 ns | 0.0481 ns | 0.0318 ns |  1.03 |    0.02 |
| BitConverter_GetBytes_UInt16         | .NET Framework 4.6.2 | 3.880 ns | 0.1489 ns | 0.1320 ns |  1.28 |    0.04 |
| BitConverter_GetBytes_Int16          | .NET Framework 4.6.2 | 3.096 ns | 0.0480 ns | 0.0318 ns |  1.01 |    0.02 |
| LittleEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 | 6.195 ns | 0.0481 ns | 0.0318 ns |  2.03 |    0.03 |
| LittleEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 | 9.983 ns | 0.1007 ns | 0.0666 ns |  3.26 |    0.04 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 | 6.266 ns | 0.1117 ns | 0.0739 ns |  2.05 |    0.03 |
| LittleEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 | 6.215 ns | 0.0468 ns | 0.0278 ns |  2.03 |    0.03 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 | 3.989 ns | 0.0360 ns | 0.0238 ns |  1.30 |    0.02 |
| LittleEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 | 4.410 ns | 0.0424 ns | 0.0252 ns |  1.44 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 | 2.996 ns | 0.0156 ns | 0.0103 ns |  0.98 |    0.01 |
| LittleEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 | 2.973 ns | 0.0545 ns | 0.0360 ns |  0.97 |    0.01 |
| ExtensionMethod_ReadBytes_Double     | .NET Framework 4.6.2 | 6.255 ns | 0.0387 ns | 0.0230 ns |  2.05 |    0.02 |
| ExtensionMethod_ReadBytes_Float      | .NET Framework 4.6.2 | 8.853 ns | 0.0647 ns | 0.0385 ns |  2.90 |    0.03 |
| ExtensionMethod_ReadBytes_UInt64     | .NET Framework 4.6.2 | 6.344 ns | 0.0910 ns | 0.0602 ns |  2.07 |    0.03 |
| ExtensionMethod_ReadBytes_Int64      | .NET Framework 4.6.2 | 4.253 ns | 0.0265 ns | 0.0139 ns |  1.39 |    0.02 |
| ExtensionMethod_ReadBytes_UInt32     | .NET Framework 4.6.2 | 3.694 ns | 0.1145 ns | 0.0894 ns |  1.21 |    0.04 |
| ExtensionMethod_ReadBytes_Int32      | .NET Framework 4.6.2 | 2.922 ns | 0.0328 ns | 0.0195 ns |  0.96 |    0.01 |
| ExtensionMethod_ReadBytes_UInt16     | .NET Framework 4.6.2 | 2.976 ns | 0.2528 ns | 0.2241 ns |  0.99 |    0.09 |
| ExtensionMethod_ReadBytes_Int16      | .NET Framework 4.6.2 | 2.663 ns | 0.0365 ns | 0.0242 ns |  0.87 |    0.01 |

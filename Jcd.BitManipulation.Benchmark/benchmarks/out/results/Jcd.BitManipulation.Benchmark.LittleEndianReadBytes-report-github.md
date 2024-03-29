```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-JSKQEV : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-FYSSQN : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                               | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double         | .NET 8.0             | 3.368 ns | 0.0816 ns | 0.0486 ns |  1.09 |    0.03 |
| BitConverter_GetBytes_Float          | .NET 8.0             | 3.508 ns | 0.2221 ns | 0.2078 ns |  1.14 |    0.09 |
| BitConverter_GetBytes_UInt64         | .NET 8.0             | 3.241 ns | 0.1041 ns | 0.0869 ns |  1.05 |    0.04 |
| BitConverter_GetBytes_Int64          | .NET 8.0             | 3.344 ns | 0.3752 ns | 0.3510 ns |  1.08 |    0.10 |
| BitConverter_GetBytes_UInt32         | .NET 8.0             | 3.439 ns | 0.4926 ns | 0.4608 ns |  1.11 |    0.16 |
| BitConverter_GetBytes_Int32          | .NET 8.0             | 3.162 ns | 0.1019 ns | 0.0953 ns |  1.02 |    0.05 |
| BitConverter_GetBytes_UInt16         | .NET 8.0             | 3.118 ns | 0.0964 ns | 0.0573 ns |  1.01 |    0.03 |
| BitConverter_GetBytes_Int16          | .NET 8.0             | 3.093 ns | 0.1146 ns | 0.1072 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Double | .NET 8.0             | 3.646 ns | 0.1549 ns | 0.1449 ns |  1.18 |    0.05 |
| LittleEndianByteIndexer_Slice_Float  | .NET 8.0             | 3.508 ns | 0.1074 ns | 0.0897 ns |  1.14 |    0.05 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET 8.0             | 3.674 ns | 0.1108 ns | 0.0802 ns |  1.19 |    0.05 |
| LittleEndianByteIndexer_Slice_Int64  | .NET 8.0             | 3.453 ns | 0.1766 ns | 0.1652 ns |  1.12 |    0.08 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET 8.0             | 3.177 ns | 0.1116 ns | 0.1044 ns |  1.03 |    0.06 |
| LittleEndianByteIndexer_Slice_Int32  | .NET 8.0             | 3.565 ns | 0.1128 ns | 0.0942 ns |  1.16 |    0.05 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET 8.0             | 3.564 ns | 0.1218 ns | 0.1080 ns |  1.16 |    0.05 |
| LittleEndianByteIndexer_Slice_Int16  | .NET 8.0             | 3.542 ns | 0.1368 ns | 0.1213 ns |  1.15 |    0.05 |
| ExtensionMethod_ReadBytes_Double     | .NET 8.0             | 3.855 ns | 0.1463 ns | 0.1368 ns |  1.25 |    0.06 |
| ExtensionMethod_ReadBytes_Float      | .NET 8.0             | 3.524 ns | 0.0674 ns | 0.0445 ns |  1.15 |    0.05 |
| ExtensionMethod_ReadBytes_UInt64     | .NET 8.0             | 3.706 ns | 0.1231 ns | 0.1091 ns |  1.20 |    0.05 |
| ExtensionMethod_ReadBytes_Int64      | .NET 8.0             | 4.668 ns | 0.0846 ns | 0.0443 ns |  1.52 |    0.05 |
| ExtensionMethod_ReadBytes_UInt32     | .NET 8.0             | 3.483 ns | 0.1073 ns | 0.0896 ns |  1.13 |    0.05 |
| ExtensionMethod_ReadBytes_Int32      | .NET 8.0             | 3.597 ns | 0.1465 ns | 0.1371 ns |  1.16 |    0.07 |
| ExtensionMethod_ReadBytes_UInt16     | .NET 8.0             | 3.292 ns | 0.1103 ns | 0.0978 ns |  1.07 |    0.05 |
| ExtensionMethod_ReadBytes_Int16      | .NET 8.0             | 3.494 ns | 0.1341 ns | 0.1254 ns |  1.13 |    0.06 |
| BitConverter_GetBytes_Double         | .NET Framework 4.6.2 | 4.198 ns | 0.0992 ns | 0.0656 ns |  1.37 |    0.05 |
| BitConverter_GetBytes_Float          | .NET Framework 4.6.2 | 3.765 ns | 0.1617 ns | 0.1513 ns |  1.22 |    0.07 |
| BitConverter_GetBytes_UInt64         | .NET Framework 4.6.2 | 4.130 ns | 0.0853 ns | 0.0446 ns |  1.34 |    0.05 |
| BitConverter_GetBytes_Int64          | .NET Framework 4.6.2 | 4.101 ns | 0.0704 ns | 0.0466 ns |  1.34 |    0.04 |
| BitConverter_GetBytes_UInt32         | .NET Framework 4.6.2 | 3.634 ns | 0.0901 ns | 0.0536 ns |  1.18 |    0.04 |
| BitConverter_GetBytes_Int32          | .NET Framework 4.6.2 | 3.667 ns | 0.1158 ns | 0.0766 ns |  1.19 |    0.04 |
| BitConverter_GetBytes_UInt16         | .NET Framework 4.6.2 | 3.721 ns | 0.0693 ns | 0.0412 ns |  1.21 |    0.04 |
| BitConverter_GetBytes_Int16          | .NET Framework 4.6.2 | 3.867 ns | 0.1167 ns | 0.0911 ns |  1.26 |    0.04 |
| LittleEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 | 5.760 ns | 0.3610 ns | 0.3377 ns |  1.86 |    0.11 |
| LittleEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 | 8.315 ns | 0.1890 ns | 0.1125 ns |  2.70 |    0.11 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 | 5.664 ns | 0.4093 ns | 0.3828 ns |  1.83 |    0.14 |
| LittleEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 | 5.939 ns | 0.4967 ns | 0.4646 ns |  1.92 |    0.18 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 | 4.392 ns | 0.1731 ns | 0.1619 ns |  1.42 |    0.07 |
| LittleEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 | 4.427 ns | 0.2350 ns | 0.2083 ns |  1.44 |    0.07 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 | 4.158 ns | 0.1258 ns | 0.0832 ns |  1.35 |    0.05 |
| LittleEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 | 4.110 ns | 0.1205 ns | 0.0717 ns |  1.33 |    0.05 |
| ExtensionMethod_ReadBytes_Double     | .NET Framework 4.6.2 | 5.724 ns | 0.2365 ns | 0.2096 ns |  1.86 |    0.09 |
| ExtensionMethod_ReadBytes_Float      | .NET Framework 4.6.2 | 8.197 ns | 0.1876 ns | 0.1356 ns |  2.66 |    0.09 |
| ExtensionMethod_ReadBytes_UInt64     | .NET Framework 4.6.2 | 5.659 ns | 0.2116 ns | 0.1876 ns |  1.84 |    0.10 |
| ExtensionMethod_ReadBytes_Int64      | .NET Framework 4.6.2 | 4.826 ns | 0.3786 ns | 0.3541 ns |  1.56 |    0.13 |
| ExtensionMethod_ReadBytes_UInt32     | .NET Framework 4.6.2 | 4.165 ns | 0.0876 ns | 0.0579 ns |  1.36 |    0.05 |
| ExtensionMethod_ReadBytes_Int32      | .NET Framework 4.6.2 | 3.284 ns | 0.1055 ns | 0.0628 ns |  1.07 |    0.04 |
| ExtensionMethod_ReadBytes_UInt16     | .NET Framework 4.6.2 | 3.756 ns | 0.0853 ns | 0.0564 ns |  1.22 |    0.04 |
| ExtensionMethod_ReadBytes_Int16      | .NET Framework 4.6.2 | 2.876 ns | 0.0959 ns | 0.0801 ns |  0.93 |    0.04 |

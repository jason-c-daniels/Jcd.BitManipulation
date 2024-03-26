```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-LCJIBQ : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-XKYBZO : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                               | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double         | .NET 8.0             | 3.337 ns | 0.1645 ns | 0.1539 ns |  1.09 |    0.07 |
| BitConverter_GetBytes_Float          | .NET 8.0             | 3.285 ns | 0.1105 ns | 0.0863 ns |  1.07 |    0.06 |
| BitConverter_GetBytes_UInt64         | .NET 8.0             | 3.185 ns | 0.1851 ns | 0.1731 ns |  1.04 |    0.07 |
| BitConverter_GetBytes_Int64          | .NET 8.0             | 3.092 ns | 0.1697 ns | 0.1505 ns |  1.01 |    0.06 |
| BitConverter_GetBytes_UInt32         | .NET 8.0             | 3.058 ns | 0.1446 ns | 0.1282 ns |  1.00 |    0.09 |
| BitConverter_GetBytes_Int32          | .NET 8.0             | 3.046 ns | 0.0891 ns | 0.0590 ns |  0.99 |    0.05 |
| BitConverter_GetBytes_UInt16         | .NET 8.0             | 3.082 ns | 0.1009 ns | 0.0894 ns |  1.01 |    0.06 |
| BitConverter_GetBytes_Int16          | .NET 8.0             | 3.080 ns | 0.1769 ns | 0.1655 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Double | .NET 8.0             | 3.578 ns | 0.1274 ns | 0.1192 ns |  1.16 |    0.06 |
| LittleEndianByteIndexer_Slice_Float  | .NET 8.0             | 3.490 ns | 0.1313 ns | 0.1228 ns |  1.14 |    0.06 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET 8.0             | 3.413 ns | 0.1433 ns | 0.1340 ns |  1.11 |    0.08 |
| LittleEndianByteIndexer_Slice_Int64  | .NET 8.0             | 3.447 ns | 0.1135 ns | 0.0751 ns |  1.12 |    0.06 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET 8.0             | 3.503 ns | 0.1242 ns | 0.1161 ns |  1.14 |    0.05 |
| LittleEndianByteIndexer_Slice_Int32  | .NET 8.0             | 3.480 ns | 0.1577 ns | 0.1398 ns |  1.14 |    0.07 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET 8.0             | 3.568 ns | 0.1282 ns | 0.1199 ns |  1.16 |    0.08 |
| LittleEndianByteIndexer_Slice_Int16  | .NET 8.0             | 3.390 ns | 0.1109 ns | 0.0926 ns |  1.11 |    0.07 |
| ExtensionMethod_ReadBytes_Double     | .NET 8.0             | 3.656 ns | 0.1195 ns | 0.1117 ns |  1.19 |    0.07 |
| ExtensionMethod_ReadBytes_Float      | .NET 8.0             | 3.452 ns | 0.1528 ns | 0.1429 ns |  1.12 |    0.08 |
| ExtensionMethod_ReadBytes_UInt64     | .NET 8.0             | 3.574 ns | 0.1048 ns | 0.0818 ns |  1.16 |    0.07 |
| ExtensionMethod_ReadBytes_Int64      | .NET 8.0             | 4.025 ns | 0.1253 ns | 0.1111 ns |  1.31 |    0.07 |
| ExtensionMethod_ReadBytes_UInt32     | .NET 8.0             | 3.123 ns | 0.0747 ns | 0.0445 ns |  1.01 |    0.05 |
| ExtensionMethod_ReadBytes_Int32      | .NET 8.0             | 3.741 ns | 0.1849 ns | 0.1729 ns |  1.22 |    0.08 |
| ExtensionMethod_ReadBytes_UInt16     | .NET 8.0             | 3.095 ns | 0.1209 ns | 0.1071 ns |  1.01 |    0.07 |
| ExtensionMethod_ReadBytes_Int16      | .NET 8.0             | 3.306 ns | 0.1591 ns | 0.1488 ns |  1.08 |    0.07 |
| BitConverter_GetBytes_Double         | .NET Framework 4.6.2 | 4.153 ns | 0.1008 ns | 0.0600 ns |  1.34 |    0.08 |
| BitConverter_GetBytes_Float          | .NET Framework 4.6.2 | 3.746 ns | 0.1233 ns | 0.1153 ns |  1.22 |    0.06 |
| BitConverter_GetBytes_UInt64         | .NET Framework 4.6.2 | 4.048 ns | 0.1248 ns | 0.0974 ns |  1.31 |    0.07 |
| BitConverter_GetBytes_Int64          | .NET Framework 4.6.2 | 4.098 ns | 0.1124 ns | 0.0744 ns |  1.33 |    0.08 |
| BitConverter_GetBytes_UInt32         | .NET Framework 4.6.2 | 3.746 ns | 0.1201 ns | 0.0794 ns |  1.21 |    0.05 |
| BitConverter_GetBytes_Int32          | .NET Framework 4.6.2 | 3.665 ns | 0.0952 ns | 0.0630 ns |  1.19 |    0.06 |
| BitConverter_GetBytes_UInt16         | .NET Framework 4.6.2 | 3.683 ns | 0.0527 ns | 0.0349 ns |  1.19 |    0.06 |
| BitConverter_GetBytes_Int16          | .NET Framework 4.6.2 | 3.741 ns | 0.1142 ns | 0.0953 ns |  1.22 |    0.07 |
| LittleEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 | 5.772 ns | 0.3111 ns | 0.2758 ns |  1.89 |    0.16 |
| LittleEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 | 8.597 ns | 0.3250 ns | 0.3040 ns |  2.80 |    0.18 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 | 5.560 ns | 0.1847 ns | 0.1637 ns |  1.82 |    0.11 |
| LittleEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 | 5.565 ns | 0.2658 ns | 0.2486 ns |  1.81 |    0.13 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 | 4.310 ns | 0.1039 ns | 0.0619 ns |  1.39 |    0.06 |
| LittleEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 | 4.376 ns | 0.1295 ns | 0.0936 ns |  1.41 |    0.08 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 | 4.324 ns | 0.1511 ns | 0.1414 ns |  1.41 |    0.10 |
| LittleEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 | 4.219 ns | 0.1271 ns | 0.0919 ns |  1.36 |    0.09 |
| ExtensionMethod_ReadBytes_Double     | .NET Framework 4.6.2 | 5.763 ns | 0.2851 ns | 0.2667 ns |  1.88 |    0.12 |
| ExtensionMethod_ReadBytes_Float      | .NET Framework 4.6.2 | 8.242 ns | 0.1171 ns | 0.0612 ns |  2.65 |    0.14 |
| ExtensionMethod_ReadBytes_UInt64     | .NET Framework 4.6.2 | 5.519 ns | 0.1509 ns | 0.1091 ns |  1.78 |    0.10 |
| ExtensionMethod_ReadBytes_Int64      | .NET Framework 4.6.2 | 4.606 ns | 0.1229 ns | 0.0888 ns |  1.48 |    0.07 |
| ExtensionMethod_ReadBytes_UInt32     | .NET Framework 4.6.2 | 4.286 ns | 0.1673 ns | 0.1565 ns |  1.40 |    0.10 |
| ExtensionMethod_ReadBytes_Int32      | .NET Framework 4.6.2 | 3.316 ns | 0.1067 ns | 0.0833 ns |  1.08 |    0.07 |
| ExtensionMethod_ReadBytes_UInt16     | .NET Framework 4.6.2 | 3.754 ns | 0.0559 ns | 0.0370 ns |  1.22 |    0.06 |
| ExtensionMethod_ReadBytes_Int16      | .NET Framework 4.6.2 | 2.752 ns | 0.0594 ns | 0.0393 ns |  0.89 |    0.05 |

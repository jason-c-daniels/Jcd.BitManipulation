```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-NGSTAA : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-DGGSAB : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```
| Method                                | Runtime              | Mean     | Error     | StdDev    | Ratio | RatioSD |
|-------------------------------------- |--------------------- |---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double          | .NET 8.0             | 3.379 ns | 0.0997 ns | 0.0660 ns |  0.94 |    0.03 |
| BitConverter_GetBytes_Float           | .NET 8.0             | 3.386 ns | 0.1045 ns | 0.0691 ns |  0.94 |    0.03 |
| BitConverter_GetBytes_UInt64          | .NET 8.0             | 3.201 ns | 0.1038 ns | 0.0867 ns |  0.89 |    0.04 |
| BitConverter_GetBytes_Int64           | .NET 8.0             | 3.151 ns | 0.0752 ns | 0.0448 ns |  0.87 |    0.02 |
| BitConverter_GetBytes_UInt32          | .NET 8.0             | 3.201 ns | 0.0896 ns | 0.0593 ns |  0.89 |    0.03 |
| BitConverter_GetBytes_Int32           | .NET 8.0             | 3.156 ns | 0.1042 ns | 0.0753 ns |  0.88 |    0.03 |
| BitConverter_GetBytes_UInt16          | .NET 8.0             | 3.087 ns | 0.0716 ns | 0.0474 ns |  0.86 |    0.02 |
| BitConverter_GetBytes_Int16           | .NET 8.0             | 3.130 ns | 0.1050 ns | 0.0820 ns |  0.87 |    0.03 |
| LittleEndianByteIndexer_Slice_Double  | .NET 8.0             | 3.636 ns | 0.0903 ns | 0.0597 ns |  1.01 |    0.02 |
| LittleEndianByteIndexer_Slice_Float   | .NET 8.0             | 3.326 ns | 0.1017 ns | 0.0673 ns |  0.93 |    0.03 |
| LittleEndianByteIndexer_Slice_UInt64  | .NET 8.0             | 3.604 ns | 0.1080 ns | 0.0781 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Int64   | .NET 8.0             | 3.648 ns | 0.0926 ns | 0.0485 ns |  1.01 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt32  | .NET 8.0             | 3.411 ns | 0.0917 ns | 0.0716 ns |  0.95 |    0.03 |
| LittleEndianByteIndexer_Slice_Int32   | .NET 8.0             | 3.378 ns | 0.1056 ns | 0.0824 ns |  0.94 |    0.03 |
| LittleEndianByteIndexer_Slice_UInt16  | .NET 8.0             | 3.378 ns | 0.1154 ns | 0.1079 ns |  0.94 |    0.05 |
| LittleEndianByteIndexer_Slice_Int16   | .NET 8.0             | 3.329 ns | 0.1543 ns | 0.1443 ns |  0.92 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET 8.0             | 3.748 ns | 0.1435 ns | 0.1343 ns |  1.04 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET 8.0             | 3.775 ns | 0.4869 ns | 0.4554 ns |  1.04 |    0.14 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET 8.0             | 3.776 ns | 0.3657 ns | 0.3241 ns |  1.03 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET 8.0             | 4.319 ns | 0.1435 ns | 0.1272 ns |  1.20 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET 8.0             | 3.616 ns | 0.2831 ns | 0.2364 ns |  1.01 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET 8.0             | 3.631 ns | 0.1051 ns | 0.0932 ns |  1.01 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET 8.0             | 3.172 ns | 0.0776 ns | 0.0513 ns |  0.88 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET 8.0             | 3.313 ns | 0.1218 ns | 0.1139 ns |  0.93 |    0.04 |
| BitConverter_GetBytes_Double          | .NET Framework 4.6.2 | 4.151 ns | 0.0983 ns | 0.0711 ns |  1.15 |    0.02 |
| BitConverter_GetBytes_Float           | .NET Framework 4.6.2 | 3.679 ns | 0.0640 ns | 0.0424 ns |  1.02 |    0.03 |
| BitConverter_GetBytes_UInt64          | .NET Framework 4.6.2 | 4.052 ns | 0.1076 ns | 0.0640 ns |  1.12 |    0.04 |
| BitConverter_GetBytes_Int64           | .NET Framework 4.6.2 | 4.197 ns | 0.1063 ns | 0.0703 ns |  1.17 |    0.03 |
| BitConverter_GetBytes_UInt32          | .NET Framework 4.6.2 | 3.896 ns | 0.1536 ns | 0.1437 ns |  1.09 |    0.07 |
| BitConverter_GetBytes_Int32           | .NET Framework 4.6.2 | 3.773 ns | 0.0914 ns | 0.0605 ns |  1.05 |    0.03 |
| BitConverter_GetBytes_UInt16          | .NET Framework 4.6.2 | 3.822 ns | 0.1893 ns | 0.1678 ns |  1.06 |    0.04 |
| BitConverter_GetBytes_Int16           | .NET Framework 4.6.2 | 3.803 ns | 0.1165 ns | 0.0842 ns |  1.06 |    0.04 |
| LittleEndianByteIndexer_Slice_Double  | .NET Framework 4.6.2 | 6.052 ns | 0.2961 ns | 0.2770 ns |  1.66 |    0.08 |
| LittleEndianByteIndexer_Slice_Float   | .NET Framework 4.6.2 | 8.255 ns | 0.1651 ns | 0.0864 ns |  2.28 |    0.06 |
| LittleEndianByteIndexer_Slice_UInt64  | .NET Framework 4.6.2 | 5.430 ns | 0.1900 ns | 0.1777 ns |  1.50 |    0.07 |
| LittleEndianByteIndexer_Slice_Int64   | .NET Framework 4.6.2 | 5.527 ns | 0.1829 ns | 0.1711 ns |  1.53 |    0.06 |
| LittleEndianByteIndexer_Slice_UInt32  | .NET Framework 4.6.2 | 4.726 ns | 0.2399 ns | 0.2244 ns |  1.32 |    0.07 |
| LittleEndianByteIndexer_Slice_Int32   | .NET Framework 4.6.2 | 6.218 ns | 1.1161 ns | 0.8714 ns |  1.74 |    0.27 |
| LittleEndianByteIndexer_Slice_UInt16  | .NET Framework 4.6.2 | 4.773 ns | 0.7496 ns | 0.7012 ns |  1.24 |    0.10 |
| LittleEndianByteIndexer_Slice_Int16   | .NET Framework 4.6.2 | 4.269 ns | 0.1643 ns | 0.1457 ns |  1.19 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET Framework 4.6.2 | 5.978 ns | 0.3659 ns | 0.3422 ns |  1.68 |    0.11 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET Framework 4.6.2 | 8.771 ns | 0.4837 ns | 0.4524 ns |  2.41 |    0.09 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET Framework 4.6.2 | 5.403 ns | 0.1503 ns | 0.1255 ns |  1.50 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET Framework 4.6.2 | 4.960 ns | 0.2382 ns | 0.2228 ns |  1.40 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET Framework 4.6.2 | 4.472 ns | 0.2115 ns | 0.1978 ns |  1.24 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET Framework 4.6.2 | 4.081 ns | 0.5001 ns | 0.4678 ns |  1.12 |    0.13 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET Framework 4.6.2 | 4.197 ns | 0.2494 ns | 0.2211 ns |  1.15 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET Framework 4.6.2 | 3.156 ns | 0.1045 ns | 0.0816 ns |  0.88 |    0.02 |

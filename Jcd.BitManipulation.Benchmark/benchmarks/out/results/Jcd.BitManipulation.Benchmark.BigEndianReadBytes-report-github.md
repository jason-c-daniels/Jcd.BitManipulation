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
| Method                                | Runtime              | Mean      | Error     | StdDev    | Ratio | RatioSD |
|-------------------------------------- |--------------------- |----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double          | .NET 8.0             |  5.274 ns | 0.7837 ns | 0.7331 ns |  1.45 |    0.20 |
| BitConverter_GetBytes_Float           | .NET 8.0             |  4.192 ns | 0.1173 ns | 0.0776 ns |  1.15 |    0.05 |
| BitConverter_GetBytes_UInt64          | .NET 8.0             |  4.418 ns | 0.1473 ns | 0.1378 ns |  1.21 |    0.04 |
| BitConverter_GetBytes_Int64           | .NET 8.0             |  4.152 ns | 0.1218 ns | 0.1017 ns |  1.14 |    0.04 |
| BitConverter_GetBytes_UInt32          | .NET 8.0             |  4.193 ns | 0.1222 ns | 0.1083 ns |  1.15 |    0.05 |
| BitConverter_GetBytes_Int32           | .NET 8.0             |  4.459 ns | 0.1980 ns | 0.1852 ns |  1.22 |    0.06 |
| BitConverter_GetBytes_UInt16          | .NET 8.0             |  4.163 ns | 0.1674 ns | 0.1566 ns |  1.15 |    0.06 |
| BitConverter_GetBytes_Int16           | .NET 8.0             |  3.960 ns | 0.1884 ns | 0.1762 ns |  1.08 |    0.05 |
| BigEndianByteIndexer_Slice_Double     | .NET 8.0             |  3.565 ns | 0.1216 ns | 0.1078 ns |  0.98 |    0.04 |
| BigEndianByteIndexer_Slice_Float      | .NET 8.0             |  3.447 ns | 0.1055 ns | 0.0762 ns |  0.94 |    0.04 |
| BigEndianByteIndexer_Slice_UInt64     | .NET 8.0             |  3.654 ns | 0.1161 ns | 0.1029 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Int64      | .NET 8.0             |  3.700 ns | 0.1171 ns | 0.1096 ns |  1.01 |    0.03 |
| BigEndianByteIndexer_Slice_UInt32     | .NET 8.0             |  3.470 ns | 0.0981 ns | 0.0649 ns |  0.95 |    0.04 |
| BigEndianByteIndexer_Slice_Int32      | .NET 8.0             |  3.435 ns | 0.1074 ns | 0.0711 ns |  0.94 |    0.04 |
| BigEndianByteIndexer_Slice_UInt16     | .NET 8.0             |  3.333 ns | 0.1446 ns | 0.1207 ns |  0.91 |    0.04 |
| BigEndianByteIndexer_Slice_Int16      | .NET 8.0             |  3.221 ns | 0.1058 ns | 0.0990 ns |  0.88 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET 8.0             |  3.590 ns | 0.1096 ns | 0.0793 ns |  0.98 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET 8.0             |  3.532 ns | 0.0776 ns | 0.0406 ns |  0.96 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET 8.0             |  3.652 ns | 0.1379 ns | 0.1290 ns |  1.00 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET 8.0             |  4.979 ns | 0.1433 ns | 0.1271 ns |  1.36 |    0.06 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET 8.0             |  3.448 ns | 0.1058 ns | 0.0883 ns |  0.94 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET 8.0             |  4.023 ns | 0.1202 ns | 0.0869 ns |  1.10 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET 8.0             |  3.252 ns | 0.0501 ns | 0.0298 ns |  0.89 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET 8.0             |  3.437 ns | 0.0819 ns | 0.0487 ns |  0.94 |    0.04 |
| BitConverter_GetBytes_Double          | .NET Framework 4.6.2 | 25.087 ns | 0.5217 ns | 0.3451 ns |  6.85 |    0.27 |
| BitConverter_GetBytes_Float           | .NET Framework 4.6.2 | 23.475 ns | 0.4910 ns | 0.3248 ns |  6.41 |    0.23 |
| BitConverter_GetBytes_UInt64          | .NET Framework 4.6.2 | 25.098 ns | 0.4347 ns | 0.2587 ns |  6.85 |    0.23 |
| BitConverter_GetBytes_Int64           | .NET Framework 4.6.2 | 25.690 ns | 0.5562 ns | 0.5203 ns |  7.04 |    0.25 |
| BitConverter_GetBytes_UInt32          | .NET Framework 4.6.2 | 23.506 ns | 0.4769 ns | 0.2838 ns |  6.42 |    0.26 |
| BitConverter_GetBytes_Int32           | .NET Framework 4.6.2 | 23.901 ns | 0.4982 ns | 0.3295 ns |  6.53 |    0.17 |
| BitConverter_GetBytes_UInt16          | .NET Framework 4.6.2 | 22.685 ns | 0.5153 ns | 0.4568 ns |  6.21 |    0.20 |
| BitConverter_GetBytes_Int16           | .NET Framework 4.6.2 | 22.387 ns | 0.4788 ns | 0.4479 ns |  6.13 |    0.24 |
| BigEndianByteIndexer_Slice_Double     | .NET Framework 4.6.2 |  8.456 ns | 0.2696 ns | 0.2105 ns |  2.31 |    0.08 |
| BigEndianByteIndexer_Slice_Float      | .NET Framework 4.6.2 |  9.223 ns | 0.3414 ns | 0.3194 ns |  2.51 |    0.11 |
| BigEndianByteIndexer_Slice_UInt64     | .NET Framework 4.6.2 |  8.452 ns | 1.0982 ns | 1.0273 ns |  2.35 |    0.26 |
| BigEndianByteIndexer_Slice_Int64      | .NET Framework 4.6.2 |  8.976 ns | 0.6644 ns | 0.5890 ns |  2.46 |    0.17 |
| BigEndianByteIndexer_Slice_UInt32     | .NET Framework 4.6.2 |  5.075 ns | 0.2590 ns | 0.2423 ns |  1.39 |    0.08 |
| BigEndianByteIndexer_Slice_Int32      | .NET Framework 4.6.2 |  5.368 ns | 0.3863 ns | 0.3614 ns |  1.46 |    0.10 |
| BigEndianByteIndexer_Slice_UInt16     | .NET Framework 4.6.2 |  4.495 ns | 0.3348 ns | 0.3132 ns |  1.24 |    0.08 |
| BigEndianByteIndexer_Slice_Int16      | .NET Framework 4.6.2 |  4.493 ns | 0.4945 ns | 0.4625 ns |  1.24 |    0.14 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET Framework 4.6.2 |  8.976 ns | 0.5083 ns | 0.4506 ns |  2.46 |    0.14 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET Framework 4.6.2 |  9.368 ns | 0.3064 ns | 0.2866 ns |  2.57 |    0.12 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET Framework 4.6.2 |  8.428 ns | 0.2443 ns | 0.2285 ns |  2.30 |    0.08 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET Framework 4.6.2 |  5.114 ns | 0.1359 ns | 0.1205 ns |  1.40 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET Framework 4.6.2 |  5.988 ns | 0.5526 ns | 0.5169 ns |  1.64 |    0.16 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET Framework 4.6.2 |  3.623 ns | 0.1457 ns | 0.1363 ns |  1.00 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET Framework 4.6.2 |  4.868 ns | 0.2189 ns | 0.2048 ns |  1.33 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET Framework 4.6.2 |  3.009 ns | 0.1181 ns | 0.1047 ns |  0.82 |    0.03 |

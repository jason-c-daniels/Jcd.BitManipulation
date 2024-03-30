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
| Method                                | Runtime              | Mean     | Error     | StdDev    | Ratio | RatioSD |
|-------------------------------------- |--------------------- |---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double          | .NET 8.0             | 3.345 ns | 0.0722 ns | 0.0478 ns |  0.92 |    0.01 |
| BitConverter_GetBytes_Float           | .NET 8.0             | 3.343 ns | 0.0409 ns | 0.0270 ns |  0.91 |    0.01 |
| BitConverter_GetBytes_UInt64          | .NET 8.0             | 3.132 ns | 0.0727 ns | 0.0433 ns |  0.86 |    0.01 |
| BitConverter_GetBytes_Int64           | .NET 8.0             | 3.094 ns | 0.0489 ns | 0.0256 ns |  0.85 |    0.01 |
| BitConverter_GetBytes_UInt32          | .NET 8.0             | 3.035 ns | 0.0330 ns | 0.0218 ns |  0.83 |    0.01 |
| BitConverter_GetBytes_Int32           | .NET 8.0             | 3.012 ns | 0.0452 ns | 0.0299 ns |  0.82 |    0.01 |
| BitConverter_GetBytes_UInt16          | .NET 8.0             | 3.143 ns | 0.0798 ns | 0.0528 ns |  0.86 |    0.01 |
| BitConverter_GetBytes_Int16           | .NET 8.0             | 3.360 ns | 0.2743 ns | 0.2566 ns |  0.96 |    0.04 |
| LittleEndianByteIndexer_Slice_Double  | .NET 8.0             | 3.513 ns | 0.0865 ns | 0.0572 ns |  0.96 |    0.01 |
| LittleEndianByteIndexer_Slice_Float   | .NET 8.0             | 3.271 ns | 0.0322 ns | 0.0191 ns |  0.89 |    0.01 |
| LittleEndianByteIndexer_Slice_UInt64  | .NET 8.0             | 3.656 ns | 0.0580 ns | 0.0383 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Int64   | .NET 8.0             | 3.638 ns | 0.0492 ns | 0.0325 ns |  1.00 |    0.01 |
| LittleEndianByteIndexer_Slice_UInt32  | .NET 8.0             | 3.355 ns | 0.0618 ns | 0.0368 ns |  0.92 |    0.01 |
| LittleEndianByteIndexer_Slice_Int32   | .NET 8.0             | 3.371 ns | 0.0417 ns | 0.0276 ns |  0.92 |    0.01 |
| LittleEndianByteIndexer_Slice_UInt16  | .NET 8.0             | 3.229 ns | 0.0336 ns | 0.0176 ns |  0.88 |    0.01 |
| LittleEndianByteIndexer_Slice_Int16   | .NET 8.0             | 3.342 ns | 0.1066 ns | 0.0705 ns |  0.91 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET 8.0             | 3.631 ns | 0.0630 ns | 0.0375 ns |  0.99 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET 8.0             | 3.318 ns | 0.2419 ns | 0.2263 ns |  0.93 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET 8.0             | 3.521 ns | 0.0868 ns | 0.0574 ns |  0.96 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET 8.0             | 4.436 ns | 0.0245 ns | 0.0162 ns |  1.21 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET 8.0             | 3.368 ns | 0.1184 ns | 0.1050 ns |  0.92 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET 8.0             | 3.795 ns | 0.0292 ns | 0.0174 ns |  1.04 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET 8.0             | 3.185 ns | 0.0296 ns | 0.0176 ns |  0.87 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET 8.0             | 3.329 ns | 0.1008 ns | 0.0600 ns |  0.91 |    0.02 |
| BitConverter_GetBytes_Double          | .NET Framework 4.6.2 | 4.184 ns | 0.0659 ns | 0.0392 ns |  1.14 |    0.01 |
| BitConverter_GetBytes_Float           | .NET Framework 4.6.2 | 3.665 ns | 0.0323 ns | 0.0192 ns |  1.00 |    0.01 |
| BitConverter_GetBytes_UInt64          | .NET Framework 4.6.2 | 4.065 ns | 0.0399 ns | 0.0264 ns |  1.11 |    0.01 |
| BitConverter_GetBytes_Int64           | .NET Framework 4.6.2 | 4.123 ns | 0.0710 ns | 0.0470 ns |  1.13 |    0.02 |
| BitConverter_GetBytes_UInt32          | .NET Framework 4.6.2 | 3.637 ns | 0.0239 ns | 0.0158 ns |  0.99 |    0.01 |
| BitConverter_GetBytes_Int32           | .NET Framework 4.6.2 | 3.660 ns | 0.0925 ns | 0.0612 ns |  1.00 |    0.02 |
| BitConverter_GetBytes_UInt16          | .NET Framework 4.6.2 | 3.727 ns | 0.0291 ns | 0.0173 ns |  1.02 |    0.01 |
| BitConverter_GetBytes_Int16           | .NET Framework 4.6.2 | 3.739 ns | 0.0334 ns | 0.0221 ns |  1.02 |    0.01 |
| LittleEndianByteIndexer_Slice_Double  | .NET Framework 4.6.2 | 5.588 ns | 0.0759 ns | 0.0502 ns |  1.53 |    0.02 |
| LittleEndianByteIndexer_Slice_Float   | .NET Framework 4.6.2 | 8.278 ns | 0.1340 ns | 0.0886 ns |  2.26 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt64  | .NET Framework 4.6.2 | 5.540 ns | 0.2102 ns | 0.1966 ns |  1.49 |    0.04 |
| LittleEndianByteIndexer_Slice_Int64   | .NET Framework 4.6.2 | 5.359 ns | 0.0272 ns | 0.0142 ns |  1.47 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt32  | .NET Framework 4.6.2 | 4.459 ns | 0.0270 ns | 0.0141 ns |  1.22 |    0.01 |
| LittleEndianByteIndexer_Slice_Int32   | .NET Framework 4.6.2 | 4.545 ns | 0.0587 ns | 0.0349 ns |  1.24 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt16  | .NET Framework 4.6.2 | 4.232 ns | 0.0637 ns | 0.0422 ns |  1.16 |    0.02 |
| LittleEndianByteIndexer_Slice_Int16   | .NET Framework 4.6.2 | 4.211 ns | 0.0568 ns | 0.0376 ns |  1.15 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET Framework 4.6.2 | 5.574 ns | 0.0601 ns | 0.0358 ns |  1.52 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET Framework 4.6.2 | 8.323 ns | 0.0822 ns | 0.0489 ns |  2.28 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET Framework 4.6.2 | 5.388 ns | 0.0765 ns | 0.0455 ns |  1.47 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET Framework 4.6.2 | 4.725 ns | 0.0319 ns | 0.0211 ns |  1.29 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET Framework 4.6.2 | 4.344 ns | 0.0589 ns | 0.0390 ns |  1.19 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET Framework 4.6.2 | 3.656 ns | 0.0434 ns | 0.0287 ns |  1.00 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET Framework 4.6.2 | 3.901 ns | 0.0540 ns | 0.0357 ns |  1.07 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET Framework 4.6.2 | 3.256 ns | 0.0702 ns | 0.0464 ns |  0.89 |    0.02 |

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-LRLIBL : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-MDTRPR : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                                | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|---------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double          | .NET 8.0             | 3.359 ns | 0.0618 ns | 0.0409 ns |  0.91 |    0.01 |
| BitConverter_GetBytes_Float           | .NET 8.0             | 3.379 ns | 0.0956 ns | 0.0632 ns |  0.92 |    0.02 |
| BitConverter_GetBytes_UInt64          | .NET 8.0             | 3.052 ns | 0.0481 ns | 0.0286 ns |  0.83 |    0.01 |
| BitConverter_GetBytes_Int64           | .NET 8.0             | 3.163 ns | 0.0416 ns | 0.0217 ns |  0.86 |    0.01 |
| BitConverter_GetBytes_UInt32          | .NET 8.0             | 3.058 ns | 0.0155 ns | 0.0102 ns |  0.83 |    0.01 |
| BitConverter_GetBytes_Int32           | .NET 8.0             | 3.151 ns | 0.0547 ns | 0.0362 ns |  0.86 |    0.02 |
| BitConverter_GetBytes_UInt16          | .NET 8.0             | 3.164 ns | 0.0650 ns | 0.0340 ns |  0.86 |    0.01 |
| BitConverter_GetBytes_Int16           | .NET 8.0             | 3.091 ns | 0.0417 ns | 0.0276 ns |  0.84 |    0.01 |
| LittleEndianByteIndexer_Slice_Double  | .NET 8.0             | 3.568 ns | 0.0551 ns | 0.0364 ns |  0.97 |    0.02 |
| LittleEndianByteIndexer_Slice_Float   | .NET 8.0             | 3.304 ns | 0.0875 ns | 0.0521 ns |  0.90 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt64  | .NET 8.0             | 3.683 ns | 0.0853 ns | 0.0508 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Int64   | .NET 8.0             | 3.678 ns | 0.0925 ns | 0.0612 ns |  1.00 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt32  | .NET 8.0             | 3.586 ns | 0.1690 ns | 0.1581 ns |  0.97 |    0.05 |
| LittleEndianByteIndexer_Slice_Int32   | .NET 8.0             | 3.382 ns | 0.0429 ns | 0.0284 ns |  0.92 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt16  | .NET 8.0             | 3.348 ns | 0.0618 ns | 0.0409 ns |  0.91 |    0.01 |
| LittleEndianByteIndexer_Slice_Int16   | .NET 8.0             | 3.281 ns | 0.0855 ns | 0.0566 ns |  0.89 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET 8.0             | 3.651 ns | 0.1090 ns | 0.0721 ns |  0.99 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET 8.0             | 3.373 ns | 0.0613 ns | 0.0406 ns |  0.92 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET 8.0             | 3.573 ns | 0.0703 ns | 0.0465 ns |  0.97 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET 8.0             | 4.532 ns | 0.1058 ns | 0.0630 ns |  1.23 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET 8.0             | 3.307 ns | 0.0631 ns | 0.0376 ns |  0.90 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET 8.0             | 4.016 ns | 0.0661 ns | 0.0346 ns |  1.09 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET 8.0             | 3.394 ns | 0.1591 ns | 0.1488 ns |  0.91 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET 8.0             | 3.476 ns | 0.2009 ns | 0.1781 ns |  0.94 |    0.06 |
| BitConverter_GetBytes_Double          | .NET Framework 4.6.2 | 4.426 ns | 0.1467 ns | 0.1301 ns |  1.21 |    0.04 |
| BitConverter_GetBytes_Float           | .NET Framework 4.6.2 | 3.951 ns | 0.3625 ns | 0.3027 ns |  1.03 |    0.05 |
| BitConverter_GetBytes_UInt64          | .NET Framework 4.6.2 | 4.201 ns | 0.0723 ns | 0.0478 ns |  1.14 |    0.02 |
| BitConverter_GetBytes_Int64           | .NET Framework 4.6.2 | 4.284 ns | 0.1595 ns | 0.1414 ns |  1.17 |    0.04 |
| BitConverter_GetBytes_UInt32          | .NET Framework 4.6.2 | 3.694 ns | 0.0609 ns | 0.0403 ns |  1.00 |    0.01 |
| BitConverter_GetBytes_Int32           | .NET Framework 4.6.2 | 3.720 ns | 0.0641 ns | 0.0424 ns |  1.01 |    0.02 |
| BitConverter_GetBytes_UInt16          | .NET Framework 4.6.2 | 3.762 ns | 0.0503 ns | 0.0299 ns |  1.02 |    0.02 |
| BitConverter_GetBytes_Int16           | .NET Framework 4.6.2 | 3.722 ns | 0.0572 ns | 0.0340 ns |  1.01 |    0.01 |
| LittleEndianByteIndexer_Slice_Double  | .NET Framework 4.6.2 | 5.653 ns | 0.0599 ns | 0.0356 ns |  1.54 |    0.02 |
| LittleEndianByteIndexer_Slice_Float   | .NET Framework 4.6.2 | 8.558 ns | 0.1736 ns | 0.1033 ns |  2.32 |    0.03 |
| LittleEndianByteIndexer_Slice_UInt64  | .NET Framework 4.6.2 | 5.600 ns | 0.0666 ns | 0.0396 ns |  1.52 |    0.02 |
| LittleEndianByteIndexer_Slice_Int64   | .NET Framework 4.6.2 | 6.037 ns | 0.2785 ns | 0.2605 ns |  1.63 |    0.08 |
| LittleEndianByteIndexer_Slice_UInt32  | .NET Framework 4.6.2 | 4.522 ns | 0.0784 ns | 0.0467 ns |  1.23 |    0.02 |
| LittleEndianByteIndexer_Slice_Int32   | .NET Framework 4.6.2 | 4.572 ns | 0.0586 ns | 0.0387 ns |  1.24 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt16  | .NET Framework 4.6.2 | 4.183 ns | 0.0640 ns | 0.0423 ns |  1.14 |    0.02 |
| LittleEndianByteIndexer_Slice_Int16   | .NET Framework 4.6.2 | 4.381 ns | 0.1190 ns | 0.0787 ns |  1.19 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET Framework 4.6.2 | 5.554 ns | 0.0817 ns | 0.0540 ns |  1.51 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET Framework 4.6.2 | 8.158 ns | 0.1691 ns | 0.1119 ns |  2.22 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET Framework 4.6.2 | 5.479 ns | 0.0559 ns | 0.0333 ns |  1.49 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET Framework 4.6.2 | 4.310 ns | 0.0418 ns | 0.0277 ns |  1.17 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET Framework 4.6.2 | 4.496 ns | 0.0741 ns | 0.0441 ns |  1.22 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET Framework 4.6.2 | 3.295 ns | 0.0789 ns | 0.0522 ns |  0.90 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET Framework 4.6.2 | 4.140 ns | 0.0114 ns | 0.0068 ns |  1.12 |    0.01 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET Framework 4.6.2 | 2.807 ns | 0.0252 ns | 0.0167 ns |  0.76 |    0.01 |

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ICMWHD : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-OXTARK : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                               | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double         | .NET 8.0             | 3.335 ns | 0.1005 ns | 0.0665 ns |  0.94 |    0.21 |
| BitConverter_GetBytes_Float          | .NET 8.0             | 3.190 ns | 0.1096 ns | 0.1025 ns |  0.93 |    0.19 |
| BitConverter_GetBytes_UInt64         | .NET 8.0             | 3.024 ns | 0.1009 ns | 0.0730 ns |  0.86 |    0.18 |
| BitConverter_GetBytes_Int64          | .NET 8.0             | 3.000 ns | 0.1024 ns | 0.0908 ns |  0.90 |    0.19 |
| BitConverter_GetBytes_UInt32         | .NET 8.0             | 2.971 ns | 0.1052 ns | 0.0984 ns |  0.87 |    0.17 |
| BitConverter_GetBytes_Int32          | .NET 8.0             | 3.262 ns | 0.2045 ns | 0.1913 ns |  0.96 |    0.24 |
| BitConverter_GetBytes_UInt16         | .NET 8.0             | 3.310 ns | 0.5053 ns | 0.4727 ns |  0.97 |    0.26 |
| BitConverter_GetBytes_Int16          | .NET 8.0             | 3.561 ns | 0.8374 ns | 0.7833 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Double | .NET 8.0             | 3.373 ns | 0.5394 ns | 0.4782 ns |  1.02 |    0.29 |
| LittleEndianByteIndexer_Slice_Float  | .NET 8.0             | 3.885 ns | 0.8428 ns | 0.7883 ns |  1.14 |    0.34 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET 8.0             | 4.002 ns | 0.8558 ns | 0.8006 ns |  1.15 |    0.25 |
| LittleEndianByteIndexer_Slice_Int64  | .NET 8.0             | 3.202 ns | 0.1776 ns | 0.1483 ns |  0.95 |    0.21 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET 8.0             | 3.635 ns | 0.6234 ns | 0.5831 ns |  1.07 |    0.30 |
| LittleEndianByteIndexer_Slice_Int32  | .NET 8.0             | 3.109 ns | 0.0820 ns | 0.0488 ns |  0.90 |    0.19 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET 8.0             | 3.755 ns | 0.1750 ns | 0.1551 ns |  1.12 |    0.23 |
| LittleEndianByteIndexer_Slice_Int16  | .NET 8.0             | 3.816 ns | 0.2426 ns | 0.2269 ns |  1.11 |    0.21 |
| ExtensionMethod_ReadBytes_Double     | .NET 8.0             | 3.786 ns | 0.8232 ns | 0.7700 ns |  1.13 |    0.40 |
| ExtensionMethod_ReadBytes_Float      | .NET 8.0             | 3.449 ns | 0.2357 ns | 0.2205 ns |  1.02 |    0.24 |
| ExtensionMethod_ReadBytes_UInt64     | .NET 8.0             | 3.513 ns | 0.8144 ns | 0.7618 ns |  1.04 |    0.33 |
| ExtensionMethod_ReadBytes_Int64      | .NET 8.0             | 4.125 ns | 0.1559 ns | 0.1458 ns |  1.21 |    0.27 |
| ExtensionMethod_ReadBytes_UInt32     | .NET 8.0             | 3.498 ns | 0.1118 ns | 0.0933 ns |  1.03 |    0.22 |
| ExtensionMethod_ReadBytes_Int32      | .NET 8.0             | 3.552 ns | 0.1256 ns | 0.1175 ns |  1.04 |    0.22 |
| ExtensionMethod_ReadBytes_UInt16     | .NET 8.0             | 3.512 ns | 0.1594 ns | 0.1331 ns |  1.03 |    0.20 |
| ExtensionMethod_ReadBytes_Int16      | .NET 8.0             | 3.278 ns | 0.1558 ns | 0.1457 ns |  0.96 |    0.19 |
| BitConverter_GetBytes_Double         | .NET Framework 4.6.2 | 4.190 ns | 0.0693 ns | 0.0412 ns |  1.21 |    0.25 |
| BitConverter_GetBytes_Float          | .NET Framework 4.6.2 | 3.748 ns | 0.1407 ns | 0.1247 ns |  1.13 |    0.25 |
| BitConverter_GetBytes_UInt64         | .NET Framework 4.6.2 | 4.331 ns | 0.1318 ns | 0.1029 ns |  1.25 |    0.26 |
| BitConverter_GetBytes_Int64          | .NET Framework 4.6.2 | 4.210 ns | 0.2074 ns | 0.1940 ns |  1.23 |    0.26 |
| BitConverter_GetBytes_UInt32         | .NET Framework 4.6.2 | 3.843 ns | 0.1855 ns | 0.1736 ns |  1.13 |    0.24 |
| BitConverter_GetBytes_Int32          | .NET Framework 4.6.2 | 3.859 ns | 0.1381 ns | 0.1292 ns |  1.13 |    0.23 |
| BitConverter_GetBytes_UInt16         | .NET Framework 4.6.2 | 3.913 ns | 0.1065 ns | 0.0944 ns |  1.17 |    0.23 |
| BitConverter_GetBytes_Int16          | .NET Framework 4.6.2 | 4.026 ns | 0.1250 ns | 0.1109 ns |  1.21 |    0.25 |
| LittleEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 | 6.473 ns | 0.1741 ns | 0.1629 ns |  1.90 |    0.39 |
| LittleEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 | 8.043 ns | 0.3991 ns | 0.3733 ns |  2.36 |    0.49 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 | 6.572 ns | 0.1658 ns | 0.1294 ns |  1.89 |    0.35 |
| LittleEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 | 6.414 ns | 0.0564 ns | 0.0336 ns |  1.86 |    0.38 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 | 3.828 ns | 0.0892 ns | 0.0531 ns |  1.11 |    0.23 |
| LittleEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 | 3.877 ns | 0.1118 ns | 0.0809 ns |  1.10 |    0.22 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 | 3.342 ns | 0.1020 ns | 0.0675 ns |  0.95 |    0.22 |
| LittleEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 | 3.312 ns | 0.1092 ns | 0.1021 ns |  0.97 |    0.19 |
| ExtensionMethod_ReadBytes_Double     | .NET Framework 4.6.2 | 6.310 ns | 0.2328 ns | 0.2063 ns |  1.89 |    0.38 |
| ExtensionMethod_ReadBytes_Float      | .NET Framework 4.6.2 | 8.182 ns | 0.3378 ns | 0.3160 ns |  2.39 |    0.46 |
| ExtensionMethod_ReadBytes_UInt64     | .NET Framework 4.6.2 | 6.204 ns | 0.2309 ns | 0.2160 ns |  1.82 |    0.38 |
| ExtensionMethod_ReadBytes_Int64      | .NET Framework 4.6.2 | 4.248 ns | 0.1004 ns | 0.0664 ns |  1.20 |    0.25 |
| ExtensionMethod_ReadBytes_UInt32     | .NET Framework 4.6.2 | 3.884 ns | 0.1171 ns | 0.0775 ns |  1.10 |    0.23 |
| ExtensionMethod_ReadBytes_Int32      | .NET Framework 4.6.2 | 2.591 ns | 0.0432 ns | 0.0226 ns |  0.77 |    0.15 |
| ExtensionMethod_ReadBytes_UInt16     | .NET Framework 4.6.2 | 3.212 ns | 0.0964 ns | 0.0574 ns |  0.93 |    0.19 |
| ExtensionMethod_ReadBytes_Int16      | .NET Framework 4.6.2 | 2.192 ns | 0.1055 ns | 0.0987 ns |  0.64 |    0.14 |

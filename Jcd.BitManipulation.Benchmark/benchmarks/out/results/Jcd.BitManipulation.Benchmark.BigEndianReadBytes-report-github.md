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

| Method                            | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|-----------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double      | .NET 8.0             |  7.646 ns | 1.4473 ns | 1.2086 ns |  1.91 |    0.29 |
| BitConverter_GetBytes_Float       | .NET 8.0             |  4.397 ns | 0.1770 ns | 0.1656 ns |  1.05 |    0.04 |
| BitConverter_GetBytes_UInt64      | .NET 8.0             |  4.216 ns | 0.1662 ns | 0.1554 ns |  1.03 |    0.04 |
| BitConverter_GetBytes_Int64       | .NET 8.0             |  4.433 ns | 0.2028 ns | 0.1897 ns |  1.09 |    0.03 |
| BitConverter_GetBytes_UInt32      | .NET 8.0             |  4.068 ns | 0.1275 ns | 0.1130 ns |  0.99 |    0.03 |
| BitConverter_GetBytes_Int32       | .NET 8.0             |  4.376 ns | 0.1211 ns | 0.0801 ns |  1.06 |    0.02 |
| BitConverter_GetBytes_UInt16      | .NET 8.0             |  4.104 ns | 0.1179 ns | 0.1045 ns |  1.00 |    0.02 |
| BitConverter_GetBytes_Int16       | .NET 8.0             |  4.125 ns | 0.0849 ns | 0.0561 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Double | .NET 8.0             |  3.626 ns | 0.1099 ns | 0.0974 ns |  0.89 |    0.03 |
| BigEndianByteIndexer_Slice_Float  | .NET 8.0             |  3.606 ns | 0.1146 ns | 0.0758 ns |  0.87 |    0.02 |
| BigEndianByteIndexer_Slice_UInt64 | .NET 8.0             |  3.649 ns | 0.1120 ns | 0.1048 ns |  0.89 |    0.04 |
| BigEndianByteIndexer_Slice_Int64  | .NET 8.0             |  3.652 ns | 0.1101 ns | 0.0920 ns |  0.89 |    0.03 |
| BigEndianByteIndexer_Slice_UInt32 | .NET 8.0             |  3.579 ns | 0.0607 ns | 0.0318 ns |  0.87 |    0.02 |
| BigEndianByteIndexer_Slice_Int32  | .NET 8.0             |  3.618 ns | 0.1109 ns | 0.0866 ns |  0.88 |    0.03 |
| BigEndianByteIndexer_Slice_UInt16 | .NET 8.0             |  3.435 ns | 0.1078 ns | 0.1008 ns |  0.83 |    0.04 |
| BigEndianByteIndexer_Slice_Int16  | .NET 8.0             |  3.442 ns | 0.1153 ns | 0.1078 ns |  0.83 |    0.02 |
| ExtensionMethod_ReadBytes_Double  | .NET 8.0             |  3.705 ns | 0.1449 ns | 0.1355 ns |  0.91 |    0.03 |
| ExtensionMethod_ReadBytes_Float   | .NET 8.0             |  3.383 ns | 0.0869 ns | 0.0628 ns |  0.82 |    0.02 |
| ExtensionMethod_ReadBytes_UInt64  | .NET 8.0             |  3.705 ns | 0.1107 ns | 0.0924 ns |  0.90 |    0.03 |
| ExtensionMethod_ReadBytes_Int64   | .NET 8.0             |  4.446 ns | 0.1341 ns | 0.0970 ns |  1.08 |    0.03 |
| ExtensionMethod_ReadBytes_UInt32  | .NET 8.0             |  3.564 ns | 0.1166 ns | 0.1091 ns |  0.86 |    0.03 |
| ExtensionMethod_ReadBytes_Int32   | .NET 8.0             |  4.098 ns | 0.1424 ns | 0.1332 ns |  0.99 |    0.04 |
| ExtensionMethod_ReadBytes_UInt16  | .NET 8.0             |  3.388 ns | 0.0970 ns | 0.0577 ns |  0.82 |    0.02 |
| ExtensionMethod_ReadBytes_Int16   | .NET 8.0             |  3.462 ns | 0.1299 ns | 0.1151 ns |  0.84 |    0.03 |
| BitConverter_GetBytes_Double      | .NET Framework 4.6.2 | 25.781 ns | 0.5144 ns | 0.4296 ns |  6.23 |    0.13 |
| BitConverter_GetBytes_Float       | .NET Framework 4.6.2 | 24.493 ns | 0.7949 ns | 0.7435 ns |  5.97 |    0.18 |
| BitConverter_GetBytes_UInt64      | .NET Framework 4.6.2 | 25.213 ns | 0.4334 ns | 0.2579 ns |  6.11 |    0.08 |
| BitConverter_GetBytes_Int64       | .NET Framework 4.6.2 | 25.459 ns | 0.3594 ns | 0.1880 ns |  6.17 |    0.13 |
| BitConverter_GetBytes_UInt32      | .NET Framework 4.6.2 | 23.565 ns | 0.5133 ns | 0.3712 ns |  5.72 |    0.13 |
| BitConverter_GetBytes_Int32       | .NET Framework 4.6.2 | 23.800 ns | 0.4814 ns | 0.4503 ns |  5.78 |    0.13 |
| BitConverter_GetBytes_UInt16      | .NET Framework 4.6.2 | 22.341 ns | 0.4050 ns | 0.2679 ns |  5.42 |    0.08 |
| BitConverter_GetBytes_Int16       | .NET Framework 4.6.2 | 22.796 ns | 0.5360 ns | 0.4751 ns |  5.52 |    0.11 |
| BigEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 |  8.269 ns | 0.2052 ns | 0.1714 ns |  1.99 |    0.04 |
| BigEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 |  9.010 ns | 0.2060 ns | 0.1608 ns |  2.18 |    0.07 |
| BigEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 |  8.135 ns | 0.2098 ns | 0.1962 ns |  1.98 |    0.06 |
| BigEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 |  8.028 ns | 0.1961 ns | 0.1297 ns |  1.95 |    0.03 |
| BigEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 |  4.899 ns | 0.1219 ns | 0.0806 ns |  1.19 |    0.02 |
| BigEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 |  5.349 ns | 0.3843 ns | 0.3595 ns |  1.28 |    0.11 |
| BigEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 |  4.232 ns | 0.1999 ns | 0.1870 ns |  1.03 |    0.03 |
| BigEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 |  3.979 ns | 0.0917 ns | 0.0546 ns |  0.96 |    0.02 |
| ExtensionMethod_ReadBytes_Double  | .NET Framework 4.6.2 |  8.607 ns | 0.2829 ns | 0.2507 ns |  2.08 |    0.04 |
| ExtensionMethod_ReadBytes_Float   | .NET Framework 4.6.2 |  9.331 ns | 0.3913 ns | 0.3660 ns |  2.24 |    0.08 |
| ExtensionMethod_ReadBytes_UInt64  | .NET Framework 4.6.2 |  8.584 ns | 0.5473 ns | 0.5119 ns |  2.10 |    0.13 |
| ExtensionMethod_ReadBytes_Int64   | .NET Framework 4.6.2 |  4.667 ns | 0.1002 ns | 0.0597 ns |  1.13 |    0.02 |
| ExtensionMethod_ReadBytes_UInt32  | .NET Framework 4.6.2 |  5.367 ns | 0.2926 ns | 0.2737 ns |  1.31 |    0.07 |
| ExtensionMethod_ReadBytes_Int32   | .NET Framework 4.6.2 |  3.453 ns | 0.0991 ns | 0.0656 ns |  0.84 |    0.02 |
| ExtensionMethod_ReadBytes_UInt16  | .NET Framework 4.6.2 |  4.377 ns | 0.1193 ns | 0.0863 ns |  1.06 |    0.03 |
| ExtensionMethod_ReadBytes_Int16   | .NET Framework 4.6.2 |  2.912 ns | 0.0630 ns | 0.0416 ns |  0.71 |    0.01 |

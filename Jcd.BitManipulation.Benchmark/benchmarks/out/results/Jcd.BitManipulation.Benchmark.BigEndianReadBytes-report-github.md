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

| Method                            | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|-----------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double      | .NET 8.0             |  4.396 ns | 0.3359 ns | 0.2978 ns |  1.12 |    0.10 |
| BitConverter_GetBytes_Float       | .NET 8.0             |  4.390 ns | 0.1695 ns | 0.1503 ns |  1.11 |    0.06 |
| BitConverter_GetBytes_UInt64      | .NET 8.0             |  4.285 ns | 0.1203 ns | 0.1005 ns |  1.09 |    0.04 |
| BitConverter_GetBytes_Int64       | .NET 8.0             |  4.308 ns | 0.1439 ns | 0.1276 ns |  1.09 |    0.06 |
| BitConverter_GetBytes_UInt32      | .NET 8.0             |  4.277 ns | 0.1439 ns | 0.1276 ns |  1.09 |    0.07 |
| BitConverter_GetBytes_Int32       | .NET 8.0             |  4.338 ns | 0.1720 ns | 0.1609 ns |  1.10 |    0.07 |
| BitConverter_GetBytes_UInt16      | .NET 8.0             |  3.966 ns | 0.1182 ns | 0.0923 ns |  1.01 |    0.04 |
| BitConverter_GetBytes_Int16       | .NET 8.0             |  3.955 ns | 0.1665 ns | 0.1557 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Double | .NET 8.0             |  3.641 ns | 0.1429 ns | 0.1337 ns |  0.92 |    0.05 |
| BigEndianByteIndexer_Slice_Float  | .NET 8.0             |  3.550 ns | 0.1786 ns | 0.1671 ns |  0.90 |    0.05 |
| BigEndianByteIndexer_Slice_UInt64 | .NET 8.0             |  3.592 ns | 0.1417 ns | 0.1256 ns |  0.91 |    0.03 |
| BigEndianByteIndexer_Slice_Int64  | .NET 8.0             |  3.577 ns | 0.1855 ns | 0.1735 ns |  0.91 |    0.07 |
| BigEndianByteIndexer_Slice_UInt32 | .NET 8.0             |  3.628 ns | 0.1341 ns | 0.1254 ns |  0.92 |    0.04 |
| BigEndianByteIndexer_Slice_Int32  | .NET 8.0             |  3.603 ns | 0.1712 ns | 0.1601 ns |  0.91 |    0.06 |
| BigEndianByteIndexer_Slice_UInt16 | .NET 8.0             |  3.520 ns | 0.2021 ns | 0.1890 ns |  0.89 |    0.07 |
| BigEndianByteIndexer_Slice_Int16  | .NET 8.0             |  3.530 ns | 0.1089 ns | 0.0720 ns |  0.90 |    0.05 |
| ExtensionMethod_ReadBytes_Double  | .NET 8.0             |  3.652 ns | 0.1750 ns | 0.1637 ns |  0.92 |    0.05 |
| ExtensionMethod_ReadBytes_Float   | .NET 8.0             |  4.218 ns | 0.3720 ns | 0.3480 ns |  1.07 |    0.08 |
| ExtensionMethod_ReadBytes_UInt64  | .NET 8.0             |  3.884 ns | 0.1131 ns | 0.0748 ns |  0.99 |    0.04 |
| ExtensionMethod_ReadBytes_Int64   | .NET 8.0             |  4.668 ns | 0.1524 ns | 0.1425 ns |  1.18 |    0.05 |
| ExtensionMethod_ReadBytes_UInt32  | .NET 8.0             |  3.527 ns | 0.1109 ns | 0.0983 ns |  0.90 |    0.05 |
| ExtensionMethod_ReadBytes_Int32   | .NET 8.0             |  3.768 ns | 0.3110 ns | 0.2909 ns |  0.95 |    0.08 |
| ExtensionMethod_ReadBytes_UInt16  | .NET 8.0             |  3.835 ns | 0.8089 ns | 0.7566 ns |  0.97 |    0.19 |
| ExtensionMethod_ReadBytes_Int16   | .NET 8.0             |  3.247 ns | 0.1803 ns | 0.1506 ns |  0.83 |    0.05 |
| BitConverter_GetBytes_Double      | .NET Framework 4.6.2 | 26.219 ns | 1.1748 ns | 1.0989 ns |  6.64 |    0.39 |
| BitConverter_GetBytes_Float       | .NET Framework 4.6.2 | 24.063 ns | 0.5259 ns | 0.4919 ns |  6.10 |    0.32 |
| BitConverter_GetBytes_UInt64      | .NET Framework 4.6.2 | 24.880 ns | 0.5091 ns | 0.3974 ns |  6.36 |    0.27 |
| BitConverter_GetBytes_Int64       | .NET Framework 4.6.2 | 25.337 ns | 0.4003 ns | 0.2382 ns |  6.47 |    0.29 |
| BitConverter_GetBytes_UInt32      | .NET Framework 4.6.2 | 23.803 ns | 0.4034 ns | 0.2668 ns |  6.08 |    0.21 |
| BitConverter_GetBytes_Int32       | .NET Framework 4.6.2 | 23.905 ns | 0.2542 ns | 0.1513 ns |  6.11 |    0.27 |
| BitConverter_GetBytes_UInt16      | .NET Framework 4.6.2 | 22.638 ns | 0.5209 ns | 0.4617 ns |  5.75 |    0.28 |
| BitConverter_GetBytes_Int16       | .NET Framework 4.6.2 | 22.710 ns | 0.6701 ns | 0.6268 ns |  5.75 |    0.26 |
| BigEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 |  8.590 ns | 0.2940 ns | 0.2750 ns |  2.18 |    0.13 |
| BigEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 |  9.164 ns | 0.3360 ns | 0.2979 ns |  2.33 |    0.11 |
| BigEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 |  8.072 ns | 0.2516 ns | 0.2353 ns |  2.04 |    0.11 |
| BigEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 |  8.030 ns | 0.1587 ns | 0.1050 ns |  2.05 |    0.09 |
| BigEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 |  4.980 ns | 0.1211 ns | 0.0720 ns |  1.27 |    0.06 |
| BigEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 |  5.034 ns | 0.1377 ns | 0.1288 ns |  1.28 |    0.08 |
| BigEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 |  4.084 ns | 0.0726 ns | 0.0432 ns |  1.04 |    0.04 |
| BigEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 |  4.066 ns | 0.0954 ns | 0.0631 ns |  1.04 |    0.05 |
| ExtensionMethod_ReadBytes_Double  | .NET Framework 4.6.2 |  8.657 ns | 0.2147 ns | 0.1420 ns |  2.21 |    0.11 |
| ExtensionMethod_ReadBytes_Float   | .NET Framework 4.6.2 |  9.341 ns | 0.3486 ns | 0.3261 ns |  2.37 |    0.13 |
| ExtensionMethod_ReadBytes_UInt64  | .NET Framework 4.6.2 |  8.226 ns | 0.2257 ns | 0.2001 ns |  2.09 |    0.11 |
| ExtensionMethod_ReadBytes_Int64   | .NET Framework 4.6.2 |  4.688 ns | 0.1400 ns | 0.1309 ns |  1.19 |    0.05 |
| ExtensionMethod_ReadBytes_UInt32  | .NET Framework 4.6.2 |  5.236 ns | 0.1384 ns | 0.1294 ns |  1.33 |    0.06 |
| ExtensionMethod_ReadBytes_Int32   | .NET Framework 4.6.2 |  3.445 ns | 0.0625 ns | 0.0372 ns |  0.88 |    0.03 |
| ExtensionMethod_ReadBytes_UInt16  | .NET Framework 4.6.2 |  4.306 ns | 0.1116 ns | 0.0738 ns |  1.10 |    0.04 |
| ExtensionMethod_ReadBytes_Int16   | .NET Framework 4.6.2 |  2.980 ns | 0.0710 ns | 0.0423 ns |  0.76 |    0.03 |

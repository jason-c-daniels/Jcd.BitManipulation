```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-BDWZRX : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-WYRMBM : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                               | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double         | .NET 8.0             | 3.179 ns | 0.0660 ns | 0.0393 ns |  1.01 |    0.01 |
| BitConverter_GetBytes_Float          | .NET 8.0             | 3.151 ns | 0.0748 ns | 0.0495 ns |  1.00 |    0.02 |
| BitConverter_GetBytes_UInt64         | .NET 8.0             | 3.178 ns | 0.0792 ns | 0.0472 ns |  1.01 |    0.01 |
| BitConverter_GetBytes_Int64          | .NET 8.0             | 3.194 ns | 0.0862 ns | 0.0513 ns |  1.01 |    0.01 |
| BitConverter_GetBytes_UInt32         | .NET 8.0             | 3.133 ns | 0.0622 ns | 0.0412 ns |  0.99 |    0.01 |
| BitConverter_GetBytes_Int32          | .NET 8.0             | 3.155 ns | 0.0571 ns | 0.0378 ns |  1.00 |    0.01 |
| BitConverter_GetBytes_UInt16         | .NET 8.0             | 3.162 ns | 0.0497 ns | 0.0296 ns |  1.00 |    0.03 |
| BitConverter_GetBytes_Int16          | .NET 8.0             | 3.163 ns | 0.1034 ns | 0.0615 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Double | .NET 8.0             | 5.708 ns | 0.1551 ns | 0.1451 ns |  1.80 |    0.06 |
| LittleEndianByteIndexer_Slice_Float  | .NET 8.0             | 6.162 ns | 0.0954 ns | 0.0631 ns |  1.95 |    0.03 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET 8.0             | 5.435 ns | 0.0781 ns | 0.0516 ns |  1.72 |    0.03 |
| LittleEndianByteIndexer_Slice_Int64  | .NET 8.0             | 5.731 ns | 0.1565 ns | 0.1035 ns |  1.81 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET 8.0             | 4.141 ns | 0.0508 ns | 0.0302 ns |  1.31 |    0.03 |
| LittleEndianByteIndexer_Slice_Int32  | .NET 8.0             | 4.178 ns | 0.0606 ns | 0.0401 ns |  1.32 |    0.04 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET 8.0             | 3.431 ns | 0.1003 ns | 0.0664 ns |  1.08 |    0.02 |
| LittleEndianByteIndexer_Slice_Int16  | .NET 8.0             | 3.399 ns | 0.0923 ns | 0.0549 ns |  1.07 |    0.02 |
| ExtensionMethod_ReadBytes_Double     | .NET 8.0             | 5.846 ns | 0.0962 ns | 0.0637 ns |  1.85 |    0.05 |
| ExtensionMethod_ReadBytes_Float      | .NET 8.0             | 7.139 ns | 0.1559 ns | 0.0928 ns |  2.26 |    0.03 |
| ExtensionMethod_ReadBytes_UInt64     | .NET 8.0             | 6.052 ns | 0.1634 ns | 0.1182 ns |  1.91 |    0.03 |
| ExtensionMethod_ReadBytes_Int64      | .NET 8.0             | 4.781 ns | 0.1058 ns | 0.0700 ns |  1.51 |    0.02 |
| ExtensionMethod_ReadBytes_UInt32     | .NET 8.0             | 4.243 ns | 0.0847 ns | 0.0560 ns |  1.34 |    0.02 |
| ExtensionMethod_ReadBytes_Int32      | .NET 8.0             | 3.433 ns | 0.0701 ns | 0.0464 ns |  1.09 |    0.01 |
| ExtensionMethod_ReadBytes_UInt16     | .NET 8.0             | 3.439 ns | 0.0657 ns | 0.0434 ns |  1.09 |    0.01 |
| ExtensionMethod_ReadBytes_Int16      | .NET 8.0             | 3.204 ns | 0.0581 ns | 0.0304 ns |  1.01 |    0.02 |
| BitConverter_GetBytes_Double         | .NET Framework 4.6.2 | 3.587 ns | 0.0307 ns | 0.0161 ns |  1.13 |    0.02 |
| BitConverter_GetBytes_Float          | .NET Framework 4.6.2 | 3.052 ns | 0.0823 ns | 0.0544 ns |  0.96 |    0.03 |
| BitConverter_GetBytes_UInt64         | .NET Framework 4.6.2 | 3.460 ns | 0.0393 ns | 0.0260 ns |  1.09 |    0.03 |
| BitConverter_GetBytes_Int64          | .NET Framework 4.6.2 | 3.587 ns | 0.0446 ns | 0.0295 ns |  1.14 |    0.02 |
| BitConverter_GetBytes_UInt32         | .NET Framework 4.6.2 | 3.013 ns | 0.0376 ns | 0.0249 ns |  0.95 |    0.02 |
| BitConverter_GetBytes_Int32          | .NET Framework 4.6.2 | 3.001 ns | 0.0448 ns | 0.0296 ns |  0.95 |    0.02 |
| BitConverter_GetBytes_UInt16         | .NET Framework 4.6.2 | 3.124 ns | 0.0621 ns | 0.0411 ns |  0.99 |    0.03 |
| BitConverter_GetBytes_Int16          | .NET Framework 4.6.2 | 3.063 ns | 0.0209 ns | 0.0139 ns |  0.97 |    0.02 |
| LittleEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 | 6.267 ns | 0.0648 ns | 0.0429 ns |  1.98 |    0.04 |
| LittleEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 | 9.112 ns | 0.0852 ns | 0.0507 ns |  2.88 |    0.07 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 | 6.244 ns | 0.1721 ns | 0.1526 ns |  1.99 |    0.05 |
| LittleEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 | 6.188 ns | 0.1056 ns | 0.0699 ns |  1.96 |    0.04 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 | 3.694 ns | 0.0216 ns | 0.0143 ns |  1.17 |    0.02 |
| LittleEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 | 3.595 ns | 0.0244 ns | 0.0145 ns |  1.14 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 | 2.648 ns | 0.0358 ns | 0.0237 ns |  0.84 |    0.02 |
| LittleEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 | 2.633 ns | 0.0532 ns | 0.0316 ns |  0.83 |    0.02 |
| ExtensionMethod_ReadBytes_Double     | .NET Framework 4.6.2 | 6.138 ns | 0.0726 ns | 0.0480 ns |  1.94 |    0.03 |
| ExtensionMethod_ReadBytes_Float      | .NET Framework 4.6.2 | 7.931 ns | 0.0953 ns | 0.0499 ns |  2.51 |    0.06 |
| ExtensionMethod_ReadBytes_UInt64     | .NET Framework 4.6.2 | 6.078 ns | 0.0315 ns | 0.0165 ns |  1.92 |    0.04 |
| ExtensionMethod_ReadBytes_Int64      | .NET Framework 4.6.2 | 3.912 ns | 0.0409 ns | 0.0270 ns |  1.24 |    0.02 |
| ExtensionMethod_ReadBytes_UInt32     | .NET Framework 4.6.2 | 3.875 ns | 0.0470 ns | 0.0311 ns |  1.22 |    0.03 |
| ExtensionMethod_ReadBytes_Int32      | .NET Framework 4.6.2 | 2.897 ns | 0.0438 ns | 0.0261 ns |  0.92 |    0.02 |
| ExtensionMethod_ReadBytes_UInt16     | .NET Framework 4.6.2 | 2.775 ns | 0.0460 ns | 0.0304 ns |  0.88 |    0.02 |
| ExtensionMethod_ReadBytes_Int16      | .NET Framework 4.6.2 | 2.261 ns | 0.0361 ns | 0.0239 ns |  0.71 |    0.02 |

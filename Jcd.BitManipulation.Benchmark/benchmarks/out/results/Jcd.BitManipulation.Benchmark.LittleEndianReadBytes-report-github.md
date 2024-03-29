```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ZHKFEE : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-PRZSWO : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                               | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double         | .NET 8.0             | 3.497 ns | 0.2910 ns | 0.2430 ns |  1.25 |    0.06 |
| BitConverter_GetBytes_Float          | .NET 8.0             | 3.377 ns | 0.2031 ns | 0.1900 ns |  1.24 |    0.07 |
| BitConverter_GetBytes_UInt64         | .NET 8.0             | 3.492 ns | 0.6493 ns | 0.6073 ns |  1.18 |    0.16 |
| BitConverter_GetBytes_Int64          | .NET 8.0             | 3.060 ns | 0.1116 ns | 0.1044 ns |  1.10 |    0.05 |
| BitConverter_GetBytes_UInt32         | .NET 8.0             | 3.283 ns | 0.2899 ns | 0.2263 ns |  1.19 |    0.07 |
| BitConverter_GetBytes_Int32          | .NET 8.0             | 3.145 ns | 0.1026 ns | 0.0679 ns |  1.13 |    0.02 |
| BitConverter_GetBytes_UInt16         | .NET 8.0             | 3.056 ns | 0.1517 ns | 0.1419 ns |  1.09 |    0.03 |
| BitConverter_GetBytes_Int16          | .NET 8.0             | 2.779 ns | 0.0699 ns | 0.0366 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Double | .NET 8.0             | 3.541 ns | 0.1136 ns | 0.0751 ns |  1.28 |    0.02 |
| LittleEndianByteIndexer_Slice_Float  | .NET 8.0             | 3.369 ns | 0.1112 ns | 0.0986 ns |  1.22 |    0.04 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET 8.0             | 3.518 ns | 0.0951 ns | 0.0843 ns |  1.26 |    0.05 |
| LittleEndianByteIndexer_Slice_Int64  | .NET 8.0             | 4.456 ns | 0.7401 ns | 0.6923 ns |  1.80 |    0.13 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET 8.0             | 3.506 ns | 0.3936 ns | 0.3489 ns |  1.34 |    0.12 |
| LittleEndianByteIndexer_Slice_Int32  | .NET 8.0             | 3.429 ns | 0.1061 ns | 0.0702 ns |  1.23 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET 8.0             | 3.317 ns | 0.1766 ns | 0.1652 ns |  1.23 |    0.06 |
| LittleEndianByteIndexer_Slice_Int16  | .NET 8.0             | 3.398 ns | 0.1013 ns | 0.0670 ns |  1.22 |    0.02 |
| ExtensionMethod_ReadBytes_Double     | .NET 8.0             | 3.627 ns | 0.0872 ns | 0.0577 ns |  1.31 |    0.03 |
| ExtensionMethod_ReadBytes_Float      | .NET 8.0             | 3.355 ns | 0.0921 ns | 0.0609 ns |  1.21 |    0.03 |
| ExtensionMethod_ReadBytes_UInt64     | .NET 8.0             | 3.829 ns | 0.2584 ns | 0.2417 ns |  1.34 |    0.06 |
| ExtensionMethod_ReadBytes_Int64      | .NET 8.0             | 4.452 ns | 0.1235 ns | 0.0646 ns |  1.60 |    0.03 |
| ExtensionMethod_ReadBytes_UInt32     | .NET 8.0             | 4.305 ns | 0.8062 ns | 0.7541 ns |  1.65 |    0.30 |
| ExtensionMethod_ReadBytes_Int32      | .NET 8.0             | 3.928 ns | 0.2784 ns | 0.2604 ns |  1.39 |    0.12 |
| ExtensionMethod_ReadBytes_UInt16     | .NET 8.0             | 3.490 ns | 0.1403 ns | 0.1312 ns |  1.27 |    0.06 |
| ExtensionMethod_ReadBytes_Int16      | .NET 8.0             | 3.356 ns | 0.1251 ns | 0.1170 ns |  1.20 |    0.04 |
| BitConverter_GetBytes_Double         | .NET Framework 4.6.2 | 4.360 ns | 0.2133 ns | 0.1781 ns |  1.57 |    0.07 |
| BitConverter_GetBytes_Float          | .NET Framework 4.6.2 | 3.710 ns | 0.0910 ns | 0.0602 ns |  1.34 |    0.02 |
| BitConverter_GetBytes_UInt64         | .NET Framework 4.6.2 | 4.103 ns | 0.1273 ns | 0.0842 ns |  1.48 |    0.04 |
| BitConverter_GetBytes_Int64          | .NET Framework 4.6.2 | 4.216 ns | 0.1285 ns | 0.0929 ns |  1.52 |    0.04 |
| BitConverter_GetBytes_UInt32         | .NET Framework 4.6.2 | 3.757 ns | 0.1116 ns | 0.0807 ns |  1.34 |    0.03 |
| BitConverter_GetBytes_Int32          | .NET Framework 4.6.2 | 3.750 ns | 0.0722 ns | 0.0430 ns |  1.35 |    0.02 |
| BitConverter_GetBytes_UInt16         | .NET Framework 4.6.2 | 3.950 ns | 0.1958 ns | 0.1736 ns |  1.42 |    0.07 |
| BitConverter_GetBytes_Int16          | .NET Framework 4.6.2 | 3.967 ns | 0.1203 ns | 0.0870 ns |  1.43 |    0.04 |
| LittleEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 | 5.804 ns | 0.1582 ns | 0.1321 ns |  2.08 |    0.08 |
| LittleEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 | 8.518 ns | 0.2063 ns | 0.1930 ns |  3.05 |    0.06 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 | 5.378 ns | 0.1349 ns | 0.0892 ns |  1.94 |    0.03 |
| LittleEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 | 5.540 ns | 0.1890 ns | 0.1768 ns |  2.02 |    0.06 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 | 4.343 ns | 0.1247 ns | 0.1105 ns |  1.56 |    0.06 |
| LittleEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 | 4.439 ns | 0.1280 ns | 0.0846 ns |  1.60 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 | 4.219 ns | 0.1155 ns | 0.0687 ns |  1.52 |    0.03 |
| LittleEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 | 4.231 ns | 0.1264 ns | 0.0987 ns |  1.52 |    0.03 |
| ExtensionMethod_ReadBytes_Double     | .NET Framework 4.6.2 | 5.791 ns | 0.0908 ns | 0.0541 ns |  2.08 |    0.03 |
| ExtensionMethod_ReadBytes_Float      | .NET Framework 4.6.2 | 8.226 ns | 0.1974 ns | 0.1033 ns |  2.96 |    0.05 |
| ExtensionMethod_ReadBytes_UInt64     | .NET Framework 4.6.2 | 5.421 ns | 0.0873 ns | 0.0519 ns |  1.95 |    0.03 |
| ExtensionMethod_ReadBytes_Int64      | .NET Framework 4.6.2 | 4.862 ns | 0.2238 ns | 0.2094 ns |  1.72 |    0.03 |
| ExtensionMethod_ReadBytes_UInt32     | .NET Framework 4.6.2 | 4.188 ns | 0.1065 ns | 0.0705 ns |  1.51 |    0.04 |
| ExtensionMethod_ReadBytes_Int32      | .NET Framework 4.6.2 | 3.176 ns | 0.0474 ns | 0.0282 ns |  1.14 |    0.02 |
| ExtensionMethod_ReadBytes_UInt16     | .NET Framework 4.6.2 | 3.815 ns | 0.0557 ns | 0.0368 ns |  1.38 |    0.02 |
| ExtensionMethod_ReadBytes_Int16      | .NET Framework 4.6.2 | 2.735 ns | 0.0763 ns | 0.0504 ns |  0.98 |    0.02 |

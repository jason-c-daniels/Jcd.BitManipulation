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

| Method                            | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|-----------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double      | .NET 8.0             |  6.073 ns | 0.6415 ns | 0.5686 ns |  0.96 |    0.09 |
| BitConverter_GetBytes_Float       | .NET 8.0             |  7.214 ns | 0.9008 ns | 0.8426 ns |  1.12 |    0.15 |
| BitConverter_GetBytes_UInt64      | .NET 8.0             |  6.447 ns | 0.6976 ns | 0.6525 ns |  1.02 |    0.11 |
| BitConverter_GetBytes_Int64       | .NET 8.0             |  6.880 ns | 0.6834 ns | 0.6058 ns |  1.08 |    0.07 |
| BitConverter_GetBytes_UInt32      | .NET 8.0             |  6.598 ns | 0.2166 ns | 0.1691 ns |  1.04 |    0.06 |
| BitConverter_GetBytes_Int32       | .NET 8.0             |  6.769 ns | 0.7815 ns | 0.7310 ns |  1.07 |    0.13 |
| BitConverter_GetBytes_UInt16      | .NET 8.0             |  5.987 ns | 0.2333 ns | 0.2069 ns |  0.94 |    0.03 |
| BitConverter_GetBytes_Int16       | .NET 8.0             |  6.349 ns | 0.3350 ns | 0.2970 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Double | .NET 8.0             |  6.302 ns | 0.5517 ns | 0.5161 ns |  1.00 |    0.08 |
| BigEndianByteIndexer_Slice_Float  | .NET 8.0             |  5.650 ns | 0.6318 ns | 0.5910 ns |  0.90 |    0.09 |
| BigEndianByteIndexer_Slice_UInt64 | .NET 8.0             |  5.267 ns | 0.2461 ns | 0.2055 ns |  0.83 |    0.06 |
| BigEndianByteIndexer_Slice_Int64  | .NET 8.0             |  5.523 ns | 0.7017 ns | 0.6563 ns |  0.87 |    0.11 |
| BigEndianByteIndexer_Slice_UInt32 | .NET 8.0             |  5.772 ns | 0.6257 ns | 0.5853 ns |  0.90 |    0.09 |
| BigEndianByteIndexer_Slice_Int32  | .NET 8.0             |  6.023 ns | 0.4434 ns | 0.4148 ns |  0.96 |    0.09 |
| BigEndianByteIndexer_Slice_UInt16 | .NET 8.0             |  5.680 ns | 0.5704 ns | 0.5336 ns |  0.90 |    0.11 |
| BigEndianByteIndexer_Slice_Int16  | .NET 8.0             |  5.754 ns | 0.5195 ns | 0.4859 ns |  0.91 |    0.09 |
| ExtensionMethod_ReadBytes_Double  | .NET 8.0             |  5.843 ns | 0.6068 ns | 0.5676 ns |  0.91 |    0.10 |
| ExtensionMethod_ReadBytes_Float   | .NET 8.0             |  5.833 ns | 0.6932 ns | 0.6484 ns |  0.93 |    0.13 |
| ExtensionMethod_ReadBytes_UInt64  | .NET 8.0             |  6.048 ns | 0.7730 ns | 0.7230 ns |  0.96 |    0.12 |
| ExtensionMethod_ReadBytes_Int64   | .NET 8.0             |  6.702 ns | 0.3336 ns | 0.3120 ns |  1.05 |    0.06 |
| ExtensionMethod_ReadBytes_UInt32  | .NET 8.0             |  5.554 ns | 0.5305 ns | 0.4962 ns |  0.87 |    0.08 |
| ExtensionMethod_ReadBytes_Int32   | .NET 8.0             |  6.128 ns | 0.6124 ns | 0.5728 ns |  0.96 |    0.07 |
| ExtensionMethod_ReadBytes_UInt16  | .NET 8.0             |  5.537 ns | 0.5376 ns | 0.5029 ns |  0.88 |    0.09 |
| ExtensionMethod_ReadBytes_Int16   | .NET 8.0             |  5.456 ns | 0.4555 ns | 0.4261 ns |  0.86 |    0.07 |
| BitConverter_GetBytes_Double      | .NET Framework 4.6.2 | 29.619 ns | 1.2089 ns | 0.9438 ns |  4.68 |    0.20 |
| BitConverter_GetBytes_Float       | .NET Framework 4.6.2 | 29.819 ns | 3.0217 ns | 2.8265 ns |  4.68 |    0.45 |
| BitConverter_GetBytes_UInt64      | .NET Framework 4.6.2 | 32.890 ns | 3.7599 ns | 3.5170 ns |  5.23 |    0.48 |
| BitConverter_GetBytes_Int64       | .NET Framework 4.6.2 | 30.117 ns | 1.4222 ns | 1.1876 ns |  4.77 |    0.29 |
| BitConverter_GetBytes_UInt32      | .NET Framework 4.6.2 | 27.808 ns | 0.4979 ns | 0.3293 ns |  4.43 |    0.21 |
| BitConverter_GetBytes_Int32       | .NET Framework 4.6.2 | 29.139 ns | 1.5227 ns | 1.4243 ns |  4.58 |    0.37 |
| BitConverter_GetBytes_UInt16      | .NET Framework 4.6.2 | 26.164 ns | 0.2733 ns | 0.1626 ns |  4.16 |    0.21 |
| BitConverter_GetBytes_Int16       | .NET Framework 4.6.2 | 26.594 ns | 0.5438 ns | 0.3932 ns |  4.21 |    0.21 |
| BigEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 | 15.494 ns | 6.2630 ns | 5.8584 ns |  2.47 |    0.92 |
| BigEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 | 13.117 ns | 0.9349 ns | 0.8288 ns |  2.07 |    0.16 |
| BigEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 |  8.225 ns | 0.3608 ns | 0.3199 ns |  1.30 |    0.08 |
| BigEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 |  8.224 ns | 0.4018 ns | 0.3137 ns |  1.30 |    0.06 |
| BigEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 |  5.229 ns | 0.2984 ns | 0.2791 ns |  0.83 |    0.06 |
| BigEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 |  5.377 ns | 0.4221 ns | 0.3525 ns |  0.85 |    0.07 |
| BigEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 |  4.162 ns | 0.1832 ns | 0.1624 ns |  0.66 |    0.04 |
| BigEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 |  4.167 ns | 0.2212 ns | 0.1847 ns |  0.66 |    0.04 |
| ExtensionMethod_ReadBytes_Double  | .NET Framework 4.6.2 |  8.398 ns | 0.2139 ns | 0.1786 ns |  1.33 |    0.06 |
| ExtensionMethod_ReadBytes_Float   | .NET Framework 4.6.2 |  9.553 ns | 0.5573 ns | 0.5213 ns |  1.51 |    0.11 |
| ExtensionMethod_ReadBytes_UInt64  | .NET Framework 4.6.2 |  8.418 ns | 0.4018 ns | 0.3759 ns |  1.33 |    0.08 |
| ExtensionMethod_ReadBytes_Int64   | .NET Framework 4.6.2 |  4.913 ns | 0.2977 ns | 0.2639 ns |  0.78 |    0.05 |
| ExtensionMethod_ReadBytes_UInt32  | .NET Framework 4.6.2 |  5.307 ns | 0.1472 ns | 0.1149 ns |  0.84 |    0.04 |
| ExtensionMethod_ReadBytes_Int32   | .NET Framework 4.6.2 |  3.526 ns | 0.1155 ns | 0.0764 ns |  0.56 |    0.03 |
| ExtensionMethod_ReadBytes_UInt16  | .NET Framework 4.6.2 |  4.644 ns | 0.3518 ns | 0.3291 ns |  0.74 |    0.07 |
| ExtensionMethod_ReadBytes_Int16   | .NET Framework 4.6.2 |  2.995 ns | 0.0659 ns | 0.0436 ns |  0.48 |    0.02 |

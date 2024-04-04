```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-CXBWXK : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-SUYWZE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```
| Method                      | Runtime              | Mean      | Error     | StdDev    | Median    | Ratio   | RatioSD |
|---------------------------- |--------------------- |----------:|----------:|----------:|----------:|--------:|--------:|
| ExtensionMethod_On_A_Double | .NET 8.0             | 0.0073 ns | 0.0154 ns | 0.0102 ns | 0.0031 ns |   1.015 |    2.13 |
| ExtensionMethod_On_A_Float  | .NET 8.0             | 0.0097 ns | 0.0126 ns | 0.0075 ns | 0.0089 ns |   0.856 |    0.61 |
| ExtensionMethod_On_A_UInt64 | .NET 8.0             | 0.0013 ns | 0.0050 ns | 0.0026 ns | 0.0000 ns |   0.192 |    0.36 |
| ExtensionMethod_On_A_Int64  | .NET 8.0             | 0.0049 ns | 0.0120 ns | 0.0079 ns | 0.0000 ns |   0.779 |    1.53 |
| ExtensionMethod_On_A_UInt32 | .NET 8.0             | 0.0018 ns | 0.0058 ns | 0.0038 ns | 0.0000 ns |   0.322 |    0.73 |
| ExtensionMethod_On_A_Int32  | .NET 8.0             | 0.0051 ns | 0.0094 ns | 0.0056 ns | 0.0035 ns |   0.422 |    0.55 |
| ExtensionMethod_On_A_UInt16 | .NET 8.0             | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |   0.000 |    0.00 |
| ExtensionMethod_On_A_Int16  | .NET 8.0             | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |   0.000 |    0.00 |
| ByteIndexer_From_A_Double   | .NET 8.0             | 0.0025 ns | 0.0061 ns | 0.0036 ns | 0.0000 ns |   0.245 |    0.39 |
| ByteIndexer_From_A_Float    | .NET 8.0             | 0.0006 ns | 0.0030 ns | 0.0015 ns | 0.0000 ns |   0.021 |    0.06 |
| ByteIndexer_From_A_UInt64   | .NET 8.0             | 0.0134 ns | 0.0112 ns | 0.0067 ns | 0.0104 ns |   1.000 |    0.00 |
| ByteIndexer_From_A_Int64    | .NET 8.0             | 0.0077 ns | 0.0154 ns | 0.0102 ns | 0.0004 ns |   0.682 |    0.87 |
| ByteIndexer_From_A_UInt32   | .NET 8.0             | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |   0.000 |    0.00 |
| ByteIndexer_From_A_Int32    | .NET 8.0             | 0.0090 ns | 0.0157 ns | 0.0082 ns | 0.0108 ns |   0.850 |    0.91 |
| ByteIndexer_From_A_UInt16   | .NET 8.0             | 0.0050 ns | 0.0100 ns | 0.0066 ns | 0.0023 ns |   0.513 |    0.70 |
| ByteIndexer_From_A_Int16    | .NET 8.0             | 0.0237 ns | 0.0274 ns | 0.0256 ns | 0.0108 ns |   2.865 |    3.02 |
| ExtensionMethod_On_A_Double | .NET Framework 4.6.2 | 0.1238 ns | 0.0368 ns | 0.0344 ns | 0.1207 ns |  11.792 |    6.18 |
| ExtensionMethod_On_A_Float  | .NET Framework 4.6.2 | 9.1899 ns | 0.1683 ns | 0.1113 ns | 9.1828 ns | 855.007 |  451.60 |
| ExtensionMethod_On_A_UInt64 | .NET Framework 4.6.2 | 0.0005 ns | 0.0025 ns | 0.0017 ns | 0.0000 ns |   0.058 |    0.17 |
| ExtensionMethod_On_A_Int64  | .NET Framework 4.6.2 | 0.0116 ns | 0.0297 ns | 0.0263 ns | 0.0000 ns |   0.707 |    1.46 |
| ExtensionMethod_On_A_UInt32 | .NET Framework 4.6.2 | 0.0166 ns | 0.0267 ns | 0.0237 ns | 0.0000 ns |   2.092 |    2.79 |
| ExtensionMethod_On_A_Int32  | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |   0.000 |    0.00 |
| ExtensionMethod_On_A_UInt16 | .NET Framework 4.6.2 | 0.0013 ns | 0.0030 ns | 0.0028 ns | 0.0000 ns |   0.084 |    0.25 |
| ExtensionMethod_On_A_Int16  | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |   0.000 |    0.00 |
| ByteIndexer_From_A_Double   | .NET Framework 4.6.2 | 1.6352 ns | 0.1903 ns | 0.1780 ns | 1.5545 ns | 142.014 |   74.27 |
| ByteIndexer_From_A_Float    | .NET Framework 4.6.2 | 5.5226 ns | 0.3481 ns | 0.3086 ns | 5.4245 ns | 502.265 |  270.37 |
| ByteIndexer_From_A_UInt64   | .NET Framework 4.6.2 | 1.4703 ns | 0.0833 ns | 0.0779 ns | 1.4578 ns | 139.383 |   82.20 |
| ByteIndexer_From_A_Int64    | .NET Framework 4.6.2 | 1.4213 ns | 0.0689 ns | 0.0645 ns | 1.4266 ns | 130.896 |   66.81 |
| ByteIndexer_From_A_UInt32   | .NET Framework 4.6.2 | 1.3138 ns | 0.0486 ns | 0.0454 ns | 1.3066 ns | 122.392 |   63.19 |
| ByteIndexer_From_A_Int32    | .NET Framework 4.6.2 | 1.3291 ns | 0.0452 ns | 0.0299 ns | 1.3237 ns | 123.845 |   65.06 |
| ByteIndexer_From_A_UInt16   | .NET Framework 4.6.2 | 1.4589 ns | 0.0330 ns | 0.0218 ns | 1.4655 ns | 135.155 |   70.34 |
| ByteIndexer_From_A_Int16    | .NET Framework 4.6.2 | 1.3813 ns | 0.0305 ns | 0.0181 ns | 1.3832 ns | 128.837 |   68.77 |

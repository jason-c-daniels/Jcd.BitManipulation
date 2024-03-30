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
| Method                      | Runtime              | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD |
|---------------------------- |--------------------- |-----------:|----------:|----------:|-----------:|------:|--------:|
| ByteIndexer_From_A_Double   | .NET 8.0             |  0.0051 ns | 0.0067 ns | 0.0040 ns |  0.0047 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET 8.0             |  0.0027 ns | 0.0095 ns | 0.0050 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET 8.0             |  0.0286 ns | 0.0255 ns | 0.0169 ns |  0.0269 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET 8.0             |  0.0134 ns | 0.0203 ns | 0.0190 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET 8.0             |  0.0096 ns | 0.0134 ns | 0.0125 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET 8.0             |  0.0053 ns | 0.0132 ns | 0.0087 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET 8.0             |  0.0088 ns | 0.0191 ns | 0.0149 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET 8.0             |  0.0018 ns | 0.0065 ns | 0.0060 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET 8.0             |  0.0058 ns | 0.0128 ns | 0.0100 ns |  0.0010 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET 8.0             |  0.0021 ns | 0.0057 ns | 0.0038 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET 8.0             |  0.0030 ns | 0.0108 ns | 0.0072 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET 8.0             |  0.0062 ns | 0.0086 ns | 0.0057 ns |  0.0070 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET 8.0             |  0.0040 ns | 0.0090 ns | 0.0054 ns |  0.0017 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET 8.0             |  0.0045 ns | 0.0068 ns | 0.0041 ns |  0.0052 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET 8.0             |  0.0044 ns | 0.0116 ns | 0.0077 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET Framework 4.6.2 |  1.3130 ns | 0.0283 ns | 0.0169 ns |  1.3065 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET Framework 4.6.2 | 10.7096 ns | 0.1906 ns | 0.1261 ns | 10.6804 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET Framework 4.6.2 |  1.3397 ns | 0.0264 ns | 0.0175 ns |  1.3428 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET Framework 4.6.2 |  1.3410 ns | 0.0255 ns | 0.0169 ns |  1.3439 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET Framework 4.6.2 |  1.3018 ns | 0.0305 ns | 0.0202 ns |  1.2996 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET Framework 4.6.2 |  1.1910 ns | 0.0179 ns | 0.0106 ns |  1.1957 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET Framework 4.6.2 |  1.5015 ns | 0.1748 ns | 0.1635 ns |  1.4089 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET Framework 4.6.2 |  1.5365 ns | 0.0519 ns | 0.0375 ns |  1.5215 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET Framework 4.6.2 |  0.0268 ns | 0.0342 ns | 0.0319 ns |  0.0140 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET Framework 4.6.2 |  9.2653 ns | 0.1617 ns | 0.0962 ns |  9.2827 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET Framework 4.6.2 |  0.0128 ns | 0.0371 ns | 0.0347 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET Framework 4.6.2 |  0.0058 ns | 0.0118 ns | 0.0105 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET Framework 4.6.2 |  0.0030 ns | 0.0125 ns | 0.0111 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET Framework 4.6.2 |  0.0125 ns | 0.0274 ns | 0.0256 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET Framework 4.6.2 |  0.0002 ns | 0.0009 ns | 0.0007 ns |  0.0000 ns |     ? |       ? |

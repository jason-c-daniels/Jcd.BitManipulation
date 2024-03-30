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
| Method                      | Runtime              | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD |
|---------------------------- |--------------------- |-----------:|----------:|----------:|-----------:|------:|--------:|
| ExtensionMethod_On_A_Double | .NET 8.0             |  0.0010 ns | 0.0030 ns | 0.0020 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET 8.0             |  0.0015 ns | 0.0050 ns | 0.0033 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET 8.0             |  0.0009 ns | 0.0020 ns | 0.0013 ns |  0.0001 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET 8.0             |  0.0003 ns | 0.0012 ns | 0.0008 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET 8.0             |  0.0007 ns | 0.0026 ns | 0.0017 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET 8.0             |  0.0029 ns | 0.0068 ns | 0.0045 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET 8.0             |  0.0007 ns | 0.0019 ns | 0.0013 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET 8.0             |  0.0007 ns | 0.0016 ns | 0.0008 ns |  0.0003 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET 8.0             |  0.0002 ns | 0.0008 ns | 0.0005 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET 8.0             |  0.0040 ns | 0.0071 ns | 0.0047 ns |  0.0032 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET 8.0             |  0.0003 ns | 0.0011 ns | 0.0007 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET 8.0             |  0.0006 ns | 0.0016 ns | 0.0010 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET Framework 4.6.2 |  0.0862 ns | 0.0062 ns | 0.0041 ns |  0.0873 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET Framework 4.6.2 |  9.1149 ns | 0.0636 ns | 0.0379 ns |  9.1155 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET Framework 4.6.2 |  1.5063 ns | 0.0297 ns | 0.0177 ns |  1.5033 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET Framework 4.6.2 | 10.8251 ns | 0.0922 ns | 0.0549 ns | 10.8210 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET Framework 4.6.2 |  1.4238 ns | 0.0421 ns | 0.0278 ns |  1.4161 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET Framework 4.6.2 |  1.3964 ns | 0.0087 ns | 0.0058 ns |  1.3956 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET Framework 4.6.2 |  1.2628 ns | 0.0303 ns | 0.0180 ns |  1.2587 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET Framework 4.6.2 |  1.2531 ns | 0.0117 ns | 0.0070 ns |  1.2525 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET Framework 4.6.2 |  1.4271 ns | 0.0194 ns | 0.0128 ns |  1.4295 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET Framework 4.6.2 |  1.2760 ns | 0.0087 ns | 0.0046 ns |  1.2775 ns |     ? |       ? |

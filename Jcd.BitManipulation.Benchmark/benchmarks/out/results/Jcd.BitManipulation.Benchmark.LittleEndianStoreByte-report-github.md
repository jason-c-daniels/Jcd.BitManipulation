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
| ByteIndexer_From_A_Double   | .NET 8.0             |  0.0009 ns | 0.0018 ns | 0.0012 ns |  0.0002 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET 8.0             |  0.0001 ns | 0.0003 ns | 0.0002 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET 8.0             |  0.0014 ns | 0.0031 ns | 0.0021 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET 8.0             |  0.0032 ns | 0.0051 ns | 0.0034 ns |  0.0026 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET 8.0             |  0.0035 ns | 0.0042 ns | 0.0028 ns |  0.0037 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET 8.0             |  0.0027 ns | 0.0051 ns | 0.0034 ns |  0.0016 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET 8.0             |  0.0027 ns | 0.0043 ns | 0.0028 ns |  0.0024 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET 8.0             |  0.0050 ns | 0.0077 ns | 0.0051 ns |  0.0046 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET 8.0             |  0.0041 ns | 0.0066 ns | 0.0044 ns |  0.0021 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET 8.0             |  0.0368 ns | 0.0607 ns | 0.0568 ns |  0.0002 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET 8.0             |  0.0009 ns | 0.0032 ns | 0.0019 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET 8.0             |  0.0016 ns | 0.0032 ns | 0.0021 ns |  0.0004 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET 8.0             |  0.0037 ns | 0.0070 ns | 0.0046 ns |  0.0021 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET 8.0             |  0.0016 ns | 0.0041 ns | 0.0027 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET 8.0             |  0.0010 ns | 0.0026 ns | 0.0017 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET 8.0             |  0.0034 ns | 0.0038 ns | 0.0025 ns |  0.0035 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET Framework 4.6.2 |  1.3215 ns | 0.0550 ns | 0.0459 ns |  1.3067 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET Framework 4.6.2 | 10.7793 ns | 0.1592 ns | 0.1053 ns | 10.8058 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET Framework 4.6.2 |  1.2934 ns | 0.0193 ns | 0.0128 ns |  1.2919 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET Framework 4.6.2 |  1.2922 ns | 0.0208 ns | 0.0138 ns |  1.2945 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET Framework 4.6.2 |  1.2658 ns | 0.0193 ns | 0.0128 ns |  1.2643 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET Framework 4.6.2 |  1.2820 ns | 0.0201 ns | 0.0133 ns |  1.2780 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET Framework 4.6.2 |  1.4307 ns | 0.0115 ns | 0.0076 ns |  1.4299 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET Framework 4.6.2 |  1.4110 ns | 0.0089 ns | 0.0053 ns |  1.4121 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET Framework 4.6.2 |  0.0240 ns | 0.0079 ns | 0.0052 ns |  0.0231 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET Framework 4.6.2 |  9.1393 ns | 0.0322 ns | 0.0213 ns |  9.1344 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |

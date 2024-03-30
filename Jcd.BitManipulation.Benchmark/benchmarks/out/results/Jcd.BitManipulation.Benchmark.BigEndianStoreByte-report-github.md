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
| ExtensionMethod_On_A_Double | .NET 8.0             |  0.0819 ns | 0.0714 ns | 0.0668 ns |  0.0869 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET 8.0             |  0.0022 ns | 0.0096 ns | 0.0080 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET 8.0             |  0.0131 ns | 0.0213 ns | 0.0199 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET 8.0             |  0.0036 ns | 0.0120 ns | 0.0094 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET 8.0             |  0.0321 ns | 0.0471 ns | 0.0441 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET 8.0             |  0.0287 ns | 0.0476 ns | 0.0445 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET 8.0             |  0.0402 ns | 0.0515 ns | 0.0456 ns |  0.0283 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET 8.0             |  0.0008 ns | 0.0027 ns | 0.0023 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET 8.0             |  0.0104 ns | 0.0167 ns | 0.0157 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET 8.0             |  0.0009 ns | 0.0038 ns | 0.0036 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET 8.0             |  0.0133 ns | 0.0216 ns | 0.0202 ns |  0.0064 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET 8.0             |  0.0299 ns | 0.0290 ns | 0.0271 ns |  0.0386 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET 8.0             |  0.0120 ns | 0.0197 ns | 0.0185 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET Framework 4.6.2 |  0.1436 ns | 0.0481 ns | 0.0402 ns |  0.1560 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET Framework 4.6.2 |  9.4006 ns | 0.3091 ns | 0.2891 ns |  9.3151 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET Framework 4.6.2 |  0.0053 ns | 0.0125 ns | 0.0110 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET Framework 4.6.2 |  0.0137 ns | 0.0304 ns | 0.0284 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET Framework 4.6.2 |  0.0030 ns | 0.0101 ns | 0.0073 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET Framework 4.6.2 |  0.0027 ns | 0.0064 ns | 0.0060 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET Framework 4.6.2 |  0.0002 ns | 0.0008 ns | 0.0007 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET Framework 4.6.2 |  0.0004 ns | 0.0011 ns | 0.0010 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET Framework 4.6.2 |  1.5587 ns | 0.0762 ns | 0.0713 ns |  1.5471 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET Framework 4.6.2 | 11.0378 ns | 0.3039 ns | 0.2843 ns | 11.0142 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET Framework 4.6.2 |  1.4837 ns | 0.1132 ns | 0.1059 ns |  1.4720 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET Framework 4.6.2 |  1.4145 ns | 0.0570 ns | 0.0533 ns |  1.4060 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET Framework 4.6.2 |  1.2352 ns | 0.0442 ns | 0.0345 ns |  1.2271 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET Framework 4.6.2 |  1.2442 ns | 0.0455 ns | 0.0403 ns |  1.2422 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET Framework 4.6.2 |  1.3836 ns | 0.0366 ns | 0.0242 ns |  1.3841 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET Framework 4.6.2 |  1.3222 ns | 0.0425 ns | 0.0253 ns |  1.3227 ns |     ? |       ? |

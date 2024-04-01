```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ROZSUB : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-TSPCCX : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                      | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|-----------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| ByteIndexer_From_A_Double   | .NET 8.0             |  0.0196 ns | 0.0212 ns | 0.0177 ns |  0.0154 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET 8.0             |  0.0089 ns | 0.0092 ns | 0.0061 ns |  0.0070 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET 8.0             |  0.0176 ns | 0.0234 ns | 0.0207 ns |  0.0114 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET 8.0             |  0.0635 ns | 0.0664 ns | 0.0621 ns |  0.0442 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET 8.0             |  0.0097 ns | 0.0151 ns | 0.0100 ns |  0.0090 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET 8.0             |  0.0360 ns | 0.0268 ns | 0.0251 ns |  0.0341 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET 8.0             |  0.0183 ns | 0.0230 ns | 0.0152 ns |  0.0181 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET 8.0             |  0.0055 ns | 0.0113 ns | 0.0075 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET 8.0             |  0.0140 ns | 0.0201 ns | 0.0133 ns |  0.0153 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET 8.0             |  0.0033 ns | 0.0114 ns | 0.0068 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET 8.0             |  0.0083 ns | 0.0123 ns | 0.0073 ns |  0.0106 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET 8.0             |  0.0236 ns | 0.0249 ns | 0.0233 ns |  0.0258 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET 8.0             |  0.0008 ns | 0.0014 ns | 0.0008 ns |  0.0009 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET Framework 4.6.2 |  1.3507 ns | 0.0498 ns | 0.0441 ns |  1.3470 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET Framework 4.6.2 | 11.3335 ns | 0.4300 ns | 0.4022 ns | 11.1444 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET Framework 4.6.2 |  1.2936 ns | 0.0251 ns | 0.0166 ns |  1.2947 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET Framework 4.6.2 |  1.3326 ns | 0.0152 ns | 0.0101 ns |  1.3362 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET Framework 4.6.2 |  1.3175 ns | 0.0353 ns | 0.0210 ns |  1.3164 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET Framework 4.6.2 |  1.2739 ns | 0.0258 ns | 0.0171 ns |  1.2697 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET Framework 4.6.2 |  1.4606 ns | 0.0262 ns | 0.0173 ns |  1.4613 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET Framework 4.6.2 |  1.4154 ns | 0.0224 ns | 0.0148 ns |  1.4149 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET Framework 4.6.2 |  0.0470 ns | 0.0332 ns | 0.0294 ns |  0.0429 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET Framework 4.6.2 |  9.2660 ns | 0.0947 ns | 0.0627 ns |  9.2451 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET Framework 4.6.2 |  0.0014 ns | 0.0066 ns | 0.0048 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET Framework 4.6.2 |  0.0006 ns | 0.0023 ns | 0.0021 ns |  0.0000 ns |     ? |       ? |

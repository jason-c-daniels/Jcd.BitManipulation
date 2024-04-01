```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-XPKBTN : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-HBVPVO : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                      | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|-----------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| ByteIndexer_From_A_Double   | .NET 8.0             |  0.0717 ns | 0.0851 ns | 0.0796 ns |  0.0386 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET 8.0             |  0.0215 ns | 0.0319 ns | 0.0299 ns |  0.0063 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET 8.0             |  0.0035 ns | 0.0110 ns | 0.0098 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET 8.0             |  0.0017 ns | 0.0068 ns | 0.0064 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET 8.0             |  0.0159 ns | 0.0187 ns | 0.0166 ns |  0.0131 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET 8.0             |  0.1246 ns | 0.1519 ns | 0.1421 ns |  0.0625 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET 8.0             |  0.0133 ns | 0.0187 ns | 0.0175 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET 8.0             |  0.0029 ns | 0.0091 ns | 0.0060 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET 8.0             |  0.0820 ns | 0.0668 ns | 0.0625 ns |  0.0740 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET 8.0             |  0.0145 ns | 0.0178 ns | 0.0118 ns |  0.0117 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET 8.0             |  0.0547 ns | 0.0404 ns | 0.0377 ns |  0.0692 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET 8.0             |  0.0054 ns | 0.0119 ns | 0.0111 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET 8.0             |  0.0519 ns | 0.0406 ns | 0.0380 ns |  0.0593 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET Framework 4.6.2 |  1.5598 ns | 0.1101 ns | 0.1030 ns |  1.5260 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET Framework 4.6.2 |  5.5421 ns | 0.2180 ns | 0.2039 ns |  5.5297 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET Framework 4.6.2 |  1.3888 ns | 0.0398 ns | 0.0263 ns |  1.3914 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET Framework 4.6.2 |  1.4760 ns | 0.0575 ns | 0.0538 ns |  1.4627 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET Framework 4.6.2 |  1.4038 ns | 0.0489 ns | 0.0291 ns |  1.3916 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET Framework 4.6.2 |  1.4250 ns | 0.0512 ns | 0.0479 ns |  1.4246 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET Framework 4.6.2 |  1.6462 ns | 0.0970 ns | 0.0860 ns |  1.6304 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET Framework 4.6.2 |  1.6627 ns | 0.1365 ns | 0.1277 ns |  1.6493 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET Framework 4.6.2 |  0.0646 ns | 0.0458 ns | 0.0429 ns |  0.0513 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET Framework 4.6.2 | 10.3135 ns | 0.4637 ns | 0.4337 ns | 10.3346 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET Framework 4.6.2 |  0.0166 ns | 0.0312 ns | 0.0292 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET Framework 4.6.2 |  0.0049 ns | 0.0115 ns | 0.0102 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET Framework 4.6.2 |  0.0054 ns | 0.0082 ns | 0.0073 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET Framework 4.6.2 |  0.0278 ns | 0.0513 ns | 0.0480 ns |  0.0000 ns |     ? |       ? |

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-VBQYBY : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-NFESSE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                      | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|-----------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| ByteIndexer_From_A_Double   | .NET 8.0             |  0.0054 ns | 0.0130 ns | 0.0086 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET 8.0             |  0.0216 ns | 0.0264 ns | 0.0174 ns |  0.0211 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET 8.0             |  0.0193 ns | 0.0230 ns | 0.0180 ns |  0.0225 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET 8.0             |  0.0910 ns | 0.1063 ns | 0.0943 ns |  0.0831 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET 8.0             |  0.0162 ns | 0.0224 ns | 0.0210 ns |  0.0093 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET 8.0             |  0.0400 ns | 0.0333 ns | 0.0311 ns |  0.0307 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET 8.0             |  0.0199 ns | 0.0348 ns | 0.0308 ns |  0.0037 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET 8.0             |  0.0072 ns | 0.0160 ns | 0.0116 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET 8.0             |  0.0051 ns | 0.0091 ns | 0.0060 ns |  0.0022 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET 8.0             |  0.0172 ns | 0.0287 ns | 0.0254 ns |  0.0010 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET 8.0             |  0.0004 ns | 0.0018 ns | 0.0011 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET 8.0             |  0.0075 ns | 0.0149 ns | 0.0124 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET 8.0             |  0.0105 ns | 0.0186 ns | 0.0155 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET 8.0             |  0.0016 ns | 0.0039 ns | 0.0029 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET 8.0             |  0.0260 ns | 0.0253 ns | 0.0225 ns |  0.0229 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET 8.0             |  0.0033 ns | 0.0108 ns | 0.0084 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET Framework 4.6.2 |  1.4868 ns | 0.0930 ns | 0.0870 ns |  1.5052 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET Framework 4.6.2 | 12.1292 ns | 0.3391 ns | 0.3172 ns | 12.0361 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET Framework 4.6.2 |  1.4544 ns | 0.0520 ns | 0.0344 ns |  1.4544 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET Framework 4.6.2 |  1.4347 ns | 0.0521 ns | 0.0488 ns |  1.4282 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET Framework 4.6.2 |  1.3726 ns | 0.0320 ns | 0.0167 ns |  1.3720 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET Framework 4.6.2 |  1.3758 ns | 0.0631 ns | 0.0590 ns |  1.3570 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET Framework 4.6.2 |  1.6725 ns | 0.1387 ns | 0.1298 ns |  1.6342 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET Framework 4.6.2 |  1.5557 ns | 0.0424 ns | 0.0252 ns |  1.5592 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET Framework 4.6.2 |  0.0369 ns | 0.0226 ns | 0.0176 ns |  0.0382 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET Framework 4.6.2 | 10.0498 ns | 0.2252 ns | 0.1997 ns | 10.0165 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET Framework 4.6.2 |  0.0004 ns | 0.0019 ns | 0.0014 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET Framework 4.6.2 |  0.0020 ns | 0.0055 ns | 0.0049 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET Framework 4.6.2 |  0.0008 ns | 0.0036 ns | 0.0028 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET Framework 4.6.2 |  0.0005 ns | 0.0017 ns | 0.0012 ns |  0.0000 ns |     ? |       ? |

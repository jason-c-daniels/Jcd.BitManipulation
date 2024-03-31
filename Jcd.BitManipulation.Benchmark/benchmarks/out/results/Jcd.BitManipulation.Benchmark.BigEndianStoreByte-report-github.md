```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-LRLIBL : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-MDTRPR : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                      | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|-----------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| ExtensionMethod_On_A_Double | .NET 8.0             |  0.0024 ns | 0.0054 ns | 0.0036 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET 8.0             |  0.0136 ns | 0.0093 ns | 0.0055 ns |  0.0148 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET 8.0             |  0.0036 ns | 0.0068 ns | 0.0045 ns |  0.0021 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET 8.0             |  0.0007 ns | 0.0023 ns | 0.0013 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET 8.0             |  0.0011 ns | 0.0034 ns | 0.0022 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET 8.0             |  0.0012 ns | 0.0029 ns | 0.0019 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET 8.0             |  0.0127 ns | 0.0085 ns | 0.0056 ns |  0.0120 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET 8.0             |  0.0212 ns | 0.0089 ns | 0.0059 ns |  0.0222 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET 8.0             |  0.0065 ns | 0.0092 ns | 0.0061 ns |  0.0061 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET 8.0             |  0.0019 ns | 0.0051 ns | 0.0034 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET 8.0             |  0.0028 ns | 0.0053 ns | 0.0035 ns |  0.0008 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET 8.0             |  0.0003 ns | 0.0014 ns | 0.0008 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET 8.0             |  0.0021 ns | 0.0051 ns | 0.0030 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET 8.0             |  0.0030 ns | 0.0048 ns | 0.0032 ns |  0.0024 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET Framework 4.6.2 |  0.1180 ns | 0.0249 ns | 0.0165 ns |  0.1168 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET Framework 4.6.2 |  9.2354 ns | 0.0444 ns | 0.0293 ns |  9.2412 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0001 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET Framework 4.6.2 |  0.0085 ns | 0.0138 ns | 0.0108 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET Framework 4.6.2 |  1.5165 ns | 0.0367 ns | 0.0218 ns |  1.5084 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET Framework 4.6.2 | 10.7270 ns | 0.0582 ns | 0.0385 ns | 10.7268 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET Framework 4.6.2 |  1.4011 ns | 0.0174 ns | 0.0115 ns |  1.4045 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET Framework 4.6.2 |  1.4137 ns | 0.0162 ns | 0.0107 ns |  1.4125 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET Framework 4.6.2 |  1.2990 ns | 0.0414 ns | 0.0274 ns |  1.2984 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET Framework 4.6.2 |  1.2479 ns | 0.0247 ns | 0.0164 ns |  1.2422 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET Framework 4.6.2 |  1.3780 ns | 0.0219 ns | 0.0130 ns |  1.3773 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET Framework 4.6.2 |  1.2960 ns | 0.0372 ns | 0.0246 ns |  1.2922 ns |     ? |       ? |

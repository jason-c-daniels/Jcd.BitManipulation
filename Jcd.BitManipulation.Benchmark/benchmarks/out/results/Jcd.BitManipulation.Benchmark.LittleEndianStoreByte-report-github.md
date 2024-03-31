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
| ByteIndexer_From_A_Double   | .NET 8.0             |  0.0044 ns | 0.0091 ns | 0.0054 ns |  0.0027 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET 8.0             |  0.0025 ns | 0.0054 ns | 0.0036 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET 8.0             |  0.0011 ns | 0.0021 ns | 0.0014 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET 8.0             |  0.0020 ns | 0.0043 ns | 0.0028 ns |  0.0006 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET 8.0             |  0.0030 ns | 0.0056 ns | 0.0037 ns |  0.0016 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET 8.0             |  0.0003 ns | 0.0014 ns | 0.0008 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET 8.0             |  0.0038 ns | 0.0083 ns | 0.0055 ns |  0.0015 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET 8.0             |  0.0208 ns | 0.0099 ns | 0.0059 ns |  0.0224 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET 8.0             |  0.0012 ns | 0.0035 ns | 0.0023 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET 8.0             |  0.0007 ns | 0.0024 ns | 0.0016 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET 8.0             |  0.0106 ns | 0.0121 ns | 0.0080 ns |  0.0103 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET 8.0             |  0.0010 ns | 0.0028 ns | 0.0019 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET 8.0             |  0.0034 ns | 0.0084 ns | 0.0055 ns |  0.0009 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET Framework 4.6.2 |  1.3292 ns | 0.0226 ns | 0.0134 ns |  1.3260 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET Framework 4.6.2 | 10.8497 ns | 0.1141 ns | 0.0679 ns | 10.8641 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET Framework 4.6.2 |  1.2762 ns | 0.0181 ns | 0.0120 ns |  1.2755 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET Framework 4.6.2 |  1.2955 ns | 0.0097 ns | 0.0058 ns |  1.2955 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET Framework 4.6.2 |  1.2881 ns | 0.0127 ns | 0.0084 ns |  1.2904 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET Framework 4.6.2 |  1.2867 ns | 0.0176 ns | 0.0117 ns |  1.2901 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET Framework 4.6.2 |  1.4469 ns | 0.0443 ns | 0.0263 ns |  1.4493 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET Framework 4.6.2 |  1.4170 ns | 0.0185 ns | 0.0122 ns |  1.4191 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET Framework 4.6.2 |  0.0616 ns | 0.0244 ns | 0.0217 ns |  0.0655 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET Framework 4.6.2 |  9.2432 ns | 0.1946 ns | 0.1625 ns |  9.1649 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET Framework 4.6.2 |  0.0036 ns | 0.0109 ns | 0.0072 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET Framework 4.6.2 |  0.0230 ns | 0.0233 ns | 0.0206 ns |  0.0189 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET Framework 4.6.2 |  0.0008 ns | 0.0026 ns | 0.0023 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET Framework 4.6.2 |  0.0046 ns | 0.0096 ns | 0.0090 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |

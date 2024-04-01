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

| Method                      | Runtime              |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |
|-----------------------------|----------------------|----------:|----------:|----------:|----------:|------:|--------:|
| ExtensionMethod_On_A_Double | .NET 8.0             | 0.0148 ns | 0.0226 ns | 0.0211 ns | 0.0039 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET 8.0             | 0.0041 ns | 0.0109 ns | 0.0072 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET 8.0             | 0.0167 ns | 0.0208 ns | 0.0195 ns | 0.0081 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET 8.0             | 0.0029 ns | 0.0085 ns | 0.0056 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET 8.0             | 0.0024 ns | 0.0054 ns | 0.0036 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET 8.0             | 0.0095 ns | 0.0190 ns | 0.0148 ns | 0.0005 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET 8.0             | 0.0069 ns | 0.0123 ns | 0.0096 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET 8.0             | 0.1539 ns | 0.1041 ns | 0.0870 ns | 0.1612 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET 8.0             | 0.0033 ns | 0.0094 ns | 0.0088 ns | 0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET 8.0             | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET 8.0             | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET 8.0             | 0.0432 ns | 0.0552 ns | 0.0490 ns | 0.0355 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET 8.0             | 0.0004 ns | 0.0018 ns | 0.0012 ns | 0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET 8.0             | 0.0277 ns | 0.0432 ns | 0.0404 ns | 0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET 8.0             | 0.0276 ns | 0.0328 ns | 0.0291 ns | 0.0166 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET 8.0             | 0.0021 ns | 0.0086 ns | 0.0051 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET Framework 4.6.2 | 0.1468 ns | 0.0491 ns | 0.0459 ns | 0.1468 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET Framework 4.6.2 | 9.9143 ns | 0.3252 ns | 0.2716 ns | 9.9114 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET Framework 4.6.2 | 0.0114 ns | 0.0225 ns | 0.0200 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET Framework 4.6.2 | 0.0038 ns | 0.0104 ns | 0.0097 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET Framework 4.6.2 | 0.0005 ns | 0.0022 ns | 0.0016 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET Framework 4.6.2 | 0.0082 ns | 0.0152 ns | 0.0143 ns | 0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET Framework 4.6.2 | 1.8062 ns | 0.1894 ns | 0.1772 ns | 1.7770 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET Framework 4.6.2 | 6.0732 ns | 0.5674 ns | 0.5307 ns | 5.8556 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET Framework 4.6.2 | 1.8354 ns | 0.3595 ns | 0.3363 ns | 1.8364 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET Framework 4.6.2 | 1.4641 ns | 0.0506 ns | 0.0301 ns | 1.4737 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET Framework 4.6.2 | 1.4241 ns | 0.2132 ns | 0.1994 ns | 1.3239 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET Framework 4.6.2 | 1.3965 ns | 0.1211 ns | 0.1133 ns | 1.3449 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET Framework 4.6.2 | 1.4457 ns | 0.0849 ns | 0.0794 ns | 1.4461 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET Framework 4.6.2 | 1.5133 ns | 0.0330 ns | 0.0218 ns | 1.5134 ns |     ? |       ? |

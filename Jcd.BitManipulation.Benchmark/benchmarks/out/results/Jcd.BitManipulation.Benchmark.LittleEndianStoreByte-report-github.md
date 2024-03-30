```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-UWWGLV : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-IXAHBT : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                      | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|-----------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| ByteIndexer_From_A_Double   | .NET 8.0             |  0.0109 ns | 0.0211 ns | 0.0153 ns |  0.0062 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET 8.0             |  0.0006 ns | 0.0019 ns | 0.0011 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET 8.0             |  0.0005 ns | 0.0024 ns | 0.0016 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET 8.0             |  0.0180 ns | 0.0208 ns | 0.0137 ns |  0.0145 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET 8.0             |  0.0002 ns | 0.0008 ns | 0.0005 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET 8.0             |  0.0079 ns | 0.0177 ns | 0.0117 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET 8.0             |  0.0118 ns | 0.0217 ns | 0.0157 ns |  0.0079 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET 8.0             |  0.0023 ns | 0.0082 ns | 0.0049 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET 8.0             |  0.0098 ns | 0.0154 ns | 0.0136 ns |  0.0005 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET 8.0             |  0.0425 ns | 0.0489 ns | 0.0434 ns |  0.0272 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET 8.0             |  0.0058 ns | 0.0071 ns | 0.0042 ns |  0.0078 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET 8.0             |  0.0082 ns | 0.0162 ns | 0.0096 ns |  0.0066 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET 8.0             |  0.0053 ns | 0.0089 ns | 0.0059 ns |  0.0033 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET 8.0             |  0.0052 ns | 0.0136 ns | 0.0106 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET Framework 4.6.2 |  1.3059 ns | 0.0139 ns | 0.0073 ns |  1.3072 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET Framework 4.6.2 | 11.1776 ns | 0.5918 ns | 0.5246 ns | 11.1233 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET Framework 4.6.2 |  1.2125 ns | 0.0459 ns | 0.0303 ns |  1.2036 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET Framework 4.6.2 |  1.2971 ns | 0.0472 ns | 0.0394 ns |  1.2954 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET Framework 4.6.2 |  1.3702 ns | 0.0956 ns | 0.0894 ns |  1.3853 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET Framework 4.6.2 |  1.2833 ns | 0.0444 ns | 0.0294 ns |  1.2821 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET Framework 4.6.2 |  1.5183 ns | 0.1229 ns | 0.1149 ns |  1.4638 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET Framework 4.6.2 |  1.4040 ns | 0.0577 ns | 0.0482 ns |  1.4018 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET Framework 4.6.2 |  0.0257 ns | 0.0203 ns | 0.0147 ns |  0.0258 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET Framework 4.6.2 |  9.3002 ns | 0.1883 ns | 0.1245 ns |  9.2807 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET Framework 4.6.2 |  0.0056 ns | 0.0106 ns | 0.0099 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET Framework 4.6.2 |  0.0004 ns | 0.0018 ns | 0.0017 ns |  0.0000 ns |     ? |       ? |

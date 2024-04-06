```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-CXBWXK : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-SUYWZE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                      | Runtime              |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |
|-----------------------------|----------------------|----------:|----------:|----------:|----------:|------:|--------:|
| ByteIndexer_From_A_Double   | .NET 8.0             | 0.0011 ns | 0.0035 ns | 0.0023 ns | 0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET 8.0             | 0.0108 ns | 0.0210 ns | 0.0125 ns | 0.0078 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET 8.0             | 0.0015 ns | 0.0046 ns | 0.0027 ns | 0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET 8.0             | 0.0012 ns | 0.0052 ns | 0.0031 ns | 0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET 8.0             | 0.0089 ns | 0.0105 ns | 0.0069 ns | 0.0108 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET 8.0             | 0.0092 ns | 0.0157 ns | 0.0147 ns | 0.0013 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET 8.0             | 0.0106 ns | 0.0155 ns | 0.0121 ns | 0.0062 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET 8.0             | 0.0104 ns | 0.0179 ns | 0.0167 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET 8.0             | 0.0122 ns | 0.0152 ns | 0.0080 ns | 0.0130 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET 8.0             | 0.0114 ns | 0.0151 ns | 0.0126 ns | 0.0103 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET 8.0             | 0.0068 ns | 0.0163 ns | 0.0108 ns | 0.0028 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET 8.0             | 0.0001 ns | 0.0005 ns | 0.0003 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET 8.0             | 0.0066 ns | 0.0158 ns | 0.0114 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET 8.0             | 0.0108 ns | 0.0184 ns | 0.0143 ns | 0.0025 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET 8.0             | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET 8.0             | 0.0111 ns | 0.0184 ns | 0.0122 ns | 0.0064 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET Framework 4.6.2 | 1.3302 ns | 0.0660 ns | 0.0618 ns | 1.3208 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET Framework 4.6.2 | 5.0836 ns | 0.1136 ns | 0.0676 ns | 5.0579 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET Framework 4.6.2 | 1.4094 ns | 0.0502 ns | 0.0445 ns | 1.4125 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET Framework 4.6.2 | 1.2745 ns | 0.0432 ns | 0.0285 ns | 1.2650 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET Framework 4.6.2 | 1.3346 ns | 0.0479 ns | 0.0448 ns | 1.3217 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET Framework 4.6.2 | 1.2762 ns | 0.0285 ns | 0.0188 ns | 1.2780 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET Framework 4.6.2 | 1.4440 ns | 0.0340 ns | 0.0202 ns | 1.4403 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET Framework 4.6.2 | 1.4432 ns | 0.0511 ns | 0.0399 ns | 1.4499 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET Framework 4.6.2 | 0.0005 ns | 0.0027 ns | 0.0014 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET Framework 4.6.2 | 9.2840 ns | 0.1419 ns | 0.0939 ns | 9.2761 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET Framework 4.6.2 | 0.0139 ns | 0.0244 ns | 0.0228 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET Framework 4.6.2 | 0.0274 ns | 0.0329 ns | 0.0308 ns | 0.0234 ns |     ? |       ? |

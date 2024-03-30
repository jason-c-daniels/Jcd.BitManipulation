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
| ExtensionMethod_On_A_Double | .NET 8.0             |  0.0398 ns | 0.0860 ns | 0.0762 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET 8.0             |  0.0218 ns | 0.0306 ns | 0.0272 ns |  0.0052 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET 8.0             |  0.0079 ns | 0.0121 ns | 0.0080 ns |  0.0081 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET 8.0             |  0.0212 ns | 0.0291 ns | 0.0272 ns |  0.0036 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET 8.0             |  0.0023 ns | 0.0098 ns | 0.0087 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET 8.0             |  0.0193 ns | 0.0257 ns | 0.0170 ns |  0.0170 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET 8.0             |  0.0065 ns | 0.0159 ns | 0.0133 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET 8.0             |  0.0021 ns | 0.0102 ns | 0.0061 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET 8.0             |  0.0036 ns | 0.0112 ns | 0.0100 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET 8.0             |  0.0057 ns | 0.0125 ns | 0.0082 ns |  0.0007 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET 8.0             |  0.0079 ns | 0.0203 ns | 0.0134 ns |  0.0001 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET 8.0             |  0.0372 ns | 0.0365 ns | 0.0342 ns |  0.0275 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET 8.0             |  0.0021 ns | 0.0049 ns | 0.0032 ns |  0.0007 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET Framework 4.6.2 |  0.1135 ns | 0.0429 ns | 0.0380 ns |  0.1092 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET Framework 4.6.2 |  9.2061 ns | 0.0676 ns | 0.0402 ns |  9.2067 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET Framework 4.6.2 |  0.0218 ns | 0.0336 ns | 0.0298 ns |  0.0058 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET Framework 4.6.2 |  0.1036 ns | 0.0960 ns | 0.0898 ns |  0.0634 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET Framework 4.6.2 |  0.0056 ns | 0.0127 ns | 0.0119 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET Framework 4.6.2 |  0.0002 ns | 0.0009 ns | 0.0008 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET Framework 4.6.2 |  1.5883 ns | 0.1219 ns | 0.1140 ns |  1.5333 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET Framework 4.6.2 | 10.6638 ns | 0.1308 ns | 0.0778 ns | 10.6269 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET Framework 4.6.2 |  1.4587 ns | 0.0619 ns | 0.0579 ns |  1.4485 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET Framework 4.6.2 |  1.4294 ns | 0.0254 ns | 0.0168 ns |  1.4269 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET Framework 4.6.2 |  1.3261 ns | 0.0664 ns | 0.0622 ns |  1.2997 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET Framework 4.6.2 |  1.3330 ns | 0.0639 ns | 0.0533 ns |  1.3386 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET Framework 4.6.2 |  1.4466 ns | 0.0619 ns | 0.0579 ns |  1.4594 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET Framework 4.6.2 |  1.2803 ns | 0.0395 ns | 0.0235 ns |  1.2868 ns |     ? |       ? |

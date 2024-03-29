```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ZHKFEE : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-PRZSWO : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| ExtensionMethod_Double | .NET 8.0             |  0.0101 ns | 0.0163 ns | 0.0118 ns |  0.0052 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.1625 ns | 0.0794 ns | 0.0743 ns |  0.1559 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Float  | .NET 8.0             |  0.0032 ns | 0.0091 ns | 0.0054 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.1410 ns | 0.0671 ns | 0.0399 ns |  9.1659 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0141 ns | 0.0179 ns | 0.0118 ns |  0.0131 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0007 ns | 0.0032 ns | 0.0026 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0244 ns | 0.0264 ns | 0.0247 ns |  0.0138 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0020 ns | 0.0064 ns | 0.0043 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0080 ns | 0.0186 ns | 0.0174 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0077 ns | 0.0159 ns | 0.0133 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Double     | .NET 8.0             |  0.0075 ns | 0.0144 ns | 0.0135 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.6040 ns | 0.1850 ns | 0.1640 ns |  1.5712 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Float      | .NET 8.0             |  0.0054 ns | 0.0094 ns | 0.0088 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 10.9354 ns | 0.2530 ns | 0.2366 ns | 10.9249 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0276 ns | 0.0462 ns | 0.0433 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.4289 ns | 0.0408 ns | 0.0270 ns |  1.4217 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int64      | .NET 8.0             |  0.0011 ns | 0.0055 ns | 0.0033 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.4238 ns | 0.0285 ns | 0.0188 ns |  1.4241 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.3299 ns | 0.0591 ns | 0.0553 ns |  1.3237 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int32      | .NET 8.0             |  0.0249 ns | 0.0312 ns | 0.0292 ns |  0.0272 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.3030 ns | 0.0706 ns | 0.0625 ns |  1.2859 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0018 ns | 0.0064 ns | 0.0042 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.3921 ns | 0.0469 ns | 0.0391 ns |  1.3855 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int16      | .NET 8.0             |  0.0073 ns | 0.0150 ns | 0.0140 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.2931 ns | 0.0463 ns | 0.0275 ns |  1.2822 ns |     ? |       ? |

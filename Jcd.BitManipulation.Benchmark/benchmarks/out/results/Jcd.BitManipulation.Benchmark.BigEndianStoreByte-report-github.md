```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ROROES : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-CCUDDK : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| ExtensionMethod_Double | .NET 8.0             |  0.0018 ns | 0.0053 ns | 0.0035 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.1055 ns | 0.0260 ns | 0.0244 ns |  0.0927 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Float  | .NET 8.0             |  3.3962 ns | 0.0911 ns | 0.0602 ns |  3.3862 ns |  1.00 |    0.00 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.0104 ns | 0.1416 ns | 0.0843 ns |  8.9882 ns |  2.66 |    0.05 |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0018 ns | 0.0036 ns | 0.0022 ns |  0.0007 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0139 ns | 0.0303 ns | 0.0253 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0008 ns | 0.0038 ns | 0.0025 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.0002 ns | 0.0011 ns | 0.0007 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0138 ns | 0.0141 ns | 0.0093 ns |  0.0161 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0006 ns | 0.0019 ns | 0.0018 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int32  | .NET 8.0             |  0.3032 ns | 0.2973 ns | 0.2781 ns |  0.2100 ns |  1.00 |    0.00 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0083 ns | 0.0190 ns | 0.0177 ns |  0.0000 ns |  0.18 |    0.42 |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Double     | .NET 8.0             |  0.0202 ns | 0.0262 ns | 0.0245 ns |  0.0181 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.5166 ns | 0.0522 ns | 0.0436 ns |  1.5041 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Float      | .NET 8.0             |  3.7688 ns | 0.4883 ns | 0.4568 ns |  3.5350 ns |  1.00 |    0.00 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 12.0133 ns | 0.5473 ns | 0.5119 ns | 11.9184 ns |  3.23 |    0.37 |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.3932 ns | 0.0486 ns | 0.0289 ns |  1.4085 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int64      | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.4659 ns | 0.0378 ns | 0.0225 ns |  1.4577 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0139 ns | 0.0200 ns | 0.0119 ns |  0.0129 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.2581 ns | 0.0478 ns | 0.0424 ns |  1.2434 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int32      | .NET 8.0             |  0.0027 ns | 0.0087 ns | 0.0063 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.2805 ns | 0.0484 ns | 0.0253 ns |  1.2759 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0030 ns | 0.0076 ns | 0.0050 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.3961 ns | 0.0404 ns | 0.0268 ns |  1.3887 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int16      | .NET 8.0             |  0.0176 ns | 0.0211 ns | 0.0187 ns |  0.0156 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.2807 ns | 0.0318 ns | 0.0189 ns |  1.2890 ns |     ? |       ? |

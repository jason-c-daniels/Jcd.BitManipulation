```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-WBOMYL : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-YFPBER : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median |     Ratio |  RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|----------:|---------:|
| ExtensionMethod_Double | .NET 8.0             |  0.0044 ns | 0.0065 ns | 0.0039 ns |  0.0038 ns |         ? |        ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.0933 ns | 0.0220 ns | 0.0146 ns |  0.0857 ns |         ? |        ? |
|                        |                      |            |           |           |            |           |          |
| ExtensionMethod_Float  | .NET 8.0             |  0.0014 ns | 0.0035 ns | 0.0023 ns |  0.0000 ns |         ? |        ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.1560 ns | 0.0221 ns | 0.0146 ns |  9.1608 ns |         ? |        ? |
|                        |                      |            |           |           |            |           |          |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0088 ns | 0.0194 ns | 0.0115 ns |  0.0047 ns |         ? |        ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |         ? |        ? |
|                        |                      |            |           |           |            |           |          |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0025 ns | 0.0028 ns | 0.0019 ns |  0.0028 ns |         ? |        ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |         ? |        ? |
|                        |                      |            |           |           |            |           |          |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0032 ns | 0.0049 ns | 0.0032 ns |  0.0028 ns |         ? |        ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |         ? |        ? |
|                        |                      |            |           |           |            |           |          |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0004 ns | 0.0017 ns | 0.0012 ns |  0.0000 ns |         ? |        ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |         ? |        ? |
|                        |                      |            |           |           |            |           |          |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0018 ns | 0.0037 ns | 0.0025 ns |  0.0008 ns |         ? |        ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |         ? |        ? |
|                        |                      |            |           |           |            |           |          |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0134 ns | 0.0112 ns | 0.0074 ns |  0.0138 ns |     1.000 |     0.00 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     0.000 |     0.00 |
|                        |                      |            |           |           |            |           |          |
| ByteIndexer_Double     | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |         ? |        ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.5070 ns | 0.0173 ns | 0.0115 ns |  1.5058 ns |         ? |        ? |
|                        |                      |            |           |           |            |           |          |
| ByteIndexer_Float      | .NET 8.0             |  0.0017 ns | 0.0023 ns | 0.0013 ns |  0.0012 ns |      1.00 |     0.00 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 10.7619 ns | 0.1042 ns | 0.0689 ns | 10.7469 ns | 10,874.84 | 8,645.73 |
|                        |                      |            |           |           |            |           |          |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0668 ns | 0.0680 ns | 0.0636 ns |  0.0324 ns |         ? |        ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.4179 ns | 0.0231 ns | 0.0153 ns |  1.4247 ns |         ? |        ? |
|                        |                      |            |           |           |            |           |          |
| ByteIndexer_Int64      | .NET 8.0             |  0.0017 ns | 0.0042 ns | 0.0028 ns |  0.0000 ns |         ? |        ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.4065 ns | 0.0187 ns | 0.0112 ns |  1.4085 ns |         ? |        ? |
|                        |                      |            |           |           |            |           |          |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0124 ns | 0.0194 ns | 0.0101 ns |  0.0084 ns |      1.00 |     0.00 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.2542 ns | 0.0478 ns | 0.0316 ns |  1.2667 ns |    384.66 |   725.23 |
|                        |                      |            |           |           |            |           |          |
| ByteIndexer_Int32      | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |         ? |        ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.2485 ns | 0.0249 ns | 0.0148 ns |  1.2553 ns |         ? |        ? |
|                        |                      |            |           |           |            |           |          |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0020 ns | 0.0042 ns | 0.0028 ns |  0.0000 ns |         ? |        ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.3938 ns | 0.0155 ns | 0.0092 ns |  1.3955 ns |         ? |        ? |
|                        |                      |            |           |           |            |           |          |
| ByteIndexer_Int16      | .NET 8.0             |  0.0003 ns | 0.0016 ns | 0.0010 ns |  0.0000 ns |         ? |        ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.3154 ns | 0.0338 ns | 0.0201 ns |  1.3096 ns |         ? |        ? |

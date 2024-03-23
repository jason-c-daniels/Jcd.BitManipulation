```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-JSAIVR : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-PHWTJI : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| ExtensionMethod_Double | .NET 8.0             |  0.0196 ns | 0.0319 ns | 0.0283 ns |  0.0074 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.0913 ns | 0.0143 ns | 0.0085 ns |  0.0929 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Float  | .NET 8.0             |  3.8618 ns | 0.0427 ns | 0.0282 ns |  3.8640 ns |  1.00 |    0.00 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.9783 ns | 0.0544 ns | 0.0360 ns |  9.9840 ns |  2.58 |    0.02 |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0025 ns | 0.0051 ns | 0.0034 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0034 ns | 0.0055 ns | 0.0033 ns |  0.0035 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0021 ns | 0.0062 ns | 0.0041 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0018 ns | 0.0043 ns | 0.0028 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0005 ns | 0.0015 ns | 0.0009 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0127 ns | 0.0147 ns | 0.0097 ns |  0.0116 ns | 1.000 |    0.00 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns | 0.000 |    0.00 |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Double     | .NET 8.0             |  0.0046 ns | 0.0065 ns | 0.0043 ns |  0.0032 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.5287 ns | 0.0178 ns | 0.0117 ns |  1.5263 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Float      | .NET 8.0             |  3.8931 ns | 0.0764 ns | 0.0506 ns |  3.8915 ns |  1.00 |    0.00 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 12.2307 ns | 0.1094 ns | 0.0724 ns | 12.2049 ns |  3.14 |    0.05 |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.6674 ns | 0.0191 ns | 0.0126 ns |  1.6636 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int64      | .NET 8.0             |  0.0044 ns | 0.0106 ns | 0.0070 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.6776 ns | 0.0354 ns | 0.0234 ns |  1.6777 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0057 ns | 0.0129 ns | 0.0077 ns |  0.0037 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.5199 ns | 0.0241 ns | 0.0126 ns |  1.5172 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int32      | .NET 8.0             |  0.0012 ns | 0.0034 ns | 0.0023 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.5018 ns | 0.0439 ns | 0.0290 ns |  1.5033 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0043 ns | 0.0071 ns | 0.0047 ns |  0.0024 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.6646 ns | 0.0152 ns | 0.0090 ns |  1.6656 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int16      | .NET 8.0             |  0.0004 ns | 0.0017 ns | 0.0011 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.6877 ns | 0.0436 ns | 0.0288 ns |  1.6908 ns |     ? |       ? |

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

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median |  Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|-------:|--------:|
| ExtensionMethod_Double | .NET 8.0             |  0.0016 ns | 0.0032 ns | 0.0021 ns |  0.0008 ns |      ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.0384 ns | 0.0127 ns | 0.0084 ns |  0.0355 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ExtensionMethod_Float  | .NET 8.0             |  3.8122 ns | 0.0363 ns | 0.0240 ns |  3.8185 ns |   1.00 |    0.00 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.9369 ns | 0.1112 ns | 0.0736 ns |  9.9349 ns |   2.61 |    0.03 |
|                        |                      |            |           |           |            |        |         |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0008 ns | 0.0024 ns | 0.0016 ns |  0.0000 ns |      ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0001 ns | 0.0006 ns | 0.0004 ns |  0.0000 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0004 ns | 0.0013 ns | 0.0009 ns |  0.0000 ns |      ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0008 ns | 0.0018 ns | 0.0011 ns |  0.0003 ns |      ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0017 ns | 0.0056 ns | 0.0037 ns |  0.0000 ns |      ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0126 ns | 0.0052 ns | 0.0034 ns |  0.0135 ns |   1.00 |    0.00 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0003 ns | 0.0011 ns | 0.0010 ns |  0.0000 ns |   0.03 |    0.08 |
|                        |                      |            |           |           |            |        |         |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0035 ns | 0.0100 ns | 0.0072 ns |  0.0000 ns |      ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ByteIndexer_Double     | .NET 8.0             |  0.0035 ns | 0.0058 ns | 0.0039 ns |  0.0015 ns |      ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.2859 ns | 0.0221 ns | 0.0146 ns |  1.2843 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ByteIndexer_Float      | .NET 8.0             |  3.8344 ns | 0.0265 ns | 0.0158 ns |  3.8274 ns |   1.00 |    0.00 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 12.0496 ns | 0.1555 ns | 0.1028 ns | 12.0739 ns |   3.15 |    0.02 |
|                        |                      |            |           |           |            |        |         |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.4771 ns | 0.0179 ns | 0.0107 ns |  1.4750 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ByteIndexer_Int64      | .NET 8.0             |  0.0028 ns | 0.0059 ns | 0.0031 ns |  0.0020 ns |      ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.4904 ns | 0.0209 ns | 0.0138 ns |  1.4922 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0001 ns | 0.0004 ns | 0.0003 ns |  0.0000 ns |      ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.7703 ns | 0.0286 ns | 0.0170 ns |  1.7715 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ByteIndexer_Int32      | .NET 8.0             |  0.0020 ns | 0.0049 ns | 0.0032 ns |  0.0000 ns |      ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.7548 ns | 0.0443 ns | 0.0293 ns |  1.7492 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0057 ns | 0.0066 ns | 0.0043 ns |  0.0054 ns |   1.00 |    0.00 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.5988 ns | 0.0206 ns | 0.0136 ns |  1.5995 ns | 502.79 |  394.03 |
|                        |                      |            |           |           |            |        |         |
| ByteIndexer_Int16      | .NET 8.0             |  0.0015 ns | 0.0031 ns | 0.0016 ns |  0.0009 ns |      ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.6272 ns | 0.0490 ns | 0.0324 ns |  1.6393 ns |      ? |       ? |

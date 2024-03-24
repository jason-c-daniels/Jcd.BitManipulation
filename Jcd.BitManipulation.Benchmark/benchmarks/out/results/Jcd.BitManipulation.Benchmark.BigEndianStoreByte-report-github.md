```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-BDWZRX : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-WYRMBM : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median |  Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|-------:|--------:|
| ExtensionMethod_Double | .NET 8.0             |  0.0010 ns | 0.0033 ns | 0.0020 ns |  0.0000 ns |      ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.0942 ns | 0.0122 ns | 0.0064 ns |  0.0959 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ExtensionMethod_Float  | .NET 8.0             |  3.7923 ns | 0.0250 ns | 0.0165 ns |  3.7862 ns |   1.00 |    0.00 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.2932 ns | 0.0459 ns | 0.0303 ns |  9.2970 ns |   2.45 |    0.01 |
|                        |                      |            |           |           |            |        |         |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0005 ns | 0.0022 ns | 0.0013 ns |  0.0000 ns |      ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0014 ns | 0.0037 ns | 0.0024 ns |  0.0000 ns |      ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0014 ns | 0.0035 ns | 0.0021 ns |  0.0000 ns |      ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0029 ns | 0.0055 ns | 0.0037 ns |  0.0013 ns |      ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0049 ns | 0.0045 ns | 0.0030 ns |  0.0046 ns |  1.000 |    0.00 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
|                        |                      |            |           |           |            |        |         |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0007 ns | 0.0019 ns | 0.0011 ns |  0.0001 ns |      ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0027 ns | 0.0056 ns | 0.0037 ns |  0.0004 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ByteIndexer_Double     | .NET 8.0             |  0.0045 ns | 0.0108 ns | 0.0071 ns |  0.0000 ns |      ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.5110 ns | 0.0218 ns | 0.0130 ns |  1.5133 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ByteIndexer_Float      | .NET 8.0             |  4.4890 ns | 0.1094 ns | 0.0724 ns |  4.4738 ns |   1.00 |    0.00 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 11.6964 ns | 0.1479 ns | 0.0978 ns | 11.6706 ns |   2.61 |    0.04 |
|                        |                      |            |           |           |            |        |         |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0046 ns | 0.0159 ns | 0.0149 ns |  0.0000 ns |      ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.4315 ns | 0.0155 ns | 0.0102 ns |  1.4301 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ByteIndexer_Int64      | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.4212 ns | 0.0174 ns | 0.0103 ns |  1.4212 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0118 ns | 0.0095 ns | 0.0050 ns |  0.0143 ns |   1.00 |    0.00 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.2833 ns | 0.0221 ns | 0.0131 ns |  1.2818 ns | 144.39 |  100.19 |
|                        |                      |            |           |           |            |        |         |
| ByteIndexer_Int32      | .NET 8.0             |  0.0038 ns | 0.0082 ns | 0.0049 ns |  0.0009 ns |      ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.2599 ns | 0.0120 ns | 0.0080 ns |  1.2606 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0014 ns | 0.0025 ns | 0.0016 ns |  0.0007 ns |      ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.4273 ns | 0.0302 ns | 0.0200 ns |  1.4284 ns |      ? |       ? |
|                        |                      |            |           |           |            |        |         |
| ByteIndexer_Int16      | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |      ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.2974 ns | 0.0248 ns | 0.0164 ns |  1.2980 ns |      ? |       ? |

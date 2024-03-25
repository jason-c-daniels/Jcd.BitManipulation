```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-EEUGLS : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-HWBWFM : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| ExtensionMethod_Double | .NET 8.0             |  0.0021 ns | 0.0050 ns | 0.0033 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.1063 ns | 0.0214 ns | 0.0179 ns |  0.1081 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Float  | .NET 8.0             |  0.0007 ns | 0.0038 ns | 0.0022 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.1857 ns | 0.0721 ns | 0.0429 ns |  9.1857 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0007 ns | 0.0021 ns | 0.0014 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0046 ns | 0.0063 ns | 0.0037 ns |  0.0052 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0151 ns | 0.0214 ns | 0.0127 ns |  0.0131 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0022 ns | 0.0049 ns | 0.0029 ns |  0.0014 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0002 ns | 0.0013 ns | 0.0007 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0005 ns | 0.0016 ns | 0.0011 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Double     | .NET 8.0             |  0.0010 ns | 0.0025 ns | 0.0015 ns |  0.0007 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.5305 ns | 0.0242 ns | 0.0144 ns |  1.5250 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Float      | .NET 8.0             |  0.0007 ns | 0.0020 ns | 0.0013 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 10.6123 ns | 0.1003 ns | 0.0663 ns | 10.6185 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0007 ns | 0.0017 ns | 0.0012 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.4468 ns | 0.0187 ns | 0.0124 ns |  1.4437 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int64      | .NET 8.0             |  0.0033 ns | 0.0071 ns | 0.0047 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.4358 ns | 0.0153 ns | 0.0091 ns |  1.4393 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0029 ns | 0.0044 ns | 0.0029 ns |  0.0025 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.2997 ns | 0.0409 ns | 0.0214 ns |  1.3079 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int32      | .NET 8.0             |  0.0042 ns | 0.0073 ns | 0.0048 ns |  0.0028 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.4805 ns | 0.0808 ns | 0.0756 ns |  1.4944 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0020 ns | 0.0035 ns | 0.0023 ns |  0.0013 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.4236 ns | 0.0482 ns | 0.0319 ns |  1.4233 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int16      | .NET 8.0             |  0.0038 ns | 0.0095 ns | 0.0057 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.3092 ns | 0.0182 ns | 0.0120 ns |  1.3092 ns |     ? |       ? |

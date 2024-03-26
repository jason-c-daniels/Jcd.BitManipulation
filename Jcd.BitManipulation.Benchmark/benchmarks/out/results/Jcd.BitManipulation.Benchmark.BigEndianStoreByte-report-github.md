```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ICMWHD : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-OXTARK : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| ExtensionMethod_Double | .NET 8.0             |  0.0225 ns | 0.0328 ns | 0.0306 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.1274 ns | 0.0258 ns | 0.0201 ns |  0.1344 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Float  | .NET 8.0             |  0.0132 ns | 0.0216 ns | 0.0202 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.2606 ns | 0.1422 ns | 0.0744 ns |  9.2856 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0063 ns | 0.0099 ns | 0.0052 ns |  0.0046 ns |  1.00 |    0.00 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0024 ns | 0.0086 ns | 0.0081 ns |  0.0000 ns |  0.66 |    1.23 |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0002 ns | 0.0011 ns | 0.0007 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0157 ns | 0.0198 ns | 0.0185 ns |  0.0095 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0007 ns | 0.0034 ns | 0.0022 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0355 ns | 0.0356 ns | 0.0333 ns |  0.0335 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0017 ns | 0.0068 ns | 0.0064 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Double     | .NET 8.0             |  0.0322 ns | 0.0425 ns | 0.0397 ns |  0.0140 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.5145 ns | 0.0334 ns | 0.0221 ns |  1.5111 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Float      | .NET 8.0             |  0.0039 ns | 0.0097 ns | 0.0064 ns |  0.0002 ns |     ? |       ? |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 10.6415 ns | 0.1971 ns | 0.1304 ns | 10.6613 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0033 ns | 0.0060 ns | 0.0056 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.4065 ns | 0.0468 ns | 0.0365 ns |  1.3970 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int64      | .NET 8.0             |  0.0310 ns | 0.0246 ns | 0.0218 ns |  0.0295 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.4430 ns | 0.0410 ns | 0.0244 ns |  1.4409 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0005 ns | 0.0014 ns | 0.0013 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.2598 ns | 0.0300 ns | 0.0179 ns |  1.2679 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int32      | .NET 8.0             |  0.0206 ns | 0.0261 ns | 0.0245 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.2574 ns | 0.0479 ns | 0.0317 ns |  1.2594 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0411 ns | 0.0293 ns | 0.0274 ns |  0.0416 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.3588 ns | 0.0436 ns | 0.0315 ns |  1.3708 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int16      | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.2757 ns | 0.0332 ns | 0.0220 ns |  1.2759 ns |     ? |       ? |

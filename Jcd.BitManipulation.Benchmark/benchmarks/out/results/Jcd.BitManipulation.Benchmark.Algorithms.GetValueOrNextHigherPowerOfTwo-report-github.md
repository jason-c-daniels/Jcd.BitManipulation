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

| Method                                    | Runtime              |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |
|-------------------------------------------|----------------------|----------:|----------:|----------:|----------:|------:|--------:|
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0280 ns | 0.0372 ns | 0.0348 ns | 0.0150 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0056 ns | 0.0114 ns | 0.0075 ns | 0.0011 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.4004 ns | 0.0462 ns | 0.0410 ns | 0.4006 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 1.5147 ns | 0.0492 ns | 0.0326 ns | 1.5094 ns |  3.82 |    0.37 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 1.1452 ns | 0.0574 ns | 0.0537 ns | 1.1457 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 1.7413 ns | 0.0473 ns | 0.0313 ns | 1.7405 ns |  1.52 |    0.08 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.3597 ns | 0.0363 ns | 0.0321 ns | 0.3575 ns |  1.00 |    0.00 |
| On_UInt32                                 | .NET Framework 4.6.2 | 1.1963 ns | 0.0463 ns | 0.0335 ns | 1.1829 ns |  3.38 |    0.27 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.7126 ns | 0.0384 ns | 0.0340 ns | 0.7083 ns |  1.00 |    0.00 |
| On_UInt64                                 | .NET Framework 4.6.2 | 4.4020 ns | 0.1619 ns | 0.1514 ns | 4.3903 ns |  6.20 |    0.46 |

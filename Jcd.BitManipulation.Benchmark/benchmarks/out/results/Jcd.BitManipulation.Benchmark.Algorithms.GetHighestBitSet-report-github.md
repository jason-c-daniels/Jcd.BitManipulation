```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-TVPDIM : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-APXAAL : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                                    | Runtime              |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |
|-------------------------------------------|----------------------|----------:|----------:|----------:|----------:|------:|--------:|
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0102 ns | 0.0172 ns | 0.0161 ns | 0.0000 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0249 ns | 0.0169 ns | 0.0112 ns | 0.0255 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.3136 ns | 0.0591 ns | 0.0524 ns | 0.2911 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 1.0565 ns | 0.0386 ns | 0.0279 ns | 1.0588 ns |  3.40 |    0.53 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.4327 ns | 0.0199 ns | 0.0131 ns | 0.4326 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 0.8672 ns | 0.0178 ns | 0.0093 ns | 0.8671 ns |  2.01 |    0.08 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.1338 ns | 0.0208 ns | 0.0138 ns | 0.1359 ns |  1.00 |    0.00 |
| On_UInt32                                 | .NET Framework 4.6.2 | 1.7594 ns | 0.0895 ns | 0.0699 ns | 1.7584 ns | 13.24 |    1.24 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.1437 ns | 0.0277 ns | 0.0216 ns | 0.1431 ns |  1.00 |    0.00 |
| On_UInt64                                 | .NET Framework 4.6.2 | 1.6678 ns | 0.1471 ns | 0.1376 ns | 1.6328 ns | 11.95 |    2.13 |

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
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0150 ns | 0.0178 ns | 0.0106 ns | 0.0143 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0107 ns | 0.0118 ns | 0.0062 ns | 0.0114 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.1605 ns | 0.0208 ns | 0.0137 ns | 0.1604 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 0.2178 ns | 0.0119 ns | 0.0071 ns | 0.2188 ns |  1.37 |    0.12 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.2642 ns | 0.0041 ns | 0.0021 ns | 0.2644 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 0.5099 ns | 0.0221 ns | 0.0146 ns | 0.5070 ns |  1.92 |    0.04 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.0032 ns | 0.0063 ns | 0.0038 ns | 0.0016 ns |     ? |       ? |
| On_UInt32                                 | .NET Framework 4.6.2 | 0.1525 ns | 0.0481 ns | 0.0427 ns | 0.1597 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.0030 ns | 0.0053 ns | 0.0035 ns | 0.0017 ns |     ? |       ? |
| On_UInt64                                 | .NET Framework 4.6.2 | 0.2081 ns | 0.0324 ns | 0.0303 ns | 0.2037 ns |     ? |       ? |

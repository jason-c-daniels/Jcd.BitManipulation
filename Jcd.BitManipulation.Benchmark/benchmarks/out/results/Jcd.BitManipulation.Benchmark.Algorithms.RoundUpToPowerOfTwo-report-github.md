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
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0064 ns | 0.0143 ns | 0.0120 ns | 0.0000 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0296 ns | 0.0212 ns | 0.0177 ns | 0.0267 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.2572 ns | 0.0366 ns | 0.0324 ns | 0.2620 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 0.9444 ns | 0.0575 ns | 0.0538 ns | 0.9464 ns |  3.72 |    0.49 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.7938 ns | 0.0399 ns | 0.0209 ns | 0.7873 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 1.5616 ns | 0.0444 ns | 0.0293 ns | 1.5666 ns |  1.97 |    0.07 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.7045 ns | 0.0521 ns | 0.0488 ns | 0.6862 ns |  1.00 |    0.00 |
| On_UInt32                                 | .NET Framework 4.6.2 | 0.7057 ns | 0.0245 ns | 0.0162 ns | 0.7097 ns |  1.00 |    0.07 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.1527 ns | 0.0490 ns | 0.0458 ns | 0.1466 ns |  1.00 |    0.00 |
| On_UInt64                                 | .NET Framework 4.6.2 | 0.3361 ns | 0.0202 ns | 0.0133 ns | 0.3378 ns |  2.36 |    0.67 |

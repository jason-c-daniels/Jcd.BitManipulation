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
| Method                                    | Runtime              | Mean      | Error     | StdDev    | Ratio | RatioSD |
|------------------------------------------ |--------------------- |----------:|----------:|----------:|------:|--------:|
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0279 ns | 0.0109 ns | 0.0072 ns |     ? |       ? |
|                                           |                      |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.4025 ns | 0.0639 ns | 0.0597 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 1.2963 ns | 0.0446 ns | 0.0322 ns |  3.19 |    0.45 |
|                                           |                      |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.5903 ns | 0.0297 ns | 0.0177 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 1.4123 ns | 0.0615 ns | 0.0575 ns |  2.42 |    0.11 |
|                                           |                      |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.2676 ns | 0.0604 ns | 0.0565 ns |  1.00 |    0.00 |
| On_UInt32                                 | .NET Framework 4.6.2 | 2.2402 ns | 0.0355 ns | 0.0186 ns |  8.15 |    1.78 |
|                                           |                      |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.5890 ns | 0.0785 ns | 0.0734 ns |  1.00 |    0.00 |
| On_UInt64                                 | .NET Framework 4.6.2 | 2.2356 ns | 0.0861 ns | 0.0805 ns |  3.84 |    0.38 |

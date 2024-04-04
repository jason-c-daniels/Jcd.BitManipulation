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
| Method                                    | Runtime              | Mean      | Error     | StdDev    | Ratio | RatioSD |
|------------------------------------------ |--------------------- |----------:|----------:|----------:|------:|--------:|
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0446 ns | 0.0258 ns | 0.0242 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.2734 ns | 0.0415 ns | 0.0388 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 1.2097 ns | 0.0247 ns | 0.0163 ns |  4.42 |    0.59 |
|                                           |                      |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.6270 ns | 0.0505 ns | 0.0448 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 1.6362 ns | 0.1394 ns | 0.1236 ns |  2.63 |    0.32 |
|                                           |                      |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.3697 ns | 0.0597 ns | 0.0499 ns |  1.00 |    0.00 |
| On_UInt32                                 | .NET Framework 4.6.2 | 2.2019 ns | 0.0819 ns | 0.0766 ns |  6.05 |    0.85 |
|                                           |                      |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.6450 ns | 0.1087 ns | 0.1016 ns |  1.00 |    0.00 |
| On_UInt64                                 | .NET Framework 4.6.2 | 2.1563 ns | 0.0614 ns | 0.0574 ns |  3.42 |    0.54 |

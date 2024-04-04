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
| Method                                    | Runtime              | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD |
|------------------------------------------ |--------------------- |----------:|----------:|----------:|----------:|------:|--------:|
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0125 ns | 0.0169 ns | 0.0132 ns | 0.0095 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0209 ns | 0.0321 ns | 0.0300 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.3590 ns | 0.0215 ns | 0.0142 ns | 0.3556 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 1.3769 ns | 0.0729 ns | 0.0682 ns | 1.3938 ns |  3.76 |    0.25 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.5701 ns | 0.0244 ns | 0.0161 ns | 0.5653 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 1.6192 ns | 0.0798 ns | 0.0746 ns | 1.6026 ns |  2.81 |    0.17 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.0068 ns | 0.0138 ns | 0.0116 ns | 0.0000 ns |     ? |       ? |
| On_UInt32                                 | .NET Framework 4.6.2 | 1.4806 ns | 0.0489 ns | 0.0433 ns | 1.4702 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.8035 ns | 0.0394 ns | 0.0349 ns | 0.7929 ns |  1.00 |    0.00 |
| On_UInt64                                 | .NET Framework 4.6.2 | 1.7424 ns | 0.0565 ns | 0.0472 ns | 1.7281 ns |  2.17 |    0.12 |
|                                           |                      |           |           |           |           |       |         |
| PopCount_SoftwareFallback_Byte            | .NET 8.0             | 0.5567 ns | 0.0265 ns | 0.0175 ns | 0.5581 ns |  1.00 |    0.00 |
| PopCount_SoftwareFallback_Byte            | .NET Framework 4.6.2 | 1.0957 ns | 0.0451 ns | 0.0352 ns | 1.0885 ns |  1.96 |    0.10 |
|                                           |                      |           |           |           |           |       |         |
| PopCount_SoftwareFallback_UInt16          | .NET 8.0             | 0.5567 ns | 0.0835 ns | 0.0781 ns | 0.5638 ns |  1.00 |    0.00 |
| PopCount_SoftwareFallback_UInt16          | .NET Framework 4.6.2 | 1.1213 ns | 0.0956 ns | 0.0847 ns | 1.0913 ns |  2.09 |    0.39 |
|                                           |                      |           |           |           |           |       |         |
| PopCount_SoftwareFallback_UInt32          | .NET 8.0             | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| PopCount_SoftwareFallback_UInt32          | .NET Framework 4.6.2 | 1.1637 ns | 0.1165 ns | 0.1090 ns | 1.1459 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| PopCount_SoftwareFallback_UInt64          | .NET 8.0             | 1.0104 ns | 0.0398 ns | 0.0237 ns | 1.0098 ns |  1.00 |    0.00 |
| PopCount_SoftwareFallback_UInt64          | .NET Framework 4.6.2 | 1.3186 ns | 0.0661 ns | 0.0619 ns | 1.3114 ns |  1.33 |    0.07 |

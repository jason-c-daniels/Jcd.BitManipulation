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
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0039 ns | 0.0114 ns | 0.0075 ns | 0.0000 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0505 ns | 0.0140 ns | 0.0083 ns | 0.0499 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.0849 ns | 0.0270 ns | 0.0211 ns | 0.0894 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 0.0693 ns | 0.0233 ns | 0.0154 ns | 0.0695 ns |  0.92 |    0.38 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.4733 ns | 0.0304 ns | 0.0201 ns | 0.4676 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 0.7030 ns | 0.0178 ns | 0.0106 ns | 0.7033 ns |  1.48 |    0.06 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.0028 ns | 0.0108 ns | 0.0064 ns | 0.0000 ns |     ? |       ? |
| On_UInt32                                 | .NET Framework 4.6.2 | 0.0416 ns | 0.0184 ns | 0.0096 ns | 0.0437 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.3426 ns | 0.0282 ns | 0.0168 ns | 0.3407 ns |  1.00 |    0.00 |
| On_UInt64                                 | .NET Framework 4.6.2 | 0.3274 ns | 0.0232 ns | 0.0154 ns | 0.3295 ns |  0.95 |    0.06 |
|                                           |                      |           |           |           |           |       |         |
| PopCount_SoftwareFallback_Byte            | .NET 8.0             | 0.0777 ns | 0.0187 ns | 0.0124 ns | 0.0764 ns |  1.00 |    0.00 |
| PopCount_SoftwareFallback_Byte            | .NET Framework 4.6.2 | 0.1168 ns | 0.0236 ns | 0.0171 ns | 0.1132 ns |  1.55 |    0.41 |
|                                           |                      |           |           |           |           |       |         |
| PopCount_SoftwareFallback_UInt16          | .NET 8.0             | 0.4474 ns | 0.0129 ns | 0.0068 ns | 0.4475 ns |  1.00 |    0.00 |
| PopCount_SoftwareFallback_UInt16          | .NET Framework 4.6.2 | 0.7884 ns | 0.0278 ns | 0.0232 ns | 0.7845 ns |  1.76 |    0.07 |
|                                           |                      |           |           |           |           |       |         |
| PopCount_SoftwareFallback_UInt32          | .NET 8.0             | 0.0058 ns | 0.0127 ns | 0.0075 ns | 0.0000 ns |     ? |       ? |
| PopCount_SoftwareFallback_UInt32          | .NET Framework 4.6.2 | 0.1044 ns | 0.0293 ns | 0.0274 ns | 0.1026 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| PopCount_SoftwareFallback_UInt64          | .NET 8.0             | 0.3527 ns | 0.0323 ns | 0.0214 ns | 0.3563 ns |  1.00 |    0.00 |
| PopCount_SoftwareFallback_UInt64          | .NET Framework 4.6.2 | 0.2996 ns | 0.0202 ns | 0.0133 ns | 0.2984 ns |  0.85 |    0.07 |

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
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0097 ns | 0.0194 ns | 0.0181 ns | 0.0000 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0243 ns | 0.0196 ns | 0.0184 ns | 0.0255 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.3455 ns | 0.0264 ns | 0.0157 ns | 0.3481 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 1.0217 ns | 0.0417 ns | 0.0301 ns | 1.0247 ns |  2.97 |    0.08 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.4613 ns | 0.0179 ns | 0.0118 ns | 0.4605 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 1.2428 ns | 0.0837 ns | 0.0742 ns | 1.2438 ns |  2.67 |    0.12 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.3641 ns | 0.0582 ns | 0.0544 ns | 0.3588 ns |  1.00 |    0.00 |
| On_UInt32                                 | .NET Framework 4.6.2 | 2.1166 ns | 0.1137 ns | 0.1008 ns | 2.1245 ns |  5.93 |    0.86 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.3796 ns | 0.0507 ns | 0.0474 ns | 0.3783 ns |  1.00 |    0.00 |
| On_UInt64                                 | .NET Framework 4.6.2 | 2.4985 ns | 0.0668 ns | 0.0442 ns | 2.4969 ns |  6.56 |    0.68 |

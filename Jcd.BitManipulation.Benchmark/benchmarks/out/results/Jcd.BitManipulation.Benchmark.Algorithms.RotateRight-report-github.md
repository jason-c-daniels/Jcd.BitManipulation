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
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0021 ns | 0.0078 ns | 0.0046 ns | 0.0000 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.1223 ns | 0.0118 ns | 0.0078 ns | 0.1217 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 0.6201 ns | 0.0344 ns | 0.0287 ns | 0.6324 ns |  5.05 |    0.35 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.1154 ns | 0.0269 ns | 0.0238 ns | 0.1075 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 0.5829 ns | 0.0527 ns | 0.0493 ns | 0.5688 ns |  5.19 |    1.08 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.0072 ns | 0.0142 ns | 0.0126 ns | 0.0000 ns |     ? |       ? |
| On_UInt32                                 | .NET Framework 4.6.2 | 0.5887 ns | 0.0256 ns | 0.0169 ns | 0.5853 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| On_UInt64                                 | .NET Framework 4.6.2 | 0.5341 ns | 0.0159 ns | 0.0095 ns | 0.5323 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BitOperations_On_UInt32                   | .NET 8.0             | 0.0020 ns | 0.0091 ns | 0.0054 ns | 0.0000 ns |     ? |       ? |
| BitOperations_On_UInt32                   | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BitOperations_On_UInt64                   | .NET 8.0             | 0.0097 ns | 0.0174 ns | 0.0126 ns | 0.0028 ns |     ? |       ? |
| BitOperations_On_UInt64                   | .NET Framework 4.6.2 | 0.0120 ns | 0.0136 ns | 0.0090 ns | 0.0126 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_Byte                           | .NET 8.0             | 0.0439 ns | 0.0350 ns | 0.0327 ns | 0.0451 ns |     ? |       ? |
| BuiltIn_On_Byte                           | .NET Framework 4.6.2 | 0.0368 ns | 0.0095 ns | 0.0057 ns | 0.0366 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt32                         | .NET 8.0             | 0.0062 ns | 0.0103 ns | 0.0096 ns | 0.0000 ns |     ? |       ? |
| BuiltIn_On_UInt32                         | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt64                         | .NET 8.0             | 0.0249 ns | 0.0405 ns | 0.0379 ns | 0.0014 ns |     ? |       ? |
| BuiltIn_On_UInt64                         | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |

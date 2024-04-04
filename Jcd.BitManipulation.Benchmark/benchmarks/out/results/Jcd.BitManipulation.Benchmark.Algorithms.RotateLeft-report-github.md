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
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0212 ns | 0.0150 ns | 0.0099 ns | 0.0244 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| On_Byte                                   | .NET Framework 4.6.2 | 0.6183 ns | 0.0482 ns | 0.0451 ns | 0.6053 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.1378 ns | 0.0665 ns | 0.0590 ns | 0.1071 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 0.5966 ns | 0.0321 ns | 0.0232 ns | 0.6094 ns |  5.46 |    1.51 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.0055 ns | 0.0122 ns | 0.0115 ns | 0.0000 ns |     ? |       ? |
| On_UInt32                                 | .NET Framework 4.6.2 | 0.6033 ns | 0.0369 ns | 0.0345 ns | 0.5929 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.0121 ns | 0.0187 ns | 0.0124 ns | 0.0072 ns |     ? |       ? |
| On_UInt64                                 | .NET Framework 4.6.2 | 0.5688 ns | 0.0402 ns | 0.0356 ns | 0.5627 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BitOperations_On_UInt32                   | .NET 8.0             | 0.0113 ns | 0.0195 ns | 0.0129 ns | 0.0072 ns |     ? |       ? |
| BitOperations_On_UInt32                   | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BitOperations_On_UInt64                   | .NET 8.0             | 0.0442 ns | 0.0485 ns | 0.0453 ns | 0.0422 ns |     ? |       ? |
| BitOperations_On_UInt64                   | .NET Framework 4.6.2 | 0.0031 ns | 0.0066 ns | 0.0051 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_Byte                           | .NET 8.0             | 0.0133 ns | 0.0193 ns | 0.0181 ns | 0.0054 ns |     ? |       ? |
| BuiltIn_On_Byte                           | .NET Framework 4.6.2 | 0.0361 ns | 0.0225 ns | 0.0175 ns | 0.0349 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt16                         | .NET 8.0             | 0.0294 ns | 0.0276 ns | 0.0258 ns | 0.0262 ns |     ? |       ? |
| BuiltIn_On_UInt16                         | .NET Framework 4.6.2 | 0.0220 ns | 0.0191 ns | 0.0127 ns | 0.0255 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt32                         | .NET 8.0             | 0.0054 ns | 0.0141 ns | 0.0132 ns | 0.0000 ns |     ? |       ? |
| BuiltIn_On_UInt32                         | .NET Framework 4.6.2 | 0.0009 ns | 0.0038 ns | 0.0032 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt64                         | .NET 8.0             | 0.0586 ns | 0.0454 ns | 0.0425 ns | 0.0471 ns |     ? |       ? |
| BuiltIn_On_UInt64                         | .NET Framework 4.6.2 | 0.0013 ns | 0.0036 ns | 0.0034 ns | 0.0000 ns |     ? |       ? |

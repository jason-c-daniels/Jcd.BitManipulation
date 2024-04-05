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
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0960 ns | 0.0430 ns | 0.0402 ns |  1.00 |    0.00 |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0215 ns | 0.0190 ns | 0.0137 ns |  0.28 |    0.32 |
|                                           |                      |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.4353 ns | 0.0270 ns | 0.0160 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 1.1316 ns | 0.0415 ns | 0.0324 ns |  2.60 |    0.12 |
|                                           |                      |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.4564 ns | 0.0372 ns | 0.0310 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 1.1139 ns | 0.0505 ns | 0.0473 ns |  2.46 |    0.20 |
|                                           |                      |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.4456 ns | 0.0335 ns | 0.0262 ns |  1.00 |    0.00 |
| On_UInt32                                 | .NET Framework 4.6.2 | 1.3002 ns | 0.0291 ns | 0.0193 ns |  2.96 |    0.18 |
|                                           |                      |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.4591 ns | 0.0324 ns | 0.0234 ns |  1.00 |    0.00 |
| On_UInt64                                 | .NET Framework 4.6.2 | 0.8951 ns | 0.0394 ns | 0.0261 ns |  1.96 |    0.09 |

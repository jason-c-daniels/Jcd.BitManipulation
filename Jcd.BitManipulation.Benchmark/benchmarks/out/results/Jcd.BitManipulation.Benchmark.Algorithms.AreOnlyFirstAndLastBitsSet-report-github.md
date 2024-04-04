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
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0164 ns | 0.0245 ns | 0.0229 ns | 0.0000 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0183 ns | 0.0237 ns | 0.0157 ns | 0.0178 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.4273 ns | 0.0601 ns | 0.0563 ns | 0.4492 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 1.1485 ns | 0.0393 ns | 0.0307 ns | 1.1451 ns |  2.78 |    0.46 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.5694 ns | 0.0607 ns | 0.0507 ns | 0.5697 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 0.9063 ns | 0.0413 ns | 0.0366 ns | 0.8986 ns |  1.60 |    0.15 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.3469 ns | 0.0288 ns | 0.0150 ns | 0.3493 ns |  1.00 |    0.00 |
| On_UInt32                                 | .NET Framework 4.6.2 | 1.2981 ns | 0.0359 ns | 0.0214 ns | 1.2975 ns |  3.76 |    0.18 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.4544 ns | 0.0266 ns | 0.0158 ns | 0.4473 ns |  1.00 |    0.00 |
| On_UInt64                                 | .NET Framework 4.6.2 | 0.9209 ns | 0.0267 ns | 0.0177 ns | 0.9180 ns |  2.03 |    0.07 |

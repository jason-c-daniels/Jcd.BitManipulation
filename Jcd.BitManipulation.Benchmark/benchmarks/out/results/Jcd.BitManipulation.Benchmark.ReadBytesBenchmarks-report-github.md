```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-OVGSJN : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-WIAADE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxIterationCount=11  MinIterationCount=9  WarmupCount=1  

```

| Method                                   | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| ReadAllBytesOnUInt64AsLittleEndian       | .NET 8.0             |  6.224 ns | 0.1858 ns | 0.1106 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsLittleEndian       | .NET Framework 4.6.2 | 10.351 ns | 0.1496 ns | 0.0783 ns |  1.66 |    0.04 |
|                                          |                      |           |           |           |       |         |
| ReadAllBytesOnUInt64AsBigEndian          | .NET 8.0             |  6.247 ns | 0.1248 ns | 0.0653 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsBigEndian          | .NET Framework 4.6.2 |  7.849 ns | 0.3906 ns | 0.2583 ns |  1.26 |    0.05 |
|                                          |                      |           |           |           |       |         |
| ReadFirstFourBytesOnUInt64AsLittleEndian | .NET 8.0             |  7.120 ns | 0.1497 ns | 0.0891 ns |  1.00 |    0.00 |
| ReadFirstFourBytesOnUInt64AsLittleEndian | .NET Framework 4.6.2 |  8.381 ns | 0.0806 ns | 0.0480 ns |  1.18 |    0.01 |
|                                          |                      |           |           |           |       |         |
| ReadFirstFourBytesOnUInt64AsBigEndian    | .NET 8.0             |  6.888 ns | 0.1643 ns | 0.0978 ns |  1.00 |    0.00 |
| ReadFirstFourBytesOnUInt64AsBigEndian    | .NET Framework 4.6.2 |  8.728 ns | 0.0947 ns | 0.0564 ns |  1.27 |    0.02 |

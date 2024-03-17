```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ELVBXX : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-JTSSOE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxIterationCount=20  MinIterationCount=19  WarmupCount=5  

```

| Method                                   | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| ReadAllBytesOnUInt64AsLittleEndian       | .NET 8.0             | 5.665 ns | 0.0681 ns | 0.0729 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsLittleEndian       | .NET Framework 4.6.2 | 9.936 ns | 0.0523 ns | 0.0581 ns |  1.76 |    0.02 |
|                                          |                      |          |           |           |       |         |
| ReadAllBytesOnUInt64AsBigEndian          | .NET 8.0             | 7.014 ns | 0.0975 ns | 0.1084 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsBigEndian          | .NET Framework 4.6.2 | 9.999 ns | 0.1252 ns | 0.1286 ns |  1.43 |    0.02 |
|                                          |                      |          |           |           |       |         |
| ReadFirstFourBytesOnUInt64AsLittleEndian | .NET 8.0             | 4.731 ns | 0.0454 ns | 0.0466 ns |  1.00 |    0.00 |
| ReadFirstFourBytesOnUInt64AsLittleEndian | .NET Framework 4.6.2 | 6.895 ns | 0.0262 ns | 0.0281 ns |  1.46 |    0.01 |
|                                          |                      |          |           |           |       |         |
| ReadFirstFourBytesOnUInt64AsBigEndian    | .NET 8.0             | 5.446 ns | 0.0774 ns | 0.0860 ns |  1.00 |    0.00 |
| ReadFirstFourBytesOnUInt64AsBigEndian    | .NET Framework 4.6.2 | 6.243 ns | 0.1092 ns | 0.1213 ns |  1.15 |    0.03 |

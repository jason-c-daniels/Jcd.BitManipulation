```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-LCJARL : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ZMUTJG : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxIterationCount=11  MinIterationCount=9  WarmupCount=1  

```

| Method                                   | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| ReadAllBytesOnUInt64AsLittleEndian       | .NET 8.0             | 4.949 ns | 0.0847 ns | 0.0504 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsLittleEndian       | .NET Framework 4.6.2 | 6.979 ns | 0.0871 ns | 0.0455 ns |  1.41 |    0.01 |
|                                          |                      |          |           |           |       |         |
| ReadAllBytesOnUInt64AsBigEndian          | .NET 8.0             | 5.247 ns | 0.1427 ns | 0.1032 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsBigEndian          | .NET Framework 4.6.2 | 6.812 ns | 0.1320 ns | 0.0691 ns |  1.29 |    0.03 |
|                                          |                      |          |           |           |       |         |
| ReadFirstFourBytesOnUInt64AsLittleEndian | .NET 8.0             | 5.078 ns | 0.1484 ns | 0.0883 ns |  1.00 |    0.00 |
| ReadFirstFourBytesOnUInt64AsLittleEndian | .NET Framework 4.6.2 | 7.367 ns | 0.0960 ns | 0.0502 ns |  1.45 |    0.03 |
|                                          |                      |          |           |           |       |         |
| ReadFirstFourBytesOnUInt64AsBigEndian    | .NET 8.0             | 4.953 ns | 0.1080 ns | 0.0565 ns |  1.00 |    0.00 |
| ReadFirstFourBytesOnUInt64AsBigEndian    | .NET Framework 4.6.2 | 7.060 ns | 0.1009 ns | 0.0528 ns |  1.43 |    0.02 |

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-TNOGMU : .NET 6.0.28 (6.0.2824.12007), X64 RyuJIT AVX2
  Job-CBTDLV : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-TPLPRL : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256
  Job-VWKDTN : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxIterationCount=11  MinIterationCount=9  WarmupCount=1  

```

| Method                                   | Runtime              |      Mean |      Error |    StdDev | Ratio | RatioSD |
|------------------------------------------|----------------------|----------:|-----------:|----------:|------:|--------:|
| ReadAllBytesOnUInt64AsLittleEndian       | .NET 6.0             | 13.471 ns |  0.7170 ns | 0.5184 ns |  1.87 |    0.11 |
| ReadAllBytesOnUInt64AsLittleEndian       | .NET 8.0             |  7.158 ns |  0.4615 ns | 0.2746 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsLittleEndian       | .NET Framework 4.6.2 | 31.608 ns | 11.0890 ns | 8.0181 ns |  4.24 |    1.24 |
| ReadAllBytesOnUInt64AsLittleEndian       | .NET Framework 4.8.1 | 21.722 ns |  1.6298 ns | 1.1784 ns |  3.07 |    0.18 |
|                                          |                      |           |            |           |       |         |
| ReadAllBytesOnUInt64AsBigEndian          | .NET 6.0             | 12.369 ns |  1.3579 ns | 0.9818 ns |  1.39 |    0.16 |
| ReadAllBytesOnUInt64AsBigEndian          | .NET 8.0             |  8.965 ns |  0.5988 ns | 0.3960 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsBigEndian          | .NET Framework 4.6.2 | 21.434 ns |  1.2368 ns | 0.8181 ns |  2.39 |    0.12 |
| ReadAllBytesOnUInt64AsBigEndian          | .NET Framework 4.8.1 | 21.914 ns |  1.4530 ns | 1.0506 ns |  2.45 |    0.20 |
|                                          |                      |           |            |           |       |         |
| ReadFirstFourBytesOnUInt64AsLittleEndian | .NET 6.0             |  8.634 ns |  0.4300 ns | 0.2844 ns |  1.38 |    0.11 |
| ReadFirstFourBytesOnUInt64AsLittleEndian | .NET 8.0             |  6.263 ns |  0.6146 ns | 0.4444 ns |  1.00 |    0.00 |
| ReadFirstFourBytesOnUInt64AsLittleEndian | .NET Framework 4.6.2 | 11.709 ns |  0.8357 ns | 0.6043 ns |  1.88 |    0.17 |
| ReadFirstFourBytesOnUInt64AsLittleEndian | .NET Framework 4.8.1 | 13.206 ns |  1.1531 ns | 0.8338 ns |  2.12 |    0.21 |
|                                          |                      |           |            |           |       |         |
| ReadFirstFourBytesOnUInt64AsBigEndian    | .NET 6.0             |  7.574 ns |  0.2576 ns | 0.1533 ns |  0.98 |    0.04 |
| ReadFirstFourBytesOnUInt64AsBigEndian    | .NET 8.0             |  7.798 ns |  0.6291 ns | 0.4161 ns |  1.00 |    0.00 |
| ReadFirstFourBytesOnUInt64AsBigEndian    | .NET Framework 4.6.2 | 12.589 ns |  1.0362 ns | 0.7492 ns |  1.61 |    0.14 |
| ReadFirstFourBytesOnUInt64AsBigEndian    | .NET Framework 4.8.1 | 13.119 ns |  1.0139 ns | 0.7331 ns |  1.67 |    0.10 |

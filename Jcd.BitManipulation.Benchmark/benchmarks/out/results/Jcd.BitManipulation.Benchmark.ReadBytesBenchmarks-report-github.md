```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-PRQUSQ : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-DUKUCV : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxIterationCount=11  MinIterationCount=9  WarmupCount=1  

```

| Method                                   | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| ReadAllBytesOnUInt64AsLittleEndian       | .NET 8.0             |  7.699 ns | 0.3653 ns | 0.2641 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsLittleEndian       | .NET Framework 4.6.2 | 10.923 ns | 0.4722 ns | 0.3414 ns |  1.42 |    0.04 |
|                                          |                      |           |           |           |       |         |
| ReadAllBytesOnUInt64AsBigEndian          | .NET 8.0             |  9.308 ns | 0.6558 ns | 0.4338 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsBigEndian          | .NET Framework 4.6.2 | 11.288 ns | 0.5361 ns | 0.3877 ns |  1.21 |    0.08 |
|                                          |                      |           |           |           |       |         |
| ReadFirstFourBytesOnUInt64AsLittleEndian | .NET 8.0             |  5.618 ns | 0.3820 ns | 0.2762 ns |  1.00 |    0.00 |
| ReadFirstFourBytesOnUInt64AsLittleEndian | .NET Framework 4.6.2 |  8.391 ns | 0.8859 ns | 0.6406 ns |  1.50 |    0.13 |
|                                          |                      |           |           |           |       |         |
| ReadFirstFourBytesOnUInt64AsBigEndian    | .NET 8.0             |  6.967 ns | 0.2188 ns | 0.1447 ns |  1.00 |    0.00 |
| ReadFirstFourBytesOnUInt64AsBigEndian    | .NET Framework 4.6.2 |  6.781 ns | 0.1699 ns | 0.0888 ns |  0.97 |    0.02 |

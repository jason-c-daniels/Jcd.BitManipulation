```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ELVBXX : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-JTSSOE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxIterationCount=20  MinIterationCount=19  WarmupCount=5  

```

| Method                                       | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|----------------------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| ReadAllBytesOnUInt64AsNativeEndian           | .NET 8.0             |  3.701 ns | 0.4319 ns | 0.4974 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsNativeEndian           | .NET Framework 4.6.2 |  3.863 ns | 0.0399 ns | 0.0427 ns |  1.04 |    0.13 |
|                                              |                      |           |           |           |       |         |
| ReadAllBytesOnUInt64AsNativeEndianAndReverse | .NET 8.0             |  4.385 ns | 0.0918 ns | 0.1020 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsNativeEndianAndReverse | .NET Framework 4.6.2 | 25.290 ns | 0.0853 ns | 0.0876 ns |  5.77 |    0.13 |

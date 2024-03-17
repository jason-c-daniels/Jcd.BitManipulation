```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-LCJARL : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ZMUTJG : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxIterationCount=11  MinIterationCount=9  WarmupCount=1  

```

| Method                                       | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|----------------------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| ReadAllBytesOnUInt64AsNativeEndian           | .NET 8.0             |  3.197 ns | 0.1621 ns | 0.1172 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsNativeEndian           | .NET Framework 4.6.2 |  3.866 ns | 0.0454 ns | 0.0270 ns |  1.20 |    0.04 |
|                                              |                      |           |           |           |       |         |
| ReadAllBytesOnUInt64AsNativeEndianAndReverse | .NET 8.0             |  4.289 ns | 0.0766 ns | 0.0340 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsNativeEndianAndReverse | .NET Framework 4.6.2 | 25.136 ns | 0.1864 ns | 0.0975 ns |  5.86 |    0.06 |

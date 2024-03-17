```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-OVGSJN : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-WIAADE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxIterationCount=11  MinIterationCount=9  WarmupCount=1  

```

| Method                                       | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|----------------------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| ReadAllBytesOnUInt64AsNativeEndian           | .NET 8.0             |  3.227 ns | 0.1449 ns | 0.1047 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsNativeEndian           | .NET Framework 4.6.2 |  3.848 ns | 0.0313 ns | 0.0164 ns |  1.18 |    0.04 |
|                                              |                      |           |           |           |       |         |
| ReadAllBytesOnUInt64AsNativeEndianAndReverse | .NET 8.0             |  4.384 ns | 0.1261 ns | 0.0834 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsNativeEndianAndReverse | .NET Framework 4.6.2 | 26.033 ns | 0.6299 ns | 0.4555 ns |  5.94 |    0.16 |

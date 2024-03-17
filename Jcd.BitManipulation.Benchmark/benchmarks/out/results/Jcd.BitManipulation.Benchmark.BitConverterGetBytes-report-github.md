```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-XZEASL : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-HXBFPP : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxIterationCount=11  MinIterationCount=10  WarmupCount=10

```

| Method                                       | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|----------------------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| ReadAllBytesOnUInt64AsNativeEndian           | .NET 8.0             |  3.216 ns | 0.0924 ns | 0.0611 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsNativeEndian           | .NET Framework 4.6.2 |  3.844 ns | 0.0367 ns | 0.0242 ns |  1.20 |    0.02 |
|                                              |                      |           |           |           |       |         |
| ReadAllBytesOnUInt64AsNativeEndianAndReverse | .NET 8.0             |  4.287 ns | 0.0653 ns | 0.0432 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsNativeEndianAndReverse | .NET Framework 4.6.2 | 25.221 ns | 0.2555 ns | 0.1690 ns |  5.88 |    0.07 |

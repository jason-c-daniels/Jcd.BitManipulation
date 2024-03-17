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

| Method                                       | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|----------------------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| ReadAllBytesOnUInt64AsNativeEndian           | .NET 6.0             |  3.418 ns | 0.4863 ns | 0.3516 ns |  0.76 |    0.08 |
| ReadAllBytesOnUInt64AsNativeEndian           | .NET 8.0             |  4.453 ns | 0.2027 ns | 0.1206 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsNativeEndian           | .NET Framework 4.6.2 |  4.767 ns | 0.2558 ns | 0.1850 ns |  1.07 |    0.06 |
| ReadAllBytesOnUInt64AsNativeEndian           | .NET Framework 4.8.1 |  4.744 ns | 0.1659 ns | 0.1097 ns |  1.07 |    0.04 |
|                                              |                      |           |           |           |       |         |
| ReadAllBytesOnUInt64AsNativeEndianAndReverse | .NET 6.0             |  6.425 ns | 0.6804 ns | 0.4919 ns |  1.07 |    0.12 |
| ReadAllBytesOnUInt64AsNativeEndianAndReverse | .NET 8.0             |  6.076 ns | 0.8666 ns | 0.5157 ns |  1.00 |    0.00 |
| ReadAllBytesOnUInt64AsNativeEndianAndReverse | .NET Framework 4.6.2 | 31.131 ns | 2.6801 ns | 1.9379 ns |  5.15 |    0.72 |
| ReadAllBytesOnUInt64AsNativeEndianAndReverse | .NET Framework 4.8.1 | 29.717 ns | 1.1116 ns | 0.7353 ns |  4.93 |    0.47 |

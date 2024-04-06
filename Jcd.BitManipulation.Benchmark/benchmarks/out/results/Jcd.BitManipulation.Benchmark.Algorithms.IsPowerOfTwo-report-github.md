```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-TVPDIM : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-APXAAL : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                                    | Runtime              |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |
|-------------------------------------------|----------------------|----------:|----------:|----------:|----------:|------:|--------:|
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0035 ns | 0.0095 ns | 0.0063 ns | 0.0000 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.2199 ns | 0.2169 ns | 0.2029 ns | 0.2002 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.2037 ns | 0.0374 ns | 0.0350 ns | 0.1976 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 0.2121 ns | 0.0276 ns | 0.0259 ns | 0.2028 ns |  1.07 |    0.24 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.3057 ns | 0.0399 ns | 0.0354 ns | 0.3076 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 0.6076 ns | 0.0740 ns | 0.0692 ns | 0.6277 ns |  1.99 |    0.27 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.0362 ns | 0.0339 ns | 0.0317 ns | 0.0467 ns |     ? |       ? |
| On_UInt32                                 | .NET Framework 4.6.2 | 0.2129 ns | 0.0231 ns | 0.0137 ns | 0.2146 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.0112 ns | 0.0206 ns | 0.0161 ns | 0.0009 ns |     ? |       ? |
| On_UInt64                                 | .NET Framework 4.6.2 | 0.2136 ns | 0.0200 ns | 0.0132 ns | 0.2117 ns |     ? |       ? |

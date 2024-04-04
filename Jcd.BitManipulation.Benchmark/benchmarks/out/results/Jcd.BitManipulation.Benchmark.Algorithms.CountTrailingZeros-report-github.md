```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-CXBWXK : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-SUYWZE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```
| Method                                    | Runtime              | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD |
|------------------------------------------ |--------------------- |----------:|----------:|----------:|----------:|------:|--------:|
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0268 ns | 0.0297 ns | 0.0278 ns | 0.0242 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0410 ns | 0.0220 ns | 0.0171 ns | 0.0419 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.2806 ns | 0.0295 ns | 0.0213 ns | 0.2830 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 1.5733 ns | 0.0840 ns | 0.0786 ns | 1.5620 ns |  5.63 |    0.54 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.3015 ns | 0.0101 ns | 0.0067 ns | 0.3024 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 1.5826 ns | 0.0488 ns | 0.0381 ns | 1.5801 ns |  5.27 |    0.13 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.3328 ns | 0.0237 ns | 0.0141 ns | 0.3312 ns |  1.00 |    0.00 |
| On_UInt32                                 | .NET Framework 4.6.2 | 2.0997 ns | 0.2337 ns | 0.1951 ns | 2.0656 ns |  6.57 |    0.65 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.4378 ns | 0.0342 ns | 0.0226 ns | 0.4345 ns |  1.00 |    0.00 |
| On_UInt64                                 | .NET Framework 4.6.2 | 2.2243 ns | 0.0866 ns | 0.0768 ns | 2.2196 ns |  5.08 |    0.21 |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_Byte                           | .NET 8.0             | 0.1360 ns | 0.0100 ns | 0.0059 ns | 0.1351 ns |  1.00 |    0.00 |
| BuiltIn_On_Byte                           | .NET Framework 4.6.2 | 0.0308 ns | 0.0301 ns | 0.0281 ns | 0.0312 ns |  0.27 |    0.21 |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt16                         | .NET 8.0             | 0.1376 ns | 0.0209 ns | 0.0138 ns | 0.1345 ns |  1.00 |    0.00 |
| BuiltIn_On_UInt16                         | .NET Framework 4.6.2 | 0.0071 ns | 0.0167 ns | 0.0088 ns | 0.0039 ns |  0.05 |    0.06 |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt32                         | .NET 8.0             | 0.0004 ns | 0.0022 ns | 0.0013 ns | 0.0000 ns |     ? |       ? |
| BuiltIn_On_UInt32                         | .NET Framework 4.6.2 | 0.0269 ns | 0.0183 ns | 0.0121 ns | 0.0297 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt64                         | .NET 8.0             | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| BuiltIn_On_UInt64                         | .NET Framework 4.6.2 | 0.0085 ns | 0.0157 ns | 0.0147 ns | 0.0000 ns |     ? |       ? |

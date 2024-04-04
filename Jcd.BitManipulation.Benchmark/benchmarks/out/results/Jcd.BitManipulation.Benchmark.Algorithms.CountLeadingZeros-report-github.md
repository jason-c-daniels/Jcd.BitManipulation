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
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0402 ns | 0.0401 ns | 0.0375 ns | 0.0280 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0238 ns | 0.0221 ns | 0.0160 ns | 0.0278 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.1879 ns | 0.0457 ns | 0.0428 ns | 0.1783 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 1.3358 ns | 0.0314 ns | 0.0187 ns | 1.3283 ns |  8.26 |    1.70 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.6265 ns | 0.0410 ns | 0.0384 ns | 0.6156 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 1.4923 ns | 0.0485 ns | 0.0351 ns | 1.4968 ns |  2.36 |    0.15 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.0166 ns | 0.0202 ns | 0.0179 ns | 0.0155 ns |     ? |       ? |
| On_UInt32                                 | .NET Framework 4.6.2 | 1.3410 ns | 0.1464 ns | 0.1298 ns | 1.3200 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.2577 ns | 0.0302 ns | 0.0180 ns | 0.2582 ns |  1.00 |    0.00 |
| On_UInt64                                 | .NET Framework 4.6.2 | 1.3386 ns | 0.0535 ns | 0.0474 ns | 1.3513 ns |  5.21 |    0.38 |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_Byte                           | .NET 8.0             | 0.0117 ns | 0.0201 ns | 0.0178 ns | 0.0000 ns |     ? |       ? |
| BuiltIn_On_Byte                           | .NET Framework 4.6.2 | 0.0002 ns | 0.0011 ns | 0.0009 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt16                         | .NET 8.0             | 0.0235 ns | 0.0225 ns | 0.0175 ns | 0.0216 ns |     ? |       ? |
| BuiltIn_On_UInt16                         | .NET Framework 4.6.2 | 0.0184 ns | 0.0323 ns | 0.0302 ns | 0.0003 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt32                         | .NET 8.0             | 0.1468 ns | 0.2219 ns | 0.2076 ns | 0.0522 ns |     ? |       ? |
| BuiltIn_On_UInt32                         | .NET Framework 4.6.2 | 0.0384 ns | 0.0420 ns | 0.0393 ns | 0.0295 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt64                         | .NET 8.0             | 0.0002 ns | 0.0008 ns | 0.0006 ns | 0.0000 ns |     ? |       ? |
| BuiltIn_On_UInt64                         | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |

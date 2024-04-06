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
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0004 ns | 0.0015 ns | 0.0010 ns | 0.0000 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0491 ns | 0.0130 ns | 0.0068 ns | 0.0512 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.3921 ns | 0.0321 ns | 0.0191 ns | 0.3835 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 1.4215 ns | 0.0539 ns | 0.0504 ns | 1.4217 ns |  3.65 |    0.25 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.3405 ns | 0.0297 ns | 0.0215 ns | 0.3385 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 1.7063 ns | 0.0504 ns | 0.0300 ns | 1.7117 ns |  5.00 |    0.40 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.3937 ns | 0.0318 ns | 0.0248 ns | 0.3880 ns |  1.00 |    0.00 |
| On_UInt32                                 | .NET Framework 4.6.2 | 2.1463 ns | 0.1607 ns | 0.1424 ns | 2.0942 ns |  5.47 |    0.50 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.4604 ns | 0.0334 ns | 0.0296 ns | 0.4523 ns |  1.00 |    0.00 |
| On_UInt64                                 | .NET Framework 4.6.2 | 2.1977 ns | 0.0666 ns | 0.0623 ns | 2.2070 ns |  4.80 |    0.31 |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_Byte                           | .NET 8.0             | 0.1466 ns | 0.0225 ns | 0.0118 ns | 0.1483 ns |  1.00 |    0.00 |
| BuiltIn_On_Byte                           | .NET Framework 4.6.2 | 0.0033 ns | 0.0082 ns | 0.0054 ns | 0.0000 ns |  0.03 |    0.04 |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt16                         | .NET 8.0             | 0.1294 ns | 0.0087 ns | 0.0045 ns | 0.1307 ns | 1.000 |    0.00 |
| BuiltIn_On_UInt16                         | .NET Framework 4.6.2 | 0.0007 ns | 0.0033 ns | 0.0022 ns | 0.0000 ns | 0.006 |    0.02 |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt32                         | .NET 8.0             | 0.0111 ns | 0.0214 ns | 0.0142 ns | 0.0059 ns |     ? |       ? |
| BuiltIn_On_UInt32                         | .NET Framework 4.6.2 | 0.0473 ns | 0.0429 ns | 0.0402 ns | 0.0399 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt64                         | .NET 8.0             | 0.0035 ns | 0.0097 ns | 0.0058 ns | 0.0000 ns |     ? |       ? |
| BuiltIn_On_UInt64                         | .NET Framework 4.6.2 | 0.0504 ns | 0.0826 ns | 0.0773 ns | 0.0000 ns |     ? |       ? |

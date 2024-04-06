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
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0266 ns | 0.0118 ns | 0.0078 ns | 0.0290 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.1804 ns | 0.0208 ns | 0.0124 ns | 0.1857 ns |  1.00 |    0.00 |
| On_Byte                                   | .NET Framework 4.6.2 | 1.3767 ns | 0.0484 ns | 0.0378 ns | 1.3799 ns |  7.75 |    0.57 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.4250 ns | 0.0284 ns | 0.0188 ns | 0.4209 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 1.0694 ns | 0.0609 ns | 0.0569 ns | 1.0656 ns |  2.53 |    0.20 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.2909 ns | 0.0456 ns | 0.0426 ns | 0.2650 ns |  1.00 |    0.00 |
| On_UInt32                                 | .NET Framework 4.6.2 | 1.3188 ns | 0.1100 ns | 0.0975 ns | 1.3069 ns |  4.59 |    0.68 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.2937 ns | 0.0443 ns | 0.0393 ns | 0.2915 ns |  1.00 |    0.00 |
| On_UInt64                                 | .NET Framework 4.6.2 | 1.4241 ns | 0.0516 ns | 0.0270 ns | 1.4305 ns |  4.89 |    0.45 |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_Byte                           | .NET 8.0             | 0.0328 ns | 0.0330 ns | 0.0308 ns | 0.0262 ns |     ? |       ? |
| BuiltIn_On_Byte                           | .NET Framework 4.6.2 | 0.0182 ns | 0.0262 ns | 0.0232 ns | 0.0085 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt16                         | .NET 8.0             | 0.0247 ns | 0.0474 ns | 0.0420 ns | 0.0000 ns |     ? |       ? |
| BuiltIn_On_UInt16                         | .NET Framework 4.6.2 | 0.0100 ns | 0.0172 ns | 0.0114 ns | 0.0073 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt32                         | .NET 8.0             | 0.0113 ns | 0.0217 ns | 0.0181 ns | 0.0000 ns |     ? |       ? |
| BuiltIn_On_UInt32                         | .NET Framework 4.6.2 | 0.0230 ns | 0.0151 ns | 0.0100 ns | 0.0243 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt64                         | .NET 8.0             | 0.0285 ns | 0.0364 ns | 0.0341 ns | 0.0119 ns |     ? |       ? |
| BuiltIn_On_UInt64                         | .NET Framework 4.6.2 | 0.0003 ns | 0.0018 ns | 0.0010 ns | 0.0000 ns |     ? |       ? |

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
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0297 ns | 0.0256 ns | 0.0239 ns | 0.0283 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.0007 ns | 0.0035 ns | 0.0021 ns | 0.0000 ns |     ? |       ? |
| On_Byte                                   | .NET Framework 4.6.2 | 0.0105 ns | 0.0178 ns | 0.0167 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.0939 ns | 0.0246 ns | 0.0163 ns | 0.0919 ns |  1.00 |    0.00 |
| On_UInt16                                 | .NET Framework 4.6.2 | 0.5023 ns | 0.0206 ns | 0.0123 ns | 0.5058 ns |  5.57 |    0.94 |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.0212 ns | 0.0249 ns | 0.0220 ns | 0.0143 ns |     ? |       ? |
| On_UInt32                                 | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.0116 ns | 0.0163 ns | 0.0108 ns | 0.0089 ns |     ? |       ? |
| On_UInt64                                 | .NET Framework 4.6.2 | 0.0181 ns | 0.0296 ns | 0.0276 ns | 0.0004 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BitOperations_On_UInt32                   | .NET 8.0             | 0.0081 ns | 0.0153 ns | 0.0128 ns | 0.0000 ns |     ? |       ? |
| BitOperations_On_UInt32                   | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BitOperations_On_UInt64                   | .NET 8.0             | 0.0154 ns | 0.0211 ns | 0.0176 ns | 0.0066 ns |     ? |       ? |
| BitOperations_On_UInt64                   | .NET Framework 4.6.2 | 0.0025 ns | 0.0069 ns | 0.0045 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_Byte                           | .NET 8.0             | 0.0033 ns | 0.0091 ns | 0.0066 ns | 0.0000 ns |     ? |       ? |
| BuiltIn_On_Byte                           | .NET Framework 4.6.2 | 0.0633 ns | 0.0446 ns | 0.0417 ns | 0.0449 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt32                         | .NET 8.0             | 0.0176 ns | 0.0210 ns | 0.0164 ns | 0.0165 ns |     ? |       ? |
| BuiltIn_On_UInt32                         | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt64                         | .NET 8.0             | 0.0014 ns | 0.0047 ns | 0.0028 ns | 0.0000 ns |     ? |       ? |
| BuiltIn_On_UInt64                         | .NET Framework 4.6.2 | 0.0332 ns | 0.0319 ns | 0.0299 ns | 0.0196 ns |     ? |       ? |

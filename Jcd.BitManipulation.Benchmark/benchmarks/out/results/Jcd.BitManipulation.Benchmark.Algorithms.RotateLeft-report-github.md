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
| Unchecked_Increment_Subtract_From_Results | .NET 8.0             | 0.0026 ns | 0.0097 ns | 0.0058 ns | 0.0000 ns |     ? |       ? |
| Unchecked_Increment_Subtract_From_Results | .NET Framework 4.6.2 | 0.0237 ns | 0.0190 ns | 0.0125 ns | 0.0260 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_Byte                                   | .NET 8.0             | 0.0043 ns | 0.0097 ns | 0.0081 ns | 0.0000 ns |     ? |       ? |
| On_Byte                                   | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_UInt16                                 | .NET 8.0             | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| On_UInt16                                 | .NET Framework 4.6.2 | 0.4924 ns | 0.0499 ns | 0.0467 ns | 0.4834 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_UInt32                                 | .NET 8.0             | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
| On_UInt32                                 | .NET Framework 4.6.2 | 0.0001 ns | 0.0004 ns | 0.0003 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| On_UInt64                                 | .NET 8.0             | 0.0114 ns | 0.0191 ns | 0.0160 ns | 0.0054 ns |     ? |       ? |
| On_UInt64                                 | .NET Framework 4.6.2 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BitOperations_On_UInt32                   | .NET 8.0             | 0.0018 ns | 0.0060 ns | 0.0043 ns | 0.0000 ns |     ? |       ? |
| BitOperations_On_UInt32                   | .NET Framework 4.6.2 | 0.0016 ns | 0.0051 ns | 0.0037 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BitOperations_On_UInt64                   | .NET 8.0             | 0.0020 ns | 0.0053 ns | 0.0035 ns | 0.0000 ns |     ? |       ? |
| BitOperations_On_UInt64                   | .NET Framework 4.6.2 | 0.0031 ns | 0.0102 ns | 0.0067 ns | 0.0000 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_Byte                           | .NET 8.0             | 0.0178 ns | 0.0292 ns | 0.0259 ns | 0.0078 ns |     ? |       ? |
| BuiltIn_On_Byte                           | .NET Framework 4.6.2 | 0.0374 ns | 0.0399 ns | 0.0354 ns | 0.0290 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt16                         | .NET 8.0             | 0.0323 ns | 0.0300 ns | 0.0280 ns | 0.0201 ns |     ? |       ? |
| BuiltIn_On_UInt16                         | .NET Framework 4.6.2 | 0.0321 ns | 0.0273 ns | 0.0242 ns | 0.0363 ns |     ? |       ? |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt32                         | .NET 8.0             | 0.1120 ns | 0.0976 ns | 0.0913 ns | 0.0935 ns | 1.000 |    0.00 |
| BuiltIn_On_UInt32                         | .NET Framework 4.6.2 | 0.0004 ns | 0.0020 ns | 0.0013 ns | 0.0000 ns | 0.004 |    0.01 |
|                                           |                      |           |           |           |           |       |         |
| BuiltIn_On_UInt64                         | .NET 8.0             | 0.0100 ns | 0.0156 ns | 0.0130 ns | 0.0032 ns |     ? |       ? |
| BuiltIn_On_UInt64                         | .NET Framework 4.6.2 | 0.0104 ns | 0.0152 ns | 0.0142 ns | 0.0000 ns |     ? |       ? |

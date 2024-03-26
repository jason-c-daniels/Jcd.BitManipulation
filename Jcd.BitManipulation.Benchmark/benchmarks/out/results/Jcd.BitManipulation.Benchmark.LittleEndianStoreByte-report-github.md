```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ICMWHD : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-OXTARK : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median |  Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|-------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| BitConverter_ToFloat   | .NET 8.0             |  0.0263 ns | 0.0326 ns | 0.0305 ns |  0.0191 ns |  0.139 |    0.16 |
| BitConverter_ToUInt64  | .NET 8.0             |  0.0262 ns | 0.0387 ns | 0.0362 ns |  0.0046 ns |  0.155 |    0.23 |
| BitConverter_ToInt64   | .NET 8.0             |  0.2268 ns | 0.0987 ns | 0.0923 ns |  0.2145 ns |  1.299 |    0.64 |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0248 ns | 0.0419 ns | 0.0371 ns |  0.0029 ns |  0.160 |    0.26 |
| BitConverter_ToInt32   | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0449 ns | 0.0567 ns | 0.0502 ns |  0.0401 ns |  0.284 |    0.35 |
| BitConverter_ToInt16   | .NET 8.0             |  0.1821 ns | 0.0320 ns | 0.0300 ns |  0.1841 ns |  1.000 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  0.0155 ns | 0.0225 ns | 0.0199 ns |  0.0073 ns |  0.103 |    0.14 |
| ExtensionMethod_Float  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0055 ns | 0.0162 ns | 0.0096 ns |  0.0000 ns |  0.032 |    0.06 |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0004 ns | 0.0018 ns | 0.0012 ns |  0.0000 ns |  0.003 |    0.01 |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0056 ns | 0.0126 ns | 0.0083 ns |  0.0000 ns |  0.038 |    0.06 |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0029 ns | 0.0058 ns | 0.0038 ns |  0.0006 ns |  0.019 |    0.03 |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0000 ns | 0.0001 ns | 0.0001 ns |  0.0000 ns |  0.000 |    0.00 |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0245 ns | 0.0295 ns | 0.0247 ns |  0.0147 ns |  0.133 |    0.13 |
| ByteIndexer_Double     | .NET 8.0             |  0.0656 ns | 0.0826 ns | 0.0773 ns |  0.0519 ns |  0.382 |    0.45 |
| ByteIndexer_Float      | .NET 8.0             |  0.0032 ns | 0.0075 ns | 0.0050 ns |  0.0000 ns |  0.021 |    0.03 |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0228 ns | 0.0415 ns | 0.0324 ns |  0.0000 ns |  0.116 |    0.17 |
| ByteIndexer_Int64      | .NET 8.0             |  0.0021 ns | 0.0080 ns | 0.0071 ns |  0.0000 ns |  0.011 |    0.04 |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0633 ns | 0.0622 ns | 0.0582 ns |  0.0535 ns |  0.351 |    0.31 |
| ByteIndexer_Int32      | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0254 ns | 0.0281 ns | 0.0263 ns |  0.0145 ns |  0.141 |    0.16 |
| ByteIndexer_Int16      | .NET 8.0             |  0.0125 ns | 0.0181 ns | 0.0131 ns |  0.0102 ns |  0.074 |    0.09 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  3.6934 ns | 0.1268 ns | 0.1124 ns |  3.6939 ns | 20.799 |    3.77 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.6120 ns | 0.0383 ns | 0.0253 ns |  2.6139 ns | 15.285 |    2.90 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  3.8981 ns | 0.1823 ns | 0.1705 ns |  3.8757 ns | 21.973 |    3.85 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  2.5419 ns | 0.1037 ns | 0.0970 ns |  2.5602 ns | 14.352 |    2.66 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  2.8130 ns | 0.1585 ns | 0.1483 ns |  2.8005 ns | 15.833 |    2.67 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  1.8222 ns | 0.0811 ns | 0.0759 ns |  1.8284 ns | 10.273 |    1.81 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  3.5141 ns | 0.0956 ns | 0.0894 ns |  3.4825 ns | 19.816 |    3.46 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  2.0397 ns | 0.0623 ns | 0.0553 ns |  2.0267 ns | 11.491 |    2.12 |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.1518 ns | 0.0503 ns | 0.0470 ns |  0.1379 ns |  0.844 |    0.27 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.8368 ns | 0.2275 ns | 0.2128 ns |  9.8141 ns | 55.367 |    8.93 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0286 ns | 0.0251 ns | 0.0222 ns |  0.0254 ns |  0.169 |    0.15 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.1329 ns | 0.0223 ns | 0.0161 ns |  0.1320 ns |  0.783 |    0.22 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0432 ns | 0.0314 ns | 0.0278 ns |  0.0401 ns |  0.237 |    0.14 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0511 ns | 0.0254 ns | 0.0238 ns |  0.0468 ns |  0.288 |    0.14 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0131 ns | 0.0232 ns | 0.0217 ns |  0.0000 ns |  0.077 |    0.13 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0232 ns | 0.0396 ns | 0.0370 ns |  0.0000 ns |  0.138 |    0.21 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.3728 ns | 0.0642 ns | 0.0536 ns |  1.3892 ns |  7.804 |    1.51 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 10.6164 ns | 0.2315 ns | 0.2165 ns | 10.5507 ns | 59.928 |   10.87 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.8517 ns | 0.0433 ns | 0.0258 ns |  1.8589 ns | 10.612 |    2.10 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.8723 ns | 0.0553 ns | 0.0366 ns |  1.8730 ns | 10.963 |    2.13 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.5395 ns | 0.0422 ns | 0.0279 ns |  1.5413 ns |  9.023 |    1.79 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.5567 ns | 0.0360 ns | 0.0238 ns |  1.5558 ns |  9.104 |    1.70 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.7666 ns | 0.0458 ns | 0.0272 ns |  1.7676 ns | 10.120 |    1.98 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.5103 ns | 0.0530 ns | 0.0470 ns |  1.5067 ns |  8.510 |    1.56 |

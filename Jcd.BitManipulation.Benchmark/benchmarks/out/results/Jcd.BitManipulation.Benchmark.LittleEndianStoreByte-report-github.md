```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ROROES : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-CCUDDK : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| ExtensionMethod_Double | .NET 8.0             |  0.0038 ns | 0.0088 ns | 0.0053 ns |  0.0008 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.0360 ns | 0.0351 ns | 0.0328 ns |  0.0345 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Float  | .NET 8.0             |  3.5223 ns | 0.0987 ns | 0.0713 ns |  3.5222 ns |  1.00 |    0.00 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 12.1977 ns | 2.2352 ns | 2.0908 ns | 11.7767 ns |  3.56 |    0.65 |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0096 ns | 0.0130 ns | 0.0086 ns |  0.0083 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0062 ns | 0.0255 ns | 0.0238 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0077 ns | 0.0151 ns | 0.0100 ns |  0.0024 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.0018 ns | 0.0064 ns | 0.0056 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0050 ns | 0.0108 ns | 0.0071 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0088 ns | 0.0125 ns | 0.0117 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0022 ns | 0.0064 ns | 0.0038 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0016 ns | 0.0054 ns | 0.0032 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0036 ns | 0.0067 ns | 0.0044 ns |  0.0019 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0018 ns | 0.0075 ns | 0.0070 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Double     | .NET 8.0             |  0.0028 ns | 0.0099 ns | 0.0059 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.3113 ns | 0.0652 ns | 0.0610 ns |  1.2877 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Float      | .NET 8.0             |  3.8720 ns | 0.0631 ns | 0.0376 ns |  3.8643 ns |  1.00 |    0.00 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 11.8102 ns | 0.1500 ns | 0.0784 ns | 11.8049 ns |  3.05 |    0.03 |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0112 ns | 0.0154 ns | 0.0102 ns |  0.0110 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.3009 ns | 0.0479 ns | 0.0424 ns |  1.2894 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int64      | .NET 8.0             |  0.0220 ns | 0.0266 ns | 0.0236 ns |  0.0105 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.3424 ns | 0.0489 ns | 0.0408 ns |  1.3482 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0003 ns | 0.0015 ns | 0.0010 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.2399 ns | 0.0176 ns | 0.0092 ns |  1.2414 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int32      | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.3038 ns | 0.0381 ns | 0.0252 ns |  1.2984 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0012 ns | 0.0042 ns | 0.0025 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.4719 ns | 0.0444 ns | 0.0294 ns |  1.4668 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int16      | .NET 8.0             |  0.0046 ns | 0.0092 ns | 0.0055 ns |  0.0039 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.4029 ns | 0.0421 ns | 0.0279 ns |  1.4085 ns |     ? |       ? |

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-BDWZRX : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-WYRMBM : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |       Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  1.4923 ns | 0.0417 ns | 0.0248 ns |  0.39 |    0.01 |
| BitConverter_ToFloat   | .NET 8.0             |  1.4843 ns | 0.0406 ns | 0.0269 ns |  0.39 |    0.01 |
| BitConverter_ToUInt64  | .NET 8.0             |  1.2909 ns | 0.0504 ns | 0.0365 ns |  0.34 |    0.01 |
| BitConverter_ToInt64   | .NET 8.0             |  1.7199 ns | 0.0463 ns | 0.0276 ns |  0.45 |    0.01 |
| BitConverter_ToUInt32  | .NET 8.0             |  1.6975 ns | 0.0272 ns | 0.0180 ns |  0.45 |    0.01 |
| BitConverter_ToInt32   | .NET 8.0             |  1.4615 ns | 0.0359 ns | 0.0237 ns |  0.39 |    0.01 |
| BitConverter_ToUInt16  | .NET 8.0             |  3.5591 ns | 0.0280 ns | 0.0185 ns |  0.94 |    0.01 |
| BitConverter_ToInt16   | .NET 8.0             |  3.7899 ns | 0.0212 ns | 0.0140 ns |  1.00 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  4.6583 ns | 0.0390 ns | 0.0204 ns |  1.23 |    0.01 |
| ExtensionMethod_Float  | .NET 8.0             |  6.3618 ns | 0.0916 ns | 0.0606 ns |  1.68 |    0.02 |
| ExtensionMethod_UInt64 | .NET 8.0             |  4.5120 ns | 0.0518 ns | 0.0343 ns |  1.19 |    0.01 |
| ExtensionMethod_Int64  | .NET 8.0             |  4.5113 ns | 0.0702 ns | 0.0418 ns |  1.19 |    0.01 |
| ExtensionMethod_UInt32 | .NET 8.0             |  2.8037 ns | 0.0557 ns | 0.0331 ns |  0.74 |    0.01 |
| ExtensionMethod_Int32  | .NET 8.0             |  1.9427 ns | 0.0251 ns | 0.0166 ns |  0.51 |    0.00 |
| ExtensionMethod_UInt16 | .NET 8.0             |  1.2224 ns | 0.0257 ns | 0.0170 ns |  0.32 |    0.01 |
| ExtensionMethod_Int16  | .NET 8.0             |  1.1008 ns | 0.0168 ns | 0.0100 ns |  0.29 |    0.00 |
| ByteIndexer_Double     | .NET 8.0             |  4.0722 ns | 0.0405 ns | 0.0268 ns |  1.07 |    0.01 |
| ByteIndexer_Float      | .NET 8.0             |  5.9157 ns | 0.0484 ns | 0.0320 ns |  1.56 |    0.01 |
| ByteIndexer_UInt64     | .NET 8.0             |  3.7939 ns | 0.0320 ns | 0.0212 ns |  1.00 |    0.01 |
| ByteIndexer_Int64      | .NET 8.0             |  3.7707 ns | 0.0330 ns | 0.0196 ns |  1.00 |    0.01 |
| ByteIndexer_UInt32     | .NET 8.0             |  1.8803 ns | 0.0183 ns | 0.0096 ns |  0.50 |    0.00 |
| ByteIndexer_Int32      | .NET 8.0             |  2.1079 ns | 0.0307 ns | 0.0203 ns |  0.56 |    0.01 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.7131 ns | 0.0359 ns | 0.0213 ns |  0.19 |    0.01 |
| ByteIndexer_Int16      | .NET 8.0             |  0.6359 ns | 0.0126 ns | 0.0075 ns |  0.17 |    0.00 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 | 25.2421 ns | 0.2174 ns | 0.1438 ns |  6.66 |    0.05 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 | 23.4358 ns | 0.2307 ns | 0.1526 ns |  6.18 |    0.04 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 | 25.9763 ns | 0.2174 ns | 0.1438 ns |  6.85 |    0.04 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 | 25.2389 ns | 0.6642 ns | 0.5888 ns |  6.64 |    0.16 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 | 23.6360 ns | 0.1599 ns | 0.1058 ns |  6.24 |    0.04 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 | 22.9559 ns | 0.4219 ns | 0.2790 ns |  6.06 |    0.09 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 | 23.0603 ns | 0.4843 ns | 0.3203 ns |  6.08 |    0.09 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 | 20.7807 ns | 0.1484 ns | 0.0981 ns |  5.48 |    0.03 |
| ExtensionMethod_Double | .NET Framework 4.6.2 | 10.8870 ns | 0.0786 ns | 0.0468 ns |  2.87 |    0.02 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 14.6655 ns | 0.0870 ns | 0.0576 ns |  3.87 |    0.01 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 | 10.7723 ns | 0.0333 ns | 0.0220 ns |  2.84 |    0.01 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 | 10.8849 ns | 0.0942 ns | 0.0623 ns |  2.87 |    0.02 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  5.2804 ns | 0.0659 ns | 0.0392 ns |  1.39 |    0.01 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  5.2550 ns | 0.0535 ns | 0.0318 ns |  1.39 |    0.01 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  2.7847 ns | 0.0447 ns | 0.0295 ns |  0.73 |    0.01 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  2.8004 ns | 0.0321 ns | 0.0212 ns |  0.74 |    0.01 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  9.5034 ns | 0.0541 ns | 0.0358 ns |  2.51 |    0.01 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 14.7862 ns | 0.1081 ns | 0.0644 ns |  3.90 |    0.03 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  7.0232 ns | 0.0523 ns | 0.0311 ns |  1.85 |    0.01 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  7.0086 ns | 0.0256 ns | 0.0152 ns |  1.85 |    0.01 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  3.1949 ns | 0.0193 ns | 0.0115 ns |  0.84 |    0.00 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  3.2413 ns | 0.0819 ns | 0.0639 ns |  0.86 |    0.02 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.6533 ns | 0.0383 ns | 0.0228 ns |  0.44 |    0.01 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.6466 ns | 0.0423 ns | 0.0280 ns |  0.43 |    0.01 |

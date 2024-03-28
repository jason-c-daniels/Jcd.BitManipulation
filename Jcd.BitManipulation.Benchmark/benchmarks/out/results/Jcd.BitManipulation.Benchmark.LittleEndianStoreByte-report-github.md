```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-WBOMYL : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-YFPBER : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median |  Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|-------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0370 ns | 0.0249 ns | 0.0233 ns |  0.0357 ns |  0.287 |    0.18 |
| BitConverter_ToFloat   | .NET 8.0             |  0.0176 ns | 0.0235 ns | 0.0220 ns |  0.0000 ns |  0.172 |    0.14 |
| BitConverter_ToUInt64  | .NET 8.0             |  0.0034 ns | 0.0070 ns | 0.0042 ns |  0.0014 ns |  0.022 |    0.03 |
| BitConverter_ToInt64   | .NET 8.0             |  0.1369 ns | 0.0066 ns | 0.0044 ns |  0.1356 ns |  0.901 |    0.07 |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0027 ns | 0.0041 ns | 0.0024 ns |  0.0021 ns |  0.017 |    0.02 |
| BitConverter_ToInt32   | .NET 8.0             |  0.0104 ns | 0.0154 ns | 0.0102 ns |  0.0059 ns |  0.068 |    0.07 |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0013 ns | 0.0047 ns | 0.0028 ns |  0.0000 ns |  0.008 |    0.02 |
| BitConverter_ToInt16   | .NET 8.0             |  0.1526 ns | 0.0172 ns | 0.0114 ns |  0.1549 ns |  1.000 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  0.0355 ns | 0.0249 ns | 0.0233 ns |  0.0328 ns |  0.279 |    0.16 |
| ExtensionMethod_Float  | .NET 8.0             |  0.0050 ns | 0.0130 ns | 0.0086 ns |  0.0000 ns |  0.035 |    0.06 |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0146 ns | 0.0238 ns | 0.0186 ns |  0.0079 ns |  0.104 |    0.14 |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0034 ns | 0.0143 ns | 0.0103 ns |  0.0000 ns |  0.022 |    0.06 |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0034 ns | 0.0062 ns | 0.0041 ns |  0.0020 ns |  0.022 |    0.03 |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0010 ns | 0.0047 ns | 0.0031 ns |  0.0000 ns |  0.007 |    0.02 |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0038 ns | 0.0052 ns | 0.0034 ns |  0.0043 ns |  0.024 |    0.02 |
| ByteIndexer_Double     | .NET 8.0             |  0.0056 ns | 0.0075 ns | 0.0050 ns |  0.0052 ns |  0.039 |    0.04 |
| ByteIndexer_Float      | .NET 8.0             |  0.0026 ns | 0.0053 ns | 0.0028 ns |  0.0020 ns |  0.016 |    0.02 |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0072 ns | 0.0078 ns | 0.0047 ns |  0.0080 ns |  0.047 |    0.03 |
| ByteIndexer_Int64      | .NET 8.0             |  0.0130 ns | 0.0187 ns | 0.0175 ns |  0.0000 ns |  0.124 |    0.13 |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ByteIndexer_Int32      | .NET 8.0             |  0.0422 ns | 0.0359 ns | 0.0336 ns |  0.0310 ns |  0.267 |    0.22 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0225 ns | 0.0267 ns | 0.0250 ns |  0.0137 ns |  0.223 |    0.16 |
| ByteIndexer_Int16      | .NET 8.0             |  0.0012 ns | 0.0028 ns | 0.0015 ns |  0.0008 ns |  0.008 |    0.01 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  3.8032 ns | 0.0711 ns | 0.0470 ns |  3.7853 ns | 25.054 |    1.97 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.6417 ns | 0.0128 ns | 0.0085 ns |  2.6425 ns | 17.397 |    1.29 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  3.7506 ns | 0.0250 ns | 0.0149 ns |  3.7466 ns | 24.415 |    1.74 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  2.4239 ns | 0.0148 ns | 0.0088 ns |  2.4257 ns | 15.778 |    1.11 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  2.8110 ns | 0.0935 ns | 0.0829 ns |  2.7918 ns | 18.582 |    1.51 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  1.8406 ns | 0.0342 ns | 0.0203 ns |  1.8424 ns | 11.980 |    0.83 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  3.3771 ns | 0.0558 ns | 0.0369 ns |  3.3844 ns | 22.234 |    1.55 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  2.0565 ns | 0.0454 ns | 0.0300 ns |  2.0614 ns | 13.543 |    1.02 |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.1827 ns | 0.0457 ns | 0.0427 ns |  0.1698 ns |  1.145 |    0.36 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.9826 ns | 0.1893 ns | 0.1252 ns | 10.0086 ns | 65.748 |    5.02 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0159 ns | 0.0088 ns | 0.0046 ns |  0.0153 ns |  0.103 |    0.03 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.0328 ns | 0.0205 ns | 0.0181 ns |  0.0332 ns |  0.181 |    0.12 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0394 ns | 0.0055 ns | 0.0033 ns |  0.0408 ns |  0.256 |    0.03 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0414 ns | 0.0133 ns | 0.0088 ns |  0.0422 ns |  0.271 |    0.05 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0003 ns | 0.0009 ns | 0.0005 ns |  0.0000 ns |  0.002 |    0.00 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0092 ns | 0.0108 ns | 0.0072 ns |  0.0124 ns |  0.061 |    0.05 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.4240 ns | 0.0698 ns | 0.0653 ns |  1.4227 ns |  9.230 |    0.90 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 10.5419 ns | 0.1820 ns | 0.1083 ns | 10.4991 ns | 68.591 |    4.35 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.9023 ns | 0.0337 ns | 0.0223 ns |  1.9015 ns | 12.530 |    0.97 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.9079 ns | 0.0381 ns | 0.0252 ns |  1.9154 ns | 12.568 |    0.99 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.5465 ns | 0.0350 ns | 0.0232 ns |  1.5503 ns | 10.186 |    0.79 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.5389 ns | 0.0272 ns | 0.0180 ns |  1.5350 ns | 10.139 |    0.81 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.8459 ns | 0.0847 ns | 0.0792 ns |  1.8373 ns | 12.375 |    0.77 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.7883 ns | 0.1086 ns | 0.1016 ns |  1.8264 ns | 11.635 |    0.67 |

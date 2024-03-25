```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-EEUGLS : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-HWBWFM : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median |  Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|-------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0047 ns | 0.0060 ns | 0.0040 ns |  0.0048 ns |  0.042 |    0.04 |
| BitConverter_ToFloat   | .NET 8.0             |  0.0099 ns | 0.0080 ns | 0.0053 ns |  0.0101 ns |  0.086 |    0.05 |
| BitConverter_ToUInt64  | .NET 8.0             |  0.0031 ns | 0.0042 ns | 0.0025 ns |  0.0031 ns |  0.027 |    0.02 |
| BitConverter_ToInt64   | .NET 8.0             |  0.1354 ns | 0.0093 ns | 0.0062 ns |  0.1344 ns |  1.190 |    0.18 |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0001 ns | 0.0007 ns | 0.0004 ns |  0.0000 ns |  0.002 |    0.00 |
| BitConverter_ToInt32   | .NET 8.0             |  0.0013 ns | 0.0050 ns | 0.0030 ns |  0.0000 ns |  0.014 |    0.03 |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0035 ns | 0.0070 ns | 0.0046 ns |  0.0017 ns |  0.030 |    0.04 |
| BitConverter_ToInt16   | .NET 8.0             |  0.1156 ns | 0.0205 ns | 0.0136 ns |  0.1165 ns |  1.000 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  0.0004 ns | 0.0013 ns | 0.0008 ns |  0.0000 ns |  0.003 |    0.01 |
| ExtensionMethod_Float  | .NET 8.0             |  0.0002 ns | 0.0009 ns | 0.0005 ns |  0.0000 ns |  0.002 |    0.00 |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0038 ns | 0.0058 ns | 0.0038 ns |  0.0040 ns |  0.032 |    0.03 |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0001 ns | 0.0004 ns | 0.0003 ns |  0.0000 ns |  0.001 |    0.00 |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0018 ns | 0.0036 ns | 0.0024 ns |  0.0000 ns |  0.015 |    0.02 |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0071 ns | 0.0069 ns | 0.0045 ns |  0.0080 ns |  0.062 |    0.04 |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0024 ns | 0.0058 ns | 0.0035 ns |  0.0014 ns |  0.021 |    0.03 |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0020 ns | 0.0033 ns | 0.0022 ns |  0.0014 ns |  0.017 |    0.02 |
| ByteIndexer_Double     | .NET 8.0             |  0.0023 ns | 0.0033 ns | 0.0022 ns |  0.0024 ns |  0.020 |    0.02 |
| ByteIndexer_Float      | .NET 8.0             |  0.0006 ns | 0.0016 ns | 0.0010 ns |  0.0000 ns |  0.005 |    0.01 |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0055 ns | 0.0072 ns | 0.0047 ns |  0.0053 ns |  0.048 |    0.04 |
| ByteIndexer_Int64      | .NET 8.0             |  0.0037 ns | 0.0052 ns | 0.0034 ns |  0.0047 ns |  0.033 |    0.03 |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ByteIndexer_Int32      | .NET 8.0             |  0.0034 ns | 0.0073 ns | 0.0048 ns |  0.0011 ns |  0.031 |    0.05 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0007 ns | 0.0020 ns | 0.0014 ns |  0.0000 ns |  0.006 |    0.01 |
| ByteIndexer_Int16      | .NET 8.0             |  0.0368 ns | 0.0263 ns | 0.0190 ns |  0.0404 ns |  0.301 |    0.15 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  3.7240 ns | 0.0935 ns | 0.0781 ns |  3.7200 ns | 32.636 |    4.02 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.6242 ns | 0.0282 ns | 0.0187 ns |  2.6261 ns | 23.004 |    2.89 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  3.7273 ns | 0.0401 ns | 0.0210 ns |  3.7374 ns | 32.843 |    4.66 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  2.4161 ns | 0.0295 ns | 0.0195 ns |  2.4126 ns | 21.173 |    2.61 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  2.6339 ns | 0.0276 ns | 0.0164 ns |  2.6390 ns | 23.128 |    3.04 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  1.7637 ns | 0.0161 ns | 0.0096 ns |  1.7655 ns | 15.489 |    2.06 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  3.3257 ns | 0.0913 ns | 0.0854 ns |  3.3020 ns | 29.357 |    3.96 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  1.9571 ns | 0.0183 ns | 0.0109 ns |  1.9581 ns | 17.183 |    2.23 |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.1277 ns | 0.0095 ns | 0.0057 ns |  0.1282 ns |  1.123 |    0.17 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.6017 ns | 0.0534 ns | 0.0318 ns |  9.5995 ns | 84.328 |   11.18 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0172 ns | 0.0120 ns | 0.0079 ns |  0.0154 ns |  0.148 |    0.06 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.0737 ns | 0.0083 ns | 0.0055 ns |  0.0721 ns |  0.648 |    0.11 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0014 ns | 0.0026 ns | 0.0017 ns |  0.0007 ns |  0.013 |    0.02 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0000 ns | 0.0001 ns | 0.0001 ns |  0.0000 ns |  0.000 |    0.00 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.2985 ns | 0.0301 ns | 0.0199 ns |  1.2967 ns | 11.388 |    1.50 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 10.3608 ns | 0.0679 ns | 0.0449 ns | 10.3770 ns | 90.809 |   11.28 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.8842 ns | 0.0564 ns | 0.0373 ns |  1.8756 ns | 16.532 |    2.24 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.8661 ns | 0.0258 ns | 0.0171 ns |  1.8634 ns | 16.357 |    2.05 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.2866 ns | 0.0151 ns | 0.0090 ns |  1.2848 ns | 11.301 |    1.51 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.2719 ns | 0.0311 ns | 0.0185 ns |  1.2784 ns | 11.162 |    1.42 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.7923 ns | 0.0428 ns | 0.0283 ns |  1.7951 ns | 15.713 |    2.03 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.5438 ns | 0.0237 ns | 0.0141 ns |  1.5446 ns | 13.561 |    1.83 |

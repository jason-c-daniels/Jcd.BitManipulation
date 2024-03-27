```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-CYDLTE : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-CSEHTA : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median |  Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|-------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0007 ns | 0.0023 ns | 0.0015 ns |  0.0000 ns |  0.005 |    0.01 |
| BitConverter_ToFloat   | .NET 8.0             |  0.0060 ns | 0.0056 ns | 0.0037 ns |  0.0060 ns |  0.045 |    0.03 |
| BitConverter_ToUInt64  | .NET 8.0             |  0.0078 ns | 0.0080 ns | 0.0053 ns |  0.0086 ns |  0.059 |    0.04 |
| BitConverter_ToInt64   | .NET 8.0             |  0.1368 ns | 0.0167 ns | 0.0099 ns |  0.1327 ns |  1.028 |    0.10 |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0164 ns | 0.0177 ns | 0.0117 ns |  0.0146 ns |  0.123 |    0.09 |
| BitConverter_ToInt32   | .NET 8.0             |  0.0048 ns | 0.0116 ns | 0.0077 ns |  0.0000 ns |  0.037 |    0.06 |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0069 ns | 0.0095 ns | 0.0050 ns |  0.0080 ns |  0.052 |    0.04 |
| BitConverter_ToInt16   | .NET 8.0             |  0.1330 ns | 0.0075 ns | 0.0050 ns |  0.1324 ns |  1.000 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  0.0021 ns | 0.0060 ns | 0.0040 ns |  0.0000 ns |  0.016 |    0.03 |
| ExtensionMethod_Float  | .NET 8.0             |  0.0032 ns | 0.0063 ns | 0.0038 ns |  0.0021 ns |  0.024 |    0.03 |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0011 ns | 0.0030 ns | 0.0020 ns |  0.0000 ns |  0.008 |    0.01 |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0069 ns | 0.0038 ns | 0.0025 ns |  0.0065 ns |  0.052 |    0.02 |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0047 ns | 0.0063 ns | 0.0037 ns |  0.0068 ns |  0.036 |    0.03 |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0043 ns | 0.0102 ns | 0.0067 ns |  0.0011 ns |  0.033 |    0.05 |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0209 ns | 0.0315 ns | 0.0280 ns |  0.0042 ns |  0.105 |    0.17 |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0181 ns | 0.0157 ns | 0.0094 ns |  0.0156 ns |  0.134 |    0.07 |
| ByteIndexer_Double     | .NET 8.0             |  0.0184 ns | 0.0153 ns | 0.0101 ns |  0.0181 ns |  0.137 |    0.08 |
| ByteIndexer_Float      | .NET 8.0             |  0.0951 ns | 0.0833 ns | 0.0779 ns |  0.0784 ns |  0.590 |    0.63 |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0406 ns | 0.0325 ns | 0.0288 ns |  0.0386 ns |  0.230 |    0.20 |
| ByteIndexer_Int64      | .NET 8.0             |  0.0320 ns | 0.0512 ns | 0.0479 ns |  0.0000 ns |  0.359 |    0.39 |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0019 ns | 0.0080 ns | 0.0071 ns |  0.0000 ns |  0.019 |    0.06 |
| ByteIndexer_Int32      | .NET 8.0             |  0.0113 ns | 0.0166 ns | 0.0110 ns |  0.0111 ns |  0.085 |    0.08 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ByteIndexer_Int16      | .NET 8.0             |  0.0133 ns | 0.0187 ns | 0.0111 ns |  0.0140 ns |  0.099 |    0.08 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  4.0311 ns | 0.3032 ns | 0.2836 ns |  3.8921 ns | 30.392 |    2.78 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.7423 ns | 0.1173 ns | 0.1097 ns |  2.6979 ns | 20.615 |    1.03 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  3.7742 ns | 0.0952 ns | 0.0566 ns |  3.7666 ns | 28.351 |    1.38 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  2.5381 ns | 0.1321 ns | 0.1235 ns |  2.4678 ns | 19.442 |    1.14 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  2.9414 ns | 0.1084 ns | 0.1014 ns |  2.9423 ns | 22.117 |    1.00 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  1.8416 ns | 0.0886 ns | 0.0829 ns |  1.8096 ns | 13.934 |    0.83 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  3.5558 ns | 0.1022 ns | 0.0906 ns |  3.5435 ns | 26.826 |    1.48 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  1.9931 ns | 0.0164 ns | 0.0097 ns |  1.9950 ns | 14.967 |    0.56 |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.1305 ns | 0.0106 ns | 0.0070 ns |  0.1312 ns |  0.984 |    0.08 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.6199 ns | 0.0749 ns | 0.0496 ns |  9.6153 ns | 72.446 |    2.77 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0085 ns | 0.0130 ns | 0.0086 ns |  0.0055 ns |  0.064 |    0.06 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.1303 ns | 0.0092 ns | 0.0048 ns |  0.1312 ns |  0.979 |    0.06 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0498 ns | 0.0268 ns | 0.0251 ns |  0.0385 ns |  0.371 |    0.17 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0655 ns | 0.0510 ns | 0.0477 ns |  0.0522 ns |  0.515 |    0.41 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0170 ns | 0.0173 ns | 0.0115 ns |  0.0168 ns |  0.129 |    0.09 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.4173 ns | 0.0748 ns | 0.0625 ns |  1.3978 ns | 10.654 |    0.84 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 11.2765 ns | 0.7250 ns | 0.6782 ns | 11.0699 ns | 86.706 |    5.17 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.9589 ns | 0.0846 ns | 0.0792 ns |  1.9383 ns | 14.938 |    0.78 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.8598 ns | 0.0266 ns | 0.0139 ns |  1.8603 ns | 13.962 |    0.57 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.5805 ns | 0.0306 ns | 0.0202 ns |  1.5760 ns | 11.905 |    0.52 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.5647 ns | 0.0300 ns | 0.0179 ns |  1.5653 ns | 11.752 |    0.50 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.8820 ns | 0.0620 ns | 0.0549 ns |  1.8706 ns | 14.213 |    0.65 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.6323 ns | 0.0882 ns | 0.0782 ns |  1.6145 ns | 12.398 |    0.89 |

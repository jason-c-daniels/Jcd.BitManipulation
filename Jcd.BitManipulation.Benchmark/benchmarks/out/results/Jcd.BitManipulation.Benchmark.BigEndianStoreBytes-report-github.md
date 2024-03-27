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

| Method                 | Runtime              |       Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  1.5852 ns | 0.1102 ns | 0.0977 ns |  0.41 |    0.03 |
| BitConverter_ToFloat   | .NET 8.0             |  1.5135 ns | 0.0741 ns | 0.0619 ns |  0.39 |    0.02 |
| BitConverter_ToUInt64  | .NET 8.0             |  1.2731 ns | 0.0479 ns | 0.0285 ns |  0.33 |    0.01 |
| BitConverter_ToInt64   | .NET 8.0             |  1.6953 ns | 0.0362 ns | 0.0239 ns |  0.44 |    0.01 |
| BitConverter_ToUInt32  | .NET 8.0             |  1.2545 ns | 0.0496 ns | 0.0414 ns |  0.33 |    0.01 |
| BitConverter_ToInt32   | .NET 8.0             |  1.7730 ns | 0.0884 ns | 0.0784 ns |  0.46 |    0.02 |
| BitConverter_ToUInt16  | .NET 8.0             |  3.6276 ns | 0.0881 ns | 0.0637 ns |  0.94 |    0.03 |
| BitConverter_ToInt16   | .NET 8.0             |  3.8563 ns | 0.1013 ns | 0.0846 ns |  1.00 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  1.3001 ns | 0.1391 ns | 0.1302 ns |  0.34 |    0.03 |
| ExtensionMethod_Float  | .NET 8.0             |  0.5779 ns | 0.0082 ns | 0.0043 ns |  0.15 |    0.00 |
| ExtensionMethod_UInt64 | .NET 8.0             |  1.2686 ns | 0.0429 ns | 0.0358 ns |  0.33 |    0.01 |
| ExtensionMethod_Int64  | .NET 8.0             |  1.3221 ns | 0.0746 ns | 0.0662 ns |  0.34 |    0.02 |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.3451 ns | 0.0248 ns | 0.0179 ns |  0.09 |    0.00 |
| ExtensionMethod_Int32  | .NET 8.0             |  0.3267 ns | 0.0187 ns | 0.0124 ns |  0.08 |    0.00 |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.1739 ns | 0.0251 ns | 0.0149 ns |  0.04 |    0.00 |
| ExtensionMethod_Int16  | .NET 8.0             |  0.1369 ns | 0.0209 ns | 0.0124 ns |  0.04 |    0.00 |
| ByteIndexer_Double     | .NET 8.0             |  1.2730 ns | 0.0273 ns | 0.0180 ns |  0.33 |    0.01 |
| ByteIndexer_Float      | .NET 8.0             |  0.3820 ns | 0.0459 ns | 0.0407 ns |  0.10 |    0.01 |
| ByteIndexer_UInt64     | .NET 8.0             |  1.2864 ns | 0.0900 ns | 0.0842 ns |  0.33 |    0.02 |
| ByteIndexer_Int64      | .NET 8.0             |  1.3114 ns | 0.0777 ns | 0.0727 ns |  0.34 |    0.02 |
| ByteIndexer_UInt32     | .NET 8.0             |  0.2870 ns | 0.0213 ns | 0.0166 ns |  0.07 |    0.00 |
| ByteIndexer_Int32      | .NET 8.0             |  0.3273 ns | 0.0255 ns | 0.0199 ns |  0.08 |    0.00 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.1219 ns | 0.0252 ns | 0.0182 ns |  0.03 |    0.00 |
| ByteIndexer_Int16      | .NET 8.0             |  0.1875 ns | 0.0393 ns | 0.0368 ns |  0.05 |    0.01 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 | 26.6305 ns | 0.6262 ns | 0.5551 ns |  6.92 |    0.16 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 | 25.2033 ns | 0.5252 ns | 0.3474 ns |  6.50 |    0.18 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 | 27.4330 ns | 0.7645 ns | 0.7151 ns |  7.13 |    0.31 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 | 25.6931 ns | 0.3226 ns | 0.1687 ns |  6.63 |    0.18 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 | 24.7655 ns | 1.1204 ns | 0.9932 ns |  6.39 |    0.26 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 | 22.6680 ns | 0.3384 ns | 0.1770 ns |  5.85 |    0.14 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 | 23.5900 ns | 0.5000 ns | 0.4677 ns |  6.13 |    0.22 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 | 20.9847 ns | 0.2167 ns | 0.1434 ns |  5.41 |    0.13 |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  6.9038 ns | 0.1532 ns | 0.1108 ns |  1.78 |    0.04 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 12.3139 ns | 0.1766 ns | 0.1051 ns |  3.18 |    0.07 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  6.3630 ns | 0.0492 ns | 0.0326 ns |  1.64 |    0.03 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  6.3854 ns | 0.0947 ns | 0.0627 ns |  1.65 |    0.04 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  2.9726 ns | 0.0228 ns | 0.0151 ns |  0.77 |    0.02 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  3.0464 ns | 0.0795 ns | 0.0473 ns |  0.79 |    0.02 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  1.4156 ns | 0.0168 ns | 0.0111 ns |  0.37 |    0.01 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  1.4886 ns | 0.0779 ns | 0.0691 ns |  0.39 |    0.02 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  6.8328 ns | 0.0518 ns | 0.0342 ns |  1.76 |    0.04 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 12.8136 ns | 0.1660 ns | 0.0988 ns |  3.31 |    0.07 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  6.6517 ns | 0.0489 ns | 0.0291 ns |  1.72 |    0.04 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  6.6377 ns | 0.0420 ns | 0.0220 ns |  1.71 |    0.03 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  3.0166 ns | 0.0667 ns | 0.0397 ns |  0.78 |    0.02 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  2.9874 ns | 0.0312 ns | 0.0186 ns |  0.77 |    0.02 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.5108 ns | 0.0640 ns | 0.0599 ns |  0.39 |    0.02 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.3905 ns | 0.0294 ns | 0.0175 ns |  0.36 |    0.01 |

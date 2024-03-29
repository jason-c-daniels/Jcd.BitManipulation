```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-JSKQEV : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-FYSSQN : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                 | Runtime              |       Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  1.4597 ns | 0.0514 ns | 0.0372 ns |  0.39 |    0.01 |
| BitConverter_ToFloat   | .NET 8.0             |  1.4437 ns | 0.0467 ns | 0.0278 ns |  0.38 |    0.01 |
| BitConverter_ToUInt64  | .NET 8.0             |  1.2682 ns | 0.0504 ns | 0.0421 ns |  0.34 |    0.01 |
| BitConverter_ToInt64   | .NET 8.0             |  1.6830 ns | 0.0213 ns | 0.0127 ns |  0.45 |    0.01 |
| BitConverter_ToUInt32  | .NET 8.0             |  1.3201 ns | 0.1030 ns | 0.0964 ns |  0.35 |    0.03 |
| BitConverter_ToInt32   | .NET 8.0             |  1.7006 ns | 0.0587 ns | 0.0424 ns |  0.45 |    0.01 |
| BitConverter_ToUInt16  | .NET 8.0             |  3.2226 ns | 0.0940 ns | 0.0622 ns |  0.86 |    0.02 |
| BitConverter_ToInt16   | .NET 8.0             |  3.7694 ns | 0.0665 ns | 0.0440 ns |  1.00 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  1.3018 ns | 0.0727 ns | 0.0644 ns |  0.34 |    0.01 |
| ExtensionMethod_Float  | .NET 8.0             |  0.1831 ns | 0.0642 ns | 0.0601 ns |  0.05 |    0.02 |
| ExtensionMethod_UInt64 | .NET 8.0             |  1.2900 ns | 0.0787 ns | 0.0737 ns |  0.34 |    0.02 |
| ExtensionMethod_Int64  | .NET 8.0             |  1.5884 ns | 0.2865 ns | 0.2540 ns |  0.42 |    0.07 |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.1450 ns | 0.0441 ns | 0.0413 ns |  0.04 |    0.01 |
| ExtensionMethod_Int32  | .NET 8.0             |  0.1301 ns | 0.0574 ns | 0.0537 ns |  0.04 |    0.01 |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0375 ns | 0.0337 ns | 0.0316 ns |  0.01 |    0.01 |
| ExtensionMethod_Int16  | .NET 8.0             |  0.1111 ns | 0.0343 ns | 0.0321 ns |  0.03 |    0.01 |
| ByteIndexer_Double     | .NET 8.0             |  1.2758 ns | 0.0500 ns | 0.0362 ns |  0.34 |    0.01 |
| ByteIndexer_Float      | .NET 8.0             |  0.3984 ns | 0.0458 ns | 0.0429 ns |  0.11 |    0.01 |
| ByteIndexer_UInt64     | .NET 8.0             |  1.1984 ns | 0.0316 ns | 0.0209 ns |  0.32 |    0.01 |
| ByteIndexer_Int64      | .NET 8.0             |  1.3004 ns | 0.1842 ns | 0.1723 ns |  0.34 |    0.05 |
| ByteIndexer_UInt32     | .NET 8.0             |  0.1295 ns | 0.0232 ns | 0.0138 ns |  0.03 |    0.00 |
| ByteIndexer_Int32      | .NET 8.0             |  0.1662 ns | 0.0512 ns | 0.0479 ns |  0.04 |    0.01 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.1215 ns | 0.0102 ns | 0.0053 ns |  0.03 |    0.00 |
| ByteIndexer_Int16      | .NET 8.0             |  0.1202 ns | 0.0164 ns | 0.0109 ns |  0.03 |    0.00 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 | 26.1616 ns | 0.4259 ns | 0.2817 ns |  6.94 |    0.10 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 | 23.6848 ns | 0.3416 ns | 0.1787 ns |  6.27 |    0.06 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 | 26.6556 ns | 0.5447 ns | 0.3938 ns |  7.06 |    0.14 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 | 25.2554 ns | 0.4829 ns | 0.3194 ns |  6.70 |    0.10 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 | 24.0786 ns | 0.3344 ns | 0.2212 ns |  6.39 |    0.07 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 | 23.1333 ns | 0.4540 ns | 0.3003 ns |  6.14 |    0.12 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 | 23.3688 ns | 0.5063 ns | 0.4736 ns |  6.25 |    0.18 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 | 21.0910 ns | 0.2707 ns | 0.1611 ns |  5.59 |    0.10 |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  6.6623 ns | 0.0513 ns | 0.0268 ns |  1.76 |    0.02 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 12.3149 ns | 0.2178 ns | 0.1296 ns |  3.26 |    0.05 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  6.5830 ns | 0.1907 ns | 0.1784 ns |  1.76 |    0.04 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  6.4623 ns | 0.0876 ns | 0.0579 ns |  1.71 |    0.02 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  2.9535 ns | 0.0415 ns | 0.0217 ns |  0.78 |    0.01 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  2.9359 ns | 0.0528 ns | 0.0349 ns |  0.78 |    0.01 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  1.4009 ns | 0.0373 ns | 0.0222 ns |  0.37 |    0.01 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  1.4198 ns | 0.0186 ns | 0.0110 ns |  0.38 |    0.01 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  6.6453 ns | 0.0961 ns | 0.0572 ns |  1.76 |    0.03 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 12.6242 ns | 0.2601 ns | 0.2172 ns |  3.35 |    0.06 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  6.4312 ns | 0.0993 ns | 0.0657 ns |  1.71 |    0.03 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  6.5593 ns | 0.1460 ns | 0.1140 ns |  1.74 |    0.04 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  2.9709 ns | 0.0887 ns | 0.0787 ns |  0.79 |    0.02 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  2.8767 ns | 0.0777 ns | 0.0689 ns |  0.77 |    0.02 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.3860 ns | 0.0605 ns | 0.0566 ns |  0.37 |    0.01 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.4050 ns | 0.0484 ns | 0.0404 ns |  0.37 |    0.01 |

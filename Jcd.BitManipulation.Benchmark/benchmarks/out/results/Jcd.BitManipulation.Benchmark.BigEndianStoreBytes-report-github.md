```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-VURUXF : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-FFYTMY : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |       Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  1.4671 ns | 0.0549 ns | 0.0327 ns |  0.40 |    0.01 |
| BitConverter_ToFloat   | .NET 8.0             |  1.4284 ns | 0.0228 ns | 0.0136 ns |  0.39 |    0.00 |
| BitConverter_ToUInt64  | .NET 8.0             |  1.2979 ns | 0.0948 ns | 0.0887 ns |  0.36 |    0.02 |
| BitConverter_ToInt64   | .NET 8.0             |  1.6752 ns | 0.0166 ns | 0.0087 ns |  0.45 |    0.00 |
| BitConverter_ToUInt32  | .NET 8.0             |  1.6254 ns | 0.0351 ns | 0.0209 ns |  0.44 |    0.01 |
| BitConverter_ToInt32   | .NET 8.0             |  1.4539 ns | 0.0510 ns | 0.0452 ns |  0.39 |    0.01 |
| BitConverter_ToUInt16  | .NET 8.0             |  3.2628 ns | 0.0938 ns | 0.0832 ns |  0.90 |    0.02 |
| BitConverter_ToInt16   | .NET 8.0             |  3.6944 ns | 0.0434 ns | 0.0258 ns |  1.00 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  4.5722 ns | 0.0415 ns | 0.0217 ns |  1.24 |    0.01 |
| ExtensionMethod_Float  | .NET 8.0             |  5.8034 ns | 0.1458 ns | 0.1218 ns |  1.58 |    0.03 |
| ExtensionMethod_UInt64 | .NET 8.0             |  4.1317 ns | 0.0871 ns | 0.0518 ns |  1.12 |    0.02 |
| ExtensionMethod_Int64  | .NET 8.0             |  4.1317 ns | 0.0776 ns | 0.0513 ns |  1.12 |    0.01 |
| ExtensionMethod_UInt32 | .NET 8.0             |  2.7535 ns | 0.0385 ns | 0.0229 ns |  0.75 |    0.01 |
| ExtensionMethod_Int32  | .NET 8.0             |  1.8989 ns | 0.0288 ns | 0.0190 ns |  0.51 |    0.00 |
| ExtensionMethod_UInt16 | .NET 8.0             |  1.1917 ns | 0.0321 ns | 0.0191 ns |  0.32 |    0.01 |
| ExtensionMethod_Int16  | .NET 8.0             |  1.1263 ns | 0.0475 ns | 0.0343 ns |  0.31 |    0.01 |
| ByteIndexer_Double     | .NET 8.0             |  3.7649 ns | 0.1037 ns | 0.0686 ns |  1.02 |    0.02 |
| ByteIndexer_Float      | .NET 8.0             |  5.5713 ns | 0.1272 ns | 0.0842 ns |  1.51 |    0.02 |
| ByteIndexer_UInt64     | .NET 8.0             |  3.4640 ns | 0.0986 ns | 0.0923 ns |  0.95 |    0.02 |
| ByteIndexer_Int64      | .NET 8.0             |  3.7632 ns | 0.0466 ns | 0.0308 ns |  1.02 |    0.01 |
| ByteIndexer_UInt32     | .NET 8.0             |  1.8741 ns | 0.0340 ns | 0.0202 ns |  0.51 |    0.00 |
| ByteIndexer_Int32      | .NET 8.0             |  2.1118 ns | 0.0494 ns | 0.0327 ns |  0.57 |    0.01 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.6943 ns | 0.0125 ns | 0.0074 ns |  0.19 |    0.00 |
| ByteIndexer_Int16      | .NET 8.0             |  0.6416 ns | 0.0221 ns | 0.0131 ns |  0.17 |    0.00 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 | 25.3202 ns | 0.4961 ns | 0.3282 ns |  6.84 |    0.10 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 | 23.2837 ns | 0.2243 ns | 0.1484 ns |  6.30 |    0.05 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 | 25.7376 ns | 0.4765 ns | 0.3445 ns |  6.96 |    0.09 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 | 24.3970 ns | 0.3492 ns | 0.2078 ns |  6.60 |    0.07 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 | 23.1230 ns | 0.3412 ns | 0.1785 ns |  6.26 |    0.05 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 | 22.4339 ns | 0.2978 ns | 0.1970 ns |  6.08 |    0.07 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 | 22.4839 ns | 0.2558 ns | 0.1522 ns |  6.09 |    0.05 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 | 20.7772 ns | 0.2820 ns | 0.1865 ns |  5.62 |    0.07 |
| ExtensionMethod_Double | .NET Framework 4.6.2 | 10.7323 ns | 0.1171 ns | 0.0697 ns |  2.91 |    0.03 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 14.5689 ns | 0.2428 ns | 0.1606 ns |  3.95 |    0.04 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 | 10.7728 ns | 0.1367 ns | 0.0904 ns |  2.91 |    0.03 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 | 10.8048 ns | 0.0784 ns | 0.0410 ns |  2.92 |    0.02 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  5.2006 ns | 0.1014 ns | 0.0670 ns |  1.41 |    0.02 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  5.2233 ns | 0.0613 ns | 0.0365 ns |  1.41 |    0.01 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  2.8109 ns | 0.0773 ns | 0.0686 ns |  0.76 |    0.02 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  3.0989 ns | 0.1003 ns | 0.0938 ns |  0.86 |    0.02 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  9.4943 ns | 0.1582 ns | 0.1402 ns |  2.57 |    0.05 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 15.1945 ns | 0.5559 ns | 0.5200 ns |  4.14 |    0.15 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  7.2327 ns | 0.2860 ns | 0.2675 ns |  1.97 |    0.08 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  6.8782 ns | 0.3131 ns | 0.2929 ns |  1.85 |    0.09 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  3.2785 ns | 0.0903 ns | 0.0801 ns |  0.89 |    0.02 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  3.3560 ns | 0.1757 ns | 0.1643 ns |  0.92 |    0.05 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.7230 ns | 0.0780 ns | 0.0730 ns |  0.47 |    0.02 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.6421 ns | 0.0566 ns | 0.0502 ns |  0.44 |    0.01 |

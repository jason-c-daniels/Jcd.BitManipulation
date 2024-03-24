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

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0193 ns | 0.0227 ns | 0.0150 ns |  0.0243 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET 8.0             |  0.0091 ns | 0.0197 ns | 0.0165 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET 8.0             |  0.1683 ns | 0.0345 ns | 0.0305 ns |  0.1712 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET 8.0             |  0.0325 ns | 0.0345 ns | 0.0322 ns |  0.0287 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0168 ns | 0.0223 ns | 0.0133 ns |  0.0116 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET 8.0             |  0.0312 ns | 0.0426 ns | 0.0399 ns |  0.0059 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0864 ns | 0.0533 ns | 0.0498 ns |  0.0805 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET 8.0             |  0.0043 ns | 0.0095 ns | 0.0056 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Double | .NET 8.0             |  4.3543 ns | 0.0566 ns | 0.0296 ns |  4.3663 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET 8.0             |  6.2468 ns | 0.2119 ns | 0.1769 ns |  6.1946 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET 8.0             |  4.0355 ns | 0.0370 ns | 0.0245 ns |  4.0308 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET 8.0             |  4.1031 ns | 0.0941 ns | 0.0622 ns |  4.0933 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET 8.0             |  2.3967 ns | 0.0902 ns | 0.0800 ns |  2.3610 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET 8.0             |  2.3843 ns | 0.0303 ns | 0.0180 ns |  2.3808 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET 8.0             |  1.3748 ns | 0.0359 ns | 0.0237 ns |  1.3721 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET 8.0             |  1.3825 ns | 0.0346 ns | 0.0206 ns |  1.3812 ns |     ? |       ? |
| ByteIndexer_Double     | .NET 8.0             |  4.0101 ns | 0.0990 ns | 0.0773 ns |  3.9883 ns |     ? |       ? |
| ByteIndexer_Float      | .NET 8.0             |  5.7268 ns | 0.0588 ns | 0.0389 ns |  5.7301 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET 8.0             |  3.2817 ns | 0.0262 ns | 0.0156 ns |  3.2802 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET 8.0             |  3.3569 ns | 0.0892 ns | 0.0696 ns |  3.3418 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET 8.0             |  2.1741 ns | 0.0731 ns | 0.0571 ns |  2.1475 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET 8.0             |  2.1684 ns | 0.0863 ns | 0.0765 ns |  2.1377 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET 8.0             |  1.2207 ns | 0.0706 ns | 0.0626 ns |  1.1949 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET 8.0             |  1.1301 ns | 0.0459 ns | 0.0240 ns |  1.1260 ns |     ? |       ? |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  3.1094 ns | 0.2479 ns | 0.2318 ns |  3.1737 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.3955 ns | 0.1977 ns | 0.1752 ns |  2.3512 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  3.1912 ns | 0.1227 ns | 0.1148 ns |  3.2039 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  1.6567 ns | 0.1431 ns | 0.1339 ns |  1.6227 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  1.8460 ns | 0.1076 ns | 0.0954 ns |  1.8272 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  0.7492 ns | 0.0524 ns | 0.0490 ns |  0.7428 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  2.9502 ns | 0.0592 ns | 0.0352 ns |  2.9561 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  1.4355 ns | 0.2974 ns | 0.2782 ns |  1.3595 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 | 10.7893 ns | 0.0721 ns | 0.0429 ns | 10.7763 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 16.5791 ns | 2.6243 ns | 2.3264 ns | 15.5477 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 | 11.1642 ns | 0.6546 ns | 0.6123 ns | 11.0627 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 | 10.7691 ns | 0.2489 ns | 0.2206 ns | 10.7286 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  5.3831 ns | 0.3504 ns | 0.3278 ns |  5.3641 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  5.3433 ns | 0.2051 ns | 0.1918 ns |  5.2961 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  2.8366 ns | 0.1148 ns | 0.1018 ns |  2.8124 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  2.8701 ns | 0.0892 ns | 0.0745 ns |  2.8768 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  9.6947 ns | 0.3421 ns | 0.3200 ns |  9.6448 ns |     ? |       ? |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 16.6060 ns | 1.6514 ns | 1.4639 ns | 16.2008 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  6.8507 ns | 0.2017 ns | 0.1788 ns |  6.8023 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  6.7098 ns | 0.2517 ns | 0.2354 ns |  6.6579 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  3.0584 ns | 0.0752 ns | 0.0497 ns |  3.0371 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  2.9936 ns | 0.0586 ns | 0.0349 ns |  2.9954 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.5768 ns | 0.0252 ns | 0.0167 ns |  1.5783 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.5667 ns | 0.0359 ns | 0.0237 ns |  1.5615 ns |     ? |       ? |

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

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0680 ns | 0.0663 ns | 0.0620 ns |  0.0592 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET 8.0             |  0.0264 ns | 0.0263 ns | 0.0246 ns |  0.0162 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET 8.0             |  0.0895 ns | 0.0081 ns | 0.0053 ns |  0.0901 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET 8.0             |  0.0097 ns | 0.0188 ns | 0.0176 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET 8.0             |  0.0070 ns | 0.0123 ns | 0.0081 ns |  0.0040 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0001 ns | 0.0007 ns | 0.0004 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET 8.0             |  0.0010 ns | 0.0027 ns | 0.0018 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Double | .NET 8.0             |  3.5159 ns | 0.0598 ns | 0.0356 ns |  3.5178 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET 8.0             |  1.5668 ns | 0.0327 ns | 0.0171 ns |  1.5661 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET 8.0             |  3.2335 ns | 0.0477 ns | 0.0284 ns |  3.2360 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET 8.0             |  3.1534 ns | 0.2524 ns | 0.2361 ns |  3.0786 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET 8.0             |  2.3707 ns | 0.2046 ns | 0.1914 ns |  2.3634 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET 8.0             |  2.2568 ns | 0.2638 ns | 0.2468 ns |  2.2559 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET 8.0             |  1.1122 ns | 0.0273 ns | 0.0181 ns |  1.1191 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET 8.0             |  1.1151 ns | 0.0347 ns | 0.0230 ns |  1.1111 ns |     ? |       ? |
| ByteIndexer_Double     | .NET 8.0             |  3.3882 ns | 0.0469 ns | 0.0279 ns |  3.3908 ns |     ? |       ? |
| ByteIndexer_Float      | .NET 8.0             |  1.6121 ns | 0.0759 ns | 0.0710 ns |  1.5985 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET 8.0             |  3.6545 ns | 0.1856 ns | 0.1736 ns |  3.6026 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET 8.0             |  3.6784 ns | 0.0860 ns | 0.0569 ns |  3.6854 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET 8.0             |  2.2012 ns | 0.1005 ns | 0.0940 ns |  2.2102 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET 8.0             |  2.1825 ns | 0.0721 ns | 0.0602 ns |  2.1736 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET 8.0             |  1.3643 ns | 0.0958 ns | 0.0896 ns |  1.3947 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET 8.0             |  1.1385 ns | 0.0526 ns | 0.0466 ns |  1.1607 ns |     ? |       ? |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  2.8311 ns | 0.1107 ns | 0.1035 ns |  2.8315 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.2682 ns | 0.0747 ns | 0.0623 ns |  2.2792 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  3.0755 ns | 0.0815 ns | 0.0723 ns |  3.0580 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  1.6877 ns | 0.0848 ns | 0.0793 ns |  1.7039 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  1.8605 ns | 0.0732 ns | 0.0611 ns |  1.8703 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  0.8730 ns | 0.0503 ns | 0.0446 ns |  0.8712 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  3.2892 ns | 0.1995 ns | 0.1866 ns |  3.2401 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  1.2118 ns | 0.2010 ns | 0.1679 ns |  1.1954 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  6.5548 ns | 0.0802 ns | 0.0530 ns |  6.5570 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 12.7720 ns | 0.2408 ns | 0.1433 ns | 12.8056 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  5.7719 ns | 0.1228 ns | 0.0812 ns |  5.7865 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  5.8213 ns | 0.1255 ns | 0.0908 ns |  5.7982 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  2.8041 ns | 0.0894 ns | 0.0793 ns |  2.7950 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  2.7347 ns | 0.0553 ns | 0.0329 ns |  2.7237 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  1.3254 ns | 0.0525 ns | 0.0465 ns |  1.3315 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  1.3840 ns | 0.0579 ns | 0.0483 ns |  1.3770 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  6.4436 ns | 0.0984 ns | 0.0651 ns |  6.4381 ns |     ? |       ? |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 12.3441 ns | 0.3291 ns | 0.3078 ns | 12.2533 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  5.7135 ns | 0.0934 ns | 0.0618 ns |  5.7054 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  5.7230 ns | 0.1375 ns | 0.0909 ns |  5.7064 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  2.7063 ns | 0.0630 ns | 0.0492 ns |  2.6955 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  2.7162 ns | 0.0735 ns | 0.0652 ns |  2.6963 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.2292 ns | 0.0337 ns | 0.0200 ns |  1.2298 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.2517 ns | 0.0456 ns | 0.0271 ns |  1.2512 ns |     ? |       ? |

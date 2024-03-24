```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-FHTXZD : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-HTTFOE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0002 ns | 0.0010 ns | 0.0009 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET 8.0             |  0.0184 ns | 0.0181 ns | 0.0095 ns |  0.0222 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET 8.0             |  0.0760 ns | 0.0312 ns | 0.0276 ns |  0.0701 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET 8.0             |  0.0126 ns | 0.0212 ns | 0.0153 ns |  0.0050 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0012 ns | 0.0030 ns | 0.0020 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET 8.0             |  0.0627 ns | 0.0504 ns | 0.0472 ns |  0.0450 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET 8.0             |  0.2482 ns | 0.2335 ns | 0.2184 ns |  0.1154 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET 8.0             |  0.0215 ns | 0.0287 ns | 0.0268 ns |  0.0132 ns |     ? |       ? |
| ExtensionMethod_Double | .NET 8.0             |  3.6749 ns | 0.1436 ns | 0.1344 ns |  3.6465 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET 8.0             |  1.6399 ns | 0.0790 ns | 0.0701 ns |  1.6313 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET 8.0             |  3.6051 ns | 0.2506 ns | 0.2344 ns |  3.5961 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET 8.0             |  3.2461 ns | 0.1851 ns | 0.1731 ns |  3.2320 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET 8.0             |  2.6740 ns | 0.2840 ns | 0.2657 ns |  2.7904 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET 8.0             |  2.4636 ns | 0.2047 ns | 0.1815 ns |  2.4296 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET 8.0             |  1.2545 ns | 0.1150 ns | 0.1075 ns |  1.2551 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET 8.0             |  1.1199 ns | 0.0347 ns | 0.0230 ns |  1.1265 ns |     ? |       ? |
| ByteIndexer_Double     | .NET 8.0             |  3.1691 ns | 0.0554 ns | 0.0329 ns |  3.1719 ns |     ? |       ? |
| ByteIndexer_Float      | .NET 8.0             |  1.6542 ns | 0.0647 ns | 0.0573 ns |  1.6540 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET 8.0             |  3.6838 ns | 0.0976 ns | 0.0646 ns |  3.6778 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET 8.0             |  4.0469 ns | 0.1102 ns | 0.0921 ns |  4.0210 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET 8.0             |  2.5527 ns | 0.1474 ns | 0.1379 ns |  2.5611 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET 8.0             |  2.2926 ns | 0.0782 ns | 0.0732 ns |  2.2935 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET 8.0             |  1.1783 ns | 0.0466 ns | 0.0337 ns |  1.1842 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET 8.0             |  1.1850 ns | 0.0624 ns | 0.0584 ns |  1.1608 ns |     ? |       ? |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  2.7346 ns | 0.0767 ns | 0.0507 ns |  2.7295 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.2109 ns | 0.0708 ns | 0.0628 ns |  2.2039 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  3.0104 ns | 0.0500 ns | 0.0331 ns |  3.0064 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  1.5154 ns | 0.0497 ns | 0.0296 ns |  1.4997 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  1.8425 ns | 0.0894 ns | 0.0836 ns |  1.7905 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  0.8871 ns | 0.0492 ns | 0.0461 ns |  0.9008 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  2.7812 ns | 0.0767 ns | 0.0599 ns |  2.7933 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  1.0888 ns | 0.0471 ns | 0.0440 ns |  1.0719 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  6.2749 ns | 0.0480 ns | 0.0285 ns |  6.2759 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 12.4653 ns | 0.1649 ns | 0.1091 ns | 12.4700 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  5.8714 ns | 0.0870 ns | 0.0576 ns |  5.8768 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  5.7408 ns | 0.0618 ns | 0.0323 ns |  5.7430 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  2.7651 ns | 0.0832 ns | 0.0737 ns |  2.7464 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  2.7297 ns | 0.0928 ns | 0.0775 ns |  2.6985 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  1.2838 ns | 0.0191 ns | 0.0127 ns |  1.2828 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  1.3349 ns | 0.0451 ns | 0.0298 ns |  1.3236 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  6.3348 ns | 0.0605 ns | 0.0400 ns |  6.3333 ns |     ? |       ? |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 12.2136 ns | 0.2606 ns | 0.1884 ns | 12.1965 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  5.7749 ns | 0.1290 ns | 0.0933 ns |  5.7728 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  5.5695 ns | 0.0629 ns | 0.0374 ns |  5.5637 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  2.7956 ns | 0.0977 ns | 0.0914 ns |  2.8235 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  2.6683 ns | 0.0661 ns | 0.0437 ns |  2.6616 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.2592 ns | 0.0641 ns | 0.0569 ns |  1.2643 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.3137 ns | 0.0474 ns | 0.0420 ns |  1.3192 ns |     ? |       ? |

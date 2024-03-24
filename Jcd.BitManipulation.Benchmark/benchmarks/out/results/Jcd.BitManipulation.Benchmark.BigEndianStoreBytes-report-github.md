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

| Method                 | Runtime              |       Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  1.6530 ns | 0.2255 ns | 0.2110 ns |  0.41 |    0.04 |
| BitConverter_ToFloat   | .NET 8.0             |  1.5225 ns | 0.0646 ns | 0.0604 ns |  0.40 |    0.02 |
| BitConverter_ToUInt64  | .NET 8.0             |  1.2824 ns | 0.0718 ns | 0.0672 ns |  0.33 |    0.02 |
| BitConverter_ToInt64   | .NET 8.0             |  1.6980 ns | 0.0440 ns | 0.0230 ns |  0.45 |    0.01 |
| BitConverter_ToUInt32  | .NET 8.0             |  1.7077 ns | 0.0557 ns | 0.0435 ns |  0.45 |    0.01 |
| BitConverter_ToInt32   | .NET 8.0             |  1.4766 ns | 0.0478 ns | 0.0423 ns |  0.39 |    0.01 |
| BitConverter_ToUInt16  | .NET 8.0             |  3.2427 ns | 0.0682 ns | 0.0451 ns |  0.86 |    0.01 |
| BitConverter_ToInt16   | .NET 8.0             |  3.7808 ns | 0.0522 ns | 0.0345 ns |  1.00 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  4.0435 ns | 0.1681 ns | 0.1573 ns |  1.08 |    0.05 |
| ExtensionMethod_Float  | .NET 8.0             |  2.0446 ns | 0.0663 ns | 0.0554 ns |  0.54 |    0.02 |
| ExtensionMethod_UInt64 | .NET 8.0             |  3.8826 ns | 0.1031 ns | 0.0805 ns |  1.02 |    0.02 |
| ExtensionMethod_Int64  | .NET 8.0             |  3.5592 ns | 0.0987 ns | 0.0924 ns |  0.94 |    0.02 |
| ExtensionMethod_UInt32 | .NET 8.0             |  1.6674 ns | 0.0199 ns | 0.0104 ns |  0.44 |    0.01 |
| ExtensionMethod_Int32  | .NET 8.0             |  1.7086 ns | 0.0523 ns | 0.0346 ns |  0.45 |    0.01 |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.7812 ns | 0.0263 ns | 0.0174 ns |  0.21 |    0.01 |
| ExtensionMethod_Int16  | .NET 8.0             |  0.8056 ns | 0.0391 ns | 0.0259 ns |  0.21 |    0.01 |
| ByteIndexer_Double     | .NET 8.0             |  3.8331 ns | 0.0887 ns | 0.0528 ns |  1.01 |    0.01 |
| ByteIndexer_Float      | .NET 8.0             |  2.1120 ns | 0.0636 ns | 0.0421 ns |  0.56 |    0.01 |
| ByteIndexer_UInt64     | .NET 8.0             |  3.8732 ns | 0.1579 ns | 0.1477 ns |  1.01 |    0.02 |
| ByteIndexer_Int64      | .NET 8.0             |  3.4947 ns | 0.1010 ns | 0.0730 ns |  0.92 |    0.03 |
| ByteIndexer_UInt32     | .NET 8.0             |  1.9299 ns | 0.0625 ns | 0.0414 ns |  0.51 |    0.01 |
| ByteIndexer_Int32      | .NET 8.0             |  2.1142 ns | 0.0510 ns | 0.0304 ns |  0.56 |    0.01 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.7167 ns | 0.0363 ns | 0.0283 ns |  0.19 |    0.01 |
| ByteIndexer_Int16      | .NET 8.0             |  0.6289 ns | 0.0302 ns | 0.0180 ns |  0.17 |    0.01 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 | 25.2923 ns | 0.2981 ns | 0.1774 ns |  6.69 |    0.09 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 | 23.5080 ns | 0.3428 ns | 0.2268 ns |  6.22 |    0.09 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 | 25.6472 ns | 0.3391 ns | 0.2018 ns |  6.78 |    0.11 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 | 24.4777 ns | 0.2443 ns | 0.1454 ns |  6.47 |    0.07 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 | 23.1697 ns | 0.2989 ns | 0.1779 ns |  6.13 |    0.08 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 | 22.5156 ns | 0.3701 ns | 0.2448 ns |  5.96 |    0.08 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 | 22.8349 ns | 0.2426 ns | 0.1605 ns |  6.04 |    0.08 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 | 20.9575 ns | 0.3336 ns | 0.1985 ns |  5.54 |    0.06 |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  6.8044 ns | 0.0748 ns | 0.0495 ns |  1.80 |    0.03 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 12.4695 ns | 0.2664 ns | 0.1762 ns |  3.30 |    0.05 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  6.5231 ns | 0.0654 ns | 0.0432 ns |  1.73 |    0.02 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  6.5063 ns | 0.0688 ns | 0.0455 ns |  1.72 |    0.01 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  3.0097 ns | 0.0822 ns | 0.0686 ns |  0.79 |    0.02 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  2.9324 ns | 0.0285 ns | 0.0169 ns |  0.78 |    0.01 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  1.4071 ns | 0.0498 ns | 0.0466 ns |  0.37 |    0.01 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  1.5239 ns | 0.0723 ns | 0.0641 ns |  0.40 |    0.02 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  6.8415 ns | 0.0765 ns | 0.0506 ns |  1.81 |    0.02 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 12.9955 ns | 0.3505 ns | 0.3279 ns |  3.42 |    0.09 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  6.4387 ns | 0.0757 ns | 0.0451 ns |  1.70 |    0.02 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  6.6340 ns | 0.1530 ns | 0.1432 ns |  1.76 |    0.04 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  3.5904 ns | 0.4506 ns | 0.3995 ns |  0.95 |    0.09 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  3.1897 ns | 0.1674 ns | 0.1484 ns |  0.85 |    0.04 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.3998 ns | 0.0905 ns | 0.0847 ns |  0.37 |    0.02 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.6932 ns | 0.1822 ns | 0.1704 ns |  0.47 |    0.05 |

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

| Method                 | Runtime              |       Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  1.4667 ns | 0.0239 ns | 0.0158 ns |  0.39 |    0.00 |
| BitConverter_ToFloat   | .NET 8.0             |  1.5930 ns | 0.0563 ns | 0.0527 ns |  0.42 |    0.01 |
| BitConverter_ToUInt64  | .NET 8.0             |  1.2545 ns | 0.0181 ns | 0.0120 ns |  0.33 |    0.00 |
| BitConverter_ToInt64   | .NET 8.0             |  1.6960 ns | 0.0232 ns | 0.0138 ns |  0.45 |    0.00 |
| BitConverter_ToUInt32  | .NET 8.0             |  1.2222 ns | 0.0177 ns | 0.0117 ns |  0.32 |    0.00 |
| BitConverter_ToInt32   | .NET 8.0             |  1.6704 ns | 0.0310 ns | 0.0205 ns |  0.44 |    0.01 |
| BitConverter_ToUInt16  | .NET 8.0             |  3.5800 ns | 0.0108 ns | 0.0064 ns |  0.94 |    0.01 |
| BitConverter_ToInt16   | .NET 8.0             |  3.7986 ns | 0.0267 ns | 0.0176 ns |  1.00 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  4.0927 ns | 0.0391 ns | 0.0232 ns |  1.08 |    0.01 |
| ExtensionMethod_Float  | .NET 8.0             |  2.0486 ns | 0.0356 ns | 0.0235 ns |  0.54 |    0.01 |
| ExtensionMethod_UInt64 | .NET 8.0             |  4.1574 ns | 0.0331 ns | 0.0219 ns |  1.09 |    0.01 |
| ExtensionMethod_Int64  | .NET 8.0             |  3.8448 ns | 0.0316 ns | 0.0209 ns |  1.01 |    0.01 |
| ExtensionMethod_UInt32 | .NET 8.0             |  1.6779 ns | 0.0171 ns | 0.0113 ns |  0.44 |    0.00 |
| ExtensionMethod_Int32  | .NET 8.0             |  1.6836 ns | 0.0105 ns | 0.0070 ns |  0.44 |    0.00 |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.7973 ns | 0.0112 ns | 0.0066 ns |  0.21 |    0.00 |
| ExtensionMethod_Int16  | .NET 8.0             |  0.8071 ns | 0.0209 ns | 0.0138 ns |  0.21 |    0.00 |
| ByteIndexer_Double     | .NET 8.0             |  4.1086 ns | 0.0296 ns | 0.0195 ns |  1.08 |    0.01 |
| ByteIndexer_Float      | .NET 8.0             |  2.0861 ns | 0.0292 ns | 0.0174 ns |  0.55 |    0.01 |
| ByteIndexer_UInt64     | .NET 8.0             |  3.7977 ns | 0.0306 ns | 0.0203 ns |  1.00 |    0.01 |
| ByteIndexer_Int64      | .NET 8.0             |  3.7899 ns | 0.0962 ns | 0.0636 ns |  1.00 |    0.02 |
| ByteIndexer_UInt32     | .NET 8.0             |  1.8963 ns | 0.0327 ns | 0.0216 ns |  0.50 |    0.01 |
| ByteIndexer_Int32      | .NET 8.0             |  2.1239 ns | 0.0335 ns | 0.0222 ns |  0.56 |    0.01 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.7260 ns | 0.0202 ns | 0.0106 ns |  0.19 |    0.00 |
| ByteIndexer_Int16      | .NET 8.0             |  0.6608 ns | 0.0217 ns | 0.0144 ns |  0.17 |    0.00 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 | 26.0876 ns | 0.1895 ns | 0.1254 ns |  6.87 |    0.05 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 | 24.1584 ns | 0.4158 ns | 0.2750 ns |  6.36 |    0.07 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 | 25.2476 ns | 0.5114 ns | 0.3698 ns |  6.64 |    0.09 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 | 24.9522 ns | 0.1286 ns | 0.0766 ns |  6.57 |    0.03 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 | 24.2318 ns | 0.2092 ns | 0.1384 ns |  6.38 |    0.05 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 | 23.2776 ns | 0.1238 ns | 0.0819 ns |  6.13 |    0.04 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 | 23.4701 ns | 0.1797 ns | 0.1188 ns |  6.18 |    0.03 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 | 21.5239 ns | 0.1586 ns | 0.1049 ns |  5.67 |    0.04 |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  6.8407 ns | 0.0570 ns | 0.0377 ns |  1.80 |    0.01 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 12.5444 ns | 0.1055 ns | 0.0698 ns |  3.30 |    0.03 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  6.4308 ns | 0.0387 ns | 0.0256 ns |  1.69 |    0.01 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  6.4241 ns | 0.0657 ns | 0.0435 ns |  1.69 |    0.02 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  2.9687 ns | 0.0306 ns | 0.0182 ns |  0.78 |    0.01 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  2.9698 ns | 0.0419 ns | 0.0277 ns |  0.78 |    0.01 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  1.4250 ns | 0.0099 ns | 0.0059 ns |  0.38 |    0.00 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  1.4478 ns | 0.0180 ns | 0.0094 ns |  0.38 |    0.00 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  6.7941 ns | 0.0459 ns | 0.0304 ns |  1.79 |    0.01 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 12.8756 ns | 0.1417 ns | 0.0938 ns |  3.39 |    0.02 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  6.4108 ns | 0.1056 ns | 0.0698 ns |  1.69 |    0.02 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  6.4146 ns | 0.0363 ns | 0.0240 ns |  1.69 |    0.01 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  2.9193 ns | 0.0359 ns | 0.0237 ns |  0.77 |    0.01 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  2.9146 ns | 0.0200 ns | 0.0119 ns |  0.77 |    0.00 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.3769 ns | 0.0118 ns | 0.0070 ns |  0.36 |    0.00 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.3811 ns | 0.0156 ns | 0.0082 ns |  0.36 |    0.00 |

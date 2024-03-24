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
| BitConverter_ToDouble  | .NET 8.0             |  0.0023 ns | 0.0049 ns | 0.0032 ns |  0.0006 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET 8.0             |  0.0026 ns | 0.0054 ns | 0.0036 ns |  0.0006 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET 8.0             |  0.1340 ns | 0.0059 ns | 0.0035 ns |  0.1345 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET 8.0             |  0.0022 ns | 0.0041 ns | 0.0021 ns |  0.0022 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0045 ns | 0.0103 ns | 0.0068 ns |  0.0006 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0006 ns | 0.0022 ns | 0.0013 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET 8.0             |  0.0012 ns | 0.0046 ns | 0.0031 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Double | .NET 8.0             |  0.0021 ns | 0.0066 ns | 0.0044 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET 8.0             |  3.9138 ns | 0.0500 ns | 0.0297 ns |  3.9273 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0010 ns | 0.0032 ns | 0.0021 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0025 ns | 0.0070 ns | 0.0042 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0016 ns | 0.0037 ns | 0.0022 ns |  0.0004 ns |     ? |       ? |
| ByteIndexer_Double     | .NET 8.0             |  0.0002 ns | 0.0008 ns | 0.0005 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Float      | .NET 8.0             |  3.9530 ns | 0.0953 ns | 0.0630 ns |  3.9603 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0005 ns | 0.0021 ns | 0.0014 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0081 ns | 0.0175 ns | 0.0104 ns |  0.0046 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET 8.0             |  0.0019 ns | 0.0035 ns | 0.0023 ns |  0.0009 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0010 ns | 0.0020 ns | 0.0013 ns |  0.0007 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET 8.0             |  0.0015 ns | 0.0039 ns | 0.0026 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  2.7342 ns | 0.0315 ns | 0.0209 ns |  2.7353 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.1763 ns | 0.0308 ns | 0.0204 ns |  2.1833 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  3.0072 ns | 0.0487 ns | 0.0322 ns |  3.0116 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  1.5604 ns | 0.0288 ns | 0.0191 ns |  1.5599 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  1.7901 ns | 0.0453 ns | 0.0299 ns |  1.7781 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  0.8430 ns | 0.0138 ns | 0.0091 ns |  0.8421 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  2.9328 ns | 0.0187 ns | 0.0124 ns |  2.9372 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  1.1355 ns | 0.0837 ns | 0.0783 ns |  1.1000 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.0956 ns | 0.0237 ns | 0.0171 ns |  0.0955 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.6014 ns | 0.1094 ns | 0.0723 ns |  9.6111 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.1353 ns | 0.0149 ns | 0.0098 ns |  0.1360 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.0951 ns | 0.0113 ns | 0.0075 ns |  0.0964 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0365 ns | 0.0070 ns | 0.0046 ns |  0.0376 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0373 ns | 0.0229 ns | 0.0151 ns |  0.0402 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.3480 ns | 0.0663 ns | 0.0620 ns |  1.3365 ns |     ? |       ? |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 11.8713 ns | 0.1846 ns | 0.1541 ns | 11.8551 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.9630 ns | 0.0449 ns | 0.0297 ns |  1.9763 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  2.0562 ns | 0.1749 ns | 0.1636 ns |  1.9811 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.2432 ns | 0.0105 ns | 0.0070 ns |  1.2421 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.2527 ns | 0.0253 ns | 0.0151 ns |  1.2547 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  2.0171 ns | 0.1256 ns | 0.1175 ns |  1.9873 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.8220 ns | 0.0409 ns | 0.0270 ns |  1.8126 ns |     ? |       ? |

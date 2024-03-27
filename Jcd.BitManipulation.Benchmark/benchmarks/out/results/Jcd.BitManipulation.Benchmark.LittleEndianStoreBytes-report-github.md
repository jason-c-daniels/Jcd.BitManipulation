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

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0378 ns | 0.0381 ns | 0.0338 ns |  0.0288 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET 8.0             |  0.0284 ns | 0.0308 ns | 0.0273 ns |  0.0208 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET 8.0             |  0.1542 ns | 0.0287 ns | 0.0254 ns |  0.1581 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET 8.0             |  0.0055 ns | 0.0075 ns | 0.0049 ns |  0.0068 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0304 ns | 0.0221 ns | 0.0131 ns |  0.0340 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET 8.0             |  0.0736 ns | 0.0821 ns | 0.0768 ns |  0.0333 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0811 ns | 0.1219 ns | 0.1141 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET 8.0             |  0.0072 ns | 0.0257 ns | 0.0240 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Double | .NET 8.0             |  3.3642 ns | 0.9538 ns | 0.8921 ns |  2.9916 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET 8.0             |  0.9538 ns | 0.1262 ns | 0.1118 ns |  0.9625 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET 8.0             |  2.5530 ns | 0.2253 ns | 0.2108 ns |  2.4948 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET 8.0             |  1.4965 ns | 0.1435 ns | 0.1343 ns |  1.5010 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.4643 ns | 0.0735 ns | 0.0614 ns |  0.4593 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET 8.0             |  0.3618 ns | 0.0399 ns | 0.0288 ns |  0.3653 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.1819 ns | 0.0563 ns | 0.0526 ns |  0.1728 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET 8.0             |  0.1387 ns | 0.0646 ns | 0.0604 ns |  0.1319 ns |     ? |       ? |
| ByteIndexer_Double     | .NET 8.0             |  1.8069 ns | 0.0886 ns | 0.0786 ns |  1.8091 ns |     ? |       ? |
| ByteIndexer_Float      | .NET 8.0             |  0.7270 ns | 0.1202 ns | 0.1125 ns |  0.7282 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET 8.0             |  1.5052 ns | 0.0905 ns | 0.0802 ns |  1.4819 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET 8.0             |  1.2767 ns | 0.0805 ns | 0.0753 ns |  1.2905 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET 8.0             |  0.6167 ns | 0.0543 ns | 0.0481 ns |  0.6017 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET 8.0             |  0.3654 ns | 0.0673 ns | 0.0597 ns |  0.3473 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET 8.0             |  0.1229 ns | 0.0371 ns | 0.0329 ns |  0.1255 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET 8.0             |  0.2318 ns | 0.0594 ns | 0.0527 ns |  0.2337 ns |     ? |       ? |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  2.9175 ns | 0.0944 ns | 0.0883 ns |  2.9025 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.3129 ns | 0.1039 ns | 0.0972 ns |  2.2923 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  3.0635 ns | 0.0842 ns | 0.0440 ns |  3.0760 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  1.6026 ns | 0.0513 ns | 0.0371 ns |  1.6175 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  1.7718 ns | 0.0336 ns | 0.0200 ns |  1.7684 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  0.9661 ns | 0.1151 ns | 0.1077 ns |  0.9700 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  2.9578 ns | 0.0613 ns | 0.0320 ns |  2.9650 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  1.2341 ns | 0.1104 ns | 0.1033 ns |  1.2084 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  3.3166 ns | 0.1778 ns | 0.1576 ns |  3.3412 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 11.2206 ns | 0.1698 ns | 0.1123 ns | 11.2303 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  2.6404 ns | 0.0723 ns | 0.0603 ns |  2.6219 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  2.5903 ns | 0.0496 ns | 0.0328 ns |  2.5827 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  1.1756 ns | 0.0530 ns | 0.0443 ns |  1.1841 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  1.2568 ns | 0.0379 ns | 0.0226 ns |  1.2615 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  1.0018 ns | 0.0809 ns | 0.0757 ns |  0.9719 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  1.0053 ns | 0.0413 ns | 0.0345 ns |  1.0018 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  3.0090 ns | 0.0113 ns | 0.0059 ns |  3.0096 ns |     ? |       ? |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 11.3863 ns | 0.2239 ns | 0.1619 ns | 11.3198 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  3.5115 ns | 0.1029 ns | 0.0962 ns |  3.5029 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  3.3300 ns | 0.0586 ns | 0.0349 ns |  3.3288 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  2.0411 ns | 0.1608 ns | 0.1504 ns |  2.0185 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.7710 ns | 0.0394 ns | 0.0261 ns |  1.7681 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  0.9096 ns | 0.0260 ns | 0.0155 ns |  0.9048 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.1265 ns | 0.1474 ns | 0.1378 ns |  1.1562 ns |     ? |       ? |

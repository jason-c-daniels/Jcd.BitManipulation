```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ZHKFEE : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-PRZSWO : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0416 ns | 0.0390 ns | 0.0346 ns |  0.0372 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET 8.0             |  0.0107 ns | 0.0234 ns | 0.0219 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET 8.0             |  0.1159 ns | 0.0113 ns | 0.0067 ns |  0.1158 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET 8.0             |  0.0359 ns | 0.0302 ns | 0.0282 ns |  0.0373 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0523 ns | 0.0872 ns | 0.0815 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET 8.0             |  0.0859 ns | 0.0789 ns | 0.0738 ns |  0.0615 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET 8.0             |  0.1154 ns | 0.1471 ns | 0.1376 ns |  0.0147 ns |     ? |       ? |
| ExtensionMethod_Double | .NET 8.0             |  1.4064 ns | 0.0314 ns | 0.0208 ns |  1.4068 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET 8.0             |  0.3484 ns | 0.0260 ns | 0.0155 ns |  0.3534 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET 8.0             |  1.2693 ns | 0.0324 ns | 0.0214 ns |  1.2689 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET 8.0             |  1.2924 ns | 0.0381 ns | 0.0252 ns |  1.2966 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.5397 ns | 0.0150 ns | 0.0078 ns |  0.5391 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET 8.0             |  0.4989 ns | 0.0231 ns | 0.0121 ns |  0.5000 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.1158 ns | 0.0231 ns | 0.0153 ns |  0.1177 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET 8.0             |  0.1323 ns | 0.0242 ns | 0.0160 ns |  0.1349 ns |     ? |       ? |
| ByteIndexer_Double     | .NET 8.0             |  1.7080 ns | 0.1982 ns | 0.1854 ns |  1.7327 ns |     ? |       ? |
| ByteIndexer_Float      | .NET 8.0             |  0.4319 ns | 0.0832 ns | 0.0778 ns |  0.4298 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET 8.0             |  1.3014 ns | 0.0516 ns | 0.0483 ns |  1.3112 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET 8.0             |  1.3417 ns | 0.0589 ns | 0.0522 ns |  1.3251 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET 8.0             |  0.3500 ns | 0.0252 ns | 0.0167 ns |  0.3486 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET 8.0             |  0.3585 ns | 0.0422 ns | 0.0374 ns |  0.3448 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET 8.0             |  0.1505 ns | 0.0298 ns | 0.0279 ns |  0.1414 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET 8.0             |  0.1594 ns | 0.0281 ns | 0.0186 ns |  0.1638 ns |     ? |       ? |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  2.7681 ns | 0.0765 ns | 0.0506 ns |  2.7583 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.1643 ns | 0.0616 ns | 0.0481 ns |  2.1615 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  2.9660 ns | 0.0237 ns | 0.0124 ns |  2.9657 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  1.5485 ns | 0.0502 ns | 0.0420 ns |  1.5502 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  1.7846 ns | 0.0478 ns | 0.0250 ns |  1.7878 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  0.8817 ns | 0.0494 ns | 0.0462 ns |  0.8801 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  3.0073 ns | 0.0799 ns | 0.0624 ns |  3.0123 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  1.0276 ns | 0.0271 ns | 0.0180 ns |  1.0239 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  3.1850 ns | 0.0854 ns | 0.0565 ns |  3.1949 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 11.2516 ns | 0.2203 ns | 0.1457 ns | 11.2220 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  2.6546 ns | 0.0602 ns | 0.0398 ns |  2.6410 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  2.6404 ns | 0.0500 ns | 0.0297 ns |  2.6498 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  1.1917 ns | 0.0348 ns | 0.0230 ns |  1.1859 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  1.1661 ns | 0.0451 ns | 0.0377 ns |  1.1743 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.9121 ns | 0.0209 ns | 0.0138 ns |  0.9051 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.9169 ns | 0.0327 ns | 0.0273 ns |  0.9115 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  2.9661 ns | 0.0703 ns | 0.0465 ns |  2.9794 ns |     ? |       ? |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 11.0120 ns | 0.1512 ns | 0.1000 ns | 11.0440 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  3.4058 ns | 0.0533 ns | 0.0317 ns |  3.4057 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  3.3627 ns | 0.0473 ns | 0.0247 ns |  3.3686 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.8018 ns | 0.0554 ns | 0.0366 ns |  1.7968 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.7720 ns | 0.0397 ns | 0.0236 ns |  1.7795 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  0.9186 ns | 0.0329 ns | 0.0292 ns |  0.9087 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  0.9538 ns | 0.0352 ns | 0.0233 ns |  0.9527 ns |     ? |       ? |

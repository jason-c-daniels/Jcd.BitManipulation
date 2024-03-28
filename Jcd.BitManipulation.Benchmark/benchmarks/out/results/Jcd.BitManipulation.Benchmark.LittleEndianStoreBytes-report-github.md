```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-WBOMYL : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-YFPBER : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0055 ns | 0.0119 ns | 0.0111 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET 8.0             |  0.0010 ns | 0.0036 ns | 0.0021 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET 8.0             |  0.1231 ns | 0.0075 ns | 0.0049 ns |  0.1225 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET 8.0             |  0.0049 ns | 0.0048 ns | 0.0031 ns |  0.0041 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0160 ns | 0.0238 ns | 0.0157 ns |  0.0128 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET 8.0             |  0.0022 ns | 0.0076 ns | 0.0045 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0137 ns | 0.0063 ns | 0.0042 ns |  0.0122 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET 8.0             |  0.0283 ns | 0.0346 ns | 0.0324 ns |  0.0175 ns |     ? |       ? |
| ExtensionMethod_Double | .NET 8.0             |  1.4589 ns | 0.0517 ns | 0.0432 ns |  1.4407 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET 8.0             |  0.3631 ns | 0.0261 ns | 0.0173 ns |  0.3601 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET 8.0             |  1.4037 ns | 0.0985 ns | 0.0921 ns |  1.3832 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET 8.0             |  1.2249 ns | 0.0120 ns | 0.0063 ns |  1.2273 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.5621 ns | 0.0053 ns | 0.0035 ns |  0.5619 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET 8.0             |  0.5613 ns | 0.0111 ns | 0.0058 ns |  0.5608 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.1405 ns | 0.0092 ns | 0.0055 ns |  0.1410 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET 8.0             |  0.1379 ns | 0.0116 ns | 0.0077 ns |  0.1384 ns |     ? |       ? |
| ByteIndexer_Double     | .NET 8.0             |  1.4763 ns | 0.0621 ns | 0.0581 ns |  1.4674 ns |     ? |       ? |
| ByteIndexer_Float      | .NET 8.0             |  0.3537 ns | 0.0274 ns | 0.0181 ns |  0.3520 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET 8.0             |  1.3485 ns | 0.0236 ns | 0.0156 ns |  1.3511 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET 8.0             |  1.3822 ns | 0.0551 ns | 0.0516 ns |  1.3815 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET 8.0             |  0.3874 ns | 0.0320 ns | 0.0231 ns |  0.3885 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET 8.0             |  0.3510 ns | 0.0311 ns | 0.0205 ns |  0.3482 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET 8.0             |  0.1873 ns | 0.0530 ns | 0.0495 ns |  0.1780 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET 8.0             |  0.1008 ns | 0.0065 ns | 0.0043 ns |  0.1009 ns |     ? |       ? |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  2.7213 ns | 0.0232 ns | 0.0154 ns |  2.7242 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.1890 ns | 0.0302 ns | 0.0179 ns |  2.1807 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  3.0189 ns | 0.0472 ns | 0.0312 ns |  3.0262 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  1.5439 ns | 0.0300 ns | 0.0198 ns |  1.5429 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  1.7969 ns | 0.0243 ns | 0.0145 ns |  1.7913 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  0.8453 ns | 0.0264 ns | 0.0174 ns |  0.8480 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  2.9844 ns | 0.0512 ns | 0.0339 ns |  2.9846 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  1.0535 ns | 0.0260 ns | 0.0155 ns |  1.0584 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  3.1880 ns | 0.0863 ns | 0.0624 ns |  3.2226 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 11.3071 ns | 0.1199 ns | 0.0793 ns | 11.2857 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  2.6687 ns | 0.0273 ns | 0.0181 ns |  2.6699 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  2.6974 ns | 0.0323 ns | 0.0214 ns |  2.6953 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  1.2285 ns | 0.0462 ns | 0.0386 ns |  1.2195 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  1.1694 ns | 0.0271 ns | 0.0142 ns |  1.1701 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.9612 ns | 0.0253 ns | 0.0150 ns |  0.9610 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.9587 ns | 0.0243 ns | 0.0161 ns |  0.9559 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  2.9503 ns | 0.0423 ns | 0.0280 ns |  2.9464 ns |     ? |       ? |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 11.1952 ns | 0.0960 ns | 0.0635 ns | 11.2024 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  3.4159 ns | 0.0566 ns | 0.0337 ns |  3.4127 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  3.4112 ns | 0.0867 ns | 0.0573 ns |  3.4097 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.8177 ns | 0.0459 ns | 0.0304 ns |  1.8133 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.8537 ns | 0.0271 ns | 0.0179 ns |  1.8561 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  0.9607 ns | 0.0198 ns | 0.0103 ns |  0.9645 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.0200 ns | 0.0322 ns | 0.0192 ns |  1.0194 ns |     ? |       ? |

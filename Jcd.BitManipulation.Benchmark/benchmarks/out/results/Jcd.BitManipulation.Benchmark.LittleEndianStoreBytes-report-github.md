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

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0054 ns | 0.0099 ns | 0.0066 ns |  0.0035 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET 8.0             |  0.0137 ns | 0.0197 ns | 0.0154 ns |  0.0083 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET 8.0             |  0.1277 ns | 0.0106 ns | 0.0070 ns |  0.1294 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET 8.0             |  0.0072 ns | 0.0120 ns | 0.0071 ns |  0.0036 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0046 ns | 0.0082 ns | 0.0054 ns |  0.0016 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET 8.0             |  0.0019 ns | 0.0060 ns | 0.0036 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0068 ns | 0.0138 ns | 0.0091 ns |  0.0046 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET 8.0             |  0.0126 ns | 0.0212 ns | 0.0140 ns |  0.0077 ns |     ? |       ? |
| ExtensionMethod_Double | .NET 8.0             |  4.0386 ns | 0.1044 ns | 0.0872 ns |  4.0197 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET 8.0             |  5.9049 ns | 0.4246 ns | 0.3764 ns |  5.8376 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET 8.0             |  4.0778 ns | 0.1441 ns | 0.1347 ns |  4.0722 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET 8.0             |  3.9662 ns | 0.2314 ns | 0.2165 ns |  3.9699 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET 8.0             |  2.3272 ns | 0.0987 ns | 0.0875 ns |  2.3190 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET 8.0             |  2.4413 ns | 0.1173 ns | 0.1040 ns |  2.4438 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET 8.0             |  1.1333 ns | 0.0382 ns | 0.0253 ns |  1.1310 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET 8.0             |  1.3352 ns | 0.0184 ns | 0.0109 ns |  1.3321 ns |     ? |       ? |
| ByteIndexer_Double     | .NET 8.0             |  3.6078 ns | 0.1055 ns | 0.0824 ns |  3.5953 ns |     ? |       ? |
| ByteIndexer_Float      | .NET 8.0             |  5.3187 ns | 0.1095 ns | 0.0573 ns |  5.3321 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET 8.0             |  3.2404 ns | 0.0594 ns | 0.0354 ns |  3.2414 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET 8.0             |  3.0137 ns | 0.1255 ns | 0.1174 ns |  3.0207 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET 8.0             |  2.1423 ns | 0.0666 ns | 0.0556 ns |  2.1329 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET 8.0             |  2.1832 ns | 0.0545 ns | 0.0360 ns |  2.1739 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET 8.0             |  1.1409 ns | 0.0404 ns | 0.0267 ns |  1.1383 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET 8.0             |  1.0813 ns | 0.0316 ns | 0.0209 ns |  1.0884 ns |     ? |       ? |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  2.6850 ns | 0.0499 ns | 0.0297 ns |  2.6966 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.0864 ns | 0.0303 ns | 0.0180 ns |  2.0865 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  2.8578 ns | 0.0631 ns | 0.0376 ns |  2.8572 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  1.5428 ns | 0.0494 ns | 0.0327 ns |  1.5523 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  1.6810 ns | 0.0335 ns | 0.0221 ns |  1.6822 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  0.8992 ns | 0.0581 ns | 0.0515 ns |  0.9086 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  2.8994 ns | 0.0784 ns | 0.0733 ns |  2.8676 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  1.0412 ns | 0.0341 ns | 0.0203 ns |  1.0412 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 | 10.5488 ns | 0.2142 ns | 0.1417 ns | 10.5128 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 14.1605 ns | 0.2829 ns | 0.2209 ns | 14.1419 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 | 10.2221 ns | 0.1435 ns | 0.0854 ns | 10.1853 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 | 10.1502 ns | 0.1167 ns | 0.0772 ns | 10.1411 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  5.3125 ns | 0.5282 ns | 0.4941 ns |  5.1640 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  4.9485 ns | 0.1026 ns | 0.0678 ns |  4.9311 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  2.6699 ns | 0.1278 ns | 0.1196 ns |  2.6729 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  2.6927 ns | 0.0532 ns | 0.0278 ns |  2.6990 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  9.3507 ns | 0.5152 ns | 0.4567 ns |  9.1675 ns |     ? |       ? |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 14.4056 ns | 0.2904 ns | 0.1728 ns | 14.4253 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  6.3681 ns | 0.0864 ns | 0.0514 ns |  6.3905 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  6.3477 ns | 0.0848 ns | 0.0561 ns |  6.3387 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  2.9510 ns | 0.0467 ns | 0.0309 ns |  2.9482 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  2.9204 ns | 0.0637 ns | 0.0421 ns |  2.9237 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.5882 ns | 0.0636 ns | 0.0595 ns |  1.5839 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.5804 ns | 0.0587 ns | 0.0549 ns |  1.5761 ns |     ? |       ? |

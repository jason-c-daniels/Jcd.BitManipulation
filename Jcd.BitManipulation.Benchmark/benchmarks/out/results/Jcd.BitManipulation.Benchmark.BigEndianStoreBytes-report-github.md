```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-NHSWMC : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-OYIBFG : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                   | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|--------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble    | .NET 8.0             |  1.4593 ns | 0.0462 ns | 0.0275 ns |  1.4663 ns | 0.385 |    0.01 |
| BitConverter_ToFloat     | .NET 8.0             |  1.5055 ns | 0.1047 ns | 0.0979 ns |  1.4934 ns | 0.402 |    0.03 |
| BitConverter_ToUInt64    | .NET 8.0             |  1.2604 ns | 0.0692 ns | 0.0647 ns |  1.2371 ns | 0.330 |    0.01 |
| BitConverter_ToInt64     | .NET 8.0             |  1.7902 ns | 0.1596 ns | 0.1493 ns |  1.7098 ns | 0.476 |    0.04 |
| BitConverter_ToUInt32    | .NET 8.0             |  1.2186 ns | 0.0735 ns | 0.0687 ns |  1.2255 ns | 0.316 |    0.02 |
| BitConverter_ToInt32     | .NET 8.0             |  1.6822 ns | 0.0533 ns | 0.0385 ns |  1.6889 ns | 0.443 |    0.01 |
| BitConverter_ToUInt16    | .NET 8.0             |  3.5339 ns | 0.0405 ns | 0.0241 ns |  3.5342 ns | 0.933 |    0.01 |
| BitConverter_ToInt16     | .NET 8.0             |  3.7993 ns | 0.0798 ns | 0.0528 ns |  3.7916 ns | 1.000 |    0.00 |
| ByteIndexer_Double       | .NET 8.0             |  1.2850 ns | 0.0448 ns | 0.0324 ns |  1.2809 ns | 0.338 |    0.01 |
| ByteIndexer_Float        | .NET 8.0             |  0.3661 ns | 0.0265 ns | 0.0175 ns |  0.3624 ns | 0.096 |    0.01 |
| ByteIndexer_UInt64       | .NET 8.0             |  1.1969 ns | 0.0372 ns | 0.0246 ns |  1.1942 ns | 0.315 |    0.01 |
| ByteIndexer_Int64        | .NET 8.0             |  1.2418 ns | 0.0502 ns | 0.0445 ns |  1.2403 ns | 0.330 |    0.01 |
| ByteIndexer_UInt32       | .NET 8.0             |  0.1265 ns | 0.0171 ns | 0.0089 ns |  0.1278 ns | 0.033 |    0.00 |
| ByteIndexer_Int32        | .NET 8.0             |  0.1243 ns | 0.0195 ns | 0.0129 ns |  0.1201 ns | 0.033 |    0.00 |
| ByteIndexer_UInt16       | .NET 8.0             |  0.1034 ns | 0.0132 ns | 0.0069 ns |  0.1017 ns | 0.027 |    0.00 |
| ByteIndexer_Int16        | .NET 8.0             |  0.1200 ns | 0.0295 ns | 0.0276 ns |  0.1133 ns | 0.032 |    0.01 |
| ExtensionMethod_Double   | .NET 8.0             |  1.2553 ns | 0.0500 ns | 0.0297 ns |  1.2497 ns | 0.331 |    0.01 |
| ExtensionMethod_Float    | .NET 8.0             |  0.1478 ns | 0.0311 ns | 0.0291 ns |  0.1366 ns | 0.039 |    0.01 |
| ExtensionMethod_UInt64   | .NET 8.0             |  1.2182 ns | 0.0250 ns | 0.0166 ns |  1.2215 ns | 0.321 |    0.00 |
| ExtensionMethod_Int64    | .NET 8.0             |  1.2469 ns | 0.0498 ns | 0.0388 ns |  1.2402 ns | 0.329 |    0.01 |
| ExtensionMethod_UInt32   | .NET 8.0             |  0.1471 ns | 0.0315 ns | 0.0294 ns |  0.1444 ns | 0.042 |    0.01 |
| ExtensionMethod_Int32    | .NET 8.0             |  0.1307 ns | 0.0274 ns | 0.0229 ns |  0.1246 ns | 0.035 |    0.01 |
| ExtensionMethod_UInt16   | .NET 8.0             |  0.1243 ns | 0.0292 ns | 0.0259 ns |  0.1207 ns | 0.032 |    0.01 |
| ExtensionMethod_Int16    | .NET 8.0             |  0.1475 ns | 0.0301 ns | 0.0282 ns |  0.1425 ns | 0.038 |    0.01 |
| ExtensionMethod_ToDouble | .NET 8.0             |  0.6715 ns | 0.0360 ns | 0.0281 ns |  0.6716 ns | 0.178 |    0.01 |
| ExtensionMethod_ToFloat  | .NET 8.0             |  0.1318 ns | 0.0175 ns | 0.0104 ns |  0.1353 ns | 0.035 |    0.00 |
| ExtensionMethod_ToUInt64 | .NET 8.0             |  0.6061 ns | 0.0371 ns | 0.0310 ns |  0.6008 ns | 0.160 |    0.01 |
| ExtensionMethod_ToInt64  | .NET 8.0             |  0.6000 ns | 0.0264 ns | 0.0175 ns |  0.5986 ns | 0.158 |    0.01 |
| ExtensionMethod_ToUInt32 | .NET 8.0             |  0.1229 ns | 0.0209 ns | 0.0124 ns |  0.1284 ns | 0.032 |    0.00 |
| ExtensionMethod_ToInt32  | .NET 8.0             |  0.1363 ns | 0.0352 ns | 0.0312 ns |  0.1243 ns | 0.036 |    0.01 |
| ExtensionMethod_ToUInt16 | .NET 8.0             |  0.0140 ns | 0.0245 ns | 0.0229 ns |  0.0000 ns | 0.005 |    0.01 |
| ExtensionMethod_ToInt16  | .NET 8.0             |  0.0235 ns | 0.0269 ns | 0.0252 ns |  0.0178 ns | 0.006 |    0.01 |
| BitConverter_ToDouble    | .NET Framework 4.6.2 | 27.3361 ns | 1.1300 ns | 1.0570 ns | 27.4170 ns | 7.207 |    0.32 |
| BitConverter_ToFloat     | .NET Framework 4.6.2 | 24.4604 ns | 0.6345 ns | 0.5935 ns | 24.3546 ns | 6.505 |    0.22 |
| BitConverter_ToUInt64    | .NET Framework 4.6.2 | 27.0288 ns | 0.6090 ns | 0.5085 ns | 26.8554 ns | 7.112 |    0.17 |
| BitConverter_ToInt64     | .NET Framework 4.6.2 | 25.5721 ns | 0.6686 ns | 0.6254 ns | 25.3221 ns | 6.741 |    0.22 |
| BitConverter_ToUInt32    | .NET Framework 4.6.2 | 24.3450 ns | 1.0716 ns | 1.0024 ns | 24.1753 ns | 6.369 |    0.29 |
| BitConverter_ToInt32     | .NET Framework 4.6.2 | 22.9635 ns | 0.4318 ns | 0.2856 ns | 22.9602 ns | 6.045 |    0.12 |
| BitConverter_ToUInt16    | .NET Framework 4.6.2 | 23.6744 ns | 0.8234 ns | 0.7299 ns | 23.4808 ns | 6.278 |    0.20 |
| BitConverter_ToInt16     | .NET Framework 4.6.2 | 22.4016 ns | 0.9649 ns | 0.9026 ns | 22.1105 ns | 5.813 |    0.19 |
| ByteIndexer_Double       | .NET Framework 4.6.2 |  6.8227 ns | 0.1826 ns | 0.1708 ns |  6.8051 ns | 1.795 |    0.07 |
| ByteIndexer_Float        | .NET Framework 4.6.2 | 13.0034 ns | 0.4549 ns | 0.4255 ns | 12.7442 ns | 3.393 |    0.10 |
| ByteIndexer_UInt64       | .NET Framework 4.6.2 |  6.6101 ns | 0.1437 ns | 0.1039 ns |  6.6044 ns | 1.742 |    0.04 |
| ByteIndexer_Int64        | .NET Framework 4.6.2 |  6.6683 ns | 0.1449 ns | 0.0958 ns |  6.6683 ns | 1.755 |    0.03 |
| ByteIndexer_UInt32       | .NET Framework 4.6.2 |  3.0604 ns | 0.1220 ns | 0.1081 ns |  3.0407 ns | 0.808 |    0.03 |
| ByteIndexer_Int32        | .NET Framework 4.6.2 |  2.9712 ns | 0.0819 ns | 0.0640 ns |  2.9649 ns | 0.784 |    0.02 |
| ByteIndexer_UInt16       | .NET Framework 4.6.2 |  1.4311 ns | 0.0496 ns | 0.0414 ns |  1.4465 ns | 0.378 |    0.01 |
| ByteIndexer_Int16        | .NET Framework 4.6.2 |  1.4255 ns | 0.0512 ns | 0.0400 ns |  1.4151 ns | 0.376 |    0.01 |
| ExtensionMethod_Double   | .NET Framework 4.6.2 |  6.7195 ns | 0.0954 ns | 0.0631 ns |  6.7235 ns | 1.769 |    0.03 |
| ExtensionMethod_Float    | .NET Framework 4.6.2 | 12.4283 ns | 0.2033 ns | 0.1470 ns | 12.4220 ns | 3.272 |    0.05 |
| ExtensionMethod_UInt64   | .NET Framework 4.6.2 |  6.6677 ns | 0.0778 ns | 0.0515 ns |  6.6677 ns | 1.755 |    0.03 |
| ExtensionMethod_Int64    | .NET Framework 4.6.2 |  6.4601 ns | 0.0499 ns | 0.0330 ns |  6.4626 ns | 1.701 |    0.02 |
| ExtensionMethod_UInt32   | .NET Framework 4.6.2 |  2.9613 ns | 0.0740 ns | 0.0578 ns |  2.9638 ns | 0.779 |    0.01 |
| ExtensionMethod_Int32    | .NET Framework 4.6.2 |  2.9062 ns | 0.0721 ns | 0.0429 ns |  2.8814 ns | 0.767 |    0.02 |
| ExtensionMethod_UInt16   | .NET Framework 4.6.2 |  1.5027 ns | 0.0520 ns | 0.0344 ns |  1.4954 ns | 0.396 |    0.01 |
| ExtensionMethod_Int16    | .NET Framework 4.6.2 |  1.4550 ns | 0.0512 ns | 0.0400 ns |  1.4669 ns | 0.385 |    0.01 |
| ExtensionMethod_ToDouble | .NET Framework 4.6.2 |  2.8460 ns | 0.0768 ns | 0.0681 ns |  2.8429 ns | 0.753 |    0.02 |
| ExtensionMethod_ToFloat  | .NET Framework 4.6.2 |  5.8672 ns | 0.1353 ns | 0.1056 ns |  5.8869 ns | 1.545 |    0.02 |
| ExtensionMethod_ToUInt64 | .NET Framework 4.6.2 |  2.7987 ns | 0.0732 ns | 0.0571 ns |  2.8138 ns | 0.736 |    0.02 |
| ExtensionMethod_ToInt64  | .NET Framework 4.6.2 |  2.7535 ns | 0.0772 ns | 0.0510 ns |  2.7652 ns | 0.725 |    0.01 |
| ExtensionMethod_ToUInt32 | .NET Framework 4.6.2 |  1.2166 ns | 0.0459 ns | 0.0429 ns |  1.1988 ns | 0.322 |    0.01 |
| ExtensionMethod_ToInt32  | .NET Framework 4.6.2 |  1.2013 ns | 0.0554 ns | 0.0518 ns |  1.2035 ns | 0.313 |    0.02 |
| ExtensionMethod_ToUInt16 | .NET Framework 4.6.2 |  0.6843 ns | 0.0297 ns | 0.0177 ns |  0.6812 ns | 0.181 |    0.01 |
| ExtensionMethod_ToInt16  | .NET Framework 4.6.2 |  0.6872 ns | 0.0351 ns | 0.0311 ns |  0.6772 ns | 0.182 |    0.01 |

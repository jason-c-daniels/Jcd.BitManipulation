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

| Method                   | Runtime              |       Mean |     Error |    StdDev |     Median |  Ratio | RatioSD |
|--------------------------|----------------------|-----------:|----------:|----------:|-----------:|-------:|--------:|
| BitConverter_ToDouble    | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| BitConverter_ToFloat     | .NET 8.0             |  0.0112 ns | 0.0179 ns | 0.0118 ns |  0.0068 ns |  0.080 |    0.08 |
| BitConverter_ToUInt64    | .NET 8.0             |  0.0059 ns | 0.0123 ns | 0.0081 ns |  0.0000 ns |  0.044 |    0.06 |
| BitConverter_ToInt64     | .NET 8.0             |  0.1311 ns | 0.0241 ns | 0.0159 ns |  0.1404 ns |  0.980 |    0.16 |
| BitConverter_ToUInt32    | .NET 8.0             |  0.0091 ns | 0.0145 ns | 0.0096 ns |  0.0059 ns |  0.065 |    0.07 |
| BitConverter_ToInt32     | .NET 8.0             |  0.0014 ns | 0.0045 ns | 0.0030 ns |  0.0000 ns |  0.011 |    0.02 |
| BitConverter_ToUInt16    | .NET 8.0             |  0.0063 ns | 0.0139 ns | 0.0083 ns |  0.0000 ns |  0.048 |    0.06 |
| BitConverter_ToInt16     | .NET 8.0             |  0.1348 ns | 0.0141 ns | 0.0094 ns |  0.1342 ns |  1.000 |    0.00 |
| ByteIndexer_Double       | .NET 8.0             |  1.4146 ns | 0.0228 ns | 0.0119 ns |  1.4137 ns | 10.434 |    0.76 |
| ByteIndexer_Float        | .NET 8.0             |  0.1629 ns | 0.0216 ns | 0.0129 ns |  0.1676 ns |  1.207 |    0.15 |
| ByteIndexer_UInt64       | .NET 8.0             |  1.3495 ns | 0.0590 ns | 0.0523 ns |  1.3442 ns | 10.148 |    0.84 |
| ByteIndexer_Int64        | .NET 8.0             |  1.3150 ns | 0.0513 ns | 0.0305 ns |  1.3268 ns |  9.726 |    0.67 |
| ByteIndexer_UInt32       | .NET 8.0             |  0.0006 ns | 0.0023 ns | 0.0022 ns |  0.0000 ns |  0.000 |    0.00 |
| ByteIndexer_Int32        | .NET 8.0             |  0.3821 ns | 0.0492 ns | 0.0460 ns |  0.3830 ns |  2.817 |    0.48 |
| ByteIndexer_UInt16       | .NET 8.0             |  0.2784 ns | 0.1141 ns | 0.1068 ns |  0.2479 ns |  2.377 |    0.75 |
| ByteIndexer_Int16        | .NET 8.0             |  0.1319 ns | 0.0407 ns | 0.0381 ns |  0.1123 ns |  0.953 |    0.28 |
| ExtensionMethod_Double   | .NET 8.0             |  1.4471 ns | 0.0763 ns | 0.0714 ns |  1.4413 ns | 10.748 |    0.82 |
| ExtensionMethod_Float    | .NET 8.0             |  0.3738 ns | 0.0394 ns | 0.0369 ns |  0.3625 ns |  2.803 |    0.33 |
| ExtensionMethod_UInt64   | .NET 8.0             |  1.2677 ns | 0.0945 ns | 0.0884 ns |  1.2360 ns |  9.523 |    1.18 |
| ExtensionMethod_Int64    | .NET 8.0             |  1.3641 ns | 0.1538 ns | 0.1439 ns |  1.2959 ns | 10.298 |    1.76 |
| ExtensionMethod_UInt32   | .NET 8.0             |  0.1431 ns | 0.0377 ns | 0.0315 ns |  0.1408 ns |  1.126 |    0.25 |
| ExtensionMethod_Int32    | .NET 8.0             |  0.2166 ns | 0.1095 ns | 0.1024 ns |  0.1986 ns |  1.714 |    0.89 |
| ExtensionMethod_UInt16   | .NET 8.0             |  0.2143 ns | 0.0787 ns | 0.0736 ns |  0.1881 ns |  1.746 |    0.51 |
| ExtensionMethod_Int16    | .NET 8.0             |  0.1166 ns | 0.0231 ns | 0.0137 ns |  0.1110 ns |  0.862 |    0.12 |
| ExtensionMethod_ToDouble | .NET 8.0             |  0.6987 ns | 0.0644 ns | 0.0603 ns |  0.6672 ns |  5.214 |    0.54 |
| ExtensionMethod_ToFloat  | .NET 8.0             |  0.1370 ns | 0.0270 ns | 0.0211 ns |  0.1364 ns |  1.015 |    0.16 |
| ExtensionMethod_ToUInt64 | .NET 8.0             |  0.6108 ns | 0.0346 ns | 0.0206 ns |  0.6116 ns |  4.522 |    0.39 |
| ExtensionMethod_ToInt64  | .NET 8.0             |  0.5618 ns | 0.0346 ns | 0.0250 ns |  0.5635 ns |  4.186 |    0.38 |
| ExtensionMethod_ToUInt32 | .NET 8.0             |  0.2283 ns | 0.0738 ns | 0.0691 ns |  0.2202 ns |  1.751 |    0.63 |
| ExtensionMethod_ToInt32  | .NET 8.0             |  0.1377 ns | 0.0507 ns | 0.0449 ns |  0.1217 ns |  0.977 |    0.34 |
| ExtensionMethod_ToUInt16 | .NET 8.0             |  0.0702 ns | 0.0754 ns | 0.0706 ns |  0.0318 ns |  0.339 |    0.39 |
| ExtensionMethod_ToInt16  | .NET 8.0             |  0.0659 ns | 0.0145 ns | 0.0096 ns |  0.0655 ns |  0.490 |    0.07 |
| BitConverter_ToDouble    | .NET Framework 4.6.2 |  2.8829 ns | 0.0237 ns | 0.0124 ns |  2.8792 ns | 21.262 |    1.50 |
| BitConverter_ToFloat     | .NET Framework 4.6.2 |  1.8962 ns | 0.0376 ns | 0.0248 ns |  1.8992 ns | 14.133 |    1.03 |
| BitConverter_ToUInt64    | .NET Framework 4.6.2 |  2.7571 ns | 0.1050 ns | 0.0982 ns |  2.7187 ns | 20.620 |    1.60 |
| BitConverter_ToInt64     | .NET Framework 4.6.2 |  1.3770 ns | 0.1386 ns | 0.1297 ns |  1.3265 ns |  9.921 |    1.25 |
| BitConverter_ToUInt32    | .NET Framework 4.6.2 |  1.5071 ns | 0.0973 ns | 0.0910 ns |  1.5181 ns | 11.396 |    1.22 |
| BitConverter_ToInt32     | .NET Framework 4.6.2 |  0.5715 ns | 0.0441 ns | 0.0412 ns |  0.5513 ns |  4.267 |    0.41 |
| BitConverter_ToUInt16    | .NET Framework 4.6.2 |  2.6271 ns | 0.0779 ns | 0.0729 ns |  2.6356 ns | 19.621 |    1.39 |
| BitConverter_ToInt16     | .NET Framework 4.6.2 |  0.7752 ns | 0.0291 ns | 0.0192 ns |  0.7795 ns |  5.775 |    0.39 |
| ByteIndexer_Double       | .NET Framework 4.6.2 |  2.8089 ns | 0.0687 ns | 0.0454 ns |  2.8087 ns | 20.935 |    1.53 |
| ByteIndexer_Float        | .NET Framework 4.6.2 | 11.2317 ns | 0.2086 ns | 0.1742 ns | 11.2087 ns | 83.773 |    5.73 |
| ByteIndexer_UInt64       | .NET Framework 4.6.2 |  3.3503 ns | 0.0817 ns | 0.0638 ns |  3.3547 ns | 24.929 |    1.71 |
| ByteIndexer_Int64        | .NET Framework 4.6.2 |  3.3404 ns | 0.0830 ns | 0.0736 ns |  3.3207 ns | 24.953 |    1.90 |
| ByteIndexer_UInt32       | .NET Framework 4.6.2 |  1.7531 ns | 0.0445 ns | 0.0294 ns |  1.7592 ns | 13.055 |    0.76 |
| ByteIndexer_Int32        | .NET Framework 4.6.2 |  1.7859 ns | 0.0536 ns | 0.0319 ns |  1.7960 ns | 13.215 |    0.97 |
| ByteIndexer_UInt16       | .NET Framework 4.6.2 |  0.9029 ns | 0.0309 ns | 0.0162 ns |  0.9056 ns |  6.659 |    0.47 |
| ByteIndexer_Int16        | .NET Framework 4.6.2 |  0.9321 ns | 0.0380 ns | 0.0226 ns |  0.9197 ns |  6.898 |    0.53 |
| ExtensionMethod_Double   | .NET Framework 4.6.2 |  3.0790 ns | 0.0713 ns | 0.0425 ns |  3.0853 ns | 22.765 |    1.34 |
| ExtensionMethod_Float    | .NET Framework 4.6.2 | 11.8691 ns | 0.1375 ns | 0.0818 ns | 11.8533 ns | 87.819 |    6.19 |
| ExtensionMethod_UInt64   | .NET Framework 4.6.2 |  2.7256 ns | 0.0548 ns | 0.0363 ns |  2.7116 ns | 20.298 |    1.20 |
| ExtensionMethod_Int64    | .NET Framework 4.6.2 |  3.3282 ns | 0.0865 ns | 0.0626 ns |  3.3213 ns | 24.790 |    1.49 |
| ExtensionMethod_UInt32   | .NET Framework 4.6.2 |  2.2900 ns | 0.0703 ns | 0.0658 ns |  2.2863 ns | 17.040 |    1.17 |
| ExtensionMethod_Int32    | .NET Framework 4.6.2 |  2.3241 ns | 0.0681 ns | 0.0492 ns |  2.3414 ns | 17.298 |    1.12 |
| ExtensionMethod_UInt16   | .NET Framework 4.6.2 |  0.9293 ns | 0.0654 ns | 0.0611 ns |  0.9020 ns |  6.932 |    0.61 |
| ExtensionMethod_Int16    | .NET Framework 4.6.2 |  0.9753 ns | 0.0418 ns | 0.0349 ns |  0.9649 ns |  7.283 |    0.65 |
| ExtensionMethod_ToDouble | .NET Framework 4.6.2 |  2.8351 ns | 0.0799 ns | 0.0667 ns |  2.8532 ns | 21.237 |    1.72 |
| ExtensionMethod_ToFloat  | .NET Framework 4.6.2 |  5.7957 ns | 0.1141 ns | 0.0679 ns |  5.7703 ns | 42.882 |    3.06 |
| ExtensionMethod_ToUInt64 | .NET Framework 4.6.2 |  2.7605 ns | 0.0537 ns | 0.0320 ns |  2.7457 ns | 20.428 |    1.51 |
| ExtensionMethod_ToInt64  | .NET Framework 4.6.2 |  2.7538 ns | 0.0758 ns | 0.0502 ns |  2.7327 ns | 20.528 |    1.57 |
| ExtensionMethod_ToUInt32 | .NET Framework 4.6.2 |  1.2146 ns | 0.0468 ns | 0.0391 ns |  1.2159 ns |  9.124 |    0.66 |
| ExtensionMethod_ToInt32  | .NET Framework 4.6.2 |  1.1304 ns | 0.0772 ns | 0.0684 ns |  1.1133 ns |  8.395 |    0.87 |
| ExtensionMethod_ToUInt16 | .NET Framework 4.6.2 |  0.7081 ns | 0.0359 ns | 0.0281 ns |  0.7020 ns |  5.306 |    0.49 |
| ExtensionMethod_ToInt16  | .NET Framework 4.6.2 |  0.6751 ns | 0.0337 ns | 0.0223 ns |  0.6694 ns |  5.035 |    0.43 |

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-CXBWXK : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-SUYWZE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```
| Method                                   | Runtime              | Mean       | Error     | StdDev    | Ratio  | RatioSD |
|----------------------------------------- |--------------------- |-----------:|----------:|----------:|-------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  1.4419 ns | 0.0471 ns | 0.0281 ns |  1.178 |    0.03 |
| BitConverter_ToFloat                     | .NET 8.0             |  1.4416 ns | 0.0288 ns | 0.0151 ns |  1.177 |    0.03 |
| BitConverter_ToUInt64                    | .NET 8.0             |  1.2288 ns | 0.0197 ns | 0.0117 ns |  1.004 |    0.02 |
| BitConverter_ToInt64                     | .NET 8.0             |  1.6726 ns | 0.0422 ns | 0.0279 ns |  1.369 |    0.04 |
| BitConverter_ToUInt32                    | .NET 8.0             |  1.2395 ns | 0.0440 ns | 0.0291 ns |  1.017 |    0.03 |
| BitConverter_ToInt32                     | .NET 8.0             |  1.6697 ns | 0.0313 ns | 0.0207 ns |  1.365 |    0.03 |
| BitConverter_ToUInt16                    | .NET 8.0             |  3.2189 ns | 0.0412 ns | 0.0245 ns |  2.629 |    0.05 |
| BitConverter_ToInt16                     | .NET 8.0             |  3.7402 ns | 0.0568 ns | 0.0376 ns |  3.049 |    0.06 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.2926 ns | 0.0355 ns | 0.0234 ns |  1.055 |    0.03 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.3549 ns | 0.0308 ns | 0.0204 ns |  0.292 |    0.02 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.2248 ns | 0.0386 ns | 0.0230 ns |  1.000 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.2401 ns | 0.0298 ns | 0.0177 ns |  1.013 |    0.03 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.1377 ns | 0.0257 ns | 0.0214 ns |  0.112 |    0.02 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.0943 ns | 0.0192 ns | 0.0127 ns |  0.078 |    0.01 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1548 ns | 0.0283 ns | 0.0221 ns |  0.125 |    0.02 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1396 ns | 0.0191 ns | 0.0127 ns |  0.114 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.3342 ns | 0.0879 ns | 0.0822 ns |  1.939 |    0.07 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.7244 ns | 0.0401 ns | 0.0313 ns |  0.589 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.0516 ns | 0.0604 ns | 0.0316 ns |  1.675 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.0580 ns | 0.0611 ns | 0.0404 ns |  1.686 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.5743 ns | 0.0350 ns | 0.0274 ns |  0.462 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.5763 ns | 0.0337 ns | 0.0223 ns |  0.472 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.3463 ns | 0.0254 ns | 0.0168 ns |  0.284 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.3543 ns | 0.0306 ns | 0.0182 ns |  0.289 |    0.01 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.2896 ns | 0.0250 ns | 0.0165 ns |  1.054 |    0.03 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.1301 ns | 0.0164 ns | 0.0086 ns |  0.106 |    0.01 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.3310 ns | 0.0953 ns | 0.0891 ns |  1.092 |    0.09 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.3226 ns | 0.0685 ns | 0.0608 ns |  1.072 |    0.06 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.3474 ns | 0.0402 ns | 0.0376 ns |  0.286 |    0.03 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.3788 ns | 0.0644 ns | 0.0603 ns |  0.323 |    0.05 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.000 |    0.00 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.1448 ns | 0.0299 ns | 0.0250 ns |  0.116 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  2.3489 ns | 0.0972 ns | 0.0862 ns |  1.914 |    0.05 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  1.8666 ns | 0.0622 ns | 0.0582 ns |  1.513 |    0.07 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  1.9941 ns | 0.0386 ns | 0.0256 ns |  1.630 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  2.1022 ns | 0.0798 ns | 0.0746 ns |  1.723 |    0.08 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  2.1561 ns | 0.0745 ns | 0.0661 ns |  1.781 |    0.06 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  2.1981 ns | 0.1459 ns | 0.1365 ns |  1.844 |    0.11 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  1.6522 ns | 0.1218 ns | 0.1080 ns |  1.357 |    0.10 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  1.4643 ns | 0.1025 ns | 0.0958 ns |  1.226 |    0.06 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 | 26.3376 ns | 0.6703 ns | 0.6270 ns | 21.390 |    0.41 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 | 25.8210 ns | 1.1045 ns | 1.0332 ns | 21.097 |    0.90 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 | 26.3415 ns | 1.1351 ns | 1.0618 ns | 21.978 |    1.03 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 | 26.0546 ns | 1.8228 ns | 1.7050 ns | 21.568 |    1.32 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 | 24.8645 ns | 1.1635 ns | 1.0883 ns | 20.445 |    0.98 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 | 22.8716 ns | 0.3381 ns | 0.2236 ns | 18.696 |    0.42 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 | 23.5504 ns | 0.4385 ns | 0.3171 ns | 19.219 |    0.54 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 | 21.6941 ns | 0.4264 ns | 0.3989 ns | 17.707 |    0.28 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 | 11.9786 ns | 0.0826 ns | 0.0491 ns |  9.783 |    0.19 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 15.8713 ns | 0.1705 ns | 0.0892 ns | 12.954 |    0.25 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 | 10.7654 ns | 0.2283 ns | 0.2024 ns |  8.845 |    0.29 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 | 10.7078 ns | 0.1207 ns | 0.0798 ns |  8.749 |    0.16 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  8.4939 ns | 0.4085 ns | 0.3821 ns |  6.813 |    0.37 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  8.0329 ns | 0.0811 ns | 0.0483 ns |  6.561 |    0.12 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  7.2467 ns | 0.0930 ns | 0.0615 ns |  5.927 |    0.14 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  7.6843 ns | 0.0603 ns | 0.0399 ns |  6.279 |    0.14 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  4.8270 ns | 0.1149 ns | 0.0960 ns |  3.919 |    0.07 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 11.9355 ns | 0.1388 ns | 0.0918 ns |  9.752 |    0.18 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  6.3933 ns | 0.1205 ns | 0.0797 ns |  5.230 |    0.14 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.4461 ns | 0.1435 ns | 0.0949 ns |  5.268 |    0.14 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  3.0742 ns | 0.0965 ns | 0.0902 ns |  2.521 |    0.11 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.9637 ns | 0.1224 ns | 0.1145 ns |  2.396 |    0.12 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  1.8760 ns | 0.0779 ns | 0.0729 ns |  1.504 |    0.07 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  1.9410 ns | 0.0652 ns | 0.0609 ns |  1.584 |    0.06 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 | 12.0617 ns | 0.2305 ns | 0.1524 ns |  9.843 |    0.18 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 16.0455 ns | 0.1721 ns | 0.1138 ns | 13.097 |    0.29 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 | 10.9358 ns | 0.1120 ns | 0.0667 ns |  8.931 |    0.16 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 | 10.8170 ns | 0.1553 ns | 0.1027 ns |  8.835 |    0.16 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  8.1747 ns | 0.1798 ns | 0.1403 ns |  6.699 |    0.15 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  8.1076 ns | 0.0694 ns | 0.0363 ns |  6.618 |    0.15 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  7.2857 ns | 0.1586 ns | 0.1049 ns |  5.956 |    0.16 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  7.7614 ns | 0.1954 ns | 0.1732 ns |  6.396 |    0.15 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  3.7390 ns | 0.0928 ns | 0.0724 ns |  3.068 |    0.09 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  7.0760 ns | 0.2375 ns | 0.2222 ns |  5.763 |    0.17 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  4.7955 ns | 0.1024 ns | 0.0908 ns |  3.929 |    0.11 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  4.8130 ns | 0.1184 ns | 0.0989 ns |  3.944 |    0.11 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  3.1714 ns | 0.0737 ns | 0.0575 ns |  2.578 |    0.06 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  3.1305 ns | 0.0562 ns | 0.0371 ns |  2.555 |    0.06 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  2.6752 ns | 0.0759 ns | 0.0549 ns |  2.175 |    0.04 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  2.6655 ns | 0.0480 ns | 0.0285 ns |  2.177 |    0.04 |

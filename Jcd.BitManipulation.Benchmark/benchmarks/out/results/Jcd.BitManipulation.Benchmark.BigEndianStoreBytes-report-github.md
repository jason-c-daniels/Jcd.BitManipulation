```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-NGSTAA : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-DGGSAB : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```
| Method                                   | Runtime              | Mean       | Error     | StdDev    | Median     | Ratio  | RatioSD |
|----------------------------------------- |--------------------- |-----------:|----------:|----------:|-----------:|-------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  1.4683 ns | 0.0251 ns | 0.0131 ns |  1.4693 ns |  1.118 |    0.04 |
| BitConverter_ToFloat                     | .NET 8.0             |  1.4965 ns | 0.0532 ns | 0.0416 ns |  1.4799 ns |  1.150 |    0.06 |
| BitConverter_ToUInt64                    | .NET 8.0             |  1.2334 ns | 0.0350 ns | 0.0183 ns |  1.2259 ns |  0.939 |    0.04 |
| BitConverter_ToInt64                     | .NET 8.0             |  1.6818 ns | 0.0080 ns | 0.0048 ns |  1.6826 ns |  1.283 |    0.05 |
| BitConverter_ToUInt32                    | .NET 8.0             |  1.4735 ns | 0.0722 ns | 0.0675 ns |  1.4561 ns |  1.131 |    0.07 |
| BitConverter_ToInt32                     | .NET 8.0             |  1.8724 ns | 0.1316 ns | 0.1167 ns |  1.8834 ns |  1.441 |    0.12 |
| BitConverter_ToUInt16                    | .NET 8.0             |  3.6489 ns | 0.1024 ns | 0.0958 ns |  3.6316 ns |  2.810 |    0.14 |
| BitConverter_ToInt16                     | .NET 8.0             |  3.8061 ns | 0.0902 ns | 0.0537 ns |  3.8030 ns |  2.904 |    0.12 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.2535 ns | 0.0612 ns | 0.0511 ns |  1.2486 ns |  0.961 |    0.06 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.1944 ns | 0.0789 ns | 0.0699 ns |  0.1936 ns |  0.150 |    0.05 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.3022 ns | 0.0568 ns | 0.0504 ns |  1.2878 ns |  1.000 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.2380 ns | 0.0443 ns | 0.0293 ns |  1.2302 ns |  0.946 |    0.04 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.4059 ns | 0.0581 ns | 0.0543 ns |  0.3884 ns |  0.308 |    0.04 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.1246 ns | 0.0215 ns | 0.0142 ns |  0.1216 ns |  0.095 |    0.01 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1668 ns | 0.0274 ns | 0.0181 ns |  0.1730 ns |  0.127 |    0.01 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1360 ns | 0.0265 ns | 0.0192 ns |  0.1299 ns |  0.104 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.2171 ns | 0.0449 ns | 0.0325 ns |  2.2002 ns |  1.699 |    0.07 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.6936 ns | 0.0229 ns | 0.0151 ns |  0.6895 ns |  0.530 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.2249 ns | 0.3030 ns | 0.2834 ns |  2.1189 ns |  1.717 |    0.24 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.0110 ns | 0.0386 ns | 0.0255 ns |  2.0030 ns |  1.536 |    0.06 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.6162 ns | 0.0924 ns | 0.0864 ns |  0.5695 ns |  0.479 |    0.07 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.5630 ns | 0.0549 ns | 0.0514 ns |  0.5484 ns |  0.430 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.3343 ns | 0.0325 ns | 0.0215 ns |  0.3229 ns |  0.255 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.3459 ns | 0.0127 ns | 0.0075 ns |  0.3450 ns |  0.264 |    0.01 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.2500 ns | 0.0269 ns | 0.0178 ns |  1.2507 ns |  0.955 |    0.03 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.3655 ns | 0.0318 ns | 0.0230 ns |  0.3586 ns |  0.280 |    0.02 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.2160 ns | 0.0453 ns | 0.0300 ns |  1.2099 ns |  0.929 |    0.05 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.2140 ns | 0.0202 ns | 0.0120 ns |  1.2168 ns |  0.926 |    0.03 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1459 ns | 0.0270 ns | 0.0253 ns |  0.1500 ns |  0.111 |    0.02 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.1221 ns | 0.0238 ns | 0.0158 ns |  0.1241 ns |  0.093 |    0.01 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.1376 ns | 0.0202 ns | 0.0134 ns |  0.1336 ns |  0.105 |    0.01 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.0051 ns | 0.0100 ns | 0.0060 ns |  0.0020 ns |  0.004 |    0.00 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  0.6625 ns | 0.0108 ns | 0.0056 ns |  0.6633 ns |  0.505 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  0.1239 ns | 0.0134 ns | 0.0070 ns |  0.1226 ns |  0.094 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  0.5961 ns | 0.0201 ns | 0.0133 ns |  0.5928 ns |  0.455 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  0.6108 ns | 0.0239 ns | 0.0158 ns |  0.6122 ns |  0.466 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  0.1435 ns | 0.0248 ns | 0.0164 ns |  0.1392 ns |  0.109 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  0.1255 ns | 0.0253 ns | 0.0167 ns |  0.1222 ns |  0.096 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  0.1221 ns | 0.0210 ns | 0.0139 ns |  0.1209 ns |  0.093 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  0.1163 ns | 0.0126 ns | 0.0066 ns |  0.1145 ns |  0.089 |    0.01 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 | 25.8917 ns | 0.4527 ns | 0.3274 ns | 25.8889 ns | 19.853 |    0.93 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 | 23.6876 ns | 0.4915 ns | 0.3554 ns | 23.6747 ns | 18.160 |    0.79 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 | 26.2984 ns | 0.4472 ns | 0.2958 ns | 26.2869 ns | 20.087 |    0.85 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 | 24.9434 ns | 0.4878 ns | 0.3226 ns | 24.9674 ns | 19.046 |    0.65 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 | 23.8287 ns | 0.4802 ns | 0.4010 ns | 23.7083 ns | 18.263 |    0.82 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 | 22.8208 ns | 0.2679 ns | 0.1772 ns | 22.8079 ns | 17.432 |    0.76 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 | 22.9644 ns | 0.4792 ns | 0.2851 ns | 22.9306 ns | 17.525 |    0.77 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 | 21.1048 ns | 0.4459 ns | 0.3224 ns | 21.1043 ns | 16.177 |    0.65 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 |  2.9152 ns | 0.0448 ns | 0.0235 ns |  2.9228 ns |  2.221 |    0.10 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 10.8706 ns | 0.1522 ns | 0.1007 ns | 10.9196 ns |  8.303 |    0.34 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 |  2.8929 ns | 0.0743 ns | 0.0580 ns |  2.8921 ns |  2.223 |    0.10 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 |  2.9199 ns | 0.0817 ns | 0.0724 ns |  2.9209 ns |  2.246 |    0.12 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  1.5522 ns | 0.0538 ns | 0.0449 ns |  1.5592 ns |  1.189 |    0.05 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  1.5687 ns | 0.0509 ns | 0.0368 ns |  1.5638 ns |  1.202 |    0.05 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  0.8911 ns | 0.0371 ns | 0.0221 ns |  0.8949 ns |  0.680 |    0.04 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  0.9419 ns | 0.0404 ns | 0.0315 ns |  0.9382 ns |  0.723 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  5.3725 ns | 0.1670 ns | 0.1395 ns |  5.3885 ns |  4.117 |    0.19 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 12.1199 ns | 0.2598 ns | 0.1878 ns | 12.0547 ns |  9.294 |    0.46 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  6.4049 ns | 0.1380 ns | 0.1077 ns |  6.3673 ns |  4.921 |    0.17 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.5306 ns | 0.1436 ns | 0.1121 ns |  6.5319 ns |  5.019 |    0.20 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  2.9953 ns | 0.0887 ns | 0.0741 ns |  2.9894 ns |  2.296 |    0.12 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.9376 ns | 0.0974 ns | 0.0911 ns |  2.9288 ns |  2.250 |    0.09 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  2.2101 ns | 0.4197 ns | 0.3926 ns |  2.2070 ns |  1.680 |    0.33 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  1.7893 ns | 0.2683 ns | 0.2509 ns |  1.7790 ns |  1.397 |    0.20 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 |  3.2549 ns | 0.3447 ns | 0.3224 ns |  3.1877 ns |  2.478 |    0.27 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 12.3877 ns | 0.9056 ns | 0.8471 ns | 12.0477 ns |  9.475 |    0.69 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 |  3.8015 ns | 0.3261 ns | 0.3050 ns |  3.7863 ns |  2.910 |    0.26 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 |  2.7647 ns | 0.0787 ns | 0.0657 ns |  2.7660 ns |  2.119 |    0.10 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  1.5007 ns | 0.0794 ns | 0.0743 ns |  1.5006 ns |  1.155 |    0.06 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  1.4952 ns | 0.0734 ns | 0.0687 ns |  1.4772 ns |  1.151 |    0.07 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  0.9831 ns | 0.0454 ns | 0.0425 ns |  0.9685 ns |  0.757 |    0.03 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  1.0110 ns | 0.0815 ns | 0.0762 ns |  1.0048 ns |  0.775 |    0.07 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  2.5137 ns | 0.0506 ns | 0.0265 ns |  2.5045 ns |  1.916 |    0.09 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  5.8176 ns | 0.1196 ns | 0.0712 ns |  5.7957 ns |  4.440 |    0.20 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  2.3089 ns | 0.0176 ns | 0.0092 ns |  2.3092 ns |  1.759 |    0.08 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  2.3093 ns | 0.0332 ns | 0.0198 ns |  2.3071 ns |  1.762 |    0.07 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  0.7463 ns | 0.0199 ns | 0.0132 ns |  0.7424 ns |  0.570 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  0.7575 ns | 0.0250 ns | 0.0166 ns |  0.7550 ns |  0.579 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  0.6172 ns | 0.0169 ns | 0.0101 ns |  0.6177 ns |  0.471 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  0.5498 ns | 0.0094 ns | 0.0056 ns |  0.5504 ns |  0.420 |    0.02 |

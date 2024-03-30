```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-UWWGLV : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-IXAHBT : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                                   | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  0.0048 ns | 0.0093 ns | 0.0061 ns |  0.0017 ns | 0.004 |    0.00 |
| BitConverter_ToFloat                     | .NET 8.0             |  0.0124 ns | 0.0212 ns | 0.0140 ns |  0.0075 ns | 0.009 |    0.01 |
| BitConverter_ToUInt64                    | .NET 8.0             |  0.0048 ns | 0.0124 ns | 0.0074 ns |  0.0000 ns | 0.004 |    0.01 |
| BitConverter_ToInt64                     | .NET 8.0             |  0.1508 ns | 0.0276 ns | 0.0183 ns |  0.1428 ns | 0.115 |    0.01 |
| BitConverter_ToUInt32                    | .NET 8.0             |  0.0137 ns | 0.0192 ns | 0.0127 ns |  0.0129 ns | 0.010 |    0.01 |
| BitConverter_ToInt32                     | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns | 0.000 |    0.00 |
| BitConverter_ToUInt16                    | .NET 8.0             |  0.0008 ns | 0.0027 ns | 0.0018 ns |  0.0000 ns | 0.001 |    0.00 |
| BitConverter_ToInt16                     | .NET 8.0             |  0.1397 ns | 0.0189 ns | 0.0125 ns |  0.1361 ns | 0.107 |    0.01 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.4326 ns | 0.0446 ns | 0.0295 ns |  1.4310 ns | 1.094 |    0.03 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.3498 ns | 0.0269 ns | 0.0178 ns |  0.3494 ns | 0.267 |    0.02 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.3086 ns | 0.0513 ns | 0.0371 ns |  1.2997 ns | 1.000 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.3075 ns | 0.0441 ns | 0.0292 ns |  1.3081 ns | 0.999 |    0.03 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.3463 ns | 0.0217 ns | 0.0129 ns |  0.3422 ns | 0.265 |    0.02 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.3402 ns | 0.0559 ns | 0.0523 ns |  0.3222 ns | 0.271 |    0.05 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.2140 ns | 0.0634 ns | 0.0593 ns |  0.2013 ns | 0.157 |    0.04 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1320 ns | 0.0258 ns | 0.0216 ns |  0.1261 ns | 0.102 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.3886 ns | 0.1193 ns | 0.1116 ns |  2.3931 ns | 1.831 |    0.09 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.7732 ns | 0.0433 ns | 0.0384 ns |  0.7631 ns | 0.596 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.2631 ns | 0.0966 ns | 0.0856 ns |  2.2591 ns | 1.739 |    0.10 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.9583 ns | 0.6110 ns | 0.5417 ns |  3.0391 ns | 2.201 |    0.39 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.5883 ns | 0.0871 ns | 0.0727 ns |  0.5786 ns | 0.440 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.7518 ns | 0.3270 ns | 0.2731 ns |  0.6799 ns | 0.563 |    0.21 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.3048 ns | 0.0319 ns | 0.0266 ns |  0.2886 ns | 0.236 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.2190 ns | 0.1136 ns | 0.1007 ns |  0.2239 ns | 0.168 |    0.08 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.3536 ns | 0.0139 ns | 0.0082 ns |  1.3533 ns | 1.037 |    0.03 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.3601 ns | 0.0100 ns | 0.0059 ns |  0.3601 ns | 0.276 |    0.01 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.2556 ns | 0.0347 ns | 0.0230 ns |  1.2533 ns | 0.959 |    0.03 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.2400 ns | 0.0285 ns | 0.0188 ns |  1.2365 ns | 0.947 |    0.03 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1273 ns | 0.0246 ns | 0.0163 ns |  0.1249 ns | 0.097 |    0.01 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.1274 ns | 0.0242 ns | 0.0144 ns |  0.1278 ns | 0.098 |    0.01 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.1271 ns | 0.0203 ns | 0.0106 ns |  0.1311 ns | 0.098 |    0.01 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.1574 ns | 0.0276 ns | 0.0230 ns |  0.1492 ns | 0.120 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  0.6964 ns | 0.0367 ns | 0.0325 ns |  0.6878 ns | 0.534 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  0.3762 ns | 0.0299 ns | 0.0216 ns |  0.3758 ns | 0.287 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  0.6035 ns | 0.0342 ns | 0.0203 ns |  0.5938 ns | 0.462 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  0.5708 ns | 0.0447 ns | 0.0419 ns |  0.5667 ns | 0.426 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  0.1102 ns | 0.0170 ns | 0.0089 ns |  0.1138 ns | 0.085 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  0.1412 ns | 0.0268 ns | 0.0159 ns |  0.1422 ns | 0.108 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  0.0023 ns | 0.0049 ns | 0.0029 ns |  0.0003 ns | 0.002 |    0.00 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  0.0005 ns | 0.0025 ns | 0.0017 ns |  0.0000 ns | 0.000 |    0.00 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 |  2.6146 ns | 0.0686 ns | 0.0573 ns |  2.6114 ns | 1.999 |    0.08 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 |  1.8974 ns | 0.0417 ns | 0.0248 ns |  1.9007 ns | 1.453 |    0.04 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 |  2.6949 ns | 0.0672 ns | 0.0444 ns |  2.6883 ns | 2.059 |    0.08 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 |  1.2454 ns | 0.0372 ns | 0.0330 ns |  1.2326 ns | 0.956 |    0.04 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 |  1.4361 ns | 0.0511 ns | 0.0453 ns |  1.4350 ns | 1.106 |    0.04 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 |  0.5099 ns | 0.0294 ns | 0.0195 ns |  0.5122 ns | 0.390 |    0.02 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 |  2.6761 ns | 0.0730 ns | 0.0528 ns |  2.6832 ns | 2.046 |    0.06 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 |  0.7637 ns | 0.0359 ns | 0.0318 ns |  0.7554 ns | 0.587 |    0.03 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 |  2.8507 ns | 0.0360 ns | 0.0238 ns |  2.8430 ns | 2.178 |    0.06 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 11.0572 ns | 0.1409 ns | 0.0838 ns | 11.0821 ns | 8.468 |    0.23 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 |  3.3053 ns | 0.0868 ns | 0.0627 ns |  3.3196 ns | 2.527 |    0.07 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 |  3.2835 ns | 0.0888 ns | 0.0588 ns |  3.2864 ns | 2.508 |    0.06 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  1.8057 ns | 0.0324 ns | 0.0214 ns |  1.8098 ns | 1.379 |    0.04 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  1.8076 ns | 0.0471 ns | 0.0280 ns |  1.8107 ns | 1.385 |    0.05 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  0.8959 ns | 0.0344 ns | 0.0228 ns |  0.8958 ns | 0.684 |    0.02 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  0.9592 ns | 0.0116 ns | 0.0069 ns |  0.9599 ns | 0.735 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  4.6963 ns | 0.1284 ns | 0.1201 ns |  4.6967 ns | 3.585 |    0.11 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 12.0376 ns | 0.1257 ns | 0.0832 ns | 12.0417 ns | 9.196 |    0.28 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  6.4238 ns | 0.1113 ns | 0.0736 ns |  6.4402 ns | 4.907 |    0.14 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.4359 ns | 0.1331 ns | 0.0880 ns |  6.4404 ns | 4.916 |    0.13 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  2.4720 ns | 0.0905 ns | 0.0755 ns |  2.4808 ns | 1.895 |    0.06 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.5195 ns | 0.1707 ns | 0.1596 ns |  2.5462 ns | 1.917 |    0.12 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  1.9403 ns | 0.0971 ns | 0.0909 ns |  1.9362 ns | 1.482 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  1.8762 ns | 0.0621 ns | 0.0581 ns |  1.8838 ns | 1.449 |    0.04 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 |  2.9049 ns | 0.0530 ns | 0.0351 ns |  2.9094 ns | 2.219 |    0.08 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 11.0910 ns | 0.1117 ns | 0.0739 ns | 11.0800 ns | 8.472 |    0.22 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 |  2.9673 ns | 0.0719 ns | 0.0428 ns |  2.9745 ns | 2.273 |    0.08 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 |  2.6785 ns | 0.0310 ns | 0.0205 ns |  2.6747 ns | 2.046 |    0.06 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  1.2190 ns | 0.0373 ns | 0.0247 ns |  1.2259 ns | 0.932 |    0.04 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  1.2268 ns | 0.0437 ns | 0.0365 ns |  1.2119 ns | 0.942 |    0.04 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  0.9502 ns | 0.0363 ns | 0.0240 ns |  0.9459 ns | 0.726 |    0.03 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  0.9453 ns | 0.0253 ns | 0.0168 ns |  0.9404 ns | 0.722 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  2.4996 ns | 0.0485 ns | 0.0288 ns |  2.4989 ns | 1.915 |    0.07 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  5.7155 ns | 0.0893 ns | 0.0531 ns |  5.7048 ns | 4.378 |    0.15 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  2.2931 ns | 0.0614 ns | 0.0544 ns |  2.2877 ns | 1.752 |    0.08 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  2.2694 ns | 0.0428 ns | 0.0283 ns |  2.2678 ns | 1.734 |    0.06 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  0.6761 ns | 0.0200 ns | 0.0132 ns |  0.6764 ns | 0.516 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  0.6604 ns | 0.0143 ns | 0.0085 ns |  0.6625 ns | 0.506 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  0.6337 ns | 0.0345 ns | 0.0306 ns |  0.6393 ns | 0.488 |    0.03 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  0.6413 ns | 0.0517 ns | 0.0484 ns |  0.6378 ns | 0.492 |    0.04 |

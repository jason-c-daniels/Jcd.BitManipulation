```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-LONWEL : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-UAIUVB : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```
| Method                                   | Runtime              | Mean       | Error     | StdDev    | Median     | Ratio  | RatioSD |
|----------------------------------------- |--------------------- |-----------:|----------:|----------:|-----------:|-------:|--------:|
| BitConverter_ToDouble                    | .NET 8.0             |  1.4649 ns | 0.0375 ns | 0.0223 ns |  1.4629 ns |  1.196 |    0.02 |
| BitConverter_ToFloat                     | .NET 8.0             |  1.4508 ns | 0.0301 ns | 0.0179 ns |  1.4509 ns |  1.184 |    0.02 |
| BitConverter_ToUInt64                    | .NET 8.0             |  1.2598 ns | 0.0618 ns | 0.0578 ns |  1.2303 ns |  1.053 |    0.04 |
| BitConverter_ToInt64                     | .NET 8.0             |  1.7135 ns | 0.0421 ns | 0.0278 ns |  1.7078 ns |  1.404 |    0.02 |
| BitConverter_ToUInt32                    | .NET 8.0             |  1.2101 ns | 0.0102 ns | 0.0061 ns |  1.2114 ns |  0.988 |    0.01 |
| BitConverter_ToInt32                     | .NET 8.0             |  1.6458 ns | 0.0299 ns | 0.0198 ns |  1.6421 ns |  1.343 |    0.02 |
| BitConverter_ToUInt16                    | .NET 8.0             |  3.5273 ns | 0.0218 ns | 0.0144 ns |  3.5269 ns |  2.880 |    0.02 |
| BitConverter_ToInt16                     | .NET 8.0             |  3.7481 ns | 0.0248 ns | 0.0148 ns |  3.7461 ns |  3.059 |    0.02 |
| ByteIndexer_From_A_Double                | .NET 8.0             |  1.2650 ns | 0.0186 ns | 0.0123 ns |  1.2673 ns |  1.031 |    0.01 |
| ByteIndexer_From_A_Float                 | .NET 8.0             |  0.1448 ns | 0.0193 ns | 0.0128 ns |  0.1439 ns |  0.118 |    0.01 |
| ByteIndexer_From_A_UInt64                | .NET 8.0             |  1.2251 ns | 0.0123 ns | 0.0073 ns |  1.2251 ns |  1.000 |    0.00 |
| ByteIndexer_From_A_Int64                 | .NET 8.0             |  1.2181 ns | 0.0111 ns | 0.0073 ns |  1.2183 ns |  0.994 |    0.01 |
| ByteIndexer_From_A_UInt32                | .NET 8.0             |  0.1207 ns | 0.0050 ns | 0.0033 ns |  0.1202 ns |  0.099 |    0.00 |
| ByteIndexer_From_A_Int32                 | .NET 8.0             |  0.1272 ns | 0.0112 ns | 0.0067 ns |  0.1283 ns |  0.104 |    0.01 |
| ByteIndexer_From_A_UInt16                | .NET 8.0             |  0.1425 ns | 0.0122 ns | 0.0081 ns |  0.1441 ns |  0.117 |    0.01 |
| ByteIndexer_From_A_Int16                 | .NET 8.0             |  0.1442 ns | 0.0217 ns | 0.0144 ns |  0.1461 ns |  0.116 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET 8.0             |  2.3286 ns | 0.0608 ns | 0.0402 ns |  2.3182 ns |  1.903 |    0.04 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET 8.0             |  0.7148 ns | 0.0095 ns | 0.0063 ns |  0.7131 ns |  0.582 |    0.00 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET 8.0             |  2.0231 ns | 0.0296 ns | 0.0155 ns |  2.0218 ns |  1.650 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET 8.0             |  2.0057 ns | 0.0140 ns | 0.0083 ns |  2.0050 ns |  1.637 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET 8.0             |  0.5474 ns | 0.0135 ns | 0.0089 ns |  0.5492 ns |  0.447 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET 8.0             |  0.5397 ns | 0.0098 ns | 0.0065 ns |  0.5384 ns |  0.441 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET 8.0             |  0.3387 ns | 0.0141 ns | 0.0084 ns |  0.3361 ns |  0.276 |    0.01 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET 8.0             |  0.3389 ns | 0.0105 ns | 0.0063 ns |  0.3361 ns |  0.277 |    0.00 |
| ExtensionMethod_On_A_Double              | .NET 8.0             |  1.2577 ns | 0.0212 ns | 0.0126 ns |  1.2546 ns |  1.027 |    0.01 |
| ExtensionMethod_On_A_Float               | .NET 8.0             |  0.3537 ns | 0.0046 ns | 0.0024 ns |  0.3546 ns |  0.288 |    0.00 |
| ExtensionMethod_On_A_UInt64              | .NET 8.0             |  1.2013 ns | 0.0120 ns | 0.0079 ns |  1.2017 ns |  0.980 |    0.01 |
| ExtensionMethod_On_A_Int64               | .NET 8.0             |  1.2215 ns | 0.0317 ns | 0.0210 ns |  1.2251 ns |  0.994 |    0.02 |
| ExtensionMethod_On_A_UInt32              | .NET 8.0             |  0.1269 ns | 0.0057 ns | 0.0030 ns |  0.1270 ns |  0.103 |    0.00 |
| ExtensionMethod_On_A_Int32               | .NET 8.0             |  0.1219 ns | 0.0073 ns | 0.0048 ns |  0.1214 ns |  0.100 |    0.00 |
| ExtensionMethod_On_A_UInt16              | .NET 8.0             |  0.1349 ns | 0.0072 ns | 0.0048 ns |  0.1372 ns |  0.110 |    0.00 |
| ExtensionMethod_On_A_Int16               | .NET 8.0             |  0.0004 ns | 0.0009 ns | 0.0005 ns |  0.0002 ns |  0.000 |    0.00 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET 8.0             |  0.6707 ns | 0.0107 ns | 0.0071 ns |  0.6697 ns |  0.548 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET 8.0             |  0.1370 ns | 0.0037 ns | 0.0019 ns |  0.1367 ns |  0.112 |    0.00 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET 8.0             |  0.6067 ns | 0.0148 ns | 0.0098 ns |  0.6052 ns |  0.495 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET 8.0             |  0.6186 ns | 0.0100 ns | 0.0060 ns |  0.6192 ns |  0.505 |    0.00 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET 8.0             |  0.1229 ns | 0.0119 ns | 0.0079 ns |  0.1215 ns |  0.100 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET 8.0             |  0.1220 ns | 0.0111 ns | 0.0073 ns |  0.1235 ns |  0.099 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET 8.0             |  0.1262 ns | 0.0119 ns | 0.0071 ns |  0.1268 ns |  0.103 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET 8.0             |  0.1319 ns | 0.0145 ns | 0.0086 ns |  0.1298 ns |  0.108 |    0.01 |
| BitConverter_ToDouble                    | .NET Framework 4.6.2 | 26.4109 ns | 0.3447 ns | 0.2280 ns | 26.3594 ns | 21.544 |    0.23 |
| BitConverter_ToFloat                     | .NET Framework 4.6.2 | 23.6870 ns | 0.3299 ns | 0.1963 ns | 23.6024 ns | 19.335 |    0.24 |
| BitConverter_ToUInt64                    | .NET Framework 4.6.2 | 26.2052 ns | 0.2169 ns | 0.1434 ns | 26.1913 ns | 21.397 |    0.14 |
| BitConverter_ToInt64                     | .NET Framework 4.6.2 | 25.2203 ns | 0.4677 ns | 0.3093 ns | 25.1024 ns | 20.601 |    0.29 |
| BitConverter_ToUInt32                    | .NET Framework 4.6.2 | 22.5967 ns | 0.4518 ns | 0.3773 ns | 22.5457 ns | 18.396 |    0.33 |
| BitConverter_ToInt32                     | .NET Framework 4.6.2 | 21.8600 ns | 0.4400 ns | 0.3900 ns | 21.8364 ns | 17.858 |    0.47 |
| BitConverter_ToUInt16                    | .NET Framework 4.6.2 | 22.7833 ns | 0.2330 ns | 0.1541 ns | 22.8138 ns | 18.590 |    0.20 |
| BitConverter_ToInt16                     | .NET Framework 4.6.2 | 21.0625 ns | 0.1728 ns | 0.1143 ns | 21.1120 ns | 17.186 |    0.14 |
| ByteIndexer_From_A_Double                | .NET Framework 4.6.2 |  2.9329 ns | 0.0717 ns | 0.0474 ns |  2.9388 ns |  2.389 |    0.05 |
| ByteIndexer_From_A_Float                 | .NET Framework 4.6.2 | 10.7800 ns | 0.1248 ns | 0.0826 ns | 10.7768 ns |  8.789 |    0.08 |
| ByteIndexer_From_A_UInt64                | .NET Framework 4.6.2 |  2.8989 ns | 0.0379 ns | 0.0251 ns |  2.9026 ns |  2.366 |    0.03 |
| ByteIndexer_From_A_Int64                 | .NET Framework 4.6.2 |  3.0463 ns | 0.0814 ns | 0.0635 ns |  3.0557 ns |  2.483 |    0.06 |
| ByteIndexer_From_A_UInt32                | .NET Framework 4.6.2 |  1.5324 ns | 0.0357 ns | 0.0236 ns |  1.5345 ns |  1.254 |    0.02 |
| ByteIndexer_From_A_Int32                 | .NET Framework 4.6.2 |  1.5383 ns | 0.0420 ns | 0.0278 ns |  1.5451 ns |  1.256 |    0.03 |
| ByteIndexer_From_A_UInt16                | .NET Framework 4.6.2 |  0.8910 ns | 0.0372 ns | 0.0269 ns |  0.8796 ns |  0.727 |    0.02 |
| ByteIndexer_From_A_Int16                 | .NET Framework 4.6.2 |  0.9236 ns | 0.0391 ns | 0.0283 ns |  0.9287 ns |  0.757 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Double       | .NET Framework 4.6.2 |  4.7959 ns | 0.0382 ns | 0.0227 ns |  4.7964 ns |  3.915 |    0.02 |
| ByteIndexer_On_ReadOnlySpan_Float        | .NET Framework 4.6.2 | 11.7013 ns | 0.1008 ns | 0.0667 ns | 11.7110 ns |  9.549 |    0.10 |
| ByteIndexer_On_ReadOnlySpan_UInt64       | .NET Framework 4.6.2 |  6.3231 ns | 0.0760 ns | 0.0503 ns |  6.3386 ns |  5.155 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_Int64        | .NET Framework 4.6.2 |  6.2814 ns | 0.0994 ns | 0.0591 ns |  6.2698 ns |  5.127 |    0.05 |
| ByteIndexer_On_ReadOnlySpan_UInt32       | .NET Framework 4.6.2 |  2.9523 ns | 0.0825 ns | 0.0772 ns |  2.9373 ns |  2.430 |    0.07 |
| ByteIndexer_On_ReadOnlySpan_Int32        | .NET Framework 4.6.2 |  2.8753 ns | 0.0450 ns | 0.0298 ns |  2.8718 ns |  2.346 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_UInt16       | .NET Framework 4.6.2 |  1.8479 ns | 0.0459 ns | 0.0273 ns |  1.8428 ns |  1.508 |    0.03 |
| ByteIndexer_On_ReadOnlySpan_Int16        | .NET Framework 4.6.2 |  1.8562 ns | 0.0494 ns | 0.0327 ns |  1.8629 ns |  1.514 |    0.03 |
| ExtensionMethod_On_A_Double              | .NET Framework 4.6.2 |  2.7517 ns | 0.0187 ns | 0.0124 ns |  2.7511 ns |  2.247 |    0.01 |
| ExtensionMethod_On_A_Float               | .NET Framework 4.6.2 | 10.7409 ns | 0.0512 ns | 0.0305 ns | 10.7452 ns |  8.767 |    0.05 |
| ExtensionMethod_On_A_UInt64              | .NET Framework 4.6.2 |  3.2726 ns | 0.0539 ns | 0.0357 ns |  3.2723 ns |  2.671 |    0.04 |
| ExtensionMethod_On_A_Int64               | .NET Framework 4.6.2 |  2.7534 ns | 0.0623 ns | 0.0412 ns |  2.7509 ns |  2.246 |    0.04 |
| ExtensionMethod_On_A_UInt32              | .NET Framework 4.6.2 |  1.4061 ns | 0.0275 ns | 0.0182 ns |  1.4009 ns |  1.148 |    0.02 |
| ExtensionMethod_On_A_Int32               | .NET Framework 4.6.2 |  1.4006 ns | 0.0406 ns | 0.0269 ns |  1.3904 ns |  1.142 |    0.03 |
| ExtensionMethod_On_A_UInt16              | .NET Framework 4.6.2 |  0.9635 ns | 0.0214 ns | 0.0127 ns |  0.9623 ns |  0.786 |    0.01 |
| ExtensionMethod_On_A_Int16               | .NET Framework 4.6.2 |  0.9396 ns | 0.0170 ns | 0.0089 ns |  0.9394 ns |  0.766 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToDouble | .NET Framework 4.6.2 |  2.4759 ns | 0.0134 ns | 0.0089 ns |  2.4765 ns |  2.021 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToFloat  | .NET Framework 4.6.2 |  5.8501 ns | 0.0999 ns | 0.0595 ns |  5.8481 ns |  4.775 |    0.06 |
| ExtensionMethod_On_A_Byte_Array_ToUInt64 | .NET Framework 4.6.2 |  2.2909 ns | 0.0157 ns | 0.0104 ns |  2.2897 ns |  1.871 |    0.02 |
| ExtensionMethod_On_A_Byte_Array_ToInt64  | .NET Framework 4.6.2 |  2.3175 ns | 0.0176 ns | 0.0104 ns |  2.3213 ns |  1.892 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt32 | .NET Framework 4.6.2 |  0.7658 ns | 0.0100 ns | 0.0060 ns |  0.7647 ns |  0.625 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt32  | .NET Framework 4.6.2 |  0.7788 ns | 0.0181 ns | 0.0120 ns |  0.7775 ns |  0.636 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToUInt16 | .NET Framework 4.6.2 |  0.6274 ns | 0.0149 ns | 0.0098 ns |  0.6275 ns |  0.513 |    0.01 |
| ExtensionMethod_On_A_Byte_Array_ToInt16  | .NET Framework 4.6.2 |  0.5883 ns | 0.0127 ns | 0.0076 ns |  0.5909 ns |  0.480 |    0.01 |

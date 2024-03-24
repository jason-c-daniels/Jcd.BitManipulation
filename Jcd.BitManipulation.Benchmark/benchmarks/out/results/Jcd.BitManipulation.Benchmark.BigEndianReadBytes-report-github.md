```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-BDWZRX : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-WYRMBM : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                            | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|-----------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double      | .NET 8.0             |  4.700 ns | 0.4107 ns | 0.3641 ns |  1.21 |    0.10 |
| BitConverter_GetBytes_Float       | .NET 8.0             |  4.044 ns | 0.2149 ns | 0.1794 ns |  1.01 |    0.05 |
| BitConverter_GetBytes_UInt64      | .NET 8.0             |  4.256 ns | 0.1399 ns | 0.1092 ns |  1.08 |    0.04 |
| BitConverter_GetBytes_Int64       | .NET 8.0             |  4.291 ns | 0.0824 ns | 0.0431 ns |  1.08 |    0.03 |
| BitConverter_GetBytes_UInt32      | .NET 8.0             |  4.145 ns | 0.1137 ns | 0.0888 ns |  1.04 |    0.02 |
| BitConverter_GetBytes_Int32       | .NET 8.0             |  4.112 ns | 0.1062 ns | 0.0632 ns |  1.03 |    0.02 |
| BitConverter_GetBytes_UInt16      | .NET 8.0             |  3.913 ns | 0.0502 ns | 0.0299 ns |  0.98 |    0.02 |
| BitConverter_GetBytes_Int16       | .NET 8.0             |  3.988 ns | 0.1058 ns | 0.0700 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Double | .NET 8.0             |  5.677 ns | 0.1189 ns | 0.0786 ns |  1.42 |    0.04 |
| BigEndianByteIndexer_Slice_Float  | .NET 8.0             |  6.581 ns | 0.3449 ns | 0.3226 ns |  1.62 |    0.06 |
| BigEndianByteIndexer_Slice_UInt64 | .NET 8.0             |  6.436 ns | 0.1713 ns | 0.1133 ns |  1.61 |    0.03 |
| BigEndianByteIndexer_Slice_Int64  | .NET 8.0             |  6.084 ns | 0.0562 ns | 0.0372 ns |  1.53 |    0.03 |
| BigEndianByteIndexer_Slice_UInt32 | .NET 8.0             |  4.301 ns | 0.0641 ns | 0.0424 ns |  1.08 |    0.03 |
| BigEndianByteIndexer_Slice_Int32  | .NET 8.0             |  4.381 ns | 0.0611 ns | 0.0404 ns |  1.10 |    0.02 |
| BigEndianByteIndexer_Slice_UInt16 | .NET 8.0             |  3.609 ns | 0.0591 ns | 0.0351 ns |  0.91 |    0.02 |
| BigEndianByteIndexer_Slice_Int16  | .NET 8.0             |  3.592 ns | 0.0433 ns | 0.0258 ns |  0.90 |    0.02 |
| ExtensionMethod_ReadBytes_Double  | .NET 8.0             |  5.867 ns | 0.1310 ns | 0.0866 ns |  1.47 |    0.03 |
| ExtensionMethod_ReadBytes_Float   | .NET 8.0             |  6.817 ns | 0.0910 ns | 0.0541 ns |  1.71 |    0.04 |
| ExtensionMethod_ReadBytes_UInt64  | .NET 8.0             |  6.206 ns | 0.2916 ns | 0.2727 ns |  1.59 |    0.06 |
| ExtensionMethod_ReadBytes_Int64   | .NET 8.0             |  5.274 ns | 0.3293 ns | 0.3081 ns |  1.34 |    0.06 |
| ExtensionMethod_ReadBytes_UInt32  | .NET 8.0             |  5.296 ns | 0.3894 ns | 0.3642 ns |  1.31 |    0.10 |
| ExtensionMethod_ReadBytes_Int32   | .NET 8.0             |  3.712 ns | 0.1713 ns | 0.1602 ns |  0.94 |    0.04 |
| ExtensionMethod_ReadBytes_UInt16  | .NET 8.0             |  3.676 ns | 0.1312 ns | 0.1228 ns |  0.93 |    0.04 |
| ExtensionMethod_ReadBytes_Int16   | .NET 8.0             |  3.226 ns | 0.0852 ns | 0.0665 ns |  0.81 |    0.02 |
| BitConverter_GetBytes_Double      | .NET Framework 4.6.2 | 25.873 ns | 0.9933 ns | 0.9291 ns |  6.41 |    0.25 |
| BitConverter_GetBytes_Float       | .NET Framework 4.6.2 | 23.524 ns | 0.4841 ns | 0.3780 ns |  5.90 |    0.10 |
| BitConverter_GetBytes_UInt64      | .NET Framework 4.6.2 | 24.181 ns | 0.1769 ns | 0.0925 ns |  6.07 |    0.12 |
| BitConverter_GetBytes_Int64       | .NET Framework 4.6.2 | 24.883 ns | 0.5361 ns | 0.3876 ns |  6.25 |    0.16 |
| BitConverter_GetBytes_UInt32      | .NET Framework 4.6.2 | 23.587 ns | 0.1744 ns | 0.1154 ns |  5.92 |    0.11 |
| BitConverter_GetBytes_Int32       | .NET Framework 4.6.2 | 23.491 ns | 0.2354 ns | 0.1401 ns |  5.90 |    0.10 |
| BitConverter_GetBytes_UInt16      | .NET Framework 4.6.2 | 21.873 ns | 0.2386 ns | 0.1578 ns |  5.49 |    0.07 |
| BitConverter_GetBytes_Int16       | .NET Framework 4.6.2 | 21.771 ns | 0.1729 ns | 0.1144 ns |  5.46 |    0.11 |
| BigEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 |  6.503 ns | 0.0379 ns | 0.0226 ns |  1.63 |    0.03 |
| BigEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 |  9.036 ns | 0.1608 ns | 0.0957 ns |  2.27 |    0.04 |
| BigEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 |  6.687 ns | 0.0605 ns | 0.0400 ns |  1.68 |    0.03 |
| BigEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 |  6.783 ns | 0.0630 ns | 0.0417 ns |  1.70 |    0.03 |
| BigEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 |  3.606 ns | 0.0372 ns | 0.0221 ns |  0.91 |    0.02 |
| BigEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 |  3.598 ns | 0.0694 ns | 0.0459 ns |  0.90 |    0.02 |
| BigEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 |  2.503 ns | 0.0179 ns | 0.0118 ns |  0.63 |    0.01 |
| BigEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 |  2.488 ns | 0.0241 ns | 0.0159 ns |  0.62 |    0.01 |
| ExtensionMethod_ReadBytes_Double  | .NET Framework 4.6.2 |  6.389 ns | 0.0863 ns | 0.0571 ns |  1.60 |    0.04 |
| ExtensionMethod_ReadBytes_Float   | .NET Framework 4.6.2 |  7.931 ns | 0.0909 ns | 0.0541 ns |  1.99 |    0.04 |
| ExtensionMethod_ReadBytes_UInt64  | .NET Framework 4.6.2 |  6.276 ns | 0.0537 ns | 0.0319 ns |  1.58 |    0.02 |
| ExtensionMethod_ReadBytes_Int64   | .NET Framework 4.6.2 |  3.910 ns | 0.0752 ns | 0.0447 ns |  0.98 |    0.02 |
| ExtensionMethod_ReadBytes_UInt32  | .NET Framework 4.6.2 |  3.905 ns | 0.0484 ns | 0.0320 ns |  0.98 |    0.02 |
| ExtensionMethod_ReadBytes_Int32   | .NET Framework 4.6.2 |  2.837 ns | 0.0279 ns | 0.0146 ns |  0.71 |    0.02 |
| ExtensionMethod_ReadBytes_UInt16  | .NET Framework 4.6.2 |  2.772 ns | 0.0587 ns | 0.0388 ns |  0.70 |    0.01 |
| ExtensionMethod_ReadBytes_Int16   | .NET Framework 4.6.2 |  2.250 ns | 0.0217 ns | 0.0143 ns |  0.56 |    0.01 |

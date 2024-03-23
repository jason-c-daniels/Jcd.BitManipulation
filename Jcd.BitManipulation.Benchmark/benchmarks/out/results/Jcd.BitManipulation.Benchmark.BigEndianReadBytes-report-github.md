```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-JSAIVR : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-PHWTJI : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                            | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|-----------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double      | .NET 8.0             |  4.069 ns | 0.1149 ns | 0.0831 ns |  1.02 |    0.02 |
| BitConverter_GetBytes_Float       | .NET 8.0             |  3.936 ns | 0.1262 ns | 0.1119 ns |  0.99 |    0.03 |
| BitConverter_GetBytes_UInt64      | .NET 8.0             |  4.413 ns | 0.1355 ns | 0.1201 ns |  1.11 |    0.03 |
| BitConverter_GetBytes_Int64       | .NET 8.0             |  4.572 ns | 0.2707 ns | 0.2399 ns |  1.15 |    0.07 |
| BitConverter_GetBytes_UInt32      | .NET 8.0             |  4.415 ns | 0.2850 ns | 0.2666 ns |  1.09 |    0.05 |
| BitConverter_GetBytes_Int32       | .NET 8.0             |  4.020 ns | 0.0564 ns | 0.0373 ns |  1.01 |    0.01 |
| BitConverter_GetBytes_UInt16      | .NET 8.0             |  3.991 ns | 0.0631 ns | 0.0375 ns |  1.00 |    0.01 |
| BitConverter_GetBytes_Int16       | .NET 8.0             |  4.000 ns | 0.0575 ns | 0.0380 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Double | .NET 8.0             |  6.172 ns | 0.0769 ns | 0.0402 ns |  1.55 |    0.02 |
| BigEndianByteIndexer_Slice_Float  | .NET 8.0             |  6.907 ns | 0.0940 ns | 0.0622 ns |  1.73 |    0.02 |
| BigEndianByteIndexer_Slice_UInt64 | .NET 8.0             |  5.706 ns | 0.1522 ns | 0.1007 ns |  1.43 |    0.04 |
| BigEndianByteIndexer_Slice_Int64  | .NET 8.0             |  5.663 ns | 0.0797 ns | 0.0527 ns |  1.42 |    0.02 |
| BigEndianByteIndexer_Slice_UInt32 | .NET 8.0             |  4.598 ns | 0.0582 ns | 0.0346 ns |  1.15 |    0.02 |
| BigEndianByteIndexer_Slice_Int32  | .NET 8.0             |  4.514 ns | 0.0294 ns | 0.0175 ns |  1.13 |    0.01 |
| BigEndianByteIndexer_Slice_UInt16 | .NET 8.0             |  3.429 ns | 0.0420 ns | 0.0250 ns |  0.86 |    0.01 |
| BigEndianByteIndexer_Slice_Int16  | .NET 8.0             |  3.466 ns | 0.0900 ns | 0.0595 ns |  0.87 |    0.02 |
| ExtensionMethod_ReadBytes_Double  | .NET 8.0             |  5.948 ns | 0.0673 ns | 0.0445 ns |  1.49 |    0.02 |
| ExtensionMethod_ReadBytes_Float   | .NET 8.0             |  6.943 ns | 0.0583 ns | 0.0347 ns |  1.74 |    0.02 |
| ExtensionMethod_ReadBytes_UInt64  | .NET 8.0             |  6.030 ns | 0.0567 ns | 0.0297 ns |  1.51 |    0.02 |
| ExtensionMethod_ReadBytes_Int64   | .NET 8.0             |  5.407 ns | 0.1682 ns | 0.1573 ns |  1.36 |    0.04 |
| ExtensionMethod_ReadBytes_UInt32  | .NET 8.0             |  4.760 ns | 0.1678 ns | 0.1570 ns |  1.21 |    0.02 |
| ExtensionMethod_ReadBytes_Int32   | .NET 8.0             |  3.617 ns | 0.1007 ns | 0.0666 ns |  0.90 |    0.02 |
| ExtensionMethod_ReadBytes_UInt16  | .NET 8.0             |  3.658 ns | 0.0698 ns | 0.0462 ns |  0.91 |    0.02 |
| ExtensionMethod_ReadBytes_Int16   | .NET 8.0             |  3.208 ns | 0.0412 ns | 0.0273 ns |  0.80 |    0.01 |
| BitConverter_GetBytes_Double      | .NET Framework 4.6.2 | 25.232 ns | 0.1386 ns | 0.0917 ns |  6.31 |    0.07 |
| BitConverter_GetBytes_Float       | .NET Framework 4.6.2 | 24.254 ns | 0.1278 ns | 0.0760 ns |  6.07 |    0.06 |
| BitConverter_GetBytes_UInt64      | .NET Framework 4.6.2 | 25.696 ns | 0.5363 ns | 0.4754 ns |  6.47 |    0.15 |
| BitConverter_GetBytes_Int64       | .NET Framework 4.6.2 | 25.621 ns | 0.2265 ns | 0.1348 ns |  6.42 |    0.07 |
| BitConverter_GetBytes_UInt32      | .NET Framework 4.6.2 | 24.513 ns | 0.2552 ns | 0.1688 ns |  6.13 |    0.06 |
| BitConverter_GetBytes_Int32       | .NET Framework 4.6.2 | 24.545 ns | 0.2127 ns | 0.1407 ns |  6.14 |    0.08 |
| BitConverter_GetBytes_UInt16      | .NET Framework 4.6.2 | 22.665 ns | 0.1956 ns | 0.1164 ns |  5.68 |    0.07 |
| BitConverter_GetBytes_Int16       | .NET Framework 4.6.2 | 22.452 ns | 0.1034 ns | 0.0684 ns |  5.61 |    0.06 |
| BigEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 |  6.553 ns | 0.0840 ns | 0.0500 ns |  1.64 |    0.02 |
| BigEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 |  9.887 ns | 0.0448 ns | 0.0266 ns |  2.48 |    0.02 |
| BigEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 |  6.824 ns | 0.0326 ns | 0.0171 ns |  1.71 |    0.01 |
| BigEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 |  6.714 ns | 0.0258 ns | 0.0135 ns |  1.68 |    0.02 |
| BigEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 |  3.771 ns | 0.0718 ns | 0.0475 ns |  0.94 |    0.01 |
| BigEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 |  3.883 ns | 0.0500 ns | 0.0331 ns |  0.97 |    0.01 |
| BigEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 |  2.948 ns | 0.0211 ns | 0.0126 ns |  0.74 |    0.01 |
| BigEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 |  2.873 ns | 0.0579 ns | 0.0383 ns |  0.72 |    0.01 |
| ExtensionMethod_ReadBytes_Double  | .NET Framework 4.6.2 |  6.781 ns | 0.1573 ns | 0.1040 ns |  1.70 |    0.03 |
| ExtensionMethod_ReadBytes_Float   | .NET Framework 4.6.2 |  8.955 ns | 0.0617 ns | 0.0367 ns |  2.24 |    0.02 |
| ExtensionMethod_ReadBytes_UInt64  | .NET Framework 4.6.2 |  6.471 ns | 0.1214 ns | 0.0803 ns |  1.62 |    0.03 |
| ExtensionMethod_ReadBytes_Int64   | .NET Framework 4.6.2 |  4.079 ns | 0.0664 ns | 0.0439 ns |  1.02 |    0.01 |
| ExtensionMethod_ReadBytes_UInt32  | .NET Framework 4.6.2 |  3.775 ns | 0.0925 ns | 0.0612 ns |  0.94 |    0.02 |
| ExtensionMethod_ReadBytes_Int32   | .NET Framework 4.6.2 |  3.216 ns | 0.1042 ns | 0.0689 ns |  0.80 |    0.02 |
| ExtensionMethod_ReadBytes_UInt16  | .NET Framework 4.6.2 |  3.009 ns | 0.0534 ns | 0.0318 ns |  0.75 |    0.01 |
| ExtensionMethod_ReadBytes_Int16   | .NET Framework 4.6.2 |  2.582 ns | 0.0229 ns | 0.0137 ns |  0.65 |    0.01 |

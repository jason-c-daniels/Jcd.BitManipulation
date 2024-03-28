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

| Method                            | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|-----------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double      | .NET 8.0             |  4.409 ns | 0.1240 ns | 0.0820 ns |  1.09 |    0.02 |
| BitConverter_GetBytes_Float       | .NET 8.0             |  4.515 ns | 0.0557 ns | 0.0368 ns |  1.12 |    0.01 |
| BitConverter_GetBytes_UInt64      | .NET 8.0             |  4.179 ns | 0.0643 ns | 0.0425 ns |  1.04 |    0.02 |
| BitConverter_GetBytes_Int64       | .NET 8.0             |  4.332 ns | 0.2663 ns | 0.2491 ns |  1.10 |    0.06 |
| BitConverter_GetBytes_UInt32      | .NET 8.0             |  4.303 ns | 0.0437 ns | 0.0229 ns |  1.07 |    0.01 |
| BitConverter_GetBytes_Int32       | .NET 8.0             |  4.218 ns | 0.0985 ns | 0.0652 ns |  1.05 |    0.02 |
| BitConverter_GetBytes_UInt16      | .NET 8.0             |  4.022 ns | 0.0564 ns | 0.0336 ns |  1.00 |    0.01 |
| BitConverter_GetBytes_Int16       | .NET 8.0             |  4.036 ns | 0.0569 ns | 0.0377 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Double | .NET 8.0             |  3.531 ns | 0.0651 ns | 0.0430 ns |  0.87 |    0.01 |
| BigEndianByteIndexer_Slice_Float  | .NET 8.0             |  3.425 ns | 0.0381 ns | 0.0252 ns |  0.85 |    0.01 |
| BigEndianByteIndexer_Slice_UInt64 | .NET 8.0             |  3.567 ns | 0.0735 ns | 0.0437 ns |  0.89 |    0.01 |
| BigEndianByteIndexer_Slice_Int64  | .NET 8.0             |  3.557 ns | 0.0631 ns | 0.0376 ns |  0.88 |    0.01 |
| BigEndianByteIndexer_Slice_UInt32 | .NET 8.0             |  3.588 ns | 0.1487 ns | 0.1319 ns |  0.88 |    0.03 |
| BigEndianByteIndexer_Slice_Int32  | .NET 8.0             |  3.606 ns | 0.2872 ns | 0.2687 ns |  0.92 |    0.07 |
| BigEndianByteIndexer_Slice_UInt16 | .NET 8.0             |  3.391 ns | 0.0421 ns | 0.0278 ns |  0.84 |    0.01 |
| BigEndianByteIndexer_Slice_Int16  | .NET 8.0             |  3.479 ns | 0.1120 ns | 0.0993 ns |  0.87 |    0.03 |
| ExtensionMethod_ReadBytes_Double  | .NET 8.0             |  3.587 ns | 0.0185 ns | 0.0122 ns |  0.89 |    0.01 |
| ExtensionMethod_ReadBytes_Float   | .NET 8.0             |  3.344 ns | 0.0362 ns | 0.0239 ns |  0.83 |    0.01 |
| ExtensionMethod_ReadBytes_UInt64  | .NET 8.0             |  3.667 ns | 0.1061 ns | 0.0631 ns |  0.91 |    0.02 |
| ExtensionMethod_ReadBytes_Int64   | .NET 8.0             |  4.542 ns | 0.0862 ns | 0.0570 ns |  1.13 |    0.02 |
| ExtensionMethod_ReadBytes_UInt32  | .NET 8.0             |  3.300 ns | 0.0882 ns | 0.0525 ns |  0.82 |    0.01 |
| ExtensionMethod_ReadBytes_Int32   | .NET 8.0             |  3.700 ns | 0.0821 ns | 0.0543 ns |  0.92 |    0.01 |
| ExtensionMethod_ReadBytes_UInt16  | .NET 8.0             |  3.241 ns | 0.0373 ns | 0.0195 ns |  0.80 |    0.01 |
| ExtensionMethod_ReadBytes_Int16   | .NET 8.0             |  3.292 ns | 0.0319 ns | 0.0190 ns |  0.82 |    0.01 |
| BitConverter_GetBytes_Double      | .NET Framework 4.6.2 | 24.766 ns | 0.1381 ns | 0.0913 ns |  6.14 |    0.05 |
| BitConverter_GetBytes_Float       | .NET Framework 4.6.2 | 23.478 ns | 0.1704 ns | 0.1014 ns |  5.83 |    0.06 |
| BitConverter_GetBytes_UInt64      | .NET Framework 4.6.2 | 25.089 ns | 0.2397 ns | 0.1426 ns |  6.22 |    0.05 |
| BitConverter_GetBytes_Int64       | .NET Framework 4.6.2 | 24.796 ns | 0.0968 ns | 0.0576 ns |  6.15 |    0.06 |
| BitConverter_GetBytes_UInt32      | .NET Framework 4.6.2 | 23.619 ns | 0.2146 ns | 0.1420 ns |  5.85 |    0.06 |
| BitConverter_GetBytes_Int32       | .NET Framework 4.6.2 | 23.571 ns | 0.2566 ns | 0.1697 ns |  5.84 |    0.06 |
| BitConverter_GetBytes_UInt16      | .NET Framework 4.6.2 | 22.884 ns | 0.1871 ns | 0.1238 ns |  5.67 |    0.05 |
| BitConverter_GetBytes_Int16       | .NET Framework 4.6.2 | 22.772 ns | 0.2738 ns | 0.1629 ns |  5.65 |    0.06 |
| BigEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 |  8.290 ns | 0.0864 ns | 0.0514 ns |  2.06 |    0.02 |
| BigEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 |  8.731 ns | 0.0433 ns | 0.0258 ns |  2.17 |    0.02 |
| BigEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 |  7.726 ns | 0.0901 ns | 0.0596 ns |  1.91 |    0.02 |
| BigEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 |  7.754 ns | 0.0373 ns | 0.0195 ns |  1.92 |    0.02 |
| BigEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 |  4.904 ns | 0.0884 ns | 0.0526 ns |  1.22 |    0.02 |
| BigEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 |  4.917 ns | 0.0560 ns | 0.0333 ns |  1.22 |    0.01 |
| BigEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 |  3.988 ns | 0.0536 ns | 0.0354 ns |  0.99 |    0.02 |
| BigEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 |  3.952 ns | 0.0524 ns | 0.0347 ns |  0.98 |    0.01 |
| ExtensionMethod_ReadBytes_Double  | .NET Framework 4.6.2 |  8.429 ns | 0.0628 ns | 0.0374 ns |  2.09 |    0.02 |
| ExtensionMethod_ReadBytes_Float   | .NET Framework 4.6.2 |  9.097 ns | 0.0877 ns | 0.0580 ns |  2.25 |    0.03 |
| ExtensionMethod_ReadBytes_UInt64  | .NET Framework 4.6.2 |  7.926 ns | 0.0352 ns | 0.0233 ns |  1.96 |    0.02 |
| ExtensionMethod_ReadBytes_Int64   | .NET Framework 4.6.2 |  4.582 ns | 0.0353 ns | 0.0233 ns |  1.14 |    0.01 |
| ExtensionMethod_ReadBytes_UInt32  | .NET Framework 4.6.2 |  5.177 ns | 0.0860 ns | 0.0569 ns |  1.28 |    0.02 |
| ExtensionMethod_ReadBytes_Int32   | .NET Framework 4.6.2 |  3.516 ns | 0.0317 ns | 0.0166 ns |  0.87 |    0.01 |
| ExtensionMethod_ReadBytes_UInt16  | .NET Framework 4.6.2 |  4.312 ns | 0.0590 ns | 0.0351 ns |  1.07 |    0.01 |
| ExtensionMethod_ReadBytes_Int16   | .NET Framework 4.6.2 |  2.954 ns | 0.0313 ns | 0.0207 ns |  0.73 |    0.01 |

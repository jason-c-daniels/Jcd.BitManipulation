```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ICMWHD : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-OXTARK : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |       Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  1.4408 ns | 0.0233 ns | 0.0122 ns |  0.42 |    0.00 |
| BitConverter_ToFloat   | .NET 8.0             |  1.4463 ns | 0.0291 ns | 0.0173 ns |  0.43 |    0.01 |
| BitConverter_ToUInt64  | .NET 8.0             |  1.2806 ns | 0.0551 ns | 0.0488 ns |  0.38 |    0.01 |
| BitConverter_ToInt64   | .NET 8.0             |  1.6777 ns | 0.0258 ns | 0.0170 ns |  0.50 |    0.01 |
| BitConverter_ToUInt32  | .NET 8.0             |  1.1901 ns | 0.0462 ns | 0.0275 ns |  0.35 |    0.01 |
| BitConverter_ToInt32   | .NET 8.0             |  1.6280 ns | 0.0201 ns | 0.0105 ns |  0.48 |    0.00 |
| BitConverter_ToUInt16  | .NET 8.0             |  3.4628 ns | 0.0257 ns | 0.0153 ns |  1.02 |    0.01 |
| BitConverter_ToInt16   | .NET 8.0             |  3.3881 ns | 0.0424 ns | 0.0252 ns |  1.00 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  3.7439 ns | 0.0958 ns | 0.0693 ns |  1.11 |    0.02 |
| ExtensionMethod_Float  | .NET 8.0             |  1.9968 ns | 0.0411 ns | 0.0272 ns |  0.59 |    0.01 |
| ExtensionMethod_UInt64 | .NET 8.0             |  3.7777 ns | 0.0736 ns | 0.0385 ns |  1.11 |    0.02 |
| ExtensionMethod_Int64  | .NET 8.0             |  3.5237 ns | 0.0937 ns | 0.0620 ns |  1.04 |    0.02 |
| ExtensionMethod_UInt32 | .NET 8.0             |  1.6579 ns | 0.0493 ns | 0.0326 ns |  0.49 |    0.01 |
| ExtensionMethod_Int32  | .NET 8.0             |  1.6728 ns | 0.0425 ns | 0.0253 ns |  0.49 |    0.01 |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.7851 ns | 0.0319 ns | 0.0211 ns |  0.23 |    0.01 |
| ExtensionMethod_Int16  | .NET 8.0             |  0.7982 ns | 0.0347 ns | 0.0229 ns |  0.24 |    0.01 |
| ByteIndexer_Double     | .NET 8.0             |  3.7409 ns | 0.0674 ns | 0.0401 ns |  1.10 |    0.02 |
| ByteIndexer_Float      | .NET 8.0             |  2.1236 ns | 0.0471 ns | 0.0280 ns |  0.63 |    0.01 |
| ByteIndexer_UInt64     | .NET 8.0             |  3.6594 ns | 0.0617 ns | 0.0367 ns |  1.08 |    0.01 |
| ByteIndexer_Int64      | .NET 8.0             |  3.4759 ns | 0.0921 ns | 0.0719 ns |  1.03 |    0.02 |
| ByteIndexer_UInt32     | .NET 8.0             |  1.8625 ns | 0.0454 ns | 0.0300 ns |  0.55 |    0.01 |
| ByteIndexer_Int32      | .NET 8.0             |  2.1266 ns | 0.0496 ns | 0.0328 ns |  0.63 |    0.01 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.7760 ns | 0.0775 ns | 0.0725 ns |  0.23 |    0.02 |
| ByteIndexer_Int16      | .NET 8.0             |  0.6350 ns | 0.0405 ns | 0.0338 ns |  0.19 |    0.01 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 | 26.4879 ns | 0.4877 ns | 0.3226 ns |  7.82 |    0.14 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 | 25.1003 ns | 0.7471 ns | 0.6989 ns |  7.34 |    0.15 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 | 27.0563 ns | 0.5682 ns | 0.5315 ns |  7.99 |    0.17 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 | 25.6477 ns | 0.5350 ns | 0.4743 ns |  7.61 |    0.17 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 | 24.9468 ns | 0.7573 ns | 0.7084 ns |  7.26 |    0.16 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 | 23.7333 ns | 0.7064 ns | 0.6608 ns |  7.06 |    0.17 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 | 24.1344 ns | 0.6083 ns | 0.5690 ns |  7.22 |    0.13 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 | 21.6655 ns | 0.4204 ns | 0.2780 ns |  6.41 |    0.10 |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  6.8315 ns | 0.0981 ns | 0.0649 ns |  2.02 |    0.03 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 12.8866 ns | 0.2778 ns | 0.2598 ns |  3.81 |    0.09 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  6.5053 ns | 0.1402 ns | 0.0927 ns |  1.92 |    0.04 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  6.5465 ns | 0.1499 ns | 0.1402 ns |  1.93 |    0.03 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  2.9807 ns | 0.0644 ns | 0.0426 ns |  0.88 |    0.01 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  2.9853 ns | 0.0733 ns | 0.0485 ns |  0.88 |    0.02 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  1.4478 ns | 0.0485 ns | 0.0351 ns |  0.43 |    0.01 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  1.5481 ns | 0.0946 ns | 0.0885 ns |  0.46 |    0.02 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  6.8373 ns | 0.0578 ns | 0.0344 ns |  2.02 |    0.02 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 12.8310 ns | 0.1427 ns | 0.0849 ns |  3.79 |    0.04 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  6.6711 ns | 0.0696 ns | 0.0414 ns |  1.97 |    0.02 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  6.7047 ns | 0.1218 ns | 0.0806 ns |  1.98 |    0.03 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  2.9969 ns | 0.0756 ns | 0.0631 ns |  0.89 |    0.02 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  2.9403 ns | 0.0632 ns | 0.0418 ns |  0.87 |    0.01 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.7078 ns | 0.1502 ns | 0.1405 ns |  0.50 |    0.05 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.4004 ns | 0.0506 ns | 0.0423 ns |  0.42 |    0.01 |

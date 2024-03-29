```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-ZHKFEE : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-PRZSWO : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                 | Runtime              |       Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  1.5449 ns | 0.0914 ns | 0.0855 ns |  0.42 |    0.02 |
| BitConverter_ToFloat   | .NET 8.0             |  1.4686 ns | 0.0847 ns | 0.0793 ns |  0.41 |    0.03 |
| BitConverter_ToUInt64  | .NET 8.0             |  1.2835 ns | 0.0815 ns | 0.0722 ns |  0.36 |    0.02 |
| BitConverter_ToInt64   | .NET 8.0             |  1.6981 ns | 0.0780 ns | 0.0691 ns |  0.47 |    0.02 |
| BitConverter_ToUInt32  | .NET 8.0             |  1.2391 ns | 0.0463 ns | 0.0306 ns |  0.34 |    0.01 |
| BitConverter_ToInt32   | .NET 8.0             |  1.6569 ns | 0.0421 ns | 0.0278 ns |  0.46 |    0.01 |
| BitConverter_ToUInt16  | .NET 8.0             |  3.1951 ns | 0.0600 ns | 0.0357 ns |  0.89 |    0.01 |
| BitConverter_ToInt16   | .NET 8.0             |  3.6035 ns | 0.0454 ns | 0.0301 ns |  1.00 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  1.3532 ns | 0.1188 ns | 0.1112 ns |  0.37 |    0.02 |
| ExtensionMethod_Float  | .NET 8.0             |  0.3268 ns | 0.0303 ns | 0.0180 ns |  0.09 |    0.00 |
| ExtensionMethod_UInt64 | .NET 8.0             |  1.3054 ns | 0.0870 ns | 0.0813 ns |  0.37 |    0.03 |
| ExtensionMethod_Int64  | .NET 8.0             |  1.2985 ns | 0.0866 ns | 0.0810 ns |  0.37 |    0.02 |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.2799 ns | 0.0188 ns | 0.0125 ns |  0.08 |    0.00 |
| ExtensionMethod_Int32  | .NET 8.0             |  0.3384 ns | 0.0217 ns | 0.0143 ns |  0.09 |    0.00 |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.1600 ns | 0.0588 ns | 0.0521 ns |  0.04 |    0.02 |
| ExtensionMethod_Int16  | .NET 8.0             |  0.1018 ns | 0.0439 ns | 0.0389 ns |  0.03 |    0.01 |
| ByteIndexer_Double     | .NET 8.0             |  1.2792 ns | 0.0674 ns | 0.0631 ns |  0.36 |    0.02 |
| ByteIndexer_Float      | .NET 8.0             |  0.3673 ns | 0.0322 ns | 0.0233 ns |  0.10 |    0.01 |
| ByteIndexer_UInt64     | .NET 8.0             |  1.1790 ns | 0.0234 ns | 0.0139 ns |  0.33 |    0.01 |
| ByteIndexer_Int64      | .NET 8.0             |  1.1799 ns | 0.0122 ns | 0.0064 ns |  0.33 |    0.00 |
| ByteIndexer_UInt32     | .NET 8.0             |  0.3397 ns | 0.0319 ns | 0.0211 ns |  0.09 |    0.01 |
| ByteIndexer_Int32      | .NET 8.0             |  0.3558 ns | 0.0305 ns | 0.0221 ns |  0.10 |    0.01 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.1145 ns | 0.0121 ns | 0.0072 ns |  0.03 |    0.00 |
| ByteIndexer_Int16      | .NET 8.0             |  0.1320 ns | 0.0227 ns | 0.0150 ns |  0.04 |    0.00 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 | 26.0257 ns | 0.4677 ns | 0.2783 ns |  7.21 |    0.09 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 | 24.1667 ns | 0.4365 ns | 0.2598 ns |  6.70 |    0.09 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 | 26.6508 ns | 0.4096 ns | 0.2709 ns |  7.40 |    0.08 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 | 25.1070 ns | 0.2713 ns | 0.1615 ns |  6.96 |    0.07 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 | 25.6328 ns | 0.9599 ns | 0.8979 ns |  7.00 |    0.22 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 | 24.2479 ns | 1.1167 ns | 0.9325 ns |  6.80 |    0.23 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 | 23.6933 ns | 0.4772 ns | 0.3985 ns |  6.56 |    0.08 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 | 22.0349 ns | 0.7044 ns | 0.6589 ns |  6.13 |    0.15 |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  6.8262 ns | 0.0842 ns | 0.0501 ns |  1.89 |    0.02 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 12.6395 ns | 0.2889 ns | 0.2703 ns |  3.53 |    0.08 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  6.4787 ns | 0.1349 ns | 0.0892 ns |  1.80 |    0.04 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  6.5106 ns | 0.1494 ns | 0.1080 ns |  1.81 |    0.03 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  2.9792 ns | 0.0771 ns | 0.0644 ns |  0.83 |    0.02 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  2.9834 ns | 0.0776 ns | 0.0561 ns |  0.83 |    0.02 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  1.3847 ns | 0.0497 ns | 0.0329 ns |  0.38 |    0.01 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  1.4338 ns | 0.0333 ns | 0.0220 ns |  0.40 |    0.01 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  6.7125 ns | 0.0824 ns | 0.0545 ns |  1.86 |    0.02 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 12.5801 ns | 0.2632 ns | 0.1741 ns |  3.49 |    0.05 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  6.6098 ns | 0.1043 ns | 0.0690 ns |  1.83 |    0.02 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  6.5895 ns | 0.1161 ns | 0.0768 ns |  1.83 |    0.03 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  2.9103 ns | 0.0544 ns | 0.0360 ns |  0.81 |    0.01 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  2.9210 ns | 0.0526 ns | 0.0313 ns |  0.81 |    0.01 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.4048 ns | 0.0301 ns | 0.0199 ns |  0.39 |    0.01 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.3743 ns | 0.0202 ns | 0.0120 ns |  0.38 |    0.00 |

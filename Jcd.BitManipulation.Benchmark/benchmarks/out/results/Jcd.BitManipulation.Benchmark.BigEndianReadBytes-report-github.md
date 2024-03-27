```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-CYDLTE : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-CSEHTA : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                            | Runtime              |      Mean |     Error |    StdDev | Ratio | RatioSD |
|-----------------------------------|----------------------|----------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double      | .NET 8.0             |  4.527 ns | 0.1339 ns | 0.1187 ns |  1.11 |    0.06 |
| BitConverter_GetBytes_Float       | .NET 8.0             |  4.674 ns | 0.3064 ns | 0.2558 ns |  1.15 |    0.11 |
| BitConverter_GetBytes_UInt64      | .NET 8.0             |  4.991 ns | 0.4166 ns | 0.3693 ns |  1.22 |    0.07 |
| BitConverter_GetBytes_Int64       | .NET 8.0             |  4.699 ns | 0.3296 ns | 0.3083 ns |  1.16 |    0.10 |
| BitConverter_GetBytes_UInt32      | .NET 8.0             |  4.412 ns | 0.2571 ns | 0.2404 ns |  1.09 |    0.10 |
| BitConverter_GetBytes_Int32       | .NET 8.0             |  4.547 ns | 0.2154 ns | 0.2015 ns |  1.12 |    0.06 |
| BitConverter_GetBytes_UInt16      | .NET 8.0             |  4.044 ns | 0.1251 ns | 0.0745 ns |  0.97 |    0.05 |
| BitConverter_GetBytes_Int16       | .NET 8.0             |  4.062 ns | 0.2028 ns | 0.1897 ns |  1.00 |    0.00 |
| BigEndianByteIndexer_Slice_Double | .NET 8.0             |  3.543 ns | 0.2140 ns | 0.2001 ns |  0.87 |    0.06 |
| BigEndianByteIndexer_Slice_Float  | .NET 8.0             |  3.552 ns | 0.2184 ns | 0.2043 ns |  0.88 |    0.08 |
| BigEndianByteIndexer_Slice_UInt64 | .NET 8.0             |  3.740 ns | 0.1955 ns | 0.1829 ns |  0.92 |    0.06 |
| BigEndianByteIndexer_Slice_Int64  | .NET 8.0             |  3.750 ns | 0.3561 ns | 0.3331 ns |  0.92 |    0.06 |
| BigEndianByteIndexer_Slice_UInt32 | .NET 8.0             |  4.044 ns | 0.5739 ns | 0.5368 ns |  1.00 |    0.16 |
| BigEndianByteIndexer_Slice_Int32  | .NET 8.0             |  3.798 ns | 0.3976 ns | 0.3719 ns |  0.93 |    0.07 |
| BigEndianByteIndexer_Slice_UInt16 | .NET 8.0             |  3.417 ns | 0.1047 ns | 0.0818 ns |  0.84 |    0.04 |
| BigEndianByteIndexer_Slice_Int16  | .NET 8.0             |  3.509 ns | 0.4075 ns | 0.3812 ns |  0.86 |    0.09 |
| ExtensionMethod_ReadBytes_Double  | .NET 8.0             |  3.547 ns | 0.0853 ns | 0.0508 ns |  0.85 |    0.04 |
| ExtensionMethod_ReadBytes_Float   | .NET 8.0             |  3.293 ns | 0.1064 ns | 0.0633 ns |  0.79 |    0.02 |
| ExtensionMethod_ReadBytes_UInt64  | .NET 8.0             |  3.417 ns | 0.0531 ns | 0.0316 ns |  0.82 |    0.03 |
| ExtensionMethod_ReadBytes_Int64   | .NET 8.0             |  4.832 ns | 0.0922 ns | 0.0610 ns |  1.17 |    0.05 |
| ExtensionMethod_ReadBytes_UInt32  | .NET 8.0             |  3.220 ns | 0.0905 ns | 0.0599 ns |  0.78 |    0.04 |
| ExtensionMethod_ReadBytes_Int32   | .NET 8.0             |  3.597 ns | 0.0688 ns | 0.0409 ns |  0.87 |    0.04 |
| ExtensionMethod_ReadBytes_UInt16  | .NET 8.0             |  3.164 ns | 0.0984 ns | 0.0711 ns |  0.77 |    0.05 |
| ExtensionMethod_ReadBytes_Int16   | .NET 8.0             |  3.149 ns | 0.0698 ns | 0.0462 ns |  0.76 |    0.03 |
| BitConverter_GetBytes_Double      | .NET Framework 4.6.2 | 25.219 ns | 0.2445 ns | 0.1617 ns |  6.10 |    0.26 |
| BitConverter_GetBytes_Float       | .NET Framework 4.6.2 | 24.027 ns | 0.4828 ns | 0.3193 ns |  5.81 |    0.22 |
| BitConverter_GetBytes_UInt64      | .NET Framework 4.6.2 | 25.447 ns | 1.0921 ns | 1.0216 ns |  6.28 |    0.33 |
| BitConverter_GetBytes_Int64       | .NET Framework 4.6.2 | 26.600 ns | 1.2083 ns | 1.1303 ns |  6.56 |    0.44 |
| BitConverter_GetBytes_UInt32      | .NET Framework 4.6.2 | 23.663 ns | 0.4250 ns | 0.2529 ns |  5.70 |    0.27 |
| BitConverter_GetBytes_Int32       | .NET Framework 4.6.2 | 24.572 ns | 0.7490 ns | 0.7006 ns |  6.06 |    0.30 |
| BitConverter_GetBytes_UInt16      | .NET Framework 4.6.2 | 22.308 ns | 0.4707 ns | 0.3113 ns |  5.40 |    0.22 |
| BitConverter_GetBytes_Int16       | .NET Framework 4.6.2 | 22.966 ns | 0.9083 ns | 0.8052 ns |  5.64 |    0.24 |
| BigEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 |  8.244 ns | 0.1500 ns | 0.0893 ns |  1.99 |    0.10 |
| BigEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 |  9.531 ns | 0.8127 ns | 0.7204 ns |  2.34 |    0.14 |
| BigEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 |  7.906 ns | 0.1001 ns | 0.0596 ns |  1.90 |    0.08 |
| BigEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 |  8.966 ns | 1.0971 ns | 1.0262 ns |  2.22 |    0.33 |
| BigEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 |  5.426 ns | 0.2838 ns | 0.2655 ns |  1.34 |    0.09 |
| BigEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 |  5.373 ns | 0.2266 ns | 0.2120 ns |  1.33 |    0.08 |
| BigEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 |  4.201 ns | 0.1544 ns | 0.1369 ns |  1.03 |    0.07 |
| BigEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 |  4.043 ns | 0.0415 ns | 0.0274 ns |  0.98 |    0.04 |
| ExtensionMethod_ReadBytes_Double  | .NET Framework 4.6.2 |  8.799 ns | 0.2669 ns | 0.2366 ns |  2.16 |    0.14 |
| ExtensionMethod_ReadBytes_Float   | .NET Framework 4.6.2 |  9.259 ns | 0.1477 ns | 0.0772 ns |  2.21 |    0.08 |
| ExtensionMethod_ReadBytes_UInt64  | .NET Framework 4.6.2 |  8.316 ns | 0.3086 ns | 0.2887 ns |  2.05 |    0.11 |
| ExtensionMethod_ReadBytes_Int64   | .NET Framework 4.6.2 |  4.681 ns | 0.0638 ns | 0.0422 ns |  1.13 |    0.05 |
| ExtensionMethod_ReadBytes_UInt32  | .NET Framework 4.6.2 |  5.333 ns | 0.2025 ns | 0.1795 ns |  1.31 |    0.09 |
| ExtensionMethod_ReadBytes_Int32   | .NET Framework 4.6.2 |  3.796 ns | 0.4364 ns | 0.4082 ns |  0.94 |    0.11 |
| ExtensionMethod_ReadBytes_UInt16  | .NET Framework 4.6.2 |  4.387 ns | 0.1878 ns | 0.1757 ns |  1.08 |    0.07 |
| ExtensionMethod_ReadBytes_Int16   | .NET Framework 4.6.2 |  2.987 ns | 0.1467 ns | 0.1372 ns |  0.74 |    0.03 |

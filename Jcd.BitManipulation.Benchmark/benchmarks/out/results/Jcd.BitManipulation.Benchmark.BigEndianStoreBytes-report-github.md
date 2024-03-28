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

| Method                 | Runtime              |       Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  1.4756 ns | 0.0169 ns | 0.0100 ns |  0.39 |    0.00 |
| BitConverter_ToFloat   | .NET 8.0             |  1.5487 ns | 0.0550 ns | 0.0397 ns |  0.41 |    0.01 |
| BitConverter_ToUInt64  | .NET 8.0             |  1.3396 ns | 0.0962 ns | 0.0900 ns |  0.35 |    0.02 |
| BitConverter_ToInt64   | .NET 8.0             |  1.6678 ns | 0.0233 ns | 0.0154 ns |  0.44 |    0.00 |
| BitConverter_ToUInt32  | .NET 8.0             |  1.2081 ns | 0.0132 ns | 0.0087 ns |  0.32 |    0.00 |
| BitConverter_ToInt32   | .NET 8.0             |  1.7112 ns | 0.0405 ns | 0.0241 ns |  0.46 |    0.01 |
| BitConverter_ToUInt16  | .NET 8.0             |  3.5445 ns | 0.0186 ns | 0.0123 ns |  0.94 |    0.00 |
| BitConverter_ToInt16   | .NET 8.0             |  3.7528 ns | 0.0277 ns | 0.0183 ns |  1.00 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  1.2601 ns | 0.0149 ns | 0.0088 ns |  0.34 |    0.00 |
| ExtensionMethod_Float  | .NET 8.0             |  0.3263 ns | 0.0075 ns | 0.0049 ns |  0.09 |    0.00 |
| ExtensionMethod_UInt64 | .NET 8.0             |  1.2063 ns | 0.0182 ns | 0.0121 ns |  0.32 |    0.00 |
| ExtensionMethod_Int64  | .NET 8.0             |  1.1963 ns | 0.0092 ns | 0.0061 ns |  0.32 |    0.00 |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.3345 ns | 0.0068 ns | 0.0045 ns |  0.09 |    0.00 |
| ExtensionMethod_Int32  | .NET 8.0             |  0.3334 ns | 0.0102 ns | 0.0061 ns |  0.09 |    0.00 |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.1252 ns | 0.0077 ns | 0.0051 ns |  0.03 |    0.00 |
| ExtensionMethod_Int16  | .NET 8.0             |  0.1374 ns | 0.0174 ns | 0.0115 ns |  0.04 |    0.00 |
| ByteIndexer_Double     | .NET 8.0             |  1.2613 ns | 0.0249 ns | 0.0148 ns |  0.34 |    0.01 |
| ByteIndexer_Float      | .NET 8.0             |  0.4138 ns | 0.0520 ns | 0.0461 ns |  0.11 |    0.01 |
| ByteIndexer_UInt64     | .NET 8.0             |  1.2555 ns | 0.0796 ns | 0.0745 ns |  0.34 |    0.02 |
| ByteIndexer_Int64      | .NET 8.0             |  1.3401 ns | 0.1122 ns | 0.1050 ns |  0.36 |    0.03 |
| ByteIndexer_UInt32     | .NET 8.0             |  0.2830 ns | 0.0099 ns | 0.0059 ns |  0.08 |    0.00 |
| ByteIndexer_Int32      | .NET 8.0             |  0.3348 ns | 0.0242 ns | 0.0160 ns |  0.09 |    0.00 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.1363 ns | 0.0224 ns | 0.0148 ns |  0.04 |    0.00 |
| ByteIndexer_Int16      | .NET 8.0             |  0.1362 ns | 0.0228 ns | 0.0151 ns |  0.04 |    0.00 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 | 26.3290 ns | 0.1704 ns | 0.1127 ns |  7.02 |    0.05 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 | 23.9414 ns | 0.5574 ns | 0.5214 ns |  6.35 |    0.14 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 | 26.1231 ns | 0.2750 ns | 0.1819 ns |  6.96 |    0.06 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 | 27.2401 ns | 1.7080 ns | 1.5977 ns |  7.32 |    0.44 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 | 24.5566 ns | 0.4998 ns | 0.4174 ns |  6.56 |    0.13 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 | 22.7908 ns | 0.8042 ns | 0.7522 ns |  6.05 |    0.22 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 | 22.9348 ns | 0.2047 ns | 0.1354 ns |  6.11 |    0.03 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 | 21.3335 ns | 0.1189 ns | 0.0708 ns |  5.69 |    0.03 |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  6.7912 ns | 0.0399 ns | 0.0264 ns |  1.81 |    0.01 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 12.4291 ns | 0.1693 ns | 0.1008 ns |  3.31 |    0.03 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  6.6696 ns | 0.2671 ns | 0.2498 ns |  1.79 |    0.07 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  7.0269 ns | 0.4809 ns | 0.4263 ns |  1.82 |    0.06 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  3.1282 ns | 0.0820 ns | 0.0767 ns |  0.84 |    0.02 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  3.0924 ns | 0.1478 ns | 0.1383 ns |  0.83 |    0.04 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  1.4421 ns | 0.0495 ns | 0.0327 ns |  0.38 |    0.01 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  1.4412 ns | 0.0403 ns | 0.0240 ns |  0.38 |    0.01 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  6.8291 ns | 0.1235 ns | 0.0735 ns |  1.82 |    0.01 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 12.8335 ns | 0.3024 ns | 0.2829 ns |  3.39 |    0.07 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  6.9132 ns | 0.1643 ns | 0.1537 ns |  1.83 |    0.04 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  6.7702 ns | 0.1501 ns | 0.1253 ns |  1.80 |    0.04 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  2.9511 ns | 0.0811 ns | 0.0677 ns |  0.78 |    0.02 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  3.0351 ns | 0.0652 ns | 0.0431 ns |  0.81 |    0.01 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.4035 ns | 0.0465 ns | 0.0277 ns |  0.37 |    0.01 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.4266 ns | 0.0553 ns | 0.0517 ns |  0.38 |    0.01 |

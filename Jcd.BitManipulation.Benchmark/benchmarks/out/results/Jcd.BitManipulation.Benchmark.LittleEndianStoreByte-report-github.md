```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-JSKQEV : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-FYSSQN : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median |  Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|-------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0328 ns | 0.0457 ns | 0.0427 ns |  0.0174 ns |  0.344 |    0.44 |
| BitConverter_ToFloat   | .NET 8.0             |  0.0026 ns | 0.0059 ns | 0.0052 ns |  0.0000 ns |  0.027 |    0.05 |
| BitConverter_ToUInt64  | .NET 8.0             |  0.0144 ns | 0.0230 ns | 0.0204 ns |  0.0031 ns |  0.146 |    0.20 |
| BitConverter_ToInt64   | .NET 8.0             |  0.0759 ns | 0.0218 ns | 0.0170 ns |  0.0694 ns |  0.680 |    0.20 |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0061 ns | 0.0165 ns | 0.0146 ns |  0.0000 ns |  0.075 |    0.18 |
| BitConverter_ToInt32   | .NET 8.0             |  0.0162 ns | 0.0240 ns | 0.0224 ns |  0.0000 ns |  0.098 |    0.18 |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| BitConverter_ToInt16   | .NET 8.0             |  0.1174 ns | 0.0280 ns | 0.0234 ns |  0.1165 ns |  1.000 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  0.0630 ns | 0.0505 ns | 0.0473 ns |  0.0494 ns |  0.488 |    0.40 |
| ExtensionMethod_Float  | .NET 8.0             |  0.0028 ns | 0.0066 ns | 0.0062 ns |  0.0000 ns |  0.025 |    0.07 |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0072 ns | 0.0120 ns | 0.0107 ns |  0.0000 ns |  0.050 |    0.08 |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0161 ns | 0.0213 ns | 0.0189 ns |  0.0042 ns |  0.154 |    0.18 |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0014 ns | 0.0058 ns | 0.0039 ns |  0.0000 ns |  0.009 |    0.02 |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ByteIndexer_Double     | .NET 8.0             |  0.0109 ns | 0.0188 ns | 0.0166 ns |  0.0000 ns |  0.100 |    0.15 |
| ByteIndexer_Float      | .NET 8.0             |  0.0067 ns | 0.0147 ns | 0.0097 ns |  0.0017 ns |  0.062 |    0.08 |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0443 ns | 0.0550 ns | 0.0514 ns |  0.0124 ns |  0.288 |    0.39 |
| ByteIndexer_Int64      | .NET 8.0             |  0.0073 ns | 0.0128 ns | 0.0113 ns |  0.0000 ns |  0.063 |    0.10 |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0201 ns | 0.0242 ns | 0.0226 ns |  0.0109 ns |  0.184 |    0.17 |
| ByteIndexer_Int32      | .NET 8.0             |  0.0158 ns | 0.0198 ns | 0.0154 ns |  0.0162 ns |  0.144 |    0.14 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0015 ns | 0.0053 ns | 0.0035 ns |  0.0000 ns |  0.013 |    0.03 |
| ByteIndexer_Int16      | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  3.9115 ns | 0.3430 ns | 0.3209 ns |  3.8394 ns | 34.441 |    6.38 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.5985 ns | 0.0730 ns | 0.0648 ns |  2.5878 ns | 23.033 |    4.76 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  3.8827 ns | 0.1350 ns | 0.1263 ns |  3.8515 ns | 34.356 |    6.68 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  2.4474 ns | 0.0877 ns | 0.0777 ns |  2.4464 ns | 21.642 |    4.49 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  2.9190 ns | 0.2184 ns | 0.2043 ns |  2.8728 ns | 25.942 |    5.22 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  1.8441 ns | 0.1162 ns | 0.0971 ns |  1.8177 ns | 16.272 |    3.17 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  3.8612 ns | 0.1569 ns | 0.1468 ns |  3.9068 ns | 34.121 |    7.34 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  2.1070 ns | 0.1239 ns | 0.1159 ns |  2.1015 ns | 18.689 |    4.15 |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.1254 ns | 0.0232 ns | 0.0181 ns |  0.1257 ns |  1.137 |    0.31 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.8518 ns | 0.4748 ns | 0.4209 ns |  9.7263 ns | 86.600 |   16.75 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0104 ns | 0.0202 ns | 0.0179 ns |  0.0002 ns |  0.103 |    0.17 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.0538 ns | 0.0295 ns | 0.0276 ns |  0.0391 ns |  0.523 |    0.27 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0236 ns | 0.0195 ns | 0.0116 ns |  0.0207 ns |  0.216 |    0.14 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0078 ns | 0.0101 ns | 0.0060 ns |  0.0091 ns |  0.074 |    0.06 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0060 ns | 0.0133 ns | 0.0088 ns |  0.0003 ns |  0.052 |    0.08 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.3907 ns | 0.1146 ns | 0.1072 ns |  1.3723 ns | 12.273 |    2.46 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 11.0405 ns | 0.9669 ns | 0.9044 ns | 10.6278 ns | 98.634 |   27.03 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.8624 ns | 0.0429 ns | 0.0255 ns |  1.8570 ns | 16.714 |    3.61 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.8813 ns | 0.0598 ns | 0.0500 ns |  1.8813 ns | 16.628 |    3.31 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.6136 ns | 0.0568 ns | 0.0531 ns |  1.6333 ns | 14.305 |    3.16 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.5585 ns | 0.0512 ns | 0.0339 ns |  1.5590 ns | 13.823 |    2.87 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.7986 ns | 0.0586 ns | 0.0423 ns |  1.7985 ns | 16.323 |    3.29 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.6350 ns | 0.0983 ns | 0.0920 ns |  1.6313 ns | 14.327 |    2.83 |

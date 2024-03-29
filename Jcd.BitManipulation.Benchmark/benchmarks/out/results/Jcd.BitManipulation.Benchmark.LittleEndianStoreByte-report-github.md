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

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median |  Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|-------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0031 ns | 0.0104 ns | 0.0062 ns |  0.0000 ns |  0.022 |    0.04 |
| BitConverter_ToFloat   | .NET 8.0             |  0.0038 ns | 0.0089 ns | 0.0046 ns |  0.0014 ns |  0.022 |    0.03 |
| BitConverter_ToUInt64  | .NET 8.0             |  0.0042 ns | 0.0086 ns | 0.0051 ns |  0.0024 ns |  0.030 |    0.04 |
| BitConverter_ToInt64   | .NET 8.0             |  0.1204 ns | 0.0145 ns | 0.0096 ns |  0.1235 ns |  0.804 |    0.12 |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0025 ns | 0.0053 ns | 0.0035 ns |  0.0011 ns |  0.015 |    0.02 |
| BitConverter_ToInt32   | .NET 8.0             |  0.0011 ns | 0.0052 ns | 0.0034 ns |  0.0000 ns |  0.007 |    0.02 |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| BitConverter_ToInt16   | .NET 8.0             |  0.1669 ns | 0.0366 ns | 0.0324 ns |  0.1590 ns |  1.000 |    0.00 |
| ExtensionMethod_Double | .NET 8.0             |  0.0156 ns | 0.0164 ns | 0.0118 ns |  0.0155 ns |  0.098 |    0.07 |
| ExtensionMethod_Float  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0067 ns | 0.0167 ns | 0.0130 ns |  0.0000 ns |  0.047 |    0.10 |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0004 ns | 0.0021 ns | 0.0012 ns |  0.0000 ns |  0.002 |    0.01 |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0024 ns | 0.0067 ns | 0.0044 ns |  0.0000 ns |  0.015 |    0.03 |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0030 ns | 0.0075 ns | 0.0045 ns |  0.0000 ns |  0.018 |    0.02 |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ByteIndexer_Double     | .NET 8.0             |  0.0045 ns | 0.0089 ns | 0.0059 ns |  0.0013 ns |  0.034 |    0.05 |
| ByteIndexer_Float      | .NET 8.0             |  0.0003 ns | 0.0015 ns | 0.0010 ns |  0.0000 ns |  0.003 |    0.01 |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0016 ns | 0.0033 ns | 0.0022 ns |  0.0006 ns |  0.009 |    0.01 |
| ByteIndexer_Int64      | .NET 8.0             |  0.0025 ns | 0.0056 ns | 0.0037 ns |  0.0000 ns |  0.018 |    0.03 |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0115 ns | 0.0215 ns | 0.0143 ns |  0.0035 ns |  0.087 |    0.11 |
| ByteIndexer_Int32      | .NET 8.0             |  0.0031 ns | 0.0051 ns | 0.0034 ns |  0.0025 ns |  0.023 |    0.02 |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0017 ns | 0.0051 ns | 0.0034 ns |  0.0000 ns |  0.012 |    0.02 |
| ByteIndexer_Int16      | .NET 8.0             |  0.0018 ns | 0.0058 ns | 0.0039 ns |  0.0000 ns |  0.013 |    0.03 |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  3.6886 ns | 0.0942 ns | 0.0881 ns |  3.6744 ns | 22.846 |    4.41 |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.5724 ns | 0.0277 ns | 0.0165 ns |  2.5720 ns | 17.129 |    2.66 |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  3.7517 ns | 0.0938 ns | 0.0732 ns |  3.7204 ns | 23.891 |    4.63 |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  2.4301 ns | 0.0648 ns | 0.0468 ns |  2.4170 ns | 15.865 |    2.56 |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  2.9051 ns | 0.2828 ns | 0.2507 ns |  2.8019 ns | 18.102 |    4.32 |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  1.8055 ns | 0.1087 ns | 0.0964 ns |  1.7739 ns | 11.143 |    1.93 |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  3.5709 ns | 0.1160 ns | 0.1028 ns |  3.5626 ns | 22.119 |    4.16 |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  2.0207 ns | 0.0615 ns | 0.0545 ns |  2.0236 ns | 12.515 |    2.29 |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.1181 ns | 0.0375 ns | 0.0351 ns |  0.1082 ns |  0.739 |    0.23 |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.8905 ns | 0.2677 ns | 0.2504 ns |  9.8812 ns | 61.304 |   12.04 |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0526 ns | 0.0352 ns | 0.0330 ns |  0.0610 ns |  0.337 |    0.22 |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.0240 ns | 0.0337 ns | 0.0299 ns |  0.0154 ns |  0.126 |    0.14 |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0250 ns | 0.0095 ns | 0.0063 ns |  0.0268 ns |  0.167 |    0.05 |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0358 ns | 0.0154 ns | 0.0080 ns |  0.0352 ns |  0.229 |    0.06 |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.000 |    0.00 |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0654 ns | 0.0604 ns | 0.0565 ns |  0.0773 ns |  0.429 |    0.33 |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.2917 ns | 0.0349 ns | 0.0231 ns |  1.2928 ns |  8.653 |    1.30 |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 10.3523 ns | 0.2895 ns | 0.2418 ns | 10.3345 ns | 64.664 |   12.60 |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.9602 ns | 0.1127 ns | 0.1054 ns |  1.9538 ns | 12.181 |    2.37 |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.8917 ns | 0.0561 ns | 0.0497 ns |  1.8937 ns | 11.738 |    2.34 |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.6313 ns | 0.0660 ns | 0.0618 ns |  1.6493 ns | 10.077 |    1.90 |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.5145 ns | 0.0386 ns | 0.0229 ns |  1.5091 ns | 10.094 |    1.64 |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.8099 ns | 0.1163 ns | 0.1031 ns |  1.7853 ns | 11.241 |    2.31 |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.8383 ns | 0.2858 ns | 0.2673 ns |  1.7762 ns | 11.652 |    3.02 |

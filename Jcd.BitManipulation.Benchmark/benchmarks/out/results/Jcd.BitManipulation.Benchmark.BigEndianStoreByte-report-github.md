```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-VBQYBY : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-NFESSE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                      | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|-----------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| ExtensionMethod_On_A_Double | .NET 8.0             |  0.0054 ns | 0.0091 ns | 0.0060 ns |  0.0037 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET 8.0             |  0.0148 ns | 0.0198 ns | 0.0185 ns |  0.0045 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET 8.0             |  0.0083 ns | 0.0140 ns | 0.0093 ns |  0.0041 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET 8.0             |  0.0010 ns | 0.0031 ns | 0.0021 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET 8.0             |  0.0003 ns | 0.0010 ns | 0.0006 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET 8.0             |  0.0020 ns | 0.0060 ns | 0.0047 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET 8.0             |  0.0109 ns | 0.0208 ns | 0.0138 ns |  0.0070 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET 8.0             |  0.0076 ns | 0.0143 ns | 0.0103 ns |  0.0046 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET 8.0             |  0.0007 ns | 0.0021 ns | 0.0014 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET 8.0             |  0.0028 ns | 0.0091 ns | 0.0054 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET 8.0             |  0.0001 ns | 0.0003 ns | 0.0002 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET 8.0             |  0.0077 ns | 0.0162 ns | 0.0107 ns |  0.0019 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET 8.0             |  0.0126 ns | 0.0161 ns | 0.0106 ns |  0.0093 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET 8.0             |  0.0064 ns | 0.0114 ns | 0.0075 ns |  0.0037 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET 8.0             |  0.0038 ns | 0.0092 ns | 0.0061 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Double | .NET Framework 4.6.2 |  0.1526 ns | 0.0328 ns | 0.0307 ns |  0.1575 ns |     ? |       ? |
| ExtensionMethod_On_A_Float  | .NET Framework 4.6.2 |  9.9242 ns | 0.2186 ns | 0.1707 ns |  9.8854 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt64 | .NET Framework 4.6.2 |  0.0022 ns | 0.0052 ns | 0.0038 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int64  | .NET Framework 4.6.2 |  0.0012 ns | 0.0049 ns | 0.0046 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt32 | .NET Framework 4.6.2 |  0.0006 ns | 0.0030 ns | 0.0018 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int32  | .NET Framework 4.6.2 |  0.0015 ns | 0.0067 ns | 0.0048 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_On_A_Int16  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_From_A_Double   | .NET Framework 4.6.2 |  1.7117 ns | 0.1078 ns | 0.0900 ns |  1.6981 ns |     ? |       ? |
| ByteIndexer_From_A_Float    | .NET Framework 4.6.2 | 11.8641 ns | 0.2066 ns | 0.1081 ns | 11.8976 ns |     ? |       ? |
| ByteIndexer_From_A_UInt64   | .NET Framework 4.6.2 |  1.5617 ns | 0.0431 ns | 0.0256 ns |  1.5677 ns |     ? |       ? |
| ByteIndexer_From_A_Int64    | .NET Framework 4.6.2 |  1.5525 ns | 0.0538 ns | 0.0420 ns |  1.5481 ns |     ? |       ? |
| ByteIndexer_From_A_UInt32   | .NET Framework 4.6.2 |  1.4470 ns | 0.0929 ns | 0.0824 ns |  1.4269 ns |     ? |       ? |
| ByteIndexer_From_A_Int32    | .NET Framework 4.6.2 |  1.4315 ns | 0.0632 ns | 0.0591 ns |  1.4455 ns |     ? |       ? |
| ByteIndexer_From_A_UInt16   | .NET Framework 4.6.2 |  1.6608 ns | 0.0744 ns | 0.0660 ns |  1.6479 ns |     ? |       ? |
| ByteIndexer_From_A_Int16    | .NET Framework 4.6.2 |  1.5138 ns | 0.1098 ns | 0.1027 ns |  1.4987 ns |     ? |       ? |

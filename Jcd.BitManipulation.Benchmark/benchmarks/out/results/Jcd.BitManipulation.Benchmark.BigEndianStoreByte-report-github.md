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

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| ExtensionMethod_Double | .NET 8.0             |  0.0052 ns | 0.0076 ns | 0.0045 ns |  0.0045 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.0725 ns | 0.0236 ns | 0.0171 ns |  0.0673 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Float  | .NET 8.0             |  0.0018 ns | 0.0069 ns | 0.0050 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.3817 ns | 0.1535 ns | 0.0914 ns |  9.3510 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0211 ns | 0.0289 ns | 0.0271 ns |  0.0049 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.0028 ns | 0.0091 ns | 0.0071 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0344 ns | 0.0273 ns | 0.0255 ns |  0.0257 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0066 ns | 0.0132 ns | 0.0123 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0071 ns | 0.0160 ns | 0.0150 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0106 ns | 0.0238 ns | 0.0211 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0166 ns | 0.0208 ns | 0.0184 ns |  0.0077 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Double     | .NET 8.0             |  0.0059 ns | 0.0141 ns | 0.0074 ns |  0.0030 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.6295 ns | 0.1644 ns | 0.1538 ns |  1.5537 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Float      | .NET 8.0             |  0.0001 ns | 0.0002 ns | 0.0002 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 11.2747 ns | 0.5269 ns | 0.4670 ns | 11.1710 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.4998 ns | 0.0755 ns | 0.0707 ns |  1.5064 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int64      | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.5902 ns | 0.0987 ns | 0.0923 ns |  1.5826 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0003 ns | 0.0015 ns | 0.0010 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.2937 ns | 0.0446 ns | 0.0322 ns |  1.2922 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int32      | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.3389 ns | 0.0317 ns | 0.0209 ns |  1.3367 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0153 ns | 0.0227 ns | 0.0164 ns |  0.0122 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.5004 ns | 0.0710 ns | 0.0664 ns |  1.4624 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int16      | .NET 8.0             |  0.0099 ns | 0.0135 ns | 0.0113 ns |  0.0103 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.3440 ns | 0.0470 ns | 0.0280 ns |  1.3494 ns |     ? |       ? |

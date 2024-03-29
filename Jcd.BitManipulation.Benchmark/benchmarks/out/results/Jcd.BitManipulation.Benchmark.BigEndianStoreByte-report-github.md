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

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| ExtensionMethod_Double | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  0.0972 ns | 0.0235 ns | 0.0170 ns |  0.0995 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Float  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 |  9.0506 ns | 0.1696 ns | 0.1122 ns |  9.0469 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt64 | .NET 8.0             |  0.0107 ns | 0.0136 ns | 0.0090 ns |  0.0117 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  0.0001 ns | 0.0006 ns | 0.0004 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int64  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int32  | .NET 8.0             |  0.0025 ns | 0.0081 ns | 0.0063 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.0125 ns | 0.0203 ns | 0.0147 ns |  0.0089 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.0013 ns | 0.0055 ns | 0.0051 ns |  0.0000 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ExtensionMethod_Int16  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.2642 ns | 0.2472 ns | 0.2312 ns |  0.1562 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Double     | .NET 8.0             |  0.0012 ns | 0.0032 ns | 0.0021 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  1.4925 ns | 0.0536 ns | 0.0419 ns |  1.4986 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Float      | .NET 8.0             |  0.0010 ns | 0.0043 ns | 0.0026 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 11.1227 ns | 0.4812 ns | 0.4266 ns | 11.0493 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt64     | .NET 8.0             |  0.0060 ns | 0.0096 ns | 0.0063 ns |  0.0045 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  1.4028 ns | 0.0471 ns | 0.0341 ns |  1.3966 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int64      | .NET 8.0             |  0.0043 ns | 0.0094 ns | 0.0062 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  1.3836 ns | 0.0503 ns | 0.0393 ns |  1.3823 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt32     | .NET 8.0             |  0.0019 ns | 0.0063 ns | 0.0042 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.5450 ns | 0.5864 ns | 0.5198 ns |  1.2940 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int32      | .NET 8.0             |  0.0013 ns | 0.0041 ns | 0.0021 ns |  0.0001 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.3036 ns | 0.0843 ns | 0.0788 ns |  1.2978 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_UInt16     | .NET 8.0             |  0.0061 ns | 0.0137 ns | 0.0090 ns |  0.0002 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.4081 ns | 0.0481 ns | 0.0375 ns |  1.4170 ns |     ? |       ? |
|                        |                      |            |           |           |            |       |         |
| ByteIndexer_Int16      | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.3229 ns | 0.0505 ns | 0.0447 ns |  1.3264 ns |     ? |       ? |

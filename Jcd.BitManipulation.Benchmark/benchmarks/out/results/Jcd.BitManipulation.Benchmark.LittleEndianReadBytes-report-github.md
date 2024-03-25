```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-EEUGLS : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-HWBWFM : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                               | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double         | .NET 8.0             | 3.190 ns | 0.0723 ns | 0.0430 ns |  1.06 |    0.03 |
| BitConverter_GetBytes_Float          | .NET 8.0             | 3.197 ns | 0.0887 ns | 0.0587 ns |  1.06 |    0.03 |
| BitConverter_GetBytes_UInt64         | .NET 8.0             | 2.871 ns | 0.0414 ns | 0.0246 ns |  0.95 |    0.02 |
| BitConverter_GetBytes_Int64          | .NET 8.0             | 2.981 ns | 0.0629 ns | 0.0416 ns |  0.99 |    0.03 |
| BitConverter_GetBytes_UInt32         | .NET 8.0             | 3.144 ns | 0.2204 ns | 0.2061 ns |  1.04 |    0.09 |
| BitConverter_GetBytes_Int32          | .NET 8.0             | 2.926 ns | 0.1002 ns | 0.0937 ns |  0.98 |    0.03 |
| BitConverter_GetBytes_UInt16         | .NET 8.0             | 2.873 ns | 0.0613 ns | 0.0406 ns |  0.95 |    0.02 |
| BitConverter_GetBytes_Int16          | .NET 8.0             | 3.012 ns | 0.0781 ns | 0.0517 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Double | .NET 8.0             | 3.057 ns | 0.0719 ns | 0.0475 ns |  1.02 |    0.03 |
| LittleEndianByteIndexer_Slice_Float  | .NET 8.0             | 3.563 ns | 0.0638 ns | 0.0422 ns |  1.18 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET 8.0             | 3.197 ns | 0.0800 ns | 0.0529 ns |  1.06 |    0.03 |
| LittleEndianByteIndexer_Slice_Int64  | .NET 8.0             | 3.138 ns | 0.0820 ns | 0.0488 ns |  1.04 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET 8.0             | 3.172 ns | 0.0653 ns | 0.0432 ns |  1.05 |    0.02 |
| LittleEndianByteIndexer_Slice_Int32  | .NET 8.0             | 3.169 ns | 0.0419 ns | 0.0277 ns |  1.05 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET 8.0             | 3.432 ns | 0.0629 ns | 0.0416 ns |  1.14 |    0.02 |
| LittleEndianByteIndexer_Slice_Int16  | .NET 8.0             | 3.388 ns | 0.0928 ns | 0.0552 ns |  1.13 |    0.03 |
| ExtensionMethod_ReadBytes_Double     | .NET 8.0             | 2.959 ns | 0.0654 ns | 0.0433 ns |  0.98 |    0.02 |
| ExtensionMethod_ReadBytes_Float      | .NET 8.0             | 3.217 ns | 0.0717 ns | 0.0474 ns |  1.07 |    0.03 |
| ExtensionMethod_ReadBytes_UInt64     | .NET 8.0             | 2.905 ns | 0.0446 ns | 0.0295 ns |  0.96 |    0.02 |
| ExtensionMethod_ReadBytes_Int64      | .NET 8.0             | 4.899 ns | 0.0541 ns | 0.0358 ns |  1.63 |    0.02 |
| ExtensionMethod_ReadBytes_UInt32     | .NET 8.0             | 3.557 ns | 0.0876 ns | 0.0579 ns |  1.18 |    0.03 |
| ExtensionMethod_ReadBytes_Int32      | .NET 8.0             | 3.689 ns | 0.1144 ns | 0.0757 ns |  1.23 |    0.03 |
| ExtensionMethod_ReadBytes_UInt16     | .NET 8.0             | 3.768 ns | 0.0799 ns | 0.0475 ns |  1.25 |    0.04 |
| ExtensionMethod_ReadBytes_Int16      | .NET 8.0             | 2.994 ns | 0.0447 ns | 0.0266 ns |  1.00 |    0.02 |
| BitConverter_GetBytes_Double         | .NET Framework 4.6.2 | 4.360 ns | 0.2532 ns | 0.2368 ns |  1.41 |    0.07 |
| BitConverter_GetBytes_Float          | .NET Framework 4.6.2 | 3.637 ns | 0.0480 ns | 0.0318 ns |  1.21 |    0.03 |
| BitConverter_GetBytes_UInt64         | .NET Framework 4.6.2 | 4.231 ns | 0.0418 ns | 0.0219 ns |  1.41 |    0.02 |
| BitConverter_GetBytes_Int64          | .NET Framework 4.6.2 | 4.030 ns | 0.0376 ns | 0.0249 ns |  1.34 |    0.02 |
| BitConverter_GetBytes_UInt32         | .NET Framework 4.6.2 | 3.757 ns | 0.0401 ns | 0.0265 ns |  1.25 |    0.02 |
| BitConverter_GetBytes_Int32          | .NET Framework 4.6.2 | 3.661 ns | 0.0269 ns | 0.0178 ns |  1.22 |    0.02 |
| BitConverter_GetBytes_UInt16         | .NET Framework 4.6.2 | 3.940 ns | 0.0359 ns | 0.0214 ns |  1.31 |    0.02 |
| BitConverter_GetBytes_Int16          | .NET Framework 4.6.2 | 3.702 ns | 0.0412 ns | 0.0272 ns |  1.23 |    0.01 |
| LittleEndianByteIndexer_Slice_Double | .NET Framework 4.6.2 | 6.250 ns | 0.1064 ns | 0.0633 ns |  2.08 |    0.04 |
| LittleEndianByteIndexer_Slice_Float  | .NET Framework 4.6.2 | 7.680 ns | 0.1706 ns | 0.1015 ns |  2.55 |    0.06 |
| LittleEndianByteIndexer_Slice_UInt64 | .NET Framework 4.6.2 | 5.943 ns | 0.1120 ns | 0.0741 ns |  1.97 |    0.04 |
| LittleEndianByteIndexer_Slice_Int64  | .NET Framework 4.6.2 | 5.909 ns | 0.1067 ns | 0.0706 ns |  1.96 |    0.03 |
| LittleEndianByteIndexer_Slice_UInt32 | .NET Framework 4.6.2 | 3.697 ns | 0.0354 ns | 0.0210 ns |  1.23 |    0.02 |
| LittleEndianByteIndexer_Slice_Int32  | .NET Framework 4.6.2 | 3.604 ns | 0.0659 ns | 0.0436 ns |  1.20 |    0.02 |
| LittleEndianByteIndexer_Slice_UInt16 | .NET Framework 4.6.2 | 2.554 ns | 0.0339 ns | 0.0224 ns |  0.85 |    0.02 |
| LittleEndianByteIndexer_Slice_Int16  | .NET Framework 4.6.2 | 2.571 ns | 0.0366 ns | 0.0242 ns |  0.85 |    0.02 |
| ExtensionMethod_ReadBytes_Double     | .NET Framework 4.6.2 | 6.223 ns | 0.0470 ns | 0.0279 ns |  2.07 |    0.03 |
| ExtensionMethod_ReadBytes_Float      | .NET Framework 4.6.2 | 7.857 ns | 0.1009 ns | 0.0667 ns |  2.61 |    0.05 |
| ExtensionMethod_ReadBytes_UInt64     | .NET Framework 4.6.2 | 5.943 ns | 0.0934 ns | 0.0488 ns |  1.98 |    0.04 |
| ExtensionMethod_ReadBytes_Int64      | .NET Framework 4.6.2 | 4.368 ns | 0.0316 ns | 0.0188 ns |  1.45 |    0.03 |
| ExtensionMethod_ReadBytes_UInt32     | .NET Framework 4.6.2 | 3.758 ns | 0.0303 ns | 0.0201 ns |  1.25 |    0.02 |
| ExtensionMethod_ReadBytes_Int32      | .NET Framework 4.6.2 | 3.200 ns | 0.0192 ns | 0.0114 ns |  1.06 |    0.02 |
| ExtensionMethod_ReadBytes_UInt16     | .NET Framework 4.6.2 | 2.493 ns | 0.0282 ns | 0.0186 ns |  0.83 |    0.02 |
| ExtensionMethod_ReadBytes_Int16      | .NET Framework 4.6.2 | 2.117 ns | 0.0451 ns | 0.0298 ns |  0.70 |    0.02 |

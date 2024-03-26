```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-RWAMGA : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-PVBPMB : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10  
WarmupCount=10  

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0054 ns | 0.0140 ns | 0.0093 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET 8.0             |  0.0284 ns | 0.0529 ns | 0.0442 ns |  0.0132 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET 8.0             |  0.1140 ns | 0.0063 ns | 0.0038 ns |  0.1139 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET 8.0             |  0.0096 ns | 0.0170 ns | 0.0112 ns |  0.0030 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0003 ns | 0.0019 ns | 0.0010 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET 8.0             |  0.0164 ns | 0.0230 ns | 0.0192 ns |  0.0104 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0325 ns | 0.0243 ns | 0.0161 ns |  0.0364 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET 8.0             |  0.0030 ns | 0.0101 ns | 0.0089 ns |  0.0000 ns |     ? |       ? |
| ExtensionMethod_Double | .NET 8.0             |  1.4736 ns | 0.0955 ns | 0.0846 ns |  1.4456 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET 8.0             |  0.3444 ns | 0.0484 ns | 0.0429 ns |  0.3397 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET 8.0             |  1.3364 ns | 0.1081 ns | 0.1011 ns |  1.3044 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET 8.0             |  1.2653 ns | 0.0518 ns | 0.0460 ns |  1.2540 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET 8.0             |  0.3744 ns | 0.0409 ns | 0.0383 ns |  0.3786 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET 8.0             |  0.4133 ns | 0.0734 ns | 0.0686 ns |  0.4036 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET 8.0             |  0.2435 ns | 0.0715 ns | 0.0669 ns |  0.2698 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET 8.0             |  0.1422 ns | 0.0341 ns | 0.0302 ns |  0.1278 ns |     ? |       ? |
| ByteIndexer_Double     | .NET 8.0             |  1.5409 ns | 0.0553 ns | 0.0518 ns |  1.5332 ns |     ? |       ? |
| ByteIndexer_Float      | .NET 8.0             |  0.6462 ns | 0.0478 ns | 0.0447 ns |  0.6443 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET 8.0             |  1.3449 ns | 0.0511 ns | 0.0478 ns |  1.3280 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET 8.0             |  1.3702 ns | 0.0922 ns | 0.0863 ns |  1.3376 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET 8.0             |  0.4275 ns | 0.0360 ns | 0.0337 ns |  0.4286 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET 8.0             |  0.4467 ns | 0.0383 ns | 0.0320 ns |  0.4449 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET 8.0             |  0.1333 ns | 0.0418 ns | 0.0391 ns |  0.1241 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET 8.0             |  0.1623 ns | 0.0352 ns | 0.0329 ns |  0.1633 ns |     ? |       ? |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  2.7927 ns | 0.0794 ns | 0.0743 ns |  2.7876 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.1103 ns | 0.0649 ns | 0.0576 ns |  2.0980 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  2.9269 ns | 0.0651 ns | 0.0430 ns |  2.9127 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  1.5581 ns | 0.0127 ns | 0.0066 ns |  1.5578 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  1.7517 ns | 0.0241 ns | 0.0144 ns |  1.7462 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  0.8448 ns | 0.0370 ns | 0.0245 ns |  0.8430 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  2.9600 ns | 0.0459 ns | 0.0303 ns |  2.9617 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  1.0239 ns | 0.0325 ns | 0.0193 ns |  1.0317 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  3.1259 ns | 0.0782 ns | 0.0653 ns |  3.1156 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 11.3083 ns | 0.1847 ns | 0.1222 ns | 11.3354 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  2.7090 ns | 0.1157 ns | 0.1082 ns |  2.6749 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  2.6198 ns | 0.0654 ns | 0.0389 ns |  2.6255 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  1.1267 ns | 0.0321 ns | 0.0191 ns |  1.1209 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  1.1408 ns | 0.0494 ns | 0.0438 ns |  1.1400 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  0.9220 ns | 0.0319 ns | 0.0231 ns |  0.9171 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  0.9031 ns | 0.0285 ns | 0.0170 ns |  0.9062 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  3.0078 ns | 0.0454 ns | 0.0300 ns |  3.0017 ns |     ? |       ? |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 11.1807 ns | 0.2318 ns | 0.1810 ns | 11.1753 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  3.4995 ns | 0.0552 ns | 0.0365 ns |  3.5030 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  3.4022 ns | 0.0851 ns | 0.0664 ns |  3.3947 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  1.7954 ns | 0.0391 ns | 0.0259 ns |  1.7950 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  1.8153 ns | 0.0414 ns | 0.0216 ns |  1.8218 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  0.9185 ns | 0.0400 ns | 0.0289 ns |  0.9091 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  0.9667 ns | 0.0381 ns | 0.0276 ns |  0.9579 ns |     ? |       ? |

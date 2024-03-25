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

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0027 ns | 0.0055 ns | 0.0033 ns |  0.0010 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET 8.0             |  0.0043 ns | 0.0048 ns | 0.0032 ns |  0.0040 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET 8.0             |  0.1291 ns | 0.0084 ns | 0.0050 ns |  0.1299 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET 8.0             |  0.0012 ns | 0.0026 ns | 0.0017 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET 8.0             |  0.0073 ns | 0.0173 ns | 0.0091 ns |  0.0039 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0022 ns | 0.0036 ns | 0.0024 ns |  0.0017 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET 8.0             |  0.0057 ns | 0.0085 ns | 0.0051 ns |  0.0061 ns |     ? |       ? |
| ExtensionMethod_Double | .NET 8.0             |  3.8953 ns | 0.0439 ns | 0.0290 ns |  3.8970 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET 8.0             |  1.5888 ns | 0.0410 ns | 0.0271 ns |  1.5831 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET 8.0             |  3.2759 ns | 0.0395 ns | 0.0207 ns |  3.2784 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET 8.0             |  3.2750 ns | 0.0218 ns | 0.0130 ns |  3.2719 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET 8.0             |  2.3979 ns | 0.0219 ns | 0.0130 ns |  2.4007 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET 8.0             |  2.3178 ns | 0.0298 ns | 0.0197 ns |  2.3138 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET 8.0             |  1.1280 ns | 0.0109 ns | 0.0072 ns |  1.1271 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET 8.0             |  1.1421 ns | 0.0100 ns | 0.0066 ns |  1.1402 ns |     ? |       ? |
| ByteIndexer_Double     | .NET 8.0             |  3.4170 ns | 0.0404 ns | 0.0267 ns |  3.4144 ns |     ? |       ? |
| ByteIndexer_Float      | .NET 8.0             |  1.5766 ns | 0.0231 ns | 0.0153 ns |  1.5775 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET 8.0             |  3.8838 ns | 0.0321 ns | 0.0212 ns |  3.8877 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET 8.0             |  4.0241 ns | 0.0242 ns | 0.0144 ns |  4.0201 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET 8.0             |  2.3785 ns | 0.0235 ns | 0.0155 ns |  2.3778 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET 8.0             |  2.2549 ns | 0.0380 ns | 0.0252 ns |  2.2613 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET 8.0             |  1.1464 ns | 0.0264 ns | 0.0175 ns |  1.1443 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET 8.0             |  1.1294 ns | 0.0116 ns | 0.0076 ns |  1.1298 ns |     ? |       ? |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  2.7687 ns | 0.0717 ns | 0.0427 ns |  2.7685 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.2406 ns | 0.1053 ns | 0.0985 ns |  2.1946 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  2.9899 ns | 0.0375 ns | 0.0248 ns |  2.9861 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  1.5685 ns | 0.0188 ns | 0.0098 ns |  1.5706 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  1.8044 ns | 0.0248 ns | 0.0164 ns |  1.8082 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  0.8592 ns | 0.0143 ns | 0.0095 ns |  0.8576 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  2.9301 ns | 0.0403 ns | 0.0240 ns |  2.9234 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  1.0331 ns | 0.0137 ns | 0.0091 ns |  1.0308 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 |  6.5190 ns | 0.0496 ns | 0.0295 ns |  6.5283 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 12.0794 ns | 0.1237 ns | 0.0818 ns | 12.0737 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 |  5.6822 ns | 0.0314 ns | 0.0208 ns |  5.6798 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 |  5.6696 ns | 0.0433 ns | 0.0258 ns |  5.6733 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  2.7236 ns | 0.0333 ns | 0.0220 ns |  2.7255 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  2.7158 ns | 0.0221 ns | 0.0132 ns |  2.7179 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  1.2767 ns | 0.0319 ns | 0.0211 ns |  1.2709 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  1.3290 ns | 0.0255 ns | 0.0152 ns |  1.3318 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 |  6.4478 ns | 0.0340 ns | 0.0225 ns |  6.4437 ns |     ? |       ? |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 12.2510 ns | 0.2386 ns | 0.1578 ns | 12.1867 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 |  5.6710 ns | 0.0982 ns | 0.0650 ns |  5.6438 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 |  5.6446 ns | 0.0438 ns | 0.0290 ns |  5.6521 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  2.6812 ns | 0.0317 ns | 0.0209 ns |  2.6765 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  2.6871 ns | 0.0360 ns | 0.0238 ns |  2.6882 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  1.2153 ns | 0.0264 ns | 0.0174 ns |  1.2119 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  1.2706 ns | 0.0186 ns | 0.0123 ns |  1.2725 ns |     ? |       ? |

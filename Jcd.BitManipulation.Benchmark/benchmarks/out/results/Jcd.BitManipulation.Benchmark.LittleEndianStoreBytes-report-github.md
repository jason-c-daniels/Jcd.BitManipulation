```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-YATUCA : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-DNRXWD : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                 | Runtime              |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|------------------------|----------------------|-----------:|----------:|----------:|-----------:|------:|--------:|
| BitConverter_ToDouble  | .NET 8.0             |  0.0005 ns | 0.0023 ns | 0.0015 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET 8.0             |  0.0014 ns | 0.0038 ns | 0.0025 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET 8.0             |  0.1167 ns | 0.0203 ns | 0.0134 ns |  0.1160 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET 8.0             |  0.0348 ns | 0.0375 ns | 0.0313 ns |  0.0286 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET 8.0             |  0.0165 ns | 0.0250 ns | 0.0234 ns |  0.0026 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET 8.0             |  0.0135 ns | 0.0262 ns | 0.0232 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET 8.0             |  0.0134 ns | 0.0203 ns | 0.0190 ns |  0.0000 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET 8.0             |  0.0155 ns | 0.0224 ns | 0.0210 ns |  0.0036 ns |     ? |       ? |
| ExtensionMethod_Double | .NET 8.0             |  4.6999 ns | 0.1158 ns | 0.0837 ns |  4.7011 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET 8.0             |  7.4302 ns | 0.4642 ns | 0.4342 ns |  7.4782 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET 8.0             |  4.4730 ns | 0.0592 ns | 0.0392 ns |  4.4683 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET 8.0             |  4.5529 ns | 0.1129 ns | 0.0746 ns |  4.5242 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET 8.0             |  2.4585 ns | 0.1260 ns | 0.1178 ns |  2.4524 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET 8.0             |  2.9043 ns | 0.1007 ns | 0.0893 ns |  2.9102 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET 8.0             |  1.1738 ns | 0.0427 ns | 0.0282 ns |  1.1642 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET 8.0             |  0.9736 ns | 0.0437 ns | 0.0365 ns |  0.9679 ns |     ? |       ? |
| ByteIndexer_Double     | .NET 8.0             |  4.5244 ns | 0.0492 ns | 0.0325 ns |  4.5229 ns |     ? |       ? |
| ByteIndexer_Float      | .NET 8.0             |  5.8069 ns | 0.2032 ns | 0.1697 ns |  5.8029 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET 8.0             |  4.3231 ns | 0.0439 ns | 0.0261 ns |  4.3324 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET 8.0             |  4.3239 ns | 0.1178 ns | 0.0701 ns |  4.3125 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET 8.0             |  2.3482 ns | 0.0749 ns | 0.0664 ns |  2.3273 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET 8.0             |  2.4729 ns | 0.0686 ns | 0.0454 ns |  2.4808 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET 8.0             |  1.1161 ns | 0.0368 ns | 0.0243 ns |  1.1100 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET 8.0             |  1.0871 ns | 0.0472 ns | 0.0394 ns |  1.0709 ns |     ? |       ? |
| BitConverter_ToDouble  | .NET Framework 4.6.2 |  2.8100 ns | 0.0987 ns | 0.0923 ns |  2.8408 ns |     ? |       ? |
| BitConverter_ToFloat   | .NET Framework 4.6.2 |  2.3542 ns | 0.2498 ns | 0.2086 ns |  2.2867 ns |     ? |       ? |
| BitConverter_ToUInt64  | .NET Framework 4.6.2 |  2.9364 ns | 0.0639 ns | 0.0334 ns |  2.9468 ns |     ? |       ? |
| BitConverter_ToInt64   | .NET Framework 4.6.2 |  1.5280 ns | 0.0214 ns | 0.0141 ns |  1.5307 ns |     ? |       ? |
| BitConverter_ToUInt32  | .NET Framework 4.6.2 |  1.8304 ns | 0.0826 ns | 0.0690 ns |  1.8362 ns |     ? |       ? |
| BitConverter_ToInt32   | .NET Framework 4.6.2 |  0.9417 ns | 0.0948 ns | 0.0887 ns |  0.9152 ns |     ? |       ? |
| BitConverter_ToUInt16  | .NET Framework 4.6.2 |  3.0013 ns | 0.0932 ns | 0.0872 ns |  2.9838 ns |     ? |       ? |
| BitConverter_ToInt16   | .NET Framework 4.6.2 |  0.8702 ns | 0.0110 ns | 0.0065 ns |  0.8700 ns |     ? |       ? |
| ExtensionMethod_Double | .NET Framework 4.6.2 | 15.4831 ns | 0.4473 ns | 0.4184 ns | 15.3894 ns |     ? |       ? |
| ExtensionMethod_Float  | .NET Framework 4.6.2 | 16.9964 ns | 0.4099 ns | 0.3423 ns | 17.0283 ns |     ? |       ? |
| ExtensionMethod_UInt64 | .NET Framework 4.6.2 | 15.8075 ns | 0.5071 ns | 0.4495 ns | 15.7220 ns |     ? |       ? |
| ExtensionMethod_Int64  | .NET Framework 4.6.2 | 15.5640 ns | 0.4275 ns | 0.3789 ns | 15.5533 ns |     ? |       ? |
| ExtensionMethod_UInt32 | .NET Framework 4.6.2 |  7.6687 ns | 0.0842 ns | 0.0501 ns |  7.6672 ns |     ? |       ? |
| ExtensionMethod_Int32  | .NET Framework 4.6.2 |  7.9858 ns | 0.2293 ns | 0.2033 ns |  8.0152 ns |     ? |       ? |
| ExtensionMethod_UInt16 | .NET Framework 4.6.2 |  4.8067 ns | 0.1026 ns | 0.0537 ns |  4.7890 ns |     ? |       ? |
| ExtensionMethod_Int16  | .NET Framework 4.6.2 |  4.6209 ns | 0.2888 ns | 0.2560 ns |  4.5657 ns |     ? |       ? |
| ByteIndexer_Double     | .NET Framework 4.6.2 | 13.8273 ns | 0.5161 ns | 0.4575 ns | 13.9011 ns |     ? |       ? |
| ByteIndexer_Float      | .NET Framework 4.6.2 | 17.3719 ns | 0.9821 ns | 0.9186 ns | 17.2754 ns |     ? |       ? |
| ByteIndexer_UInt64     | .NET Framework 4.6.2 | 13.2752 ns | 0.3491 ns | 0.2916 ns | 13.3382 ns |     ? |       ? |
| ByteIndexer_Int64      | .NET Framework 4.6.2 | 14.2151 ns | 1.0927 ns | 0.9686 ns | 14.0068 ns |     ? |       ? |
| ByteIndexer_UInt32     | .NET Framework 4.6.2 |  6.8041 ns | 0.2769 ns | 0.2312 ns |  6.7766 ns |     ? |       ? |
| ByteIndexer_Int32      | .NET Framework 4.6.2 |  7.5930 ns | 0.6101 ns | 0.5707 ns |  7.5153 ns |     ? |       ? |
| ByteIndexer_UInt16     | .NET Framework 4.6.2 |  4.1048 ns | 0.1676 ns | 0.1399 ns |  4.1171 ns |     ? |       ? |
| ByteIndexer_Int16      | .NET Framework 4.6.2 |  4.3141 ns | 0.2982 ns | 0.2644 ns |  4.2496 ns |     ? |       ? |

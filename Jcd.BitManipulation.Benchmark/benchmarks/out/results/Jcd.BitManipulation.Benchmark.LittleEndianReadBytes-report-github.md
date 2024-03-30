```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-UWWGLV : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-IXAHBT : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=120.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```

| Method                                | Runtime              |     Mean |     Error |    StdDev | Ratio | RatioSD |
|---------------------------------------|----------------------|---------:|----------:|----------:|------:|--------:|
| BitConverter_GetBytes_Double          | .NET 8.0             | 3.302 ns | 0.1034 ns | 0.0747 ns |  0.93 |    0.02 |
| BitConverter_GetBytes_Float           | .NET 8.0             | 3.314 ns | 0.1035 ns | 0.0749 ns |  0.93 |    0.03 |
| BitConverter_GetBytes_UInt64          | .NET 8.0             | 3.053 ns | 0.1019 ns | 0.0795 ns |  0.86 |    0.03 |
| BitConverter_GetBytes_Int64           | .NET 8.0             | 3.096 ns | 0.0960 ns | 0.0694 ns |  0.87 |    0.02 |
| BitConverter_GetBytes_UInt32          | .NET 8.0             | 3.093 ns | 0.0923 ns | 0.0549 ns |  0.87 |    0.02 |
| BitConverter_GetBytes_Int32           | .NET 8.0             | 3.093 ns | 0.0811 ns | 0.0536 ns |  0.87 |    0.02 |
| BitConverter_GetBytes_UInt16          | .NET 8.0             | 3.078 ns | 0.1070 ns | 0.0949 ns |  0.87 |    0.04 |
| BitConverter_GetBytes_Int16           | .NET 8.0             | 3.007 ns | 0.0799 ns | 0.0418 ns |  0.85 |    0.01 |
| LittleEndianByteIndexer_Slice_Double  | .NET 8.0             | 3.668 ns | 0.1142 ns | 0.1069 ns |  1.05 |    0.03 |
| LittleEndianByteIndexer_Slice_Float   | .NET 8.0             | 3.280 ns | 0.1160 ns | 0.1028 ns |  0.93 |    0.04 |
| LittleEndianByteIndexer_Slice_UInt64  | .NET 8.0             | 3.549 ns | 0.1121 ns | 0.0667 ns |  1.00 |    0.00 |
| LittleEndianByteIndexer_Slice_Int64   | .NET 8.0             | 3.655 ns | 0.1122 ns | 0.0876 ns |  1.04 |    0.03 |
| LittleEndianByteIndexer_Slice_UInt32  | .NET 8.0             | 3.296 ns | 0.0666 ns | 0.0396 ns |  0.93 |    0.02 |
| LittleEndianByteIndexer_Slice_Int32   | .NET 8.0             | 3.285 ns | 0.1048 ns | 0.0758 ns |  0.92 |    0.03 |
| LittleEndianByteIndexer_Slice_UInt16  | .NET 8.0             | 3.270 ns | 0.1086 ns | 0.0718 ns |  0.92 |    0.03 |
| LittleEndianByteIndexer_Slice_Int16   | .NET 8.0             | 3.241 ns | 0.0998 ns | 0.0660 ns |  0.92 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET 8.0             | 3.565 ns | 0.1045 ns | 0.0755 ns |  1.00 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET 8.0             | 3.311 ns | 0.0816 ns | 0.0485 ns |  0.93 |    0.02 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET 8.0             | 3.567 ns | 0.1181 ns | 0.1047 ns |  1.01 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET 8.0             | 4.598 ns | 0.1332 ns | 0.1112 ns |  1.30 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET 8.0             | 3.362 ns | 0.1071 ns | 0.0894 ns |  0.95 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET 8.0             | 4.080 ns | 0.2206 ns | 0.2064 ns |  1.13 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET 8.0             | 3.277 ns | 0.1439 ns | 0.1346 ns |  0.92 |    0.05 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET 8.0             | 3.243 ns | 0.1103 ns | 0.1031 ns |  0.92 |    0.02 |
| BitConverter_GetBytes_Double          | .NET Framework 4.6.2 | 4.193 ns | 0.1267 ns | 0.1058 ns |  1.18 |    0.04 |
| BitConverter_GetBytes_Float           | .NET Framework 4.6.2 | 3.588 ns | 0.1003 ns | 0.0663 ns |  1.01 |    0.03 |
| BitConverter_GetBytes_UInt64          | .NET Framework 4.6.2 | 4.715 ns | 0.4804 ns | 0.4012 ns |  1.34 |    0.08 |
| BitConverter_GetBytes_Int64           | .NET Framework 4.6.2 | 4.233 ns | 0.1603 ns | 0.1499 ns |  1.18 |    0.04 |
| BitConverter_GetBytes_UInt32          | .NET Framework 4.6.2 | 3.769 ns | 0.1438 ns | 0.1275 ns |  1.05 |    0.04 |
| BitConverter_GetBytes_Int32           | .NET Framework 4.6.2 | 3.749 ns | 0.1243 ns | 0.1102 ns |  1.04 |    0.03 |
| BitConverter_GetBytes_UInt16          | .NET Framework 4.6.2 | 3.750 ns | 0.1079 ns | 0.0842 ns |  1.06 |    0.04 |
| BitConverter_GetBytes_Int16           | .NET Framework 4.6.2 | 3.845 ns | 0.1971 ns | 0.1747 ns |  1.05 |    0.03 |
| LittleEndianByteIndexer_Slice_Double  | .NET Framework 4.6.2 | 5.864 ns | 0.3999 ns | 0.3740 ns |  1.66 |    0.13 |
| LittleEndianByteIndexer_Slice_Float   | .NET Framework 4.6.2 | 8.431 ns | 0.3488 ns | 0.3092 ns |  2.41 |    0.13 |
| LittleEndianByteIndexer_Slice_UInt64  | .NET Framework 4.6.2 | 5.506 ns | 0.3253 ns | 0.3043 ns |  1.55 |    0.10 |
| LittleEndianByteIndexer_Slice_Int64   | .NET Framework 4.6.2 | 5.628 ns | 0.3655 ns | 0.3240 ns |  1.58 |    0.09 |
| LittleEndianByteIndexer_Slice_UInt32  | .NET Framework 4.6.2 | 4.587 ns | 0.1898 ns | 0.1775 ns |  1.29 |    0.05 |
| LittleEndianByteIndexer_Slice_Int32   | .NET Framework 4.6.2 | 4.510 ns | 0.0752 ns | 0.0447 ns |  1.27 |    0.03 |
| LittleEndianByteIndexer_Slice_UInt16  | .NET Framework 4.6.2 | 4.167 ns | 0.0782 ns | 0.0466 ns |  1.17 |    0.02 |
| LittleEndianByteIndexer_Slice_Int16   | .NET Framework 4.6.2 | 4.551 ns | 0.3941 ns | 0.3686 ns |  1.33 |    0.11 |
| ExtensionMethod_ReadBytes_On_A_Double | .NET Framework 4.6.2 | 5.766 ns | 0.3093 ns | 0.2742 ns |  1.63 |    0.07 |
| ExtensionMethod_ReadBytes_On_A_Float  | .NET Framework 4.6.2 | 8.322 ns | 0.1313 ns | 0.0869 ns |  2.35 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_UInt64 | .NET Framework 4.6.2 | 5.331 ns | 0.1439 ns | 0.0952 ns |  1.51 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_Int64  | .NET Framework 4.6.2 | 4.681 ns | 0.1379 ns | 0.0997 ns |  1.32 |    0.04 |
| ExtensionMethod_ReadBytes_On_A_UInt32 | .NET Framework 4.6.2 | 4.166 ns | 0.0812 ns | 0.0483 ns |  1.17 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_Int32  | .NET Framework 4.6.2 | 3.694 ns | 0.1156 ns | 0.0836 ns |  1.04 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_UInt16 | .NET Framework 4.6.2 | 3.863 ns | 0.1053 ns | 0.0879 ns |  1.09 |    0.03 |
| ExtensionMethod_ReadBytes_On_A_Int16  | .NET Framework 4.6.2 | 3.226 ns | 0.0944 ns | 0.0625 ns |  0.91 |    0.03 |

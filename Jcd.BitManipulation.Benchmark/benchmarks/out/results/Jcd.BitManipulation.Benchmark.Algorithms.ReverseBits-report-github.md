```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.4037/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.400
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  Job-PIGZZO : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  Job-KLDPFO : .NET Framework 4.8.1 (4.8.9261.0), X64 RyuJIT VectorSize=256

IterationTime=500.0000 ms  MaxIterationCount=15  MinIterationCount=10
WarmupCount=10

```
| Method    | Runtime              | b   | sb  | s     | us    | i          | ui         | l                   | ul                  | Mean      | Error     | StdDev    | Ratio | RatioSD |
|---------- |--------------------- |---- |---- |------ |------ |----------- |----------- |-------------------- |-------------------- |----------:|----------:|----------:|------:|--------:|
| **On_Byte**   | **.NET 8.0**             | **116** | **?**   | **?**     | **?**     | **?**          | **?**          | **?**                   | **?**                   | **0.2173 ns** | **0.0073 ns** | **0.0043 ns** |  **1.00** |    **0.00** |
| On_Byte   | .NET Framework 4.6.2 | 116 | ?   | ?     | ?     | ?          | ?          | ?                   | ?                   | 0.2187 ns | 0.0232 ns | 0.0153 ns |  1.00 |    0.07 |
|           |                      |     |     |       |       |            |            |                     |                     |           |           |           |       |         |
| **On_SByte**  | **.NET 8.0**             | **?**   | **116** | **?**     | **?**     | **?**          | **?**          | **?**                   | **?**                   | **0.2071 ns** | **0.0189 ns** | **0.0112 ns** |  **1.00** |    **0.00** |
| On_SByte  | .NET Framework 4.6.2 | ?   | 116 | ?     | ?     | ?          | ?          | ?                   | ?                   | 0.2121 ns | 0.0157 ns | 0.0094 ns |  1.03 |    0.06 |
|           |                      |     |     |       |       |            |            |                     |                     |           |           |           |       |         |
| **On_Byte**   | **.NET 8.0**             | **117** | **?**   | **?**     | **?**     | **?**          | **?**          | **?**                   | **?**                   | **0.2218 ns** | **0.0174 ns** | **0.0104 ns** |  **1.00** |    **0.00** |
| On_Byte   | .NET Framework 4.6.2 | 117 | ?   | ?     | ?     | ?          | ?          | ?                   | ?                   | 0.2571 ns | 0.0615 ns | 0.0576 ns |  1.05 |    0.23 |
|           |                      |     |     |       |       |            |            |                     |                     |           |           |           |       |         |
| **On_SByte**  | **.NET 8.0**             | **?**   | **117** | **?**     | **?**     | **?**          | **?**          | **?**                   | **?**                   | **0.2125 ns** | **0.0344 ns** | **0.0228 ns** |  **1.00** |    **0.00** |
| On_SByte  | .NET Framework 4.6.2 | ?   | 117 | ?     | ?     | ?          | ?          | ?                   | ?                   | 0.2619 ns | 0.0473 ns | 0.0443 ns |  1.27 |    0.30 |
|           |                      |     |     |       |       |            |            |                     |                     |           |           |           |       |         |
| **On_Int16**  | **.NET 8.0**             | **?**   | **?**   | **29812** | **?**     | **?**          | **?**          | **?**                   | **?**                   | **0.4665 ns** | **0.0379 ns** | **0.0274 ns** |  **1.00** |    **0.00** |
| On_Int16  | .NET Framework 4.6.2 | ?   | ?   | 29812 | ?     | ?          | ?          | ?                   | ?                   | 0.4388 ns | 0.0289 ns | 0.0191 ns |  0.94 |    0.08 |
|           |                      |     |     |       |       |            |            |                     |                     |           |           |           |       |         |
| **On_UInt16** | **.NET 8.0**             | **?**   | **?**   | **?**     | **29812** | **?**          | **?**          | **?**                   | **?**                   | **0.2151 ns** | **0.0155 ns** | **0.0092 ns** |  **1.00** |    **0.00** |
| On_UInt16 | .NET Framework 4.6.2 | ?   | ?   | ?     | 29812 | ?          | ?          | ?                   | ?                   | 0.4456 ns | 0.0183 ns | 0.0096 ns |  2.09 |    0.10 |
|           |                      |     |     |       |       |            |            |                     |                     |           |           |           |       |         |
| **On_Int16**  | **.NET 8.0**             | **?**   | **?**   | **30069** | **?**     | **?**          | **?**          | **?**                   | **?**                   | **0.4592 ns** | **0.0261 ns** | **0.0155 ns** |  **1.00** |    **0.00** |
| On_Int16  | .NET Framework 4.6.2 | ?   | ?   | 30069 | ?     | ?          | ?          | ?                   | ?                   | 0.4251 ns | 0.0314 ns | 0.0208 ns |  0.92 |    0.07 |
|           |                      |     |     |       |       |            |            |                     |                     |           |           |           |       |         |
| **On_UInt16** | **.NET 8.0**             | **?**   | **?**   | **?**     | **30069** | **?**          | **?**          | **?**                   | **?**                   | **0.2374 ns** | **0.0333 ns** | **0.0220 ns** |  **1.00** |    **0.00** |
| On_UInt16 | .NET Framework 4.6.2 | ?   | ?   | ?     | 30069 | ?          | ?          | ?                   | ?                   | 0.4362 ns | 0.0313 ns | 0.0207 ns |  1.85 |    0.22 |
|           |                      |     |     |       |       |            |            |                     |                     |           |           |           |       |         |
| **On_Int32**  | **.NET 8.0**             | **?**   | **?**   | **?**     | **?**     | **1953789044** | **?**          | **?**                   | **?**                   | **0.6821 ns** | **0.0308 ns** | **0.0204 ns** |  **1.00** |    **0.00** |
| On_Int32  | .NET Framework 4.6.2 | ?   | ?   | ?     | ?     | 1953789044 | ?          | ?                   | ?                   | 0.9977 ns | 0.0360 ns | 0.0238 ns |  1.46 |    0.05 |
|           |                      |     |     |       |       |            |            |                     |                     |           |           |           |       |         |
| **On_UInt32** | **.NET 8.0**             | **?**   | **?**   | **?**     | **?**     | **?**          | **1953789044** | **?**                   | **?**                   | **0.6799 ns** | **0.0081 ns** | **0.0043 ns** |  **1.00** |    **0.00** |
| On_UInt32 | .NET Framework 4.6.2 | ?   | ?   | ?     | ?     | ?          | 1953789044 | ?                   | ?                   | 1.0253 ns | 0.0481 ns | 0.0402 ns |  1.52 |    0.06 |
|           |                      |     |     |       |       |            |            |                     |                     |           |           |           |       |         |
| **On_Int32**  | **.NET 8.0**             | **?**   | **?**   | **?**     | **?**     | **1970632053** | **?**          | **?**                   | **?**                   | **0.6972 ns** | **0.0398 ns** | **0.0263 ns** |  **1.00** |    **0.00** |
| On_Int32  | .NET Framework 4.6.2 | ?   | ?   | ?     | ?     | 1970632053 | ?          | ?                   | ?                   | 0.9962 ns | 0.0115 ns | 0.0060 ns |  1.44 |    0.06 |
|           |                      |     |     |       |       |            |            |                     |                     |           |           |           |       |         |
| **On_UInt32** | **.NET 8.0**             | **?**   | **?**   | **?**     | **?**     | **?**          | **1970632053** | **?**                   | **?**                   | **0.6912 ns** | **0.0173 ns** | **0.0114 ns** |  **1.00** |    **0.00** |
| On_UInt32 | .NET Framework 4.6.2 | ?   | ?   | ?     | ?     | ?          | 1970632053 | ?                   | ?                   | 1.0010 ns | 0.0357 ns | 0.0236 ns |  1.45 |    0.04 |
|           |                      |     |     |       |       |            |            |                     |                     |           |           |           |       |         |
| **On_Int64**  | **.NET 8.0**             | **?**   | **?**   | **?**     | **?**     | **?**          | **?**          | **8391460049216894068** | **?**                   | **3.1610 ns** | **0.0572 ns** | **0.0378 ns** |  **1.00** |    **0.00** |
| On_Int64  | .NET Framework 4.6.2 | ?   | ?   | ?     | ?     | ?          | ?          | 8391460049216894068 | ?                   | 4.0012 ns | 0.0688 ns | 0.0455 ns |  1.27 |    0.02 |
|           |                      |     |     |       |       |            |            |                     |                     |           |           |           |       |         |
| **On_UInt64** | **.NET 8.0**             | **?**   | **?**   | **?**     | **?**     | **?**          | **?**          | **?**                   | **8391460049216894068** | **3.1461 ns** | **0.0375 ns** | **0.0223 ns** |  **1.00** |    **0.00** |
| On_UInt64 | .NET Framework 4.6.2 | ?   | ?   | ?     | ?     | ?          | ?          | ?                   | 8391460049216894068 | 4.0136 ns | 0.0415 ns | 0.0217 ns |  1.28 |    0.01 |
|           |                      |     |     |       |       |            |            |                     |                     |           |           |           |       |         |
| **On_Int64**  | **.NET 8.0**             | **?**   | **?**   | **?**     | **?**     | **?**          | **?**          | **8463800222054970741** | **?**                   | **3.1262 ns** | **0.0403 ns** | **0.0240 ns** |  **1.00** |    **0.00** |
| On_Int64  | .NET Framework 4.6.2 | ?   | ?   | ?     | ?     | ?          | ?          | 8463800222054970741 | ?                   | 4.0381 ns | 0.0731 ns | 0.0483 ns |  1.29 |    0.02 |
|           |                      |     |     |       |       |            |            |                     |                     |           |           |           |       |         |
| **On_UInt64** | **.NET 8.0**             | **?**   | **?**   | **?**     | **?**     | **?**          | **?**          | **?**                   | **8463800222054970741** | **3.2217 ns** | **0.0950 ns** | **0.0566 ns** |  **1.00** |    **0.00** |
| On_UInt64 | .NET Framework 4.6.2 | ?   | ?   | ?     | ?     | ?          | ?          | ?                   | 8463800222054970741 | 4.1375 ns | 0.1086 ns | 0.0718 ns |  1.29 |    0.04 |
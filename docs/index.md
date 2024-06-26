# Jcd.BitManipulation

A bit manipulation readability enhancement library.

[![GitHub](https://img.shields.io/github/license/jason-c-daniels/Jcd.BitManipulation)](https://github.com/jason-c-daniels/Jcd.BitManipulation/blob/main/LICENSE)
[![MyGet](https://img.shields.io/myget/jason-c-daniels/v/Jcd.BitManipulation?logo=nuget)](https://www.myget.org/feed/jason-c-daniels/package/nuget/Jcd.BitManipulation)
[![Nuget](https://img.shields.io/nuget/v/Jcd.BitManipulation?logo=nuget)](https://www.nuget.org/packages/Jcd.BitManipulation)

## Examples

```csharp
ushort data = 0b0000000000000000;

// turn on all the bits
data = data.SetBits(0, 16); // value is now 0b1111111111111111

// this is the equivalent as above
data = data.SetBits();

// Clear the middle 4 bits.
data = data.ClearBits(4, 8); // value is now 0b1111000000001111

// Toggle all the bits.
data = data.ToggleBits(); // value is now 0b0000111111110000

var finalData = data;
// read the upper byte
var upperByte = (byte) data.ReadBits(8, 8); // upperByte is now 0b00001111

// write 0b1011 into the upper nybble
upperByte = upperByte.StoreBits(0b1011, 4, 4); // upperByte is now 0b10111111

// chaining operations, the same steps and end results
data.ClearBits();
data = data.SetBits(0, 16)  // value is now 0b1111111111111111
           .SetBits()       // this is the equivalent as above
           .ClearBits(4, 8) // value is now 0b1111000000001111
           .ToggleBits();   // value is now 0b0000111111110000

upperByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
  .StoreBits(0b1011, 4, 4);              // store the value in the upper 4 bits, now upperByte is now 0b10111111

// finalData 0b0000111111110000
var beByte0     = finalData.ReadByte(0, Endian.Big);              // 00001111
var leByte0     = finalData.ReadByte(0, Endian.Little);           // 11110000

var mutatedData = finalData
                 .StoreByte(0b10111111, 0, Endian.Big)
                 .StoreByte(0b01010101, 0, Endian.Little ); // lower byte is now 0b01010101
;                                                           // mutatedData is now 0b1011111101010101

var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b01010101]

var leBa = mutatedData.ToByteArray(Endian.Little); // leBa=[0b01010101, 0b10111111]

var leBaToUInt16Le = leBa.ToUInt16(Endian.Little); // leBaToUInt16Le = 0b1011111101010101

var leBaToUInt16Be = leBa.ToUInt16(Endian.Big); // leBaToUInt16Le = 0b0101010110111111
```

### Performance Notes

If you read the code you'll notice a fair number of abstractions and helper structs in use.
These don't have a significant impact on release mode performance.

To see how it performs on your system run the code in the Main function of the examples app or
run the performance benchmarks using the bash script `run-benchmarks`. By default it'll try to
run .Net Framework 4.6.2 in addition to .Net 8.0. Just edit the script to exclude .Net Framework
if your system doesn't have it installed.

The latest performance benchmarks from my machine are available at the links below:

* [BigEndianReadBytes](https://github.com/jason-c-daniels/Jcd.BitManipulation/tree/main/Jcd.BitManipulation.Benchmark/benchmarks/out/results/Jcd.BitManipulation.Benchmark.BigEndianReadBytes-report-github.md) -- Extracts bytes from various integer and floating point types as a big endian array.
* [LittleEndianReadBytes](https://github.com/jason-c-daniels/Jcd.BitManipulation/tree/main/Jcd.BitManipulation.Benchmark/benchmarks/out/results/Jcd.BitManipulation.Benchmark.LittleEndianReadBytes-report-github.md) -- Extracts bytes from various integer and floating point types as a little endian array.
* [BigEndianStoreByte](https://github.com/jason-c-daniels/Jcd.BitManipulation/tree/main/Jcd.BitManipulation.Benchmark/benchmarks/out/results/Jcd.BitManipulation.Benchmark.BigEndianStoreByte-report-github.md) -- Stores a single byte in various numeric types at an index using big endian indexing.
* [LittleEndianStoreByte](https://github.com/jason-c-daniels/Jcd.BitManipulation/tree/main/Jcd.BitManipulation.Benchmark/benchmarks/out/results/Jcd.BitManipulation.Benchmark.LittleEndianStoreByte-report-github.md) -- Stores a single byte in various numeric type at an index using little endian indexing.
* [BigEndianStoreBytes](https://github.com/jason-c-daniels/Jcd.BitManipulation/tree/main/Jcd.BitManipulation.Benchmark/benchmarks/out/results/Jcd.BitManipulation.Benchmark.BigEndianStoreBytes-report-github.md) -- Stores a collection of bytes in various numeric types, indexing into the numeric type's location as if the memory layout were big endian. (i.e. index 0 in the collection is the most significant byte)
* [LittleEndianStoreBytes](https://github.com/jason-c-daniels/Jcd.BitManipulation/tree/main/Jcd.BitManipulation.Benchmark/benchmarks/out/results/Jcd.BitManipulation.Benchmark.LittleEndianStoreBytes-report-github.md) -- Stores a collection of bytes in various numeric types, indexing into the numeric type's location as if the memory layout were little endian. (i.e. index 0 in the collection is the least significant byte)

## Version History

See [Release Notes](https://github.com/jason-c-daniels/Jcd.BitManipulation/tree/main/RELEASE_NOTES.md)

## Dev Notes

1. v3.1.x-alpha development is now happening in the `main` branch.
   A release branch will be created once its ready to be released.

2. v3.0.x release bug fixes are now happening in the `release/3.0` branch.

3. v2.4.x development has ceased and the branch will be protected.

## Build and Status

[![Build status](https://ci.appveyor.com/api/projects/status/98xuytl8nl7rns7m?svg=true)](https://ci.appveyor.com/project/jason-c-daniels/jcd-bitmanipulation)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=jason-c-daniels_Jcd.BitManipulation&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=jason-c-daniels_Jcd.BitManipulation)

### Statistics

[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=jason-c-daniels_Jcd.BitManipulation&metric=vulnerabilities)](https://sonarcloud.io/summary/new_code?id=jason-c-daniels_Jcd.BitManipulation)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=jason-c-daniels_Jcd.BitManipulation&metric=bugs)](https://sonarcloud.io/summary/new_code?id=jason-c-daniels_Jcd.BitManipulation)
[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=jason-c-daniels_Jcd.BitManipulation&metric=code_smells)](https://sonarcloud.io/summary/new_code?id=jason-c-daniels_Jcd.BitManipulation)
[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=jason-c-daniels_Jcd.BitManipulation&metric=sqale_index)](https://sonarcloud.io/summary/new_code?id=jason-c-daniels_Jcd.BitManipulation)

[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=jason-c-daniels_Jcd.BitManipulation&metric=coverage)](https://sonarcloud.io/summary/new_code?id=jason-c-daniels_Jcd.BitManipulation)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=jason-c-daniels_Jcd.BitManipulation&metric=ncloc)](https://sonarcloud.io/summary/new_code?id=jason-c-daniels_Jcd.BitManipulation)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=jason-c-daniels_Jcd.BitManipulation&metric=duplicated_lines_density)](https://sonarcloud.io/summary/new_code?id=jason-c-daniels_Jcd.BitManipulation)

### Ratings

[![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/jason-c-daniels/Jcd.BitManipulation)](https://www.codefactor.io/repository/github/jason-c-daniels/jcd.bitmanipulation)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=jason-c-daniels_Jcd.BitManipulation&metric=reliability_rating)](https://sonarcloud.io/summary/new_code?id=jason-c-daniels_Jcd.BitManipulation)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=jason-c-daniels_Jcd.BitManipulation&metric=security_rating)](https://sonarcloud.io/summary/new_code?id=jason-c-daniels_Jcd.BitManipulation)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=jason-c-daniels_Jcd.BitManipulation&metric=sqale_rating)](https://sonarcloud.io/summary/new_code?id=jason-c-daniels_Jcd.BitManipulation)

## Documentation

[![Project Website](https://img.shields.io/badge/Visit-The%20Project%20Website-green?style=for-the-badge)](https://jason-c-daniels.github.io/Jcd.BitManipulation)
[![API Docs](https://img.shields.io/badge/Read-The%20API%20Documentation-blue?style=for-the-badge)](https://jason-c-daniels.github.io/Jcd.BitManipulation/api)

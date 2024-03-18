# Jcd.BitManipulation

A .Net Standard 2.0 library adding syntactic sugar to your bit manipulation experience.

### Performance Notes

If you read the code you'll notice a fair number of abstractions at play. These don't have a
significant impact on release mode performance. In fact running on at roughly 3.5GHz to 3.8Ghz
(my CPU auto-scales performance based on load.) doing the 6 chained operations at the end of
the example below, but on the loop index instead of just zero, 10+e9 times completes in roughly
830-890ms in Release mode. 10+e6 iterations in debug mode completes in roughly 50-65ms.

To see how it performs on your system run the code in the Main function of the examples app.

```text
Debug mode run:
1,000,000 iterations with 6 operations per iteration took 51.34 ms for an average of 8.56e-006 ms per operation.

Release mode run:
1,000,000,000 iterations with 6 operations per iteration took 868.58 ms for an average of 1.45e-007 ms per operation.
```

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
;                                                                // mutatedData is now 0b1011111101010101

var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b01010101]

var leBa = mutatedData.ToByteArray(Endian.Little); // leBa=[0b01010101, 0b10111111]

var leBaToUInt16Le = leBa.ToUInt16(Endian.Little); // leBaToUInt16Le = 0b1011111101010101

var leBaToUInt16Be = leBa.ToUInt16(Endian.Big); // leBaToUInt16Le = 0b0101010110111111
```

## Change Log

### Version 2.3 Released

1. Added an Endian parameter to `StoreByte`.
2. Improved efficiency of `ReadByte` calls.
3. Fixed numerous copy and paste errors in the documentation.
4. Added examples of using `StoreByte` and `ToByteArray`.

### Version 2.2 Released

1. Added `AreAnyBitsSet` extensions methods for all intrinsic integer types.
2. Added `AreAllBitsSet` extensions methods for all intrinsic integer types.
3. Added `AreNoBitsSet` extensions methods for all intrinsic integer types.

### Version 2.1 Released

1. Added `GetBytes` and `GetByte` extension methods for intrinsic data types.
2. Added `StoreBytes` and `StoreByte` extension methods for intrinsic data types.
3. Added `LittleEndianXXXByteIndexer` classes.
4. Added `BigEndianXXXByteIndexer` classes.

### Version 2.0 Released

#### Breaking Changes from v1.x

1. Renamed `BitMask.CreateRange` to `BitMask.FromRange`.
2. Renamed `BitMask.CreateSingleBit` to `BitMask.FromSingleBit`.
3. All `StoreBit` overloads had bit and offset parameters swapped for semantic parity with `StoreBits`
4. Extension methods: `ClearBits`, `SetBits`, `StoreBits`, `ToggleBits`, `ClearBit`, `SetBit`, `StoreBit`,
   and `ToggleBit` no longer take `ref` parameters. Now they return the modified result instead of modifying
   the original variable. This gives a net benefit of being able to use fluent syntax to chain together
   bit manipulation operations.

## Build, Code Stats and Nuget

[![GitHub](https://img.shields.io/github/license/jason-c-daniels/Jcd.BitManipulation)](https://github.com/jason-c-daniels/Jcd.BitManipulation/blob/main/LICENSE)
[![Build status](https://ci.appveyor.com/api/projects/status/98xuytl8nl7rns7m?svg=true)](https://ci.appveyor.com/project/jason-c-daniels/jcd-bitmanipulation)
[![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/jason-c-daniels/Jcd.BitManipulation)](https://www.codefactor.io/repository/github/jason-c-daniels/jcd.bitmanipulation)

[![MyGet](https://img.shields.io/myget/jason-c-daniels/v/Jcd.BitManipulation?logo=nuget)](https://www.myget.org/feed/jason-c-daniels/package/nuget/Jcd.BitManipulation)
[![Nuget](https://img.shields.io/nuget/v/Jcd.BitManipulation?logo=nuget)](https://www.nuget.org/packages/Jcd.BitManipulation)

## API Documentation

[![API Docs](https://img.shields.io/badge/Read-The%20API%20Documentation-blue?style=for-the-badge)](https://github.com/jason-c-daniels/Jcd.BitManipulation/blob/main/docs/Jcd.BitManipulation.md)

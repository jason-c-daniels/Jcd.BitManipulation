# Jcd.BitManipulation

A .Net Standard 2.0 library adding syntactic sugar to your bit manipulation experience.

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

If you read the code you'll notice a fair number of abstractions at play. These don't have a
significant impact on release mode performance. In fact running on at roughly 3.5GHz to 4.0Ghz
(my CPU auto-scales performance based on load.) doing the 6 chained operations at the end of
the example below, but on the loop index instead of just zero, 10+e9 times completes in roughly
830-890ms in Release mode.

To see how it performs on your system run the code in the Main function of the examples app.

```text
1,000,000,000 iterations with 6 operations per iteration took 868.58 ms for an average of 14.5 ns per operation.
```

Even more extensive performance testing is underway with version 3.0. Read below for details.

## Upcoming Changes

### 2.x Summary

- In the rush to get 2.x out the door I missed including Endianness with some of the extension methods
  and related unit tests. I've found a number of these in my work on 3.0. Many of these fixes and improvements
  have already been back ported to 2.x from 3.0. Others will follow as I find them and will be released in
  2.x well ahead of the 3.0 release.

  _You have my sincerest apologies for these oversights._

### 3.0 Summary

As you've guessed, I'm actively working on v3.0. Some big changes will hit with that release. If you have
any wants from this library please add an issue with your request.

The biggest changes are focused on completeness, simplifying the API surface/reducing volume of code, and
and keeping acceptable performance<sup>1</sup>.

Below is are list of currently planned changes.

1. One notable exception is a known performance hit caused by simplifying the API surface. It's described in detail
   below.

### 3.0 Planned breaking changes

- I've found myself strongly disliking the proliferation of types. All of the type specific `BitIndexer` and
  `ByteIndexer` types will be replaced with four types: `BigEndianByteIndexer`, `LittleEndianByteIndexer`,
  `BigEndianBitIndexer`, `LittleEndianBitIndexer`.
- The old indexer types will be deprecated in an upcoming release of 2.x, shortly before 3.0 is released. If you're
  using them keep in mind that you will need to change over. Consider scoping out the change once the first
  prerelease of 3.0 is published.
- The `IByteIndexer` and `IBitIndexer` interfaces will go away. I'm not using them internally and using them causes
  boxing allocations. Frequent boxing allocations can consume a lot of heap memory. The intended use case for the
  indexers was at the point where bit/byte level access is **required** (i.e. stack allocated).
- For the same reasons as above none of the indexer types will derive from IEnumerable. Instead explicit
  conversion operators will be provided to and from `Span`s and `Array`s.
- To the end of enforcing the indexers stack allocated and used in place, the bit and byte indexer types will become
  `ref structs`. This carries some implications such as making them non-viable as fields and async return types.
  That's in keeping with the original intent and a desirable change, from my view. If you need them to remain
  heap allocatable, add an issue or open a dialog with me about your needs.

### 3.0 New Features / Improvements

- Byte and bit level indexing of IEEE.754 floating point types: `double` and `float` will be directly provided in 3.0.
  This is currently possible if one first uses BitConverter to convert to the same sized integer type.
  The support for these types will be much more comprehensive than that in 2.0. (e.g. `.SetBits(this float,...)` will
  return a `float` with the specified bits altered)
- Performance improvements via `AggressiveInlining`. In many places in 1.x and 2.x, `AggressiveInlining` is missing.
  Using this consistently has halved and quartered the run time of some of the extension methods in the 3.0 branch.
- Performance benchmarks! I will include both the most recent performance benchmark runs as well as the benchmark
  application in 3.0. In running this I confirmed that the slight performance boost I got going with the
  type specific byte indexers, was not worth the hassle of the volume of code it requires for a .Net standard 2.0
  library. To illustrate (in the 3.0 branch, using my machine):
   - Using `BitConverter` to create an array from any int of any size and reverse the array (big endian on Intel
     processors) is 4ns on .Net 8.0 and 25ns in .Net Framework 4.8.1.
   - Using `BigEndianByteIndexerUInt64` takes rougly 6ns on both .Net 8.0 and 10ns on .Net Framework 4.8.1,
   - Using `BigEndianByteIndexerUInt16` takes roughly 3ns on both .Net 8.0 and 10ns on .Net Framework 4.8.1,
   - The replacement indexers need more logic as they are handling multiple bit sizes. `BigEndianByteIndexer` runs at
     roughly 8ns per conversion of the `UInt64` to an array of bytes.
   - This loss of performance to accomodate easier to maintain code is acceptable for two reasons:
      - In the worst case there's 6ns difference from `BitConverter`, and 5ns from the baseline implementation. 8ns per
        operation at 4GHz is still sufficiently fast for most purposes.
      - The target audience for this library are people who want more readable code. This sometimes comes at a slight
        performance hit. I believe a loss of performance of 6ns per conversion to a big endian array on an Intel
        processor
        is performant enough for the target audience.
      - If you really need as fast of performance as possible in converting integer to and from arrays, you may need to
        roll your own solution tailored to the hardware you're running on. Even `BitConverter` can be less performant
        than
        hand-rolled solutions for 16 bit integers on my machine.
- Improved documentation. I will improve the documentation on how to properly use the extension methods as well
  as their underlying types. One area currently lacking is on how to expect a big endian conversion from a
  a byte array to behave when the array is smaller than the destination type. (fills from position 0)
- ReSharper auto-formatting updates. Some of the code just looks silly with the settings used in 2.x (main) branch. I
  will update these settings to remove that odd formatting. (This mostly impacts data driven unit tests making it harder
  than necessary to comprehend what's happening)

### 3.0 Tentative Feature/Addition

- I will investigate .Net 7.0 generic math as a possible way of providing a truly generic implementation.
  (i.e. BigEndianByteIndexer<int> for example.) If this approach proves performant enough, I'll create a
  .net 7.0 version of this library with that support built in. The .Net Standard 2.0 compatible indexers will
  still be provided.

## Change Log

### Version 2.4 Released

1. Added `ReadByte` extension methods for `IByteIndexer` derived types.
2. Added `AggressiveInlining` hints to help boost performance.

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

# Change Log

## Version 3.0.121 Released

The biggest changes for 3.0 were focused on completeness, simplifying the API surface/reducing volume of code, and
and improving performance. This has introduced a number of breaking changes from 2.x.

### Breaking Changes

- All of the type specific `ByteIndexer` types will were replaced by `BigEndianByteIndexer` and `LittleEndianByteIndexer`.
  Early previews of both have been backported to 2.4.33 and you should perform your migration to these using that version.
- The same is true of the type specific `BitIndexer` types (e.g. `BitIndexerUInt64`). These were all replaced with
  the `BitIndexer` struct.
- The `IByteIndexer` and `IBitIndexer` interfaces were eliminated.
- `BigEndianByteIndexer`, `LittleEndianByteIndexer`, and `BitIndexer` are `ref structs`.
- All extension methods were moved into type-specific extesion classes (e.g. `UInt64Extensions`). This breaks
  direct calls such as `ReadBytesExtensions.ReadBytes(myInt,offset,length,Endian.Big)`.
- Various parameters were renamed for consistency sake. This breaks named parameters.

### New Features / Improvements

- `new` **BitManipulations of floating point types**. Byte and bit level indexing `Double` and `float` are directly
  provided in 3.0.
- `new` **Performance benchmarks!**. The `Jcd.BitManipulation.Benchmark` project has the most recent benchmark runs.
- `new` **Various common bit manipulation algorithms** These live in the `Jcd.BitManipulation.Algorithms` namespace.
- **Performance improvements** via `AggressiveInlining` and targeted code changes. 
- **Improved documentation**. See the github pages site: https://jason-c-daniels.github.io/Jcd.BitManipulation 
- **ReSharper auto-formatting updates**. These give more consistency to code formatting. This only impacts those who 
    read the code.

## Version 2.4.33 Released

1. Backported `BitIndexer`,`BigEndianByteIdexer` and `LittleEndianByteIndexer`
2. Added the `ObsoleteAttribute` to impacted types, properties and methods with instructions on how to proceed.

## Version 2.4 Released

1. Added `ReadByte` extension methods for `IByteIndexer` derived types.
2. Updated all `Slice` methods to prevent possible array index out of bounds.
3. Added `AggressiveInlining` hints to help boost performance.

## Version 2.3 Released

1. Added an Endian parameter to `StoreByte`.
2. Improved efficiency of `ReadByte` calls.
3. Fixed numerous copy and paste errors in the documentation.
4. Added examples of using `StoreByte` and `ToByteArray`.

## Version 2.2 Released

1. Added `AreAnyBitsSet` extensions methods for all intrinsic integer types.
2. Added `AreAllBitsSet` extensions methods for all intrinsic integer types.
3. Added `AreNoBitsSet` extensions methods for all intrinsic integer types.

## Version 2.1 Released

1. Added `GetBytes` and `GetByte` extension methods for intrinsic data types.
2. Added `StoreBytes` and `StoreByte` extension methods for intrinsic data types.
3. Added `LittleEndianXXXByteIndexer` classes.
4. Added `BigEndianXXXByteIndexer` classes.

## Version 2.0 Released

### Breaking Changes from v1.x

1. Renamed `BitMask.CreateRange` to `BitMask.FromRange`.
2. Renamed `BitMask.CreateSingleBit` to `BitMask.FromSingleBit`.
3. All `StoreBit` overloads had bit and offset parameters swapped for semantic parity with `StoreBits`
4. Extension methods: `ClearBits`, `SetBits`, `StoreBits`, `ToggleBits`, `ClearBit`, `SetBit`, `StoreBit`,
   and `ToggleBit` no longer take `ref` parameters. Now they return the modified result instead of modifying
   the original variable. This gives a net benefit of being able to use fluent syntax to chain together
   bit manipulation operations.

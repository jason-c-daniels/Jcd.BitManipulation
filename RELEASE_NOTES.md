# Change Log

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

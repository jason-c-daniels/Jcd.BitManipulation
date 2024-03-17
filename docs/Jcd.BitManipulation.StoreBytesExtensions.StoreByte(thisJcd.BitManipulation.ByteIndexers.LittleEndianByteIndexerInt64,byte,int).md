﻿#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[StoreBytesExtensions](Jcd.BitManipulation.StoreBytesExtensions.md 'Jcd.BitManipulation.StoreBytesExtensions')

## StoreBytesExtensions.StoreByte(this LittleEndianByteIndexerInt64, byte, int) Method

Store a single byte to the value at the specified byte offset.
Byte indexing is LSB, least significant byte, at index/offset zero.

```csharp
public static Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64 StoreByte(this Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64 value, byte @byte, int offset);
```

#### Parameters

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreByte(thisJcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64,byte,int).value'></a>

`value` [LittleEndianByteIndexerInt64](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64')

The value to be modified.

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreByte(thisJcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64,byte,int).byte'></a>

`byte` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The byte value to set

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreByte(thisJcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64,byte,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the offset of the byte to write

#### Returns

[LittleEndianByteIndexerInt64](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerInt64')
The modified value.
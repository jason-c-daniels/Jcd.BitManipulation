#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[LittleEndianByteIndexerUInt32](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32')

## LittleEndianByteIndexerUInt32.implicit operator uint(LittleEndianByteIndexerUInt32) Operator

Converts the [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') indexer to its
underlying data type.

```csharp
public static uint implicit operator uint(Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32 buffer);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.op_Implicituint(Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32).buffer'></a>

`buffer` [LittleEndianByteIndexerUInt32](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerUInt32')

The buffer to convert.

#### Returns

[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
The raw data.
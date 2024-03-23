#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[LittleEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer')

## LittleEndianByteIndexer.explicit operator byte[](LittleEndianByteIndexer) Operator

Explicitly converts the [LittleEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer') to an array of bytes.

```csharp
public static byte[] explicit operator byte[](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer indexer);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer.op_Explicitbyte[](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer).indexer'></a>

`indexer` [LittleEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer')

The indexer to convert.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
The raw data converted to an array, serialized as big endian.
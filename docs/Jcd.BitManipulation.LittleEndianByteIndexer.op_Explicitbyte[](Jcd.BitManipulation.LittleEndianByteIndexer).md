### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer')

## LittleEndianByteIndexer.explicit operator byte[](LittleEndianByteIndexer) Operator

Explicitly converts
the [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer')
to an array of bytes.

```csharp
public static byte[] explicit operator byte[](Jcd.BitManipulation.LittleEndianByteIndexer indexer);
```
#### Parameters

<a name='Jcd.BitManipulation.LittleEndianByteIndexer.op_Explicitbyte[](Jcd.BitManipulation.LittleEndianByteIndexer).indexer'></a>

`indexer` [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer')

The indexer to convert.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
The raw data converted to an array, serialized as big endian.
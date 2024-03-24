#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[BigEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer')

## BigEndianByteIndexer.explicit operator byte[](BigEndianByteIndexer) Operator

Explicitly converts the [BigEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer') to an array of bytes.

```csharp
public static byte[] explicit operator byte[](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer indexer);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.op_Explicitbyte[](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer).indexer'></a>

`indexer` [BigEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer')

The indexer to convert.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
The raw data converted to an array, serialized as big endian.
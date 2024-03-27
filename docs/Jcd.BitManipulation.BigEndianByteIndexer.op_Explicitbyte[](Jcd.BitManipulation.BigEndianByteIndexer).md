### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer')

## BigEndianByteIndexer.explicit operator byte[](BigEndianByteIndexer) Operator

Explicitly converts
the [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer') to an
array of bytes.

```csharp
public static byte[] explicit operator byte[](Jcd.BitManipulation.BigEndianByteIndexer indexer);
```
#### Parameters

<a name='Jcd.BitManipulation.BigEndianByteIndexer.op_Explicitbyte[](Jcd.BitManipulation.BigEndianByteIndexer).indexer'></a>

`indexer` [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer')

The indexer to convert.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
The raw data converted to an array, serialized as big endian.
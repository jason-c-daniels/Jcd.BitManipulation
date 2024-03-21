#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[BigEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer')

## BigEndianByteIndexer.implicit operator byte[](BigEndianByteIndexer) Operator

Converts the byte indexer to its underlying data type.

```csharp
public static byte[] implicit operator byte[](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer indexer);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.op_Implicitbyte[](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer).indexer'></a>

`indexer` [BigEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer')

The indexer to convert.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
The raw data.
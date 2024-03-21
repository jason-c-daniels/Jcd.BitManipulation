#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[BigEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer')

## BigEndianByteIndexer.implicit operator ulong(BigEndianByteIndexer) Operator

Converts the byte indexer to its underlying data type.

```csharp
public static ulong implicit operator ulong(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer indexer);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.op_Implicitulong(Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer).indexer'></a>

`indexer` [BigEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer')

The indexer to convert.

#### Returns

[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The raw data.
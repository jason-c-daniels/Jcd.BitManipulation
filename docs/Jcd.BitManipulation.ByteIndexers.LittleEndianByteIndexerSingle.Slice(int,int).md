#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[LittleEndianByteIndexerSingle](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle')

## LittleEndianByteIndexerSingle.Slice(int, int) Method

Get a subset of bytes given a starting offset and length.

```csharp
public readonly byte[] Slice(int start, int length);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.Slice(int,int).start'></a>

`start` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The starting bit offset

<a name='Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexerSingle.Slice(int,int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to extract

Implements [Slice(int, int)](Jcd.BitManipulation.ByteIndexers.IByteIndexer.Slice(int,int).md 'Jcd.BitManipulation.ByteIndexers.IByteIndexer.Slice(int, int)')

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
an array of bytes for the specified subset
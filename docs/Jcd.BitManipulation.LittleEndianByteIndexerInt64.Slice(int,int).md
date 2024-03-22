### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[LittleEndianByteIndexerInt64](Jcd.BitManipulation.LittleEndianByteIndexerInt64.md 'Jcd.BitManipulation.LittleEndianByteIndexerInt64')

## LittleEndianByteIndexerInt64.Slice(int, int) Method

Get a subset of bytes given a starting offset and length.

```csharp
public byte[] Slice(int start, int length);
```
#### Parameters

<a name='Jcd.BitManipulation.LittleEndianByteIndexerInt64.Slice(int,int).start'></a>

`start` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The starting bit offset

<a name='Jcd.BitManipulation.LittleEndianByteIndexerInt64.Slice(int,int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to extract

Implements [Slice(int, int)](Jcd.BitManipulation.IByteIndexer.Slice(int,int).md 'Jcd.BitManipulation.IByteIndexer.Slice(int, int)')

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
an array of bytes for the specified subset
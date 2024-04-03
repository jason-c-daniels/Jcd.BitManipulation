#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer')

## LittleEndianByteIndexer.Slice(int, int) Method

Get a subset of bytes given a starting offset and length.

```csharp
public readonly byte[] Slice(int start, int length);
```
#### Parameters

<a name='Jcd.BitManipulation.LittleEndianByteIndexer.Slice(int,int).start'></a>

`start` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The starting bit offset

<a name='Jcd.BitManipulation.LittleEndianByteIndexer.Slice(int,int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bytes to extract

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
An array of bytes for the specified subset.
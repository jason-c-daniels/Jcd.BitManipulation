#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ReadBytesExtensions](Jcd.BitManipulation.ReadBytesExtensions.md 'Jcd.BitManipulation.ReadBytesExtensions')

## ReadBytesExtensions.ReadBytes(this ByteIndexerInt16, int, int) Method

Reads a set of bytes starting at the specified byte location within the indexer.

```csharp
public static byte[] ReadBytes(this Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16 indexer, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadBytes(thisJcd.BitManipulation.ByteIndexers.ByteIndexerInt16,int,int).indexer'></a>

`indexer` [ByteIndexerInt16](Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerInt16')

The indexer whose value is to be modified.

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadBytes(thisJcd.BitManipulation.ByteIndexers.ByteIndexerInt16,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte location to store the value.

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadBytes(thisJcd.BitManipulation.ByteIndexers.ByteIndexerInt16,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bytes from the source, to store.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
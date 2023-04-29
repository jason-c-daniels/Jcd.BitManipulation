#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[ReadBytesExtensions](Jcd.BitManipulation.ByteIndexers.ReadBytesExtensions.md 'Jcd.BitManipulation.ByteIndexers.ReadBytesExtensions')

## ReadBytesExtensions.ReadBytes(this ByteIndexerSByte, int, int) Method

Reads a set of bytes starting at the specified byte location within the indexer.

```csharp
public static byte[] ReadBytes(this Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte indexer, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.ReadBytesExtensions.ReadBytes(thisJcd.BitManipulation.ByteIndexers.ByteIndexerSByte,int,int).indexer'></a>

`indexer` [ByteIndexerSByte](Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte')

The indexer whose value is to be modified.

<a name='Jcd.BitManipulation.ByteIndexers.ReadBytesExtensions.ReadBytes(thisJcd.BitManipulation.ByteIndexers.ByteIndexerSByte,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte location to store the value.

<a name='Jcd.BitManipulation.ByteIndexers.ReadBytesExtensions.ReadBytes(thisJcd.BitManipulation.ByteIndexers.ByteIndexerSByte,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bytes from the source, to store.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
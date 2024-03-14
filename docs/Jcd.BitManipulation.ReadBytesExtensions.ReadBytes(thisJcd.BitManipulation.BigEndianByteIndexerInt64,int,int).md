### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ReadBytesExtensions](Jcd.BitManipulation.ReadBytesExtensions.md 'Jcd.BitManipulation.ReadBytesExtensions')

## ReadBytesExtensions.ReadBytes(this BigEndianByteIndexerInt64, int, int) Method

Reads a set of bytes starting at the specified byte location within the indexer.

```csharp
public static byte[] ReadBytes(this Jcd.BitManipulation.BigEndianByteIndexerInt64 indexer, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadBytes(thisJcd.BitManipulation.BigEndianByteIndexerInt64,int,int).indexer'></a>

`indexer` [BigEndianByteIndexerInt64](Jcd.BitManipulation.BigEndianByteIndexerInt64.md 'Jcd.BitManipulation.BigEndianByteIndexerInt64')

The indexer whose value is to be modified.

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadBytes(thisJcd.BitManipulation.BigEndianByteIndexerInt64,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte location to store the value.

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadBytes(thisJcd.BitManipulation.BigEndianByteIndexerInt64,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bytes from the source, to store.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
A big endian byte array of the value.
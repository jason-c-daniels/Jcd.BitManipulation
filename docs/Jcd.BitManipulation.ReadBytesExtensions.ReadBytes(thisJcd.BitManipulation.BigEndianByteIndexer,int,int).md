### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ReadBytesExtensions](Jcd.BitManipulation.ReadBytesExtensions.md 'Jcd.BitManipulation.ReadBytesExtensions')

## ReadBytesExtensions.ReadBytes(this BigEndianByteIndexer, int, int) Method

Reads a set of bytes starting at the specified byte location within the indexer.

```csharp
public static byte[] ReadBytes(this Jcd.BitManipulation.BigEndianByteIndexer indexer, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadBytes(thisJcd.BitManipulation.BigEndianByteIndexer,int,int).indexer'></a>

`indexer` [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer')

The indexer whose value is to be modified.

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadBytes(thisJcd.BitManipulation.BigEndianByteIndexer,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte location to store the value.

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadBytes(thisJcd.BitManipulation.BigEndianByteIndexer,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bytes from the source, to store.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
A big endian byte array of the value.
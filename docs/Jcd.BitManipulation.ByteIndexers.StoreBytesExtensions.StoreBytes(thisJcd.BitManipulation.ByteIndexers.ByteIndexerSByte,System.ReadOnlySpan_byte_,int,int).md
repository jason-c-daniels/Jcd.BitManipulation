#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[StoreBytesExtensions](Jcd.BitManipulation.ByteIndexers.StoreBytesExtensions.md 'Jcd.BitManipulation.ByteIndexers.StoreBytesExtensions')

## StoreBytesExtensions.StoreBytes(this ByteIndexerSByte, ReadOnlySpan<byte>, int, int) Method

Stores a set of bytes starting at the specified byte location within the indexer.

```csharp
public static Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte StoreBytes(this Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte indexer, System.ReadOnlySpan<byte> bytes, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.StoreBytesExtensions.StoreBytes(thisJcd.BitManipulation.ByteIndexers.ByteIndexerSByte,System.ReadOnlySpan_byte_,int,int).indexer'></a>

`indexer` [ByteIndexerSByte](Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte')

The indexer whose value is to be modified.

<a name='Jcd.BitManipulation.ByteIndexers.StoreBytesExtensions.StoreBytes(thisJcd.BitManipulation.ByteIndexers.ByteIndexerSByte,System.ReadOnlySpan_byte_,int,int).bytes'></a>

`bytes` [System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')

The value to be stored at the byte location.

<a name='Jcd.BitManipulation.ByteIndexers.StoreBytesExtensions.StoreBytes(thisJcd.BitManipulation.ByteIndexers.ByteIndexerSByte,System.ReadOnlySpan_byte_,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte location to store the value.

<a name='Jcd.BitManipulation.ByteIndexers.StoreBytesExtensions.StoreBytes(thisJcd.BitManipulation.ByteIndexers.ByteIndexerSByte,System.ReadOnlySpan_byte_,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bytes from the source, to store. -1 means all bytes.

#### Returns
[ByteIndexerSByte](Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte')
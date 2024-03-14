#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[StoreBytesExtensions](Jcd.BitManipulation.StoreBytesExtensions.md 'Jcd.BitManipulation.StoreBytesExtensions')

## StoreBytesExtensions.StoreBytes(this BigEndianByteIndexerUInt32, ReadOnlySpan<byte>, int, int) Method

Stores a set of bytes starting at the specified byte location within the indexer.
Byte indexing is MSB, most significant byte, at index/offset zero.

```csharp
public static Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32 StoreBytes(this Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32 indexer, System.ReadOnlySpan<byte> bytes, int offset, int size=-1);
```
#### Parameters

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreBytes(thisJcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32,System.ReadOnlySpan_byte_,int,int).indexer'></a>

`indexer` [BigEndianByteIndexerUInt32](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32')

The indexer whose value is to be modified.

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreBytes(thisJcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32,System.ReadOnlySpan_byte_,int,int).bytes'></a>

`bytes` [System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')

The value to be stored at the byte location.

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreBytes(thisJcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32,System.ReadOnlySpan_byte_,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte location to store the value.

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreBytes(thisJcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32,System.ReadOnlySpan_byte_,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bytes from the source, to store. -1 means all bytes.

#### Returns
[BigEndianByteIndexerUInt32](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexerUInt32')
The modified value.
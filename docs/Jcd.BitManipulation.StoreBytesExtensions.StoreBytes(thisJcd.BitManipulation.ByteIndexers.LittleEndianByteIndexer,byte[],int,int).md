#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[StoreBytesExtensions](Jcd.BitManipulation.StoreBytesExtensions.md 'Jcd.BitManipulation.StoreBytesExtensions')

## StoreBytesExtensions.StoreBytes(this LittleEndianByteIndexer, byte[], int, int) Method

Stores a set of bytes starting at the specified byte location within the indexer.

```csharp
public static Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer StoreBytes(this Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer indexer, byte[] bytes, int offset, int size=-1);
```
#### Parameters

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreBytes(thisJcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer,byte[],int,int).indexer'></a>

`indexer` [LittleEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer')

The indexer whose value is to be modified.

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreBytes(thisJcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer,byte[],int,int).bytes'></a>

`bytes` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The value to be stored at the byte location.

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreBytes(thisJcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer,byte[],int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte location to store the value.

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreBytes(thisJcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer,byte[],int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bytes from the source to store. -1 means all bytes.

#### Returns

[LittleEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.LittleEndianByteIndexer')
The modified value.
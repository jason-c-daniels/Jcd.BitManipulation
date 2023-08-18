#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[StoreBytesExtensions](Jcd.BitManipulation.StoreBytesExtensions.md 'Jcd.BitManipulation.StoreBytesExtensions')

## StoreBytesExtensions.StoreBytes(this ByteIndexerSByte, ReadOnlySpan<byte>, int) Method

Stores a set of bytes starting at the specified byte location within the indexer.  
Byte indexing is LSB, least significant byte, at index/offset zero.

```csharp
public static Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte StoreBytes(this Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte indexer, System.ReadOnlySpan<byte> bytes, int offset);
```
#### Parameters

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreBytes(thisJcd.BitManipulation.ByteIndexers.ByteIndexerSByte,System.ReadOnlySpan_byte_,int).indexer'></a>

`indexer` [ByteIndexerSByte](Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte')

The indexer whose value is to be modified.

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreBytes(thisJcd.BitManipulation.ByteIndexers.ByteIndexerSByte,System.ReadOnlySpan_byte_,int).bytes'></a>

`bytes` [System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')

The value to be stored at the byte location.

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreBytes(thisJcd.BitManipulation.ByteIndexers.ByteIndexerSByte,System.ReadOnlySpan_byte_,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte location to store the value.

#### Returns
[ByteIndexerSByte](Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte.md 'Jcd.BitManipulation.ByteIndexers.ByteIndexerSByte')  
The modified value.
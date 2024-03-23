#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[StoreBytesExtensions](Jcd.BitManipulation.StoreBytesExtensions.md 'Jcd.BitManipulation.StoreBytesExtensions')

## StoreBytesExtensions.StoreByte(this BigEndianByteIndexer, byte, int) Method

Store a single byte to the value at the specified byte offset.

```csharp
public static Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer StoreByte(this Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer value, byte @byte, int offset);
```
#### Parameters

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreByte(thisJcd.BitManipulation.ByteIndexers.BigEndianByteIndexer,byte,int).value'></a>

`value` [BigEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer')

The value to be modified.

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreByte(thisJcd.BitManipulation.ByteIndexers.BigEndianByteIndexer,byte,int).byte'></a>

`byte` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The byte value to set

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreByte(thisJcd.BitManipulation.ByteIndexers.BigEndianByteIndexer,byte,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the offset of the byte to write

#### Returns
[BigEndianByteIndexer](Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer.md 'Jcd.BitManipulation.ByteIndexers.BigEndianByteIndexer')
The modified value.
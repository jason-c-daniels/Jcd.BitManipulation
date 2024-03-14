### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[StoreBytesExtensions](Jcd.BitManipulation.StoreBytesExtensions.md 'Jcd.BitManipulation.StoreBytesExtensions')

## StoreBytesExtensions.StoreByte(this BigEndianByteIndexerUInt32, byte, int) Method

Store a single byte to the value at the specified byte offset.
Byte indexing is LSB, least significant byte, at index/offset zero.

```csharp
public static Jcd.BitManipulation.BigEndianByteIndexerUInt32 StoreByte(this Jcd.BitManipulation.BigEndianByteIndexerUInt32 value, byte @byte, int offset);
```
#### Parameters

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreByte(thisJcd.BitManipulation.BigEndianByteIndexerUInt32,byte,int).value'></a>

`value` [BigEndianByteIndexerUInt32](Jcd.BitManipulation.BigEndianByteIndexerUInt32.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt32')

The value to be modified.

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreByte(thisJcd.BitManipulation.BigEndianByteIndexerUInt32,byte,int).byte'></a>

`byte` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The byte value to set

<a name='Jcd.BitManipulation.StoreBytesExtensions.StoreByte(thisJcd.BitManipulation.BigEndianByteIndexerUInt32,byte,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the offset of the byte to write

#### Returns

[BigEndianByteIndexerUInt32](Jcd.BitManipulation.BigEndianByteIndexerUInt32.md 'Jcd.BitManipulation.BigEndianByteIndexerUInt32')
The modified value.
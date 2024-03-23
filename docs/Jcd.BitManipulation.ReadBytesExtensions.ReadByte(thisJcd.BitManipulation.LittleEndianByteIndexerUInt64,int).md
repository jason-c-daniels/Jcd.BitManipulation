### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ReadBytesExtensions](Jcd.BitManipulation.ReadBytesExtensions.md 'Jcd.BitManipulation.ReadBytesExtensions')

## ReadBytesExtensions.ReadByte(this LittleEndianByteIndexerUInt64, int) Method

Read a single byte from the value at the specified byte offset.

```csharp
public static byte ReadByte(this Jcd.BitManipulation.LittleEndianByteIndexerUInt64 value, int offset);
```
#### Parameters

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadByte(thisJcd.BitManipulation.LittleEndianByteIndexerUInt64,int).value'></a>

`value` [LittleEndianByteIndexerUInt64](Jcd.BitManipulation.LittleEndianByteIndexerUInt64.md 'Jcd.BitManipulation.LittleEndianByteIndexerUInt64')

The value to be read.

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadByte(thisJcd.BitManipulation.LittleEndianByteIndexerUInt64,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the offset of the byte to write

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The specified byte.
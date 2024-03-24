### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ReadBytesExtensions](Jcd.BitManipulation.ReadBytesExtensions.md 'Jcd.BitManipulation.ReadBytesExtensions')

## ReadBytesExtensions.ReadByte(this LittleEndianByteIndexer, int) Method

Read a single byte from the value at the specified byte offset.

```csharp
public static byte ReadByte(this Jcd.BitManipulation.LittleEndianByteIndexer indexer, int offset);
```
#### Parameters

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadByte(thisJcd.BitManipulation.LittleEndianByteIndexer,int).indexer'></a>

`indexer` [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer')

The indexer to be read from.

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadByte(thisJcd.BitManipulation.LittleEndianByteIndexer,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the offset of the byte to write

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The specified byte.
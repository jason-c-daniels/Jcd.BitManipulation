### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ReadBytesExtensions](Jcd.BitManipulation.ReadBytesExtensions.md 'Jcd.BitManipulation.ReadBytesExtensions')

## ReadBytesExtensions.ReadByte(this uint, int, Endian) Method

Read a single byte from the value at the specified byte offset.

```csharp
public static byte ReadByte(this uint value, int offset, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadByte(thisuint,int,Jcd.BitManipulation.Endian).value'></a>

`value` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The value to be read.

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadByte(thisuint,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the offset of the byte to write

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadByte(thisuint,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endianness of the byte indexing within the value.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The specified byte.
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int32Extensions](Jcd.BitManipulation.Int32Extensions.md 'Jcd.BitManipulation.Int32Extensions')

## Int32Extensions.ReadByte(this int, int, Endian) Method

Reads a single byte from the value at the specified byte offset.

```csharp
public static byte ReadByte(this int value, int offset, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.Int32Extensions.ReadByte(thisint,int,Jcd.BitManipulation.Endian).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The value to read the byte from.

<a name='Jcd.BitManipulation.Int32Extensions.ReadByte(thisint,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of where to store the byte.

<a name='Jcd.BitManipulation.Int32Extensions.ReadByte(thisint,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endianness of the byte indexing within the value.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The specified byte.
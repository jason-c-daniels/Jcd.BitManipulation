#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[UInt32Extensions](Jcd.BitManipulation.UInt32Extensions 'Jcd.BitManipulation.UInt32Extensions')

## UInt32Extensions.ReadByte(this uint, int, Endian) Method

Reads a single byte from the value at the specified byte offset.

```csharp
public static byte ReadByte(this uint number, int offset, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt32Extensions.ReadByte(thisuint,int,Jcd.BitManipulation.Endian).number'></a>

`number` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The value to read the byte from.

<a name='Jcd.BitManipulation.UInt32Extensions.ReadByte(thisuint,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of where to store the byte.

<a name='Jcd.BitManipulation.UInt32Extensions.ReadByte(thisuint,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian')

The endianness of the byte indexing within the value.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The specified byte.
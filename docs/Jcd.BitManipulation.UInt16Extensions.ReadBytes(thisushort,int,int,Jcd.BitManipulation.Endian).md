### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt16Extensions](Jcd.BitManipulation.UInt16Extensions.md 'Jcd.BitManipulation.UInt16Extensions')

## UInt16Extensions.ReadBytes(this ushort, int, int, Endian) Method

Reads a set of bytes starting at the specified byte location within the value.

```csharp
public static byte[] ReadBytes(this ushort value, int offset, int size, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.UInt16Extensions.ReadBytes(thisushort,int,int,Jcd.BitManipulation.Endian).value'></a>

`value` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The value to be read.

<a name='Jcd.BitManipulation.UInt16Extensions.ReadBytes(thisushort,int,int,Jcd.BitManipulation.Endian).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte location to store the value.

<a name='Jcd.BitManipulation.UInt16Extensions.ReadBytes(thisushort,int,int,Jcd.BitManipulation.Endian).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte size of the value.

<a name='Jcd.BitManipulation.UInt16Extensions.ReadBytes(thisushort,int,int,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endianness of the byte indexing within the value.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
A little endian byte array of the value.
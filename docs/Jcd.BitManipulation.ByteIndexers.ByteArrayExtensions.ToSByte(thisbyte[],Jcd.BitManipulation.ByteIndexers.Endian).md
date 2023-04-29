#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[ByteArrayExtensions](Jcd.BitManipulation.ByteIndexers.ByteArrayExtensions.md 'Jcd.BitManipulation.ByteIndexers.ByteArrayExtensions')

## ByteArrayExtensions.ToSByte(this byte[], Endian) Method

Converts bytes into an sbyte, discarding any excess data.

```csharp
public static sbyte ToSByte(this byte[] data, Jcd.BitManipulation.ByteIndexers.Endian endian=Jcd.BitManipulation.ByteIndexers.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.ByteArrayExtensions.ToSByte(thisbyte[],Jcd.BitManipulation.ByteIndexers.Endian).data'></a>

`data` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the bytes to convert

<a name='Jcd.BitManipulation.ByteIndexers.ByteArrayExtensions.ToSByte(thisbyte[],Jcd.BitManipulation.ByteIndexers.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.ByteIndexers.Endian.md 'Jcd.BitManipulation.ByteIndexers.Endian')

A setting indicating the endianness of the source data. The default is Endian.Little.

#### Returns
[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')  
The converted sbyte
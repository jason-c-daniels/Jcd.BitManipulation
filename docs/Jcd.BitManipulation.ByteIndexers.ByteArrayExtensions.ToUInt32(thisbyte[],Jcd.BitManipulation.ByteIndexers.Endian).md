#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[ByteArrayExtensions](Jcd.BitManipulation.ByteIndexers.ByteArrayExtensions.md 'Jcd.BitManipulation.ByteIndexers.ByteArrayExtensions')

## ByteArrayExtensions.ToUInt32(this byte[], Endian) Method

Converts bytes into a uint, discarding any excess data.

```csharp
public static uint ToUInt32(this byte[] data, Jcd.BitManipulation.ByteIndexers.Endian endian=Jcd.BitManipulation.ByteIndexers.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.ByteArrayExtensions.ToUInt32(thisbyte[],Jcd.BitManipulation.ByteIndexers.Endian).data'></a>

`data` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the bytes to convert

<a name='Jcd.BitManipulation.ByteIndexers.ByteArrayExtensions.ToUInt32(thisbyte[],Jcd.BitManipulation.ByteIndexers.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.ByteIndexers.Endian.md 'Jcd.BitManipulation.ByteIndexers.Endian')

A setting indicating the endianness of the source data. The default is Endian.Little.

#### Returns
[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The converted uint
#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[ByteArrayExtensions](Jcd.BitManipulation.ByteIndexers.ByteArrayExtensions.md 'Jcd.BitManipulation.ByteIndexers.ByteArrayExtensions')

## ByteArrayExtensions.ToByteArray(this ushort, Endian) Method

Convert a ushort into an array of bytes

```csharp
public static byte[] ToByteArray(this ushort data, Jcd.BitManipulation.ByteIndexers.Endian endian=Jcd.BitManipulation.ByteIndexers.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.ByteArrayExtensions.ToByteArray(thisushort,Jcd.BitManipulation.ByteIndexers.Endian).data'></a>

`data` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

the data of the ushort to convert

<a name='Jcd.BitManipulation.ByteIndexers.ByteArrayExtensions.ToByteArray(thisushort,Jcd.BitManipulation.ByteIndexers.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.ByteIndexers.Endian.md 'Jcd.BitManipulation.ByteIndexers.Endian')

The order in which to store the bytes

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The value as an array in the requested byte order
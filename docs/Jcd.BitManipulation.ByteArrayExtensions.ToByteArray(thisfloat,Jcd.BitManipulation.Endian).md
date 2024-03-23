#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ByteArrayExtensions](Jcd.BitManipulation.ByteArrayExtensions.md 'Jcd.BitManipulation.ByteArrayExtensions')

## ByteArrayExtensions.ToByteArray(this float, Endian) Method

Convert a float into an array of bytes

```csharp
public static byte[] ToByteArray(this float data, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToByteArray(thisfloat,Jcd.BitManipulation.Endian).data'></a>

`data` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

the long to convert

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToByteArray(thisfloat,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The order in which to store the bytes

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
The value as an array in the requested byte order
#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[ByteArrayExtensions](Jcd.BitManipulation.ByteArrayExtensions 'Jcd.BitManipulation.ByteArrayExtensions')

## ByteArrayExtensions.ToByte(this byte[], Endian) Method

Converts an array of bytes into a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'), discarding any excess data.

```csharp
public static byte ToByte(this byte[] array, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToByte(thisbyte[],Jcd.BitManipulation.Endian).array'></a>

`array` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the bytes to convert.

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToByte(thisbyte[],Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian')

The endian for the bytes.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The converted [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
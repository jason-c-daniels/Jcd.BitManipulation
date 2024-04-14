#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[ByteArrayExtensions](Jcd.BitManipulation.ByteArrayExtensions 'Jcd.BitManipulation.ByteArrayExtensions')

## ByteArrayExtensions.ToSByte(this byte[], Endian) Method

Converts an array of bytes into a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte'), discarding any excess data.

```csharp
public static sbyte ToSByte(this byte[] array, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToSByte(thisbyte[],Jcd.BitManipulation.Endian).array'></a>

`array` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the bytes to convert.

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToSByte(thisbyte[],Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian')

The endian for the bytes.

#### Returns

[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
The converted sbyte
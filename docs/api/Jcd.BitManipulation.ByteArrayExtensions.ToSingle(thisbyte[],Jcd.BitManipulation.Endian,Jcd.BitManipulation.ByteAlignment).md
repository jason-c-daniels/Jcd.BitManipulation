#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[ByteArrayExtensions](Jcd.BitManipulation.ByteArrayExtensions 'Jcd.BitManipulation.ByteArrayExtensions')

## ByteArrayExtensions.ToSingle(this byte[], Endian, ByteAlignment) Method

Converts an array of bytes into a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single'), discarding any excess data.

```csharp
public static float ToSingle(this byte[] array, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little, Jcd.BitManipulation.ByteAlignment align=Jcd.BitManipulation.ByteAlignment.InferredFromEndian);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToSingle(thisbyte[],Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).array'></a>

`array` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the bytes to convert.

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToSingle(thisbyte[],Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian')

A setting indicating the endianness of the source data. The default is Endian.Little.

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToSingle(thisbyte[],Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).align'></a>

`align` [ByteAlignment](Jcd.BitManipulation.ByteAlignment 'Jcd.BitManipulation.ByteAlignment')

Indicates how to align partial data

#### Returns

[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')
The converted ulong

### Remarks

Index 0 in the array is index 0 in the destination value. For Big Endian this is the
most significant byte.
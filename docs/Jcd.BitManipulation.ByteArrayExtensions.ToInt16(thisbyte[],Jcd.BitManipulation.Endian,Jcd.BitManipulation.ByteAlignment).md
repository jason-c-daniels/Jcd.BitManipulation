#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ByteArrayExtensions](Jcd.BitManipulation.ByteArrayExtensions.md 'Jcd.BitManipulation.ByteArrayExtensions')

## ByteArrayExtensions.ToInt16(this byte[], Endian, ByteAlignment) Method

Converts an array of bytes into a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'), discarding any excess data.

```csharp
public static short ToInt16(this byte[] array, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little, Jcd.BitManipulation.ByteAlignment align=Jcd.BitManipulation.ByteAlignment.InferredFromEndian);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToInt16(thisbyte[],Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).array'></a>

`array` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the bytes to convert.

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToInt16(thisbyte[],Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endian for the bytes.

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToInt16(thisbyte[],Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).align'></a>

`align` [ByteAlignment](Jcd.BitManipulation.ByteAlignment.md 'Jcd.BitManipulation.ByteAlignment')

Indicates how to align partial data

#### Returns

[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')
The converted [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

### Remarks

Index 0 in the array is index 0 in the destination value. For Big Endian this is the
most significant byte.
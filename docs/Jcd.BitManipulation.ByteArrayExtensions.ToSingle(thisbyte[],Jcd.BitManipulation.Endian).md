### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ByteArrayExtensions](Jcd.BitManipulation.ByteArrayExtensions.md 'Jcd.BitManipulation.ByteArrayExtensions')

## ByteArrayExtensions.ToSingle(this byte[], Endian) Method

Converts an array of bytes into a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single'), discarding any excess data.

```csharp
public static float ToSingle(this byte[] data, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToSingle(thisbyte[],Jcd.BitManipulation.Endian).data'></a>

`data` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the bytes to convert.

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToSingle(thisbyte[],Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

A setting indicating the endianness of the source data. The default is Endian.Little.

#### Returns

[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')
The converted ulong

### Remarks

<b>WARNING:</b>

Index 0 in the array is index 0 in the destination value. For Big Endian this is the
most significant byte. If you're passing in a smaller array and need the result
right shifted, after calling this, you'll need to convert to a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
shift it, then convert back to a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single').
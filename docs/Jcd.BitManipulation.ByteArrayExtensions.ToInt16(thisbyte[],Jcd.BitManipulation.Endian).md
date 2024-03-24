### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ByteArrayExtensions](Jcd.BitManipulation.ByteArrayExtensions.md 'Jcd.BitManipulation.ByteArrayExtensions')

## ByteArrayExtensions.ToInt16(this byte[], Endian) Method

Converts bytes into a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'),
discarding any excess data.

```csharp
public static short ToInt16(this byte[] data, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToInt16(thisbyte[],Jcd.BitManipulation.Endian).data'></a>

`data` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the bytes to convert

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToInt16(thisbyte[],Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endian for the bytes.

#### Returns

[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')
The converted [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')
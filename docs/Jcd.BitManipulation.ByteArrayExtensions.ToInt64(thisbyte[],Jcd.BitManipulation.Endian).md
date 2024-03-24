### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ByteArrayExtensions](Jcd.BitManipulation.ByteArrayExtensions.md 'Jcd.BitManipulation.ByteArrayExtensions')

## ByteArrayExtensions.ToInt64(this byte[], Endian) Method

Converts bytes into a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'),
discarding any excess data.

```csharp
public static long ToInt64(this byte[] data, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToInt64(thisbyte[],Jcd.BitManipulation.Endian).data'></a>

`data` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the bytes to convert

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToInt64(thisbyte[],Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endian for the bytes.

#### Returns

[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')
The converted [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')
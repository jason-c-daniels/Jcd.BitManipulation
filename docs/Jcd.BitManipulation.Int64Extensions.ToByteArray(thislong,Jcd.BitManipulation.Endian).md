### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int64Extensions](Jcd.BitManipulation.Int64Extensions.md 'Jcd.BitManipulation.Int64Extensions')

## Int64Extensions.ToByteArray(this long, Endian) Method

Convert a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') into an array of bytes

```csharp
public static byte[] ToByteArray(this long data, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.Int64Extensions.ToByteArray(thislong,Jcd.BitManipulation.Endian).data'></a>

`data` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

the [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') to convert

<a name='Jcd.BitManipulation.Int64Extensions.ToByteArray(thislong,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The order in which to store the bytes

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
The value as an array in the requested byte order
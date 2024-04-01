### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int16Extensions](Jcd.BitManipulation.Int16Extensions.md 'Jcd.BitManipulation.Int16Extensions')

## Int16Extensions.ToByteArray(this short, Endian) Method

Converts a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') into an array of bytes in the specified [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian').

```csharp
public static byte[] ToByteArray(this short data, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```

#### Parameters

<a name='Jcd.BitManipulation.Int16Extensions.ToByteArray(thisshort,Jcd.BitManipulation.Endian).data'></a>

`data` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The value to convert to a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') array.

<a name='Jcd.BitManipulation.Int16Extensions.ToByteArray(thisshort,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The order in which to store the bytes

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
The value as an array in the requested byte order
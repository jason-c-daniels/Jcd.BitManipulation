### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt16Extensions](Jcd.BitManipulation.UInt16Extensions.md 'Jcd.BitManipulation.UInt16Extensions')

## UInt16Extensions.ToByteArray(this ushort, Endian) Method

Convert a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') into an array of
bytes

```csharp
public static byte[] ToByteArray(this ushort data, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.UInt16Extensions.ToByteArray(thisushort,Jcd.BitManipulation.Endian).data'></a>

`data` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

the data of the [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') to convert

<a name='Jcd.BitManipulation.UInt16Extensions.ToByteArray(thisushort,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The order in which to store the bytes

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
The value as an array in the requested byte order
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt32Extensions](Jcd.BitManipulation.UInt32Extensions.md 'Jcd.BitManipulation.UInt32Extensions')

## UInt32Extensions.ToByteArray(this uint, Endian) Method

Convert a uint into an array of bytes

```csharp
public static byte[] ToByteArray(this uint data, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.UInt32Extensions.ToByteArray(thisuint,Jcd.BitManipulation.Endian).data'></a>

`data` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

the [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') to convert

<a name='Jcd.BitManipulation.UInt32Extensions.ToByteArray(thisuint,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The order in which to store the bytes

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
The value as an array in the requested byte order
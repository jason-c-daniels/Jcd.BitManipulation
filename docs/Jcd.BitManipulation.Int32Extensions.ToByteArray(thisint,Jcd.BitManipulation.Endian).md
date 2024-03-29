### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int32Extensions](Jcd.BitManipulation.Int32Extensions.md 'Jcd.BitManipulation.Int32Extensions')

## Int32Extensions.ToByteArray(this int, Endian) Method

Converts an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') into an array of bytes

```csharp
public static byte[] ToByteArray(this int data, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.Int32Extensions.ToByteArray(thisint,Jcd.BitManipulation.Endian).data'></a>

`data` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') to convert.

<a name='Jcd.BitManipulation.Int32Extensions.ToByteArray(thisint,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The order in which to store the bytes

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
The value as an array in the requested byte order
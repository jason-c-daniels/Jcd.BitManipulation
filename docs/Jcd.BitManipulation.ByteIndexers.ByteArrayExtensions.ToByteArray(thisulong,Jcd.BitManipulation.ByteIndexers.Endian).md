#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.ByteIndexers](Jcd.BitManipulation.ByteIndexers.md 'Jcd.BitManipulation.ByteIndexers').[ByteArrayExtensions](Jcd.BitManipulation.ByteIndexers.ByteArrayExtensions.md 'Jcd.BitManipulation.ByteIndexers.ByteArrayExtensions')

## ByteArrayExtensions.ToByteArray(this ulong, Endian) Method

Convert a ulong into an array of bytes

```csharp
public static byte[] ToByteArray(this ulong data, Jcd.BitManipulation.ByteIndexers.Endian endian=Jcd.BitManipulation.ByteIndexers.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteIndexers.ByteArrayExtensions.ToByteArray(thisulong,Jcd.BitManipulation.ByteIndexers.Endian).data'></a>

`data` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

the ulong to convert

<a name='Jcd.BitManipulation.ByteIndexers.ByteArrayExtensions.ToByteArray(thisulong,Jcd.BitManipulation.ByteIndexers.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.ByteIndexers.Endian.md 'Jcd.BitManipulation.ByteIndexers.Endian')

The order in which to store the bytes

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The value as an array in the requested byte order
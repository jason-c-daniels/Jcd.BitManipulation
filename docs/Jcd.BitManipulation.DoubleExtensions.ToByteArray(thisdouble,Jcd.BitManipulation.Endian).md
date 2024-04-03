#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[DoubleExtensions](Jcd.BitManipulation.DoubleExtensions.md 'Jcd.BitManipulation.DoubleExtensions')

## DoubleExtensions.ToByteArray(this double, Endian) Method

Converts a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') into an array of bytes in the specified [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian').

```csharp
public static byte[] ToByteArray(this double data, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.DoubleExtensions.ToByteArray(thisdouble,Jcd.BitManipulation.Endian).data'></a>

`data` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The value to convert to a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') array.

<a name='Jcd.BitManipulation.DoubleExtensions.ToByteArray(thisdouble,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The order in which to store the bytes

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
The value as an array in the requested byte order
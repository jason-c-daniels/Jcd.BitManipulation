#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ByteArrayExtensions](Jcd.BitManipulation.ByteArrayExtensions.md 'Jcd.BitManipulation.ByteArrayExtensions')

## ByteArrayExtensions.ToDouble(this byte[], Endian, ByteAlignment) Method

Converts an array of bytes into a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double'), discarding any excess data.

```csharp
public static double ToDouble(this byte[] data, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little, Jcd.BitManipulation.ByteAlignment align=Jcd.BitManipulation.ByteAlignment.InferredFromEndian);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToDouble(thisbyte[],Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).data'></a>

`data` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the bytes to convert.

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToDouble(thisbyte[],Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

A setting indicating the endianness of the source data. The default is Endian.Little.

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToDouble(thisbyte[],Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).align'></a>

`align` [ByteAlignment](Jcd.BitManipulation.ByteAlignment.md 'Jcd.BitManipulation.ByteAlignment')

Indicates how to align partial data

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')
The converted [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

### Remarks

<b>WARNING:</b>

Index 0 in the array is index 0 in the destination value. For Big Endian this is the
most significant byte. If you're passing in a smaller array and need the result
right shifted, after calling this, you'll need to convert to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
shift it, then convert back to a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').
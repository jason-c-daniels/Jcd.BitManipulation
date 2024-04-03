#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ByteArrayExtensions](Jcd.BitManipulation.ByteArrayExtensions.md 'Jcd.BitManipulation.ByteArrayExtensions')

## ByteArrayExtensions.ToInt32(this byte[], Endian, ByteAlignment) Method

Converts an array of bytes into a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32'), discarding any excess data.

```csharp
public static int ToInt32(this byte[] data, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little, Jcd.BitManipulation.ByteAlignment align=Jcd.BitManipulation.ByteAlignment.InferredFromEndian);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToInt32(thisbyte[],Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).data'></a>

`data` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the bytes to convert.

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToInt32(thisbyte[],Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endian for the bytes.

<a name='Jcd.BitManipulation.ByteArrayExtensions.ToInt32(thisbyte[],Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).align'></a>

`align` [ByteAlignment](Jcd.BitManipulation.ByteAlignment.md 'Jcd.BitManipulation.ByteAlignment')

Indicates how to align partial data

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The converted [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

### Remarks

<b>WARNING:</b>

Index 0 in the array is index 0 in the destination value. For Big Endian this is the
most significant byte. If you're passing in a smaller array and need the result
right shifted, you'll need to shift it after calling this.
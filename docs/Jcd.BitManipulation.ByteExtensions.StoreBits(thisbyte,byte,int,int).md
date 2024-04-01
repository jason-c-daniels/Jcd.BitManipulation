### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ByteExtensions](Jcd.BitManipulation.ByteExtensions.md 'Jcd.BitManipulation.ByteExtensions')

## ByteExtensions.StoreBits(this byte, byte, int, int) Method

Stores a range of bits to the value, from a source value, and returns the modified value.

```csharp
public static byte StoreBits(this byte value, byte source, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteExtensions.StoreBits(thisbyte,byte,int,int).value'></a>

`value` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The value to modify.

<a name='Jcd.BitManipulation.ByteExtensions.StoreBits(thisbyte,byte,int,int).source'></a>

`source` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The value to be stored at the bit location.

<a name='Jcd.BitManipulation.ByteExtensions.StoreBits(thisbyte,byte,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.ByteExtensions.StoreBits(thisbyte,byte,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit size of the value.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The modified value.
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ByteExtensions](Jcd.BitManipulation.ByteExtensions.md 'Jcd.BitManipulation.ByteExtensions')

## ByteExtensions.StoreBit(this byte, bool, int) Method

Store a single bit at the specified offset.

```csharp
public static byte StoreBit(this byte value, bool bit, int offset);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteExtensions.StoreBit(thisbyte,bool,int).value'></a>

`value` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The value to be modified.

<a name='Jcd.BitManipulation.ByteExtensions.StoreBit(thisbyte,bool,int).bit'></a>

`bit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

The bit value to set

<a name='Jcd.BitManipulation.ByteExtensions.StoreBit(thisbyte,bool,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the offset of the bit to write

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The modified value.
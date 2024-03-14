### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[StoreBitsExtensions](Jcd.BitManipulation.StoreBitsExtensions.md 'Jcd.BitManipulation.StoreBitsExtensions')

## StoreBitsExtensions.StoreBit(this ulong, bool, int) Method

Store a single bit at the specified offset.

```csharp
public static ulong StoreBit(this ulong value, bool bit, int offset);
```
#### Parameters

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBit(thisulong,bool,int).value'></a>

`value` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value to be modified.

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBit(thisulong,bool,int).bit'></a>

`bit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

The bit value to set

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBit(thisulong,bool,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the offset of the bit to write

#### Returns

[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The modified value.
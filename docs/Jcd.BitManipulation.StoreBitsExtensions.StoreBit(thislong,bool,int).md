### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[StoreBitsExtensions](Jcd.BitManipulation.StoreBitsExtensions.md 'Jcd.BitManipulation.StoreBitsExtensions')

## StoreBitsExtensions.StoreBit(this long, bool, int) Method

Store a single bit from the specified offset.

```csharp
public static long StoreBit(this long value, bool bit, int offset);
```
#### Parameters

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBit(thislong,bool,int).value'></a>

`value` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The value to be modified.

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBit(thislong,bool,int).bit'></a>

`bit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

The bit value to set

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBit(thislong,bool,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the offset of the bit to write

#### Returns

[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')
The modified value.
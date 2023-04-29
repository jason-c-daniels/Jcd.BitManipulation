#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ClearBitsExtensions](Jcd.BitManipulation.ClearBitsExtensions.md 'Jcd.BitManipulation.ClearBitsExtensions')

## ClearBitsExtensions.ClearBits(this ulong, int, int) Method

Sets all specified bits to "off" and returns the modified value.

```csharp
public static ulong ClearBits(this ulong value, int offset=0, int size=64);
```
#### Parameters

<a name='Jcd.BitManipulation.ClearBitsExtensions.ClearBits(thisulong,int,int).value'></a>

`value` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value to be modified.

<a name='Jcd.BitManipulation.ClearBitsExtensions.ClearBits(thisulong,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of where to begin clearing bits.

<a name='Jcd.BitManipulation.ClearBitsExtensions.ClearBits(thisulong,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to clear.

#### Returns
[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')  
The modified value.
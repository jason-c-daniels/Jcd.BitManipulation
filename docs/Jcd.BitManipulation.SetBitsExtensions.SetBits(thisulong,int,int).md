### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[SetBitsExtensions](Jcd.BitManipulation.SetBitsExtensions.md 'Jcd.BitManipulation.SetBitsExtensions')

## SetBitsExtensions.SetBits(this ulong, int, int) Method

Sets all specified bits to "on"

```csharp
public static ulong SetBits(this ulong value, int offset=0, int size=64);
```
#### Parameters

<a name='Jcd.BitManipulation.SetBitsExtensions.SetBits(thisulong,int,int).value'></a>

`value` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value to be modified.

<a name='Jcd.BitManipulation.SetBitsExtensions.SetBits(thisulong,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.SetBitsExtensions.SetBits(thisulong,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to set on.

#### Returns

[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The modified value.
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[StoreBitsExtensions](Jcd.BitManipulation.StoreBitsExtensions.md 'Jcd.BitManipulation.StoreBitsExtensions')

## StoreBitsExtensions.StoreBits(this ulong, ulong, int, int) Method

Stores a value at the specified bit location within the variable.

```csharp
public static ulong StoreBits(this ulong value, ulong source, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisulong,ulong,int,int).value'></a>

`value` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value to be modified.

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisulong,ulong,int,int).source'></a>

`source` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value to be stored at the bit location.

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisulong,ulong,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisulong,ulong,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit size of the value.

#### Returns

[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The modified value.
#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[UInt64Extensions](Jcd.BitManipulation.UInt64Extensions 'Jcd.BitManipulation.UInt64Extensions')

## UInt64Extensions.StoreBits(this ulong, ulong, int, int) Method

Stores a range of bits to the value, from a source value, and returns the modified value. The source value is left shifted by the offset before storing.

```csharp
public static ulong StoreBits(this ulong number, ulong source, int offset, int size);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt64Extensions.StoreBits(thisulong,ulong,int,int).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value to modify.

<a name='Jcd.BitManipulation.UInt64Extensions.StoreBits(thisulong,ulong,int,int).source'></a>

`source` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value to be stored at the bit location.

<a name='Jcd.BitManipulation.UInt64Extensions.StoreBits(thisulong,ulong,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.UInt64Extensions.StoreBits(thisulong,ulong,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit size of the value.

#### Returns

[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The modified value.
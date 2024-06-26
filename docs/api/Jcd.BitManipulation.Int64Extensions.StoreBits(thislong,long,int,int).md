#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[Int64Extensions](Jcd.BitManipulation.Int64Extensions 'Jcd.BitManipulation.Int64Extensions')

## Int64Extensions.StoreBits(this long, long, int, int) Method

Stores a range of bits to the value, from a source value, and returns the modified value. The source value is left shifted by the offset before storing.

```csharp
public static long StoreBits(this long number, long source, int offset, int size);
```

#### Parameters

<a name='Jcd.BitManipulation.Int64Extensions.StoreBits(thislong,long,int,int).number'></a>

`number` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The value to modify.

<a name='Jcd.BitManipulation.Int64Extensions.StoreBits(thislong,long,int,int).source'></a>

`source` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The value to be stored at the bit location.

<a name='Jcd.BitManipulation.Int64Extensions.StoreBits(thislong,long,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.Int64Extensions.StoreBits(thislong,long,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit size of the value.

#### Returns

[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')
The modified value.
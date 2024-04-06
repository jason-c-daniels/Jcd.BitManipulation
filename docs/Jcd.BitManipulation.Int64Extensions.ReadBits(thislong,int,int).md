#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int64Extensions](Jcd.BitManipulation.Int64Extensions.md 'Jcd.BitManipulation.Int64Extensions')

## Int64Extensions.ReadBits(this long, int, int) Method

Reads the bits specified and returns the result shifted to the right by the offset.

```csharp
public static long ReadBits(this long value, int offset, int size);
```

#### Parameters

<a name='Jcd.BitManipulation.Int64Extensions.ReadBits(thislong,int,int).value'></a>

`value` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The source of the bits to read.

<a name='Jcd.BitManipulation.Int64Extensions.ReadBits(thislong,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit offset to start reading from.

<a name='Jcd.BitManipulation.Int64Extensions.ReadBits(thislong,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total number of bits to extract.

#### Returns

[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')
The value stored in the range of bits specified, right shifted by the offset..
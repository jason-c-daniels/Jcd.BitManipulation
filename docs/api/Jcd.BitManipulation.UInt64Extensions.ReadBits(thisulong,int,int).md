#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[UInt64Extensions](Jcd.BitManipulation.UInt64Extensions 'Jcd.BitManipulation.UInt64Extensions')

## UInt64Extensions.ReadBits(this ulong, int, int) Method

Reads the bits specified and returns the result shifted to the right by the offset.

```csharp
public static ulong ReadBits(this ulong number, int offset, int size);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt64Extensions.ReadBits(thisulong,int,int).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The source of the bits to read.

<a name='Jcd.BitManipulation.UInt64Extensions.ReadBits(thisulong,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit offset to start reading from.

<a name='Jcd.BitManipulation.UInt64Extensions.ReadBits(thisulong,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total number of bits to extract.

#### Returns

[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The value stored in the range of bits specified, right shifted by the offset.
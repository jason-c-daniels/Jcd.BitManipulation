#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[UInt16Extensions](Jcd.BitManipulation.UInt16Extensions 'Jcd.BitManipulation.UInt16Extensions')

## UInt16Extensions.StoreBits(this ushort, ushort, int, int) Method

Stores a range of bits to the value, from a source value, and returns the modified value.

```csharp
public static ushort StoreBits(this ushort number, ushort source, int offset, int size);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt16Extensions.StoreBits(thisushort,ushort,int,int).number'></a>

`number` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The value to modify.

<a name='Jcd.BitManipulation.UInt16Extensions.StoreBits(thisushort,ushort,int,int).source'></a>

`source` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The value to be stored at the bit location.

<a name='Jcd.BitManipulation.UInt16Extensions.StoreBits(thisushort,ushort,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.UInt16Extensions.StoreBits(thisushort,ushort,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit size of the value.

#### Returns

[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')
The modified value.
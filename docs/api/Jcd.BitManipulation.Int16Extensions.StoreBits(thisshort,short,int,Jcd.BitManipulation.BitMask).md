#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[Int16Extensions](Jcd.BitManipulation.Int16Extensions 'Jcd.BitManipulation.Int16Extensions')

## Int16Extensions.StoreBits(this short, short, int, BitMask) Method

Stores a set of bits specified by a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a source value to a bit offset and returns the modified
value.

```csharp
public static short StoreBits(this short number, short source, int offset, Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.Int16Extensions.StoreBits(thisshort,short,int,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

the destination for the stored bits

<a name='Jcd.BitManipulation.Int16Extensions.StoreBits(thisshort,short,int,Jcd.BitManipulation.BitMask).source'></a>

`source` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The source of the bits to store.

<a name='Jcd.BitManipulation.Int16Extensions.StoreBits(thisshort,short,int,Jcd.BitManipulation.BitMask).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The destination offset of where to store the bits.

<a name='Jcd.BitManipulation.Int16Extensions.StoreBits(thisshort,short,int,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The mask specifying the bits to store

#### Returns
[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')
The modified value.
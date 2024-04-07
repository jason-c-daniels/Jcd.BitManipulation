#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int16Extensions](Jcd.BitManipulation.Int16Extensions.md 'Jcd.BitManipulation.Int16Extensions')

## Int16Extensions.ReadBits(this short, BitMask) Method

Extract a subset of bits specified by a bitmask.

```csharp
public static short ReadBits(this short number, Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.Int16Extensions.ReadBits(thisshort,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The source of the bits to read.

<a name='Jcd.BitManipulation.Int16Extensions.ReadBits(thisshort,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

The bitmask specifying which bits to read.

#### Returns

[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')
The unshifted extracted bits
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int16Extensions](Jcd.BitManipulation.Int16Extensions.md 'Jcd.BitManipulation.Int16Extensions')

## Int16Extensions.AreAnyBitsSet(this short, BitMask) Method

Tests if any bits from the bitmask are set on a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16').

```csharp
public static bool AreAnyBitsSet(this short data, Jcd.BitManipulation.BitMask bitmask);
```
#### Parameters

<a name='Jcd.BitManipulation.Int16Extensions.AreAnyBitsSet(thisshort,Jcd.BitManipulation.BitMask).data'></a>

`data` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The data to inspect.

<a name='Jcd.BitManipulation.Int16Extensions.AreAnyBitsSet(thisshort,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the bits to test.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if any of the bits from the bitmask were set.

### Remarks
NB: Only the lowest 16 bits of the bitmask will be used.
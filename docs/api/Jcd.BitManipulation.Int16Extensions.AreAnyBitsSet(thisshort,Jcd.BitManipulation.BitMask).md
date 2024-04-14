#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[Int16Extensions](Jcd.BitManipulation.Int16Extensions 'Jcd.BitManipulation.Int16Extensions')

## Int16Extensions.AreAnyBitsSet(this short, BitMask) Method

Tests if any bits from the bitmask are set on a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16').

```csharp
public static bool AreAnyBitsSet(this short number, Jcd.BitManipulation.BitMask bitmask);
```

#### Parameters

<a name='Jcd.BitManipulation.Int16Extensions.AreAnyBitsSet(thisshort,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The data to inspect.

<a name='Jcd.BitManipulation.Int16Extensions.AreAnyBitsSet(thisshort,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bits to test.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if any of the bits from the bitmask were set.

### Remarks

NB: Only the lowest 16 bits of the bitmask will be used.
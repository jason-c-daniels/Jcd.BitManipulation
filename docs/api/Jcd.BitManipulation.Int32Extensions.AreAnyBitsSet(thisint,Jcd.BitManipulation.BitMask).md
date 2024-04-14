#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[Int32Extensions](Jcd.BitManipulation.Int32Extensions 'Jcd.BitManipulation.Int32Extensions')

## Int32Extensions.AreAnyBitsSet(this int, BitMask) Method

Tests if any bits from the bitmask are set on a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32').

```csharp
public static bool AreAnyBitsSet(this int number, Jcd.BitManipulation.BitMask bitmask);
```

#### Parameters

<a name='Jcd.BitManipulation.Int32Extensions.AreAnyBitsSet(thisint,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The data to inspect.

<a name='Jcd.BitManipulation.Int32Extensions.AreAnyBitsSet(thisint,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bits to test.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if any of the bits from the bitmask were set.

### Remarks

NB: Only the lowest 32 bits of the bitmask will be used.
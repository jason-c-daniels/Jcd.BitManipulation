#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[SingleExtensions](Jcd.BitManipulation.SingleExtensions 'Jcd.BitManipulation.SingleExtensions')

## SingleExtensions.AreAnyBitsSet(this float, BitMask) Method

Tests if any bits from the bitmask are set on a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single').

```csharp
public static bool AreAnyBitsSet(this float number, Jcd.BitManipulation.BitMask bitmask);
```

#### Parameters

<a name='Jcd.BitManipulation.SingleExtensions.AreAnyBitsSet(thisfloat,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The data to inspect.

<a name='Jcd.BitManipulation.SingleExtensions.AreAnyBitsSet(thisfloat,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bits to test.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if any of the bits from the bitmask were set.

### Remarks

NB: Only the lowest 8 bits of the bitmask will be used.
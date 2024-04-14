#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[UInt64Extensions](Jcd.BitManipulation.UInt64Extensions 'Jcd.BitManipulation.UInt64Extensions')

## UInt64Extensions.AreAnyBitsSet(this ulong, BitMask) Method

Tests if any bits from the bitmask are set on a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64').

```csharp
public static bool AreAnyBitsSet(this ulong number, Jcd.BitManipulation.BitMask bitmask);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt64Extensions.AreAnyBitsSet(thisulong,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The data to inspect.

<a name='Jcd.BitManipulation.UInt64Extensions.AreAnyBitsSet(thisulong,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bits to test.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if any of the bits from the bitmask were set.
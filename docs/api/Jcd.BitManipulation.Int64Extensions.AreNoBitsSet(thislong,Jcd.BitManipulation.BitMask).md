#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[Int64Extensions](Jcd.BitManipulation.Int64Extensions 'Jcd.BitManipulation.Int64Extensions')

## Int64Extensions.AreNoBitsSet(this long, BitMask) Method

Tests if none of the bits from the bitmask are set on a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64').

```csharp
public static bool AreNoBitsSet(this long number, Jcd.BitManipulation.BitMask bitmask);
```

#### Parameters

<a name='Jcd.BitManipulation.Int64Extensions.AreNoBitsSet(thislong,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The data to inspect.

<a name='Jcd.BitManipulation.Int64Extensions.AreNoBitsSet(thislong,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bits to test.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if all of the bits from the bitmask were set.
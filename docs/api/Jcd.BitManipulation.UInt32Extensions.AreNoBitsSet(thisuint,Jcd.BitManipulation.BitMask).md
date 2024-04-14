#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[UInt32Extensions](Jcd.BitManipulation.UInt32Extensions 'Jcd.BitManipulation.UInt32Extensions')

## UInt32Extensions.AreNoBitsSet(this uint, BitMask) Method

Tests if none of the bits from the bitmask are set on a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32').

```csharp
public static bool AreNoBitsSet(this uint number, Jcd.BitManipulation.BitMask bitmask);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt32Extensions.AreNoBitsSet(thisuint,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The data to inspect.

<a name='Jcd.BitManipulation.UInt32Extensions.AreNoBitsSet(thisuint,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bits to test.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if all of the bits from the bitmask were set.

### Remarks

NB: Only the lowest 32 bits of the bitmask will be used.
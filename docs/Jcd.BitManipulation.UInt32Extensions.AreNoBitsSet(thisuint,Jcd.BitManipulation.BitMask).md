### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt32Extensions](Jcd.BitManipulation.UInt32Extensions.md 'Jcd.BitManipulation.UInt32Extensions')

## UInt32Extensions.AreNoBitsSet(this uint, BitMask) Method

Tests if none of the bits from the bitmask are set on
a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32').

```csharp
public static bool AreNoBitsSet(this uint data, Jcd.BitManipulation.BitMask bitmask);
```
#### Parameters

<a name='Jcd.BitManipulation.UInt32Extensions.AreNoBitsSet(thisuint,Jcd.BitManipulation.BitMask).data'></a>

`data` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The data to inspect.

<a name='Jcd.BitManipulation.UInt32Extensions.AreNoBitsSet(thisuint,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the bits to test.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if all of the bits from the bitmask were set.

### Remarks
NB: Only the lowest 32 bits of the bitmask will be used.
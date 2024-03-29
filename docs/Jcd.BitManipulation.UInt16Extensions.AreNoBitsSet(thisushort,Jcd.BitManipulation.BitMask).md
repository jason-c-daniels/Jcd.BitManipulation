### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt16Extensions](Jcd.BitManipulation.UInt16Extensions.md 'Jcd.BitManipulation.UInt16Extensions')

## UInt16Extensions.AreNoBitsSet(this ushort, BitMask) Method

Tests if none of the bits from the bitmask are set on a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16').

```csharp
public static bool AreNoBitsSet(this ushort data, Jcd.BitManipulation.BitMask bitmask);
```
#### Parameters

<a name='Jcd.BitManipulation.UInt16Extensions.AreNoBitsSet(thisushort,Jcd.BitManipulation.BitMask).data'></a>

`data` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The data to inspect.

<a name='Jcd.BitManipulation.UInt16Extensions.AreNoBitsSet(thisushort,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the bits to test.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if all of the bits from the bitmask were set.

### Remarks
NB: Only the lowest 16 bits of the bitmask will be used.
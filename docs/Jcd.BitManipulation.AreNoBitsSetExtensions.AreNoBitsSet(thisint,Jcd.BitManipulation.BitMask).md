### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[AreNoBitsSetExtensions](Jcd.BitManipulation.AreNoBitsSetExtensions.md 'Jcd.BitManipulation.AreNoBitsSetExtensions')

## AreNoBitsSetExtensions.AreNoBitsSet(this int, BitMask) Method

Tests if none of the bits from the bitmask are set on
an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32').

```csharp
public static bool AreNoBitsSet(this int data, Jcd.BitManipulation.BitMask bitmask);
```
#### Parameters

<a name='Jcd.BitManipulation.AreNoBitsSetExtensions.AreNoBitsSet(thisint,Jcd.BitManipulation.BitMask).data'></a>

`data` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The data to inspect.

<a name='Jcd.BitManipulation.AreNoBitsSetExtensions.AreNoBitsSet(thisint,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the bits to test.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if all of the bits from the bitmask were set.

### Remarks
NB: Only the lowest 32 bits of the bitmask will be used.
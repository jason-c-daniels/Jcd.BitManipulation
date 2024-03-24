### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[AreNoBitsSetExtensions](Jcd.BitManipulation.AreNoBitsSetExtensions.md 'Jcd.BitManipulation.AreNoBitsSetExtensions')

## AreNoBitsSetExtensions.AreNoBitsSet(this ulong, BitMask) Method

Tests if none of the bits from the bitmask are set on a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64').

```csharp
public static bool AreNoBitsSet(this ulong data, Jcd.BitManipulation.BitMask bitmask);
```
#### Parameters

<a name='Jcd.BitManipulation.AreNoBitsSetExtensions.AreNoBitsSet(thisulong,Jcd.BitManipulation.BitMask).data'></a>

`data` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The data to inspect.

<a name='Jcd.BitManipulation.AreNoBitsSetExtensions.AreNoBitsSet(thisulong,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the bits to test.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if all of the bits from the bitmask were set.
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[SByteExtensions](Jcd.BitManipulation.SByteExtensions.md 'Jcd.BitManipulation.SByteExtensions')

## SByteExtensions.AreAnyBitsSet(this sbyte, BitMask) Method

Tests if any bits from the bitmask are set on a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte').

```csharp
public static bool AreAnyBitsSet(this sbyte data, Jcd.BitManipulation.BitMask bitmask);
```
#### Parameters

<a name='Jcd.BitManipulation.SByteExtensions.AreAnyBitsSet(thissbyte,Jcd.BitManipulation.BitMask).data'></a>

`data` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The data to inspect.

<a name='Jcd.BitManipulation.SByteExtensions.AreAnyBitsSet(thissbyte,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

The bits to test.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if any of the bits from the bitmask were set.

### Remarks
NB: Only the lowest 8 bits of the bitmask will be used.
#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[SByteExtensions](Jcd.BitManipulation.SByteExtensions 'Jcd.BitManipulation.SByteExtensions')

## SByteExtensions.AreNoBitsSet(this sbyte, BitMask) Method

Tests if none of the bits from the bitmask are set on a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte').

```csharp
public static bool AreNoBitsSet(this sbyte number, Jcd.BitManipulation.BitMask bitmask);
```

#### Parameters

<a name='Jcd.BitManipulation.SByteExtensions.AreNoBitsSet(thissbyte,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The data to inspect.

<a name='Jcd.BitManipulation.SByteExtensions.AreNoBitsSet(thissbyte,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bits to test.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if all of the bits from the bitmask were set.

### Remarks

NB: Only the lowest 8 bits of the bitmask will be used.
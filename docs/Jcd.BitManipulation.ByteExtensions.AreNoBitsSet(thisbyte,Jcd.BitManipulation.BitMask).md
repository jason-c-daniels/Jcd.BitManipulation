#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[ByteExtensions](Jcd.BitManipulation.ByteExtensions 'Jcd.BitManipulation.ByteExtensions')

## ByteExtensions.AreNoBitsSet(this byte, BitMask) Method

Tests if none of the bits from the bitmask are set on a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte').

```csharp
public static bool AreNoBitsSet(this byte number, Jcd.BitManipulation.BitMask bitmask);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteExtensions.AreNoBitsSet(thisbyte,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The data to inspect.

<a name='Jcd.BitManipulation.ByteExtensions.AreNoBitsSet(thisbyte,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bits to test.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if all of the bits from the bitmask were set.

### Remarks

NB: Only the lowest 8 bits of the bitmask will be used.
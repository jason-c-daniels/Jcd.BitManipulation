#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[ByteExtensions](Jcd.BitManipulation.ByteExtensions 'Jcd.BitManipulation.ByteExtensions')

## ByteExtensions.AreAnyBitsSet(this byte, BitMask) Method

Tests if any bits from the bitmask are set on a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte').

```csharp
public static bool AreAnyBitsSet(this byte number, Jcd.BitManipulation.BitMask bitmask);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteExtensions.AreAnyBitsSet(thisbyte,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The data to inspect.

<a name='Jcd.BitManipulation.ByteExtensions.AreAnyBitsSet(thisbyte,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bits to test.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if any of the bits from the bitmask were set.

### Remarks

NB: Only the lowest 8 bits of the bitmask will be used.
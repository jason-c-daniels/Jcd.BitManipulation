### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[AreAllBitsSetExtensions](Jcd.BitManipulation.AreAllBitsSetExtensions.md 'Jcd.BitManipulation.AreAllBitsSetExtensions')

## AreAllBitsSetExtensions.AreAllBitsSet(this byte, BitMask) Method

Tests if all of the bits from the bitmask are set on
a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte').

```csharp
public static bool AreAllBitsSet(this byte data, Jcd.BitManipulation.BitMask bitmask);
```

#### Parameters

<a name='Jcd.BitManipulation.AreAllBitsSetExtensions.AreAllBitsSet(thisbyte,Jcd.BitManipulation.BitMask).data'></a>

`data` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The data to inspect.

<a name='Jcd.BitManipulation.AreAllBitsSetExtensions.AreAllBitsSet(thisbyte,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the bits to test.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if all of the bits from the bitmask were set.

### Remarks

NB: Only the lowest 8 bits of the bitmask will be used.
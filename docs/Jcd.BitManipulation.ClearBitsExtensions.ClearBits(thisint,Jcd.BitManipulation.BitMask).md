### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ClearBitsExtensions](Jcd.BitManipulation.ClearBitsExtensions.md 'Jcd.BitManipulation.ClearBitsExtensions')

## ClearBitsExtensions.ClearBits(this int, BitMask) Method

Sets all bits from a provided mask to "off" and returns the modified value.

```csharp
public static int ClearBits(this int value, Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.ClearBitsExtensions.ClearBits(thisint,Jcd.BitManipulation.BitMask).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The value to be modified.

<a name='Jcd.BitManipulation.ClearBitsExtensions.ClearBits(thisint,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the bit mask of the bits to clear.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The modified value.
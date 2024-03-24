### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt64Extensions](Jcd.BitManipulation.UInt64Extensions.md 'Jcd.BitManipulation.UInt64Extensions')

## UInt64Extensions.ClearBits(this ulong, BitMask) Method

Sets all bits from a provided mask to "off" and returns the modified value.

```csharp
public static ulong ClearBits(this ulong value, Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.UInt64Extensions.ClearBits(thisulong,Jcd.BitManipulation.BitMask).value'></a>

`value` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value to be modified.

<a name='Jcd.BitManipulation.UInt64Extensions.ClearBits(thisulong,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the bit mask of the bits to clear.

#### Returns

[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The modified value.
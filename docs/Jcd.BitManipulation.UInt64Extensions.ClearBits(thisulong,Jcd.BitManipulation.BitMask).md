#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt64Extensions](Jcd.BitManipulation.UInt64Extensions.md 'Jcd.BitManipulation.UInt64Extensions')

## UInt64Extensions.ClearBits(this ulong, BitMask) Method

Sets all bits from the provided mask to "off" and returns the modified value.

```csharp
public static ulong ClearBits(this ulong number, Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt64Extensions.ClearBits(thisulong,Jcd.BitManipulation.BitMask).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value to modify.

<a name='Jcd.BitManipulation.UInt64Extensions.ClearBits(thisulong,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

The bit mask of the bits to clear.

#### Returns

[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The modified value.
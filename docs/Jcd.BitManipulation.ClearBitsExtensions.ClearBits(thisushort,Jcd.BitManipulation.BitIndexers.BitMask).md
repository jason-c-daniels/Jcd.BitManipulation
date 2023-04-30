#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ClearBitsExtensions](Jcd.BitManipulation.ClearBitsExtensions.md 'Jcd.BitManipulation.ClearBitsExtensions')

## ClearBitsExtensions.ClearBits(this ushort, BitMask) Method

Sets all bits from a provided mask to "off" and returns the modified value.

```csharp
public static ushort ClearBits(this ushort value, Jcd.BitManipulation.BitIndexers.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.ClearBitsExtensions.ClearBits(thisushort,Jcd.BitManipulation.BitIndexers.BitMask).value'></a>

`value` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The value to be modified.

<a name='Jcd.BitManipulation.ClearBitsExtensions.ClearBits(thisushort,Jcd.BitManipulation.BitIndexers.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitIndexers.BitMask.md 'Jcd.BitManipulation.BitIndexers.BitMask')

the bit mask of the bits to clear.

#### Returns
[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')  
The modified value.
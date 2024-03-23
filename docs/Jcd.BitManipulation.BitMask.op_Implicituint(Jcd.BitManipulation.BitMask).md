#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

## BitMask.implicit operator uint(BitMask) Operator

Automatically convert to [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

```csharp
public static uint implicit operator uint(Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.BitMask.op_Implicituint(Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

#### Returns

[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
the lowest 32 bits of the mask as a uint
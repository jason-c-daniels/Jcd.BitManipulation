#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

## BitMask.implicit operator sbyte(BitMask) Operator

Automatically convert to [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

```csharp
public static sbyte implicit operator sbyte(Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.BitMask.op_Implicitsbyte(Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') to convert from.

#### Returns

[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
the lowest 8 bits of the mask as a
signed [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.BitIndexers](Jcd.BitManipulation.BitIndexers.md 'Jcd.BitManipulation.BitIndexers').[BitMask](Jcd.BitManipulation.BitIndexers.BitMask.md 'Jcd.BitManipulation.BitIndexers.BitMask')

## BitMask.implicit operator byte(BitMask) Operator

Automatically convert to [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') from a [BitMask](Jcd.BitManipulation.BitIndexers.BitMask.md 'Jcd.BitManipulation.BitIndexers.BitMask')

```csharp
public static byte implicit operator byte(Jcd.BitManipulation.BitIndexers.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.BitIndexers.BitMask.op_Implicitbyte(Jcd.BitManipulation.BitIndexers.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitIndexers.BitMask.md 'Jcd.BitManipulation.BitIndexers.BitMask')

the [BitMask](Jcd.BitManipulation.BitIndexers.BitMask.md 'Jcd.BitManipulation.BitIndexers.BitMask') to convert from.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
the lowest 8 bits of the mask as a byte
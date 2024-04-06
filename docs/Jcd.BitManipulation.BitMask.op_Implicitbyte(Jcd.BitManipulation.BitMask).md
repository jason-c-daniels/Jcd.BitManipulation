#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

## BitMask.implicit operator byte(BitMask) Operator

Automatically convert to a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

```csharp
public static byte implicit operator byte(Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.BitMask.op_Implicitbyte(Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') to convert from.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
the lowest 8 bits of the mask as a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
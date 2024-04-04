#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

## BitMask.implicit operator int(BitMask) Operator

Automatically convert to [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

```csharp
public static int implicit operator int(Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.BitMask.op_Implicitint(Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') to convert from.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
the lowest 32 bits of the mask as a int
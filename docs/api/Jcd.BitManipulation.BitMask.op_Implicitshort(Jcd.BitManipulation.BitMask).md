#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

## BitMask.implicit operator short(BitMask) Operator

Automatically convert to a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') from a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

```csharp
public static short implicit operator short(Jcd.BitManipulation.BitMask mask);
```

#### Parameters

<a name='Jcd.BitManipulation.BitMask.op_Implicitshort(Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

the [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') to convert from.

#### Returns

[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')
the lowest 16 bits of the mask as a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')
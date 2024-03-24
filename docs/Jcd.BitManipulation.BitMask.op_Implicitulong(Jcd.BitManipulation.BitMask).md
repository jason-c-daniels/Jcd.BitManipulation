### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

## BitMask.implicit operator ulong(BitMask) Operator

Automatically convert to [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

```csharp
public static ulong implicit operator ulong(Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.BitMask.op_Implicitulong(Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

the [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') to convert from.

#### Returns
[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
the bits of the mask as a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
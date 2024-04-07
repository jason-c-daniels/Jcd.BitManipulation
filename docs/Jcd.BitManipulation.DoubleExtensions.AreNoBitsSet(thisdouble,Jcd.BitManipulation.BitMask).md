#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[DoubleExtensions](Jcd.BitManipulation.DoubleExtensions.md 'Jcd.BitManipulation.DoubleExtensions')

## DoubleExtensions.AreNoBitsSet(this double, BitMask) Method

Tests if none of the bits from the bitmask are set on a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').

```csharp
public static bool AreNoBitsSet(this double data, Jcd.BitManipulation.BitMask bitmask);
```

#### Parameters

<a name='Jcd.BitManipulation.DoubleExtensions.AreNoBitsSet(thisdouble,Jcd.BitManipulation.BitMask).data'></a>

`data` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The data to inspect.

<a name='Jcd.BitManipulation.DoubleExtensions.AreNoBitsSet(thisdouble,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

The bits to test.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if all of the bits from the bitmask were set.
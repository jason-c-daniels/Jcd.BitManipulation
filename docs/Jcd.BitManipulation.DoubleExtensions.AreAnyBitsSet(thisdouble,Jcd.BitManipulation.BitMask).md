#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[DoubleExtensions](Jcd.BitManipulation.DoubleExtensions 'Jcd.BitManipulation.DoubleExtensions')

## DoubleExtensions.AreAnyBitsSet(this double, BitMask) Method

Tests if any bits from the bitmask are set on a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').

```csharp
public static bool AreAnyBitsSet(this double data, Jcd.BitManipulation.BitMask bitmask);
```

#### Parameters

<a name='Jcd.BitManipulation.DoubleExtensions.AreAnyBitsSet(thisdouble,Jcd.BitManipulation.BitMask).data'></a>

`data` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The data to inspect.

<a name='Jcd.BitManipulation.DoubleExtensions.AreAnyBitsSet(thisdouble,Jcd.BitManipulation.BitMask).bitmask'></a>

`bitmask` [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')

The bits to test.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
True if any of the bits from the bitmask were set.
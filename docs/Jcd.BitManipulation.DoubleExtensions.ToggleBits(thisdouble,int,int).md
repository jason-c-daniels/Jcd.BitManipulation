#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[DoubleExtensions](Jcd.BitManipulation.DoubleExtensions.md 'Jcd.BitManipulation.DoubleExtensions')

## DoubleExtensions.ToggleBits(this double, int, int) Method

Toggles the specified range of bits and returns the modified value.

```csharp
public static double ToggleBits(this double value, int offset=0, int size=64);
```

#### Parameters

<a name='Jcd.BitManipulation.DoubleExtensions.ToggleBits(thisdouble,int,int).value'></a>

`value` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The value to modify.

<a name='Jcd.BitManipulation.DoubleExtensions.ToggleBits(thisdouble,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of the bits to toggle.

<a name='Jcd.BitManipulation.DoubleExtensions.ToggleBits(thisdouble,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to toggle.

#### Returns

[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')
The modified value.
#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[DoubleExtensions](Jcd.BitManipulation.DoubleExtensions.md 'Jcd.BitManipulation.DoubleExtensions')

## DoubleExtensions.SetBits(this double, int, int) Method

Sets all specified bits to 1 and returns the modified value.

```csharp
public static double SetBits(this double value, int offset=0, int size=64);
```

#### Parameters

<a name='Jcd.BitManipulation.DoubleExtensions.SetBits(thisdouble,int,int).value'></a>

`value` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The value to modify.

<a name='Jcd.BitManipulation.DoubleExtensions.SetBits(thisdouble,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.DoubleExtensions.SetBits(thisdouble,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to set on.

#### Returns

[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')
The modified value.
#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[BooleanArrayExtensions](Jcd.BitManipulation.BooleanArrayExtensions 'Jcd.BitManipulation.BooleanArrayExtensions')

## BooleanArrayExtensions.ToInt16(this bool[]) Method

Converts an array of bools into a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'), discarding any excess bits.

```csharp
public static short ToInt16(this bool[] bits);
```

#### Parameters

<a name='Jcd.BitManipulation.BooleanArrayExtensions.ToInt16(thisbool[]).bits'></a>

`bits` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The array of [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') values to convert. The Least Significant Bit is at index 0

#### Returns

[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')
The converted [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')
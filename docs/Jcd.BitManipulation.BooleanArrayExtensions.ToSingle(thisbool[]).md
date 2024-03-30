### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BooleanArrayExtensions](Jcd.BitManipulation.BooleanArrayExtensions.md 'Jcd.BitManipulation.BooleanArrayExtensions')

## BooleanArrayExtensions.ToSingle(this bool[]) Method

Converts an array of bools into a float, discarding any excess bits.

```csharp
public static float ToSingle(this bool[] bits);
```
#### Parameters

<a name='Jcd.BitManipulation.BooleanArrayExtensions.ToSingle(thisbool[]).bits'></a>

`bits` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The array of [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') values to convert. The Least Significant Bit is at index 0

#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')
The converted float
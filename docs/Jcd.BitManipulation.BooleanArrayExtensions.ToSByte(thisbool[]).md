#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BooleanArrayExtensions](Jcd.BitManipulation.BooleanArrayExtensions.md 'Jcd.BitManipulation.BooleanArrayExtensions')

## BooleanArrayExtensions.ToSByte(this bool[]) Method

Converts an array of bools into an [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte'), discarding any excess bits.

```csharp
public static sbyte ToSByte(this bool[] bits);
```
#### Parameters

<a name='Jcd.BitManipulation.BooleanArrayExtensions.ToSByte(thisbool[]).bits'></a>

`bits` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the array of bools to convert, Least Significant Bit at index 0

#### Returns

[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
The converted [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
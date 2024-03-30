### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BooleanArrayExtensions](Jcd.BitManipulation.BooleanArrayExtensions.md 'Jcd.BitManipulation.BooleanArrayExtensions')

## BooleanArrayExtensions.ToSByte(this bool[]) Method

Converts an array of bools into
an [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte'), discarding any excess bits.

```csharp
public static sbyte ToSByte(this bool[] bits);
```

#### Parameters

<a name='Jcd.BitManipulation.BooleanArrayExtensions.ToSByte(thisbool[]).bits'></a>

`bits` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The array of [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') values to
convert. The Least Significant Bit is at index 0

#### Returns

[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
The converted [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
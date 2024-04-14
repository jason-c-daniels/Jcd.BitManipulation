#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int64Extensions](Jcd.BitManipulation.Int64Extensions.md 'Jcd.BitManipulation.Int64Extensions')

## Int64Extensions.ToBooleanArray(this long) Method

Converts a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') into an array of values with the lease significant bit at index 0.

```csharp
public static bool[] ToBooleanArray(this long number);
```

#### Parameters

<a name='Jcd.BitManipulation.Int64Extensions.ToBooleanArray(thislong).number'></a>

`number` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') to convert.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
An array with the Least Significant Bit at index 0
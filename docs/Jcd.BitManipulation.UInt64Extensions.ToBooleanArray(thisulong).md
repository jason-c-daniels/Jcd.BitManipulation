#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[UInt64Extensions](Jcd.BitManipulation.UInt64Extensions 'Jcd.BitManipulation.UInt64Extensions')

## UInt64Extensions.ToBooleanArray(this ulong) Method

Converts a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') into an array of values with the lease significant bit at index 0.

```csharp
public static bool[] ToBooleanArray(this ulong number);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt64Extensions.ToBooleanArray(thisulong).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value to convert to an array of [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') values.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
An array with the Least Significant Bit at index 0
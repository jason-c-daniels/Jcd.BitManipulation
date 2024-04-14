#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[SingleExtensions](Jcd.BitManipulation.SingleExtensions.md 'Jcd.BitManipulation.SingleExtensions')

## SingleExtensions.ToBooleanArray(this float) Method

Converts a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single') into an array of values with the lease significant bit at index 0.

```csharp
public static bool[] ToBooleanArray(this float number);
```

#### Parameters

<a name='Jcd.BitManipulation.SingleExtensions.ToBooleanArray(thisfloat).number'></a>

`number` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The value to convert to an array of [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') values.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
the array. LSB at index 0
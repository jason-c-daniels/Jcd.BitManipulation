### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[SByteExtensions](Jcd.BitManipulation.SByteExtensions.md 'Jcd.BitManipulation.SByteExtensions')

## SByteExtensions.ToBooleanArray(this sbyte) Method

Converts a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') into an array of values with the lease significant bit at index 0.

```csharp
public static bool[] ToBooleanArray(this sbyte bits);
```

#### Parameters

<a name='Jcd.BitManipulation.SByteExtensions.ToBooleanArray(thissbyte).bits'></a>

`bits` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') to convert.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
An array with the Least Significant Bit at index 0
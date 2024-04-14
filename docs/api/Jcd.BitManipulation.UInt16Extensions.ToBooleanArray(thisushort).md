#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[UInt16Extensions](Jcd.BitManipulation.UInt16Extensions 'Jcd.BitManipulation.UInt16Extensions')

## UInt16Extensions.ToBooleanArray(this ushort) Method

Converts a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') into an array of values with the lease significant bit at index 0.

```csharp
public static bool[] ToBooleanArray(this ushort number);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt16Extensions.ToBooleanArray(thisushort).number'></a>

`number` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

the bits of the [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') to convert.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
An array with the Least Significant Bit at index 0
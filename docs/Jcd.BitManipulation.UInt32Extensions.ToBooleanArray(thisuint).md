#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt32Extensions](Jcd.BitManipulation.UInt32Extensions.md 'Jcd.BitManipulation.UInt32Extensions')

## UInt32Extensions.ToBooleanArray(this uint) Method

Converts a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') into an array of  values with the lease significant bit at index 0.

```csharp
public static bool[] ToBooleanArray(this uint bits);
```
#### Parameters

<a name='Jcd.BitManipulation.UInt32Extensions.ToBooleanArray(thisuint).bits'></a>

`bits` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') to convert.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
An array with the Least Significant Bit at index 0
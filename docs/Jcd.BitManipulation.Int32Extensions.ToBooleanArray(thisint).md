### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int32Extensions](Jcd.BitManipulation.Int32Extensions.md 'Jcd.BitManipulation.Int32Extensions')

## Int32Extensions.ToBooleanArray(this int) Method

Converts an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') into an array of  values with the lease significant bit at index 0.

```csharp
public static bool[] ToBooleanArray(this int bits);
```
#### Parameters

<a name='Jcd.BitManipulation.Int32Extensions.ToBooleanArray(thisint).bits'></a>

`bits` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') to convert.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
An array with the Least Significant Bit at index 0
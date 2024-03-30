### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ByteExtensions](Jcd.BitManipulation.ByteExtensions.md 'Jcd.BitManipulation.ByteExtensions')

## ByteExtensions.ToBooleanArray(this byte) Method

Converts a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') into an array of  values with the lease significant bit at index 0.

```csharp
public static bool[] ToBooleanArray(this byte bits);
```
#### Parameters

<a name='Jcd.BitManipulation.ByteExtensions.ToBooleanArray(thisbyte).bits'></a>

`bits` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The value to convert to an array of [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') values.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
An array with the Least Significant Bit at index 0
#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[DoubleExtensions](Jcd.BitManipulation.DoubleExtensions 'Jcd.BitManipulation.DoubleExtensions')

## DoubleExtensions.ToBooleanArray(this double) Method

Converts a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') into an array of  values with the lease significant bit at index 0..

```csharp
public static bool[] ToBooleanArray(this double bits);
```
#### Parameters

<a name='Jcd.BitManipulation.DoubleExtensions.ToBooleanArray(thisdouble).bits'></a>

`bits` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The value to convert to an array of [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') values.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
the array. LSB at index 0
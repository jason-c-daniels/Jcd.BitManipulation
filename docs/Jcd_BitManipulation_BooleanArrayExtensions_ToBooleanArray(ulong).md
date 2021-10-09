### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation').[BooleanArrayExtensions](Jcd_BitManipulation_BooleanArrayExtensions.md 'Jcd.BitManipulation.BooleanArrayExtensions')
## BooleanArrayExtensions.ToBooleanArray(ulong) Method
Convert a ulong into an array of bools  
```csharp
public static bool[] ToBooleanArray(this ulong bits);
```
#### Parameters
<a name='Jcd_BitManipulation_BooleanArrayExtensions_ToBooleanArray(ulong)_bits'></a>
`bits` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')  
the ulong to convert
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
the array. LSB at index 0

### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation').[BooleanArrayExtensions](Jcd_BitManipulation_BooleanArrayExtensions.md 'Jcd.BitManipulation.BooleanArrayExtensions')
## BooleanArrayExtensions.ToInt32(bool[]) Method
Converts an array of bools into an int, discarding any excess bits.  
```csharp
public static int ToInt32(this bool[] bits);
```
#### Parameters
<a name='Jcd_BitManipulation_BooleanArrayExtensions_ToInt32(bool__)_bits'></a>
`bits` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
the array of bools to convert, LSB at index 0
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The converted int

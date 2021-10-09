### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation').[BooleanArrayExtensions](Jcd_BitManipulation_BooleanArrayExtensions.md 'Jcd.BitManipulation.BooleanArrayExtensions')
## BooleanArrayExtensions.ToInt16(bool[]) Method
Converts an array of bools into a short, discarding any excess bits.  
```csharp
public static short ToInt16(this bool[] bits);
```
#### Parameters
<a name='Jcd_BitManipulation_BooleanArrayExtensions_ToInt16(bool__)_bits'></a>
`bits` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
the array of bools to convert, LSB at index 0
  
#### Returns
[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')  
The converted short

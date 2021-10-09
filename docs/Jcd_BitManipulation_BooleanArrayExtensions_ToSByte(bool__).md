### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation').[BooleanArrayExtensions](Jcd_BitManipulation_BooleanArrayExtensions.md 'Jcd.BitManipulation.BooleanArrayExtensions')
## BooleanArrayExtensions.ToSByte(bool[]) Method
Converts an array of bools into an sbyte, discarding any excess bits.  
```csharp
public static sbyte ToSByte(this bool[] bits);
```
#### Parameters
<a name='Jcd_BitManipulation_BooleanArrayExtensions_ToSByte(bool__)_bits'></a>
`bits` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
the array of bools to convert, LSB at index 0
  
#### Returns
[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')  
The converted sbyte

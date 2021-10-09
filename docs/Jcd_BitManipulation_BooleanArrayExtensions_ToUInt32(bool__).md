### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation').[BooleanArrayExtensions](Jcd_BitManipulation_BooleanArrayExtensions.md 'Jcd.BitManipulation.BooleanArrayExtensions')
## BooleanArrayExtensions.ToUInt32(bool[]) Method
Converts an array of bools into a uint, discarding any excess bits.  
```csharp
public static uint ToUInt32(this bool[] bits);
```
#### Parameters
<a name='Jcd_BitManipulation_BooleanArrayExtensions_ToUInt32(bool__)_bits'></a>
`bits` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
the array of bools to convert, LSB at index 0
  
#### Returns
[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The converted uint

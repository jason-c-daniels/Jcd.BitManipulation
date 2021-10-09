### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation').[ClearBitsExtensions](Jcd_BitManipulation_ClearBitsExtensions.md 'Jcd.BitManipulation.ClearBitsExtensions')
## ClearBitsExtensions.ClearBits(ulong, int, int) Method
Sets all specified bits to "off" in a variable.   
```csharp
public static void ClearBits(this ref ulong self, int offset=0, int size=64);
```
#### Parameters
<a name='Jcd_BitManipulation_ClearBitsExtensions_ClearBits(ulong_int_int)_self'></a>
`self` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')  
The value to be modified.
  
<a name='Jcd_BitManipulation_ClearBitsExtensions_ClearBits(ulong_int_int)_offset'></a>
`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The bit location to begin clearing bits.
  
<a name='Jcd_BitManipulation_ClearBitsExtensions_ClearBits(ulong_int_int)_size'></a>
`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of bits to clear on.
  

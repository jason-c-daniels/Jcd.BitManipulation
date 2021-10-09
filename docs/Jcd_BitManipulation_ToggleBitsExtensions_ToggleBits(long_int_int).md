### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation').[ToggleBitsExtensions](Jcd_BitManipulation_ToggleBitsExtensions.md 'Jcd.BitManipulation.ToggleBitsExtensions')
## ToggleBitsExtensions.ToggleBits(long, int, int) Method
Toggles bits in a variable, given a bit position and size.   
The default values result in toggling all bits.   
```csharp
public static void ToggleBits(this ref long self, int offset=0, int size=64);
```
#### Parameters
<a name='Jcd_BitManipulation_ToggleBitsExtensions_ToggleBits(long_int_int)_self'></a>
`self` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
The value to be modified.
  
<a name='Jcd_BitManipulation_ToggleBitsExtensions_ToggleBits(long_int_int)_offset'></a>
`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The offset of the bits to toggle.
  
<a name='Jcd_BitManipulation_ToggleBitsExtensions_ToggleBits(long_int_int)_size'></a>
`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of bits to toggle.
  

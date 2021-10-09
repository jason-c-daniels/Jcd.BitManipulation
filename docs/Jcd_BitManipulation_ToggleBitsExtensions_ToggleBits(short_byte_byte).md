### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation').[ToggleBitsExtensions](Jcd_BitManipulation_ToggleBitsExtensions.md 'Jcd.BitManipulation.ToggleBitsExtensions')
## ToggleBitsExtensions.ToggleBits(short, byte, byte) Method
Toggles bits in a variable, given a bit position and size.   
The default values result in toggling all bits.   
```csharp
public static void ToggleBits(this ref short self, byte offset=0, byte size=16);
```
#### Parameters
<a name='Jcd_BitManipulation_ToggleBitsExtensions_ToggleBits(short_byte_byte)_self'></a>
`self` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')  
The value to be modified.
  
<a name='Jcd_BitManipulation_ToggleBitsExtensions_ToggleBits(short_byte_byte)_offset'></a>
`offset` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The offset of the bits to toggle.
  
<a name='Jcd_BitManipulation_ToggleBitsExtensions_ToggleBits(short_byte_byte)_size'></a>
`size` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
The number of bits to toggle.
  

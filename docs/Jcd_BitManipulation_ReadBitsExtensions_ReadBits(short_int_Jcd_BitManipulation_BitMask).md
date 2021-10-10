### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation').[ReadBitsExtensions](Jcd_BitManipulation_ReadBitsExtensions.md 'Jcd.BitManipulation.ReadBitsExtensions')
## ReadBitsExtensions.ReadBits(short, int, BitMask) Method
Extract a subset of bits specified by a bitmask and right align the bits by the offset.   
```csharp
public static short ReadBits(this short self, int offset, Jcd.BitManipulation.BitMask mask);
```
#### Parameters
<a name='Jcd_BitManipulation_ReadBitsExtensions_ReadBits(short_int_Jcd_BitManipulation_BitMask)_self'></a>
`self` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')  
the source of bits to read
  
<a name='Jcd_BitManipulation_ReadBitsExtensions_ReadBits(short_int_Jcd_BitManipulation_BitMask)_offset'></a>
`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the bit offset to read from
  
<a name='Jcd_BitManipulation_ReadBitsExtensions_ReadBits(short_int_Jcd_BitManipulation_BitMask)_mask'></a>
`mask` [BitMask](Jcd_BitManipulation_BitMask.md 'Jcd.BitManipulation.BitMask')  
the bitmask of which bits to read.  
            Zeroed bits in the mask will always extract 0 from the source.  
            
  
#### Returns
[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')  
The right shifted value extracted from the value
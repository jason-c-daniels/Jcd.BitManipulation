### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation').[StoreBitsExtensions](Jcd_BitManipulation_StoreBitsExtensions.md 'Jcd.BitManipulation.StoreBitsExtensions')
## StoreBitsExtensions.StoreBits(uint, uint, int, BitMask) Method
Store a masked set of bits from a value to an offset in the destination  
The mask must apply to the destination bits.  
```csharp
public static void StoreBits(this ref uint self, uint value, int offset, Jcd.BitManipulation.BitMask mask);
```
#### Parameters
<a name='Jcd_BitManipulation_StoreBitsExtensions_StoreBits(uint_uint_int_Jcd_BitManipulation_BitMask)_self'></a>
`self` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
the destination for the stored bits
  
<a name='Jcd_BitManipulation_StoreBitsExtensions_StoreBits(uint_uint_int_Jcd_BitManipulation_BitMask)_value'></a>
`value` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
the source of the bits to store
  
<a name='Jcd_BitManipulation_StoreBitsExtensions_StoreBits(uint_uint_int_Jcd_BitManipulation_BitMask)_offset'></a>
`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the destination offset of where to store the bits
  
<a name='Jcd_BitManipulation_StoreBitsExtensions_StoreBits(uint_uint_int_Jcd_BitManipulation_BitMask)_mask'></a>
`mask` [BitMask](Jcd_BitManipulation_BitMask.md 'Jcd.BitManipulation.BitMask')  
the mask of which bits to store
  

### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation').[ReadBitsExtensions](Jcd_BitManipulation_ReadBitsExtensions.md 'Jcd.BitManipulation.ReadBitsExtensions')
## ReadBitsExtensions.ReadBits(int, int, int) Method
For a given value return the specified bits from within it, right shifted pos bits.  
```csharp
public static int ReadBits(this int self, int offset, int size);
```
#### Parameters
<a name='Jcd_BitManipulation_ReadBitsExtensions_ReadBits(int_int_int)_self'></a>
`self` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the source of bits to read
  
<a name='Jcd_BitManipulation_ReadBitsExtensions_ReadBits(int_int_int)_offset'></a>
`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the bit offset to read from
  
<a name='Jcd_BitManipulation_ReadBitsExtensions_ReadBits(int_int_int)_size'></a>
`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The total number of bits to extract
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The numeric value stored at that bit location

### [Jcd.BitManipulation](Jcd_BitManipulation.md 'Jcd.BitManipulation').[BitMask](Jcd_BitManipulation_BitMask.md 'Jcd.BitManipulation.BitMask')
## BitMask.CreateRange(int, int) Method
Create a 64 bit, bitmask of a specified bit size and bit location within the number.    
```csharp
public static Jcd.BitManipulation.BitMask CreateRange(int offset=0, int size=64);
```
#### Parameters
<a name='Jcd_BitManipulation_BitMask_CreateRange(int_int)_offset'></a>
`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the lowest bit to start turning on
  
<a name='Jcd_BitManipulation_BitMask_CreateRange(int_int)_size'></a>
`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the number of bits to set to 1
  
#### Returns
[BitMask](Jcd_BitManipulation_BitMask.md 'Jcd.BitManipulation.BitMask')  
the shifted mask

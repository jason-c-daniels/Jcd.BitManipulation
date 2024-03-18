### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[SetBitsExtensions](Jcd.BitManipulation.SetBitsExtensions.md 'Jcd.BitManipulation.SetBitsExtensions')

## SetBitsExtensions.SetBits(this ushort, int, int) Method

Sets all specified bits to "on"

```csharp
public static ushort SetBits(this ushort value, int offset=0, int size=16);
```
#### Parameters

<a name='Jcd.BitManipulation.SetBitsExtensions.SetBits(thisushort,int,int).value'></a>

`value` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The value to be modified.

<a name='Jcd.BitManipulation.SetBitsExtensions.SetBits(thisushort,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.SetBitsExtensions.SetBits(thisushort,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to set on.

#### Returns

[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')
The modified value.
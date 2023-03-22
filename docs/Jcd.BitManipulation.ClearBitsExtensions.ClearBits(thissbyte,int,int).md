### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ClearBitsExtensions](Jcd.BitManipulation.ClearBitsExtensions.md 'Jcd.BitManipulation.ClearBitsExtensions')

## ClearBitsExtensions.ClearBits(this sbyte, int, int) Method

Sets all specified bits to "off" in a variable.

```csharp
public static void ClearBits(this ref sbyte self, int offset=0, int size=8);
```
#### Parameters

<a name='Jcd.BitManipulation.ClearBitsExtensions.ClearBits(thissbyte,int,int).self'></a>

`self` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The value to be modified.

<a name='Jcd.BitManipulation.ClearBitsExtensions.ClearBits(thissbyte,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to begin clearing bits.

<a name='Jcd.BitManipulation.ClearBitsExtensions.ClearBits(thissbyte,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to clear on.
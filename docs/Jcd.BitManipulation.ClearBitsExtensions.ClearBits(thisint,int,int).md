### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ClearBitsExtensions](Jcd.BitManipulation.ClearBitsExtensions.md 'Jcd.BitManipulation.ClearBitsExtensions')

## ClearBitsExtensions.ClearBits(this int, int, int) Method

Sets all specified bits to "off" and returns the modified value.

```csharp
public static int ClearBits(this int value, int offset=0, int size=32);
```

#### Parameters

<a name='Jcd.BitManipulation.ClearBitsExtensions.ClearBits(thisint,int,int).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The value to be modified.

<a name='Jcd.BitManipulation.ClearBitsExtensions.ClearBits(thisint,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of where to begin clearing bits.

<a name='Jcd.BitManipulation.ClearBitsExtensions.ClearBits(thisint,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to clear.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The modified value.
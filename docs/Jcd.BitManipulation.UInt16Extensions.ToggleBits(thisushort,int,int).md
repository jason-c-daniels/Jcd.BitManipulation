### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt16Extensions](Jcd.BitManipulation.UInt16Extensions.md 'Jcd.BitManipulation.UInt16Extensions')

## UInt16Extensions.ToggleBits(this ushort, int, int) Method

Toggles the specified range of bits and returns the modified value.

```csharp
public static ushort ToggleBits(this ushort value, int offset=0, int size=16);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt16Extensions.ToggleBits(thisushort,int,int).value'></a>

`value` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The value to modify.

<a name='Jcd.BitManipulation.UInt16Extensions.ToggleBits(thisushort,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of the bits to toggle.

<a name='Jcd.BitManipulation.UInt16Extensions.ToggleBits(thisushort,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to toggle.

#### Returns

[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')
The modified value.
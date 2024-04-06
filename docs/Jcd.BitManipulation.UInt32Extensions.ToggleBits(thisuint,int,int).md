#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt32Extensions](Jcd.BitManipulation.UInt32Extensions.md 'Jcd.BitManipulation.UInt32Extensions')

## UInt32Extensions.ToggleBits(this uint, int, int) Method

Toggles the specified range of bits and returns the modified value.

```csharp
public static uint ToggleBits(this uint value, int offset=0, int size=32);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt32Extensions.ToggleBits(thisuint,int,int).value'></a>

`value` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The value to modify.

<a name='Jcd.BitManipulation.UInt32Extensions.ToggleBits(thisuint,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of the bits to toggle.

<a name='Jcd.BitManipulation.UInt32Extensions.ToggleBits(thisuint,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to toggle.

#### Returns

[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
The modified value.
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ToggleBitsExtensions](Jcd.BitManipulation.ToggleBitsExtensions.md 'Jcd.BitManipulation.ToggleBitsExtensions')

## ToggleBitsExtensions.ToggleBits(this ulong, int, int) Method

Toggles bits and size.
The default values result in toggling all bits.

```csharp
public static ulong ToggleBits(this ulong value, int offset=0, int size=64);
```
#### Parameters

<a name='Jcd.BitManipulation.ToggleBitsExtensions.ToggleBits(thisulong,int,int).value'></a>

`value` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value to be modified.

<a name='Jcd.BitManipulation.ToggleBitsExtensions.ToggleBits(thisulong,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of the bits to toggle.

<a name='Jcd.BitManipulation.ToggleBitsExtensions.ToggleBits(thisulong,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to toggle.

#### Returns

[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The modified value.
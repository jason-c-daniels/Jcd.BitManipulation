### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ToggleBitsExtensions](Jcd.BitManipulation.ToggleBitsExtensions.md 'Jcd.BitManipulation.ToggleBitsExtensions')

## ToggleBitsExtensions.ToggleBits(this ulong, BitMask) Method

Toggle all the bits in a variable according to the provided mask

```csharp
public static void ToggleBits(this ref ulong self, Jcd.BitManipulation.BitMask mask);
```
#### Parameters

<a name='Jcd.BitManipulation.ToggleBitsExtensions.ToggleBits(thisulong,Jcd.BitManipulation.BitMask).self'></a>

`self` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value to be modified.

<a name='Jcd.BitManipulation.ToggleBitsExtensions.ToggleBits(thisulong,Jcd.BitManipulation.BitMask).mask'></a>

`mask` [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

bits to set.
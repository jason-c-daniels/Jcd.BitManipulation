### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ToggleBitsExtensions](Jcd.BitManipulation.ToggleBitsExtensions.md 'Jcd.BitManipulation.ToggleBitsExtensions')

## ToggleBitsExtensions.ToggleBits(this sbyte, int, int) Method

Toggles bits in a variable, given a bit position and size.  
The default values result in toggling all bits.

```csharp
public static void ToggleBits(this ref sbyte self, int offset=0, int size=8);
```
#### Parameters

<a name='Jcd.BitManipulation.ToggleBitsExtensions.ToggleBits(thissbyte,int,int).self'></a>

`self` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The value to be modified.

<a name='Jcd.BitManipulation.ToggleBitsExtensions.ToggleBits(thissbyte,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of the bits to toggle.

<a name='Jcd.BitManipulation.ToggleBitsExtensions.ToggleBits(thissbyte,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to toggle.
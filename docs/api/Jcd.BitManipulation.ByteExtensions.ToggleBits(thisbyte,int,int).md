#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[ByteExtensions](Jcd.BitManipulation.ByteExtensions 'Jcd.BitManipulation.ByteExtensions')

## ByteExtensions.ToggleBits(this byte, int, int) Method

Toggles the specified range of bits and returns the modified value.

```csharp
public static byte ToggleBits(this byte number, int offset=0, int size=8);
```

#### Parameters

<a name='Jcd.BitManipulation.ByteExtensions.ToggleBits(thisbyte,int,int).number'></a>

`number` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The value to modify.

<a name='Jcd.BitManipulation.ByteExtensions.ToggleBits(thisbyte,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of the bits to toggle.

<a name='Jcd.BitManipulation.ByteExtensions.ToggleBits(thisbyte,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to toggle.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The modified value.
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[StoreBitsExtensions](Jcd.BitManipulation.StoreBitsExtensions.md 'Jcd.BitManipulation.StoreBitsExtensions')

## StoreBitsExtensions.StoreBits(this byte, byte, int, int) Method

Stores a value at the specified bit location within the variable.

```csharp
public static byte StoreBits(this byte value, byte source, int offset, int size);
```

#### Parameters

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisbyte,byte,int,int).value'></a>

`value` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The value to be modified.

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisbyte,byte,int,int).source'></a>

`source` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The value to be stored at the bit location.

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisbyte,byte,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisbyte,byte,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit size of the value.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
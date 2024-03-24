### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[SingleExtensions](Jcd.BitManipulation.SingleExtensions.md 'Jcd.BitManipulation.SingleExtensions')

## SingleExtensions.StoreBits(this float, uint, int, int) Method

Stores a value at the specified bit location within the variable.

```csharp
public static float StoreBits(this float value, uint source, int offset, int size);
```

#### Parameters

<a name='Jcd.BitManipulation.SingleExtensions.StoreBits(thisfloat,uint,int,int).value'></a>

`value` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The value to be modified.

<a name='Jcd.BitManipulation.SingleExtensions.StoreBits(thisfloat,uint,int,int).source'></a>

`source` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The value to be stored at the bit location.

<a name='Jcd.BitManipulation.SingleExtensions.StoreBits(thisfloat,uint,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.SingleExtensions.StoreBits(thisfloat,uint,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit size of the value.

#### Returns

[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')
The modified value.
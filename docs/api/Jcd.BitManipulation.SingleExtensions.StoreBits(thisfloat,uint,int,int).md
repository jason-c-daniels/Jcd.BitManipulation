#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[SingleExtensions](Jcd.BitManipulation.SingleExtensions 'Jcd.BitManipulation.SingleExtensions')

## SingleExtensions.StoreBits(this float, uint, int, int) Method

Stores a range of bits to the value, from a source value, and returns the modified value. The source value is left shifted by the offset before storing.

```csharp
public static float StoreBits(this float number, uint source, int offset, int size);
```

#### Parameters

<a name='Jcd.BitManipulation.SingleExtensions.StoreBits(thisfloat,uint,int,int).number'></a>

`number` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The value to modify.

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
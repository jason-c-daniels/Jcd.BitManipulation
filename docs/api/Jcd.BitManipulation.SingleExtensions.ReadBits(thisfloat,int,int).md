#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[SingleExtensions](Jcd.BitManipulation.SingleExtensions 'Jcd.BitManipulation.SingleExtensions')

## SingleExtensions.ReadBits(this float, int, int) Method

Reads the bits specified and returns the result shifted to the right by the offset.

```csharp
public static uint ReadBits(this float number, int offset, int size);
```

#### Parameters

<a name='Jcd.BitManipulation.SingleExtensions.ReadBits(thisfloat,int,int).number'></a>

`number` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The source of the bits to read.

<a name='Jcd.BitManipulation.SingleExtensions.ReadBits(thisfloat,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit offset to start reading from.

<a name='Jcd.BitManipulation.SingleExtensions.ReadBits(thisfloat,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total number of bits to extract.

#### Returns

[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
The value stored in the range of bits specified, right shifted by the offset.
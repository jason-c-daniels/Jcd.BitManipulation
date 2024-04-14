#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[UInt32Extensions](Jcd.BitManipulation.UInt32Extensions 'Jcd.BitManipulation.UInt32Extensions')

## UInt32Extensions.StoreBits(this uint, uint, int, int) Method

Stores a range of bits to the value, from a source value, and returns the modified value.

```csharp
public static uint StoreBits(this uint number, uint source, int offset, int size);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt32Extensions.StoreBits(thisuint,uint,int,int).number'></a>

`number` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The value to modify.

<a name='Jcd.BitManipulation.UInt32Extensions.StoreBits(thisuint,uint,int,int).source'></a>

`source` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The value to be stored at the bit location.

<a name='Jcd.BitManipulation.UInt32Extensions.StoreBits(thisuint,uint,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.UInt32Extensions.StoreBits(thisuint,uint,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit size of the value.

#### Returns

[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
The modified value.
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt32Extensions](Jcd.BitManipulation.UInt32Extensions.md 'Jcd.BitManipulation.UInt32Extensions')

## UInt32Extensions.StoreBits(this uint, uint, int, int) Method

Stores a value at the specified bit location within the variable.

```csharp
public static uint StoreBits(this uint value, uint source, int offset, int size);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt32Extensions.StoreBits(thisuint,uint,int,int).value'></a>

`value` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The value to be modified.

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